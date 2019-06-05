using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	
	partial class frmContadorFactConIVA
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmContadorFactConIVA() : base()
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
		public System.Windows.Forms.TextBox txtCUIT;
		public System.Windows.Forms.Label Label18;
		public System.Windows.Forms.Label Label17;
		public System.Windows.Forms.Label Label16;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label15;
		public System.Windows.Forms.Label Label14;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label10;
		public System.Windows.Forms.TextBox txtImpBruto;
		public System.Windows.Forms.TextBox txtImpNeto;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.TextBox txtNoGravados;
		public System.Windows.Forms.TextBox txtIngBrutos;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label13;
		public System.Windows.Forms.CheckBox chIVA27;
		public System.Windows.Forms.CheckBox chIVA21;
		public System.Windows.Forms.CheckBox chIVA105;
		public System.Windows.Forms.TextBox txtIVA21;
		public System.Windows.Forms.TextBox txtIVA105;
		public System.Windows.Forms.TextBox txtIVA27;
		public System.Windows.Forms.TextBox txtNroFact;
		public System.Windows.Forms.Label Label5;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContadorFactConIVA));
			this.groupImportes = new System.Windows.Forms.GroupBox();
			this.txtImpBruto = new System.Windows.Forms.TextBox();
			this.txtImpNeto = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.groupOtrosImp = new System.Windows.Forms.GroupBox();
			this.txtPercIva = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtNoGravados = new System.Windows.Forms.TextBox();
			this.txtIngBrutos = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.groupIVA = new System.Windows.Forms.GroupBox();
			this.chIVA27 = new System.Windows.Forms.CheckBox();
			this.chIVA21 = new System.Windows.Forms.CheckBox();
			this.chIVA105 = new System.Windows.Forms.CheckBox();
			this.txtIVA21 = new System.Windows.Forms.TextBox();
			this.txtIVA105 = new System.Windows.Forms.TextBox();
			this.txtIVA27 = new System.Windows.Forms.TextBox();
			this.dtFechaIngreso = new System.Windows.Forms.DateTimePicker();
			this.dtFecha = new System.Windows.Forms.DateTimePicker();
			this.groupFechas = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabCliente = new System.Windows.Forms.TabPage();
			this.lblID = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.lblItem = new System.Windows.Forms.Label();
			this.lblSubCuenta = new System.Windows.Forms.Label();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblCuenta = new System.Windows.Forms.Label();
			this.lblRazSoc = new System.Windows.Forms.Label();
			this.lblConcepto = new System.Windows.Forms.Label();
			this.lblProvincia = new System.Windows.Forms.Label();
			this.lblLocalidad = new System.Windows.Forms.Label();
			this.txtCUIT = new System.Windows.Forms.TextBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.tabFactura = new System.Windows.Forms.TabPage();
			this.cmbTipoFC = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtNroFact = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.tabImpuestos = new System.Windows.Forms.TabPage();
			this.tabVarios = new System.Windows.Forms.TabPage();
			this.gridImpuestos = new System.Windows.Forms.DataGridView();
			this.colConcepto = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPorcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabConsulta = new System.Windows.Forms.TabPage();
			this.cmdActualizar = new System.Windows.Forms.Button();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.gridInformacion = new System.Windows.Forms.DataGridView();
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this.tlbNuevo = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button2 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbGuardar = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button4 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbImprimir = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button6 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbEditar = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button10 = new System.Windows.Forms.ToolStripSeparator();
			this.groupImportes.SuspendLayout();
			this.groupOtrosImp.SuspendLayout();
			this.groupIVA.SuspendLayout();
			this.groupFechas.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabCliente.SuspendLayout();
			this.tabFactura.SuspendLayout();
			this.tabImpuestos.SuspendLayout();
			this.tabVarios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridImpuestos)).BeginInit();
			this.tabConsulta.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridInformacion)).BeginInit();
			this.Toolbar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupImportes
			// 
			this.groupImportes.BackColor = System.Drawing.SystemColors.Control;
			this.groupImportes.Controls.Add(this.txtImpBruto);
			this.groupImportes.Controls.Add(this.txtImpNeto);
			this.groupImportes.Controls.Add(this.Label6);
			this.groupImportes.Controls.Add(this.Label8);
			this.groupImportes.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupImportes.Location = new System.Drawing.Point(11, 193);
			this.groupImportes.Name = "groupImportes";
			this.groupImportes.Padding = new System.Windows.Forms.Padding(0);
			this.groupImportes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupImportes.Size = new System.Drawing.Size(361, 89);
			this.groupImportes.TabIndex = 3;
			this.groupImportes.TabStop = false;
			this.groupImportes.Text = "Importes";
			// 
			// txtImpBruto
			// 
			this.txtImpBruto.AcceptsReturn = true;
			this.txtImpBruto.BackColor = System.Drawing.SystemColors.Window;
			this.txtImpBruto.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtImpBruto.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtImpBruto.Location = new System.Drawing.Point(152, 24);
			this.txtImpBruto.MaxLength = 0;
			this.txtImpBruto.Name = "txtImpBruto";
			this.txtImpBruto.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtImpBruto.Size = new System.Drawing.Size(180, 20);
			this.txtImpBruto.TabIndex = 0;
			this.txtImpBruto.Text = "0";
			this.txtImpBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtImpNeto
			// 
			this.txtImpNeto.AcceptsReturn = true;
			this.txtImpNeto.BackColor = System.Drawing.SystemColors.Window;
			this.txtImpNeto.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtImpNeto.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtImpNeto.Location = new System.Drawing.Point(152, 48);
			this.txtImpNeto.MaxLength = 0;
			this.txtImpNeto.Name = "txtImpNeto";
			this.txtImpNeto.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtImpNeto.Size = new System.Drawing.Size(180, 20);
			this.txtImpNeto.TabIndex = 1;
			this.txtImpNeto.Text = "0";
			this.txtImpNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Label6
			// 
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(8, 24);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(137, 17);
			this.Label6.TabIndex = 23;
			this.Label6.Text = "Imprte Bruto";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label8
			// 
			this.Label8.BackColor = System.Drawing.SystemColors.Control;
			this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label8.Location = new System.Drawing.Point(8, 48);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(137, 17);
			this.Label8.TabIndex = 22;
			this.Label8.Text = "Importe Neto";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// groupOtrosImp
			// 
			this.groupOtrosImp.BackColor = System.Drawing.SystemColors.Control;
			this.groupOtrosImp.Controls.Add(this.txtPercIva);
			this.groupOtrosImp.Controls.Add(this.label11);
			this.groupOtrosImp.Controls.Add(this.txtNoGravados);
			this.groupOtrosImp.Controls.Add(this.txtIngBrutos);
			this.groupOtrosImp.Controls.Add(this.Label9);
			this.groupOtrosImp.Controls.Add(this.Label13);
			this.groupOtrosImp.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupOtrosImp.Location = new System.Drawing.Point(13, 147);
			this.groupOtrosImp.Name = "groupOtrosImp";
			this.groupOtrosImp.Padding = new System.Windows.Forms.Padding(0);
			this.groupOtrosImp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupOtrosImp.Size = new System.Drawing.Size(361, 124);
			this.groupOtrosImp.TabIndex = 5;
			this.groupOtrosImp.TabStop = false;
			this.groupOtrosImp.Text = "Otros Impuestos";
			// 
			// txtPercIva
			// 
			this.txtPercIva.AcceptsReturn = true;
			this.txtPercIva.BackColor = System.Drawing.SystemColors.Window;
			this.txtPercIva.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPercIva.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtPercIva.Location = new System.Drawing.Point(152, 70);
			this.txtPercIva.MaxLength = 0;
			this.txtPercIva.Name = "txtPercIva";
			this.txtPercIva.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtPercIva.Size = new System.Drawing.Size(180, 20);
			this.txtPercIva.TabIndex = 2;
			this.txtPercIva.Text = "0";
			this.txtPercIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.Control;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Cursor = System.Windows.Forms.Cursors.Default;
			this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label11.Location = new System.Drawing.Point(8, 70);
			this.label11.Name = "label11";
			this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label11.Size = new System.Drawing.Size(137, 17);
			this.label11.TabIndex = 20;
			this.label11.Text = "Ret IVA";
			this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtNoGravados
			// 
			this.txtNoGravados.AcceptsReturn = true;
			this.txtNoGravados.BackColor = System.Drawing.SystemColors.Window;
			this.txtNoGravados.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNoGravados.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNoGravados.Location = new System.Drawing.Point(152, 48);
			this.txtNoGravados.MaxLength = 0;
			this.txtNoGravados.Name = "txtNoGravados";
			this.txtNoGravados.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtNoGravados.Size = new System.Drawing.Size(180, 20);
			this.txtNoGravados.TabIndex = 1;
			this.txtNoGravados.Text = "0";
			this.txtNoGravados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtIngBrutos
			// 
			this.txtIngBrutos.AcceptsReturn = true;
			this.txtIngBrutos.BackColor = System.Drawing.SystemColors.Window;
			this.txtIngBrutos.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtIngBrutos.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtIngBrutos.Location = new System.Drawing.Point(152, 24);
			this.txtIngBrutos.MaxLength = 0;
			this.txtIngBrutos.Name = "txtIngBrutos";
			this.txtIngBrutos.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtIngBrutos.Size = new System.Drawing.Size(180, 20);
			this.txtIngBrutos.TabIndex = 0;
			this.txtIngBrutos.Text = "0";
			this.txtIngBrutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Label9
			// 
			this.Label9.BackColor = System.Drawing.SystemColors.Control;
			this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label9.Location = new System.Drawing.Point(8, 48);
			this.Label9.Name = "Label9";
			this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label9.Size = new System.Drawing.Size(137, 17);
			this.Label9.TabIndex = 18;
			this.Label9.Text = "NO Gravados";
			this.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label13
			// 
			this.Label13.BackColor = System.Drawing.SystemColors.Control;
			this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label13.Location = new System.Drawing.Point(8, 24);
			this.Label13.Name = "Label13";
			this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label13.Size = new System.Drawing.Size(137, 17);
			this.Label13.TabIndex = 17;
			this.Label13.Text = "Ingresos Brutos";
			this.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// groupIVA
			// 
			this.groupIVA.BackColor = System.Drawing.SystemColors.Control;
			this.groupIVA.Controls.Add(this.chIVA27);
			this.groupIVA.Controls.Add(this.chIVA21);
			this.groupIVA.Controls.Add(this.chIVA105);
			this.groupIVA.Controls.Add(this.txtIVA21);
			this.groupIVA.Controls.Add(this.txtIVA105);
			this.groupIVA.Controls.Add(this.txtIVA27);
			this.groupIVA.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupIVA.Location = new System.Drawing.Point(13, 23);
			this.groupIVA.Name = "groupIVA";
			this.groupIVA.Padding = new System.Windows.Forms.Padding(0);
			this.groupIVA.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupIVA.Size = new System.Drawing.Size(361, 105);
			this.groupIVA.TabIndex = 4;
			this.groupIVA.TabStop = false;
			this.groupIVA.Text = "IVA";
			// 
			// chIVA27
			// 
			this.chIVA27.Appearance = System.Windows.Forms.Appearance.Button;
			this.chIVA27.BackColor = System.Drawing.SystemColors.Control;
			this.chIVA27.Cursor = System.Windows.Forms.Cursors.Default;
			this.chIVA27.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chIVA27.Location = new System.Drawing.Point(8, 72);
			this.chIVA27.Name = "chIVA27";
			this.chIVA27.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chIVA27.Size = new System.Drawing.Size(138, 20);
			this.chIVA27.TabIndex = 47;
			this.chIVA27.Text = "IVA 27%";
			this.chIVA27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chIVA27.UseVisualStyleBackColor = false;
			// 
			// chIVA21
			// 
			this.chIVA21.Appearance = System.Windows.Forms.Appearance.Button;
			this.chIVA21.BackColor = System.Drawing.SystemColors.Control;
			this.chIVA21.Checked = true;
			this.chIVA21.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chIVA21.Cursor = System.Windows.Forms.Cursors.Default;
			this.chIVA21.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chIVA21.Location = new System.Drawing.Point(8, 47);
			this.chIVA21.Name = "chIVA21";
			this.chIVA21.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chIVA21.Size = new System.Drawing.Size(138, 21);
			this.chIVA21.TabIndex = 46;
			this.chIVA21.Text = "IVA 21%";
			this.chIVA21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chIVA21.UseVisualStyleBackColor = false;
			// 
			// chIVA105
			// 
			this.chIVA105.Appearance = System.Windows.Forms.Appearance.Button;
			this.chIVA105.BackColor = System.Drawing.SystemColors.Control;
			this.chIVA105.Cursor = System.Windows.Forms.Cursors.Default;
			this.chIVA105.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chIVA105.Location = new System.Drawing.Point(8, 24);
			this.chIVA105.Name = "chIVA105";
			this.chIVA105.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chIVA105.Size = new System.Drawing.Size(138, 22);
			this.chIVA105.TabIndex = 45;
			this.chIVA105.Text = "IVA 10,5%";
			this.chIVA105.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chIVA105.UseVisualStyleBackColor = false;
			// 
			// txtIVA21
			// 
			this.txtIVA21.AcceptsReturn = true;
			this.txtIVA21.BackColor = System.Drawing.SystemColors.Window;
			this.txtIVA21.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtIVA21.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtIVA21.Location = new System.Drawing.Point(152, 48);
			this.txtIVA21.MaxLength = 0;
			this.txtIVA21.Name = "txtIVA21";
			this.txtIVA21.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtIVA21.Size = new System.Drawing.Size(180, 20);
			this.txtIVA21.TabIndex = 0;
			this.txtIVA21.Text = "0";
			this.txtIVA21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtIVA105
			// 
			this.txtIVA105.AcceptsReturn = true;
			this.txtIVA105.BackColor = System.Drawing.SystemColors.Window;
			this.txtIVA105.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtIVA105.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtIVA105.Location = new System.Drawing.Point(152, 24);
			this.txtIVA105.MaxLength = 0;
			this.txtIVA105.Name = "txtIVA105";
			this.txtIVA105.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtIVA105.Size = new System.Drawing.Size(180, 20);
			this.txtIVA105.TabIndex = 1;
			this.txtIVA105.Text = "0";
			this.txtIVA105.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtIVA27
			// 
			this.txtIVA27.AcceptsReturn = true;
			this.txtIVA27.BackColor = System.Drawing.SystemColors.Window;
			this.txtIVA27.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtIVA27.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtIVA27.Location = new System.Drawing.Point(152, 72);
			this.txtIVA27.MaxLength = 0;
			this.txtIVA27.Name = "txtIVA27";
			this.txtIVA27.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtIVA27.Size = new System.Drawing.Size(180, 20);
			this.txtIVA27.TabIndex = 2;
			this.txtIVA27.Text = "0";
			this.txtIVA27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// dtFechaIngreso
			// 
			this.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaIngreso.Location = new System.Drawing.Point(114, 20);
			this.dtFechaIngreso.Name = "dtFechaIngreso";
			this.dtFechaIngreso.Size = new System.Drawing.Size(105, 20);
			this.dtFechaIngreso.TabIndex = 0;
			// 
			// dtFecha
			// 
			this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFecha.Location = new System.Drawing.Point(114, 46);
			this.dtFecha.Name = "dtFecha";
			this.dtFecha.Size = new System.Drawing.Size(105, 20);
			this.dtFecha.TabIndex = 1;
			// 
			// groupFechas
			// 
			this.groupFechas.Controls.Add(this.label7);
			this.groupFechas.Controls.Add(this.label2);
			this.groupFechas.Controls.Add(this.dtFechaIngreso);
			this.groupFechas.Controls.Add(this.dtFecha);
			this.groupFechas.Location = new System.Drawing.Point(11, 95);
			this.groupFechas.Name = "groupFechas";
			this.groupFechas.Size = new System.Drawing.Size(228, 72);
			this.groupFechas.TabIndex = 2;
			this.groupFechas.TabStop = false;
			this.groupFechas.Text = "Fechas";
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Location = new System.Drawing.Point(8, 46);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 20);
			this.label7.TabIndex = 40;
			this.label7.Text = "Fecha";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(8, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 40;
			this.label2.Text = "Fecha Ingreso";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 0);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(200, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 17);
			this.toolStripStatusLabel1.Text = "stripBaseDatos";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabCliente);
			this.tabControl1.Controls.Add(this.tabFactura);
			this.tabControl1.Controls.Add(this.tabImpuestos);
			this.tabControl1.Controls.Add(this.tabVarios);
			this.tabControl1.Controls.Add(this.tabConsulta);
			this.tabControl1.Location = new System.Drawing.Point(12, 57);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(986, 511);
			this.tabControl1.TabIndex = 10;
			// 
			// tabCliente
			// 
			this.tabCliente.Controls.Add(this.lblID);
			this.tabCliente.Controls.Add(this.label21);
			this.tabCliente.Controls.Add(this.lblItem);
			this.tabCliente.Controls.Add(this.lblSubCuenta);
			this.tabCliente.Controls.Add(this.lblDireccion);
			this.tabCliente.Controls.Add(this.lblCuenta);
			this.tabCliente.Controls.Add(this.lblRazSoc);
			this.tabCliente.Controls.Add(this.lblConcepto);
			this.tabCliente.Controls.Add(this.lblProvincia);
			this.tabCliente.Controls.Add(this.lblLocalidad);
			this.tabCliente.Controls.Add(this.txtCUIT);
			this.tabCliente.Controls.Add(this.Label18);
			this.tabCliente.Controls.Add(this.Label17);
			this.tabCliente.Controls.Add(this.Label16);
			this.tabCliente.Controls.Add(this.Label1);
			this.tabCliente.Controls.Add(this.Label15);
			this.tabCliente.Controls.Add(this.Label14);
			this.tabCliente.Controls.Add(this.Label3);
			this.tabCliente.Controls.Add(this.Label4);
			this.tabCliente.Controls.Add(this.Label10);
			this.tabCliente.Location = new System.Drawing.Point(4, 22);
			this.tabCliente.Name = "tabCliente";
			this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
			this.tabCliente.Size = new System.Drawing.Size(978, 485);
			this.tabCliente.TabIndex = 1;
			this.tabCliente.Text = "Cliente";
			this.tabCliente.UseVisualStyleBackColor = true;
			// 
			// lblID
			// 
			this.lblID.BackColor = System.Drawing.SystemColors.Control;
			this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblID.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblID.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblID.Location = new System.Drawing.Point(149, 35);
			this.lblID.Name = "lblID";
			this.lblID.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblID.Size = new System.Drawing.Size(181, 17);
			this.lblID.TabIndex = 59;
			this.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.SystemColors.Control;
			this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label21.Cursor = System.Windows.Forms.Cursors.Default;
			this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label21.Location = new System.Drawing.Point(6, 35);
			this.label21.Name = "label21";
			this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label21.Size = new System.Drawing.Size(137, 17);
			this.label21.TabIndex = 58;
			this.label21.Text = "ID";
			this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblItem
			// 
			this.lblItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblItem.Location = new System.Drawing.Point(150, 253);
			this.lblItem.Name = "lblItem";
			this.lblItem.Size = new System.Drawing.Size(180, 20);
			this.lblItem.TabIndex = 49;
			// 
			// lblSubCuenta
			// 
			this.lblSubCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSubCuenta.Location = new System.Drawing.Point(150, 229);
			this.lblSubCuenta.Name = "lblSubCuenta";
			this.lblSubCuenta.Size = new System.Drawing.Size(180, 20);
			this.lblSubCuenta.TabIndex = 54;
			// 
			// lblDireccion
			// 
			this.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDireccion.Location = new System.Drawing.Point(150, 109);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(180, 20);
			this.lblDireccion.TabIndex = 52;
			// 
			// lblCuenta
			// 
			this.lblCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblCuenta.Location = new System.Drawing.Point(150, 205);
			this.lblCuenta.Name = "lblCuenta";
			this.lblCuenta.Size = new System.Drawing.Size(180, 20);
			this.lblCuenta.TabIndex = 51;
			// 
			// lblRazSoc
			// 
			this.lblRazSoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRazSoc.Location = new System.Drawing.Point(150, 86);
			this.lblRazSoc.Name = "lblRazSoc";
			this.lblRazSoc.Size = new System.Drawing.Size(180, 20);
			this.lblRazSoc.TabIndex = 50;
			// 
			// lblConcepto
			// 
			this.lblConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblConcepto.Location = new System.Drawing.Point(150, 181);
			this.lblConcepto.Name = "lblConcepto";
			this.lblConcepto.Size = new System.Drawing.Size(180, 20);
			this.lblConcepto.TabIndex = 53;
			// 
			// lblProvincia
			// 
			this.lblProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblProvincia.Location = new System.Drawing.Point(150, 157);
			this.lblProvincia.Name = "lblProvincia";
			this.lblProvincia.Size = new System.Drawing.Size(180, 20);
			this.lblProvincia.TabIndex = 56;
			// 
			// lblLocalidad
			// 
			this.lblLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblLocalidad.Location = new System.Drawing.Point(150, 133);
			this.lblLocalidad.Name = "lblLocalidad";
			this.lblLocalidad.Size = new System.Drawing.Size(180, 20);
			this.lblLocalidad.TabIndex = 55;
			// 
			// txtCUIT
			// 
			this.txtCUIT.AcceptsReturn = true;
			this.txtCUIT.BackColor = System.Drawing.SystemColors.Window;
			this.txtCUIT.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCUIT.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCUIT.Location = new System.Drawing.Point(150, 61);
			this.txtCUIT.MaxLength = 11;
			this.txtCUIT.Name = "txtCUIT";
			this.txtCUIT.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCUIT.Size = new System.Drawing.Size(180, 20);
			this.txtCUIT.TabIndex = 40;
			this.txtCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCUITKeyPress);
			// 
			// Label18
			// 
			this.Label18.BackColor = System.Drawing.SystemColors.Control;
			this.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label18.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label18.Location = new System.Drawing.Point(6, 253);
			this.Label18.Name = "Label18";
			this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label18.Size = new System.Drawing.Size(137, 17);
			this.Label18.TabIndex = 57;
			this.Label18.Text = "Items";
			this.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label17
			// 
			this.Label17.BackColor = System.Drawing.SystemColors.Control;
			this.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label17.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label17.Location = new System.Drawing.Point(6, 229);
			this.Label17.Name = "Label17";
			this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label17.Size = new System.Drawing.Size(137, 17);
			this.Label17.TabIndex = 48;
			this.Label17.Text = "Sub Cuenta";
			this.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label16
			// 
			this.Label16.BackColor = System.Drawing.SystemColors.Control;
			this.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label16.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label16.Location = new System.Drawing.Point(6, 205);
			this.Label16.Name = "Label16";
			this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label16.Size = new System.Drawing.Size(137, 17);
			this.Label16.TabIndex = 47;
			this.Label16.Text = "Cuenta";
			this.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(6, 181);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(137, 17);
			this.Label1.TabIndex = 46;
			this.Label1.Text = "Concepto";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label15
			// 
			this.Label15.BackColor = System.Drawing.SystemColors.Control;
			this.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label15.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label15.Location = new System.Drawing.Point(6, 157);
			this.Label15.Name = "Label15";
			this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label15.Size = new System.Drawing.Size(137, 17);
			this.Label15.TabIndex = 45;
			this.Label15.Text = "Provincia";
			this.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label14
			// 
			this.Label14.BackColor = System.Drawing.SystemColors.Control;
			this.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label14.Location = new System.Drawing.Point(6, 133);
			this.Label14.Name = "Label14";
			this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label14.Size = new System.Drawing.Size(137, 17);
			this.Label14.TabIndex = 44;
			this.Label14.Text = "Localidad";
			this.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label3
			// 
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(6, 85);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(137, 17);
			this.Label3.TabIndex = 43;
			this.Label3.Text = "Razon Social";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label4
			// 
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(6, 61);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(137, 17);
			this.Label4.TabIndex = 42;
			this.Label4.Text = "CUIT";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label10
			// 
			this.Label10.BackColor = System.Drawing.SystemColors.Control;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label10.Location = new System.Drawing.Point(6, 109);
			this.Label10.Name = "Label10";
			this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label10.Size = new System.Drawing.Size(137, 17);
			this.Label10.TabIndex = 41;
			this.Label10.Text = "Direccion";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tabFactura
			// 
			this.tabFactura.Controls.Add(this.cmbTipoFC);
			this.tabFactura.Controls.Add(this.label12);
			this.tabFactura.Controls.Add(this.txtNroFact);
			this.tabFactura.Controls.Add(this.groupImportes);
			this.tabFactura.Controls.Add(this.groupFechas);
			this.tabFactura.Controls.Add(this.Label5);
			this.tabFactura.Location = new System.Drawing.Point(4, 22);
			this.tabFactura.Name = "tabFactura";
			this.tabFactura.Padding = new System.Windows.Forms.Padding(3);
			this.tabFactura.Size = new System.Drawing.Size(978, 485);
			this.tabFactura.TabIndex = 0;
			this.tabFactura.Text = "Factura";
			this.tabFactura.UseVisualStyleBackColor = true;
			// 
			// cmbTipoFC
			// 
			this.cmbTipoFC.FormattingEnabled = true;
			this.cmbTipoFC.Items.AddRange(new object[] {
			"A",
			"B",
			"C",
			"NC",
			"ND"});
			this.cmbTipoFC.Location = new System.Drawing.Point(155, 52);
			this.cmbTipoFC.Name = "cmbTipoFC";
			this.cmbTipoFC.Size = new System.Drawing.Size(44, 21);
			this.cmbTipoFC.TabIndex = 10;
			this.cmbTipoFC.Text = "A";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.Control;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label12.Cursor = System.Windows.Forms.Cursors.Default;
			this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label12.Location = new System.Drawing.Point(11, 54);
			this.label12.Name = "label12";
			this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label12.Size = new System.Drawing.Size(137, 17);
			this.label12.TabIndex = 6;
			this.label12.Text = "Tipo de Factura";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtNroFact
			// 
			this.txtNroFact.AcceptsReturn = true;
			this.txtNroFact.BackColor = System.Drawing.SystemColors.Window;
			this.txtNroFact.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNroFact.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNroFact.Location = new System.Drawing.Point(155, 21);
			this.txtNroFact.MaxLength = 0;
			this.txtNroFact.Name = "txtNroFact";
			this.txtNroFact.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtNroFact.Size = new System.Drawing.Size(180, 20);
			this.txtNroFact.TabIndex = 4;
			// 
			// Label5
			// 
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(11, 21);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(137, 17);
			this.Label5.TabIndex = 5;
			this.Label5.Text = "Numero de Factura";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tabImpuestos
			// 
			this.tabImpuestos.Controls.Add(this.groupIVA);
			this.tabImpuestos.Controls.Add(this.groupOtrosImp);
			this.tabImpuestos.Location = new System.Drawing.Point(4, 22);
			this.tabImpuestos.Name = "tabImpuestos";
			this.tabImpuestos.Size = new System.Drawing.Size(978, 485);
			this.tabImpuestos.TabIndex = 2;
			this.tabImpuestos.Text = "Impuestos";
			this.tabImpuestos.UseVisualStyleBackColor = true;
			// 
			// tabVarios
			// 
			this.tabVarios.Controls.Add(this.gridImpuestos);
			this.tabVarios.Location = new System.Drawing.Point(4, 22);
			this.tabVarios.Name = "tabVarios";
			this.tabVarios.Size = new System.Drawing.Size(978, 485);
			this.tabVarios.TabIndex = 3;
			this.tabVarios.Text = "Varios";
			this.tabVarios.UseVisualStyleBackColor = true;
			// 
			// gridImpuestos
			// 
			this.gridImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridImpuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colConcepto,
			this.colBase,
			this.colPorcentaje,
			this.colImporte});
			this.gridImpuestos.Location = new System.Drawing.Point(14, 35);
			this.gridImpuestos.Name = "gridImpuestos";
			this.gridImpuestos.Size = new System.Drawing.Size(469, 273);
			this.gridImpuestos.TabIndex = 9;
			this.gridImpuestos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridImpuestosCellEndEdit);
			this.gridImpuestos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridImpuestosCellValueChanged);
			this.gridImpuestos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.GridImpuestosRowsAdded);
			// 
			// colConcepto
			// 
			this.colConcepto.HeaderText = "Concepto";
			this.colConcepto.Items.AddRange(new object[] {
			"IVA",
			"Ret IIBB",
			"Ret IVA",
			"No Gravados"});
			this.colConcepto.Name = "colConcepto";
			// 
			// colBase
			// 
			this.colBase.HeaderText = "Base";
			this.colBase.Name = "colBase";
			this.colBase.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colBase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// colPorcentaje
			// 
			this.colPorcentaje.HeaderText = "Porcentaje";
			this.colPorcentaje.Name = "colPorcentaje";
			// 
			// colImporte
			// 
			this.colImporte.HeaderText = "Importe";
			this.colImporte.Name = "colImporte";
			this.colImporte.ReadOnly = true;
			// 
			// tabConsulta
			// 
			this.tabConsulta.Controls.Add(this.cmdActualizar);
			this.tabConsulta.Controls.Add(this.label20);
			this.tabConsulta.Controls.Add(this.label19);
			this.tabConsulta.Controls.Add(this.dateTimePicker2);
			this.tabConsulta.Controls.Add(this.dateTimePicker1);
			this.tabConsulta.Controls.Add(this.gridInformacion);
			this.tabConsulta.Location = new System.Drawing.Point(4, 22);
			this.tabConsulta.Name = "tabConsulta";
			this.tabConsulta.Size = new System.Drawing.Size(978, 485);
			this.tabConsulta.TabIndex = 4;
			this.tabConsulta.Text = "Consulta";
			this.tabConsulta.UseVisualStyleBackColor = true;
			// 
			// cmdActualizar
			// 
			this.cmdActualizar.Location = new System.Drawing.Point(859, 22);
			this.cmdActualizar.Name = "cmdActualizar";
			this.cmdActualizar.Size = new System.Drawing.Size(104, 24);
			this.cmdActualizar.TabIndex = 5;
			this.cmdActualizar.Text = "Actualizar";
			this.cmdActualizar.UseVisualStyleBackColor = true;
			this.cmdActualizar.Click += new System.EventHandler(this.CmdActualizarClick);
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(9, 20);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(100, 23);
			this.label20.TabIndex = 4;
			this.label20.Text = "Inicio";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(237, 20);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(100, 23);
			this.label19.TabIndex = 3;
			this.label19.Text = "Fin";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(237, 46);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker2.TabIndex = 2;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(9, 46);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 1;
			// 
			// gridInformacion
			// 
			this.gridInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridInformacion.Location = new System.Drawing.Point(3, 84);
			this.gridInformacion.Name = "gridInformacion";
			this.gridInformacion.Size = new System.Drawing.Size(961, 398);
			this.gridInformacion.TabIndex = 0;
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
			this.tlbEditar,
			this._Toolbar1_Button10});
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.Size = new System.Drawing.Size(1249, 42);
			this.Toolbar1.TabIndex = 42;
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
			// 
			// _Toolbar1_Button6
			// 
			this._Toolbar1_Button6.Name = "_Toolbar1_Button6";
			this._Toolbar1_Button6.Size = new System.Drawing.Size(6, 42);
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
			// frmContadorFactConIVA
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1249, 734);
			this.Controls.Add(this.Toolbar1);
			this.Controls.Add(this.tabControl1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 28);
			this.Name = "frmContadorFactConIVA";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Facturas Con IVA";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmContadorFactConIVALoad);
			this.groupImportes.ResumeLayout(false);
			this.groupImportes.PerformLayout();
			this.groupOtrosImp.ResumeLayout(false);
			this.groupOtrosImp.PerformLayout();
			this.groupIVA.ResumeLayout(false);
			this.groupIVA.PerformLayout();
			this.groupFechas.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabCliente.ResumeLayout(false);
			this.tabCliente.PerformLayout();
			this.tabFactura.ResumeLayout(false);
			this.tabFactura.PerformLayout();
			this.tabImpuestos.ResumeLayout(false);
			this.tabVarios.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridImpuestos)).EndInit();
			this.tabConsulta.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridInformacion)).EndInit();
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.TabPage tabFactura;
		private System.Windows.Forms.TabPage tabCliente;
		private System.Windows.Forms.TabPage tabImpuestos;
		private System.Windows.Forms.ComboBox cmbTipoFC;
		public System.Windows.Forms.Label label12;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.DataGridView gridImpuestos;
		public System.Windows.Forms.TextBox txtPercIva;
		private System.Windows.Forms.DateTimePicker dtFecha;
		private System.Windows.Forms.DateTimePicker dtFechaIngreso;
		private System.Windows.Forms.DataGridViewTextBoxColumn colImporte;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPorcentaje;
		private System.Windows.Forms.DataGridViewTextBoxColumn colBase;
		private System.Windows.Forms.DataGridViewComboBoxColumn colConcepto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupFechas;
		public System.Windows.Forms.Label label11;
		public System.Windows.Forms.GroupBox groupIVA;
		public System.Windows.Forms.GroupBox groupOtrosImp;
		public System.Windows.Forms.GroupBox groupImportes;
		private System.Windows.Forms.Label lblItem;
		private System.Windows.Forms.Label lblConcepto;
		private System.Windows.Forms.Label lblCuenta;
		private System.Windows.Forms.Label lblSubCuenta;
		private System.Windows.Forms.Label lblProvincia;
		private System.Windows.Forms.Label lblLocalidad;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.Label lblRazSoc;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.ToolStripButton tlbNuevo;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button2;
		public System.Windows.Forms.ToolStripButton tlbGuardar;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button4;
		public System.Windows.Forms.ToolStripButton tlbImprimir;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button6;
		public System.Windows.Forms.ToolStripButton tlbEditar;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button10;
		private System.Windows.Forms.TabPage tabVarios;
		private System.Windows.Forms.TabPage tabConsulta;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DataGridView gridInformacion;
		private System.Windows.Forms.Button cmdActualizar;
		public System.Windows.Forms.Label lblID;
		public System.Windows.Forms.Label label21;
		
			#endregion
	}
}
