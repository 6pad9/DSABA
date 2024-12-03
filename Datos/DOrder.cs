using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DOrder
    {
        public List<Order> ListarTodo()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Order.Where(o => o.IsDeleted.Equals(false)).ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<Order>();
            }
        }

        public string Registrar(Order order)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Order.Add(order);
                    context.SaveChanges();
                }
                return "Orden registrada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(Order order)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Order orderDB = context.Order.FirstOrDefault(o => o.Id.Equals(order.Id));
                    if (orderDB != null)
                    {
                        orderDB.Shipper_Id = order.Shipper_Id;
                        orderDB.Code = order.Code;
                        orderDB.Status = order.Status;
                        orderDB.Description = order.Description;
                        orderDB.UpdatedBy = order.UpdatedBy;
                        orderDB.UpdatedAt = order.UpdatedAt;
                        context.SaveChanges();
                        return "Orden modificada correctamente";
                    }
                    else
                    {
                        return "Orden no encontrada";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarFisico(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var orderTemp = context.Order.Find(id);
                    if (orderTemp != null)
                    {
                        context.Order.Remove(orderTemp);
                        context.SaveChanges();
                        return "Orden eliminada físicamente";
                    }
                    else
                    {
                        return "Orden no encontrada";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarLogico(Order order)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var orderTemp = context.Order.Find(order.Id);
                    if (orderTemp != null)
                    {
                        orderTemp.IsDeleted = true;
                        orderTemp.UpdatedBy = order.UpdatedBy;
                        orderTemp.UpdatedAt = order.UpdatedAt;
                        context.SaveChanges();
                        return "Orden eliminada lógicamente";
                    }
                    else
                    {
                        return "Orden no encontrada";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Order> BuscarOrdenes(string textoBuscar)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var ordenesFiltradas = context.Order
                        .Where(o =>
                            (
                                o.Code.ToLower().Contains(textoBuscar) ||
                                o.Status.ToLower().Contains(textoBuscar) ||
                                o.Description.ToLower().Contains(textoBuscar) ||
                                o.DateReceipt.ToString().Contains(textoBuscar)
                            ) &&
                            o.IsDeleted.Equals(false) 
                        ).ToList();
                    return ordenesFiltradas;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Order> OrdenarOrdenes(string criterioOrdenacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    List<Order> ordenesOrdenadas = context.Order.Where(o=>o.IsDeleted.Equals(false)).ToList();

                    switch (criterioOrdenacion)
                    {
                        case "Código":
                            ordenesOrdenadas = ordenesOrdenadas.OrderBy(p => p.Code).ToList();
                            break;
                        case "Descripción":
                            ordenesOrdenadas = ordenesOrdenadas.OrderBy(p => p.Description).ToList();
                            break;
                        case "Estado":
                            ordenesOrdenadas = ordenesOrdenadas.OrderBy(p => p.Status).ToList();
                            break;
                        case "Fecha de Emisión":
                            ordenesOrdenadas = ordenesOrdenadas.OrderBy(p => p.DateReceipt).ToList();
                            break;
                        default:
                            break;
                    }
                    return ordenesOrdenadas;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Order> ListarOrdenesPorCategoria(String criterioOrdenacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    List<Order> ordenesPorEstado = context.Order.ToList();


                    switch (criterioOrdenacion)
                    {
                        case "Pendiente":
                            ordenesPorEstado = ordenesPorEstado.Where(p => p.Status.Equals("Pendiente")).ToList();
                            break;
                        case "Enviado":
                            ordenesPorEstado = ordenesPorEstado.Where(p => p.Status.Equals("Enviado")).ToList();
                            break;
                        case "Completado":
                            ordenesPorEstado = ordenesPorEstado.Where(p => p.Status.Equals("Completado")).ToList();
                            break;
                        case "Cancelado":
                            ordenesPorEstado = ordenesPorEstado.Where(p => p.Status.Equals("Cancelado")).ToList();
                            break;
                        default:
                            break;
                    }
                    return ordenesPorEstado;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Order> OrdenarOrdenesPorCategoria(string criterioOrdenacion, string criterioOrdenarCategoria)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    List<Order> ordenesOrdenadas = ListarOrdenesPorCategoria(criterioOrdenarCategoria);

                    switch (criterioOrdenacion)
                    {
                        case "Código":
                            ordenesOrdenadas = ordenesOrdenadas.OrderBy(p => p.Code).ToList();
                            break;
                        case "Descripción":
                            ordenesOrdenadas = ordenesOrdenadas.OrderBy(p => p.Description).ToList();
                            break;
                        case "Estado":
                            ordenesOrdenadas = ordenesOrdenadas.OrderBy(p => p.Status).ToList();
                            break;
                        case "Fecha de Emisión":
                            ordenesOrdenadas = ordenesOrdenadas.OrderBy(p => p.DateReceipt).ToList();
                            break;
                        default:
                            break;
                    }
                    return ordenesOrdenadas;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public (List<Order>, decimal) ReporteVentasConDetalle(DateTime fechaInicio, DateTime? fechaFin = null)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var query = context.Order
                        .Where(o => o.Status == "Completado" &&
                                    o.IsDeleted == false &&
                                    o.DateReceipt >= fechaInicio);

                    if (fechaFin.HasValue)
                    {
                        query = query.Where(o => o.DateReceipt <= fechaFin.Value);
                    }

                    var ordenes = query.ToList();

                    var totalVentas = ordenes
                        .SelectMany(o => o.OrderDetail)
                        .Where(od => od.IsDeleted == false)
                        .Sum(od => (decimal?)(od.Quantity * od.Price)) ?? 0m;

                    return (ordenes, totalVentas);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar el reporte de ventas: " + ex.Message);
            }
        }

        public List<Order> ObtenerOrdenesPorId(int idOrder)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Order.Where(p => p.IsDeleted.Equals(false) &&
                                                      p.Id == idOrder).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Order> OrdenarReporteVentas(List<Order> ordenes, string criterioOrdenacion)
        {
            try
            {
                switch (criterioOrdenacion)
                {
                    case "Código":
                        return ordenes.OrderBy(o => o.Code).ToList();
                    case "Descripción":
                        return ordenes.OrderBy(o => o.Description).ToList();
                    case "Estado":
                        return ordenes.OrderBy(o => o.Status).ToList();
                    case "Fecha de Emisión":
                        return ordenes.OrderBy(o => o.DateReceipt).ToList();
                    default:
                        throw new ArgumentException("Criterio de ordenación no válido.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ordenar el reporte: " + ex.Message);
            }
        }

        public List<Order> BuscarReporteVentas(List<Order> ordenes, string textoBuscar)
        {
            try
            {
                if (ordenes == null || !ordenes.Any() || string.IsNullOrEmpty(textoBuscar))
                {
                    return ordenes; 
                }

                textoBuscar = textoBuscar.ToLower(); 
                var ordenesFiltradas = ordenes
                    .Where(o =>
                        (o.Code?.ToLower().Contains(textoBuscar) ?? false) ||
                        (o.Status?.ToLower().Contains(textoBuscar) ?? false) || 
                        (o.Description?.ToLower().Contains(textoBuscar) ?? false) ||
                        o.DateReceipt.ToString("yyyy-MM-dd").Contains(textoBuscar) 
                    )
                    .ToList();

                return ordenesFiltradas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar en el reporte de ventas: " + ex.Message);
            }
        }

    }
}
