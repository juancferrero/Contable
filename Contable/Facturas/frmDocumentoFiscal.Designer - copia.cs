/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 22/09/2016
 * Hora: 11:00 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Contable.Facturas
{
	partial class frmDocumentoFiscal
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button1;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button2;
		public System.Windows.Forms.ToolStripButton tlbGuardar;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button4;
		public System.Windows.Forms.ToolStripButton tbImprimir;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button6;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button7;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button8;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button9;
		public System.Windows.Forms.MonthCalendar Calendario;
		public System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.ComboBox cmbRemito4;
		internal System.Windows.Forms.ComboBox cmbRemito3;
		internal System.Windows.Forms.ComboBox cmbRemito2;
		internal System.Windows.Forms.ComboBox cmbRemito1;
		internal System.Windows.Forms.DataGridView gridDatos;
		internal System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
		internal System.Windows.Forms.DataGridViewComboBoxColumn colProducto;
		internal System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
		internal System.Windows.Forms.DataGridViewTextBoxColumn colUMedida;
		internal System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
		internal System.Windows.Forms.DataGridViewComboBoxColumn colBonif;
		internal System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
		internal System.Windows.Forms.DataGridViewComboBoxColumn colAlicuotaIVA;
		internal System.Windows.Forms.DataGridViewTextBoxColumn colSubTotCIva;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.TabControl TabControl1;
		public System.Windows.Forms.GroupBox frCliente;
		public System.Windows.Forms.ComboBox cmbPosIVA;
		public System.Windows.Forms.Button cmdClienteNuevo;
		public System.Windows.Forms.ComboBox cmbRazonSocial;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.Label _Lbl_7;
		public System.Windows.Forms.Label lblIDCliente;
		public System.Windows.Forms.Label _Lbl_1;
		public System.Windows.Forms.Label _Lbl_2;
		public System.Windows.Forms.Label _Lbl_3;
		public System.Windows.Forms.Label lblLocalidad;
		public System.Windows.Forms.Label lblDireccion;
		public System.Windows.Forms.Label lblProvincia;
		public System.Windows.Forms.Label _Lbl_4;
		public System.Windows.Forms.Label lblCUIT;
		public System.Windows.Forms.Label lblDolar;
		public System.Windows.Forms.Label _Lbl_17;
		public System.Windows.Forms.TextBox txtCodBarNum;
		public System.Windows.Forms.GroupBox frFecha;
		internal System.Windows.Forms.DateTimePicker dtFecha;
		public System.Windows.Forms.GroupBox frNumFact;
		public System.Windows.Forms.ComboBox cmbSucursal;
		public System.Windows.Forms.TextBox txtNumFact;
		public System.Windows.Forms.GroupBox frTipoFC;
		public System.Windows.Forms.Label lblCod_cbe;
		public System.Windows.Forms.Label lblTipoFC;
		public System.Windows.Forms.GroupBox frDescuento;
		public System.Windows.Forms.Label lblDescuento;
		public System.Windows.Forms.GroupBox Frame3;
		public System.Windows.Forms.RadioButton optPeso;
		public System.Windows.Forms.RadioButton optDolar;
		private System.Windows.Forms.Label lblToken;
		private System.Windows.Forms.Label lblSign;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocumentoFiscal));
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this._Toolbar1_Button1 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button2 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbGuardar = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button4 = new System.Windows.Forms.ToolStripSeparator();
			this.tbImprimir = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button6 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button7 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button8 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button9 = new System.Windows.Forms.ToolStripButton();
			this.Calendario = new System.Windows.Forms.MonthCalendar();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbRemito4 = new System.Windows.Forms.ComboBox();
			this.cmbRemito3 = new System.Windows.Forms.ComboBox();
			this.cmbRemito2 = new System.Windows.Forms.ComboBox();
			this.cmbRemito1 = new System.Windows.Forms.ComboBox();
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProducto = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBonif = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAlicuotaIVA = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colSubTotCIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.frCliente = new System.Windows.Forms.GroupBox();
			this.cmbPosIVA = new System.Windows.Forms.ComboBox();
			this.cmdClienteNuevo = new System.Windows.Forms.Button();
			this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this._Lbl_7 = new System.Windows.Forms.Label();
			this.lblIDCliente = new System.Windows.Forms.Label();
			this._Lbl_1 = new System.Windows.Forms.Label();
			this._Lbl_2 = new System.Windows.Forms.Label();
			this._Lbl_3 = new System.Windows.Forms.Label();
			this.lblLocalidad = new System.Windows.Forms.Label();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblProvincia = new System.Windows.Forms.Label();
			this._Lbl_4 = new System.Windows.Forms.Label();
			this.lblCUIT = new System.Windows.Forms.Label();
			this.lblDolar = new System.Windows.Forms.Label();
			this._Lbl_17 = new System.Windows.Forms.Label();
			this.txtCodBarNum = new System.Windows.Forms.TextBox();
			this.frFecha = new System.Windows.Forms.GroupBox();
			this.dtFecha = new System.Windows.Forms.DateTimePicker();
			this.frNumFact = new System.Windows.Forms.GroupBox();
			this.cmbSucursal = new System.Windows.Forms.ComboBox();
			this.txtNumFact = new System.Windows.Forms.TextBox();
			this.frTipoFC = new System.Windows.Forms.GroupBox();
			this.lblCod_cbe = new System.Windows.Forms.Label();
			this.lblTipoFC = new System.Windows.Forms.Label();
			this.frDescuento = new System.Windows.Forms.GroupBox();
			this.lblDescuento = new System.Windows.Forms.Label();
			this.Frame3 = new System.Windows.Forms.GroupBox();
			this.optPeso = new System.Windows.Forms.RadioButton();
			this.optDolar = new System.Windows.Forms.RadioButton();
			this.lblToken = new System.Windows.Forms.Label();
			this.lblSign = new System.Windows.Forms.Label();
			this.Toolbar1.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
			this.frCliente.SuspendLayout();
			this.frFecha.SuspendLayout();
			this.frNumFact.SuspendLayout();
			this.frTipoFC.SuspendLayout();
			this.frDescuento.SuspendLayout();
			this.Frame3.SuspendLayout();
			this.SuspendLayout();
			// 
			// Toolbar1
			// 
			this.Toolbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this._Toolbar1_Button1,
			this._Toolbar1_Button2,
			this.tlbGuardar,
			this._Toolbar1_Button4,
			this.tbImprimir,
			this._Toolbar1_Button6,
			this._Toolbar1_Button7,
			this._Toolbar1_Button8,
			this._Toolbar1_Button9});
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.Size = new System.Drawing.Size(1301, 39);
			this.Toolbar1.TabIndex = 158;
			// 
			// _Toolbar1_Button1
			// 
			this._Toolbar1_Button1.Image = ((System.Drawing.Image)(resources.GetObject("_Toolbar1_Button1.Image")));
			this._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button1.Name = "_Toolbar1_Button1";
			this._Toolbar1_Button1.Size = new System.Drawing.Size(26, 36);
			this._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button1.ToolTipText = "Nuevo";
			// 
			// _Toolbar1_Button2
			// 
			this._Toolbar1_Button2.Name = "_Toolbar1_Button2";
			this._Toolbar1_Button2.Size = new System.Drawing.Size(6, 39);
			// 
			// tlbGuardar
			// 
			this.tlbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tlbGuardar.Image")));
			this.tlbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbGuardar.Name = "tlbGuardar";
			this.tlbGuardar.Size = new System.Drawing.Size(26, 36);
			this.tlbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbGuardar.ToolTipText = "Guardar";
			// 
			// _Toolbar1_Button4
			// 
			this._Toolbar1_Button4.AutoSize = false;
			this._Toolbar1_Button4.Name = "_Toolbar1_Button4";
			this._Toolbar1_Button4.Size = new System.Drawing.Size(0, 39);
			// 
			// tbImprimir
			// 
			this.tbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tbImprimir.Image")));
			this.tbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tbImprimir.Name = "tbImprimir";
			this.tbImprimir.Size = new System.Drawing.Size(26, 36);
			this.tbImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbImprimir.ToolTipText = "Imprimir";
			// 
			// _Toolbar1_Button6
			// 
			this._Toolbar1_Button6.Name = "_Toolbar1_Button6";
			this._Toolbar1_Button6.Size = new System.Drawing.Size(6, 39);
			// 
			// _Toolbar1_Button7
			// 
			this._Toolbar1_Button7.Image = ((System.Drawing.Image)(resources.GetObject("_Toolbar1_Button7.Image")));
			this._Toolbar1_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button7.Name = "_Toolbar1_Button7";
			this._Toolbar1_Button7.Size = new System.Drawing.Size(26, 36);
			this._Toolbar1_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button7.ToolTipText = "Anular";
			// 
			// _Toolbar1_Button8
			// 
			this._Toolbar1_Button8.Name = "_Toolbar1_Button8";
			this._Toolbar1_Button8.Size = new System.Drawing.Size(6, 39);
			// 
			// _Toolbar1_Button9
			// 
			this._Toolbar1_Button9.Image = ((System.Drawing.Image)(resources.GetObject("_Toolbar1_Button9.Image")));
			this._Toolbar1_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button9.Name = "_Toolbar1_Button9";
			this._Toolbar1_Button9.Size = new System.Drawing.Size(26, 36);
			this._Toolbar1_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button9.ToolTipText = "Editar";
			// 
			// Calendario
			// 
			this.Calendario.Location = new System.Drawing.Point(715, 530);
			this.Calendario.Name = "Calendario";
			this.Calendario.TabIndex = 157;
			this.Calendario.Visible = false;
			// 
			// GroupBox1
			// 
			this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.GroupBox1.Controls.Add(this.cmbRemito4);
			this.GroupBox1.Controls.Add(this.cmbRemito3);
			this.GroupBox1.Controls.Add(this.cmbRemito2);
			this.GroupBox1.Controls.Add(this.cmbRemito1);
			this.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.GroupBox1.Location = new System.Drawing.Point(659, 210);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new System.Windows.Forms.Padding(0);
			this.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.GroupBox1.Size = new System.Drawing.Size(236, 105);
			this.GroupBox1.TabIndex = 156;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Remitos";
			// 
			// cmbRemito4
			// 
			this.cmbRemito4.FormattingEnabled = true;
			this.cmbRemito4.Location = new System.Drawing.Point(4, 46);
			this.cmbRemito4.Name = "cmbRemito4";
			this.cmbRemito4.Size = new System.Drawing.Size(58, 21);
			this.cmbRemito4.TabIndex = 0;
			this.cmbRemito4.Text = "0";
			// 
			// cmbRemito3
			// 
			this.cmbRemito3.FormattingEnabled = true;
			this.cmbRemito3.Location = new System.Drawing.Point(144, 16);
			this.cmbRemito3.Name = "cmbRemito3";
			this.cmbRemito3.Size = new System.Drawing.Size(58, 21);
			this.cmbRemito3.TabIndex = 1;
			this.cmbRemito3.Text = "0";
			// 
			// cmbRemito2
			// 
			this.cmbRemito2.FormattingEnabled = true;
			this.cmbRemito2.Location = new System.Drawing.Point(68, 16);
			this.cmbRemito2.Name = "cmbRemito2";
			this.cmbRemito2.Size = new System.Drawing.Size(58, 21);
			this.cmbRemito2.TabIndex = 2;
			this.cmbRemito2.Text = "0";
			// 
			// cmbRemito1
			// 
			this.cmbRemito1.FormattingEnabled = true;
			this.cmbRemito1.Location = new System.Drawing.Point(4, 16);
			this.cmbRemito1.Name = "cmbRemito1";
			this.cmbRemito1.Size = new System.Drawing.Size(58, 21);
			this.cmbRemito1.TabIndex = 3;
			this.cmbRemito1.Text = "0";
			// 
			// gridDatos
			// 
			this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colCodigo,
			this.colProducto,
			this.colCantidad,
			this.colUMedida,
			this.colPrecioUnitario,
			this.colBonif,
			this.colSubTotal,
			this.colAlicuotaIVA,
			this.colSubTotCIva});
			this.gridDatos.Location = new System.Drawing.Point(28, 335);
			this.gridDatos.Name = "gridDatos";
			this.gridDatos.Size = new System.Drawing.Size(601, 183);
			this.gridDatos.TabIndex = 155;
			// 
			// colCodigo
			// 
			this.colCodigo.HeaderText = "Codigo";
			this.colCodigo.Name = "colCodigo";
			// 
			// colProducto
			// 
			this.colProducto.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.colProducto.HeaderText = "Producto";
			this.colProducto.Name = "colProducto";
			// 
			// colCantidad
			// 
			this.colCantidad.HeaderText = "Cantidad";
			this.colCantidad.Name = "colCantidad";
			this.colCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// colUMedida
			// 
			this.colUMedida.HeaderText = "U. Medida";
			this.colUMedida.Name = "colUMedida";
			this.colUMedida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colUMedida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// colPrecioUnitario
			// 
			this.colPrecioUnitario.HeaderText = "PrecioUnitario(USD)";
			this.colPrecioUnitario.Name = "colPrecioUnitario";
			this.colPrecioUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colPrecioUnitario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// colBonif
			// 
			this.colBonif.HeaderText = "%Bonif";
			this.colBonif.Items.AddRange(new object[] {
			"0",
			"20"});
			this.colBonif.Name = "colBonif";
			// 
			// colSubTotal
			// 
			this.colSubTotal.HeaderText = "Subtotal(USD)";
			this.colSubTotal.Name = "colSubTotal";
			// 
			// colAlicuotaIVA
			// 
			this.colAlicuotaIVA.HeaderText = "Alicuota IVA";
			this.colAlicuotaIVA.Items.AddRange(new object[] {
			"0",
			"10,5",
			"21"});
			this.colAlicuotaIVA.Name = "colAlicuotaIVA";
			this.colAlicuotaIVA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colAlicuotaIVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colSubTotCIva
			// 
			this.colSubTotCIva.HeaderText = "Subtotal c/Iva (USD)";
			this.colSubTotCIva.Name = "colSubTotCIva";
			// 
			// PictureBox1
			// 
			this.PictureBox1.BackColor = System.Drawing.Color.White;
			this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PictureBox1.Location = new System.Drawing.Point(19, 582);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(625, 39);
			this.PictureBox1.TabIndex = 154;
			this.PictureBox1.TabStop = false;
			// 
			// TabControl1
			// 
			this.TabControl1.Location = new System.Drawing.Point(659, 357);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(240, 161);
			this.TabControl1.TabIndex = 153;
			// 
			// frCliente
			// 
			this.frCliente.BackColor = System.Drawing.SystemColors.Control;
			this.frCliente.Controls.Add(this.cmbPosIVA);
			this.frCliente.Controls.Add(this.cmdClienteNuevo);
			this.frCliente.Controls.Add(this.cmbRazonSocial);
			this.frCliente.Controls.Add(this.Frame1);
			this.frCliente.Controls.Add(this._Lbl_7);
			this.frCliente.Controls.Add(this.lblIDCliente);
			this.frCliente.Controls.Add(this._Lbl_1);
			this.frCliente.Controls.Add(this._Lbl_2);
			this.frCliente.Controls.Add(this._Lbl_3);
			this.frCliente.Controls.Add(this.lblLocalidad);
			this.frCliente.Controls.Add(this.lblDireccion);
			this.frCliente.Controls.Add(this.lblProvincia);
			this.frCliente.Controls.Add(this._Lbl_4);
			this.frCliente.Controls.Add(this.lblCUIT);
			this.frCliente.Controls.Add(this.lblDolar);
			this.frCliente.Controls.Add(this._Lbl_17);
			this.frCliente.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frCliente.Location = new System.Drawing.Point(20, 138);
			this.frCliente.Name = "frCliente";
			this.frCliente.Padding = new System.Windows.Forms.Padding(0);
			this.frCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frCliente.Size = new System.Drawing.Size(625, 177);
			this.frCliente.TabIndex = 146;
			this.frCliente.TabStop = false;
			// 
			// cmbPosIVA
			// 
			this.cmbPosIVA.BackColor = System.Drawing.SystemColors.Window;
			this.cmbPosIVA.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbPosIVA.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbPosIVA.Location = new System.Drawing.Point(256, 128);
			this.cmbPosIVA.Name = "cmbPosIVA";
			this.cmbPosIVA.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbPosIVA.Size = new System.Drawing.Size(225, 21);
			this.cmbPosIVA.TabIndex = 54;
			this.cmbPosIVA.Text = "Resp Incripto";
			// 
			// cmdClienteNuevo
			// 
			this.cmdClienteNuevo.BackColor = System.Drawing.SystemColors.Control;
			this.cmdClienteNuevo.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdClienteNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdClienteNuevo.Location = new System.Drawing.Point(592, 16);
			this.cmdClienteNuevo.Name = "cmdClienteNuevo";
			this.cmdClienteNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdClienteNuevo.Size = new System.Drawing.Size(17, 21);
			this.cmdClienteNuevo.TabIndex = 4;
			this.cmdClienteNuevo.Text = "...";
			this.cmdClienteNuevo.UseVisualStyleBackColor = false;
			// 
			// cmbRazonSocial
			// 
			this.cmbRazonSocial.BackColor = System.Drawing.SystemColors.Control;
			this.cmbRazonSocial.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbRazonSocial.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbRazonSocial.Location = new System.Drawing.Point(8, 16);
			this.cmbRazonSocial.Name = "cmbRazonSocial";
			this.cmbRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbRazonSocial.Size = new System.Drawing.Size(577, 21);
			this.cmbRazonSocial.Sorted = true;
			this.cmbRazonSocial.TabIndex = 55;
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(440, 176);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(185, 1);
			this.Frame1.TabIndex = 2;
			this.Frame1.TabStop = false;
			this.Frame1.Text = "Frame1";
			// 
			// _Lbl_7
			// 
			this._Lbl_7.AutoSize = true;
			this._Lbl_7.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_7.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_7.Location = new System.Drawing.Point(280, 104);
			this._Lbl_7.Name = "_Lbl_7";
			this._Lbl_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_7.Size = new System.Drawing.Size(16, 13);
			this._Lbl_7.TabIndex = 53;
			this._Lbl_7.Text = "Id";
			this._Lbl_7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblIDCliente
			// 
			this.lblIDCliente.BackColor = System.Drawing.SystemColors.Control;
			this.lblIDCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblIDCliente.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblIDCliente.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblIDCliente.Location = new System.Drawing.Point(296, 96);
			this.lblIDCliente.Name = "lblIDCliente";
			this.lblIDCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblIDCliente.Size = new System.Drawing.Size(177, 25);
			this.lblIDCliente.TabIndex = 26;
			// 
			// _Lbl_1
			// 
			this._Lbl_1.AutoSize = true;
			this._Lbl_1.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_1.Location = new System.Drawing.Point(16, 48);
			this._Lbl_1.Name = "_Lbl_1";
			this._Lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_1.Size = new System.Drawing.Size(52, 13);
			this._Lbl_1.TabIndex = 14;
			this._Lbl_1.Text = "Direccion";
			this._Lbl_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_2
			// 
			this._Lbl_2.AutoSize = true;
			this._Lbl_2.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_2.Location = new System.Drawing.Point(16, 80);
			this._Lbl_2.Name = "_Lbl_2";
			this._Lbl_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_2.Size = new System.Drawing.Size(53, 13);
			this._Lbl_2.TabIndex = 13;
			this._Lbl_2.Text = "Localidad";
			this._Lbl_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_3
			// 
			this._Lbl_3.AutoSize = true;
			this._Lbl_3.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_3.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_3.Location = new System.Drawing.Point(256, 80);
			this._Lbl_3.Name = "_Lbl_3";
			this._Lbl_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_3.Size = new System.Drawing.Size(51, 13);
			this._Lbl_3.TabIndex = 12;
			this._Lbl_3.Text = "Provincia";
			this._Lbl_3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblLocalidad
			// 
			this.lblLocalidad.BackColor = System.Drawing.SystemColors.Control;
			this.lblLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLocalidad.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLocalidad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLocalidad.Location = new System.Drawing.Point(72, 72);
			this.lblLocalidad.Name = "lblLocalidad";
			this.lblLocalidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLocalidad.Size = new System.Drawing.Size(177, 20);
			this.lblLocalidad.TabIndex = 11;
			// 
			// lblDireccion
			// 
			this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
			this.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDireccion.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDireccion.Location = new System.Drawing.Point(72, 48);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDireccion.Size = new System.Drawing.Size(361, 20);
			this.lblDireccion.TabIndex = 10;
			// 
			// lblProvincia
			// 
			this.lblProvincia.BackColor = System.Drawing.SystemColors.Control;
			this.lblProvincia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProvincia.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblProvincia.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProvincia.Location = new System.Drawing.Point(304, 72);
			this.lblProvincia.Name = "lblProvincia";
			this.lblProvincia.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblProvincia.Size = new System.Drawing.Size(169, 20);
			this.lblProvincia.TabIndex = 9;
			// 
			// _Lbl_4
			// 
			this._Lbl_4.AutoSize = true;
			this._Lbl_4.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_4.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_4.Location = new System.Drawing.Point(40, 104);
			this._Lbl_4.Name = "_Lbl_4";
			this._Lbl_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_4.Size = new System.Drawing.Size(32, 13);
			this._Lbl_4.TabIndex = 8;
			this._Lbl_4.Text = "CUIT";
			this._Lbl_4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblCUIT
			// 
			this.lblCUIT.BackColor = System.Drawing.SystemColors.Control;
			this.lblCUIT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCUIT.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCUIT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCUIT.Location = new System.Drawing.Point(72, 96);
			this.lblCUIT.Name = "lblCUIT";
			this.lblCUIT.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCUIT.Size = new System.Drawing.Size(129, 20);
			this.lblCUIT.TabIndex = 7;
			// 
			// lblDolar
			// 
			this.lblDolar.BackColor = System.Drawing.SystemColors.Control;
			this.lblDolar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDolar.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDolar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDolar.Location = new System.Drawing.Point(72, 120);
			this.lblDolar.Name = "lblDolar";
			this.lblDolar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDolar.Size = new System.Drawing.Size(81, 20);
			this.lblDolar.TabIndex = 56;
			// 
			// _Lbl_17
			// 
			this._Lbl_17.AutoSize = true;
			this._Lbl_17.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_17.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_17.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_17.Location = new System.Drawing.Point(40, 128);
			this._Lbl_17.Name = "_Lbl_17";
			this._Lbl_17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_17.Size = new System.Drawing.Size(32, 13);
			this._Lbl_17.TabIndex = 5;
			this._Lbl_17.Text = "Dolar";
			this._Lbl_17.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtCodBarNum
			// 
			this.txtCodBarNum.AcceptsReturn = true;
			this.txtCodBarNum.BackColor = System.Drawing.SystemColors.Window;
			this.txtCodBarNum.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCodBarNum.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCodBarNum.Location = new System.Drawing.Point(112, 544);
			this.txtCodBarNum.MaxLength = 0;
			this.txtCodBarNum.Name = "txtCodBarNum";
			this.txtCodBarNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCodBarNum.Size = new System.Drawing.Size(473, 20);
			this.txtCodBarNum.TabIndex = 152;
			// 
			// frFecha
			// 
			this.frFecha.BackColor = System.Drawing.SystemColors.Control;
			this.frFecha.Controls.Add(this.dtFecha);
			this.frFecha.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frFecha.Location = new System.Drawing.Point(740, 63);
			this.frFecha.Name = "frFecha";
			this.frFecha.Padding = new System.Windows.Forms.Padding(0);
			this.frFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frFecha.Size = new System.Drawing.Size(121, 49);
			this.frFecha.TabIndex = 149;
			this.frFecha.TabStop = false;
			this.frFecha.Text = "Fecha";
			// 
			// dtFecha
			// 
			this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtFecha.Location = new System.Drawing.Point(15, 16);
			this.dtFecha.Name = "dtFecha";
			this.dtFecha.Size = new System.Drawing.Size(90, 20);
			this.dtFecha.TabIndex = 88;
			this.dtFecha.Visible = false;
			// 
			// frNumFact
			// 
			this.frNumFact.BackColor = System.Drawing.SystemColors.Control;
			this.frNumFact.Controls.Add(this.cmbSucursal);
			this.frNumFact.Controls.Add(this.txtNumFact);
			this.frNumFact.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frNumFact.Location = new System.Drawing.Point(536, 63);
			this.frNumFact.Name = "frNumFact";
			this.frNumFact.Padding = new System.Windows.Forms.Padding(0);
			this.frNumFact.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frNumFact.Size = new System.Drawing.Size(193, 41);
			this.frNumFact.TabIndex = 148;
			this.frNumFact.TabStop = false;
			this.frNumFact.Text = "Nro Factura";
			// 
			// cmbSucursal
			// 
			this.cmbSucursal.BackColor = System.Drawing.SystemColors.Window;
			this.cmbSucursal.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbSucursal.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbSucursal.Items.AddRange(new object[] {
			"0001",
			"0002",
			"0003"});
			this.cmbSucursal.Location = new System.Drawing.Point(16, 16);
			this.cmbSucursal.Name = "cmbSucursal";
			this.cmbSucursal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbSucursal.Size = new System.Drawing.Size(65, 21);
			this.cmbSucursal.TabIndex = 43;
			this.cmbSucursal.Text = "0003";
			// 
			// txtNumFact
			// 
			this.txtNumFact.AcceptsReturn = true;
			this.txtNumFact.BackColor = System.Drawing.SystemColors.Window;
			this.txtNumFact.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNumFact.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNumFact.Location = new System.Drawing.Point(104, 16);
			this.txtNumFact.MaxLength = 0;
			this.txtNumFact.Name = "txtNumFact";
			this.txtNumFact.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtNumFact.Size = new System.Drawing.Size(81, 20);
			this.txtNumFact.TabIndex = 28;
			// 
			// frTipoFC
			// 
			this.frTipoFC.BackColor = System.Drawing.SystemColors.Control;
			this.frTipoFC.Controls.Add(this.lblCod_cbe);
			this.frTipoFC.Controls.Add(this.lblTipoFC);
			this.frTipoFC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frTipoFC.Location = new System.Drawing.Point(416, 63);
			this.frTipoFC.Name = "frTipoFC";
			this.frTipoFC.Padding = new System.Windows.Forms.Padding(0);
			this.frTipoFC.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frTipoFC.Size = new System.Drawing.Size(114, 56);
			this.frTipoFC.TabIndex = 147;
			this.frTipoFC.TabStop = false;
			this.frTipoFC.Text = "Tipo de Factura";
			// 
			// lblCod_cbe
			// 
			this.lblCod_cbe.BackColor = System.Drawing.SystemColors.Control;
			this.lblCod_cbe.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCod_cbe.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCod_cbe.Location = new System.Drawing.Point(53, 32);
			this.lblCod_cbe.Name = "lblCod_cbe";
			this.lblCod_cbe.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCod_cbe.Size = new System.Drawing.Size(24, 17);
			this.lblCod_cbe.TabIndex = 61;
			this.lblCod_cbe.Text = "01";
			// 
			// lblTipoFC
			// 
			this.lblTipoFC.AutoSize = true;
			this.lblTipoFC.BackColor = System.Drawing.SystemColors.Control;
			this.lblTipoFC.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblTipoFC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTipoFC.Location = new System.Drawing.Point(56, 13);
			this.lblTipoFC.Name = "lblTipoFC";
			this.lblTipoFC.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTipoFC.Size = new System.Drawing.Size(14, 13);
			this.lblTipoFC.TabIndex = 58;
			this.lblTipoFC.Text = "A";
			// 
			// frDescuento
			// 
			this.frDescuento.BackColor = System.Drawing.SystemColors.Control;
			this.frDescuento.Controls.Add(this.lblDescuento);
			this.frDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frDescuento.Location = new System.Drawing.Point(788, 147);
			this.frDescuento.Name = "frDescuento";
			this.frDescuento.Padding = new System.Windows.Forms.Padding(0);
			this.frDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frDescuento.Size = new System.Drawing.Size(73, 41);
			this.frDescuento.TabIndex = 151;
			this.frDescuento.TabStop = false;
			this.frDescuento.Text = "Descuento";
			// 
			// lblDescuento
			// 
			this.lblDescuento.BackColor = System.Drawing.SystemColors.Control;
			this.lblDescuento.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDescuento.Location = new System.Drawing.Point(16, 16);
			this.lblDescuento.Name = "lblDescuento";
			this.lblDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDescuento.Size = new System.Drawing.Size(41, 17);
			this.lblDescuento.TabIndex = 45;
			this.lblDescuento.Text = "0";
			this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Frame3
			// 
			this.Frame3.BackColor = System.Drawing.SystemColors.Control;
			this.Frame3.Controls.Add(this.optPeso);
			this.Frame3.Controls.Add(this.optDolar);
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.Location = new System.Drawing.Point(651, 138);
			this.Frame3.Name = "Frame3";
			this.Frame3.Padding = new System.Windows.Forms.Padding(0);
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Size = new System.Drawing.Size(129, 50);
			this.Frame3.TabIndex = 150;
			this.Frame3.TabStop = false;
			// 
			// optPeso
			// 
			this.optPeso.Appearance = System.Windows.Forms.Appearance.Button;
			this.optPeso.BackColor = System.Drawing.SystemColors.Control;
			this.optPeso.Cursor = System.Windows.Forms.Cursors.Default;
			this.optPeso.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optPeso.Location = new System.Drawing.Point(72, 16);
			this.optPeso.Name = "optPeso";
			this.optPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optPeso.Size = new System.Drawing.Size(49, 21);
			this.optPeso.TabIndex = 42;
			this.optPeso.TabStop = true;
			this.optPeso.Text = "Peso";
			this.optPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.optPeso.UseVisualStyleBackColor = false;
			// 
			// optDolar
			// 
			this.optDolar.Appearance = System.Windows.Forms.Appearance.Button;
			this.optDolar.BackColor = System.Drawing.SystemColors.Control;
			this.optDolar.Checked = true;
			this.optDolar.Cursor = System.Windows.Forms.Cursors.Default;
			this.optDolar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optDolar.Location = new System.Drawing.Point(8, 16);
			this.optDolar.Name = "optDolar";
			this.optDolar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optDolar.Size = new System.Drawing.Size(53, 21);
			this.optDolar.TabIndex = 41;
			this.optDolar.TabStop = true;
			this.optDolar.Text = "Dolar";
			this.optDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.optDolar.UseVisualStyleBackColor = false;
			// 
			// lblToken
			// 
			this.lblToken.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblToken.Location = new System.Drawing.Point(1035, 276);
			this.lblToken.Name = "lblToken";
			this.lblToken.Size = new System.Drawing.Size(167, 38);
			this.lblToken.TabIndex = 159;
			this.lblToken.Text = "label1";
			// 
			// lblSign
			// 
			this.lblSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblSign.Location = new System.Drawing.Point(1043, 338);
			this.lblSign.Name = "lblSign";
			this.lblSign.Size = new System.Drawing.Size(126, 56);
			this.lblSign.TabIndex = 160;
			this.lblSign.Text = "label1";
			// 
			// frmDocumentoFiscal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1301, 750);
			this.Controls.Add(this.lblSign);
			this.Controls.Add(this.lblToken);
			this.Controls.Add(this.Toolbar1);
			this.Controls.Add(this.Calendario);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.gridDatos);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.frCliente);
			this.Controls.Add(this.txtCodBarNum);
			this.Controls.Add(this.frFecha);
			this.Controls.Add(this.frNumFact);
			this.Controls.Add(this.frTipoFC);
			this.Controls.Add(this.frDescuento);
			this.Controls.Add(this.Frame3);
			this.Name = "frmDocumentoFiscal";
			this.Text = "frmDocumentoFiscal";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmDocumentoFiscalLoad);
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
			this.frCliente.ResumeLayout(false);
			this.frCliente.PerformLayout();
			this.frFecha.ResumeLayout(false);
			this.frNumFact.ResumeLayout(false);
			this.frNumFact.PerformLayout();
			this.frTipoFC.ResumeLayout(false);
			this.frTipoFC.PerformLayout();
			this.frDescuento.ResumeLayout(false);
			this.Frame3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
