﻿using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormEnvios : Form
    {
        public FormEnvios()
        {
            InitializeComponent();
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
        #endregion

        #region-> Botones de navegacion
        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            FormOrdenes form = new FormOrdenes();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FormProveedores form = new FormProveedores();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos form = new FormProductos();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }
        #endregion

        #region-> Botones Multiusuario
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuarios form = new FormUsuarios();
            form.Show();
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
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnrptOrdenesPorStatus_Click(object sender, EventArgs e)
        {
            FormReporteOrdenesPorStatus form = new FormReporteOrdenesPorStatus();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnrptVentasPorFecha_Click(object sender, EventArgs e)
        {
            FormReporteVentasPorFecha form = new FormReporteVentasPorFecha();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }

        private void btnrptMovimientosDeInventario_Click(object sender, EventArgs e)
        {
            FormReporteMovimientosDeInventario form = new FormReporteMovimientosDeInventario();
            form.Show();
            this.Hide();
            form.FormClosed += (s, args) => this.Close();
        }
        #endregion

    }
}
