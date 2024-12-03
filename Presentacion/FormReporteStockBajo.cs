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
using Datos;
using IronXL;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace Presentacion
{
    public partial class FormReporteStockBajo : Form
    {
        private NProduct nProduct = new NProduct();
        private NClient nClient = new NClient();

        public FormReporteStockBajo()
        {
            InitializeComponent();
            MostrarProductosPersonalizado(nProduct.ListarProductosStockMinimo());
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
            FormUsuarios form = new FormUsuarios();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnrptStockBajo_Click(object sender, EventArgs e)
        {
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

        private void FormReporteStockBajo_Load(object sender, EventArgs e)
        {
            cbOrdenar.Items.Add("Nombre");
            cbOrdenar.Items.Add("Precio");
            cbOrdenar.Items.Add("Cantidad");

            cbOrdenar.Texts = "";

            if (NClient.UsuarioLogueado().Role == "Trabajador")
            {
                btnUsuarios.Visible = false;
                btnReportes.Visible = false;
                pnlUsuarios.Visible = false;
                pnlReportes.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBuscar.Texts.Trim()))
            {
                MessageBox.Show("Escribe algo.");
                return;
            }
            var productosFiltrados = nProduct.BuscarProductos(tbBuscar.Texts.Trim());
            MostrarProductosPersonalizado(productosFiltrados);
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
            var productosOrdenados = nProduct.OrdenarProductosStockMinimo(criterioOrdenacion);
            MostrarProductosPersonalizado(productosOrdenados);
            lblBorrarFiltros.Visible = true;
        }

        private void MostrarProductosPersonalizado(List<Product> productos)
        {
            dgStockBajo.DataSource = null;
            dgStockBajo.AutoGenerateColumns = false;
            dgStockBajo.Columns.Clear();

            if (productos == null || productos.Count == 0)
            {
                return;
            }

           dgStockBajo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Nombre",
                Name = "Name"
            });

            dgStockBajo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Descripción",
                Name = "Description"
            });


            dgStockBajo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Cantidad",
                Name = "Quantity"
            });

            dgStockBajo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Precio",
                Name = "Price"
            });

            dgStockBajo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MinimumStock",
                HeaderText = "Stock Minimo",
                Name = "MinimumStock"
            });

            dgStockBajo.DataSource = productos;
        }

        private void lblBorrarFiltros_Click(object sender, EventArgs e)
        {
            MostrarProductosPersonalizado(nProduct.ListarProductosStockMinimo());
            lblBorrarFiltros.Visible = false;
        }

        private void btnDownloadPDF_Click(object sender, EventArgs e)
        {
            Document document = new Document(PageSize.A4, 10, 10, 10, 10);

            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DataGridViewExport.pdf");
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                document.Open();

                PdfPTable pdfTable = new PdfPTable(dgStockBajo.Columns.Count);
                pdfTable.WidthPercentage = 100;

                foreach (DataGridViewColumn column in dgStockBajo.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                    {
                        BackgroundColor = new BaseColor(240, 240, 240), 
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dgStockBajo.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string cellValue = cell.Value != null ? cell.Value.ToString() : string.Empty;
                        PdfPCell pdfCell = new PdfPCell(new Phrase(cellValue))
                        {
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        pdfTable.AddCell(pdfCell);
                    }
                }

                document.Add(pdfTable);
                MessageBox.Show("Data exported successfully to PDF on Desktop!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to PDF: " + ex.Message);
            }
            finally
            {
                document.Close();
            }
        }

        private string ConvertToCellAddress(int row, int column)
        {
            string columnLabel = "";
            while (column >= 0)
            {
                columnLabel = (char)('A' + column % 26) + columnLabel;
                column = column / 26 - 1;
            }

            string rowLabel = (row + 1).ToString();
            return columnLabel + rowLabel;
        }

        private void btnDownloadExcel_Click(object sender, EventArgs e)
        {
            WorkBook workbook = new WorkBook();
            WorkSheet worksheet = workbook.CreateWorkSheet("ExportedData");

            for (int i = 0; i < dgStockBajo.Rows.Count; i++)
            {
                for (int j = 0; j < dgStockBajo.Columns.Count; j++)
                {
                    string cellAddress = ConvertToCellAddress(i, j);
                    object cellValue = dgStockBajo.Rows[i].Cells[j].Value;
                    worksheet[cellAddress].Value = cellValue != null ? cellValue.ToString() : "";
                }
            }

            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DataGridViewExport.xlsx");
                workbook.SaveAs(filePath);
                MessageBox.Show("Data exported successfully to Desktop!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a Excel: " + ex.Message);
            }
        }
    }
}
