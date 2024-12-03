using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProductSupplier
    {
        private static DProductSupplier dProductDetail = new DProductSupplier();

        public List<ProductSupplier> ListarTodo()
        {
            return dProductDetail.ListarTodo();
        }

        public List<ProductSupplier> ListarPorProveedor(int idProveedor)
        {
            return dProductDetail.ListarPorProveedor(idProveedor);
        }

        public string Registrar(ProductSupplier productDetail)
        {
            return dProductDetail.Registrar(productDetail);
        }

        public string Modificar(ProductSupplier productDetail)
        {
            return dProductDetail.Modificar(productDetail);
        }

        public string EliminarFisico(int id)
        {
            return dProductDetail.EliminarFisico(id);
        }

        public string EliminarLogico(ProductSupplier productDetail)
        {
            return dProductDetail.EliminarLogico(productDetail);
        }
    }
}
