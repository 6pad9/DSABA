using Negocio;
using System;
using System.Windows.Forms;
using Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presentacion
{
    public partial class FormProveedores : Form
    {
        private NSupplier nSupplier= new NSupplier();
        private NClient nClient = new NClient();

        private bool detallesVisiblesProveedores= false;

        public FormProveedores()
        {
            InitializeComponent();
            MostrarProveedoresPersonalizado(nSupplier.ListarTodo());
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            cbOrdenar.Items.Add("Nombre");
            cbOrdenar.Items.Add("Teléfono");

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

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FormCategorias form = new FormCategorias();
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

        #region -> CRUD Proveedores
        private void MostrarProveedores(List<Supplier> suppliers)
        {
            dgProveedores.DataSource = null;
            dgProveedores.AutoGenerateColumns = true;
            dgProveedores.Columns.Clear();

            dgProveedores.DataSource = suppliers;
        }

        private void MostrarProveedoresPersonalizado (List<Supplier> suppliers)
        {
            dgProveedores.DataSource = null;
            dgProveedores.AutoGenerateColumns = false;
            dgProveedores.Columns.Clear();

            if (suppliers == null || suppliers.Count == 0)
            {
                return;
            }

            dgProveedores.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name="Id",
                Visible = false
            });

            dgProveedores.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Name",
                HeaderText = "Nombre",
                Name= "Name",
            });

            dgProveedores.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Phone",
                HeaderText = "Teléfono",
                Name="Phone",
            });
            dgProveedores.DataSource = suppliers;
        }

        private void ActualizarVista()
        {
            if (detallesVisiblesProveedores)
            {
                MostrarProveedoresPersonalizado(nSupplier.ListarTodo());
            }
            else
            {
                MostrarProveedores(nSupplier.ListarTodo());
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            detallesVisiblesProveedores = !detallesVisiblesProveedores;
            ActualizarVista();
        }

        private void LimpiarFormulario()
        {
            tbNombre.Texts = "";
            tbNumero.Texts = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Texts == "" || tbNumero.Texts == "")
            {
                MessageBox.Show("Por favor, llene todos los campos");
                return;
            }

            Supplier supplier = new Supplier()
            {
                Name = tbNombre.Texts,
                Phone = tbNumero.Texts,
                CreatedBy = NClient.UsuarioLogueado().Id.ToString(),
                CreatedAt = DateTime.UtcNow,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow
            };

            String mensaje = nSupplier.Registrar(supplier);
            MessageBox.Show(mensaje);
            MostrarProveedoresPersonalizado(nSupplier.ListarTodo());
            LimpiarFormulario();

            FormProductoProveedor form = new FormProductoProveedor(supplier.Id);
            form.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Texts == "" || tbNumero.Texts == "")
            {
                MessageBox.Show("Por favor, llene todos los campos");
                return;
            }

            if(dgProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor");
                return;
            }

            int id = int.Parse(dgProveedores.SelectedRows[0].Cells["Id"].Value.ToString());

            Supplier supplier = new Supplier()
            {
                Id = id,
                Name = tbNombre.Texts,
                Phone = tbNumero.Texts,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow
            };

            DialogResult dialogResult = MessageBox.Show("¿Quieres modificar los productos del proveedor?", "Modificar Proveedor", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FormProductoProveedor form = new FormProductoProveedor(int.Parse(dgProveedores.SelectedRows[0].Cells["Id"].Value.ToString()));
                form.ShowDialog();
                return;
            }

            String mensaje = nSupplier.Modificar(supplier);
            MessageBox.Show(mensaje);
            MostrarProveedoresPersonalizado(nSupplier.ListarTodo());
            LimpiarFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgProveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor");
                return;
            }

            int id = int.Parse(dgProveedores.SelectedRows[0].Cells["Id"].Value.ToString());

            Supplier supplier = new Supplier()
            {
                Id = id,
                UpdatedBy = NClient.UsuarioLogueado().Id.ToString(),
                UpdatedAt = DateTime.UtcNow
            };

            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar el proveedor?", "Eliminar Proveedor", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String mensaje = nSupplier.EliminarLogico(supplier);
                MessageBox.Show(mensaje);
                MostrarProveedoresPersonalizado(nSupplier.ListarTodo());
                LimpiarFormulario();
            }           
        }

        private void dgProveedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgProveedores.SelectedRows.Count == 0) { return; }

            tbNombre.Texts = dgProveedores.SelectedRows[0].Cells["Name"].Value.ToString();
            tbNumero.Texts = dgProveedores.SelectedRows[0].Cells["Phone"].Value.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(tbBuscar.Texts == "")
            {
                MessageBox.Show("Por favor, llene el campo de búsqueda");
                return;
            }
            var productosFiltrados = nSupplier.BuscarProveedores(tbBuscar.Texts);
            MostrarProveedoresPersonalizado(productosFiltrados);
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
            var productosOrdenados = nSupplier.OrdenarProveedores(criterioOrdenacion);
            MostrarProveedoresPersonalizado(productosOrdenados);
            lblBorrarFiltros.Visible = true;
        }

        private void lblBorrarFiltros_Click(object sender, EventArgs e)
        {
            MostrarProveedoresPersonalizado(nSupplier.ListarTodo());
            lblBorrarFiltros.Visible = false;
        }

        #endregion


    }
}
