namespace Presentacion
{
    partial class FormOrdenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdenes));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelOrdenes = new System.Windows.Forms.Panel();
            this.tlpOrdenes = new System.Windows.Forms.TableLayoutPanel();
            this.tlpContenidoAgregarEditar = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new Presentacion.RJControls.RJTextBoxSinBorde();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.tbDetalle = new Presentacion.RJControls.RJTextBoxSinBorde();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new Presentacion.RJControls.RJComboBox();
            this.tlpFiltro = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new Presentacion.RJControls.RJButton();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.tbBuscar = new Presentacion.RJControls.RJTextBoxSinBorde();
            this.cbOrdenar = new Presentacion.RJControls.RJComboBox();
            this.btnOrdenar = new Presentacion.RJControls.RJButton();
            this.dgOrdenes = new System.Windows.Forms.DataGridView();
            this.tlpCrud = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new Presentacion.RJControls.RJButton();
            this.btnDetalles = new Presentacion.RJControls.RJButton();
            this.tlpAgregarEditar = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarEditarProducto = new Presentacion.RJControls.RJButton();
            this.lblAgregarEditar = new System.Windows.Forms.Label();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.PictureBox();
            this.SubmenuReportes = new System.Windows.Forms.Panel();
            this.pnlMovimientosDeInventario = new System.Windows.Forms.Panel();
            this.btnrptMovimientosDeInventario = new System.Windows.Forms.Button();
            this.pnlVentasPorFecha = new System.Windows.Forms.Panel();
            this.btnrptVentasPorFecha = new System.Windows.Forms.Button();
            this.pnlOrdenesSegunEstado = new System.Windows.Forms.Panel();
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
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.panelOrdenes.SuspendLayout();
            this.tlpOrdenes.SuspendLayout();
            this.tlpContenidoAgregarEditar.SuspendLayout();
            this.tlpFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenes)).BeginInit();
            this.tlpCrud.SuspendLayout();
            this.tlpAgregarEditar.SuspendLayout();
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
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(619, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(93, 23);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Ordenes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelContenedor.Controls.Add(this.panelOrdenes);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(330, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1016, 965);
            this.panelContenedor.TabIndex = 8;
            // 
            // panelOrdenes
            // 
            this.panelOrdenes.AutoScroll = true;
            this.panelOrdenes.Controls.Add(this.tlpOrdenes);
            this.panelOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrdenes.Location = new System.Drawing.Point(0, 0);
            this.panelOrdenes.Name = "panelOrdenes";
            this.panelOrdenes.Size = new System.Drawing.Size(1016, 965);
            this.panelOrdenes.TabIndex = 0;
            // 
            // tlpOrdenes
            // 
            this.tlpOrdenes.ColumnCount = 3;
            this.tlpOrdenes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpOrdenes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpOrdenes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpOrdenes.Controls.Add(this.tlpContenidoAgregarEditar, 1, 9);
            this.tlpOrdenes.Controls.Add(this.tlpFiltro, 1, 1);
            this.tlpOrdenes.Controls.Add(this.dgOrdenes, 1, 3);
            this.tlpOrdenes.Controls.Add(this.tlpCrud, 1, 5);
            this.tlpOrdenes.Controls.Add(this.tlpAgregarEditar, 1, 7);
            this.tlpOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpOrdenes.Location = new System.Drawing.Point(0, 0);
            this.tlpOrdenes.Name = "tlpOrdenes";
            this.tlpOrdenes.RowCount = 10;
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.25F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.25F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.25F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.15F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.7F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.15F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.25F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tlpOrdenes.Size = new System.Drawing.Size(990, 1072);
            this.tlpOrdenes.TabIndex = 1;
            // 
            // tlpContenidoAgregarEditar
            // 
            this.tlpContenidoAgregarEditar.ColumnCount = 5;
            this.tlpContenidoAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpContenidoAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpContenidoAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpContenidoAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpContenidoAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpContenidoAgregarEditar.Controls.Add(this.lblNombre, 1, 0);
            this.tlpContenidoAgregarEditar.Controls.Add(this.tbNombre, 3, 0);
            this.tlpContenidoAgregarEditar.Controls.Add(this.lblDetalle, 1, 1);
            this.tlpContenidoAgregarEditar.Controls.Add(this.tbDetalle, 3, 1);
            this.tlpContenidoAgregarEditar.Controls.Add(this.lblEstado, 1, 2);
            this.tlpContenidoAgregarEditar.Controls.Add(this.cbEstado, 3, 2);
            this.tlpContenidoAgregarEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenidoAgregarEditar.Location = new System.Drawing.Point(52, 826);
            this.tlpContenidoAgregarEditar.Name = "tlpContenidoAgregarEditar";
            this.tlpContenidoAgregarEditar.RowCount = 5;
            this.tlpContenidoAgregarEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpContenidoAgregarEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpContenidoAgregarEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpContenidoAgregarEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpContenidoAgregarEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpContenidoAgregarEditar.Size = new System.Drawing.Size(885, 243);
            this.tlpContenidoAgregarEditar.TabIndex = 25;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(144, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 23);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(122)))), ((int)(((byte)(138)))));
            this.tbNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.tbNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbNombre.BorderSize = 2;
            this.tbNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNombre.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbNombre.ForeColor = System.Drawing.Color.Transparent;
            this.tbNombre.Location = new System.Drawing.Point(480, 5);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNombre.MinimumSize = new System.Drawing.Size(257, 41);
            this.tbNombre.Multiline = false;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Padding = new System.Windows.Forms.Padding(8);
            this.tbNombre.PasswordChar = false;
            this.tbNombre.Size = new System.Drawing.Size(257, 41);
            this.tbNombre.TabIndex = 25;
            this.tbNombre.Texts = "";
            this.tbNombre.UnderlinedStyle = true;
            // 
            // lblDetalle
            // 
            this.lblDetalle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblDetalle.ForeColor = System.Drawing.Color.White;
            this.lblDetalle.Location = new System.Drawing.Point(144, 60);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(87, 23);
            this.lblDetalle.TabIndex = 26;
            this.lblDetalle.Text = "Detalle:";
            // 
            // tbDetalle
            // 
            this.tbDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(122)))), ((int)(((byte)(138)))));
            this.tbDetalle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.tbDetalle.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbDetalle.BorderSize = 2;
            this.tbDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDetalle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbDetalle.ForeColor = System.Drawing.Color.Transparent;
            this.tbDetalle.Location = new System.Drawing.Point(480, 53);
            this.tbDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDetalle.MinimumSize = new System.Drawing.Size(257, 41);
            this.tbDetalle.Multiline = false;
            this.tbDetalle.Name = "tbDetalle";
            this.tbDetalle.Padding = new System.Windows.Forms.Padding(8);
            this.tbDetalle.PasswordChar = false;
            this.tbDetalle.Size = new System.Drawing.Size(257, 41);
            this.tbDetalle.TabIndex = 30;
            this.tbDetalle.Texts = "";
            this.tbDetalle.UnderlinedStyle = true;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(144, 108);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(77, 23);
            this.lblEstado.TabIndex = 27;
            this.lblEstado.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(122)))), ((int)(((byte)(138)))));
            this.cbEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.cbEstado.BorderSize = 1;
            this.cbEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbEstado.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbEstado.ForeColor = System.Drawing.Color.IndianRed;
            this.cbEstado.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.cbEstado.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbEstado.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.cbEstado.ListTextColor = System.Drawing.Color.IndianRed;
            this.cbEstado.Location = new System.Drawing.Point(479, 99);
            this.cbEstado.MinimumSize = new System.Drawing.Size(212, 33);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Padding = new System.Windows.Forms.Padding(1);
            this.cbEstado.Size = new System.Drawing.Size(259, 42);
            this.cbEstado.TabIndex = 34;
            this.cbEstado.Texts = "";
            // 
            // tlpFiltro
            // 
            this.tlpFiltro.ColumnCount = 7;
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpFiltro.Controls.Add(this.btnBuscar, 5, 0);
            this.tlpFiltro.Controls.Add(this.lblBuscar, 1, 0);
            this.tlpFiltro.Controls.Add(this.lblOrdenar, 1, 2);
            this.tlpFiltro.Controls.Add(this.tbBuscar, 3, 0);
            this.tlpFiltro.Controls.Add(this.cbOrdenar, 3, 2);
            this.tlpFiltro.Controls.Add(this.btnOrdenar, 5, 2);
            this.tlpFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltro.Location = new System.Drawing.Point(52, 48);
            this.tlpFiltro.Name = "tlpFiltro";
            this.tlpFiltro.RowCount = 3;
            this.tlpFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpFiltro.Size = new System.Drawing.Size(885, 101);
            this.tlpFiltro.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnBuscar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuscar.BorderRadius = 10;
            this.btnBuscar.BorderSize = 0;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(577, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(259, 39);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(47, 11);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(79, 23);
            this.lblBuscar.TabIndex = 18;
            this.lblBuscar.Text = "Buscar:";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblOrdenar.ForeColor = System.Drawing.Color.White;
            this.lblOrdenar.Location = new System.Drawing.Point(47, 66);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(134, 23);
            this.lblOrdenar.TabIndex = 19;
            this.lblOrdenar.Text = "Ordenar Por:";
            // 
            // tbBuscar
            // 
            this.tbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(122)))), ((int)(((byte)(138)))));
            this.tbBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.tbBuscar.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbBuscar.BorderSize = 2;
            this.tbBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBuscar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.tbBuscar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbBuscar.Location = new System.Drawing.Point(269, 5);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBuscar.MinimumSize = new System.Drawing.Size(257, 41);
            this.tbBuscar.Multiline = false;
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Padding = new System.Windows.Forms.Padding(8);
            this.tbBuscar.PasswordChar = false;
            this.tbBuscar.Size = new System.Drawing.Size(257, 41);
            this.tbBuscar.TabIndex = 21;
            this.tbBuscar.Texts = "";
            this.tbBuscar.UnderlinedStyle = true;
            // 
            // cbOrdenar
            // 
            this.cbOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(122)))), ((int)(((byte)(138)))));
            this.cbOrdenar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.cbOrdenar.BorderSize = 1;
            this.cbOrdenar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbOrdenar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbOrdenar.ForeColor = System.Drawing.Color.IndianRed;
            this.cbOrdenar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.cbOrdenar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbOrdenar.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.cbOrdenar.ListTextColor = System.Drawing.Color.IndianRed;
            this.cbOrdenar.Location = new System.Drawing.Point(268, 58);
            this.cbOrdenar.MinimumSize = new System.Drawing.Size(212, 33);
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Padding = new System.Windows.Forms.Padding(1);
            this.cbOrdenar.Size = new System.Drawing.Size(259, 40);
            this.cbOrdenar.TabIndex = 22;
            this.cbOrdenar.Texts = "";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnOrdenar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnOrdenar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOrdenar.BorderRadius = 12;
            this.btnOrdenar.BorderSize = 0;
            this.btnOrdenar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrdenar.FlatAppearance.BorderSize = 0;
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnOrdenar.ForeColor = System.Drawing.Color.White;
            this.btnOrdenar.Location = new System.Drawing.Point(577, 58);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(259, 40);
            this.btnOrdenar.TabIndex = 24;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.TextColor = System.Drawing.Color.White;
            this.btnOrdenar.UseVisualStyleBackColor = false;
            // 
            // dgOrdenes
            // 
            this.dgOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOrdenes.Location = new System.Drawing.Point(52, 200);
            this.dgOrdenes.Name = "dgOrdenes";
            this.dgOrdenes.RowHeadersWidth = 62;
            this.dgOrdenes.RowTemplate.Height = 28;
            this.dgOrdenes.Size = new System.Drawing.Size(885, 393);
            this.dgOrdenes.TabIndex = 1;
            // 
            // tlpCrud
            // 
            this.tlpCrud.ColumnCount = 5;
            this.tlpCrud.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33133F));
            this.tlpCrud.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.003F));
            this.tlpCrud.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33133F));
            this.tlpCrud.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.003F));
            this.tlpCrud.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33133F));
            this.tlpCrud.Controls.Add(this.btnEliminar, 1, 0);
            this.tlpCrud.Controls.Add(this.btnDetalles, 3, 0);
            this.tlpCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCrud.Location = new System.Drawing.Point(52, 622);
            this.tlpCrud.Name = "tlpCrud";
            this.tlpCrud.RowCount = 1;
            this.tlpCrud.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCrud.Size = new System.Drawing.Size(885, 55);
            this.tlpCrud.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 15;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(120, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(259, 49);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnDetalles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnDetalles.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDetalles.BorderRadius = 15;
            this.btnDetalles.BorderSize = 0;
            this.btnDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDetalles.FlatAppearance.BorderSize = 0;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnDetalles.ForeColor = System.Drawing.Color.White;
            this.btnDetalles.Location = new System.Drawing.Point(502, 3);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(259, 49);
            this.btnDetalles.TabIndex = 23;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.TextColor = System.Drawing.Color.White;
            this.btnDetalles.UseVisualStyleBackColor = false;
            // 
            // tlpAgregarEditar
            // 
            this.tlpAgregarEditar.ColumnCount = 5;
            this.tlpAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.649717F));
            this.tlpAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.63277F));
            this.tlpAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.954802F));
            this.tlpAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.84598F));
            this.tlpAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.769343F));
            this.tlpAgregarEditar.Controls.Add(this.btnAgregarEditarProducto, 3, 0);
            this.tlpAgregarEditar.Controls.Add(this.lblAgregarEditar, 1, 0);
            this.tlpAgregarEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAgregarEditar.Location = new System.Drawing.Point(52, 706);
            this.tlpAgregarEditar.Name = "tlpAgregarEditar";
            this.tlpAgregarEditar.RowCount = 1;
            this.tlpAgregarEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAgregarEditar.Size = new System.Drawing.Size(885, 69);
            this.tlpAgregarEditar.TabIndex = 24;
            // 
            // btnAgregarEditarProducto
            // 
            this.btnAgregarEditarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnAgregarEditarProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnAgregarEditarProducto.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarEditarProducto.BorderRadius = 15;
            this.btnAgregarEditarProducto.BorderSize = 0;
            this.btnAgregarEditarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarEditarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEditarProducto.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAgregarEditarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEditarProducto.Location = new System.Drawing.Point(483, 3);
            this.btnAgregarEditarProducto.Name = "btnAgregarEditarProducto";
            this.btnAgregarEditarProducto.Size = new System.Drawing.Size(320, 63);
            this.btnAgregarEditarProducto.TabIndex = 23;
            this.btnAgregarEditarProducto.Text = "Agregar/Editar";
            this.btnAgregarEditarProducto.TextColor = System.Drawing.Color.White;
            this.btnAgregarEditarProducto.UseVisualStyleBackColor = false;
            // 
            // lblAgregarEditar
            // 
            this.lblAgregarEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAgregarEditar.AutoSize = true;
            this.lblAgregarEditar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarEditar.ForeColor = System.Drawing.Color.White;
            this.lblAgregarEditar.Location = new System.Drawing.Point(53, 17);
            this.lblAgregarEditar.Name = "lblAgregarEditar";
            this.lblAgregarEditar.Size = new System.Drawing.Size(308, 34);
            this.lblAgregarEditar.TabIndex = 24;
            this.lblAgregarEditar.Text = "Agregar/Editar Orden";
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
            this.MenuVertical.Controls.Add(this.pnlProducto);
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
            this.SubmenuReportes.Visible = false;
            // 
            // pnlMovimientosDeInventario
            // 
            this.pnlMovimientosDeInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.pnlMovimientosDeInventario.Location = new System.Drawing.Point(0, 157);
            this.pnlMovimientosDeInventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMovimientosDeInventario.Name = "pnlMovimientosDeInventario";
            this.pnlMovimientosDeInventario.Size = new System.Drawing.Size(8, 83);
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
            // pnlOrdenesSegunEstado
            // 
            this.pnlOrdenesSegunEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.pnlOrdenesSegunEstado.Location = new System.Drawing.Point(0, 52);
            this.pnlOrdenesSegunEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlOrdenesSegunEstado.Name = "pnlOrdenesSegunEstado";
            this.pnlOrdenesSegunEstado.Size = new System.Drawing.Size(8, 43);
            this.pnlOrdenesSegunEstado.TabIndex = 19;
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
            this.pnlReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
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
            this.pnlOrdenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(122)))), ((int)(((byte)(138)))));
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
            // pnlProducto
            // 
            this.pnlProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(232)))), ((int)(((byte)(91)))));
            this.pnlProducto.Location = new System.Drawing.Point(4, 237);
            this.pnlProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(8, 49);
            this.pnlProducto.TabIndex = 2;
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
            // FormOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 1000);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrdenes";
            this.Text = "FormOrdenes";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelOrdenes.ResumeLayout(false);
            this.tlpOrdenes.ResumeLayout(false);
            this.tlpContenidoAgregarEditar.ResumeLayout(false);
            this.tlpContenidoAgregarEditar.PerformLayout();
            this.tlpFiltro.ResumeLayout(false);
            this.tlpFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenes)).EndInit();
            this.tlpCrud.ResumeLayout(false);
            this.tlpAgregarEditar.ResumeLayout(false);
            this.tlpAgregarEditar.PerformLayout();
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
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelOrdenes;
        private System.Windows.Forms.TableLayoutPanel tlpOrdenes;
        private System.Windows.Forms.TableLayoutPanel tlpContenidoAgregarEditar;
        private System.Windows.Forms.Label lblNombre;
        private RJControls.RJTextBoxSinBorde tbNombre;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblEstado;
        private RJControls.RJTextBoxSinBorde tbDetalle;
        private System.Windows.Forms.TableLayoutPanel tlpFiltro;
        private RJControls.RJButton btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblOrdenar;
        private RJControls.RJTextBoxSinBorde tbBuscar;
        private RJControls.RJComboBox cbOrdenar;
        private RJControls.RJButton btnOrdenar;
        private System.Windows.Forms.DataGridView dgOrdenes;
        private System.Windows.Forms.TableLayoutPanel tlpCrud;
        private RJControls.RJButton btnEliminar;
        private RJControls.RJButton btnDetalles;
        private System.Windows.Forms.TableLayoutPanel tlpAgregarEditar;
        private RJControls.RJButton btnAgregarEditarProducto;
        private System.Windows.Forms.Label lblAgregarEditar;
        private RJControls.RJComboBox cbEstado;
    }
}