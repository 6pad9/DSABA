using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProduct
    {
        public List<Product> ListarTodo()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Product.Where(p => p.IsDeleted.Equals(false)).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string Registrar(Product product)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Product.Add(product);
                    context.SaveChanges();

                    var exists = context.Product.Any(p => p.Id == product.Id);
                    if (!exists)
                    {
                        return "Error: El producto no existe en la base de datos.";
                    }

                    var movimiento = new InventoryMovement
                    {
                        Product_Id = product.Id,
                        Order_Id = null,
                        Quantity = product.Quantity,
                        TypeMovement = "Entrada",
                        MovementDate = DateTime.UtcNow,
                        IsDeleted = false,
                        CreatedBy = product.CreatedBy,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedBy = product.UpdatedBy,
                        UpdatedAt = DateTime.UtcNow,
                        Remarks = $"Entrada de {product.Quantity} {product.Name}"
                    };

                    context.InventoryMovement.Add(movimiento);
                    context.SaveChanges();
                }
                return "Producto registrado con éxito y movimiento de inventario creado";
            }
            catch (Exception ex)
            {
                return "Error al registrar el producto: " + ex.Message;
            }
        }

        public string Modificar(Product product)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var prod = context.Product.FirstOrDefault(x => x.Id == product.Id);
                    if (prod != null)
                    {
                        int cantidadAnterior = prod.Quantity;

                        prod.Category_Id = product.Category_Id;
                        prod.Name = product.Name;
                        prod.Description = product.Description;
                        prod.Quantity = product.Quantity;
                        prod.Price = product.Price;
                        prod.MinimumStock = product.MinimumStock;
                        prod.UpdatedBy = product.UpdatedBy;
                        prod.UpdatedAt = product.UpdatedAt;

                        if(cantidadAnterior != product.Quantity)
                        {
                            var movimiento = new InventoryMovement
                            {
                                Product_Id = product.Id,
                                Order_Id = null,
                                Quantity = product.Quantity - cantidadAnterior,
                                TypeMovement = product.Quantity > cantidadAnterior ? "Entrada" : "Salida",
                                MovementDate = DateTime.UtcNow,
                                CreatedBy = product.UpdatedBy,
                                CreatedAt = DateTime.UtcNow,
                                UpdatedBy = product.UpdatedBy,
                                UpdatedAt = DateTime.UtcNow
                            };

                            context.InventoryMovement.Add(movimiento);
                        }
                  

                        context.SaveChanges();
                        return "Producto modificado con éxito y movimiento de inventario creado";

                    }
                    else
                    {
                        return "Producto no encontrado";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error al modificar el producto: " + ex.Message;
            }
        }


        public string EliminarFisico(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var product = context.Product.FirstOrDefault(p => p.Id == id);
                    if (product != null)
                    {
                        var movimientos = context.InventoryMovement.Where(m => m.Product_Id == id).ToList();
                        context.InventoryMovement.RemoveRange(movimientos);

                        context.Product.Remove(product);
                        context.SaveChanges();
                        return "Producto y movimientos de inventario eliminados correctamente";
                    }
                    return "No se encontró el producto";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string EliminarLogico(Product product)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var prod = context.Product.Find(product.Id);
                    if (prod != null)
                    {
                        prod.IsDeleted = true;
                        prod.UpdatedBy = product.UpdatedBy;
                        prod.UpdatedAt = product.UpdatedAt;

                        var movimientos = context.InventoryMovement
                            .Where(m => m.Product_Id == product.Id)
                            .ToList();
                        foreach (var movimiento in movimientos)
                        {
                            movimiento.IsDeleted = true;
                            movimiento.UpdatedAt = DateTime.Now;
                            movimiento.UpdatedBy = product.UpdatedBy;
                        }

                        context.SaveChanges();
                        return "Producto y movimientos eliminados lógicamente";
                    }
                    else
                    {
                        return "Producto no encontrado";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error al eliminar el producto: " + ex.Message;
            }
        }


        public List<Product> BuscarProductos(string textoBuscar)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var productosFiltrados = context.Product
                        .Where(p =>
                            (
                                p.Name.ToLower().Contains(textoBuscar) ||
                                p.Description.ToLower().Contains(textoBuscar) ||
                                p.Category.Name.ToLower().Contains(textoBuscar) ||
                                p.Quantity.ToString().Contains(textoBuscar) ||
                                p.Price.ToString().Contains(textoBuscar) ||
                                p.MinimumStock.ToString().Contains(textoBuscar)
                            ) &&
                            p.IsDeleted == false
                        )
                        .ToList();
                    return productosFiltrados;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


        public List<Product> OrdenarProductos(string criterioOrdenacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    List<Product> productosOrdenados = context.Product.Where(p => p.IsDeleted.Equals(false)).ToList();

                    switch (criterioOrdenacion)
                    {
                        case "Nombre":
                            productosOrdenados = productosOrdenados.OrderBy(p => p.Name).ToList();
                            break;
                        case "Descripción":
                            productosOrdenados = productosOrdenados.OrderBy(p => p.Description).ToList();
                            break;
                        case "Cantidad":
                            productosOrdenados = productosOrdenados.OrderBy(p => p.Quantity).ToList();
                            break;
                        case "Precio":
                            productosOrdenados = productosOrdenados.OrderBy(p => p.Price).ToList();
                            break;
                        case "Stock Minimo":
                            productosOrdenados = productosOrdenados.OrderBy(p => p.MinimumStock).ToList();
                            break;                       
                        default:
                            break;
                    }
                    return productosOrdenados;                    
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Product> ListarProductosStockMinimo()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Product.Where(p => p.IsDeleted.Equals(false)&&
                                                      p.Quantity<p.MinimumStock).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Product> OrdenarProductosStockMinimo(string criterioOrdenacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    List<Product> productosOrdenados = ListarProductosStockMinimo();

                    switch (criterioOrdenacion)
                    {
                        case "Precio":
                            productosOrdenados = productosOrdenados.OrderBy(p => p.Price).ToList();
                            break;
                        case "Cantidad":
                            productosOrdenados = productosOrdenados.OrderBy(p => p.Quantity).ToList();
                            break;
                        case "Nombre":
                            productosOrdenados = productosOrdenados.OrderBy(p => p.Name).ToList();
                            break;
                        default:
                            break;
                    }
                    return productosOrdenados;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Product> ObtenerProductoPorId(int idProduct)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.Product.Where(p => p.IsDeleted.Equals(false) &&
                                                      p.Id == idProduct).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
