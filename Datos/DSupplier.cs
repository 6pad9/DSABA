using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DSupplier
    {
        public List<Supplier> ListarTodo()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Supplier.Where(s => s.IsDeleted.Equals(false)).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Supplier> ListarTodoPorId(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Supplier.Where(s => s.IsDeleted.Equals(false) &&
                                                       s.Id.Equals(id)).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Registrar(Supplier supplier)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Supplier.Add(supplier);
                    context.SaveChanges();
                }
                return "Proveedor registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(Supplier supplier)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Supplier supplierDB = context.Supplier.FirstOrDefault(s => s.Id.Equals(supplier.Id));
                    if (supplierDB != null)
                    {
                        supplierDB.Name = supplier.Name;
                        supplierDB.Phone = supplier.Phone;
                        supplierDB.UpdatedAt = supplier.UpdatedAt;
                        supplierDB.UpdatedBy = supplier.UpdatedBy;
                        context.SaveChanges();
                        return "Proveedor modificado correctamente";
                    }
                    else
                    {
                        return "Proveedor no encontrado";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarLogico(Supplier supplier)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Supplier supplierTemp = context.Supplier.Find(supplier.Id);
                    if (supplierTemp != null)
                    {
                        supplierTemp.IsDeleted = true;
                        supplierTemp.UpdatedAt = supplier.UpdatedAt;
                        supplierTemp.UpdatedBy = supplier.UpdatedBy;
                        context.SaveChanges();
                        return "Proveedor eliminado correctamente";
                    }
                    else
                    {
                        return "Proveedor no encontrado";
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
                    Supplier supplierTemp = context.Supplier.Find(id);
                    if (supplierTemp != null)
                    {
                        context.Supplier.Remove(supplierTemp);
                        context.SaveChanges();
                        return "Proveedor eliminado correctamente";
                    }
                    else
                    {
                        return "Proveedor no encontrado";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Supplier> BuscarProveedores(string textoBuscar)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var proveedoresFiltrados = context.Supplier
                        .Where(p =>
                            (
                                p.Name.ToLower().Contains(textoBuscar) ||
                                p.Phone.ToLower().Contains(textoBuscar)
                             ) &&
                             p.IsDeleted.Equals(false)
                        ).ToList();
                    return proveedoresFiltrados;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Supplier> OrdenarProveedores(string criterioOrdenacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    List<Supplier> proveedoresOrdenados = context.Supplier.Where(p=>p.IsDeleted.Equals(false)).ToList();

                    switch (criterioOrdenacion)
                    {
                        case "Nombre":
                            proveedoresOrdenados = proveedoresOrdenados.OrderBy(p => p.Name).ToList();
                            break;
                        case "Teléfono":
                            proveedoresOrdenados = proveedoresOrdenados.OrderBy(p => p.Phone).ToList();
                            break;
                        default:
                            break;
                    }
                    return proveedoresOrdenados;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
