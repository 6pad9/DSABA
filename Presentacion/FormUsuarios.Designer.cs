namespace Presentacion
{
    partial class FormUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnRegistrarCategoria = new Presentacion.RJControls.RJButton();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.PictureBox();
            this.SubmenuReportes = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnrptMovimientosDeInventario = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnrptVentasPorFecha = new System.Windows.Forms.Button();
            this.btnrptOrdenesPorStatus = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnrptStockBajo = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEnvios = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrarProducto = new Presentacion.RJControls.RJButton();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            this.SubmenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1346, 35);
            this.BarraTitulo.TabIndex = 6;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Presentacion.Properties.Resources.minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(1246, 4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::Presentacion.Properties.Resources.restore;
            this.btnMaximizar.Location = new System.Drawing.Point(1277, 4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Presentacion.Properties.Resources.close;
            this.btnCerrar.Location = new System.Drawing.Point(1308, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::Presentacion.Properties.Resources.maximize;
            this.btnRestaurar.Location = new System.Drawing.Point(1278, 4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(122)))), ((int)(((byte)(138)))));
            this.panelContenedor.Controls.Add(this.btnRegistrarCategoria);
            this.panelContenedor.Controls.Add(this.MenuVertical);
            this.panelContenedor.Controls.Add(this.btnRegistrarProducto);
            this.panelContenedor.Controls.Add(this.dgProductos);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1346, 965);
            this.panelContenedor.TabIndex = 8;
            // 
            // btnRegistrarCategoria
            // 
            this.btnRegistrarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnRegistrarCategoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnRegistrarCategoria.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegistrarCategoria.BorderRadius = 15;
            this.btnRegistrarCategoria.BorderSize = 0;
            this.btnRegistrarCategoria.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCategoria.Location = new System.Drawing.Point(1071, 441);
            this.btnRegistrarCategoria.Name = "btnRegistrarCategoria";
            this.btnRegistrarCategoria.Size = new System.Drawing.Size(245, 40);
            this.btnRegistrarCategoria.TabIndex = 23;
            this.btnRegistrarCategoria.Text = "Registrar Categoria de Producto";
            this.btnRegistrarCategoria.TextColor = System.Drawing.Color.White;
            this.btnRegistrarCategoria.UseVisualStyleBackColor = false;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.MenuVertical.Controls.Add(this.btnsalir);
            this.MenuVertical.Controls.Add(this.SubmenuReportes);
            this.MenuVertical.Controls.Add(this.panel7);
            this.MenuVertical.Controls.Add(this.btnReportes);
            this.MenuVertical.Controls.Add(this.panel5);
            this.MenuVertical.Controls.Add(this.btnUsuarios);
            this.MenuVertical.Controls.Add(this.panel4);
            this.MenuVertical.Controls.Add(this.btnEnvios);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.btnProveedores);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.btnOrdenes);
            this.MenuVertical.Controls.Add(this.panel1);
            this.MenuVertical.Controls.Add(this.btnProductos);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(330, 965);
            this.MenuVertical.TabIndex = 22;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::Presentacion.Properties.Resources.shutdown;
            this.btnsalir.Location = new System.Drawing.Point(8, 859);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(82, 92);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 16;
            this.btnsalir.TabStop = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // SubmenuReportes
            // 
            this.SubmenuReportes.Controls.Add(this.panel12);
            this.SubmenuReportes.Controls.Add(this.btnrptMovimientosDeInventario);
            this.SubmenuReportes.Controls.Add(this.panel8);
            this.SubmenuReportes.Controls.Add(this.panel10);
            this.SubmenuReportes.Controls.Add(this.btnrptVentasPorFecha);
            this.SubmenuReportes.Controls.Add(this.btnrptOrdenesPorStatus);
            this.SubmenuReportes.Controls.Add(this.panel9);
            this.SubmenuReportes.Controls.Add(this.btnrptStockBajo);
            this.SubmenuReportes.Location = new System.Drawing.Point(66, 589);
            this.SubmenuReportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmenuReportes.Name = "SubmenuReportes";
            this.SubmenuReportes.Size = new System.Drawing.Size(268, 241);
            this.SubmenuReportes.TabIndex = 17;
            this.SubmenuReportes.Visible = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.panel12.Location = new System.Drawing.Point(0, 157);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 60);
            this.panel12.TabIndex = 19;
            // 
            // btnrptMovimientosDeInventario
            // 
            this.btnrptMovimientosDeInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.btnrptMovimientosDeInventario.FlatAppearance.BorderSize = 0;
            this.btnrptMovimientosDeInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptMovimientosDeInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptMovimientosDeInventario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptMovimientosDeInventario.ForeColor = System.Drawing.Color.White;
            this.btnrptMovimientosDeInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptMovimientosDeInventario.Location = new System.Drawing.Point(8, 156);
            this.btnrptMovimientosDeInventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrptMovimientosDeInventario.Name = "btnrptMovimientosDeInventario";
            this.btnrptMovimientosDeInventario.Size = new System.Drawing.Size(264, 59);
            this.btnrptMovimientosDeInventario.TabIndex = 20;
            this.btnrptMovimientosDeInventario.Text = "Movimientos de Inventario";
            this.btnrptMovimientosDeInventario.UseVisualStyleBackColor = false;
            this.btnrptMovimientosDeInventario.Click += new System.EventHandler(this.btnrptMovimientosDeInventario_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.panel8.Location = new System.Drawing.Point(0, 105);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(8, 43);
            this.panel8.TabIndex = 19;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.panel10.Location = new System.Drawing.Point(0, 52);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(8, 43);
            this.panel10.TabIndex = 19;
            // 
            // btnrptVentasPorFecha
            // 
            this.btnrptVentasPorFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.btnrptVentasPorFecha.FlatAppearance.BorderSize = 0;
            this.btnrptVentasPorFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptVentasPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptVentasPorFecha.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptVentasPorFecha.ForeColor = System.Drawing.Color.White;
            this.btnrptVentasPorFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptVentasPorFecha.Location = new System.Drawing.Point(4, 105);
            this.btnrptVentasPorFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrptVentasPorFecha.Name = "btnrptVentasPorFecha";
            this.btnrptVentasPorFecha.Size = new System.Drawing.Size(264, 43);
            this.btnrptVentasPorFecha.TabIndex = 18;
            this.btnrptVentasPorFecha.Text = "Ventas por Fecha";
            this.btnrptVentasPorFecha.UseVisualStyleBackColor = false;
            this.btnrptVentasPorFecha.Click += new System.EventHandler(this.btnrptVentasPorFecha_Click);
            // 
            // btnrptOrdenesPorStatus
            // 
            this.btnrptOrdenesPorStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.btnrptOrdenesPorStatus.FlatAppearance.BorderSize = 0;
            this.btnrptOrdenesPorStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptOrdenesPorStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptOrdenesPorStatus.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptOrdenesPorStatus.ForeColor = System.Drawing.Color.White;
            this.btnrptOrdenesPorStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptOrdenesPorStatus.Location = new System.Drawing.Point(4, 52);
            this.btnrptOrdenesPorStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrptOrdenesPorStatus.Name = "btnrptOrdenesPorStatus";
            this.btnrptOrdenesPorStatus.Size = new System.Drawing.Size(264, 43);
            this.btnrptOrdenesPorStatus.TabIndex = 18;
            this.btnrptOrdenesPorStatus.Text = "Ordenes segun Estado";
            this.btnrptOrdenesPorStatus.UseVisualStyleBackColor = false;
            this.btnrptOrdenesPorStatus.Click += new System.EventHandler(this.btnrptOrdenesPorStatus_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(8, 43);
            this.panel9.TabIndex = 17;
            // 
            // btnrptStockBajo
            // 
            this.btnrptStockBajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.btnrptStockBajo.FlatAppearance.BorderSize = 0;
            this.btnrptStockBajo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptStockBajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptStockBajo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptStockBajo.ForeColor = System.Drawing.Color.White;
            this.btnrptStockBajo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptStockBajo.Location = new System.Drawing.Point(4, 0);
            this.btnrptStockBajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrptStockBajo.Name = "btnrptStockBajo";
            this.btnrptStockBajo.Size = new System.Drawing.Size(264, 43);
            this.btnrptStockBajo.TabIndex = 16;
            this.btnrptStockBajo.Text = "Stock Bajo";
            this.btnrptStockBajo.UseVisualStyleBackColor = false;
            this.btnrptStockBajo.Click += new System.EventHandler(this.btnrptStockBajo_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.panel7.Location = new System.Drawing.Point(4, 530);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(8, 49);
            this.panel7.TabIndex = 14;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(8, 530);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(326, 49);
            this.btnReportes.TabIndex = 13;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(122)))), ((int)(((byte)(138)))));
            this.panel5.Location = new System.Drawing.Point(4, 471);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(8, 49);
            this.panel5.TabIndex = 10;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(8, 471);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(326, 49);
            this.btnUsuarios.TabIndex = 9;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.panel4.Location = new System.Drawing.Point(4, 413);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 49);
            this.panel4.TabIndex = 8;
            // 
            // btnEnvios
            // 
            this.btnEnvios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.btnEnvios.FlatAppearance.BorderSize = 0;
            this.btnEnvios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEnvios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvios.ForeColor = System.Drawing.Color.White;
            this.btnEnvios.Image = ((System.Drawing.Image)(resources.GetObject("btnEnvios.Image")));
            this.btnEnvios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnvios.Location = new System.Drawing.Point(8, 413);
            this.btnEnvios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnvios.Name = "btnEnvios";
            this.btnEnvios.Size = new System.Drawing.Size(326, 49);
            this.btnEnvios.TabIndex = 7;
            this.btnEnvios.Text = "Envios";
            this.btnEnvios.UseVisualStyleBackColor = false;
            this.btnEnvios.Click += new System.EventHandler(this.btnEnvios_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.panel3.Location = new System.Drawing.Point(4, 354);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 49);
            this.panel3.TabIndex = 6;
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(8, 354);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(326, 49);
            this.btnProveedores.TabIndex = 5;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.panel2.Location = new System.Drawing.Point(4, 296);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 49);
            this.panel2.TabIndex = 4;
            // 
            // btnOrdenes
            // 
            this.btnOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.btnOrdenes.FlatAppearance.BorderSize = 0;
            this.btnOrdenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenes.ForeColor = System.Drawing.Color.White;
            this.btnOrdenes.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenes.Image")));
            this.btnOrdenes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenes.Location = new System.Drawing.Point(8, 296);
            this.btnOrdenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(326, 49);
            this.btnOrdenes.TabIndex = 3;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.panel1.Location = new System.Drawing.Point(4, 237);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 49);
            this.panel1.TabIndex = 2;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(8, 237);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(326, 49);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.logo_color;
            this.pictureBox1.Location = new System.Drawing.Point(0, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnRegistrarProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnRegistrarProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegistrarProducto.BorderRadius = 15;
            this.btnRegistrarProducto.BorderSize = 0;
            this.btnRegistrarProducto.FlatAppearance.BorderSize = 0;
            this.btnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarProducto.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarProducto.Location = new System.Drawing.Point(363, 441);
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(188, 40);
            this.btnRegistrarProducto.TabIndex = 17;
            this.btnRegistrarProducto.Text = "Registrar/Editar Orden";
            this.btnRegistrarProducto.TextColor = System.Drawing.Color.White;
            this.btnRegistrarProducto.UseVisualStyleBackColor = false;
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(363, 72);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowHeadersWidth = 62;
            this.dgProductos.RowTemplate.Height = 28;
            this.dgProductos.Size = new System.Drawing.Size(953, 341);
            this.dgProductos.TabIndex = 0;
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 1000);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuarios";
            this.Text = "FormUsuarios";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            this.SubmenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Panel panelContenedor;
        private RJControls.RJButton btnRegistrarCategoria;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox btnsalir;
        private System.Windows.Forms.Panel SubmenuReportes;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnrptMovimientosDeInventario;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnrptVentasPorFecha;
        private System.Windows.Forms.Button btnrptOrdenesPorStatus;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnrptStockBajo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnEnvios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJControls.RJButton btnRegistrarProducto;
        private System.Windows.Forms.DataGridView dgProductos;
    }
}