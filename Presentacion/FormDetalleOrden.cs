using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormDetalleOrden : Form
    {
        private int orderId;

        private NProduct nProduct = new NProduct();
        private NOrder nOrder = new NOrder();
        private NClient nClient = new NClient();
        private NOrderDetail nOrderDetail = new NOrderDetail();

        private bool detallesVisibleOrdenes = false;
        private bool cambiosRealizados = false;

        public FormDetalleOrden(int id)
        {
            InitializeComponent();
            this.orderId = id;
            MostrarDetallesOrdenPersonalizado(nOrderDetail.ObtenerOrdenesPorId(orderId));
            MostrarProductosEnComboBox(nProduct.ListarTodo());
        }

        private void FormDetalleOrden_Load(object sender, EventArgs e)
        {
            var orden = nOrder.ObtenerOrdenesPorId(orderId).FirstOrDefault();
            cbProducts.Texts = null;
            if (orden != null)
            {
                lblOrdenActual.Text = orden.Code;
            }
            else
            {
                lblOrdenActual.Text = "Producto no encontrado";
            }

            cbProducts.Texts = null;
        }

        private void FormDetalleOrden_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cambiosRealizados)
            {
                DialogResult result = MessageBox.Show("No se han realizado cambios. ¿Seguro que desea salir?", "Confirmación de salida", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        #region -> Botones para cerrar, minimizar, maximizar y restaurar
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            MessageBox.Show("Sesión cerrada correctamente");
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void AbrirFormularioSecundario(Form formularioSecundario)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                formularioSecundario.WindowState = FormWindowState.Maximized;
            }
            else
            {
                formularioSecundario.WindowState = FormWindowState.Normal;
            }

            formularioSecundario.Show();
        }
        #endregion

        #region -> CRUD Detalles de Orden


        private void MostrarDetallesOrden(List<OrderDetail> orderDetails)
        {
            dgProductos.DataSource = null;
            dgProductos.AutoGenerateColumns = true;
            dgProductos.Columns.Clear();

            dgProductos.DataSource = orderDetails;
        }

        private void MostrarDetallesOrdenPersonalizado(List<OrderDetail> orderDetails)
        {
            dgProductos.DataSource = null;
            dgProductos.AutoGenerateColumns = false;
            dgProductos.Columns.Clear();

            if (orderDetails == null || orderDetails.Count == 0)
            {
                return;
            }

            dgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                Name = "Id",
                Visible = false,

            });

            dgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Order_Id",
                HeaderText = "Órdenes",
                Name = "Order_Id",
                Visible = false,

            });

            dgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Product_Id",
                HeaderText = "Productos",
                Name = "Product_Id",
                Visible = false,
            });

            dgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Cantidad",
                Name = "Quantity"
            });

            dgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DateReceipt",
                HeaderText = "Fecha de emisión",
                Name = "DateReceipt"
            });

            dgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Precio",
                Name = "Price"
            });

            dgProductos.DataSource = orderDetails;
        }

        private void ActualizarVista()
        {
            if (detallesVisibleOrdenes)
            {
                MostrarDetallesOrdenPersonalizado(nOrderDetail.ObtenerOrdenesPorId(orderId));
            }
            else
            {
                MostrarDetallesOrden(nOrderDetail.ObtenerOrdenesPorId(orderId));
            }
        }

        private void MostrarProductosEnComboBox(List<Product> products)
        {
            cbProducts.DataSource = products;
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "Id";
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            detallesVisibleOrdenes = !detallesVisibleOrdenes;
            ActualizarVista();
        }

        private void dgProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0) { return; }

            cbProducts.SelectedValue = int.Parse(dgProductos.SelectedRows[0].Cells["Product_Id"].Value.ToString());
            tbCantidad.Texts = dgProductos.CurrentRow.Cells["Quantity"].Value.ToString() ?? string.Empty;
            tbPrecio.Texts = dgProductos.CurrentRow.Cells["Price"].Value.ToString() ?? string.Empty;
            dtpDateReceipt.Value = DateTime.Parse(dgProductos.CurrentRow.Cells["DateReceipt"].Value.ToString());
        }

        private void LimpiarCampos()
        {
            cbProducts.Texts = null;
            tbCantidad.Texts = string.Empty;
            tbPrecio.Texts = string.Empty;
            dtpDateReceipt.Value = DateTime.Now;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbProducts.SelectedItem == null || tbCantidad.Texts == "" || tbPrecio.Texts == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            int idProduct = int.Parse(cbProducts.SelectedValue.ToString());

            int cantidad = 0;
            Decimal precio = 0;

            try
            {
                cantidad = int.Parse(tbCantidad.Texts);
                precio = Decimal.Parse(tbPrecio.Texts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            OrderDetail orderDetail = new OrderDetail
            {
                Order_Id = orderId,
                Product_Id = idProduct,
                Quantity = cantidad,
                Price = precio,
                DateReceipt = dtpDateReceipt.Value,
                CreatedBy = NClient.UsuarioLogueado().Id.ToString(),
                CreatedAt = DateTime.UtcNow,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow
            };

            string mensaje = nOrderDetail.Registrar(orderDetail);
            cambiosRealizados = true;
            MessageBox.Show(mensaje);
            MostrarDetallesOrdenPersonalizado(nOrderDetail.ObtenerOrdenesPorId(orderId));
            LimpiarCampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una detalle de orden para modificar");
                return;
            }

            if (cbProducts.SelectedItem == null || tbCantidad.Texts == "" || tbPrecio.Texts == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            int idProduct = int.Parse(cbProducts.SelectedValue.ToString());

            int cantidad = 0;
            Decimal precio = 0;

            try
            {
                cantidad = int.Parse(tbCantidad.Texts);
                precio = Decimal.Parse(tbPrecio.Texts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int id = int.Parse(dgProductos.CurrentRow.Cells["Id"].Value.ToString());
            OrderDetail orderDetail = new OrderDetail
            {
                Id = id,
                Order_Id = orderId,
                Product_Id = idProduct,
                Quantity = cantidad,
                Price = precio,
                DateReceipt = dtpDateReceipt.Value,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow
            };

            string mensaje = nOrderDetail.Modificar(orderDetail);
            cambiosRealizados = true;
            MessageBox.Show(mensaje);
            MostrarDetallesOrdenPersonalizado(nOrderDetail.ObtenerOrdenesPorId(orderId));
            LimpiarCampos();
        }
    

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una detalle de orden para modificar");
                return;
            }

            int id = int.Parse(dgProductos.CurrentRow.Cells["Id"].Value.ToString());
            OrderDetail orderDetail = new OrderDetail
            {
                Id = id,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow
            };

            string mensaje = nOrderDetail.EliminarLogico(orderDetail);
            cambiosRealizados = true;
            MessageBox.Show(mensaje);
            MostrarDetallesOrdenPersonalizado(nOrderDetail.ObtenerOrdenesPorId(orderId));
            LimpiarCampos();
        }

        private void cbProducts_Click(object sender, EventArgs e)
        {
            if (cbProducts.SelectedValue != null)
            {
                int productId = int.Parse(cbProducts.SelectedValue.ToString());
                var product = nProduct.ObtenerProductoPorId(productId).FirstOrDefault();
                if (product != null)
                {
                    tbPrecio.Texts = product.Price.ToString();
                }
            }
        }

        #endregion
    }
}
