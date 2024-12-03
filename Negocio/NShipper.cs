using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NShipper
    {
        private static DShipper dShipper = new DShipper();

        public List<Shipper> ListarTodo()
        {
            return dShipper.ListarTodo();
        }
        public string Registrar(Shipper shipper)
        {
            return dShipper.Registrar(shipper);
        }

        public string Modificar(Shipper shipper)
        {
            return dShipper.Modificar(shipper);
        }

        public string EliminarFisico(int id)
        {
            return dShipper.EliminarFisico(id);
        }

        public string ELiminarLogico(Shipper shipper) 
        {
            return dShipper.EliminarLogico(shipper);
        }

        public List<Shipper> BuscarEnvios(string nombre)
        {
            return dShipper.BuscarEnvios(nombre);
        }

        public List<Shipper> OrdenarEnvios(string nombre)
        {
            return dShipper.OrdenarEnvios(nombre);
        }
    }
}
