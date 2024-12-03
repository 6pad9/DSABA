using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DShipper
    {
        public List<Shipper> ListarTodo()
        {
            using (var context = new BDEFEntities())
            {
                context.Configuration.LazyLoadingEnabled = false;
                return context.Shipper.Where(s => s.IsDeleted == false).ToList();
            }
        }

        public string Registrar(Shipper shipper)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Shipper.Add(shipper);
                    context.SaveChanges();
                }
                return "Shipper registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Modificar(Shipper shipper)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Shipper shipperDB = context.Shipper.FirstOrDefault(s => s.Id.Equals(shipper.Id));
                    if (shipperDB != null)
                    {
                        shipperDB.CompanyName = shipper.CompanyName;
                        shipperDB.Phone = shipper.Phone;
                        shipperDB.UpdatedBy = shipper.UpdatedBy;
                        shipperDB.UpdatedAt = shipper.UpdatedAt;
                        context.SaveChanges();
                        return "Envio modificado correctamente";
                    }
                    else
                    {
                        return "Envio no encontrado";
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
                    Shipper shipperTemp = context.Shipper.Find(id);
                    if (shipperTemp != null)
                    {
                        context.Shipper.Remove(shipperTemp);
                        context.SaveChanges();
                        return "Envio eliminado correctamente";
                    }
                    else
                    {
                        return "Envio no encontrado";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarLogico(Shipper shipper)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var shipperTemp = context.Shipper.Find(shipper.Id);
                    if (shipperTemp != null)
                    {
                        shipperTemp.IsDeleted = true;
                        shipperTemp.UpdatedBy = shipper.UpdatedBy;
                        shipperTemp.UpdatedAt = shipper.UpdatedAt;
                        context.SaveChanges();
                        return "Envio eliminado correctamente";
                    }
                    else
                    {
                        return "Envio no encontrado";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Shipper> BuscarEnvios(string textoBuscar)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var enviosFiltrados = context.Shipper
                        .Where(p =>
                            (
                                p.CompanyName.ToLower().Contains(textoBuscar) ||
                                p.Phone.ToLower().Contains(textoBuscar) 
                            ) &&
                            p.IsDeleted.Equals(false)
                        ).ToList();
                    return enviosFiltrados;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Shipper> OrdenarEnvios(string criterioOrdenacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    List<Shipper> enviosOrdenados = context.Shipper.Where(e=>e.IsDeleted.Equals(false)).ToList();

                    switch (criterioOrdenacion)
                    {
                        case "Nombre de la Empresa":
                            enviosOrdenados = enviosOrdenados.OrderBy(p => p.CompanyName).ToList();
                            break;
                        case "Numero telefonico":
                            enviosOrdenados = enviosOrdenados.OrderBy(p => p.Phone).ToList();
                            break;
                        default:
                            break;
                    }
                    return enviosOrdenados;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
