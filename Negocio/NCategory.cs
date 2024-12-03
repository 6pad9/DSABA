using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NCategory
    {
        private static DCategory dCategory = new DCategory();

        public List<Category> ListarTodo()
        {
            return dCategory.ListarTodo();
        }

        public string Registrar(Category category)
        {
            return dCategory.Registrar(category);
        }

        public string Modificar(Category category)
        {
            return dCategory.Modificar(category);
        }

        public string EliminarFisico(int id)
        {
            return dCategory.EliminarFisico(id);
        }

        public string EliminarLogico(Category category)
        {
            return dCategory.EliminarLogico(category);
        }

        public List<Category> BuscarCategorias(string textoBuscar)
        {
            return dCategory.BuscarCategorias(textoBuscar);
        }

        public List<Category> OrdenarCategorias(string criterioOrdenacion)
        {
            return dCategory.OrdenarCategorias(criterioOrdenacion);
        }
    }
}
