using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NOrder
    {
        private DOrder dOrder = new DOrder();

        public List<Order> ListarTodo()
        {
            return dOrder.ListarTodo();
        }

        public string Registrar(Order order)
        {
            return dOrder.Registrar(order);
        }

        public string Modificar(Order order)
        {
            return dOrder.Modificar(order);
        }

        public string EliminarFisico(int id)
        {
            return dOrder.EliminarFisico(id);
        }

        public string EliminarLogico(Order order)
        {
            return dOrder.EliminarLogico(order);
        }

        public List<Order> BuscarOrdenes(string textoBuscar)
        {
            return dOrder.BuscarOrdenes(textoBuscar);
        }

        public List<Order> OrdenarOrdenes(string criterioOrdenacion)
        {
            return dOrder.OrdenarOrdenes(criterioOrdenacion);
        }

        public List<Order> ListarOrdenesPorCategoria(String criterioOrdenacion)
        {
            return dOrder.ListarOrdenesPorCategoria(criterioOrdenacion);
        }

        public List<Order> OrdenarOrdenesPorCategoria(string criterioOrdenacion, string criterioOrdenarCategoria)
        {
           return dOrder.OrdenarOrdenesPorCategoria(criterioOrdenacion, criterioOrdenarCategoria);
        }

        public List<Order> ObtenerOrdenesPorId(int idOrder)
        {
            return dOrder.ObtenerOrdenesPorId(idOrder);
        }

        public (List<Order>, decimal) ReporteVentasConDetalle(DateTime fechaInicio, DateTime? fechaFin = null)
        {
            return dOrder.ReporteVentasConDetalle(fechaInicio, fechaFin);
        }

        public List<Order> OrdenarReporteVentas(List<Order> ordenes, string criterioOrdenacion)
        {
           return dOrder.OrdenarReporteVentas(ordenes, criterioOrdenacion);
        }

        public List<Order> BuscarReporteVentas(List<Order> ordenes, string textoBuscar)
        {
           return dOrder.BuscarReporteVentas(ordenes, textoBuscar);
        }
    }
}
