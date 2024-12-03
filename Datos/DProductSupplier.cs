using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DProductSupplier
    {
        public List<ProductSupplier> ListarTodo()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.ProductSupplier.Where(p => p.IsDeleted.Equals(false)).ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<ProductSupplier>();
            }
        }

        public List<ProductSupplier> ListarPorProveedor(int idSupplier)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.ProductSupplier.Where(p => p.IsDeleted.Equals(false) &&
                                                              p.Supplier_Id.Equals(idSupplier)).ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<ProductSupplier>();
            }
        }

        public string Registrar(ProductSupplier productDetail)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.ProductSupplier.Add(productDetail);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Modificar(ProductSupplier productDetail)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    ProductSupplier productDetailTemp = context.ProductSupplier.FirstOrDefault(p => p.Id.Equals(productDetail.Id));
                    if (productDetailTemp != null)
                    {
                        productDetailTemp.Product_Id = productDetail.Product_Id;
                        productDetailTemp.Supplier_Id = productDetail.Supplier_Id;
                        productDetailTemp.Detail = productDetail.Detail;
                        productDetailTemp.UpdatedBy = productDetail.UpdatedBy;
                        productDetailTemp.UpdatedAt = productDetail.UpdatedAt;
                        context.SaveChanges();
                        return "Modificado correctamente";
                    }
                    else
                    {
                        return "No se encontro el registro";
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
                    var productDetailTemp = context.ProductSupplier.Find(id);
                    if (productDetailTemp != null)
                    {
                        context.ProductSupplier.Remove(productDetailTemp);
                        context.SaveChanges();
                        return "Eliminado correctamente";
                    }
                    else
                    {
                        return "No se encontro el registro";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string EliminarLogico(ProductSupplier productDetail)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var productDetailTemp = context.ProductSupplier.Find(productDetail.Id);
                    if (productDetailTemp != null)
                    {
                        productDetailTemp.IsDeleted = true;
                        productDetailTemp.UpdatedBy = productDetail.UpdatedBy;
                        productDetailTemp.UpdatedAt = productDetail.UpdatedAt;
                        context.SaveChanges();
                        return "Eliminado correctamente";
                    }
                    else
                    {
                        return "No se encontro el registro";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
