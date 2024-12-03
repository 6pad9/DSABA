using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Presentacion
{
    public partial class FormProductos : Form
    {
        private NProduct nProduct = new NProduct();
        private NCategory nCategory = new NCategory();
        private NClient nClient = new NClient();

        private bool detallesVisiblesProductos = false;


        public FormProductos()
        {
            InitializeComponent();
            MostrarCategoriasEnComboBox(nCategory.ListarTodo());
            MostrarProductosPersonalizado(nProduct.ListarTodo());
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            cbOrdenarProductos.Items.Add("Nombre");
            cbOrdenarProductos.Items.Add("Descripción");
            cbOrdenarProductos.Items.Add("Cantidad");
            cbOrdenarProductos.Items.Add("Precio");
            cbOrdenarProductos.Items.Add("Stock Minimo");

            cbCategoria.Texts = "";

            if (NClient.UsuarioLogueado().Role == "Trabajador")
            {
                btnUsuarios.Visible = false;
                btnReportes.Visible = false;
                pnlUsuarios.Visible = false;
                pnlReportes.Visible = false;
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

        #region-> Botones de navegacion
        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            FormOrdenes form = new FormOrdenes();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FormProveedores form = new FormProveedores();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            FormEnvios form = new FormEnvios();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FormCategorias form = new FormCategorias();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {

        }
        #endregion 

        #region->Botones Multiusuario

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios form = new FormUsuarios();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = !SubmenuReportes.Visible;
        }

        private void btnrptStockBajo_Click(object sender, EventArgs e)
        {
            FormReporteStockBajo form = new FormReporteStockBajo();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnrptOrdenesPorStatus_Click(object sender, EventArgs e)
        {
            FormReporteOrdenesPorStatus form = new FormReporteOrdenesPorStatus();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnrptVentasPorFecha_Click(object sender, EventArgs e)
        {
            FormReporteVentasPorFecha form = new FormReporteVentasPorFecha();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnrptMovimientosDeInventario_Click(object sender, EventArgs e)
        {
            FormReporteMovimientosDeInventario form = new FormReporteMovimientosDeInventario();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }
        #endregion

        #region --> Crud Productos

        private void MostrarProductos(List<Product> productos)
        {
            dgProductos.DataSource = null;
            dgProductos.AutoGenerateColumns = true;
            dgProductos.Columns.Clear();

            dgProductos.DataSource = productos;
        }

        private void MostrarProductosPersonalizado(List<Product> productos)
        {
            dgProductos.DataSource = null;
            dgProductos.AutoGenerateColumns = false;
            dgProductos.Columns.Clear();

            if (productos == null || productos.Count == 0)
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
                DataPropertyName = "Category_Id",
                HeaderText = "Categoria",
                Name = "Category_Id",
                Visible = false,

            });


            dgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Nombre",
                Name = "Name"
            });

            dgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Descripción",
                Name = "Description"
            });


            dgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Cantidad",
                Name = "Quantity"
            });

            dgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Precio",
                Name = "Price"
            });

            dgProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MinimumStock",
                HeaderText = "Stock Minimo",
                Name = "MinimumStock"
            });

            dgProductos.DataSource = productos;
        }

        private void ActualizarVista()
        {
            if (detallesVisiblesProductos)
            {
                MostrarProductosPersonalizado(nProduct.ListarTodo());
            }
            else
            {
                MostrarProductos(nProduct.ListarTodo());
            }
        }

        private void MostrarCategoriasEnComboBox(List<Category> categorias)
        {
            cbCategoria.DataSource = categorias;
            cbCategoria.DisplayMember = "Name";
            cbCategoria.ValueMember = "Id";
        }

        private void btnDetallesProducto_Click(object sender, EventArgs e)
        {
            detallesVisiblesProductos = !detallesVisiblesProductos;
            ActualizarVista();
        }

        private void dgProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0) { return; }

            tbNombreProducto.Texts = dgProductos.SelectedRows[0].Cells["Name"].Value?.ToString() ?? string.Empty;
            tbDescripcionProducto.Texts = dgProductos.SelectedRows[0].Cells["Description"].Value?.ToString() ?? string.Empty;
            tbCantidadProducto.Texts = dgProductos.SelectedRows[0].Cells["Quantity"].Value?.ToString() ?? string.Empty;
            tbPrecioProducto.Texts = dgProductos.SelectedRows[0].Cells["Price"].Value?.ToString() ?? string.Empty;
            tbStockMinimoProducto.Texts = dgProductos.SelectedRows[0].Cells["MinimumStock"].Value?.ToString() ?? string.Empty;
            cbCategoria.SelectedValue = int.Parse(dgProductos.SelectedRows[0].Cells["Category_Id"].Value.ToString());
        }

        private void LimpiarFormulario()
        {
            tbNombre.Texts = string.Empty;
            tbDescripcionProducto.Texts = string.Empty;
            tbCantidadProducto.Texts = string.Empty;
            tbPrecioProducto.Texts = string.Empty;
            tbStockMinimoProducto.Texts = string.Empty;
            cbCategoria.SelectedIndex = 0;
        }

        private bool CamposVacios()
        {
            return string.IsNullOrEmpty(tbNombreProducto.Texts) ||
                   string.IsNullOrEmpty(tbDescripcionProducto.Texts) ||
                   string.IsNullOrEmpty(tbCantidadProducto.Texts) ||
                   string.IsNullOrEmpty(tbPrecioProducto.Texts) ||
                   string.IsNullOrEmpty(tbStockMinimoProducto.Texts) ||
                   string.IsNullOrEmpty(cbCategoria.Texts);
        }

        private bool ValidarValoresNumericos()
        {
            return int.TryParse(tbCantidadProducto.Texts, out _) &&
                   decimal.TryParse(tbPrecioProducto.Texts, out _) &&
                   int.TryParse(tbStockMinimoProducto.Texts, out _);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                MessageBox.Show("Por favor llene todos los campos");
                return;
            }

            if (!ValidarValoresNumericos())
            {
                MessageBox.Show("Recuerde que la cantidad y el stock deben ser valores enteros, y el precio debe ser un valor decimal.");
                return;
            }

            int idCategoria = int.Parse(cbCategoria.SelectedValue.ToString());
            Product product = new Product
            {
                Category_Id = idCategoria,
                Name = tbNombreProducto.Texts,
                Description = tbDescripcionProducto.Texts,
                Quantity = int.Parse(tbCantidadProducto.Texts),
                Price = Decimal.Parse(tbPrecioProducto.Texts),
                MinimumStock = int.Parse(tbStockMinimoProducto.Texts),
                CreatedBy = NClient.UsuarioLogueado().Id.ToString(),
                CreatedAt = DateTime.UtcNow,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow,
            };

            String mensaje = nProduct.Registrar(product);
            MessageBox.Show(mensaje);
            MostrarProductosPersonalizado(nProduct.ListarTodo());
            LimpiarFormulario();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para modificar");
                return;
            }

            if (CamposVacios())
            {
                MessageBox.Show("Por favor llene todos los campos");
                return;
            }

            if (!ValidarValoresNumericos())
            {
                MessageBox.Show("Recuerde que la cantidad y el stock deben ser números enteros, y el precio un decimal.");
                return;
            }

            int idCategoria = int.Parse(cbCategoria.SelectedValue.ToString());
            int idProduct = int.Parse(dgProductos.SelectedRows[0].Cells["Id"].Value.ToString());

            Product product = new Product
            {
                Id = idProduct,
                Category_Id = idCategoria,
                Name = tbNombreProducto.Texts,
                Description = tbDescripcionProducto.Texts,
                Quantity = int.Parse(tbCantidadProducto.Texts),
                Price = Decimal.Parse(tbPrecioProducto.Texts),
                MinimumStock = int.Parse(tbStockMinimoProducto.Texts),
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow,
            };

            String mensaje = nProduct.Modificar(product);
            MessageBox.Show(mensaje);
            MostrarProductosPersonalizado(nProduct.ListarTodo());
            LimpiarFormulario();
        }

        private void btnEliminarProductos_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar");
                return;
            }

            int id = Convert.ToInt32(dgProductos.SelectedRows[0].Cells["Id"].Value);

            Product product = new Product
            {
                Id = id,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow,
            };

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el producto?", "Eliminar Producto", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String mensaje = nProduct.EliminarLogico(product);
                MessageBox.Show(mensaje);
                MostrarProductosPersonalizado(nProduct.ListarTodo());
                LimpiarFormulario();
            }
        }

        private void btnOrdenarProductos_Click(object sender, EventArgs e)
        {
            String criterioOrdenacion = cbOrdenarProductos.Texts;
            if (string.IsNullOrEmpty(criterioOrdenacion))
            {
                MessageBox.Show("Por favor, selecciona un criterio de ordenación.");
                return;
            }
            var productosOrdenados = nProduct.OrdenarProductos(criterioOrdenacion);
            MostrarProductosPersonalizado(productosOrdenados);
            lblBorrarFiltros.Visible = true;
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBuscarProductos.Texts.Trim()))
            {
                MessageBox.Show("Escribe algo.");
                return;
            }
            var productosFiltrados=nProduct.BuscarProductos(tbBuscarProductos.Texts.Trim());
            MostrarProductosPersonalizado(productosFiltrados);
            lblBorrarFiltros.Visible = true;
        }

        private void lblBorrarFiltros_Click(object sender, EventArgs e)
        {
            MostrarProductosPersonalizado(nProduct.ListarTodo());
            lblBorrarFiltros.Visible = false;
        }

        #endregion

    }
}
