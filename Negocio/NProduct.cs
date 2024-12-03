using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProduct
    {
        private static DProduct dProduct = new DProduct();

        public List<Product> ListarTodo()
        {
            return dProduct.ListarTodo();
        }

        public string Registrar(Product product)
        {
            return dProduct.Registrar(product);
        }

        public string Modificar(Product product)
        {
            return dProduct.Modificar(product);
        }

        public string EliminarFisico(int id)
        {
            return dProduct.EliminarFisico(id);
        }

        public string EliminarLogico(Product product)
        {
            return dProduct.EliminarLogico(product);
        }

        public List<Product> BuscarProductos(string textoBuscar)
        {
            return dProduct.BuscarProductos(textoBuscar);
        }

        public List<Product> OrdenarProductos(string criterioOrdenacion)
        {
            return dProduct.OrdenarProductos(criterioOrdenacion);
        }

        public List<Product> ListarProductosStockMinimo()
        {
           return dProduct.ListarProductosStockMinimo();
        }

        public List<Product> OrdenarProductosStockMinimo(string criterioOrdenacion)
        {
            return dProduct.OrdenarProductosStockMinimo(criterioOrdenacion);
        }

        public List<Product> ObtenerProductoPorId(int idProduct)
        {
           return dProduct.ObtenerProductoPorId(idProduct);
        }
    }
}
