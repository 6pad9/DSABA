using Datos;
using IronXL;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormReporteMovimientosDeInventario : Form
    {
        private NInventoryMovement nInventoryMovement = new NInventoryMovement();
        private NClient nClient = new NClient();

        private bool detallesVisiblesMovimientosDeInventario = false;

        public FormReporteMovimientosDeInventario()
        {
            InitializeComponent();
            MostrarMovimientosDeInventarioPersonalizado(nInventoryMovement.ListarTodo());
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

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FormProveedores form = new FormProveedores();
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
            FormReporteVentasPorFecha form = new FormReporteVentasPorFecha();
            AbrirFormularioSecundario(form);
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnrptMovimientosDeInventario_Click(object sender, EventArgs e)
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

        private void MostrarMovimientosDeInventario(List<InventoryMovement> inventoryMovements)
        {
            dgMovimientos.DataSource = null;
            dgMovimientos.AutoGenerateColumns = true;
            dgMovimientos.Columns.Clear();

            dgMovimientos.DataSource = inventoryMovements;
        }

        private void MostrarMovimientosDeInventarioPersonalizado(List<InventoryMovement> inventoryMovements)
        {
            dgMovimientos.DataSource = null;
            dgMovimientos.AutoGenerateColumns = false;
            dgMovimientos.Columns.Clear();


            if (dgMovimientos == null || inventoryMovements.Count == 0)
            {
                return;
            }
            dgMovimientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id",
                Name = "Id",
                Visible = false,

            });

            dgMovimientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Order_Id",
                HeaderText = "Id",
                Name = "Order_Id",
                Visible = false,

            });

            dgMovimientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Product_Id",
                HeaderText = "Id",
                Name = "Product_Id",
                Visible = false,

            });

            dgMovimientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Cantidad",
                Name = "Quantity"
            });

            dgMovimientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TypeMovement",
                HeaderText = "Tipo de Movimiento",
                Name = "TypeMovement"
            });

            dgMovimientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Remarks",
                HeaderText = "Observaciones",
                Name = "Remarks"
            });

            dgMovimientos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MovementDate",
                HeaderText = "Fecha de Movimiento",
                Name = "MovementDate"
            });

            dgMovimientos.DataSource = inventoryMovements;
        }

        private void ActualizarVista()
        {
            if(detallesVisiblesMovimientosDeInventario)
            {
                MostrarMovimientosDeInventarioPersonalizado(nInventoryMovement.ListarTodo());
            }
            else
            {
                MostrarMovimientosDeInventario(nInventoryMovement.ListarTodo());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbBuscar.Texts.Trim()))
            {
                MessageBox.Show("Escribe algo.");
                return;
            }
            var movimientosDeinventarioFiltrados = nInventoryMovement.BuscarMovimientosDeInventario(tbBuscar.Texts.Trim());
            MostrarMovimientosDeInventarioPersonalizado(movimientosDeinventarioFiltrados);
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
            var movimientosDeInventarioOrdenados = nInventoryMovement.OrdenarMovimientosDeInventario(criterioOrdenacion);
            MostrarMovimientosDeInventarioPersonalizado(movimientosDeInventarioOrdenados);
            lblBorrarFiltros.Visible = true;
        }

        private void btnOrderByTipe_Click(object sender, EventArgs e)
        {
            String criterioOrdenacion = cbOrdenar.Texts;
            if (string.IsNullOrEmpty(criterioOrdenacion))
            {
                MessageBox.Show("Por favor, selecciona un tipo.");
                return;
            }
            var movimientosDeInventarioOrdenados = nInventoryMovement.ListarPorTipo(criterioOrdenacion);
            MostrarMovimientosDeInventarioPersonalizado(movimientosDeInventarioOrdenados);
            lblBorrarFiltros.Visible = true;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            detallesVisiblesMovimientosDeInventario = !detallesVisiblesMovimientosDeInventario;
            ActualizarVista();
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

                PdfPTable pdfTable = new PdfPTable(dgMovimientos.Columns.Count);
                pdfTable.WidthPercentage = 100;

                foreach (DataGridViewColumn column in dgMovimientos.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText))
                    {
                        BackgroundColor = new BaseColor(240, 240, 240),
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dgMovimientos.Rows)
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

            for (int i = 0; i < dgMovimientos.Rows.Count; i++)
            {
                for (int j = 0; j < dgMovimientos.Columns.Count; j++)
                {
                    string cellAddress = ConvertToCellAddress(i, j);
                    object cellValue = dgMovimientos.Rows[i].Cells[j].Value;
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
            MostrarMovimientosDeInventarioPersonalizado(nInventoryMovement.ListarTodo());
            lblBorrarFiltros.Visible = false;
        }

        private void FormReporteMovimientosDeInventario_Load(object sender, EventArgs e)
        {
            cbTipo.Items.Add("Entrada");
            cbTipo.Items.Add("Salida");

            cbOrdenar.Items.Add("Cantidad");
            cbOrdenar.Items.Add("Tipo de Movimiento");
            cbOrdenar.Items.Add("Observaciones");
        }
    }
}
