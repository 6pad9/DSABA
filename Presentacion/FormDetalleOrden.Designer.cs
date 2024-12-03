namespace Presentacion
{
    partial class FormDetalleOrden
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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelOrdenes = new System.Windows.Forms.Panel();
            this.tlpOrdenes = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrdenActual = new System.Windows.Forms.Label();
            this.tlpCProductos = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregar = new Presentacion.RJControls.RJButton();
            this.lblAgregarEditarProducto = new System.Windows.Forms.Label();
            this.btnModificar = new Presentacion.RJControls.RJButton();
            this.tlpContenidoAgregarEditar = new System.Windows.Forms.TableLayoutPanel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cbProducts = new Presentacion.RJControls.RJComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tbCantidad = new Presentacion.RJControls.RJTextBoxSinBorde();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tbPrecio = new Presentacion.RJControls.RJTextBoxSinBorde();
            this.lblDateReceipt = new System.Windows.Forms.Label();
            this.dtpDateReceipt = new System.Windows.Forms.DateTimePicker();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.tlpCrud = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new Presentacion.RJControls.RJButton();
            this.btnDetalles = new Presentacion.RJControls.RJButton();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.panelOrdenes.SuspendLayout();
            this.tlpOrdenes.SuspendLayout();
            this.tlpCProductos.SuspendLayout();
            this.tlpContenidoAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.tlpCrud.SuspendLayout();
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
            this.BarraTitulo.Size = new System.Drawing.Size(1243, 35);
            this.BarraTitulo.TabIndex = 9;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(511, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 23);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Detalle Orden";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Presentacion.Properties.Resources.minimize;
            this.btnMinimizar.Location = new System.Drawing.Point(1143, 5);
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
            this.btnMaximizar.Location = new System.Drawing.Point(1173, 5);
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
            this.btnCerrar.Location = new System.Drawing.Point(1205, 5);
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
            this.btnRestaurar.Location = new System.Drawing.Point(1175, 5);
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
            this.panelContenedor.Location = new System.Drawing.Point(0, 35);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1243, 810);
            this.panelContenedor.TabIndex = 22;
            // 
            // panelOrdenes
            // 
            this.panelOrdenes.AutoScroll = true;
            this.panelOrdenes.Controls.Add(this.tlpOrdenes);
            this.panelOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrdenes.Location = new System.Drawing.Point(0, 0);
            this.panelOrdenes.Name = "panelOrdenes";
            this.panelOrdenes.Size = new System.Drawing.Size(1243, 810);
            this.panelOrdenes.TabIndex = 0;
            // 
            // tlpOrdenes
            // 
            this.tlpOrdenes.ColumnCount = 3;
            this.tlpOrdenes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.286432F));
            this.tlpOrdenes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.42714F));
            this.tlpOrdenes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.286432F));
            this.tlpOrdenes.Controls.Add(this.lblOrdenActual, 1, 0);
            this.tlpOrdenes.Controls.Add(this.tlpCProductos, 1, 5);
            this.tlpOrdenes.Controls.Add(this.tlpContenidoAgregarEditar, 1, 7);
            this.tlpOrdenes.Controls.Add(this.dgProductos, 1, 1);
            this.tlpOrdenes.Controls.Add(this.tlpCrud, 1, 3);
            this.tlpOrdenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpOrdenes.Location = new System.Drawing.Point(0, 0);
            this.tlpOrdenes.Name = "tlpOrdenes";
            this.tlpOrdenes.RowCount = 9;
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.987816F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.95204F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.017366F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.348365F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.017366F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.776906F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.713396F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.42056F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.76619F));
            this.tlpOrdenes.Size = new System.Drawing.Size(1217, 1072);
            this.tlpOrdenes.TabIndex = 1;
            // 
            // lblOrdenActual
            // 
            this.lblOrdenActual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOrdenActual.AutoSize = true;
            this.lblOrdenActual.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenActual.ForeColor = System.Drawing.Color.White;
            this.lblOrdenActual.Location = new System.Drawing.Point(502, 0);
            this.lblOrdenActual.Name = "lblOrdenActual";
            this.lblOrdenActual.Size = new System.Drawing.Size(210, 34);
            this.lblOrdenActual.TabIndex = 27;
            this.lblOrdenActual.Text = "Orden Código";
            // 
            // tlpCProductos
            // 
            this.tlpCProductos.ColumnCount = 6;
            this.tlpCProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.4654F));
            this.tlpCProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.67644F));
            this.tlpCProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.316852F));
            this.tlpCProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.53795F));
            this.tlpCProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.53795F));
            this.tlpCProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.4654F));
            this.tlpCProductos.Controls.Add(this.btnAgregar, 3, 0);
            this.tlpCProductos.Controls.Add(this.lblAgregarEditarProducto, 1, 0);
            this.tlpCProductos.Controls.Add(this.btnModificar, 4, 0);
            this.tlpCProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCProductos.Location = new System.Drawing.Point(91, 518);
            this.tlpCProductos.Name = "tlpCProductos";
            this.tlpCProductos.RowCount = 1;
            this.tlpCProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCProductos.Size = new System.Drawing.Size(1033, 55);
            this.tlpCProductos.TabIndex = 35;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 15;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(491, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(247, 49);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Registrar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblAgregarEditarProducto
            // 
            this.lblAgregarEditarProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAgregarEditarProducto.AutoSize = true;
            this.lblAgregarEditarProducto.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarEditarProducto.ForeColor = System.Drawing.Color.White;
            this.lblAgregarEditarProducto.Location = new System.Drawing.Point(38, 10);
            this.lblAgregarEditarProducto.Name = "lblAgregarEditarProducto";
            this.lblAgregarEditarProducto.Size = new System.Drawing.Size(341, 34);
            this.lblAgregarEditarProducto.TabIndex = 24;
            this.lblAgregarEditarProducto.Text = "Agregar/Editar Relación";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnModificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.btnModificar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificar.BorderRadius = 15;
            this.btnModificar.BorderSize = 0;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(744, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(247, 49);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextColor = System.Drawing.Color.White;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tlpContenidoAgregarEditar
            // 
            this.tlpContenidoAgregarEditar.ColumnCount = 5;
            this.tlpContenidoAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpContenidoAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpContenidoAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpContenidoAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpContenidoAgregarEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpContenidoAgregarEditar.Controls.Add(this.lblProduct, 1, 0);
            this.tlpContenidoAgregarEditar.Controls.Add(this.cbProducts, 3, 0);
            this.tlpContenidoAgregarEditar.Controls.Add(this.lblCantidad, 1, 1);
            this.tlpContenidoAgregarEditar.Controls.Add(this.tbCantidad, 3, 1);
            this.tlpContenidoAgregarEditar.Controls.Add(this.lblPrecio, 1, 2);
            this.tlpContenidoAgregarEditar.Controls.Add(this.tbPrecio, 3, 2);
            this.tlpContenidoAgregarEditar.Controls.Add(this.lblDateReceipt, 1, 3);
            this.tlpContenidoAgregarEditar.Controls.Add(this.dtpDateReceipt, 3, 3);
            this.tlpContenidoAgregarEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContenidoAgregarEditar.Location = new System.Drawing.Point(91, 608);
            this.tlpContenidoAgregarEditar.Name = "tlpContenidoAgregarEditar";
            this.tlpContenidoAgregarEditar.RowCount = 5;
            this.tlpContenidoAgregarEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpContenidoAgregarEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpContenidoAgregarEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpContenidoAgregarEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpContenidoAgregarEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpContenidoAgregarEditar.Size = new System.Drawing.Size(1033, 255);
            this.tlpContenidoAgregarEditar.TabIndex = 25;
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(168, 14);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(113, 23);
            this.lblProduct.TabIndex = 24;
            this.lblProduct.Text = "Productos:";
            // 
            // cbProducts
            // 
            this.cbProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(122)))), ((int)(((byte)(138)))));
            this.cbProducts.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.cbProducts.BorderSize = 1;
            this.cbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProducts.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cbProducts.ForeColor = System.Drawing.Color.White;
            this.cbProducts.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.cbProducts.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbProducts.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.cbProducts.ListTextColor = System.Drawing.Color.White;
            this.cbProducts.Location = new System.Drawing.Point(559, 3);
            this.cbProducts.MinimumSize = new System.Drawing.Size(212, 33);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Padding = new System.Windows.Forms.Padding(1);
            this.cbProducts.Size = new System.Drawing.Size(303, 45);
            this.cbProducts.TabIndex = 37;
            this.cbProducts.Texts = "";
            this.cbProducts.Click += new System.EventHandler(this.cbProducts_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(168, 65);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(109, 23);
            this.lblCantidad.TabIndex = 35;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(122)))), ((int)(((byte)(138)))));
            this.tbCantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.tbCantidad.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbCantidad.BorderSize = 2;
            this.tbCantidad.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbCantidad.ForeColor = System.Drawing.Color.Transparent;
            this.tbCantidad.Location = new System.Drawing.Point(560, 56);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCantidad.MinimumSize = new System.Drawing.Size(257, 41);
            this.tbCantidad.Multiline = false;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Padding = new System.Windows.Forms.Padding(8);
            this.tbCantidad.PasswordChar = false;
            this.tbCantidad.Size = new System.Drawing.Size(301, 41);
            this.tbCantidad.TabIndex = 43;
            this.tbCantidad.Texts = "";
            this.tbCantidad.UnderlinedStyle = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(168, 116);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(75, 23);
            this.lblPrecio.TabIndex = 40;
            this.lblPrecio.Text = "Precio:";
            // 
            // tbPrecio
            // 
            this.tbPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(122)))), ((int)(((byte)(138)))));
            this.tbPrecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(185)))), ((int)(((byte)(119)))));
            this.tbPrecio.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbPrecio.BorderSize = 2;
            this.tbPrecio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tbPrecio.ForeColor = System.Drawing.Color.Transparent;
            this.tbPrecio.Location = new System.Drawing.Point(560, 107);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrecio.MinimumSize = new System.Drawing.Size(257, 41);
            this.tbPrecio.Multiline = false;
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Padding = new System.Windows.Forms.Padding(8);
            this.tbPrecio.PasswordChar = false;
            this.tbPrecio.Size = new System.Drawing.Size(301, 41);
            this.tbPrecio.TabIndex = 38;
            this.tbPrecio.Texts = "";
            this.tbPrecio.UnderlinedStyle = true;
            // 
            // lblDateReceipt
            // 
            this.lblDateReceipt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateReceipt.AutoSize = true;
            this.lblDateReceipt.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblDateReceipt.ForeColor = System.Drawing.Color.White;
            this.lblDateReceipt.Location = new System.Drawing.Point(168, 167);
            this.lblDateReceipt.Name = "lblDateReceipt";
            this.lblDateReceipt.Size = new System.Drawing.Size(187, 23);
            this.lblDateReceipt.TabIndex = 41;
            this.lblDateReceipt.Text = "Fecha de emisión:";
            // 
            // dtpDateReceipt
            // 
            this.dtpDateReceipt.Location = new System.Drawing.Point(559, 156);
            this.dtpDateReceipt.Name = "dtpDateReceipt";
            this.dtpDateReceipt.Size = new System.Drawing.Size(303, 26);
            this.dtpDateReceipt.TabIndex = 44;
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgProductos.Location = new System.Drawing.Point(91, 45);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowHeadersWidth = 62;
            this.dgProductos.RowTemplate.Height = 28;
            this.dgProductos.Size = new System.Drawing.Size(1033, 368);
            this.dgProductos.TabIndex = 1;
            this.dgProductos.SelectionChanged += new System.EventHandler(this.dgProductos_SelectionChanged);
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
            this.tlpCrud.Location = new System.Drawing.Point(91, 440);
            this.tlpCrud.Name = "tlpCrud";
            this.tlpCrud.RowCount = 1;
            this.tlpCrud.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCrud.Size = new System.Drawing.Size(1033, 51);
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
            this.btnEliminar.Location = new System.Drawing.Point(140, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(303, 45);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnDetalles.Location = new System.Drawing.Point(586, 3);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(303, 45);
            this.btnDetalles.TabIndex = 23;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.TextColor = System.Drawing.Color.White;
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // FormDetalleOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 845);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetalleOrden";
            this.Text = "FormDetalleOrden";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDetalleOrden_FormClosing);
            this.Load += new System.EventHandler(this.FormDetalleOrden_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.panelOrdenes.ResumeLayout(false);
            this.tlpOrdenes.ResumeLayout(false);
            this.tlpOrdenes.PerformLayout();
            this.tlpCProductos.ResumeLayout(false);
            this.tlpCProductos.PerformLayout();
            this.tlpContenidoAgregarEditar.ResumeLayout(false);
            this.tlpContenidoAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.tlpCrud.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelOrdenes;
        private System.Windows.Forms.TableLayoutPanel tlpOrdenes;
        private System.Windows.Forms.Label lblOrdenActual;
        private System.Windows.Forms.TableLayoutPanel tlpCProductos;
        private RJControls.RJButton btnAgregar;
        private System.Windows.Forms.Label lblAgregarEditarProducto;
        private RJControls.RJButton btnModificar;
        private System.Windows.Forms.TableLayoutPanel tlpContenidoAgregarEditar;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgProductos;
        private System.Windows.Forms.TableLayoutPanel tlpCrud;
        private RJControls.RJButton btnEliminar;
        private RJControls.RJButton btnDetalles;
        private System.Windows.Forms.Label lblTitulo;
        private RJControls.RJComboBox cbProducts;
        private RJControls.RJTextBoxSinBorde tbPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDateReceipt;
        private RJControls.RJTextBoxSinBorde tbCantidad;
        private System.Windows.Forms.DateTimePicker dtpDateReceipt;
    }
}