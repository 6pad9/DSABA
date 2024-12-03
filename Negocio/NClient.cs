using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class NClient
    {
        private DClient dClient = new DClient();
        private static Client clientLogIn = null;

        public List<Client> ListarTodo()
        {
            return dClient.ListarTodo();
        }

        public string Registrar(Client client)
        {
            return dClient.Registrar(client);
        }

        public string Modificar(Client client)
        {
            return dClient.Modificar(client);
        }

        public string EliminarFisico(int id)
        {
            return dClient.EliminarFisico(id);
        }

        public string EliminarLogico(Client client)
        {
            return dClient.EliminarLogico(client);
        }

        public List<Client> BuscarUsuarios(string textoBuscar)
        {
            return dClient.BuscarUsuarios(textoBuscar);
        }

        public List<Client> OrdenarUsuarios(string criterioOrdenacion)
        {
            return dClient.OrdenarUsuarios(criterioOrdenacion);
        }

        public Client Login(string username, string password)
        {
            clientLogIn = dClient.Login(username, password);
            return clientLogIn;
        }

        public static Client UsuarioLogueado()
        {
            return clientLogIn;
        }

        
    }
}
