using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DOrderDetail
    {
        public List<OrderDetail> ListarTodo()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.OrderDetail.Where(o => o.IsDeleted.Equals(false)).ToList();
                }
            }
            catch (Exception)
            {
                return new List<OrderDetail>();
            }
        }

        public string Registrar(OrderDetail orderDetail)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var product = context.Product.Find(orderDetail.Product_Id);
                    if (product == null)
                        return "Producto no encontrado";

                    if (product.Quantity < orderDetail.Quantity)
                        return "Cantidad insuficiente en inventario";

                    context.OrderDetail.Add(orderDetail);

                    product.Quantity -= orderDetail.Quantity;

                    var order = context.Order.FirstOrDefault(o => o.Id == orderDetail.Order_Id);
                    if (order == null)
                        return "Orden no encontrada";


                    var movimiento = new InventoryMovement
                    {
                        Product_Id = orderDetail.Product_Id,
                        Order_Id = orderDetail.Order_Id,
                        Quantity = orderDetail.Quantity,
                        TypeMovement = "Salida",
                        MovementDate = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = orderDetail.CreatedBy,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedBy = orderDetail.UpdatedBy,
                        UpdatedAt = DateTime.UtcNow,
                        Remarks = $"Salida de {product.Name} por la orden con código {order.Code}"
                    };

                    context.InventoryMovement.Add(movimiento);

                    context.SaveChanges();
                    return "Orden registrada y movimiento de inventario creado";
                }
            }
            catch (Exception ex)
            {
                return "Error al registrar la orden: " + ex.Message;
            }
        }


        public string Modificar(OrderDetail orderDetail)
        {
            try
            {
                if (orderDetail == null || orderDetail.Id <= 0)
                    return "El registro es inválido o no tiene un ID válido.";

                using (var context = new BDEFEntities())
                {
                    OrderDetail orderDetailTemp = context.OrderDetail.FirstOrDefault(o => o.Id == orderDetail.Id);
                    if (orderDetailTemp == null)
                        return "No se encontró el registro.";

                    var product = context.Product.Find(orderDetail.Product_Id);
                    if (product == null)
                        return "Producto no encontrado";

                    int cantidadAnterior = orderDetailTemp.Quantity;
                    int diferenciaCantidad = orderDetail.Quantity - cantidadAnterior;

                    orderDetailTemp.Product_Id = orderDetail.Product_Id;
                    orderDetailTemp.Quantity = orderDetail.Quantity;
                    orderDetailTemp.DateReceipt = orderDetail.DateReceipt;
                    orderDetailTemp.Price = orderDetail.Price;
                    orderDetailTemp.UpdatedAt = orderDetail.UpdatedAt;
                    orderDetailTemp.UpdatedBy = orderDetail.UpdatedBy;

                    if (diferenciaCantidad != 0)
                    {
                        if (product.Quantity + cantidadAnterior < orderDetail.Quantity)
                            return "Cantidad insuficiente en inventario para realizar la modificación.";

                        product.Quantity -= diferenciaCantidad;

                        var typeMovement = diferenciaCantidad > 0 ? "Salida" : "Entrada";

                        var movimiento = new InventoryMovement
                        {
                            Product_Id = orderDetail.Product_Id,
                            Order_Id = orderDetail.Order_Id,
                            Quantity = Math.Abs(diferenciaCantidad),
                            TypeMovement = typeMovement,
                            MovementDate = DateTime.UtcNow,
                            IsDeleted = false,
                            CreatedBy = orderDetail.UpdatedBy,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedBy = orderDetail.UpdatedBy,
                            UpdatedAt = DateTime.UtcNow,
                            Remarks = $"{typeMovement} de {product.Name} por modificación de la orden {orderDetail.Order_Id}"
                        };

                        context.InventoryMovement.Add(movimiento);
                    }

                    context.SaveChanges();
                    return "Detalle de orden y movimiento de inventario modificados correctamente";
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar la orden: " + ex.Message;
            }
        }


        public string EliminarFisico(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var orderDetail = context.OrderDetail.FirstOrDefault(o => o.Id == id);
                    if (orderDetail != null)
                    {
                        var movimientos = context.InventoryMovement.Where(m => m.Order_Id == orderDetail.Order_Id && 
                                                                               m.Product_Id == orderDetail.Product_Id).ToList();
                        context.InventoryMovement.RemoveRange(movimientos);
                        context.OrderDetail.Remove(orderDetail);
                        context.SaveChanges();
                        return "Detalle de orden y movimientos de inventario eliminados correctamente";
                    }
                    return "No se encontró el detalle de orden";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string EliminarLogico(OrderDetail orderDetail)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var orderDetailTemp = context.OrderDetail.Find(orderDetail.Id);
                    if (orderDetailTemp != null)
                    {
                        orderDetailTemp.IsDeleted = true;
                        orderDetailTemp.UpdatedAt = orderDetail.UpdatedAt;
                        orderDetailTemp.UpdatedBy = orderDetail.UpdatedBy;

                        var movimientos = context.InventoryMovement.Where(m => m.Order_Id == orderDetail.Order_Id && 
                                                                               m.Product_Id == orderDetail.Product_Id).ToList();
                        foreach (var movimiento in movimientos)
                        {
                            movimiento.IsDeleted = true;
                            movimiento.UpdatedAt = orderDetail.UpdatedAt;
                            movimiento.UpdatedBy = orderDetail.UpdatedBy;
                        }

                        context.SaveChanges();
                        return "Se orden y moviminetos eliminaron lógicamente";
                    }
                    else
                    {
                        return "No se encontro el registro";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<OrderDetail> ObtenerOrdenesPorId(int idOrder)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.OrderDetail.Where(p => p.IsDeleted.Equals(false) &&
                                                      p.Order_Id == idOrder).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
