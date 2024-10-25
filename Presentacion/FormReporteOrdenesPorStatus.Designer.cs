namespace Presentacion
{
    partial class FormReporteOrdenesPorStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteOrdenesPorStatus));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.PictureBox();
            this.SubmenuReportes = new System.Windows.Forms.Panel();
            this.pnlMovimientosDeInventario = new System.Windows.Forms.Panel();
            this.btnrptMovimientosDeInventario = new System.Windows.Forms.Button();
            this.pnlVentasPorFecha = new System.Windows.Forms.Panel();
            this.pnlOrdenesSegunEstado = new System.Windows.Forms.Panel();
            this.btnrptVentasPorFecha = new System.Windows.Forms.Button();
            this.btnrptOrdenesPorStatus = new System.Windows.Forms.Button();
            this.pnlStockBajo = new System.Windows.Forms.Panel();
            this.btnrptStockBajo = new System.Windows.Forms.Button();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.pnlEnvios = new System.Windows.Forms.Panel();
            this.btnEnvios = new System.Windows.Forms.Button();
            this.pnlProveedores = new System.Windows.Forms.Panel();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.pnlOrdenes = new System.Windows.Forms.Panel();
            this.btnOrdenes = new System.Windows.Forms.Button();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            this.SubmenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.BarraTitulo.Controls.Add(this.lblTitulo);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1246, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(26, 25);
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
            this.btnMaximizar.Location = new System.Drawing.Point(1276, 5);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(26, 25);
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
            this.btnCerrar.Location = new System.Drawing.Point(1308, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 25);
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
            this.btnRestaurar.Location = new System.Drawing.Point(1278, 5);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(26, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(122)))), ((int)(((byte)(138)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1346, 965);
            this.panelContenedor.TabIndex = 8;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.MenuVertical.Controls.Add(this.btnsalir);
            this.MenuVertical.Controls.Add(this.SubmenuReportes);
            this.MenuVertical.Controls.Add(this.pnlReportes);
            this.MenuVertical.Controls.Add(this.btnReportes);
            this.MenuVertical.Controls.Add(this.pnlUsuarios);
            this.MenuVertical.Controls.Add(this.btnUsuarios);
            this.MenuVertical.Controls.Add(this.pnlEnvios);
            this.MenuVertical.Controls.Add(this.btnEnvios);
            this.MenuVertical.Controls.Add(this.pnlProveedores);
            this.MenuVertical.Controls.Add(this.btnProveedores);
            this.MenuVertical.Controls.Add(this.pnlOrdenes);
            this.MenuVertical.Controls.Add(this.btnOrdenes);
            this.MenuVertical.Controls.Add(this.pnlProductos);
            this.MenuVertical.Controls.Add(this.btnProductos);
            this.MenuVertical.Controls.Add(this.pbLogo);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 35);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(330, 965);
            this.MenuVertical.TabIndex = 22;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::Presentacion.Properties.Resources.shutdown;
            this.btnsalir.Location = new System.Drawing.Point(8, 858);
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
            this.SubmenuReportes.Controls.Add(this.pnlMovimientosDeInventario);
            this.SubmenuReportes.Controls.Add(this.btnrptMovimientosDeInventario);
            this.SubmenuReportes.Controls.Add(this.pnlVentasPorFecha);
            this.SubmenuReportes.Controls.Add(this.btnrptVentasPorFecha);
            this.SubmenuReportes.Controls.Add(this.pnlOrdenesSegunEstado);
            this.SubmenuReportes.Controls.Add(this.btnrptOrdenesPorStatus);
            this.SubmenuReportes.Controls.Add(this.pnlStockBajo);
            this.SubmenuReportes.Controls.Add(this.btnrptStockBajo);
            this.SubmenuReportes.Location = new System.Drawing.Point(66, 589);
            this.SubmenuReportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmenuReportes.Name = "SubmenuReportes";
            this.SubmenuReportes.Size = new System.Drawing.Size(268, 242);
            this.SubmenuReportes.TabIndex = 17;
            // 
            // pnlMovimientosDeInventario
            // 
            this.pnlMovimientosDeInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.pnlMovimientosDeInventario.Location = new System.Drawing.Point(0, 157);
            this.pnlMovimientosDeInventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMovimientosDeInventario.Name = "pnlMovimientosDeInventario";
            this.pnlMovimientosDeInventario.Size = new System.Drawing.Size(8, 71);
            this.pnlMovimientosDeInventario.TabIndex = 19;
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
            this.btnrptMovimientosDeInventario.Location = new System.Drawing.Point(8, 155);
            this.btnrptMovimientosDeInventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnrptMovimientosDeInventario.Name = "btnrptMovimientosDeInventario";
            this.btnrptMovimientosDeInventario.Size = new System.Drawing.Size(264, 83);
            this.btnrptMovimientosDeInventario.TabIndex = 20;
            this.btnrptMovimientosDeInventario.Text = "Movimientos de Inventario";
            this.btnrptMovimientosDeInventario.UseVisualStyleBackColor = false;
            this.btnrptMovimientosDeInventario.Click += new System.EventHandler(this.btnrptMovimientosDeInventario_Click);
            // 
            // pnlVentasPorFecha
            // 
            this.pnlVentasPorFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.pnlVentasPorFecha.Location = new System.Drawing.Point(0, 105);
            this.pnlVentasPorFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlVentasPorFecha.Name = "pnlVentasPorFecha";
            this.pnlVentasPorFecha.Size = new System.Drawing.Size(8, 43);
            this.pnlVentasPorFecha.TabIndex = 19;
            // 
            // pnlOrdenesSegunEstado
            // 
            this.pnlOrdenesSegunEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(122)))), ((int)(((byte)(138)))));
            this.pnlOrdenesSegunEstado.Location = new System.Drawing.Point(0, 52);
            this.pnlOrdenesSegunEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOrdenesSegunEstado.Name = "pnlOrdenesSegunEstado";
            this.pnlOrdenesSegunEstado.Size = new System.Drawing.Size(8, 43);
            this.pnlOrdenesSegunEstado.TabIndex = 19;
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
            // pnlStockBajo
            // 
            this.pnlStockBajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.pnlStockBajo.Location = new System.Drawing.Point(0, 0);
            this.pnlStockBajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlStockBajo.Name = "pnlStockBajo";
            this.pnlStockBajo.Size = new System.Drawing.Size(8, 43);
            this.pnlStockBajo.TabIndex = 17;
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
            // pnlReportes
            // 
            this.pnlReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(122)))), ((int)(((byte)(138)))));
            this.pnlReportes.Location = new System.Drawing.Point(4, 529);
            this.pnlReportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(8, 49);
            this.pnlReportes.TabIndex = 14;
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
            this.btnReportes.Location = new System.Drawing.Point(8, 529);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(326, 49);
            this.btnReportes.TabIndex = 13;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.pnlUsuarios.Location = new System.Drawing.Point(4, 471);
            this.pnlUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(8, 49);
            this.pnlUsuarios.TabIndex = 10;
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
            // pnlEnvios
            // 
            this.pnlEnvios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.pnlEnvios.Location = new System.Drawing.Point(4, 412);
            this.pnlEnvios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEnvios.Name = "pnlEnvios";
            this.pnlEnvios.Size = new System.Drawing.Size(8, 49);
            this.pnlEnvios.TabIndex = 8;
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
            this.btnEnvios.Location = new System.Drawing.Point(8, 412);
            this.btnEnvios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnvios.Name = "btnEnvios";
            this.btnEnvios.Size = new System.Drawing.Size(326, 49);
            this.btnEnvios.TabIndex = 7;
            this.btnEnvios.Text = "Envios";
            this.btnEnvios.UseVisualStyleBackColor = false;
            this.btnEnvios.Click += new System.EventHandler(this.btnEnvios_Click);
            // 
            // pnlProveedores
            // 
            this.pnlProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.pnlProveedores.Location = new System.Drawing.Point(4, 354);
            this.pnlProveedores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlProveedores.Name = "pnlProveedores";
            this.pnlProveedores.Size = new System.Drawing.Size(8, 49);
            this.pnlProveedores.TabIndex = 6;
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
            // pnlOrdenes
            // 
            this.pnlOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.pnlOrdenes.Location = new System.Drawing.Point(4, 295);
            this.pnlOrdenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOrdenes.Name = "pnlOrdenes";
            this.pnlOrdenes.Size = new System.Drawing.Size(8, 49);
            this.pnlOrdenes.TabIndex = 4;
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
            this.btnOrdenes.Location = new System.Drawing.Point(8, 295);
            this.btnOrdenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrdenes.Name = "btnOrdenes";
            this.btnOrdenes.Size = new System.Drawing.Size(326, 49);
            this.btnOrdenes.TabIndex = 3;
            this.btnOrdenes.Text = "Ordenes";
            this.btnOrdenes.UseVisualStyleBackColor = false;
            this.btnOrdenes.Click += new System.EventHandler(this.btnOrdenes_Click);
            // 
            // pnlProductos
            // 
            this.pnlProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.pnlProductos.Location = new System.Drawing.Point(4, 237);
            this.pnlProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(8, 49);
            this.pnlProductos.TabIndex = 2;
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
            // pbLogo
            // 
            this.pbLogo.Image = global::Presentacion.Properties.Resources.logo_color;
            this.pbLogo.Location = new System.Drawing.Point(0, 72);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(330, 111);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(619, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(288, 23);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Reporte Ordenar por Estado";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReporteOrdenesPorStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 1000);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteOrdenesPorStatus";
            this.Text = "FormReporteOrdenesPorStatus";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            this.SubmenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox btnsalir;
        private System.Windows.Forms.Panel SubmenuReportes;
        private System.Windows.Forms.Panel pnlMovimientosDeInventario;
        private System.Windows.Forms.Button btnrptMovimientosDeInventario;
        private System.Windows.Forms.Panel pnlVentasPorFecha;
        private System.Windows.Forms.Panel pnlOrdenesSegunEstado;
        private System.Windows.Forms.Button btnrptVentasPorFecha;
        private System.Windows.Forms.Button btnrptOrdenesPorStatus;
        private System.Windows.Forms.Panel pnlStockBajo;
        private System.Windows.Forms.Button btnrptStockBajo;
        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel pnlEnvios;
        private System.Windows.Forms.Button btnEnvios;
        private System.Windows.Forms.Panel pnlProveedores;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Panel pnlOrdenes;
        private System.Windows.Forms.Button btnOrdenes;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitulo;
    }
}