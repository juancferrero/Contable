/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 22/05/2015
 * Hora: 10:41 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Contable.SENASA
{
	partial class frmInformarTraza
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.Label lblCUIT;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.ToolStripButton tlbNuevo;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button2;
		public System.Windows.Forms.ToolStripButton tlbGuardar;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button4;
		public System.Windows.Forms.ToolStripButton tlbImprimir;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button6;
		public System.Windows.Forms.ToolStripButton tlbAnular;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button8;
		public System.Windows.Forms.ToolStripButton tlbEditar;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button10;
		public System.Windows.Forms.ToolStripButton tlbFacturar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbEvento;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNumFact;
		private System.Windows.Forms.DateTimePicker dtFecha;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabCliente;
		private System.Windows.Forms.TabPage tabProducto;
		private System.Windows.Forms.TabPage tabEvento;
		public System.Windows.Forms.GroupBox frCliente;
		private System.Windows.Forms.Button btnNuevoGLN;
		private System.Windows.Forms.Label lblGLN;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox txtIdCliente;
		public System.Windows.Forms.ComboBox cmbRazonSocial;
		public System.Windows.Forms.Label lblDescuento;
		public System.Windows.Forms.Label _Lbl_14;
		public System.Windows.Forms.Label _Lbl_4;
		public System.Windows.Forms.Label lblProvincia;
		public System.Windows.Forms.Label lblDireccion;
		public System.Windows.Forms.Label lblLocalidad;
		public System.Windows.Forms.Label _Lbl_3;
		public System.Windows.Forms.Label _Lbl_2;
		public System.Windows.Forms.Label _Lbl_1;
		public System.Windows.Forms.Label _Lbl_0;
		private System.Windows.Forms.DataGridView gridStock;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtFiltroLote;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtFiltroGTIN;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView gridInformar;
		private System.Windows.Forms.Button cmdFiltrar;
		private System.Windows.Forms.Button cmdPasar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformarTraza));
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this.tlbNuevo = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button2 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbGuardar = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button4 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbImprimir = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button6 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbAnular = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button8 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbEditar = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button10 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbFacturar = new System.Windows.Forms.ToolStripButton();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabCliente = new System.Windows.Forms.TabPage();
			this.frCliente = new System.Windows.Forms.GroupBox();
			this.btnNuevoGLN = new System.Windows.Forms.Button();
			this.lblGLN = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIdCliente = new System.Windows.Forms.TextBox();
			this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
			this.lblDescuento = new System.Windows.Forms.Label();
			this._Lbl_14 = new System.Windows.Forms.Label();
			this.lblCUIT = new System.Windows.Forms.Label();
			this._Lbl_4 = new System.Windows.Forms.Label();
			this.lblProvincia = new System.Windows.Forms.Label();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblLocalidad = new System.Windows.Forms.Label();
			this._Lbl_3 = new System.Windows.Forms.Label();
			this._Lbl_2 = new System.Windows.Forms.Label();
			this._Lbl_1 = new System.Windows.Forms.Label();
			this._Lbl_0 = new System.Windows.Forms.Label();
			this.tabProducto = new System.Windows.Forms.TabPage();
			this.cmdPasar = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.cmdFiltrar = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtFiltroLote = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtFiltroGTIN = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gridInformar = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.gridStock = new System.Windows.Forms.DataGridView();
			this.tabEvento = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dtFecha = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNumFact = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbEvento = new System.Windows.Forms.ComboBox();
			this.Toolbar1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabCliente.SuspendLayout();
			this.frCliente.SuspendLayout();
			this.tabProducto.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridInformar)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
			this.tabEvento.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Toolbar1
			// 
			this.Toolbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tlbNuevo,
			this._Toolbar1_Button2,
			this.tlbGuardar,
			this._Toolbar1_Button4,
			this.tlbImprimir,
			this._Toolbar1_Button6,
			this.tlbAnular,
			this._Toolbar1_Button8,
			this.tlbEditar,
			this._Toolbar1_Button10,
			this.tlbFacturar});
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.Size = new System.Drawing.Size(1370, 42);
			this.Toolbar1.TabIndex = 41;
			// 
			// tlbNuevo
			// 
			this.tlbNuevo.AutoSize = false;
			this.tlbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tlbNuevo.Image")));
			this.tlbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbNuevo.Name = "tlbNuevo";
			this.tlbNuevo.Size = new System.Drawing.Size(40, 39);
			this.tlbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbNuevo.ToolTipText = "Nuevo";
			// 
			// _Toolbar1_Button2
			// 
			this._Toolbar1_Button2.Name = "_Toolbar1_Button2";
			this._Toolbar1_Button2.Size = new System.Drawing.Size(6, 42);
			// 
			// tlbGuardar
			// 
			this.tlbGuardar.AutoSize = false;
			this.tlbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tlbGuardar.Image")));
			this.tlbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbGuardar.Name = "tlbGuardar";
			this.tlbGuardar.Size = new System.Drawing.Size(40, 39);
			this.tlbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbGuardar.ToolTipText = "Guardar";
			this.tlbGuardar.Click += new System.EventHandler(this.TlbGuardarClick);
			// 
			// _Toolbar1_Button4
			// 
			this._Toolbar1_Button4.AutoSize = false;
			this._Toolbar1_Button4.Name = "_Toolbar1_Button4";
			this._Toolbar1_Button4.Size = new System.Drawing.Size(0, 39);
			// 
			// tlbImprimir
			// 
			this.tlbImprimir.AutoSize = false;
			this.tlbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tlbImprimir.Image")));
			this.tlbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbImprimir.Name = "tlbImprimir";
			this.tlbImprimir.Size = new System.Drawing.Size(40, 39);
			this.tlbImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbImprimir.ToolTipText = "Imprimir";
			this.tlbImprimir.Click += new System.EventHandler(this.TlbImprimirClick);
			// 
			// _Toolbar1_Button6
			// 
			this._Toolbar1_Button6.Name = "_Toolbar1_Button6";
			this._Toolbar1_Button6.Size = new System.Drawing.Size(6, 42);
			// 
			// tlbAnular
			// 
			this.tlbAnular.AutoSize = false;
			this.tlbAnular.Enabled = false;
			this.tlbAnular.Image = ((System.Drawing.Image)(resources.GetObject("tlbAnular.Image")));
			this.tlbAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbAnular.Name = "tlbAnular";
			this.tlbAnular.Size = new System.Drawing.Size(40, 39);
			this.tlbAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbAnular.ToolTipText = "Anular";
			// 
			// _Toolbar1_Button8
			// 
			this._Toolbar1_Button8.Name = "_Toolbar1_Button8";
			this._Toolbar1_Button8.Size = new System.Drawing.Size(6, 42);
			// 
			// tlbEditar
			// 
			this.tlbEditar.AutoSize = false;
			this.tlbEditar.Enabled = false;
			this.tlbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tlbEditar.Image")));
			this.tlbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbEditar.Name = "tlbEditar";
			this.tlbEditar.Size = new System.Drawing.Size(40, 39);
			this.tlbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbEditar.ToolTipText = "Editar";
			// 
			// _Toolbar1_Button10
			// 
			this._Toolbar1_Button10.Name = "_Toolbar1_Button10";
			this._Toolbar1_Button10.Size = new System.Drawing.Size(6, 42);
			// 
			// tlbFacturar
			// 
			this.tlbFacturar.AutoSize = false;
			this.tlbFacturar.Enabled = false;
			this.tlbFacturar.Image = ((System.Drawing.Image)(resources.GetObject("tlbFacturar.Image")));
			this.tlbFacturar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbFacturar.Name = "tlbFacturar";
			this.tlbFacturar.Size = new System.Drawing.Size(40, 39);
			this.tlbFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbFacturar.ToolTipText = "Facturar";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabCliente);
			this.tabControl1.Controls.Add(this.tabProducto);
			this.tabControl1.Controls.Add(this.tabEvento);
			this.tabControl1.Location = new System.Drawing.Point(12, 45);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1247, 639);
			this.tabControl1.TabIndex = 46;
			// 
			// tabCliente
			// 
			this.tabCliente.Controls.Add(this.frCliente);
			this.tabCliente.Location = new System.Drawing.Point(4, 22);
			this.tabCliente.Name = "tabCliente";
			this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
			this.tabCliente.Size = new System.Drawing.Size(1239, 613);
			this.tabCliente.TabIndex = 0;
			this.tabCliente.Text = "Cliente";
			this.tabCliente.UseVisualStyleBackColor = true;
			// 
			// frCliente
			// 
			this.frCliente.BackColor = System.Drawing.SystemColors.Control;
			this.frCliente.Controls.Add(this.btnNuevoGLN);
			this.frCliente.Controls.Add(this.lblGLN);
			this.frCliente.Controls.Add(this.label4);
			this.frCliente.Controls.Add(this.label3);
			this.frCliente.Controls.Add(this.txtIdCliente);
			this.frCliente.Controls.Add(this.cmbRazonSocial);
			this.frCliente.Controls.Add(this.lblDescuento);
			this.frCliente.Controls.Add(this._Lbl_14);
			this.frCliente.Controls.Add(this.lblCUIT);
			this.frCliente.Controls.Add(this._Lbl_4);
			this.frCliente.Controls.Add(this.lblProvincia);
			this.frCliente.Controls.Add(this.lblDireccion);
			this.frCliente.Controls.Add(this.lblLocalidad);
			this.frCliente.Controls.Add(this._Lbl_3);
			this.frCliente.Controls.Add(this._Lbl_2);
			this.frCliente.Controls.Add(this._Lbl_1);
			this.frCliente.Controls.Add(this._Lbl_0);
			this.frCliente.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frCliente.Location = new System.Drawing.Point(20, 31);
			this.frCliente.Name = "frCliente";
			this.frCliente.Padding = new System.Windows.Forms.Padding(0);
			this.frCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frCliente.Size = new System.Drawing.Size(825, 211);
			this.frCliente.TabIndex = 1;
			this.frCliente.TabStop = false;
			// 
			// btnNuevoGLN
			// 
			this.btnNuevoGLN.Enabled = false;
			this.btnNuevoGLN.Location = new System.Drawing.Point(578, 108);
			this.btnNuevoGLN.Name = "btnNuevoGLN";
			this.btnNuevoGLN.Size = new System.Drawing.Size(75, 23);
			this.btnNuevoGLN.TabIndex = 50;
			this.btnNuevoGLN.Text = "Nuevo GLN";
			this.btnNuevoGLN.UseVisualStyleBackColor = true;
			// 
			// lblGLN
			// 
			this.lblGLN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblGLN.Location = new System.Drawing.Point(578, 80);
			this.lblGLN.Name = "lblGLN";
			this.lblGLN.Size = new System.Drawing.Size(100, 20);
			this.lblGLN.TabIndex = 49;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(511, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 23);
			this.label4.TabIndex = 48;
			this.label4.Text = "GLN";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(603, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 23);
			this.label3.TabIndex = 47;
			this.label3.Text = "ID";
			// 
			// txtIdCliente
			// 
			this.txtIdCliente.AcceptsReturn = true;
			this.txtIdCliente.BackColor = System.Drawing.SystemColors.Window;
			this.txtIdCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtIdCliente.Enabled = false;
			this.txtIdCliente.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtIdCliente.Location = new System.Drawing.Point(632, 13);
			this.txtIdCliente.MaxLength = 0;
			this.txtIdCliente.Name = "txtIdCliente";
			this.txtIdCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtIdCliente.Size = new System.Drawing.Size(113, 20);
			this.txtIdCliente.TabIndex = 44;
			// 
			// cmbRazonSocial
			// 
			this.cmbRazonSocial.BackColor = System.Drawing.SystemColors.Window;
			this.cmbRazonSocial.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbRazonSocial.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbRazonSocial.Location = new System.Drawing.Point(92, 13);
			this.cmbRazonSocial.Name = "cmbRazonSocial";
			this.cmbRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbRazonSocial.Size = new System.Drawing.Size(465, 21);
			this.cmbRazonSocial.Sorted = true;
			this.cmbRazonSocial.TabIndex = 9;
			this.cmbRazonSocial.DropDown += new System.EventHandler(this.CmbRazonSocialDropDown);
			this.cmbRazonSocial.SelectedIndexChanged += new System.EventHandler(this.CmbRazonSocialSelectedIndexChanged);
			// 
			// lblDescuento
			// 
			this.lblDescuento.BackColor = System.Drawing.SystemColors.Control;
			this.lblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDescuento.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDescuento.Location = new System.Drawing.Point(377, 152);
			this.lblDescuento.Name = "lblDescuento";
			this.lblDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDescuento.Size = new System.Drawing.Size(81, 17);
			this.lblDescuento.TabIndex = 46;
			this.lblDescuento.Text = "0";
			// 
			// _Lbl_14
			// 
			this._Lbl_14.AutoSize = true;
			this._Lbl_14.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_14.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_14.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_14.Location = new System.Drawing.Point(313, 152);
			this._Lbl_14.Name = "_Lbl_14";
			this._Lbl_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_14.Size = new System.Drawing.Size(59, 13);
			this._Lbl_14.TabIndex = 45;
			this._Lbl_14.Text = "Descuento";
			this._Lbl_14.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblCUIT
			// 
			this.lblCUIT.BackColor = System.Drawing.SystemColors.Control;
			this.lblCUIT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCUIT.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCUIT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCUIT.Location = new System.Drawing.Point(113, 151);
			this.lblCUIT.Name = "lblCUIT";
			this.lblCUIT.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCUIT.Size = new System.Drawing.Size(153, 20);
			this.lblCUIT.TabIndex = 23;
			// 
			// _Lbl_4
			// 
			this._Lbl_4.AutoSize = true;
			this._Lbl_4.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_4.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_4.Location = new System.Drawing.Point(54, 153);
			this._Lbl_4.Name = "_Lbl_4";
			this._Lbl_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_4.Size = new System.Drawing.Size(32, 13);
			this._Lbl_4.TabIndex = 22;
			this._Lbl_4.Text = "CUIT";
			this._Lbl_4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblProvincia
			// 
			this.lblProvincia.BackColor = System.Drawing.SystemColors.Control;
			this.lblProvincia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProvincia.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblProvincia.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProvincia.Location = new System.Drawing.Point(329, 112);
			this.lblProvincia.Name = "lblProvincia";
			this.lblProvincia.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblProvincia.Size = new System.Drawing.Size(129, 20);
			this.lblProvincia.TabIndex = 21;
			// 
			// lblDireccion
			// 
			this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
			this.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDireccion.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDireccion.Location = new System.Drawing.Point(113, 80);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDireccion.Size = new System.Drawing.Size(345, 20);
			this.lblDireccion.TabIndex = 20;
			// 
			// lblLocalidad
			// 
			this.lblLocalidad.BackColor = System.Drawing.SystemColors.Control;
			this.lblLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLocalidad.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLocalidad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLocalidad.Location = new System.Drawing.Point(113, 112);
			this.lblLocalidad.Name = "lblLocalidad";
			this.lblLocalidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLocalidad.Size = new System.Drawing.Size(153, 20);
			this.lblLocalidad.TabIndex = 19;
			// 
			// _Lbl_3
			// 
			this._Lbl_3.AutoSize = true;
			this._Lbl_3.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_3.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_3.Location = new System.Drawing.Point(272, 113);
			this._Lbl_3.Name = "_Lbl_3";
			this._Lbl_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_3.Size = new System.Drawing.Size(51, 13);
			this._Lbl_3.TabIndex = 18;
			this._Lbl_3.Text = "Provincia";
			this._Lbl_3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_2
			// 
			this._Lbl_2.AutoSize = true;
			this._Lbl_2.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_2.Location = new System.Drawing.Point(33, 113);
			this._Lbl_2.Name = "_Lbl_2";
			this._Lbl_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_2.Size = new System.Drawing.Size(53, 13);
			this._Lbl_2.TabIndex = 17;
			this._Lbl_2.Text = "Localidad";
			this._Lbl_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_1
			// 
			this._Lbl_1.AutoSize = true;
			this._Lbl_1.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_1.Location = new System.Drawing.Point(34, 81);
			this._Lbl_1.Name = "_Lbl_1";
			this._Lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_1.Size = new System.Drawing.Size(52, 13);
			this._Lbl_1.TabIndex = 16;
			this._Lbl_1.Text = "Direccion";
			this._Lbl_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_0
			// 
			this._Lbl_0.AutoSize = true;
			this._Lbl_0.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_0.Location = new System.Drawing.Point(16, 16);
			this._Lbl_0.Name = "_Lbl_0";
			this._Lbl_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_0.Size = new System.Drawing.Size(70, 13);
			this._Lbl_0.TabIndex = 15;
			this._Lbl_0.Text = "Razon Social";
			this._Lbl_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tabProducto
			// 
			this.tabProducto.Controls.Add(this.cmdPasar);
			this.tabProducto.Controls.Add(this.groupBox5);
			this.tabProducto.Controls.Add(this.groupBox1);
			this.tabProducto.Controls.Add(this.groupBox3);
			this.tabProducto.Location = new System.Drawing.Point(4, 22);
			this.tabProducto.Name = "tabProducto";
			this.tabProducto.Padding = new System.Windows.Forms.Padding(3);
			this.tabProducto.Size = new System.Drawing.Size(1239, 613);
			this.tabProducto.TabIndex = 1;
			this.tabProducto.Text = "Producto";
			this.tabProducto.UseVisualStyleBackColor = true;
			// 
			// cmdPasar
			// 
			this.cmdPasar.Location = new System.Drawing.Point(928, 301);
			this.cmdPasar.Name = "cmdPasar";
			this.cmdPasar.Size = new System.Drawing.Size(294, 30);
			this.cmdPasar.TabIndex = 47;
			this.cmdPasar.Text = "Pasar";
			this.cmdPasar.UseVisualStyleBackColor = true;
			this.cmdPasar.Click += new System.EventHandler(this.CmdPasarClick);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.cmdFiltrar);
			this.groupBox5.Controls.Add(this.groupBox6);
			this.groupBox5.Controls.Add(this.txtFiltroLote);
			this.groupBox5.Controls.Add(this.label6);
			this.groupBox5.Controls.Add(this.txtFiltroGTIN);
			this.groupBox5.Controls.Add(this.label5);
			this.groupBox5.Enabled = false;
			this.groupBox5.Location = new System.Drawing.Point(928, 18);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(294, 263);
			this.groupBox5.TabIndex = 46;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Filtro";
			// 
			// cmdFiltrar
			// 
			this.cmdFiltrar.Location = new System.Drawing.Point(8, 206);
			this.cmdFiltrar.Name = "cmdFiltrar";
			this.cmdFiltrar.Size = new System.Drawing.Size(252, 39);
			this.cmdFiltrar.TabIndex = 5;
			this.cmdFiltrar.Text = "Filtrar";
			this.cmdFiltrar.UseVisualStyleBackColor = true;
			this.cmdFiltrar.Click += new System.EventHandler(this.CmdFiltrarClick);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.textBox1);
			this.groupBox6.Controls.Add(this.label7);
			this.groupBox6.Controls.Add(this.textBox2);
			this.groupBox6.Controls.Add(this.label8);
			this.groupBox6.Location = new System.Drawing.Point(8, 110);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(252, 82);
			this.groupBox6.TabIndex = 4;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Serie";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(75, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(165, 20);
			this.textBox1.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Location = new System.Drawing.Point(9, 50);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "Hasta";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(75, 19);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(165, 20);
			this.textBox2.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(9, 19);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 20);
			this.label8.TabIndex = 4;
			this.label8.Text = "Desde";
			// 
			// txtFiltroLote
			// 
			this.txtFiltroLote.Location = new System.Drawing.Point(51, 65);
			this.txtFiltroLote.Name = "txtFiltroLote";
			this.txtFiltroLote.Size = new System.Drawing.Size(197, 20);
			this.txtFiltroLote.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Location = new System.Drawing.Point(8, 67);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 20);
			this.label6.TabIndex = 2;
			this.label6.Text = "Lote";
			// 
			// txtFiltroGTIN
			// 
			this.txtFiltroGTIN.Location = new System.Drawing.Point(51, 36);
			this.txtFiltroGTIN.Name = "txtFiltroGTIN";
			this.txtFiltroGTIN.Size = new System.Drawing.Size(197, 20);
			this.txtFiltroGTIN.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Location = new System.Drawing.Point(8, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 20);
			this.label5.TabIndex = 0;
			this.label5.Text = "GTIN";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.gridInformar);
			this.groupBox1.Location = new System.Drawing.Point(6, 235);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(907, 223);
			this.groupBox1.TabIndex = 45;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Informar";
			// 
			// gridInformar
			// 
			this.gridInformar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridInformar.Location = new System.Drawing.Point(6, 19);
			this.gridInformar.Name = "gridInformar";
			this.gridInformar.Size = new System.Drawing.Size(895, 195);
			this.gridInformar.TabIndex = 0;
			this.gridInformar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridInformarCellContentClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.gridStock);
			this.groupBox3.Location = new System.Drawing.Point(6, 6);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(907, 223);
			this.groupBox3.TabIndex = 44;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Stock";
			// 
			// gridStock
			// 
			this.gridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridStock.Location = new System.Drawing.Point(6, 19);
			this.gridStock.Name = "gridStock";
			this.gridStock.Size = new System.Drawing.Size(895, 195);
			this.gridStock.TabIndex = 0;
			// 
			// tabEvento
			// 
			this.tabEvento.Controls.Add(this.groupBox4);
			this.tabEvento.Controls.Add(this.groupBox2);
			this.tabEvento.Location = new System.Drawing.Point(4, 22);
			this.tabEvento.Name = "tabEvento";
			this.tabEvento.Size = new System.Drawing.Size(1239, 613);
			this.tabEvento.TabIndex = 2;
			this.tabEvento.Text = "Evento";
			this.tabEvento.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dtFecha);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.txtNumFact);
			this.groupBox4.Location = new System.Drawing.Point(20, 152);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(456, 107);
			this.groupBox4.TabIndex = 45;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Comprobante";
			// 
			// dtFecha
			// 
			this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFecha.Location = new System.Drawing.Point(158, 53);
			this.dtFecha.Name = "dtFecha";
			this.dtFecha.Size = new System.Drawing.Size(227, 20);
			this.dtFecha.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(11, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 17);
			this.label2.TabIndex = 43;
			this.label2.Text = "Fecha del Evento";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(11, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Numero de Fact/Rto";
			// 
			// txtNumFact
			// 
			this.txtNumFact.Location = new System.Drawing.Point(158, 27);
			this.txtNumFact.Name = "txtNumFact";
			this.txtNumFact.Size = new System.Drawing.Size(215, 20);
			this.txtNumFact.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbEvento);
			this.groupBox2.Location = new System.Drawing.Point(60, 58);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(462, 56);
			this.groupBox2.TabIndex = 44;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Eventos";
			// 
			// cmbEvento
			// 
			this.cmbEvento.FormattingEnabled = true;
			this.cmbEvento.Items.AddRange(new object[] {
			"IMPORTACION",
			"LIBERACION DE ZONA FRANCA",
			"EXPORTACION",
			"SINTESIS DE PRINCIPIO ACTIVO",
			"USO PARA PRODUCCION DE PRODUCTO",
			"PRODUCCION DE PRODUCTOS",
			"USO PARA FRACCIONAMIENTO",
			"RESULTADO DE FRACCIONAMIENTO",
			"DESTRUCCION / MERMA",
			"ROBO / HURTO",
			"VENTA / ENVIO",
			"RECEPCIÓN DE COMPRA",
			"VENTA MINORISTA",
			"DEVOLUCION",
			"RECEPCION POR DEVOLUCION MINORISTA",
			"PRODUCCION CON MATERIA PRIMA NO TRAZADA",
			"USO PARA AUTOCONSUMO",
			"IMPORTACION A ZONA FRANCA",
			"EXPORTACION DESDE ZONA FRANCA",
			"ENVIO A COMERCIANTE NO INSCRIPTO EN EL SISTEMA"});
			this.cmbEvento.Location = new System.Drawing.Point(6, 23);
			this.cmbEvento.Name = "cmbEvento";
			this.cmbEvento.Size = new System.Drawing.Size(307, 21);
			this.cmbEvento.TabIndex = 0;
			this.cmbEvento.Text = "VENTA / ENVIO";
			// 
			// frmInformarTraza
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 750);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.Toolbar1);
			this.Name = "frmInformarTraza";
			this.Text = "frmInformarTraza";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmInformarTrazaLoad);
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabCliente.ResumeLayout(false);
			this.frCliente.ResumeLayout(false);
			this.frCliente.PerformLayout();
			this.tabProducto.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridInformar)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
			this.tabEvento.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
