//using Microsoft.VisualBasic;
//using Microsoft.VisualBasic.Compatibility;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	
	partial class frmReciboAltas
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmReciboAltas() : base()
		{
			//Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();
			
		}
//Form invalida a Dispose para limpiar la lista de componentes.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool Disposing)
		{
			if (Disposing) {
				if ((components != null)) {
					components.Dispose();
				}
			}
			base.Dispose(Disposing);
		}
//Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.TextBox txtRetenIVA;
		public System.Windows.Forms.TextBox txtRetenCargasSoc;
		public System.Windows.Forms.TextBox txtRetenGanancias;
		public System.Windows.Forms.TextBox txtRetenIIB;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.Label lblDiferenciaTotal;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.TextBox txtDescuento;
		public System.Windows.Forms.TextBox txtRetenciones;
		public System.Windows.Forms.TextBox txtVarios;
		public System.Windows.Forms.TextBox txtCobranzaNeta;
		public System.Windows.Forms.TextBox txtNO;
		public System.Windows.Forms.Label Label15;
		public System.Windows.Forms.Label Label16;
		public System.Windows.Forms.Label Label17;
		public System.Windows.Forms.Label Label18;
		public System.Windows.Forms.Label Label19;
		public System.Windows.Forms.Label Label20;
		public System.Windows.Forms.Label lblSubTotal;
		public System.Windows.Forms.GroupBox frameVarios;
		public System.Windows.Forms.ComboBox cmbRazonSocial;
		public System.Windows.Forms.Button cmdClienteNuevo;
		public System.Windows.Forms.Label lblDolar;
		public System.Windows.Forms.Label _Lbl_17;
		public System.Windows.Forms.Label _Lbl_5;
		public System.Windows.Forms.Label lblLaSumaDe;
		public System.Windows.Forms.Label _Lbl_4;
		public System.Windows.Forms.Label lblCUIT;
		public System.Windows.Forms.Label lblProvincia;
		public System.Windows.Forms.Label lblDireccion;
		public System.Windows.Forms.Label lblLocalidad;
		public System.Windows.Forms.Label _Lbl_3;
		public System.Windows.Forms.Label _Lbl_2;
		public System.Windows.Forms.Label _Lbl_1;
		public System.Windows.Forms.Label _Lbl_0;
		public System.Windows.Forms.Label _Lbl_13;
		public System.Windows.Forms.GroupBox frCliente;
		public System.Windows.Forms.TextBox txtNumRecibo;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button1;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button2;
		public System.Windows.Forms.ToolStripButton tlbGuardar;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button4;
		public System.Windows.Forms.ToolStripButton tbImprimir;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button6;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button7;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button8;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button9;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.Label lblReciboN;
		private System.Windows.Forms.DateTimePicker dtFecha;
		private System.Windows.Forms.Label lblIDCliente;
		private System.Windows.Forms.DataGridView gridFact;
		private System.Windows.Forms.DataGridView gridND;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabFacturasA;
		private System.Windows.Forms.TabPage tabND;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabCheque;
		private System.Windows.Forms.TabPage tabInterdep;
		private System.Windows.Forms.TabPage tabNC;
		private System.Windows.Forms.DataGridView gridNC;
		private System.Windows.Forms.DataGridView gridCheque;
		private System.Windows.Forms.DataGridView gridInterdeposito;
		private System.Windows.Forms.TabControl tabControl3;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEfectivo;
		private System.Windows.Forms.Label lblCobranzaTotal;
		private System.Windows.Forms.TabPage tabFacturaB;
		private System.Windows.Forms.DataGridView gridFactB;
		private System.Windows.Forms.CheckBox chkTotos;
		//public Microsoft.VisualBasic.Compatibility.VB6.LabelArray Lbl;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReciboAltas));
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.cmdClienteNuevo = new System.Windows.Forms.Button();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.lblDiferenciaTotal = new System.Windows.Forms.Label();
			this.frCliente = new System.Windows.Forms.GroupBox();
			this.lblIDCliente = new System.Windows.Forms.Label();
			this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
			this.lblDolar = new System.Windows.Forms.Label();
			this._Lbl_17 = new System.Windows.Forms.Label();
			this._Lbl_5 = new System.Windows.Forms.Label();
			this.lblLaSumaDe = new System.Windows.Forms.Label();
			this._Lbl_4 = new System.Windows.Forms.Label();
			this.lblCUIT = new System.Windows.Forms.Label();
			this.lblProvincia = new System.Windows.Forms.Label();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblLocalidad = new System.Windows.Forms.Label();
			this._Lbl_3 = new System.Windows.Forms.Label();
			this._Lbl_2 = new System.Windows.Forms.Label();
			this._Lbl_1 = new System.Windows.Forms.Label();
			this._Lbl_0 = new System.Windows.Forms.Label();
			this.dtFecha = new System.Windows.Forms.DateTimePicker();
			this._Lbl_13 = new System.Windows.Forms.Label();
			this.txtNumRecibo = new System.Windows.Forms.TextBox();
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
			this.lblReciboN = new System.Windows.Forms.Label();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabFacturasA = new System.Windows.Forms.TabPage();
			this.gridFact = new System.Windows.Forms.DataGridView();
			this.tabFacturaB = new System.Windows.Forms.TabPage();
			this.gridFactB = new System.Windows.Forms.DataGridView();
			this.tabND = new System.Windows.Forms.TabPage();
			this.gridND = new System.Windows.Forms.DataGridView();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabCheque = new System.Windows.Forms.TabPage();
			this.gridCheque = new System.Windows.Forms.DataGridView();
			this.tabInterdep = new System.Windows.Forms.TabPage();
			this.gridInterdeposito = new System.Windows.Forms.DataGridView();
			this.tabNC = new System.Windows.Forms.TabPage();
			this.gridNC = new System.Windows.Forms.DataGridView();
			this.tabControl3 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.frameVarios = new System.Windows.Forms.GroupBox();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.txtRetenciones = new System.Windows.Forms.TextBox();
			this.txtVarios = new System.Windows.Forms.TextBox();
			this.txtCobranzaNeta = new System.Windows.Forms.TextBox();
			this.txtNO = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label20 = new System.Windows.Forms.Label();
			this.lblSubTotal = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.txtRetenIVA = new System.Windows.Forms.TextBox();
			this.txtRetenCargasSoc = new System.Windows.Forms.TextBox();
			this.txtRetenGanancias = new System.Windows.Forms.TextBox();
			this.txtRetenIIB = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEfectivo = new System.Windows.Forms.TextBox();
			this.lblCobranzaTotal = new System.Windows.Forms.Label();
			this.chkTotos = new System.Windows.Forms.CheckBox();
			this.Frame1.SuspendLayout();
			this.frCliente.SuspendLayout();
			this.Toolbar1.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabFacturasA.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridFact)).BeginInit();
			this.tabFacturaB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridFactB)).BeginInit();
			this.tabND.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridND)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabCheque.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCheque)).BeginInit();
			this.tabInterdep.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridInterdeposito)).BeginInit();
			this.tabNC.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridNC)).BeginInit();
			this.tabControl3.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.frameVarios.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdClienteNuevo
			// 
			this.cmdClienteNuevo.BackColor = System.Drawing.SystemColors.Control;
			this.cmdClienteNuevo.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdClienteNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdClienteNuevo.Location = new System.Drawing.Point(240, 32);
			this.cmdClienteNuevo.Name = "cmdClienteNuevo";
			this.cmdClienteNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdClienteNuevo.Size = new System.Drawing.Size(17, 21);
			this.cmdClienteNuevo.TabIndex = 91;
			this.cmdClienteNuevo.Text = "...";
			this.ToolTip1.SetToolTip(this.cmdClienteNuevo, "Agregar un Nuevo Cliente");
			this.cmdClienteNuevo.UseVisualStyleBackColor = false;
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.lblDiferenciaTotal);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(712, 544);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(217, 65);
			this.Frame1.TabIndex = 133;
			this.Frame1.TabStop = false;
			this.Frame1.Text = "Diferencia";
			// 
			// lblDiferenciaTotal
			// 
			this.lblDiferenciaTotal.BackColor = System.Drawing.SystemColors.Control;
			this.lblDiferenciaTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDiferenciaTotal.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDiferenciaTotal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDiferenciaTotal.Location = new System.Drawing.Point(32, 16);
			this.lblDiferenciaTotal.Name = "lblDiferenciaTotal";
			this.lblDiferenciaTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDiferenciaTotal.Size = new System.Drawing.Size(137, 23);
			this.lblDiferenciaTotal.TabIndex = 134;
			this.lblDiferenciaTotal.Text = "0";
			this.lblDiferenciaTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// frCliente
			// 
			this.frCliente.BackColor = System.Drawing.SystemColors.Control;
			this.frCliente.Controls.Add(this.lblIDCliente);
			this.frCliente.Controls.Add(this.cmbRazonSocial);
			this.frCliente.Controls.Add(this.cmdClienteNuevo);
			this.frCliente.Controls.Add(this.lblDolar);
			this.frCliente.Controls.Add(this._Lbl_17);
			this.frCliente.Controls.Add(this._Lbl_5);
			this.frCliente.Controls.Add(this.lblLaSumaDe);
			this.frCliente.Controls.Add(this._Lbl_4);
			this.frCliente.Controls.Add(this.lblCUIT);
			this.frCliente.Controls.Add(this.lblProvincia);
			this.frCliente.Controls.Add(this.lblDireccion);
			this.frCliente.Controls.Add(this.lblLocalidad);
			this.frCliente.Controls.Add(this._Lbl_3);
			this.frCliente.Controls.Add(this._Lbl_2);
			this.frCliente.Controls.Add(this._Lbl_1);
			this.frCliente.Controls.Add(this._Lbl_0);
			this.frCliente.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frCliente.Location = new System.Drawing.Point(9, 96);
			this.frCliente.Name = "frCliente";
			this.frCliente.Padding = new System.Windows.Forms.Padding(0);
			this.frCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frCliente.Size = new System.Drawing.Size(558, 177);
			this.frCliente.TabIndex = 0;
			this.frCliente.TabStop = false;
			this.frCliente.Text = "Cliente";
			// 
			// lblIDCliente
			// 
			this.lblIDCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblIDCliente.Location = new System.Drawing.Point(284, 32);
			this.lblIDCliente.Name = "lblIDCliente";
			this.lblIDCliente.Size = new System.Drawing.Size(117, 21);
			this.lblIDCliente.TabIndex = 124;
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
			this.cmbRazonSocial.TabIndex = 2;
			this.cmbRazonSocial.DropDown += new System.EventHandler(this.CmbRazonSocialDropDown);
			this.cmbRazonSocial.SelectedIndexChanged += new System.EventHandler(this.CmbRazonSocialSelectedIndexChanged);
			// 
			// lblDolar
			// 
			this.lblDolar.BackColor = System.Drawing.SystemColors.Control;
			this.lblDolar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDolar.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDolar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDolar.Location = new System.Drawing.Point(320, 112);
			this.lblDolar.Name = "lblDolar";
			this.lblDolar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDolar.Size = new System.Drawing.Size(81, 20);
			this.lblDolar.TabIndex = 122;
			// 
			// _Lbl_17
			// 
			this._Lbl_17.AutoSize = true;
			this._Lbl_17.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_17.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_17.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_17.Location = new System.Drawing.Point(328, 96);
			this._Lbl_17.Name = "_Lbl_17";
			this._Lbl_17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_17.Size = new System.Drawing.Size(32, 13);
			this._Lbl_17.TabIndex = 121;
			this._Lbl_17.Text = "Dolar";
			this._Lbl_17.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_5
			// 
			this._Lbl_5.AutoSize = true;
			this._Lbl_5.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_5.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_5.Location = new System.Drawing.Point(13, 136);
			this._Lbl_5.Name = "_Lbl_5";
			this._Lbl_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_5.Size = new System.Drawing.Size(67, 13);
			this._Lbl_5.TabIndex = 89;
			this._Lbl_5.Text = "La Suma de:";
			this._Lbl_5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblLaSumaDe
			// 
			this.lblLaSumaDe.BackColor = System.Drawing.SystemColors.Control;
			this.lblLaSumaDe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLaSumaDe.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLaSumaDe.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLaSumaDe.Location = new System.Drawing.Point(16, 152);
			this.lblLaSumaDe.Name = "lblLaSumaDe";
			this.lblLaSumaDe.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLaSumaDe.Size = new System.Drawing.Size(515, 20);
			this.lblLaSumaDe.TabIndex = 88;
			// 
			// _Lbl_4
			// 
			this._Lbl_4.AutoSize = true;
			this._Lbl_4.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_4.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_4.Location = new System.Drawing.Point(160, 96);
			this._Lbl_4.Name = "_Lbl_4";
			this._Lbl_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_4.Size = new System.Drawing.Size(32, 13);
			this._Lbl_4.TabIndex = 87;
			this._Lbl_4.Text = "CUIT";
			this._Lbl_4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblCUIT
			// 
			this.lblCUIT.BackColor = System.Drawing.SystemColors.Control;
			this.lblCUIT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCUIT.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCUIT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCUIT.Location = new System.Drawing.Point(152, 112);
			this.lblCUIT.Name = "lblCUIT";
			this.lblCUIT.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCUIT.Size = new System.Drawing.Size(129, 20);
			this.lblCUIT.TabIndex = 86;
			// 
			// lblProvincia
			// 
			this.lblProvincia.BackColor = System.Drawing.SystemColors.Control;
			this.lblProvincia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProvincia.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblProvincia.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProvincia.Location = new System.Drawing.Point(8, 112);
			this.lblProvincia.Name = "lblProvincia";
			this.lblProvincia.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblProvincia.Size = new System.Drawing.Size(129, 20);
			this.lblProvincia.TabIndex = 66;
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
			this.lblDireccion.TabIndex = 65;
			// 
			// lblLocalidad
			// 
			this.lblLocalidad.BackColor = System.Drawing.SystemColors.Control;
			this.lblLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLocalidad.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLocalidad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLocalidad.Location = new System.Drawing.Point(264, 72);
			this.lblLocalidad.Name = "lblLocalidad";
			this.lblLocalidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLocalidad.Size = new System.Drawing.Size(153, 20);
			this.lblLocalidad.TabIndex = 64;
			// 
			// _Lbl_3
			// 
			this._Lbl_3.AutoSize = true;
			this._Lbl_3.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_3.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_3.Location = new System.Drawing.Point(16, 96);
			this._Lbl_3.Name = "_Lbl_3";
			this._Lbl_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_3.Size = new System.Drawing.Size(51, 13);
			this._Lbl_3.TabIndex = 63;
			this._Lbl_3.Text = "Provincia";
			this._Lbl_3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_2
			// 
			this._Lbl_2.AutoSize = true;
			this._Lbl_2.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_2.Location = new System.Drawing.Point(272, 56);
			this._Lbl_2.Name = "_Lbl_2";
			this._Lbl_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_2.Size = new System.Drawing.Size(53, 13);
			this._Lbl_2.TabIndex = 62;
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
			this._Lbl_1.TabIndex = 61;
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
			this._Lbl_0.TabIndex = 60;
			this._Lbl_0.Text = "Razon Social";
			this._Lbl_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// dtFecha
			// 
			this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFecha.Location = new System.Drawing.Point(475, 50);
			this.dtFecha.Name = "dtFecha";
			this.dtFecha.Size = new System.Drawing.Size(92, 20);
			this.dtFecha.TabIndex = 123;
			// 
			// _Lbl_13
			// 
			this._Lbl_13.AutoSize = true;
			this._Lbl_13.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_13.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_13.Location = new System.Drawing.Point(432, 56);
			this._Lbl_13.Name = "_Lbl_13";
			this._Lbl_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_13.Size = new System.Drawing.Size(37, 13);
			this._Lbl_13.TabIndex = 59;
			this._Lbl_13.Text = "Fecha";
			this._Lbl_13.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtNumRecibo
			// 
			this.txtNumRecibo.AcceptsReturn = true;
			this.txtNumRecibo.BackColor = System.Drawing.SystemColors.Window;
			this.txtNumRecibo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNumRecibo.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNumRecibo.Location = new System.Drawing.Point(136, 56);
			this.txtNumRecibo.MaxLength = 0;
			this.txtNumRecibo.Name = "txtNumRecibo";
			this.txtNumRecibo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtNumRecibo.Size = new System.Drawing.Size(97, 20);
			this.txtNumRecibo.TabIndex = 1;
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
			this.Toolbar1.Size = new System.Drawing.Size(1006, 39);
			this.Toolbar1.TabIndex = 144;
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
			this.tlbGuardar.Click += new System.EventHandler(this.TlbGuardarClick);
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
			this.tbImprimir.Click += new System.EventHandler(this.TbImprimirClick);
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
			// lblReciboN
			// 
			this.lblReciboN.BackColor = System.Drawing.SystemColors.Control;
			this.lblReciboN.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblReciboN.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblReciboN.Location = new System.Drawing.Point(12, 59);
			this.lblReciboN.Name = "lblReciboN";
			this.lblReciboN.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblReciboN.Size = new System.Drawing.Size(129, 14);
			this.lblReciboN.TabIndex = 81;
			this.lblReciboN.Text = "RECIBO N°";
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabFacturasA);
			this.tabControl2.Controls.Add(this.tabFacturaB);
			this.tabControl2.Controls.Add(this.tabND);
			this.tabControl2.Location = new System.Drawing.Point(585, 12);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(416, 221);
			this.tabControl2.TabIndex = 147;
			// 
			// tabFacturasA
			// 
			this.tabFacturasA.Controls.Add(this.gridFact);
			this.tabFacturasA.Location = new System.Drawing.Point(4, 22);
			this.tabFacturasA.Name = "tabFacturasA";
			this.tabFacturasA.Padding = new System.Windows.Forms.Padding(3);
			this.tabFacturasA.Size = new System.Drawing.Size(408, 195);
			this.tabFacturasA.TabIndex = 0;
			this.tabFacturasA.Text = "Facturas A";
			this.tabFacturasA.UseVisualStyleBackColor = true;
			// 
			// gridFact
			// 
			this.gridFact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridFact.Location = new System.Drawing.Point(3, 2);
			this.gridFact.Name = "gridFact";
			this.gridFact.Size = new System.Drawing.Size(402, 190);
			this.gridFact.TabIndex = 146;
			this.gridFact.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.GridFactRowsRemoved);
			// 
			// tabFacturaB
			// 
			this.tabFacturaB.Controls.Add(this.gridFactB);
			this.tabFacturaB.Location = new System.Drawing.Point(4, 22);
			this.tabFacturaB.Name = "tabFacturaB";
			this.tabFacturaB.Size = new System.Drawing.Size(408, 195);
			this.tabFacturaB.TabIndex = 2;
			this.tabFacturaB.Text = "Factura B";
			this.tabFacturaB.UseVisualStyleBackColor = true;
			// 
			// gridFactB
			// 
			this.gridFactB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridFactB.Location = new System.Drawing.Point(3, 2);
			this.gridFactB.Name = "gridFactB";
			this.gridFactB.Size = new System.Drawing.Size(402, 190);
			this.gridFactB.TabIndex = 147;
			// 
			// tabND
			// 
			this.tabND.Controls.Add(this.gridND);
			this.tabND.Location = new System.Drawing.Point(4, 22);
			this.tabND.Name = "tabND";
			this.tabND.Padding = new System.Windows.Forms.Padding(3);
			this.tabND.Size = new System.Drawing.Size(408, 195);
			this.tabND.TabIndex = 1;
			this.tabND.Text = "Nota de Debito";
			this.tabND.UseVisualStyleBackColor = true;
			// 
			// gridND
			// 
			this.gridND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridND.Location = new System.Drawing.Point(0, 2);
			this.gridND.Name = "gridND";
			this.gridND.Size = new System.Drawing.Size(401, 187);
			this.gridND.TabIndex = 147;
			this.gridND.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.GridNDRowsRemoved);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabCheque);
			this.tabControl1.Controls.Add(this.tabInterdep);
			this.tabControl1.Controls.Add(this.tabNC);
			this.tabControl1.Location = new System.Drawing.Point(17, 279);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(660, 280);
			this.tabControl1.TabIndex = 148;
			// 
			// tabCheque
			// 
			this.tabCheque.Controls.Add(this.gridCheque);
			this.tabCheque.Location = new System.Drawing.Point(4, 22);
			this.tabCheque.Name = "tabCheque";
			this.tabCheque.Padding = new System.Windows.Forms.Padding(3);
			this.tabCheque.Size = new System.Drawing.Size(652, 254);
			this.tabCheque.TabIndex = 0;
			this.tabCheque.Text = "Cheque";
			this.tabCheque.UseVisualStyleBackColor = true;
			// 
			// gridCheque
			// 
			this.gridCheque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCheque.Location = new System.Drawing.Point(0, 0);
			this.gridCheque.Name = "gridCheque";
			this.gridCheque.Size = new System.Drawing.Size(643, 248);
			this.gridCheque.TabIndex = 0;
			this.gridCheque.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.GridChequeRowsRemoved);
			// 
			// tabInterdep
			// 
			this.tabInterdep.Controls.Add(this.gridInterdeposito);
			this.tabInterdep.Location = new System.Drawing.Point(4, 22);
			this.tabInterdep.Name = "tabInterdep";
			this.tabInterdep.Padding = new System.Windows.Forms.Padding(3);
			this.tabInterdep.Size = new System.Drawing.Size(652, 254);
			this.tabInterdep.TabIndex = 1;
			this.tabInterdep.Text = "Interdeposito";
			this.tabInterdep.UseVisualStyleBackColor = true;
			// 
			// gridInterdeposito
			// 
			this.gridInterdeposito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridInterdeposito.Location = new System.Drawing.Point(0, 0);
			this.gridInterdeposito.Name = "gridInterdeposito";
			this.gridInterdeposito.Size = new System.Drawing.Size(649, 248);
			this.gridInterdeposito.TabIndex = 0;
			this.gridInterdeposito.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.GridInterdepositoRowsRemoved);
			// 
			// tabNC
			// 
			this.tabNC.Controls.Add(this.gridNC);
			this.tabNC.Location = new System.Drawing.Point(4, 22);
			this.tabNC.Name = "tabNC";
			this.tabNC.Size = new System.Drawing.Size(652, 254);
			this.tabNC.TabIndex = 2;
			this.tabNC.Text = "Nota de Credito";
			this.tabNC.UseVisualStyleBackColor = true;
			// 
			// gridNC
			// 
			this.gridNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridNC.Location = new System.Drawing.Point(0, 0);
			this.gridNC.Name = "gridNC";
			this.gridNC.Size = new System.Drawing.Size(649, 251);
			this.gridNC.TabIndex = 0;
			this.gridNC.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.GridNCRowsRemoved);
			// 
			// tabControl3
			// 
			this.tabControl3.Controls.Add(this.tabPage1);
			this.tabControl3.Controls.Add(this.tabPage2);
			this.tabControl3.Location = new System.Drawing.Point(683, 248);
			this.tabControl3.Name = "tabControl3";
			this.tabControl3.SelectedIndex = 0;
			this.tabControl3.Size = new System.Drawing.Size(311, 261);
			this.tabControl3.TabIndex = 149;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.frameVarios);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(303, 235);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Datos";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// frameVarios
			// 
			this.frameVarios.BackColor = System.Drawing.SystemColors.Control;
			this.frameVarios.Controls.Add(this.txtDescuento);
			this.frameVarios.Controls.Add(this.txtRetenciones);
			this.frameVarios.Controls.Add(this.txtVarios);
			this.frameVarios.Controls.Add(this.txtCobranzaNeta);
			this.frameVarios.Controls.Add(this.txtNO);
			this.frameVarios.Controls.Add(this.Label15);
			this.frameVarios.Controls.Add(this.Label16);
			this.frameVarios.Controls.Add(this.Label17);
			this.frameVarios.Controls.Add(this.Label18);
			this.frameVarios.Controls.Add(this.Label19);
			this.frameVarios.Controls.Add(this.Label20);
			this.frameVarios.Controls.Add(this.lblSubTotal);
			this.frameVarios.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frameVarios.Location = new System.Drawing.Point(6, 6);
			this.frameVarios.Name = "frameVarios";
			this.frameVarios.Padding = new System.Windows.Forms.Padding(0);
			this.frameVarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frameVarios.Size = new System.Drawing.Size(241, 169);
			this.frameVarios.TabIndex = 96;
			this.frameVarios.TabStop = false;
			this.frameVarios.Text = "Varios";
			// 
			// txtDescuento
			// 
			this.txtDescuento.AcceptsReturn = true;
			this.txtDescuento.BackColor = System.Drawing.SystemColors.Window;
			this.txtDescuento.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDescuento.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtDescuento.Location = new System.Drawing.Point(160, 40);
			this.txtDescuento.MaxLength = 0;
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtDescuento.Size = new System.Drawing.Size(69, 20);
			this.txtDescuento.TabIndex = 100;
			this.txtDescuento.Text = "0";
			this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtRetenciones
			// 
			this.txtRetenciones.AcceptsReturn = true;
			this.txtRetenciones.BackColor = System.Drawing.SystemColors.Window;
			this.txtRetenciones.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRetenciones.Enabled = false;
			this.txtRetenciones.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtRetenciones.Location = new System.Drawing.Point(160, 64);
			this.txtRetenciones.MaxLength = 0;
			this.txtRetenciones.Name = "txtRetenciones";
			this.txtRetenciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtRetenciones.Size = new System.Drawing.Size(69, 20);
			this.txtRetenciones.TabIndex = 99;
			this.txtRetenciones.Text = "0";
			this.txtRetenciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtVarios
			// 
			this.txtVarios.AcceptsReturn = true;
			this.txtVarios.BackColor = System.Drawing.SystemColors.Window;
			this.txtVarios.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtVarios.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtVarios.Location = new System.Drawing.Point(160, 112);
			this.txtVarios.MaxLength = 0;
			this.txtVarios.Name = "txtVarios";
			this.txtVarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtVarios.Size = new System.Drawing.Size(69, 20);
			this.txtVarios.TabIndex = 98;
			this.txtVarios.Text = "0";
			this.txtVarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtCobranzaNeta
			// 
			this.txtCobranzaNeta.AcceptsReturn = true;
			this.txtCobranzaNeta.BackColor = System.Drawing.SystemColors.Window;
			this.txtCobranzaNeta.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCobranzaNeta.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCobranzaNeta.Location = new System.Drawing.Point(160, 136);
			this.txtCobranzaNeta.MaxLength = 0;
			this.txtCobranzaNeta.Name = "txtCobranzaNeta";
			this.txtCobranzaNeta.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCobranzaNeta.Size = new System.Drawing.Size(69, 20);
			this.txtCobranzaNeta.TabIndex = 97;
			this.txtCobranzaNeta.Text = "0";
			this.txtCobranzaNeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtNO
			// 
			this.txtNO.AcceptsReturn = true;
			this.txtNO.BackColor = System.Drawing.SystemColors.Window;
			this.txtNO.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNO.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNO.Location = new System.Drawing.Point(160, 88);
			this.txtNO.MaxLength = 0;
			this.txtNO.Name = "txtNO";
			this.txtNO.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtNO.Size = new System.Drawing.Size(69, 20);
			this.txtNO.TabIndex = 96;
			this.txtNO.Text = "0";
			this.txtNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Label15
			// 
			this.Label15.BackColor = System.Drawing.SystemColors.Control;
			this.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label15.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label15.Location = new System.Drawing.Point(8, 16);
			this.Label15.Name = "Label15";
			this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label15.Size = new System.Drawing.Size(145, 21);
			this.Label15.TabIndex = 107;
			this.Label15.Text = "SubTotal";
			// 
			// Label16
			// 
			this.Label16.BackColor = System.Drawing.SystemColors.Control;
			this.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label16.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label16.Location = new System.Drawing.Point(8, 40);
			this.Label16.Name = "Label16";
			this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label16.Size = new System.Drawing.Size(145, 21);
			this.Label16.TabIndex = 106;
			this.Label16.Text = "Decuento";
			// 
			// Label17
			// 
			this.Label17.BackColor = System.Drawing.SystemColors.Control;
			this.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label17.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label17.Location = new System.Drawing.Point(8, 64);
			this.Label17.Name = "Label17";
			this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label17.Size = new System.Drawing.Size(145, 21);
			this.Label17.TabIndex = 105;
			this.Label17.Text = "Retenciones";
			// 
			// Label18
			// 
			this.Label18.BackColor = System.Drawing.SystemColors.Control;
			this.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label18.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label18.Location = new System.Drawing.Point(8, 88);
			this.Label18.Name = "Label18";
			this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label18.Size = new System.Drawing.Size(145, 21);
			this.Label18.TabIndex = 104;
			this.Label18.Text = "N / O";
			// 
			// Label19
			// 
			this.Label19.BackColor = System.Drawing.SystemColors.Control;
			this.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label19.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label19.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label19.Location = new System.Drawing.Point(8, 112);
			this.Label19.Name = "Label19";
			this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label19.Size = new System.Drawing.Size(145, 21);
			this.Label19.TabIndex = 103;
			this.Label19.Text = "Varios";
			// 
			// Label20
			// 
			this.Label20.BackColor = System.Drawing.SystemColors.Control;
			this.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label20.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label20.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label20.Location = new System.Drawing.Point(8, 136);
			this.Label20.Name = "Label20";
			this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label20.Size = new System.Drawing.Size(145, 21);
			this.Label20.TabIndex = 102;
			this.Label20.Text = "Cobranza Neta";
			// 
			// lblSubTotal
			// 
			this.lblSubTotal.BackColor = System.Drawing.SystemColors.Window;
			this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSubTotal.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblSubTotal.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lblSubTotal.Location = new System.Drawing.Point(160, 16);
			this.lblSubTotal.Name = "lblSubTotal";
			this.lblSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblSubTotal.Size = new System.Drawing.Size(69, 21);
			this.lblSubTotal.TabIndex = 101;
			this.lblSubTotal.Text = "0";
			this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.Frame2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(303, 235);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Retenciones";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Frame2
			// 
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.txtRetenIVA);
			this.Frame2.Controls.Add(this.txtRetenCargasSoc);
			this.Frame2.Controls.Add(this.txtRetenGanancias);
			this.Frame2.Controls.Add(this.txtRetenIIB);
			this.Frame2.Controls.Add(this.Label8);
			this.Frame2.Controls.Add(this.Label7);
			this.Frame2.Controls.Add(this.Label6);
			this.Frame2.Controls.Add(this.Label5);
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(11, 23);
			this.Frame2.Name = "Frame2";
			this.Frame2.Padding = new System.Windows.Forms.Padding(0);
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(241, 121);
			this.Frame2.TabIndex = 136;
			this.Frame2.TabStop = false;
			this.Frame2.Text = "Retenciones";
			// 
			// txtRetenIVA
			// 
			this.txtRetenIVA.AcceptsReturn = true;
			this.txtRetenIVA.BackColor = System.Drawing.SystemColors.Window;
			this.txtRetenIVA.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRetenIVA.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtRetenIVA.Location = new System.Drawing.Point(160, 40);
			this.txtRetenIVA.MaxLength = 0;
			this.txtRetenIVA.Name = "txtRetenIVA";
			this.txtRetenIVA.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtRetenIVA.Size = new System.Drawing.Size(69, 20);
			this.txtRetenIVA.TabIndex = 139;
			this.txtRetenIVA.Text = "0";
			this.txtRetenIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRetenIVA.TextChanged += new System.EventHandler(this.TxtRetenIVATextChanged);
			// 
			// txtRetenCargasSoc
			// 
			this.txtRetenCargasSoc.AcceptsReturn = true;
			this.txtRetenCargasSoc.BackColor = System.Drawing.SystemColors.Window;
			this.txtRetenCargasSoc.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRetenCargasSoc.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtRetenCargasSoc.Location = new System.Drawing.Point(160, 88);
			this.txtRetenCargasSoc.MaxLength = 0;
			this.txtRetenCargasSoc.Name = "txtRetenCargasSoc";
			this.txtRetenCargasSoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtRetenCargasSoc.Size = new System.Drawing.Size(69, 20);
			this.txtRetenCargasSoc.TabIndex = 138;
			this.txtRetenCargasSoc.Text = "0";
			this.txtRetenCargasSoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRetenCargasSoc.TextChanged += new System.EventHandler(this.TxtRetenCargasSocTextChanged);
			// 
			// txtRetenGanancias
			// 
			this.txtRetenGanancias.AcceptsReturn = true;
			this.txtRetenGanancias.BackColor = System.Drawing.SystemColors.Window;
			this.txtRetenGanancias.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRetenGanancias.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtRetenGanancias.Location = new System.Drawing.Point(160, 64);
			this.txtRetenGanancias.MaxLength = 0;
			this.txtRetenGanancias.Name = "txtRetenGanancias";
			this.txtRetenGanancias.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtRetenGanancias.Size = new System.Drawing.Size(69, 20);
			this.txtRetenGanancias.TabIndex = 137;
			this.txtRetenGanancias.Text = "0";
			this.txtRetenGanancias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRetenGanancias.TextChanged += new System.EventHandler(this.TxtRetenGananciasTextChanged);
			// 
			// txtRetenIIB
			// 
			this.txtRetenIIB.AcceptsReturn = true;
			this.txtRetenIIB.BackColor = System.Drawing.SystemColors.Window;
			this.txtRetenIIB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRetenIIB.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtRetenIIB.Location = new System.Drawing.Point(160, 16);
			this.txtRetenIIB.MaxLength = 0;
			this.txtRetenIIB.Name = "txtRetenIIB";
			this.txtRetenIIB.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtRetenIIB.Size = new System.Drawing.Size(69, 20);
			this.txtRetenIIB.TabIndex = 136;
			this.txtRetenIIB.Text = "0";
			this.txtRetenIIB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRetenIIB.TextChanged += new System.EventHandler(this.TxtRetenIIBTextChanged);
			// 
			// Label8
			// 
			this.Label8.BackColor = System.Drawing.SystemColors.Control;
			this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label8.Location = new System.Drawing.Point(8, 88);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(145, 21);
			this.Label8.TabIndex = 143;
			this.Label8.Text = "Cargas Sociales";
			// 
			// Label7
			// 
			this.Label7.BackColor = System.Drawing.SystemColors.Control;
			this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.Location = new System.Drawing.Point(8, 64);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(145, 21);
			this.Label7.TabIndex = 142;
			this.Label7.Text = "Ganancias";
			// 
			// Label6
			// 
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(8, 40);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(145, 21);
			this.Label6.TabIndex = 141;
			this.Label6.Text = "IVA";
			// 
			// Label5
			// 
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(8, 16);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(145, 21);
			this.Label5.TabIndex = 140;
			this.Label5.Text = "Ingresos Brutos";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(242, 568);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 150;
			this.label1.Text = "Efectivo";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(242, 591);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 151;
			this.label2.Text = "Total Cobranza";
			// 
			// txtEfectivo
			// 
			this.txtEfectivo.Location = new System.Drawing.Point(466, 565);
			this.txtEfectivo.Name = "txtEfectivo";
			this.txtEfectivo.Size = new System.Drawing.Size(101, 20);
			this.txtEfectivo.TabIndex = 152;
			this.txtEfectivo.Text = "0";
			this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblCobranzaTotal
			// 
			this.lblCobranzaTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCobranzaTotal.Location = new System.Drawing.Point(467, 590);
			this.lblCobranzaTotal.Name = "lblCobranzaTotal";
			this.lblCobranzaTotal.Size = new System.Drawing.Size(100, 17);
			this.lblCobranzaTotal.TabIndex = 153;
			this.lblCobranzaTotal.Text = "0,00";
			this.lblCobranzaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkTotos
			// 
			this.chkTotos.Location = new System.Drawing.Point(270, 65);
			this.chkTotos.Name = "chkTotos";
			this.chkTotos.Size = new System.Drawing.Size(104, 24);
			this.chkTotos.TabIndex = 154;
			this.chkTotos.Text = "Todos";
			this.chkTotos.UseVisualStyleBackColor = true;
			this.chkTotos.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// frmReciboAltas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1006, 667);
			this.Controls.Add(this.chkTotos);
			this.Controls.Add(this.lblCobranzaTotal);
			this.Controls.Add(this.txtEfectivo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tabControl3);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.dtFecha);
			this.Controls.Add(this.tabControl2);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.frCliente);
			this.Controls.Add(this.txtNumRecibo);
			this.Controls.Add(this.Toolbar1);
			this.Controls.Add(this.lblReciboN);
			this.Controls.Add(this._Lbl_13);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Location = new System.Drawing.Point(4, 30);
			this.Name = "frmReciboAltas";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Recibo Nuevo";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmReciboAltasLoad);
			this.Frame1.ResumeLayout(false);
			this.frCliente.ResumeLayout(false);
			this.frCliente.PerformLayout();
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			this.tabControl2.ResumeLayout(false);
			this.tabFacturasA.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridFact)).EndInit();
			this.tabFacturaB.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridFactB)).EndInit();
			this.tabND.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridND)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabCheque.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridCheque)).EndInit();
			this.tabInterdep.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridInterdeposito)).EndInit();
			this.tabNC.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridNC)).EndInit();
			this.tabControl3.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.frameVarios.ResumeLayout(false);
			this.frameVarios.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.Frame2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
	}
}
