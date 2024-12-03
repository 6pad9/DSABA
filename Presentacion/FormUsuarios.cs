using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Presentacion
{
    public partial class FormUsuarios : Form
    {
        private NClient nClient = new NClient();

        private bool detallesVisiblesUsuarios = false;

        public FormUsuarios()
        {
            InitializeComponent();
            MostrarUsuariosPersonalizado(nClient.ListarTodo());
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            cbOrdenar.Items.Add("Nombre");
            cbOrdenar.Items.Add("Rol");
            cbOrdenar.Items.Add("Contraseña");
            cbOrdenar.Items.Add("Zona Horaria");
            cbRol.Items.Add("Administrador");
            cbRol.Items.Add("Trabajador");

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
        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = !SubmenuReportes.Visible;
        }
        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            FormOrdenes form = new FormOrdenes();
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
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

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos form = new FormProductos();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        #endregion

        #region -> CRUD Usuarios
        private void MostrarUsuarios(List<Client> usuarios)
        {
            dgUsuarios.DataSource = null;
            dgUsuarios.AutoGenerateColumns = true;
            dgUsuarios.Columns.Clear();
            dgUsuarios.DataSource = usuarios;
        }

        private void MostrarUsuariosPersonalizado(List<Client> usuarios)
        {
            dgUsuarios.DataSource = null;
            dgUsuarios.AutoGenerateColumns = false;
            dgUsuarios.Columns.Clear();
            if (usuarios.Count == 0 || usuarios == null)
            {
                return;
            }
            dgUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                Name = "Id",
                Visible = false,
            });
            dgUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Nombre",
                Name = "Name",
            });
            dgUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Password",
                HeaderText = "Contraseña",
                Name = "Password",
            });
            dgUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Offset",
                HeaderText = "Zona Horaria",
                Name = "Offset",
            });
            dgUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Role",
                HeaderText = "Rol",
                Name = "Role",
            });
            dgUsuarios.DataSource = usuarios;

        }

        private void ActualizarVista()
        {
            if (detallesVisiblesUsuarios)
            {
                MostrarUsuarios(nClient.ListarTodo());
            }
            else
            {
                MostrarUsuariosPersonalizado(nClient.ListarTodo());
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            detallesVisiblesUsuarios = !detallesVisiblesUsuarios;
            ActualizarVista();
        }

        private void LimpiarCampos()
        {
            tbNombre.Texts = "";
            tbPassword.Texts = "";
            cbRol.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Texts == "" || tbPassword.Texts == "" || cbRol.Texts == "")
            {
                MessageBox.Show("Por favor, llene todos los campos");
                return;
            }

            Client user = new Client
            {
                Name = tbNombre.Texts,
                Password = tbPassword.Texts,
                Role = cbRol.Texts,
                Offset = tbOffset.Texts,
                CreatedBy = NClient.UsuarioLogueado().Name,
                CreatedAt = DateTime.UtcNow,
                UpdatedBy = NClient.UsuarioLogueado().Name,
                UpdatedAt = DateTime.UtcNow
            };
            String mensaje = nClient.Registrar(user);
            MessageBox.Show(mensaje);
            MostrarUsuariosPersonalizado(nClient.ListarTodo());
            LimpiarCampos();
        }

        private void dgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count == 0) { return; }

            tbNombre.Texts = dgUsuarios.SelectedRows[0].Cells["Name"].Value.ToString();
            tbPassword.Texts = dgUsuarios.SelectedRows[0].Cells["Password"].Value.ToString();
            cbRol.Texts = dgUsuarios.SelectedRows[0].Cells["Role"].Value.ToString();
            tbOffset.Texts = dgUsuarios.SelectedRows[0].Cells["Offset"].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario");
                return;
            }

            if (tbNombre.Texts == "" || tbPassword.Texts == "" || cbRol.Texts == "")
            {
                MessageBox.Show("Por favor, llene todos los campos");
                return;
            }

            int id = int.Parse(dgUsuarios.SelectedRows[0].Cells["Id"].Value.ToString());
            Client user = new Client
            {
                Id = id,
                Name = tbNombre.Texts,
                Password = tbPassword.Texts,
                Role = cbRol.Texts,
                Offset = tbOffset.Texts,
                UpdatedBy = NClient.UsuarioLogueado().Name,
                UpdatedAt = DateTime.UtcNow
            };
            String mensaje = nClient.Modificar(user);
            MessageBox.Show(mensaje);
            MostrarUsuariosPersonalizado(nClient.ListarTodo());
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario");
                return;
            }

            int id = int.Parse(dgUsuarios.SelectedRows[0].Cells["Id"].Value.ToString());

            Client client = new Client
            {
                Id = id,
                UpdatedAt = DateTime.UtcNow,
                UpdatedBy = NClient.UsuarioLogueado().Name
            };

            if (id==NClient.UsuarioLogueado().Id)
            {
                MessageBox.Show("No puedes eliminarte a ti mismo");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el usuario?", "Eliminar Cliente", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String mensaje = nClient.EliminarLogico(client);
                MessageBox.Show(mensaje);
                MostrarUsuariosPersonalizado(nClient.ListarTodo());
                LimpiarCampos();
            }
        }

        private void lblBorrarFiltros_Click(object sender, EventArgs e)
        {
            MostrarUsuariosPersonalizado(nClient.ListarTodo());
            lblBorrarFiltros.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBuscar.Texts))
            {
                MessageBox.Show("Escribe algo.");
                return;
            }
            var usuariosFiltrados = nClient.BuscarUsuarios(tbBuscar.Texts);
            MostrarUsuariosPersonalizado(usuariosFiltrados);
            lblBorrarFiltros.Visible = true;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            String criterioOrdenacion = cbOrdenar.Texts.Trim();
            if (string.IsNullOrEmpty(criterioOrdenacion))
            {
                MessageBox.Show("Por favor, selecciona un criterio de ordenación.");
                return;
            }
            var usuariosOrdenados = nClient.OrdenarUsuarios(criterioOrdenacion);
            MostrarUsuariosPersonalizado(usuariosOrdenados);
            lblBorrarFiltros.Visible = true;
        }

        #endregion


    }
}
