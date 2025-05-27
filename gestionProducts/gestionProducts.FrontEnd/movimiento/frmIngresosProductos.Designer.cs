namespace gestionProducts.FrontEnd.movimiento
{
    partial class frmIngresosProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresosProductos));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtNomBus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstImportaciones = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grDetalle = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmodelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.userGrilla = new gestionProducts.FrontEnd.usercontrol.userControlGrilla();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdModelo = new System.Windows.Forms.Button();
            this.cmdProd = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtObservacionDetalle = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtIDMod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservacionCabecera = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblImportacion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImpoNombre = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlA = new System.Windows.Forms.Panel();
            this.pnlD = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlA.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 608);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdBuscar);
            this.panel1.Controls.Add(this.txtNomBus);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lstImportaciones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 602);
            this.panel1.TabIndex = 0;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Garamond", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(6, 562);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(208, 30);
            this.cmdBuscar.TabIndex = 17;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // txtNomBus
            // 
            this.txtNomBus.Location = new System.Drawing.Point(6, 535);
            this.txtNomBus.Name = "txtNomBus";
            this.txtNomBus.Size = new System.Drawing.Size(208, 25);
            this.txtNomBus.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 513);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nombre:";
            // 
            // lstImportaciones
            // 
            this.lstImportaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstImportaciones.FormattingEnabled = true;
            this.lstImportaciones.ItemHeight = 18;
            this.lstImportaciones.Location = new System.Drawing.Point(0, 0);
            this.lstImportaciones.Name = "lstImportaciones";
            this.lstImportaciones.Size = new System.Drawing.Size(259, 508);
            this.lstImportaciones.TabIndex = 0;
            this.lstImportaciones.Click += new System.EventHandler(this.lstImportaciones_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.grDetalle, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblImpoNombre, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(268, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(635, 602);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // grDetalle
            // 
            this.grDetalle.AllowUserToAddRows = false;
            this.grDetalle.AllowUserToDeleteRows = false;
            this.grDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.idproducto,
            this.Producto,
            this.idmodelo,
            this.Modelo,
            this.observacion,
            this.disponible,
            this.estado});
            this.grDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDetalle.Location = new System.Drawing.Point(3, 28);
            this.grDetalle.Name = "grDetalle";
            this.grDetalle.ReadOnly = true;
            this.grDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grDetalle.Size = new System.Drawing.Size(629, 220);
            this.grDetalle.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // idproducto
            // 
            this.idproducto.DataPropertyName = "idproducto";
            this.idproducto.HeaderText = "idproducto";
            this.idproducto.Name = "idproducto";
            this.idproducto.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // idmodelo
            // 
            this.idmodelo.DataPropertyName = "idmodelo";
            this.idmodelo.HeaderText = "idmodelo";
            this.idmodelo.Name = "idmodelo";
            this.idmodelo.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // observacion
            // 
            this.observacion.DataPropertyName = "observacion";
            this.observacion.HeaderText = "Observacion";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            // 
            // disponible
            // 
            this.disponible.DataPropertyName = "disponible";
            this.disponible.HeaderText = "Disponible";
            this.disponible.Name = "disponible";
            this.disponible.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmdGrabar);
            this.panel3.Controls.Add(this.userGrilla);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtObservacionCabecera);
            this.panel3.Controls.Add(this.lblUsuario);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblImportacion);
            this.panel3.Controls.Add(this.lblFecha);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblNew);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 254);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(629, 345);
            this.panel3.TabIndex = 1;
            // 
            // userGrilla
            // 
            this.userGrilla.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGrilla.FormName = null;
            this.userGrilla.Location = new System.Drawing.Point(121, 47);
            this.userGrilla.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userGrilla.Name = "userGrilla";
            this.userGrilla.NombreCampo = null;
            this.userGrilla.NombreTabla = null;
            this.userGrilla.Size = new System.Drawing.Size(375, 201);
            this.userGrilla.TabIndex = 26;
            this.userGrilla.ValorBuscar = null;
            this.userGrilla.ValorCampo = null;
            this.userGrilla.ValorSeleccionado = null;
            this.userGrilla.Visible = false;
            this.userGrilla.VisibleChanged += new System.EventHandler(this.userGrilla_VisibleChanged);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Image = global::gestionProducts.FrontEnd.Properties.Resources.Save_Impor;
            this.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdGrabar.Location = new System.Drawing.Point(500, 279);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(123, 60);
            this.cmdGrabar.TabIndex = 12;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlD);
            this.groupBox1.Controls.Add(this.pnlA);
            this.groupBox1.Controls.Add(this.cmdNuevo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmdAgregar);
            this.groupBox1.Controls.Add(this.txtObservacionDetalle);
            this.groupBox1.Controls.Add(this.txtSerial);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(3, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 187);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Productos";
            // 
            // cmdModelo
            // 
            this.cmdModelo.Location = new System.Drawing.Point(203, 31);
            this.cmdModelo.Name = "cmdModelo";
            this.cmdModelo.Size = new System.Drawing.Size(27, 25);
            this.cmdModelo.TabIndex = 23;
            this.cmdModelo.Text = "...";
            this.cmdModelo.UseVisualStyleBackColor = true;
            this.cmdModelo.Click += new System.EventHandler(this.cmdModelo_Click);
            // 
            // cmdProd
            // 
            this.cmdProd.Location = new System.Drawing.Point(203, 3);
            this.cmdProd.Name = "cmdProd";
            this.cmdProd.Size = new System.Drawing.Size(27, 25);
            this.cmdProd.TabIndex = 22;
            this.cmdProd.Text = "...";
            this.cmdProd.UseVisualStyleBackColor = true;
            this.cmdProd.Click += new System.EventHandler(this.cmdProd_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Image = ((System.Drawing.Image)(resources.GetObject("cmdNuevo.Image")));
            this.cmdNuevo.Location = new System.Drawing.Point(579, 16);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(39, 41);
            this.cmdNuevo.TabIndex = 21;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Observacion:";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAgregar.Image = global::gestionProducts.FrontEnd.Properties.Resources.agregar;
            this.cmdAgregar.Location = new System.Drawing.Point(579, 61);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(39, 41);
            this.cmdAgregar.TabIndex = 11;
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtObservacionDetalle
            // 
            this.txtObservacionDetalle.Location = new System.Drawing.Point(111, 114);
            this.txtObservacionDetalle.Multiline = true;
            this.txtObservacionDetalle.Name = "txtObservacionDetalle";
            this.txtObservacionDetalle.Size = new System.Drawing.Size(265, 53);
            this.txtObservacionDetalle.TabIndex = 19;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(99, 84);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(277, 25);
            this.txtSerial.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Serial:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(236, 40);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(60, 18);
            this.lblModelo.TabIndex = 16;
            this.lblModelo.Text = "Modelo";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(236, 10);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(71, 18);
            this.lblProducto.TabIndex = 15;
            this.lblProducto.Text = "Producto";
            // 
            // txtIDMod
            // 
            this.txtIDMod.Location = new System.Drawing.Point(97, 33);
            this.txtIDMod.Name = "txtIDMod";
            this.txtIDMod.Size = new System.Drawing.Size(100, 25);
            this.txtIDMod.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "ID Mod:";
            // 
            // txtIDProd
            // 
            this.txtIDProd.Location = new System.Drawing.Point(97, 3);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(100, 25);
            this.txtIDProd.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID Prod:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Observacion:";
            // 
            // txtObservacionCabecera
            // 
            this.txtObservacionCabecera.Location = new System.Drawing.Point(373, 48);
            this.txtObservacionCabecera.Multiline = true;
            this.txtObservacionCabecera.Name = "txtObservacionCabecera";
            this.txtObservacionCabecera.Size = new System.Drawing.Size(250, 51);
            this.txtObservacionCabecera.TabIndex = 8;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(124, 81);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 18);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuario:";
            // 
            // lblImportacion
            // 
            this.lblImportacion.AutoSize = true;
            this.lblImportacion.Location = new System.Drawing.Point(565, 0);
            this.lblImportacion.Name = "lblImportacion";
            this.lblImportacion.Size = new System.Drawing.Size(58, 18);
            this.lblImportacion.TabIndex = 4;
            this.lblImportacion.Text = "IDIMP";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(124, 56);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 18);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(121, 23);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(47, 18);
            this.lblNew.TabIndex = 1;
            this.lblNew.Text = "NEW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // lblImpoNombre
            // 
            this.lblImpoNombre.AutoSize = true;
            this.lblImpoNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblImpoNombre.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpoNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblImpoNombre.Location = new System.Drawing.Point(3, 0);
            this.lblImpoNombre.Name = "lblImpoNombre";
            this.lblImpoNombre.Size = new System.Drawing.Size(629, 25);
            this.lblImpoNombre.TabIndex = 2;
            this.lblImpoNombre.Text = "LblIMPNOM";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(912, 657);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 37);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mantenimiento de Importaciones";
            // 
            // pnlA
            // 
            this.pnlA.Controls.Add(this.txtIDProd);
            this.pnlA.Controls.Add(this.label6);
            this.pnlA.Controls.Add(this.cmdModelo);
            this.pnlA.Controls.Add(this.label8);
            this.pnlA.Controls.Add(this.cmdProd);
            this.pnlA.Controls.Add(this.txtIDMod);
            this.pnlA.Controls.Add(this.lblProducto);
            this.pnlA.Controls.Add(this.lblModelo);
            this.pnlA.Location = new System.Drawing.Point(9, 17);
            this.pnlA.Name = "pnlA";
            this.pnlA.Size = new System.Drawing.Size(564, 61);
            this.pnlA.TabIndex = 27;
            // 
            // pnlD
            // 
            this.pnlD.Location = new System.Drawing.Point(383, 84);
            this.pnlD.Name = "pnlD";
            this.pnlD.Size = new System.Drawing.Size(190, 74);
            this.pnlD.TabIndex = 28;
            // 
            // frmIngresosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 657);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIngresosProductos";
            this.Text = "frmIngresosProductos";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grDetalle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlA.ResumeLayout(false);
            this.pnlA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstImportaciones;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtNomBus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView grDetalle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblImportacion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservacionCabecera;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIDProd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservacionDetalle;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtIDMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdModelo;
        private System.Windows.Forms.Button cmdProd;
        private usercontrol.userControlGrilla userGrilla;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmodelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Label lblImpoNombre;
        private System.Windows.Forms.Panel pnlA;
        private System.Windows.Forms.Panel pnlD;
    }
}