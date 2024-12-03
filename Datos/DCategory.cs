using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DCategory
    {
        public List<Category> ListarTodo()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Category.Where(c => c.IsDeleted.Equals(false)).ToList();
                }
            }
            catch (Exception)
            {
                return new List<Category>();
            }
        }

        public string Registrar(Category category)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Category.Add(category);
                    context.SaveChanges();
                }
                return "Categoría registrada correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(Category category)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Category categoryDB = context.Category.FirstOrDefault(c => c.Id.Equals(category.Id));
                    if (categoryDB != null)
                    {
                        categoryDB.Name = category.Name;
                        categoryDB.Description = category.Description;
                        categoryDB.UpdatedBy = category.UpdatedBy;
                        categoryDB.UpdatedAt = category.UpdatedAt;
                        context.SaveChanges();
                        return "Categoría modificada correctamente";
                    }
                    else
                    {
                        return "Categoría no encontrada";
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
                    var categoryTemp = context.Category.Find(id);
                    if (categoryTemp != null)
                    {
                        context.Category.Remove(categoryTemp);
                        context.SaveChanges();
                        return "Categoría eliminada físicamente";
                    }
                    else
                    {
                        return "Categoría no encontrada";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string EliminarLogico(Category category)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var categoryTemp = context.Category.Find(category.Id);
                    if (categoryTemp != null)
                    {
                        categoryTemp.IsDeleted = true;
                        categoryTemp.UpdatedBy = category.UpdatedBy;
                        categoryTemp.UpdatedAt = category.UpdatedAt;
                        context.SaveChanges();
                        return "Categoría eliminada lógicamente";
                    }
                    return "Categoría no encontrada";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Category> BuscarCategorias(string textoBuscar)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var categoriasFiltradas = context.Category
                        .Where(p =>
                            (
                                p.Name.ToLower().Contains(textoBuscar) ||
                                p.Description.ToLower().Contains(textoBuscar)
                            ) &&
                            p.IsDeleted.Equals(false)
                        ).ToList();
                    return categoriasFiltradas;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


        public List<Category> OrdenarCategorias(string criterioOrdenacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var categoriasOrdenadas = context.Category.Where(c => c.IsDeleted.Equals(false)).ToList();

                    switch (criterioOrdenacion)
                    {
                        case "Nombre":
                            categoriasOrdenadas = categoriasOrdenadas.OrderBy(p => p.Name).ToList();
                            break;
                        case "Descripción":
                            categoriasOrdenadas = categoriasOrdenadas.OrderBy(p => p.Description).ToList();
                            break;
                        default:
                            break;
                    }
                    return categoriasOrdenadas;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
