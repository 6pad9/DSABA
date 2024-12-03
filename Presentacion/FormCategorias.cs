using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCategorias : Form
    {
        private NCategory nCategory = new NCategory();
        private NClient nClient = new NClient();

        private bool detallesVisiblesCategorias = false;

        public FormCategorias()
        {
            InitializeComponent();
            MostrarCategoriasPersonalizado(nCategory.ListarTodo());
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            cbOrdenar.Items.Add("Nombre");
            cbOrdenar.Items.Add("Descripción");

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
            
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos form = new FormProductos();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
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

        #region -> CRUD Categorias

        private void MostrarCategorias(List<Category> categories)
        {
            dgCategorias.DataSource = null;
            dgCategorias.AutoGenerateColumns = true;
            dgCategorias.Columns.Clear();

            dgCategorias.DataSource = categories;
        }

        private void MostrarCategoriasPersonalizado(List<Category> categorias)
        {
            dgCategorias.DataSource = null;
            dgCategorias.AutoGenerateColumns = false;
            dgCategorias.Columns.Clear();


            if (categorias == null || categorias.Count == 0)
            {
                return;
            }
            dgCategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                Name = "Id",
                Visible = false,

            });

            dgCategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Nombre",
                Name = "NameColumn"
            });

            dgCategorias.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Descripción",
                Name = "DescriptionColumn"
            });

            dgCategorias.DataSource = categorias;
        }

        private void ActualizarVistaCategorias()
        {
            if (detallesVisiblesCategorias)
            {
                MostrarCategoriasPersonalizado(nCategory.ListarTodo());
            }
            else
            {
                MostrarCategorias(nCategory.ListarTodo());
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            detallesVisiblesCategorias = !detallesVisiblesCategorias;
            ActualizarVistaCategorias();
        }

        private void LimpiarFormularioCategoria()
        {
            tbNombre.Texts = string.Empty;
            tbDescripcion.Texts = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBuscar.Texts.Trim()))
            {
                MessageBox.Show("Escribe algo.");
                return;
            }
            var categoriasFiltradas = nCategory.BuscarCategorias(tbBuscar.Texts.Trim());
            MostrarCategoriasPersonalizado(categoriasFiltradas);
            lblBorrarFiltros.Visible = true;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            String criterioOrdenacion = cbOrdenar.Texts;
            if (string.IsNullOrEmpty(criterioOrdenacion))
            {
                MessageBox.Show("Por favor, selecciona un criterio de ordenación.");
                return;
            }
            var productosOrdenados = nCategory.OrdenarCategorias(criterioOrdenacion);
            MostrarCategoriasPersonalizado(productosOrdenados);
            lblBorrarFiltros.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoria para modificar");
                return;
            }

            int id = Convert.ToInt32(dgCategorias.SelectedRows[0].Cells["Id"].Value);
            Category category = new Category
            {
                Id = id,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow,
            };
            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar la categoria?", "Eliminar Categoria", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String mensaje = nCategory.EliminarLogico(category);
                MessageBox.Show(mensaje);
                MostrarCategoriasPersonalizado(nCategory.ListarTodo());
                LimpiarFormularioCategoria();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Texts == "" || tbDescripcion.Texts == "")
            {
                MessageBox.Show("Por favor llene todos los campos");
                return;
            }

            Category category = new Category
            {
                Name = tbNombre.Texts,
                Description = tbDescripcion.Texts,
                CreatedBy = NClient.UsuarioLogueado().Id.ToString(),
                CreatedAt = DateTime.UtcNow,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow,
            };

            String mensaje = nCategory.Registrar(category);
            MessageBox.Show(mensaje);
            MostrarCategoriasPersonalizado(nCategory.ListarTodo());
            LimpiarFormularioCategoria();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoria para modificar");
                return;
            }

            if (tbNombre.Texts == "" || tbDescripcion.Texts == "")
            {
                MessageBox.Show("Por favor llene todos los campos");
                return;
            }

            int idCategoria = int.Parse(dgCategorias.SelectedRows[0].Cells["Id"].Value.ToString());
            Category category = new Category
            {
                Id = idCategoria,
                Name = tbNombre.Texts,
                Description = tbDescripcion.Texts,
                CreatedBy = NClient.UsuarioLogueado().Id.ToString(),
                CreatedAt = DateTime.UtcNow,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow,
            };

            String mensaje = nCategory.Modificar(category);
            MessageBox.Show(mensaje);
            MostrarCategoriasPersonalizado(nCategory.ListarTodo());
            LimpiarFormularioCategoria();
        }

        private void dgCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCategorias.SelectedRows.Count == 0) { return; }

            tbNombre.Texts = dgCategorias.SelectedRows[0].Cells["NameColumn"].Value?.ToString() ?? string.Empty;
            tbDescripcion.Texts = dgCategorias.SelectedRows[0].Cells["DescriptionColumn"].Value?.ToString() ?? string.Empty;
        }

        private void lblBorrarFiltros_Click(object sender, EventArgs e)
        {
            MostrarCategoriasPersonalizado(nCategory.ListarTodo());
            lblBorrarFiltros.Visible = false;
        }

        #endregion

    }
}
