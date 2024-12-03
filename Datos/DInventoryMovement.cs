using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DInventoryMovement
    {
        public List<InventoryMovement> ListarTodo()
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    return context.InventoryMovement.Where(i => i.IsDeleted.Equals(false)).ToList();
                }
            }
            catch (Exception)
            {
                return new List<InventoryMovement>();
            }
        }

        public List<InventoryMovement> ListarPorTipo(string tipo)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    return context.InventoryMovement
                                  .Where(m => m.TypeMovement == tipo && !m.IsDeleted)
                                  .ToList();
                }
            }
            catch (Exception)
            {
                return new List<InventoryMovement>();

            }
        }

        public List<InventoryMovement> BuscarMovimientosDeInventario(string textoBuscar)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var movimientosDeInventarioFiltradas = context.InventoryMovement
                        .Where(p =>
                            (
                                p.Quantity.ToString().Contains(textoBuscar) ||
                                p.TypeMovement.ToLower().Contains(textoBuscar) ||
                                p.Remarks.ToLower().Contains(textoBuscar)

                            ) &&
                            p.IsDeleted.Equals(false)
                        ).ToList();
                    return movimientosDeInventarioFiltradas;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


        public List<InventoryMovement> OrdenarMovimientosDeInventario(string criterioOrdenacion)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    var movimientosDeInventarioOrdenados = context.InventoryMovement.Where(c => c.IsDeleted.Equals(false)).ToList();

                    switch (criterioOrdenacion)
                    {
                        case "Cantidad":
                            movimientosDeInventarioOrdenados = movimientosDeInventarioOrdenados.OrderBy(p => p.Quantity).ToList();
                            break;
                        case "Tipo de Movimiento":
                            movimientosDeInventarioOrdenados = movimientosDeInventarioOrdenados.OrderBy(p => p.TypeMovement).ToList();
                            break;
                        case "Observaciones":
                            movimientosDeInventarioOrdenados = movimientosDeInventarioOrdenados.OrderBy(p => p.Remarks).ToList();
                            break;
                        default:
                            break;
                    }
                    return movimientosDeInventarioOrdenados;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
