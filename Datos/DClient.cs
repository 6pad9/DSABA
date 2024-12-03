using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Datos
{
    public class DClient
    {
        public List<Client> ListarTodo()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Client.Where(c => c.IsDeleted.Equals(false)).ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<Client>();
            }

        }

        public string Registrar(Client client)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    client.Password = HashPassword(client.Password);
                    context.Client.Add(client);
                    context.SaveChanges();
                }
                return "Cliente registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(Client client)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Client clientDB = context.Client.FirstOrDefault(c => c.Id.Equals(client.Id));
                    if (clientDB != null)
                    {
                        clientDB.Name = client.Name;
                        clientDB.Password = client.Password;
                        clientDB.Role = client.Role;
                        clientDB.Offset = client.Offset;
                        clientDB.UpdatedBy = client.UpdatedBy;
                        clientDB.UpdatedAt = client.UpdatedAt;
                        context.SaveChanges();
                        return "Cliente modificado correctamente";
                    }
                    else
                    {
                        return "Cliente no encontrado";
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
                    var clientTemp = context.Client.Find(id);
                    if (clientTemp != null)
                    {
                        context.Client.Remove(clientTemp);
                        context.SaveChanges();
                        return "Cliente eliminado correctamente";
                    }
                    else
                    {
                        return "Cliente no encontrado";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarLogico(Client client)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var clientTemp = context.Client.Find(client.Id);
                    if (clientTemp != null)
                    {
                        clientTemp.IsDeleted = true;
                        clientTemp.UpdatedBy = client.UpdatedBy;
                        clientTemp.UpdatedAt = client.UpdatedAt;
                        context.SaveChanges();
                        return "Cliente eliminado correctamente";
                    }
                    else { return "Cliente no encontrado"; }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Client Login(string username, string password)
        {
            using (var context = new BDEFEntities())
            {
                string hashedPassword = HashPassword(password);
                
                Client client = context.Client.FirstOrDefault(c => c.Name.Equals(username) && c.Password.Equals(hashedPassword));
                return client;
            }
        }

        public List<Client> BuscarUsuarios(string textoBuscar)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var usuariosFiltrados = context.Client
                        .Where(p =>
                            (
                                p.Name.ToLower().Contains(textoBuscar) ||
                                p.Role.ToLower().Contains(textoBuscar) ||
                                p.Offset.ToLower().Contains(textoBuscar) ||
                                p.Password.ToLower().Contains(textoBuscar) 
                            ) &&
                            p.IsDeleted.Equals(false)
                        ).ToList();
                    return usuariosFiltrados;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Client> OrdenarUsuarios(string criterioOrdenacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    List<Client> usuariosOrdenados = context.Client.Where(u=> u.IsDeleted.Equals(false)).ToList();

                    switch (criterioOrdenacion)
                    {
                        case "Nombre":
                            usuariosOrdenados = usuariosOrdenados.OrderBy(p => p.Name).ToList();
                            break;
                        case "Contraseña":
                            usuariosOrdenados = usuariosOrdenados.OrderBy(p => p.Password).ToList();
                            break;
                        case "Rol":
                            usuariosOrdenados = usuariosOrdenados.OrderBy(p => p.Role).ToList();
                            break;
                        case "Zona Horaria":
                            usuariosOrdenados = usuariosOrdenados.OrderBy(p => p.Offset).ToList();
                            break;
                        default:
                            break;
                    }
                    return usuariosOrdenados;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
