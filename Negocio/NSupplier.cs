using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NSupplier
    {
        private static DSupplier dSupplier = new DSupplier();

        public List<Supplier> ListarTodo()
        {
            return dSupplier.ListarTodo();
        }

        public string Registrar(Supplier supplier)
        {
            return dSupplier.Registrar(supplier);
        }

        public string Modificar(Supplier supplier) 
        {
            return dSupplier.Modificar(supplier);
        }

        public string EliminarFisico(int id)
        {
            return dSupplier.EliminarFisico(id);
        }
        public string EliminarLogico(Supplier supplier)
        {
            return dSupplier.EliminarLogico(supplier);
        }

        public List<Supplier> BuscarProveedores(string textoBuscar)
        {
           return dSupplier.BuscarProveedores(textoBuscar);
        }

        public List<Supplier> OrdenarProveedores(string criterioOrdenacion)
        {
            return dSupplier.OrdenarProveedores(criterioOrdenacion);
        }

        public List<Supplier> ListarTodoPorId(int id)
        {
            return dSupplier.ListarTodoPorId(id);
        }
    }
}
