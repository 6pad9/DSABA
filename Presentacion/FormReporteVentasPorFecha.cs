using Datos;
using IronXL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormReporteVentasPorFecha : Form
    {
        private NOrder nOrder = new NOrder();
        private NClient nClient = new NClient();
        private List<Order> orders;
        private decimal total;
        private DateTime hoy = DateTime.UtcNow;

        public FormReporteVentasPorFecha()
        {
            InitializeComponent();
            var reporte = nOrder.ReporteVentasConDetalle(hoy);
            orders = reporte.Item1;
            total = reporte.Item2;
            MostrarOrdenesPersonalizada(orders);
            lblVentas.Text = total.ToString("C");
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

        private void MostrarOrdenesPersonalizada(List<Order> orders)
        {
            dgVentas.DataSource = null;
            dgVentas.AutoGenerateColumns = false;
            dgVentas.Columns.Clear();

            if (orders == null || orders.Count == 0)
            {
                return;
            }

            dgVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Code",
                HeaderText = "Código",
                Name = "Code"
            });

            dgVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Estado",
                Name = "Status"
            });


            dgVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Descripción",
                Name = "Description"
            });

            dgVentas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DateReceipt",
                HeaderText = "Fecha de emisión",
                Name = "DateReceipt"
            });

            dgVentas.DataSource = orders;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBuscar.Texts.Trim()))
            {
                MessageBox.Show("Escribe algo.");
                return;
            }
            var ordenesFiltradas = nOrder.BuscarReporteVentas(orders, tbBuscar.Texts.Trim());
            MostrarOrdenesPersonalizada(ordenesFiltradas);
            lblBorrarFiltros.Visible = true;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string criterioOrdenacion = cbOrdenar.Texts;
            if (string.IsNullOrEmpty(criterioOrdenacion))
            {
                MessageBox.Show("Por favor, selecciona un criterio de ordenación.");
                return;
            }

            var ordenesOrdenadas = nOrder.OrdenarReporteVentas(orders, criterioOrdenacion);
            MostrarOrdenesPersonalizada(ordenesOrdenadas);

            lblBorrarFiltros.Visible = true;
        }

        private void btnFiltrarVentas_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime? fechaFin = dtpFechaFin.Visible ? dtpFechaFin.Value : (DateTime?)null;

            if (fechaInicio > hoy || (fechaFin.HasValue && fechaInicio > fechaFin.Value))
            {
                MessageBox.Show("Las fechas seleccionadas no son válidas.");
                return;
            }

            var reporte = nOrder.ReporteVentasConDetalle(fechaInicio, fechaFin);
            orders = reporte.Item1;
            total = reporte.Item2;

            MostrarOrdenesPersonalizada(orders);
            lblVentas.Text = total.ToString("C");

            lblBorrarFiltros.Visible = true;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            dtpFechaFin.Visible = !dtpFechaFin.Visible; 
            lblVentasNombre.Visible = !lblVentasNombre.Visible;
            checkBox1.Checked = dtpFechaFin.Visible;  
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

        private void btnDownloadPDF_Click(object sender, EventArgs e)
        {
            Document document = new Document(PageSize.A4, 10, 10, 10, 10);

            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DataGridViewExport.pdf");
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                document.Open();

                PdfPTable pdfTable = new PdfPTable(dgVentas.Columns.Count);
                pdfTable.WidthPercentage = 100;

                foreach (DataGridViewColumn column in dgVentas.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                    {
                        BackgroundColor = new BaseColor(240, 240, 240),
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dgVentas.Rows)
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

        private void btnDownloadExcel_Click(object sender, EventArgs e)
        {
            WorkBook workbook = new WorkBook();
            WorkSheet worksheet = workbook.CreateWorkSheet("ExportedData");

            for (int i = 0; i < dgVentas.Rows.Count; i++)
            {
                for (int j = 0; j < dgVentas.Columns.Count; j++)
                {
                    string cellAddress = ConvertToCellAddress(i, j);
                    object cellValue = dgVentas.Rows[i].Cells[j].Value;
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

        private void lblBorrarFiltros_Click(object sender, EventArgs e)
        {
            MostrarOrdenesPersonalizada(orders);
            lblBorrarFiltros.Visible = false;
        }

        private void FormReporteVentasPorFecha_Load(object sender, EventArgs e)
        {
            cbOrdenar.Items.Add("Código");
            cbOrdenar.Items.Add("Descripción");
            cbOrdenar.Items.Add("Estado");
            cbOrdenar.Items.Add("Fecha de Emisión");
        }
    }
}
