using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NInventoryMovement
    {
        private static DInventoryMovement dInventoryMovement = new DInventoryMovement();

        public List<InventoryMovement> ListarTodo()
        {
            return dInventoryMovement.ListarTodo();
        }

        public List<InventoryMovement> ListarPorTipo(string tipo)
        {
            return dInventoryMovement.ListarPorTipo(tipo);
        }

        public List<InventoryMovement> BuscarMovimientosDeInventario(string textoBuscar)
        {
           return dInventoryMovement.BuscarMovimientosDeInventario(textoBuscar);
        }


        public List<InventoryMovement> OrdenarMovimientosDeInventario(string criterioOrdenacion)
        {
            return dInventoryMovement.OrdenarMovimientosDeInventario(criterioOrdenacion);
        }
    }
}
