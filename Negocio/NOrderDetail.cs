using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NOrderDetail
    {
        private static DOrderDetail dOrderDetail = new DOrderDetail();
        private static DInventoryMovement dInventoryMovement = new DInventoryMovement();

        public List<OrderDetail> ListarTodo()
        {
            return dOrderDetail.ListarTodo();
        }

        public string Registrar(OrderDetail orderDetail)
        {
            return dOrderDetail.Registrar(orderDetail);
        }

        public string Modificar(OrderDetail orderDetail)
        {
           return dOrderDetail.Modificar(orderDetail);
        }

        public string EliminarFisico(int id)
        {
            return dOrderDetail.EliminarFisico(id);
        }

        public string EliminarLogico(OrderDetail orderDetail)
        {
            return dOrderDetail.EliminarLogico(orderDetail);
        }

        public List<OrderDetail> ObtenerOrdenesPorId(int idOrderDetail)
        {
            return dOrderDetail.ObtenerOrdenesPorId(idOrderDetail);
        }
    }
}
