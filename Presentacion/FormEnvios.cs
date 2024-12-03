using Negocio;
using System;
using System.Windows.Forms;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public partial class FormEnvios : Form
    {
        private NShipper nShipper = new NShipper();
        private NClient nClient = new NClient();

        private bool detallesVisiblesEnvios= false;


        public FormEnvios()
        {
            InitializeComponent();
            MostrarEnviosPersonalizado(nShipper.ListarTodo());
        }

        private void FormEnvios_Load(object sender, EventArgs e)
        {
            cbOrdenar.Items.Add("Nombre de la Empresa");
            cbOrdenar.Items.Add("Numero telefonico");
            if (NClient.UsuarioLogueado().Role == "Trabajador")
            {
                btnUsuarios.Visible = false;
                btnReportes.Visible = false;
                pnlUsuarios.Visible = false;
                pnlUsuarios.Visible = false;
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

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos form = new FormProductos();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }
        
        #endregion

        #region-> Botones Multiusuario
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

        #region -> CRUD Envios
        private void MostrarEnvios(List<Shipper> shippers)
        {
            dgEnvios.DataSource = null;
            dgEnvios.AutoGenerateColumns = true;
            dgEnvios.Columns.Clear();
            dgEnvios.DataSource = shippers;
        }

        private void MostrarEnviosPersonalizado(List<Shipper> shippers)
        {
            dgEnvios.DataSource = null;
            dgEnvios.AutoGenerateColumns = false;
            dgEnvios.Columns.Clear();

            if (shippers == null || shippers.Count == 0)
            {
                return;
            }

            dgEnvios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                Name = "Id",
                Visible = false,
            });

            dgEnvios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CompanyName",
                HeaderText = "Nombre",
                Name = "CompanyName",
            });

            dgEnvios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Phone",
                HeaderText = "Teléfono",
                Name = "Phone",
            });

            dgEnvios.DataSource = shippers;
        }

        private void ActualizarVista()
        {
            if(detallesVisiblesEnvios)
            {
                MostrarEnviosPersonalizado(nShipper.ListarTodo());
            }
            else
            {
                MostrarEnvios(nShipper.ListarTodo());
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            detallesVisiblesEnvios = !detallesVisiblesEnvios;
            ActualizarVista();
        }

        private void LimpiarFormulario()
        {
            tbNumero.Texts = string.Empty;
            tbNombreCompania.Texts = string.Empty;
        }

        private void dgEnvios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgEnvios.SelectedRows.Count == 0) { return; }

            tbNombreCompania.Texts = dgEnvios.SelectedRows[0].Cells["CompanyName"].Value?.ToString() ?? string.Empty;
            tbNumero.Texts = dgEnvios.SelectedRows[0].Cells["Phone"].Value?.ToString() ?? string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(tbNombreCompania.Texts == ""|| tbNumero.Texts == "")
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            Shipper shipper = new Shipper
            {
                CompanyName = tbNombreCompania.Texts,
                Phone = tbNumero.Texts,
                CreatedBy = NClient.UsuarioLogueado().Id.ToString(),
                CreatedAt = DateTime.UtcNow,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.Now,
            };

            String mensaje = nShipper.Registrar(shipper);
            MessageBox.Show(mensaje);
            MostrarEnviosPersonalizado(nShipper.ListarTodo());
            LimpiarFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbNombreCompania.Texts == "" || tbNumero.Texts == "")
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            if (dgEnvios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un envio");
                return;
            }

            Shipper shipper = new Shipper
            {
                Id = Convert.ToInt32(dgEnvios.SelectedRows[0].Cells["Id"].Value),
                CompanyName = tbNombreCompania.Texts,
                Phone = tbNumero.Texts,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow,
            };

            String mensaje = nShipper.Modificar(shipper);
            MessageBox.Show(mensaje);
            MostrarEnviosPersonalizado(nShipper.ListarTodo());
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgEnvios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un envio");
                return;
            }

            int id = Convert.ToInt32(dgEnvios.SelectedRows[0].Cells["Id"].Value);

            Shipper shipper = new Shipper
            {
                Id = id,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow,
            };

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el envio?", "Eliminar Envio", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String mensaje = nShipper.ELiminarLogico(shipper);
                MessageBox.Show(mensaje);
                MostrarEnviosPersonalizado(nShipper.ListarTodo());
                LimpiarFormulario();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(tbBuscar.Texts == "")
            {
                MessageBox.Show("Por favor, ingrese un nombre para buscar");
                return;
            }
            var shippers = nShipper.BuscarEnvios(tbBuscar.Texts);
            MostrarEnviosPersonalizado(shippers);
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
            MostrarEnviosPersonalizado(nShipper.OrdenarEnvios(criterioOrdenacion));
            lblBorrarFiltros.Visible = true;
        }

        private void lblBorrarFiltros_Click(object sender, EventArgs e)
        {
            MostrarEnviosPersonalizado(nShipper.ListarTodo());
            lblBorrarFiltros.Visible = false;
        }

        #endregion

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FormCategorias form = new FormCategorias();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }
    }
}
