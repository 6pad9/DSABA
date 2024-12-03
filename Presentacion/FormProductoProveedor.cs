using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace Presentacion
{
    public partial class FormProductoProveedor : Form
    {
        private int proveedorId;

        private NProductSupplier nProductSupplier = new NProductSupplier();
        private NProduct nProduct = new NProduct();
        private NSupplier nSupplier = new NSupplier();
        private NClient nClient = new NClient();

        private bool detallesVisiblesProductos = false;
        private bool cambiosRealizados = false;


        public FormProductoProveedor(int id)
        {
            InitializeComponent();
            this.proveedorId = id;
            MostrarProductosProveedorPersonalizado(nProductSupplier.ListarPorProveedor(proveedorId));
            MostrarProductosEnComboBox(nProduct.ListarTodo());
        }

        private void FormProductoProveedor_Load(object sender, EventArgs e)
        {
            var proveedor = nSupplier.ListarTodoPorId(proveedorId).FirstOrDefault();
            if (proveedor != null)
            {
                lblProductoActual.Text = proveedor.Name;
            }
            else
            {
                lblProductoActual.Text = "Proveedor no encontrado";
            }

            cbProductos.Texts = null;
        }

        private void FormProductoProveedor_FormClosing(object sender, FormClosingEventArgs e)
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

        #region-> CRUD ProductoProveedor

        private void MostrarProductosProveedor(List<ProductSupplier> productos)
        {
            dgProductos.DataSource = null;
            dgProductos.AutoGenerateColumns = true;
            dgProductos.Columns.Clear();

            dgProductos.DataSource = productos;
        }

        private void MostrarProductosProveedorPersonalizado(List<ProductSupplier> productSuppliers)
        {
            dgProductos.DataSource = null;
            dgProductos.AutoGenerateColumns = false;
            dgProductos.Columns.Clear();

            if (productSuppliers == null || productSuppliers.Count == 0)
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
                DataPropertyName = "Product_Id",
                HeaderText = "Proveedor",
                Name = "Product_Id",
                Visible = false,

            });

            dgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Detail",
                HeaderText = "Descripción",
                Name = "Detail"
            });

            dgProductos.DataSource = productSuppliers;
        }

        private void ActualizarVista()
        {
            if (detallesVisiblesProductos)
            {
                MostrarProductosProveedorPersonalizado(nProductSupplier.ListarPorProveedor(proveedorId));
            }
            else
            {
                MostrarProductosProveedor(nProductSupplier.ListarPorProveedor(proveedorId));
            }
        }

        private void MostrarProductosEnComboBox(List<Product> products)
        {
            cbProductos.DataSource = products;
            cbProductos.DisplayMember = "Name";
            cbProductos.ValueMember = "Id";
        }

        private void LimpiarCampos()
        {
            cbProductos.Texts = null;
            tbDescripcion.Texts = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbProductos.Texts == null)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            }

            int productoId = int.Parse(cbProductos.SelectedValue.ToString());

            ProductSupplier productSupplier = new ProductSupplier
            {
                Product_Id = productoId,
                Supplier_Id = proveedorId,
                Detail = tbDescripcion.Texts,
                CreatedBy = NClient.UsuarioLogueado().Id.ToString(),
                CreatedAt = DateTime.UtcNow,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow
            };

            string mensaje = nProductSupplier.Registrar(productSupplier);
            cambiosRealizados = true;
            MessageBox.Show(mensaje);
            MostrarProductosProveedorPersonalizado(nProductSupplier.ListarPorProveedor(proveedorId));
            LimpiarCampos();
        }

        private void dgProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0) { return; }

            tbDescripcion.Texts = dgProductos.CurrentRow.Cells["Detail"].Value.ToString() ?? string.Empty;
            cbProductos.SelectedValue = int.Parse(dgProductos.SelectedRows[0].Cells["Product_Id"].Value.ToString());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            if (cbProductos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            }

            int productoId= int.Parse(cbProductos.SelectedValue.ToString());
            int idProductoProveedor = int.Parse(dgProductos.SelectedRows[0].Cells["Id"].Value.ToString());
            ProductSupplier productSupplier = new ProductSupplier
            {
                Id = idProductoProveedor,
                Product_Id = productoId,
                Supplier_Id = proveedorId,
                Detail = tbDescripcion.Texts,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow
            };

            string mensaje = nProductSupplier.Modificar(productSupplier);
            cambiosRealizados = true;
            MessageBox.Show(mensaje);
            MostrarProductosProveedorPersonalizado(nProductSupplier.ListarPorProveedor(proveedorId));
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un fila para eliminar");
                return;
            }

            int id = Convert.ToInt32(dgProductos.SelectedRows[0].Cells["Id"].Value);

            ProductSupplier productSupplier = new ProductSupplier
            {
                Id = id,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow,
            };

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminarlo?", "Eliminarlo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String mensaje = nProductSupplier.EliminarLogico(productSupplier);
                cambiosRealizados = true;
                MessageBox.Show(mensaje);
                MostrarProductosProveedorPersonalizado(nProductSupplier.ListarPorProveedor(proveedorId));
                LimpiarCampos();
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            detallesVisiblesProductos = !detallesVisiblesProductos;
            ActualizarVista();
        }

        #endregion

    }
}
