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
    public partial class FormOrdenes : Form
    {
        NOrder nOrder = new NOrder();
        NClient nClient = new NClient();
        NShipper nShipper = new NShipper();

        private bool detallesVisiblesOrdenes = false;


        public FormOrdenes()
        {
            InitializeComponent();
            MostrarOrdenesPersonalizado(nOrder.ListarTodo());
            MostrarRepartidores(nShipper.ListarTodo());
        }

        private void FormOrdenes_Load(object sender, EventArgs e)
        {
            cbOrdenar.Items.Add("Estado");
            cbOrdenar.Items.Add("Código");
            cbOrdenar.Items.Add("Fecha de Emisión");
            cbOrdenar.Items.Add("Descripción");

            cbEstatus.Items.Add("Pendiente");
            cbEstatus.Items.Add("Enviado");
            cbEstatus.Items.Add("Completado");
            cbEstatus.Items.Add("Cancelado");

            cbEstatus.Texts = "";
            cbShipper.Texts = "";

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

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos form = new FormProductos();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        #endregion

        #region->Botones Multiusuario
        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = !SubmenuReportes.Visible;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios form = new FormUsuarios();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
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

        #region -> CRUD Ordenes

        private void MostrarRepartidores(List<Shipper> shippers)
        {
            cbShipper.DataSource = shippers;
            cbShipper.DisplayMember = "CompanyName";
            cbShipper.ValueMember = "Id";
        }

        private void MostrarOrdenes(List<Order> orders)
        {
            dgOrdenes.DataSource = null;
            dgOrdenes.AutoGenerateColumns = true;
            dgOrdenes.Columns.Clear();

            dgOrdenes.DataSource = orders;
        }

        private void MostrarOrdenesPersonalizado(List<Order> orders)
        {
            dgOrdenes.DataSource = null;
            dgOrdenes.AutoGenerateColumns = false;
            dgOrdenes.Columns.Clear();

            if (orders == null || orders.Count == 0)
            {
                return;
            }

            dgOrdenes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                Name = "Id",
                Visible = false,

            });

            dgOrdenes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Shipper_Id",
                HeaderText = "Repartidor",
                Name = "Shipper_Id",
                Visible = false,

            });


            dgOrdenes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Code",
                HeaderText = "Código",
                Name = "Code"
            });

            dgOrdenes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Estado",
                Name = "Status"
            });

            dgOrdenes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Descripción",
                Name = "Description"
            });

            dgOrdenes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DateReceipt",
                HeaderText = "Fecha de Emisión",
                Name = "DateReceipt"
            });

            dgOrdenes.DataSource = orders;
        }

        private void ActualizarVista()
        {
            if (detallesVisiblesOrdenes)
            {
                MostrarOrdenesPersonalizado(nOrder.ListarTodo());
            }
            else
            {
                MostrarOrdenes(nOrder.ListarTodo());
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            detallesVisiblesOrdenes = !detallesVisiblesOrdenes;
            ActualizarVista();
        }

        private void LimpiarFormulario()
        {
            tbCode.Texts = "";
            tbDescription.Texts = "";
            cbEstatus.Texts = "";
            cbShipper.Texts = "";
            dtpDateReceipt.Value = DateTime.Now;
        }

        private void dgOrdenes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgOrdenes.SelectedRows.Count == 0) { return; }

            tbCode.Texts = dgOrdenes.SelectedRows[0].Cells["Code"].Value?.ToString() ?? string.Empty;
            cbShipper.SelectedValue = int.Parse(dgOrdenes.SelectedRows[0].Cells["Shipper_Id"].Value.ToString());
            cbEstatus.Texts = dgOrdenes.SelectedRows[0].Cells["Status"].Value?.ToString() ?? string.Empty;
            tbDescription.Texts = dgOrdenes.SelectedRows[0].Cells["Description"].Value?.ToString() ?? string.Empty;
            dtpDateReceipt.Value = dgOrdenes.SelectedRows[0].Cells["DateReceipt"].Value is DateTime dateReceipt ? dateReceipt : DateTime.Now;
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            {
                if (tbCode.Texts == "" || tbDescription.Texts == "" || cbEstatus.Texts == "" || cbShipper.Texts == "" || dtpDateReceipt.Value.ToString() == "")
                {
                    MessageBox.Show("Por favor llene todos los campos");
                    return;
                }

                int idShipper = int.Parse(cbShipper.SelectedValue.ToString());
                Order order = new Order
                {
                    Shipper_Id = idShipper,
                    Code = tbCode.Texts,
                    Description = tbDescription.Texts,
                    Status = cbEstatus.Texts,
                    DateReceipt = dtpDateReceipt.Value,
                    CreatedBy = NClient.UsuarioLogueado().Id.ToString(),
                    CreatedAt = DateTime.UtcNow,
                    UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                    UpdatedAt = DateTime.UtcNow,
                };

                String mensaje = nOrder.Registrar(order);
                MessageBox.Show(mensaje);
                MostrarOrdenesPersonalizado(nOrder.ListarTodo());
                LimpiarFormulario();

                FormDetalleOrden form = new FormDetalleOrden(order.Id);
                form.ShowDialog();
            }
        }

        private void btnModificarOrden_Click(object sender, EventArgs e)
        {
            if (dgOrdenes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una orden para modificar");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("¿Quieres modificar el detalles de la orden", "Modificar Orden", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FormDetalleOrden form = new FormDetalleOrden(int.Parse(dgOrdenes.SelectedRows[0].Cells["Id"].Value.ToString()));
                form.ShowDialog();
                return;
            }

            if (tbCode.Texts == "" || tbDescription.Texts == "" || cbEstatus.Texts == "" || cbShipper.Texts == "" || dtpDateReceipt.Value.ToString() == "")
            {
                MessageBox.Show("Por favor llene todos los campos");
                return;
            }

            int idShipper = int.Parse(cbShipper.SelectedValue.ToString());
            int idOrder = int.Parse(dgOrdenes.SelectedRows[0].Cells["Id"].Value.ToString());

            Order order = new Order
            {
                Id = idOrder,
                Shipper_Id = idShipper,
                Code = tbCode.Texts,
                Description = tbDescription.Texts,
                Status = cbEstatus.Texts,
                DateReceipt = dtpDateReceipt.Value,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow,
            };

            String mensaje = nOrder.Modificar(order);
            MessageBox.Show(mensaje);
            MostrarOrdenesPersonalizado(nOrder.ListarTodo());
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgOrdenes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una orden para eliminar");
                return;
            }

            int id = Convert.ToInt32(dgOrdenes.SelectedRows[0].Cells["Id"].Value);

            Order order = new Order
            {
                Id = id,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow,
            };

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar la orden?", "Eliminar Orden", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String mensaje = nOrder.EliminarLogico(order);
                MessageBox.Show(mensaje);
                MostrarOrdenesPersonalizado(nOrder.ListarTodo());
                LimpiarFormulario();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBuscar.Texts.Trim()))
            {
                MessageBox.Show("Escribe algo.");
                return;
            }
            var ordenesFiltradas = nOrder.BuscarOrdenes(tbBuscar.Texts.Trim());
            MostrarOrdenesPersonalizado(ordenesFiltradas);
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
            var ordenesOrdenadas = nOrder.OrdenarOrdenes(criterioOrdenacion);
            MostrarOrdenesPersonalizado(ordenesOrdenadas);
            lblBorrarFiltros.Visible = true;
        }

        private void lblBorrarFiltros_Click(object sender, EventArgs e)
        {
            MostrarOrdenesPersonalizado(nOrder.ListarTodo());
            lblBorrarFiltros.Visible = false;
        }

        #endregion

    }
}
