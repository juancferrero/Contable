using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	
	partial class frmRemitos
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmRemitos() : base()
		{
			//Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();
			//Éste es un formulario MDI secundario.
			//Este código simula la funcionalidad de VB6 
			// de cargar automáticamente
			// y mostrar el formulario primario de
			// un MDI secundario.
			/*this.MdiParent = My.MyProject.Forms.Principal;
			My.MyProject.Forms.Principal.Show();*/
		}
//Form invalida a Dispose para limpiar la lista de componentes.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool Disposing)
		{
			if (Disposing) {
				/*if ((components != null)) {
					components.Dispose();
				}*/
			}
			base.Dispose(Disposing);
		}
//Requerido por el Diseñador de Windows Forms
		//private System.ComponentModel.IContainer components;
		public System.Windows.Forms.PrintDialog CommonDialog1Print;
		public System.Windows.Forms.RichTextBox txtLeyenda;
		public System.Windows.Forms.GroupBox Frame3;
		public System.Windows.Forms.Label _Lbl_5;
		public System.Windows.Forms.Label lblPesoBruto;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button2;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button4;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button6;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button8;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button10;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.Label lblValDec;
		public System.Windows.Forms.Label _Lbl_9;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.Label lblDolar;
		public System.Windows.Forms.Label _Lbl_11;
		public System.Windows.Forms.GroupBox frDolar;
		public System.Windows.Forms.RadioButton OptIvaRespIns;
		public System.Windows.Forms.RadioButton OptIvaRespNoIns;
		public System.Windows.Forms.RadioButton OptIvaRegMono;
		public System.Windows.Forms.RadioButton OptIvaNoResp;
		public System.Windows.Forms.RadioButton OptIvaExento;
		public System.Windows.Forms.RadioButton OptIvaConsFinal;
		public System.Windows.Forms.GroupBox FrmPosFiscal;
		public System.Windows.Forms.TextBox txtIdCliente;
		public System.Windows.Forms.ComboBox cmbRazonSocial;
		public System.Windows.Forms.TextBox txtTransHorario;
		public System.Windows.Forms.TextBox txtTransDireccion;
		public System.Windows.Forms.ComboBox cmbTransNombre;
		public System.Windows.Forms.Button cmdNuevoTransporte;
		public System.Windows.Forms.Label _Lbl_6;
		public System.Windows.Forms.Label _Lbl_7;
		public System.Windows.Forms.Label _Lbl_10;
		public System.Windows.Forms.GroupBox frTrasportista;
		public System.Windows.Forms.TextBox txtNumRemito;
		public System.Windows.Forms.Label lblDescuento;
		public System.Windows.Forms.Label _Lbl_14;
		public System.Windows.Forms.Label lblCUIT;
		public System.Windows.Forms.Label _Lbl_4;
		public System.Windows.Forms.Label lblProvincia;
		public System.Windows.Forms.Label lblDireccion;
		public System.Windows.Forms.Label lblLocalidad;
		public System.Windows.Forms.Label _Lbl_3;
		public System.Windows.Forms.Label _Lbl_2;
		public System.Windows.Forms.Label _Lbl_1;
		public System.Windows.Forms.Label _Lbl_0;
		public System.Windows.Forms.Label _Lbl_13;
		public System.Windows.Forms.Label _Lbl_12;
		public System.Windows.Forms.GroupBox frCliente;
		//public Microsoft.VisualBasic.Compatibility.VB6.LabelArray Lbl;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemitos));
			this.CommonDialog1Print = new System.Windows.Forms.PrintDialog();
			this.Frame3 = new System.Windows.Forms.GroupBox();
			this.txtLeyenda = new System.Windows.Forms.RichTextBox();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this._Lbl_5 = new System.Windows.Forms.Label();
			this.lblPesoBruto = new System.Windows.Forms.Label();
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
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.lblValDec = new System.Windows.Forms.Label();
			this._Lbl_9 = new System.Windows.Forms.Label();
			this.frDolar = new System.Windows.Forms.GroupBox();
			this.lblDolar = new System.Windows.Forms.Label();
			this._Lbl_11 = new System.Windows.Forms.Label();
			this.FrmPosFiscal = new System.Windows.Forms.GroupBox();
			this.OptIvaRespIns = new System.Windows.Forms.RadioButton();
			this.OptIvaRespNoIns = new System.Windows.Forms.RadioButton();
			this.OptIvaRegMono = new System.Windows.Forms.RadioButton();
			this.OptIvaNoResp = new System.Windows.Forms.RadioButton();
			this.OptIvaExento = new System.Windows.Forms.RadioButton();
			this.OptIvaConsFinal = new System.Windows.Forms.RadioButton();
			this.frCliente = new System.Windows.Forms.GroupBox();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.txtIdCliente = new System.Windows.Forms.TextBox();
			this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
			this.frTrasportista = new System.Windows.Forms.GroupBox();
			this.txtTransHorario = new System.Windows.Forms.TextBox();
			this.txtTransDireccion = new System.Windows.Forms.TextBox();
			this.cmbTransNombre = new System.Windows.Forms.ComboBox();
			this.cmdNuevoTransporte = new System.Windows.Forms.Button();
			this._Lbl_6 = new System.Windows.Forms.Label();
			this._Lbl_7 = new System.Windows.Forms.Label();
			this._Lbl_10 = new System.Windows.Forms.Label();
			this.txtNumRemito = new System.Windows.Forms.TextBox();
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
			this._Lbl_13 = new System.Windows.Forms.Label();
			this._Lbl_12 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabMercaderia = new System.Windows.Forms.TabPage();
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrecioUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabAFIP = new System.Windows.Forms.TabPage();
			this.lblCodBarras = new System.Windows.Forms.Label();
			this.lblFechaVto = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblCAI = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Frame3.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.Toolbar1.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.frDolar.SuspendLayout();
			this.FrmPosFiscal.SuspendLayout();
			this.frCliente.SuspendLayout();
			this.frTrasportista.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabMercaderia.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
			this.tabAFIP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Frame3
			// 
			this.Frame3.BackColor = System.Drawing.SystemColors.Control;
			this.Frame3.Controls.Add(this.txtLeyenda);
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.Location = new System.Drawing.Point(887, 56);
			this.Frame3.Name = "Frame3";
			this.Frame3.Padding = new System.Windows.Forms.Padding(0);
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Size = new System.Drawing.Size(329, 153);
			this.Frame3.TabIndex = 48;
			this.Frame3.TabStop = false;
			this.Frame3.Text = "Notas";
			// 
			// txtLeyenda
			// 
			this.txtLeyenda.Location = new System.Drawing.Point(16, 24);
			this.txtLeyenda.Name = "txtLeyenda";
			this.txtLeyenda.Size = new System.Drawing.Size(297, 113);
			this.txtLeyenda.TabIndex = 49;
			this.txtLeyenda.Text = "";
			// 
			// Frame2
			// 
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this._Lbl_5);
			this.Frame2.Controls.Add(this.lblPesoBruto);
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(8, 320);
			this.Frame2.Name = "Frame2";
			this.Frame2.Padding = new System.Windows.Forms.Padding(0);
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(249, 49);
			this.Frame2.TabIndex = 41;
			this.Frame2.TabStop = false;
			// 
			// _Lbl_5
			// 
			this._Lbl_5.AutoSize = true;
			this._Lbl_5.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_5.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_5.Location = new System.Drawing.Point(46, 16);
			this._Lbl_5.Name = "_Lbl_5";
			this._Lbl_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_5.Size = new System.Drawing.Size(59, 13);
			this._Lbl_5.TabIndex = 43;
			this._Lbl_5.Text = "Peso Bruto";
			this._Lbl_5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblPesoBruto
			// 
			this.lblPesoBruto.BackColor = System.Drawing.SystemColors.Control;
			this.lblPesoBruto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPesoBruto.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblPesoBruto.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPesoBruto.Location = new System.Drawing.Point(127, 16);
			this.lblPesoBruto.Name = "lblPesoBruto";
			this.lblPesoBruto.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPesoBruto.Size = new System.Drawing.Size(89, 17);
			this.lblPesoBruto.TabIndex = 42;
			this.lblPesoBruto.Text = "0";
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
			this.Toolbar1.Size = new System.Drawing.Size(1283, 42);
			this.Toolbar1.TabIndex = 40;
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
			this.tlbNuevo.Click += new System.EventHandler(this.TlbNuevoClick);
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
			this.tlbImprimir.Enabled = false;
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
			this.tlbAnular.Click += new System.EventHandler(this.TlbAnularClick);
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
			this.tlbFacturar.Image = ((System.Drawing.Image)(resources.GetObject("tlbFacturar.Image")));
			this.tlbFacturar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbFacturar.Name = "tlbFacturar";
			this.tlbFacturar.Size = new System.Drawing.Size(40, 39);
			this.tlbFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbFacturar.ToolTipText = "Facturar";
			this.tlbFacturar.Click += new System.EventHandler(this.TlbFacturarClick);
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.lblValDec);
			this.Frame1.Controls.Add(this._Lbl_9);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(392, 320);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(241, 49);
			this.Frame1.TabIndex = 34;
			this.Frame1.TabStop = false;
			// 
			// lblValDec
			// 
			this.lblValDec.BackColor = System.Drawing.SystemColors.Control;
			this.lblValDec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblValDec.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblValDec.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblValDec.Location = new System.Drawing.Point(126, 16);
			this.lblValDec.Name = "lblValDec";
			this.lblValDec.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblValDec.Size = new System.Drawing.Size(89, 17);
			this.lblValDec.TabIndex = 36;
			this.lblValDec.Text = "0";
			this.lblValDec.DoubleClick += new System.EventHandler(this.LblValDecDoubleClick);
			// 
			// _Lbl_9
			// 
			this._Lbl_9.AutoSize = true;
			this._Lbl_9.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_9.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_9.Location = new System.Drawing.Point(7, 16);
			this._Lbl_9.Name = "_Lbl_9";
			this._Lbl_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_9.Size = new System.Drawing.Size(83, 13);
			this._Lbl_9.TabIndex = 35;
			this._Lbl_9.Text = "Valor Declarado";
			this._Lbl_9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// frDolar
			// 
			this.frDolar.BackColor = System.Drawing.SystemColors.Control;
			this.frDolar.Controls.Add(this.lblDolar);
			this.frDolar.Controls.Add(this._Lbl_11);
			this.frDolar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frDolar.Location = new System.Drawing.Point(392, 240);
			this.frDolar.Name = "frDolar";
			this.frDolar.Padding = new System.Windows.Forms.Padding(0);
			this.frDolar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frDolar.Size = new System.Drawing.Size(233, 65);
			this.frDolar.TabIndex = 31;
			this.frDolar.TabStop = false;
			// 
			// lblDolar
			// 
			this.lblDolar.BackColor = System.Drawing.SystemColors.Control;
			this.lblDolar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDolar.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDolar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDolar.Location = new System.Drawing.Point(120, 24);
			this.lblDolar.Name = "lblDolar";
			this.lblDolar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDolar.Size = new System.Drawing.Size(81, 17);
			this.lblDolar.TabIndex = 33;
			// 
			// _Lbl_11
			// 
			this._Lbl_11.AutoSize = true;
			this._Lbl_11.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_11.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_11.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_11.Location = new System.Drawing.Point(70, 24);
			this._Lbl_11.Name = "_Lbl_11";
			this._Lbl_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_11.Size = new System.Drawing.Size(35, 13);
			this._Lbl_11.TabIndex = 32;
			this._Lbl_11.Text = "Dolar:";
			this._Lbl_11.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// FrmPosFiscal
			// 
			this.FrmPosFiscal.BackColor = System.Drawing.SystemColors.Control;
			this.FrmPosFiscal.Controls.Add(this.OptIvaRespIns);
			this.FrmPosFiscal.Controls.Add(this.OptIvaRespNoIns);
			this.FrmPosFiscal.Controls.Add(this.OptIvaRegMono);
			this.FrmPosFiscal.Controls.Add(this.OptIvaNoResp);
			this.FrmPosFiscal.Controls.Add(this.OptIvaExento);
			this.FrmPosFiscal.Controls.Add(this.OptIvaConsFinal);
			this.FrmPosFiscal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FrmPosFiscal.Location = new System.Drawing.Point(0, 240);
			this.FrmPosFiscal.Name = "FrmPosFiscal";
			this.FrmPosFiscal.Padding = new System.Windows.Forms.Padding(0);
			this.FrmPosFiscal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.FrmPosFiscal.Size = new System.Drawing.Size(393, 65);
			this.FrmPosFiscal.TabIndex = 24;
			this.FrmPosFiscal.TabStop = false;
			// 
			// OptIvaRespIns
			// 
			this.OptIvaRespIns.BackColor = System.Drawing.SystemColors.Control;
			this.OptIvaRespIns.Checked = true;
			this.OptIvaRespIns.Cursor = System.Windows.Forms.Cursors.Default;
			this.OptIvaRespIns.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OptIvaRespIns.Location = new System.Drawing.Point(16, 16);
			this.OptIvaRespIns.Name = "OptIvaRespIns";
			this.OptIvaRespIns.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.OptIvaRespIns.Size = new System.Drawing.Size(89, 21);
			this.OptIvaRespIns.TabIndex = 30;
			this.OptIvaRespIns.TabStop = true;
			this.OptIvaRespIns.Text = "Resp Incripto";
			this.OptIvaRespIns.UseVisualStyleBackColor = false;
			// 
			// OptIvaRespNoIns
			// 
			this.OptIvaRespNoIns.BackColor = System.Drawing.SystemColors.Control;
			this.OptIvaRespNoIns.Cursor = System.Windows.Forms.Cursors.Default;
			this.OptIvaRespNoIns.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OptIvaRespNoIns.Location = new System.Drawing.Point(16, 40);
			this.OptIvaRespNoIns.Name = "OptIvaRespNoIns";
			this.OptIvaRespNoIns.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.OptIvaRespNoIns.Size = new System.Drawing.Size(113, 17);
			this.OptIvaRespNoIns.TabIndex = 29;
			this.OptIvaRespNoIns.TabStop = true;
			this.OptIvaRespNoIns.Text = "Resp No Insctipto";
			this.OptIvaRespNoIns.UseVisualStyleBackColor = false;
			// 
			// OptIvaRegMono
			// 
			this.OptIvaRegMono.BackColor = System.Drawing.SystemColors.Control;
			this.OptIvaRegMono.Cursor = System.Windows.Forms.Cursors.Default;
			this.OptIvaRegMono.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OptIvaRegMono.Location = new System.Drawing.Point(136, 16);
			this.OptIvaRegMono.Name = "OptIvaRegMono";
			this.OptIvaRegMono.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.OptIvaRegMono.Size = new System.Drawing.Size(113, 17);
			this.OptIvaRegMono.TabIndex = 28;
			this.OptIvaRegMono.TabStop = true;
			this.OptIvaRegMono.Text = "Reg Monotributo";
			this.OptIvaRegMono.UseVisualStyleBackColor = false;
			// 
			// OptIvaNoResp
			// 
			this.OptIvaNoResp.BackColor = System.Drawing.SystemColors.Control;
			this.OptIvaNoResp.Cursor = System.Windows.Forms.Cursors.Default;
			this.OptIvaNoResp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OptIvaNoResp.Location = new System.Drawing.Point(136, 40);
			this.OptIvaNoResp.Name = "OptIvaNoResp";
			this.OptIvaNoResp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.OptIvaNoResp.Size = new System.Drawing.Size(113, 17);
			this.OptIvaNoResp.TabIndex = 27;
			this.OptIvaNoResp.TabStop = true;
			this.OptIvaNoResp.Text = "No Responsable";
			this.OptIvaNoResp.UseVisualStyleBackColor = false;
			// 
			// OptIvaExento
			// 
			this.OptIvaExento.BackColor = System.Drawing.SystemColors.Control;
			this.OptIvaExento.Cursor = System.Windows.Forms.Cursors.Default;
			this.OptIvaExento.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OptIvaExento.Location = new System.Drawing.Point(264, 16);
			this.OptIvaExento.Name = "OptIvaExento";
			this.OptIvaExento.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.OptIvaExento.Size = new System.Drawing.Size(65, 17);
			this.OptIvaExento.TabIndex = 26;
			this.OptIvaExento.TabStop = true;
			this.OptIvaExento.Text = "Exento";
			this.OptIvaExento.UseVisualStyleBackColor = false;
			// 
			// OptIvaConsFinal
			// 
			this.OptIvaConsFinal.BackColor = System.Drawing.SystemColors.Control;
			this.OptIvaConsFinal.Cursor = System.Windows.Forms.Cursors.Default;
			this.OptIvaConsFinal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OptIvaConsFinal.Location = new System.Drawing.Point(264, 40);
			this.OptIvaConsFinal.Name = "OptIvaConsFinal";
			this.OptIvaConsFinal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.OptIvaConsFinal.Size = new System.Drawing.Size(105, 17);
			this.OptIvaConsFinal.TabIndex = 25;
			this.OptIvaConsFinal.TabStop = true;
			this.OptIvaConsFinal.Text = "Consumidor Final";
			this.OptIvaConsFinal.UseVisualStyleBackColor = false;
			// 
			// frCliente
			// 
			this.frCliente.BackColor = System.Drawing.SystemColors.Control;
			this.frCliente.Controls.Add(this.dtpFecha);
			this.frCliente.Controls.Add(this.txtIdCliente);
			this.frCliente.Controls.Add(this.cmbRazonSocial);
			this.frCliente.Controls.Add(this.frTrasportista);
			this.frCliente.Controls.Add(this.txtNumRemito);
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
			this.frCliente.Controls.Add(this._Lbl_13);
			this.frCliente.Controls.Add(this._Lbl_12);
			this.frCliente.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frCliente.Location = new System.Drawing.Point(0, 56);
			this.frCliente.Name = "frCliente";
			this.frCliente.Padding = new System.Windows.Forms.Padding(0);
			this.frCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frCliente.Size = new System.Drawing.Size(825, 177);
			this.frCliente.TabIndex = 0;
			this.frCliente.TabStop = false;
			this.frCliente.Enter += new System.EventHandler(this.FrClienteEnter);
			// 
			// dtpFecha
			// 
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(707, 34);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(110, 20);
			this.dtpFecha.TabIndex = 47;
			// 
			// txtIdCliente
			// 
			this.txtIdCliente.AcceptsReturn = true;
			this.txtIdCliente.BackColor = System.Drawing.SystemColors.Window;
			this.txtIdCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtIdCliente.Enabled = false;
			this.txtIdCliente.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtIdCliente.Location = new System.Drawing.Point(264, 32);
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
			this.cmbRazonSocial.Location = new System.Drawing.Point(8, 32);
			this.cmbRazonSocial.Name = "cmbRazonSocial";
			this.cmbRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbRazonSocial.Size = new System.Drawing.Size(225, 21);
			this.cmbRazonSocial.Sorted = true;
			this.cmbRazonSocial.TabIndex = 9;
			this.cmbRazonSocial.DropDown += new System.EventHandler(this.CmbRazonSocialDropDown);
			this.cmbRazonSocial.SelectedIndexChanged += new System.EventHandler(this.CmbRazonSocialSelectedIndexChanged);
			// 
			// frTrasportista
			// 
			this.frTrasportista.BackColor = System.Drawing.SystemColors.Control;
			this.frTrasportista.Controls.Add(this.txtTransHorario);
			this.frTrasportista.Controls.Add(this.txtTransDireccion);
			this.frTrasportista.Controls.Add(this.cmbTransNombre);
			this.frTrasportista.Controls.Add(this.cmdNuevoTransporte);
			this.frTrasportista.Controls.Add(this._Lbl_6);
			this.frTrasportista.Controls.Add(this._Lbl_7);
			this.frTrasportista.Controls.Add(this._Lbl_10);
			this.frTrasportista.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frTrasportista.Location = new System.Drawing.Point(568, 64);
			this.frTrasportista.Name = "frTrasportista";
			this.frTrasportista.Padding = new System.Windows.Forms.Padding(0);
			this.frTrasportista.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frTrasportista.Size = new System.Drawing.Size(249, 105);
			this.frTrasportista.TabIndex = 3;
			this.frTrasportista.TabStop = false;
			this.frTrasportista.Text = "Transportista";
			// 
			// txtTransHorario
			// 
			this.txtTransHorario.AcceptsReturn = true;
			this.txtTransHorario.BackColor = System.Drawing.SystemColors.Window;
			this.txtTransHorario.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTransHorario.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTransHorario.Location = new System.Drawing.Point(72, 80);
			this.txtTransHorario.MaxLength = 0;
			this.txtTransHorario.Name = "txtTransHorario";
			this.txtTransHorario.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTransHorario.Size = new System.Drawing.Size(145, 20);
			this.txtTransHorario.TabIndex = 50;
			// 
			// txtTransDireccion
			// 
			this.txtTransDireccion.AcceptsReturn = true;
			this.txtTransDireccion.BackColor = System.Drawing.SystemColors.Window;
			this.txtTransDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTransDireccion.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTransDireccion.Location = new System.Drawing.Point(72, 56);
			this.txtTransDireccion.MaxLength = 0;
			this.txtTransDireccion.Name = "txtTransDireccion";
			this.txtTransDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTransDireccion.Size = new System.Drawing.Size(145, 20);
			this.txtTransDireccion.TabIndex = 6;
			// 
			// cmbTransNombre
			// 
			this.cmbTransNombre.BackColor = System.Drawing.SystemColors.Window;
			this.cmbTransNombre.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbTransNombre.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbTransNombre.Location = new System.Drawing.Point(88, 24);
			this.cmbTransNombre.Name = "cmbTransNombre";
			this.cmbTransNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbTransNombre.Size = new System.Drawing.Size(129, 21);
			this.cmbTransNombre.TabIndex = 5;
			// 
			// cmdNuevoTransporte
			// 
			this.cmdNuevoTransporte.BackColor = System.Drawing.SystemColors.Control;
			this.cmdNuevoTransporte.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdNuevoTransporte.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdNuevoTransporte.Location = new System.Drawing.Point(224, 24);
			this.cmdNuevoTransporte.Name = "cmdNuevoTransporte";
			this.cmdNuevoTransporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdNuevoTransporte.Size = new System.Drawing.Size(17, 17);
			this.cmdNuevoTransporte.TabIndex = 4;
			this.cmdNuevoTransporte.Text = "...";
			this.cmdNuevoTransporte.UseVisualStyleBackColor = false;
			// 
			// _Lbl_6
			// 
			this._Lbl_6.AutoSize = true;
			this._Lbl_6.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_6.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_6.Location = new System.Drawing.Point(27, 80);
			this._Lbl_6.Name = "_Lbl_6";
			this._Lbl_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_6.Size = new System.Drawing.Size(41, 13);
			this._Lbl_6.TabIndex = 51;
			this._Lbl_6.Text = "Horario";
			this._Lbl_6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_7
			// 
			this._Lbl_7.AutoSize = true;
			this._Lbl_7.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_7.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_7.Location = new System.Drawing.Point(16, 56);
			this._Lbl_7.Name = "_Lbl_7";
			this._Lbl_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_7.Size = new System.Drawing.Size(52, 13);
			this._Lbl_7.TabIndex = 8;
			this._Lbl_7.Text = "Direccion";
			this._Lbl_7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_10
			// 
			this._Lbl_10.AutoSize = true;
			this._Lbl_10.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_10.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_10.Location = new System.Drawing.Point(16, 24);
			this._Lbl_10.Name = "_Lbl_10";
			this._Lbl_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_10.Size = new System.Drawing.Size(70, 13);
			this._Lbl_10.TabIndex = 7;
			this._Lbl_10.Text = "Razon Social";
			this._Lbl_10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtNumRemito
			// 
			this.txtNumRemito.AcceptsReturn = true;
			this.txtNumRemito.BackColor = System.Drawing.SystemColors.Window;
			this.txtNumRemito.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNumRemito.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNumRemito.Location = new System.Drawing.Point(520, 16);
			this.txtNumRemito.MaxLength = 0;
			this.txtNumRemito.Name = "txtNumRemito";
			this.txtNumRemito.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtNumRemito.Size = new System.Drawing.Size(81, 20);
			this.txtNumRemito.TabIndex = 2;
			this.txtNumRemito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumRemitoKeyPress);
			// 
			// lblDescuento
			// 
			this.lblDescuento.BackColor = System.Drawing.SystemColors.Control;
			this.lblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDescuento.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDescuento.Location = new System.Drawing.Point(264, 144);
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
			this._Lbl_14.Location = new System.Drawing.Point(200, 144);
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
			this.lblCUIT.Location = new System.Drawing.Point(8, 152);
			this.lblCUIT.Name = "lblCUIT";
			this.lblCUIT.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCUIT.Size = new System.Drawing.Size(129, 20);
			this.lblCUIT.TabIndex = 23;
			// 
			// _Lbl_4
			// 
			this._Lbl_4.AutoSize = true;
			this._Lbl_4.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_4.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_4.Location = new System.Drawing.Point(16, 136);
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
			this.lblProvincia.Location = new System.Drawing.Point(176, 112);
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
			this.lblDireccion.Location = new System.Drawing.Point(8, 72);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDireccion.Size = new System.Drawing.Size(241, 20);
			this.lblDireccion.TabIndex = 20;
			// 
			// lblLocalidad
			// 
			this.lblLocalidad.BackColor = System.Drawing.SystemColors.Control;
			this.lblLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLocalidad.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLocalidad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLocalidad.Location = new System.Drawing.Point(8, 112);
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
			this._Lbl_3.Location = new System.Drawing.Point(184, 96);
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
			this._Lbl_2.Location = new System.Drawing.Point(16, 96);
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
			this._Lbl_1.Location = new System.Drawing.Point(16, 56);
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
			// _Lbl_13
			// 
			this._Lbl_13.AutoSize = true;
			this._Lbl_13.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_13.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_13.Location = new System.Drawing.Point(670, 40);
			this._Lbl_13.Name = "_Lbl_13";
			this._Lbl_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_13.Size = new System.Drawing.Size(37, 13);
			this._Lbl_13.TabIndex = 11;
			this._Lbl_13.Text = "Fecha";
			this._Lbl_13.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_12
			// 
			this._Lbl_12.AutoSize = true;
			this._Lbl_12.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_12.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_12.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_12.Location = new System.Drawing.Point(408, 16);
			this._Lbl_12.Name = "_Lbl_12";
			this._Lbl_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_12.Size = new System.Drawing.Size(78, 13);
			this._Lbl_12.TabIndex = 10;
			this._Lbl_12.Text = "Nro de Remito:";
			this._Lbl_12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabMercaderia);
			this.tabControl1.Controls.Add(this.tabAFIP);
			this.tabControl1.Location = new System.Drawing.Point(8, 406);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1249, 225);
			this.tabControl1.TabIndex = 50;
			// 
			// tabMercaderia
			// 
			this.tabMercaderia.Controls.Add(this.gridDatos);
			this.tabMercaderia.Location = new System.Drawing.Point(4, 22);
			this.tabMercaderia.Name = "tabMercaderia";
			this.tabMercaderia.Padding = new System.Windows.Forms.Padding(3);
			this.tabMercaderia.Size = new System.Drawing.Size(1241, 199);
			this.tabMercaderia.TabIndex = 1;
			this.tabMercaderia.Text = "Mercaderia";
			this.tabMercaderia.UseVisualStyleBackColor = true;
			// 
			// gridDatos
			// 
			this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colCodigo,
			this.colDetalle,
			this.colCantidad,
			this.colPrecioUnit,
			this.colPrecioTotal});
			this.gridDatos.Location = new System.Drawing.Point(6, 6);
			this.gridDatos.Name = "gridDatos";
			this.gridDatos.Size = new System.Drawing.Size(1181, 150);
			this.gridDatos.TabIndex = 50;
			this.gridDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatosCellContentClick);
			this.gridDatos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridDatosCellMouseClick);
			// 
			// colCodigo
			// 
			this.colCodigo.HeaderText = "Cantidad";
			this.colCodigo.Name = "colCodigo";
			// 
			// colDetalle
			// 
			this.colDetalle.HeaderText = "Codigo";
			this.colDetalle.Name = "colDetalle";
			this.colDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colDetalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// colCantidad
			// 
			this.colCantidad.HeaderText = "Detalle";
			this.colCantidad.Name = "colCantidad";
			// 
			// colPrecioUnit
			// 
			this.colPrecioUnit.HeaderText = "Precio Unitario";
			this.colPrecioUnit.Name = "colPrecioUnit";
			this.colPrecioUnit.ReadOnly = true;
			// 
			// colPrecioTotal
			// 
			this.colPrecioTotal.HeaderText = "Precio Total";
			this.colPrecioTotal.Name = "colPrecioTotal";
			this.colPrecioTotal.ReadOnly = true;
			// 
			// tabAFIP
			// 
			this.tabAFIP.Controls.Add(this.lblCodBarras);
			this.tabAFIP.Controls.Add(this.lblFechaVto);
			this.tabAFIP.Controls.Add(this.label2);
			this.tabAFIP.Controls.Add(this.label1);
			this.tabAFIP.Controls.Add(this.lblCAI);
			this.tabAFIP.Controls.Add(this.pictureBox1);
			this.tabAFIP.Location = new System.Drawing.Point(4, 22);
			this.tabAFIP.Name = "tabAFIP";
			this.tabAFIP.Padding = new System.Windows.Forms.Padding(3);
			this.tabAFIP.Size = new System.Drawing.Size(1241, 199);
			this.tabAFIP.TabIndex = 0;
			this.tabAFIP.Text = "AFIP";
			this.tabAFIP.UseVisualStyleBackColor = true;
			// 
			// lblCodBarras
			// 
			this.lblCodBarras.Location = new System.Drawing.Point(23, 144);
			this.lblCodBarras.Name = "lblCodBarras";
			this.lblCodBarras.Size = new System.Drawing.Size(920, 23);
			this.lblCodBarras.TabIndex = 5;
			this.lblCodBarras.Text = "0";
			// 
			// lblFechaVto
			// 
			this.lblFechaVto.Location = new System.Drawing.Point(83, 46);
			this.lblFechaVto.Name = "lblFechaVto";
			this.lblFechaVto.Size = new System.Drawing.Size(74, 23);
			this.lblFechaVto.TabIndex = 4;
			this.lblFechaVto.Text = "26/09/2014";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "FechaVto";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "CAI";
			// 
			// lblCAI
			// 
			this.lblCAI.Location = new System.Drawing.Point(57, 23);
			this.lblCAI.Name = "lblCAI";
			this.lblCAI.Size = new System.Drawing.Size(221, 23);
			this.lblCAI.TabIndex = 1;
			this.lblCAI.Text = "1234";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 70);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1223, 58);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// frmRemitos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1283, 734);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Toolbar1);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.frDolar);
			this.Controls.Add(this.FrmPosFiscal);
			this.Controls.Add(this.frCliente);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 30);
			this.Name = "frmRemitos";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Remitos ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmRemitosLoad);
			this.Frame3.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.Frame2.PerformLayout();
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			this.frDolar.ResumeLayout(false);
			this.frDolar.PerformLayout();
			this.FrmPosFiscal.ResumeLayout(false);
			this.frCliente.ResumeLayout(false);
			this.frCliente.PerformLayout();
			this.frTrasportista.ResumeLayout(false);
			this.frTrasportista.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabMercaderia.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
			this.tabAFIP.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.TabPage tabAFIP;
		private System.Windows.Forms.TabPage tabMercaderia;
		private System.Windows.Forms.Label lblCodBarras;
		private System.Windows.Forms.Label lblFechaVto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.DataGridView gridDatos;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnit;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDetalle;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label lblCAI;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TabControl tabControl1;
		public System.Windows.Forms.ToolStripButton tlbFacturar;
		public System.Windows.Forms.ToolStripButton tlbEditar;
		public System.Windows.Forms.ToolStripButton tlbAnular;
		public System.Windows.Forms.ToolStripButton tlbImprimir;
		public System.Windows.Forms.ToolStripButton tlbGuardar;
		public System.Windows.Forms.ToolStripButton tlbNuevo;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
			#endregion
	}
}
