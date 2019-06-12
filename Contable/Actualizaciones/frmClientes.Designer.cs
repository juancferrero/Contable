using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	//[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class frmClientes
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmClientes() : base()
		{
			//Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();
			//Éste es un formulario MDI secundario.
			//Este código simula la funcionalidad de VB6 
			// de cargar automáticamente
			// y mostrar el formulario primario de
			// un MDI secundario.
			
			
			//this.MdiParent = My.MyProject.Forms.Principal;
			//My.MyProject.Forms.Principal.Show();
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
		public System.Windows.Forms.RadioButton optLocalidad;
		public System.Windows.Forms.RadioButton optProvincia;
		public System.Windows.Forms.RadioButton optContacto;
		public System.Windows.Forms.RadioButton optNombre;
		public System.Windows.Forms.GroupBox Frame8;
		public System.Windows.Forms.TextBox txtRazonSocial;
		public System.Windows.Forms.ComboBox cmbLocalidad;
		public System.Windows.Forms.ComboBox cmbProvincia;
		public System.Windows.Forms.TextBox txtDireccion;
		public System.Windows.Forms.TextBox txtDesc;
		public System.Windows.Forms.TextBox txtCUIT;
		public System.Windows.Forms.TextBox txtCodPos;
		public System.Windows.Forms.TextBox txtTelefono2;
		public System.Windows.Forms.TextBox txtTelefono1;
		public System.Windows.Forms.TextBox txtEMail;
		public System.Windows.Forms.TextBox txtFax;
		public System.Windows.Forms.TextBox txtNumClie;
		public System.Windows.Forms.Label _Label1_18;
		public System.Windows.Forms.Label _Label1_8;
		public System.Windows.Forms.Label _Label1_7;
		public System.Windows.Forms.Label _Label1_6;
		public System.Windows.Forms.Label _Label1_5;
		public System.Windows.Forms.Label _Label1_4;
		public System.Windows.Forms.Label _Label1_3;
		public System.Windows.Forms.Label _Label1_2;
		public System.Windows.Forms.Label _Label1_1;
		public System.Windows.Forms.Label _Label1_13;
		public System.Windows.Forms.Label _Label1_17;
		public System.Windows.Forms.Label _Label1_11;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.TabPage _SSTab1_TabPage0;
		public System.Windows.Forms.TabPage _SSTab1_TabPage1;
		public System.Windows.Forms.TextBox txtTranspNum;
		public System.Windows.Forms.TextBox txtTranspDireccion;
		public System.Windows.Forms.ComboBox cmbTranspNombre;
		public System.Windows.Forms.Label _Label1_12;
		public System.Windows.Forms.Label _Label1_9;
		public System.Windows.Forms.Label _Label1_10;
		public System.Windows.Forms.GroupBox Frame3;
		public System.Windows.Forms.TabPage _SSTab1_TabPage2;
		public System.Windows.Forms.RichTextBox richNotas;
		public System.Windows.Forms.TabPage _SSTab1_TabPage3;
		public System.Windows.Forms.TabPage _SSTab1_TabPage4;
		public System.Windows.Forms.RadioButton OptAct;
		public System.Windows.Forms.RadioButton OptInact;
		public System.Windows.Forms.GroupBox Frame7;
		public System.Windows.Forms.ProgressBar ProgressBar1;
		public System.Windows.Forms.GroupBox Frame6;
		public System.Windows.Forms.RadioButton OptNo;
		public System.Windows.Forms.RadioButton OptYes;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.ComboBox cmbClienteDe;
		public System.Windows.Forms.GroupBox Frame5;
		public System.Windows.Forms.TabPage _SSTab1_TabPage5;
		public System.Windows.Forms.TabControl SSTab1;
		public System.Windows.Forms.ToolStripButton tlbNuevo;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button2;
		public System.Windows.Forms.ToolStripButton tlbGuardar;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button4;
		public System.Windows.Forms.ToolStripButton tlbImprimir;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button6;
		public System.Windows.Forms.ToolStripButton tlbAnular;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button8;
		public System.Windows.Forms.ToolStripButton tlbEditar;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.Label Label2;
		//public Microsoft.VisualBasic.Compatibility.VB6.LabelArray Label1;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SSTab1 = new System.Windows.Forms.TabControl();
			this.tabBusqueda = new System.Windows.Forms.TabPage();
			this.txtCriterio = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.gridData = new System.Windows.Forms.DataGridView();
			this.Frame8 = new System.Windows.Forms.GroupBox();
			this.optLocalidad = new System.Windows.Forms.RadioButton();
			this.optProvincia = new System.Windows.Forms.RadioButton();
			this.optContacto = new System.Windows.Forms.RadioButton();
			this.optNombre = new System.Windows.Forms.RadioButton();
			this._SSTab1_TabPage0 = new System.Windows.Forms.TabPage();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.cmbLocalidad = new System.Windows.Forms.ComboBox();
			this.cmbProvincia = new System.Windows.Forms.ComboBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.txtCUIT = new System.Windows.Forms.TextBox();
			this.txtCodPos = new System.Windows.Forms.TextBox();
			this.txtTelefono2 = new System.Windows.Forms.TextBox();
			this.txtTelefono1 = new System.Windows.Forms.TextBox();
			this.txtEMail = new System.Windows.Forms.TextBox();
			this.txtFax = new System.Windows.Forms.TextBox();
			this.txtNumClie = new System.Windows.Forms.TextBox();
			this._Label1_18 = new System.Windows.Forms.Label();
			this._Label1_8 = new System.Windows.Forms.Label();
			this._Label1_7 = new System.Windows.Forms.Label();
			this._Label1_6 = new System.Windows.Forms.Label();
			this._Label1_5 = new System.Windows.Forms.Label();
			this._Label1_4 = new System.Windows.Forms.Label();
			this._Label1_3 = new System.Windows.Forms.Label();
			this._Label1_2 = new System.Windows.Forms.Label();
			this._Label1_1 = new System.Windows.Forms.Label();
			this._Label1_13 = new System.Windows.Forms.Label();
			this._Label1_17 = new System.Windows.Forms.Label();
			this._Label1_11 = new System.Windows.Forms.Label();
			this._SSTab1_TabPage1 = new System.Windows.Forms.TabPage();
			this.dataContactos = new System.Windows.Forms.DataGridView();
			this.colContactoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colContactoDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._SSTab1_TabPage2 = new System.Windows.Forms.TabPage();
			this.Frame3 = new System.Windows.Forms.GroupBox();
			this.txtTranspNum = new System.Windows.Forms.TextBox();
			this.txtTranspDireccion = new System.Windows.Forms.TextBox();
			this.cmbTranspNombre = new System.Windows.Forms.ComboBox();
			this._Label1_12 = new System.Windows.Forms.Label();
			this._Label1_9 = new System.Windows.Forms.Label();
			this._Label1_10 = new System.Windows.Forms.Label();
			this._SSTab1_TabPage3 = new System.Windows.Forms.TabPage();
			this.richNotas = new System.Windows.Forms.RichTextBox();
			this._SSTab1_TabPage4 = new System.Windows.Forms.TabPage();
			this._SSTab1_TabPage5 = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Frame7 = new System.Windows.Forms.GroupBox();
			this.OptAct = new System.Windows.Forms.RadioButton();
			this.OptInact = new System.Windows.Forms.RadioButton();
			this.Frame6 = new System.Windows.Forms.GroupBox();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.OptNo = new System.Windows.Forms.RadioButton();
			this.OptYes = new System.Windows.Forms.RadioButton();
			this.Frame5 = new System.Windows.Forms.GroupBox();
			this.cmbClienteDe = new System.Windows.Forms.ComboBox();
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
			this.SSTab1.SuspendLayout();
			this.tabBusqueda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
			this.Frame8.SuspendLayout();
			this._SSTab1_TabPage0.SuspendLayout();
			this.Frame1.SuspendLayout();
			this._SSTab1_TabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataContactos)).BeginInit();
			this._SSTab1_TabPage2.SuspendLayout();
			this.Frame3.SuspendLayout();
			this._SSTab1_TabPage3.SuspendLayout();
			this._SSTab1_TabPage5.SuspendLayout();
			this.Frame7.SuspendLayout();
			this.Frame6.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.Frame5.SuspendLayout();
			this.Toolbar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SSTab1
			// 
			this.SSTab1.Controls.Add(this.tabBusqueda);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage0);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage1);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage2);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage3);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage4);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage5);
			this.SSTab1.ItemSize = new System.Drawing.Size(42, 18);
			this.SSTab1.Location = new System.Drawing.Point(0, 47);
			this.SSTab1.Name = "SSTab1";
			this.SSTab1.SelectedIndex = 5;
			this.SSTab1.Size = new System.Drawing.Size(1342, 634);
			this.SSTab1.TabIndex = 0;
			// 
			// tabBusqueda
			// 
			this.tabBusqueda.Controls.Add(this.txtCriterio);
			this.tabBusqueda.Controls.Add(this.Label2);
			this.tabBusqueda.Controls.Add(this.gridData);
			this.tabBusqueda.Controls.Add(this.Frame8);
			this.tabBusqueda.Location = new System.Drawing.Point(4, 22);
			this.tabBusqueda.Name = "tabBusqueda";
			this.tabBusqueda.Size = new System.Drawing.Size(1334, 608);
			this.tabBusqueda.TabIndex = 6;
			this.tabBusqueda.Text = "Busqueda";
			this.tabBusqueda.UseVisualStyleBackColor = true;
			// 
			// txtCriterio
			// 
			this.txtCriterio.AcceptsReturn = true;
			this.txtCriterio.BackColor = System.Drawing.SystemColors.Window;
			this.txtCriterio.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCriterio.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCriterio.Location = new System.Drawing.Point(136, 16);
			this.txtCriterio.MaxLength = 0;
			this.txtCriterio.Name = "txtCriterio";
			this.txtCriterio.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCriterio.Size = new System.Drawing.Size(257, 20);
			this.txtCriterio.TabIndex = 57;
			this.txtCriterio.TextChanged += new System.EventHandler(this.TxtCriterioTextChanged);
			this.txtCriterio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCriterioKeyPress);
			// 
			// Label2
			// 
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(8, 16);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(121, 17);
			this.Label2.TabIndex = 58;
			this.Label2.Text = "Filtar por:";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// gridData
			// 
			this.gridData.AllowUserToAddRows = false;
			this.gridData.AllowUserToDeleteRows = false;
			this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
			this.gridData.Location = new System.Drawing.Point(8, 137);
			this.gridData.MultiSelect = false;
			this.gridData.Name = "gridData";
			this.gridData.ReadOnly = true;
			this.gridData.Size = new System.Drawing.Size(950, 290);
			this.gridData.TabIndex = 60;
			this.gridData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDataCellContentDoubleClick);
			// 
			// Frame8
			// 
			this.Frame8.BackColor = System.Drawing.SystemColors.Control;
			this.Frame8.Controls.Add(this.optLocalidad);
			this.Frame8.Controls.Add(this.optProvincia);
			this.Frame8.Controls.Add(this.optContacto);
			this.Frame8.Controls.Add(this.optNombre);
			this.Frame8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame8.Location = new System.Drawing.Point(8, 40);
			this.Frame8.Name = "Frame8";
			this.Frame8.Padding = new System.Windows.Forms.Padding(0);
			this.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame8.Size = new System.Drawing.Size(121, 91);
			this.Frame8.TabIndex = 59;
			this.Frame8.TabStop = false;
			// 
			// optLocalidad
			// 
			this.optLocalidad.BackColor = System.Drawing.SystemColors.Control;
			this.optLocalidad.Cursor = System.Windows.Forms.Cursors.Default;
			this.optLocalidad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optLocalidad.Location = new System.Drawing.Point(8, 64);
			this.optLocalidad.Name = "optLocalidad";
			this.optLocalidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optLocalidad.Size = new System.Drawing.Size(105, 17);
			this.optLocalidad.TabIndex = 59;
			this.optLocalidad.TabStop = true;
			this.optLocalidad.Text = "Localidad";
			this.optLocalidad.UseVisualStyleBackColor = false;
			// 
			// optProvincia
			// 
			this.optProvincia.BackColor = System.Drawing.SystemColors.Control;
			this.optProvincia.Cursor = System.Windows.Forms.Cursors.Default;
			this.optProvincia.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optProvincia.Location = new System.Drawing.Point(8, 48);
			this.optProvincia.Name = "optProvincia";
			this.optProvincia.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optProvincia.Size = new System.Drawing.Size(105, 17);
			this.optProvincia.TabIndex = 58;
			this.optProvincia.TabStop = true;
			this.optProvincia.Text = "Provincia";
			this.optProvincia.UseVisualStyleBackColor = false;
			// 
			// optContacto
			// 
			this.optContacto.BackColor = System.Drawing.SystemColors.Control;
			this.optContacto.Cursor = System.Windows.Forms.Cursors.Default;
			this.optContacto.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optContacto.Location = new System.Drawing.Point(8, 32);
			this.optContacto.Name = "optContacto";
			this.optContacto.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optContacto.Size = new System.Drawing.Size(105, 17);
			this.optContacto.TabIndex = 57;
			this.optContacto.TabStop = true;
			this.optContacto.Text = "Contacto";
			this.optContacto.UseVisualStyleBackColor = false;
			// 
			// optNombre
			// 
			this.optNombre.BackColor = System.Drawing.SystemColors.Control;
			this.optNombre.Checked = true;
			this.optNombre.Cursor = System.Windows.Forms.Cursors.Default;
			this.optNombre.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optNombre.Location = new System.Drawing.Point(8, 16);
			this.optNombre.Name = "optNombre";
			this.optNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optNombre.Size = new System.Drawing.Size(105, 17);
			this.optNombre.TabIndex = 56;
			this.optNombre.TabStop = true;
			this.optNombre.Text = "Nombre";
			this.optNombre.UseVisualStyleBackColor = false;
			// 
			// _SSTab1_TabPage0
			// 
			this._SSTab1_TabPage0.Controls.Add(this.Frame1);
			this._SSTab1_TabPage0.Location = new System.Drawing.Point(4, 22);
			this._SSTab1_TabPage0.Name = "_SSTab1_TabPage0";
			this._SSTab1_TabPage0.Size = new System.Drawing.Size(1213, 550);
			this._SSTab1_TabPage0.TabIndex = 0;
			this._SSTab1_TabPage0.Text = "Generales";
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.txtRazonSocial);
			this.Frame1.Controls.Add(this.cmbLocalidad);
			this.Frame1.Controls.Add(this.cmbProvincia);
			this.Frame1.Controls.Add(this.txtDireccion);
			this.Frame1.Controls.Add(this.txtDesc);
			this.Frame1.Controls.Add(this.txtCUIT);
			this.Frame1.Controls.Add(this.txtCodPos);
			this.Frame1.Controls.Add(this.txtTelefono2);
			this.Frame1.Controls.Add(this.txtTelefono1);
			this.Frame1.Controls.Add(this.txtEMail);
			this.Frame1.Controls.Add(this.txtFax);
			this.Frame1.Controls.Add(this.txtNumClie);
			this.Frame1.Controls.Add(this._Label1_18);
			this.Frame1.Controls.Add(this._Label1_8);
			this.Frame1.Controls.Add(this._Label1_7);
			this.Frame1.Controls.Add(this._Label1_6);
			this.Frame1.Controls.Add(this._Label1_5);
			this.Frame1.Controls.Add(this._Label1_4);
			this.Frame1.Controls.Add(this._Label1_3);
			this.Frame1.Controls.Add(this._Label1_2);
			this.Frame1.Controls.Add(this._Label1_1);
			this.Frame1.Controls.Add(this._Label1_13);
			this.Frame1.Controls.Add(this._Label1_17);
			this.Frame1.Controls.Add(this._Label1_11);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(8, 24);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(489, 321);
			this.Frame1.TabIndex = 10;
			this.Frame1.TabStop = false;
			// 
			// txtRazonSocial
			// 
			this.txtRazonSocial.AcceptsReturn = true;
			this.txtRazonSocial.BackColor = System.Drawing.SystemColors.Window;
			this.txtRazonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRazonSocial.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtRazonSocial.Location = new System.Drawing.Point(112, 56);
			this.txtRazonSocial.MaxLength = 0;
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtRazonSocial.Size = new System.Drawing.Size(345, 20);
			this.txtRazonSocial.TabIndex = 46;
			// 
			// cmbLocalidad
			// 
			this.cmbLocalidad.BackColor = System.Drawing.SystemColors.Window;
			this.cmbLocalidad.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbLocalidad.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbLocalidad.Location = new System.Drawing.Point(112, 104);
			this.cmbLocalidad.Name = "cmbLocalidad";
			this.cmbLocalidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbLocalidad.Size = new System.Drawing.Size(345, 21);
			this.cmbLocalidad.TabIndex = 21;
			// 
			// cmbProvincia
			// 
			this.cmbProvincia.BackColor = System.Drawing.SystemColors.Window;
			this.cmbProvincia.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbProvincia.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbProvincia.Location = new System.Drawing.Point(112, 80);
			this.cmbProvincia.Name = "cmbProvincia";
			this.cmbProvincia.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbProvincia.Size = new System.Drawing.Size(345, 21);
			this.cmbProvincia.TabIndex = 20;
			// 
			// txtDireccion
			// 
			this.txtDireccion.AcceptsReturn = true;
			this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
			this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDireccion.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtDireccion.Location = new System.Drawing.Point(112, 128);
			this.txtDireccion.MaxLength = 0;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtDireccion.Size = new System.Drawing.Size(345, 20);
			this.txtDireccion.TabIndex = 19;
			// 
			// txtDesc
			// 
			this.txtDesc.AcceptsReturn = true;
			this.txtDesc.BackColor = System.Drawing.SystemColors.Window;
			this.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDesc.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtDesc.Location = new System.Drawing.Point(112, 272);
			this.txtDesc.MaxLength = 0;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtDesc.Size = new System.Drawing.Size(345, 20);
			this.txtDesc.TabIndex = 18;
			this.txtDesc.Text = "0";
			this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtCUIT
			// 
			this.txtCUIT.AcceptsReturn = true;
			this.txtCUIT.BackColor = System.Drawing.SystemColors.Window;
			this.txtCUIT.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCUIT.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCUIT.Location = new System.Drawing.Point(112, 248);
			this.txtCUIT.MaxLength = 0;
			this.txtCUIT.Name = "txtCUIT";
			this.txtCUIT.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCUIT.Size = new System.Drawing.Size(345, 20);
			this.txtCUIT.TabIndex = 17;
			// 
			// txtCodPos
			// 
			this.txtCodPos.AcceptsReturn = true;
			this.txtCodPos.BackColor = System.Drawing.SystemColors.Window;
			this.txtCodPos.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCodPos.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCodPos.Location = new System.Drawing.Point(112, 152);
			this.txtCodPos.MaxLength = 0;
			this.txtCodPos.Name = "txtCodPos";
			this.txtCodPos.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCodPos.Size = new System.Drawing.Size(345, 20);
			this.txtCodPos.TabIndex = 16;
			this.txtCodPos.Text = "0";
			this.txtCodPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTelefono2
			// 
			this.txtTelefono2.AcceptsReturn = true;
			this.txtTelefono2.BackColor = System.Drawing.SystemColors.Window;
			this.txtTelefono2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTelefono2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTelefono2.Location = new System.Drawing.Point(112, 200);
			this.txtTelefono2.MaxLength = 0;
			this.txtTelefono2.Name = "txtTelefono2";
			this.txtTelefono2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTelefono2.Size = new System.Drawing.Size(345, 20);
			this.txtTelefono2.TabIndex = 15;
			// 
			// txtTelefono1
			// 
			this.txtTelefono1.AcceptsReturn = true;
			this.txtTelefono1.BackColor = System.Drawing.SystemColors.Window;
			this.txtTelefono1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTelefono1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTelefono1.Location = new System.Drawing.Point(112, 176);
			this.txtTelefono1.MaxLength = 0;
			this.txtTelefono1.Name = "txtTelefono1";
			this.txtTelefono1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTelefono1.Size = new System.Drawing.Size(345, 20);
			this.txtTelefono1.TabIndex = 14;
			// 
			// txtEMail
			// 
			this.txtEMail.AcceptsReturn = true;
			this.txtEMail.BackColor = System.Drawing.SystemColors.Window;
			this.txtEMail.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEMail.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtEMail.Location = new System.Drawing.Point(112, 296);
			this.txtEMail.MaxLength = 0;
			this.txtEMail.Name = "txtEMail";
			this.txtEMail.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtEMail.Size = new System.Drawing.Size(345, 20);
			this.txtEMail.TabIndex = 13;
			this.txtEMail.Text = " ";
			// 
			// txtFax
			// 
			this.txtFax.AcceptsReturn = true;
			this.txtFax.BackColor = System.Drawing.SystemColors.Window;
			this.txtFax.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtFax.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtFax.Location = new System.Drawing.Point(112, 224);
			this.txtFax.MaxLength = 0;
			this.txtFax.Name = "txtFax";
			this.txtFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtFax.Size = new System.Drawing.Size(345, 20);
			this.txtFax.TabIndex = 12;
			// 
			// txtNumClie
			// 
			this.txtNumClie.AcceptsReturn = true;
			this.txtNumClie.BackColor = System.Drawing.SystemColors.Window;
			this.txtNumClie.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNumClie.Enabled = false;
			this.txtNumClie.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNumClie.Location = new System.Drawing.Point(112, 24);
			this.txtNumClie.MaxLength = 0;
			this.txtNumClie.Name = "txtNumClie";
			this.txtNumClie.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtNumClie.Size = new System.Drawing.Size(193, 20);
			this.txtNumClie.TabIndex = 11;
			// 
			// _Label1_18
			// 
			this._Label1_18.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_18.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_18.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_18.Location = new System.Drawing.Point(8, 56);
			this._Label1_18.Name = "_Label1_18";
			this._Label1_18.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_18.Size = new System.Drawing.Size(97, 17);
			this._Label1_18.TabIndex = 45;
			this._Label1_18.Text = "Razon Social";
			this._Label1_18.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_8
			// 
			this._Label1_8.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_8.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_8.Location = new System.Drawing.Point(8, 272);
			this._Label1_8.Name = "_Label1_8";
			this._Label1_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_8.Size = new System.Drawing.Size(97, 17);
			this._Label1_8.TabIndex = 32;
			this._Label1_8.Text = "Descuneto";
			this._Label1_8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_7
			// 
			this._Label1_7.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_7.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_7.Location = new System.Drawing.Point(8, 248);
			this._Label1_7.Name = "_Label1_7";
			this._Label1_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_7.Size = new System.Drawing.Size(97, 17);
			this._Label1_7.TabIndex = 31;
			this._Label1_7.Text = "CUIT";
			this._Label1_7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_6
			// 
			this._Label1_6.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_6.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_6.Location = new System.Drawing.Point(8, 80);
			this._Label1_6.Name = "_Label1_6";
			this._Label1_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_6.Size = new System.Drawing.Size(97, 17);
			this._Label1_6.TabIndex = 30;
			this._Label1_6.Text = "Provincia";
			this._Label1_6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_5
			// 
			this._Label1_5.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_5.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_5.Location = new System.Drawing.Point(8, 152);
			this._Label1_5.Name = "_Label1_5";
			this._Label1_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_5.Size = new System.Drawing.Size(97, 17);
			this._Label1_5.TabIndex = 29;
			this._Label1_5.Text = "CodPos";
			this._Label1_5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_4
			// 
			this._Label1_4.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_4.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_4.Location = new System.Drawing.Point(8, 200);
			this._Label1_4.Name = "_Label1_4";
			this._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_4.Size = new System.Drawing.Size(97, 17);
			this._Label1_4.TabIndex = 28;
			this._Label1_4.Text = "Telefono2";
			this._Label1_4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_3
			// 
			this._Label1_3.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_3.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_3.Location = new System.Drawing.Point(8, 176);
			this._Label1_3.Name = "_Label1_3";
			this._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_3.Size = new System.Drawing.Size(97, 17);
			this._Label1_3.TabIndex = 27;
			this._Label1_3.Text = "Telefono1";
			this._Label1_3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_2
			// 
			this._Label1_2.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_2.Location = new System.Drawing.Point(8, 104);
			this._Label1_2.Name = "_Label1_2";
			this._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_2.Size = new System.Drawing.Size(97, 17);
			this._Label1_2.TabIndex = 26;
			this._Label1_2.Text = "Localidad";
			this._Label1_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_1
			// 
			this._Label1_1.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_1.Location = new System.Drawing.Point(8, 128);
			this._Label1_1.Name = "_Label1_1";
			this._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_1.Size = new System.Drawing.Size(97, 17);
			this._Label1_1.TabIndex = 25;
			this._Label1_1.Text = "Direccion";
			this._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_13
			// 
			this._Label1_13.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_13.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_13.Location = new System.Drawing.Point(8, 296);
			this._Label1_13.Name = "_Label1_13";
			this._Label1_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_13.Size = new System.Drawing.Size(97, 17);
			this._Label1_13.TabIndex = 24;
			this._Label1_13.Text = "E-Mail";
			this._Label1_13.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_17
			// 
			this._Label1_17.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_17.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_17.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_17.Location = new System.Drawing.Point(8, 224);
			this._Label1_17.Name = "_Label1_17";
			this._Label1_17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_17.Size = new System.Drawing.Size(97, 17);
			this._Label1_17.TabIndex = 23;
			this._Label1_17.Text = "Fax";
			this._Label1_17.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_11
			// 
			this._Label1_11.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_11.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_11.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_11.Location = new System.Drawing.Point(8, 24);
			this._Label1_11.Name = "_Label1_11";
			this._Label1_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_11.Size = new System.Drawing.Size(97, 17);
			this._Label1_11.TabIndex = 22;
			this._Label1_11.Text = "Numero de Cliete";
			this._Label1_11.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _SSTab1_TabPage1
			// 
			this._SSTab1_TabPage1.Controls.Add(this.dataContactos);
			this._SSTab1_TabPage1.Location = new System.Drawing.Point(4, 22);
			this._SSTab1_TabPage1.Name = "_SSTab1_TabPage1";
			this._SSTab1_TabPage1.Size = new System.Drawing.Size(1213, 550);
			this._SSTab1_TabPage1.TabIndex = 1;
			this._SSTab1_TabPage1.Text = "Contactos";
			// 
			// dataContactos
			// 
			this.dataContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colContactoNombre,
			this.colContactoDireccion});
			this.dataContactos.Location = new System.Drawing.Point(8, 13);
			this.dataContactos.Name = "dataContactos";
			this.dataContactos.Size = new System.Drawing.Size(947, 298);
			this.dataContactos.TabIndex = 49;
			// 
			// colContactoNombre
			// 
			this.colContactoNombre.HeaderText = "Nombre";
			this.colContactoNombre.Name = "colContactoNombre";
			// 
			// colContactoDireccion
			// 
			this.colContactoDireccion.HeaderText = "Direccion";
			this.colContactoDireccion.Name = "colContactoDireccion";
			// 
			// _SSTab1_TabPage2
			// 
			this._SSTab1_TabPage2.Controls.Add(this.Frame3);
			this._SSTab1_TabPage2.Location = new System.Drawing.Point(4, 22);
			this._SSTab1_TabPage2.Name = "_SSTab1_TabPage2";
			this._SSTab1_TabPage2.Size = new System.Drawing.Size(1213, 550);
			this._SSTab1_TabPage2.TabIndex = 2;
			this._SSTab1_TabPage2.Text = "Transporte";
			// 
			// Frame3
			// 
			this.Frame3.BackColor = System.Drawing.SystemColors.Control;
			this.Frame3.Controls.Add(this.txtTranspNum);
			this.Frame3.Controls.Add(this.txtTranspDireccion);
			this.Frame3.Controls.Add(this.cmbTranspNombre);
			this.Frame3.Controls.Add(this._Label1_12);
			this.Frame3.Controls.Add(this._Label1_9);
			this.Frame3.Controls.Add(this._Label1_10);
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.Location = new System.Drawing.Point(12, 13);
			this.Frame3.Name = "Frame3";
			this.Frame3.Padding = new System.Windows.Forms.Padding(0);
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Size = new System.Drawing.Size(313, 113);
			this.Frame3.TabIndex = 33;
			this.Frame3.TabStop = false;
			// 
			// txtTranspNum
			// 
			this.txtTranspNum.AcceptsReturn = true;
			this.txtTranspNum.BackColor = System.Drawing.SystemColors.Window;
			this.txtTranspNum.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTranspNum.Enabled = false;
			this.txtTranspNum.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTranspNum.Location = new System.Drawing.Point(112, 24);
			this.txtTranspNum.MaxLength = 0;
			this.txtTranspNum.Name = "txtTranspNum";
			this.txtTranspNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTranspNum.Size = new System.Drawing.Size(193, 20);
			this.txtTranspNum.TabIndex = 36;
			// 
			// txtTranspDireccion
			// 
			this.txtTranspDireccion.AcceptsReturn = true;
			this.txtTranspDireccion.BackColor = System.Drawing.SystemColors.Window;
			this.txtTranspDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTranspDireccion.Enabled = false;
			this.txtTranspDireccion.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTranspDireccion.Location = new System.Drawing.Point(112, 72);
			this.txtTranspDireccion.MaxLength = 0;
			this.txtTranspDireccion.Name = "txtTranspDireccion";
			this.txtTranspDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTranspDireccion.Size = new System.Drawing.Size(193, 20);
			this.txtTranspDireccion.TabIndex = 35;
			// 
			// cmbTranspNombre
			// 
			this.cmbTranspNombre.BackColor = System.Drawing.SystemColors.Window;
			this.cmbTranspNombre.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbTranspNombre.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbTranspNombre.Location = new System.Drawing.Point(112, 48);
			this.cmbTranspNombre.Name = "cmbTranspNombre";
			this.cmbTranspNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbTranspNombre.Size = new System.Drawing.Size(193, 21);
			this.cmbTranspNombre.TabIndex = 34;
			// 
			// _Label1_12
			// 
			this._Label1_12.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_12.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_12.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_12.Location = new System.Drawing.Point(8, 24);
			this._Label1_12.Name = "_Label1_12";
			this._Label1_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_12.Size = new System.Drawing.Size(97, 17);
			this._Label1_12.TabIndex = 39;
			this._Label1_12.Text = "NumeroTransporte";
			this._Label1_12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_9
			// 
			this._Label1_9.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_9.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_9.Location = new System.Drawing.Point(8, 72);
			this._Label1_9.Name = "_Label1_9";
			this._Label1_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_9.Size = new System.Drawing.Size(97, 17);
			this._Label1_9.TabIndex = 38;
			this._Label1_9.Text = "TranspDireccion";
			this._Label1_9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Label1_10
			// 
			this._Label1_10.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Label1_10.Cursor = System.Windows.Forms.Cursors.Default;
			this._Label1_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Label1_10.Location = new System.Drawing.Point(8, 48);
			this._Label1_10.Name = "_Label1_10";
			this._Label1_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_10.Size = new System.Drawing.Size(97, 17);
			this._Label1_10.TabIndex = 37;
			this._Label1_10.Text = "TranspNombre";
			this._Label1_10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _SSTab1_TabPage3
			// 
			this._SSTab1_TabPage3.Controls.Add(this.richNotas);
			this._SSTab1_TabPage3.Location = new System.Drawing.Point(4, 22);
			this._SSTab1_TabPage3.Name = "_SSTab1_TabPage3";
			this._SSTab1_TabPage3.Size = new System.Drawing.Size(1213, 550);
			this._SSTab1_TabPage3.TabIndex = 3;
			this._SSTab1_TabPage3.Text = "Notas";
			// 
			// richNotas
			// 
			this.richNotas.Location = new System.Drawing.Point(8, 10);
			this.richNotas.Name = "richNotas";
			this.richNotas.Size = new System.Drawing.Size(919, 337);
			this.richNotas.TabIndex = 1;
			this.richNotas.Text = "";
			// 
			// _SSTab1_TabPage4
			// 
			this._SSTab1_TabPage4.Location = new System.Drawing.Point(4, 22);
			this._SSTab1_TabPage4.Name = "_SSTab1_TabPage4";
			this._SSTab1_TabPage4.Size = new System.Drawing.Size(1213, 550);
			this._SSTab1_TabPage4.TabIndex = 4;
			this._SSTab1_TabPage4.Text = "Contables";
			// 
			// _SSTab1_TabPage5
			// 
			this._SSTab1_TabPage5.Controls.Add(this.textBox1);
			this._SSTab1_TabPage5.Controls.Add(this.label1);
			this._SSTab1_TabPage5.Controls.Add(this.Frame7);
			this._SSTab1_TabPage5.Controls.Add(this.Frame6);
			this._SSTab1_TabPage5.Controls.Add(this.Frame2);
			this._SSTab1_TabPage5.Controls.Add(this.Frame5);
			this._SSTab1_TabPage5.Location = new System.Drawing.Point(4, 22);
			this._SSTab1_TabPage5.Name = "_SSTab1_TabPage5";
			this._SSTab1_TabPage5.Size = new System.Drawing.Size(1213, 550);
			this._SSTab1_TabPage5.TabIndex = 5;
			this._SSTab1_TabPage5.Text = "Otros Datos";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(262, 180);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(123, 20);
			this.textBox1.TabIndex = 45;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(226, 183);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 19);
			this.label1.TabIndex = 44;
			this.label1.Text = "GLN";
			// 
			// Frame7
			// 
			this.Frame7.BackColor = System.Drawing.SystemColors.Control;
			this.Frame7.Controls.Add(this.OptAct);
			this.Frame7.Controls.Add(this.OptInact);
			this.Frame7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame7.Location = new System.Drawing.Point(16, 40);
			this.Frame7.Name = "Frame7";
			this.Frame7.Padding = new System.Windows.Forms.Padding(0);
			this.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame7.Size = new System.Drawing.Size(161, 121);
			this.Frame7.TabIndex = 5;
			this.Frame7.TabStop = false;
			this.Frame7.Text = "Activo";
			// 
			// OptAct
			// 
			this.OptAct.Appearance = System.Windows.Forms.Appearance.Button;
			this.OptAct.BackColor = System.Drawing.SystemColors.Control;
			this.OptAct.Checked = true;
			this.OptAct.Cursor = System.Windows.Forms.Cursors.Default;
			this.OptAct.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OptAct.Location = new System.Drawing.Point(24, 32);
			this.OptAct.Name = "OptAct";
			this.OptAct.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.OptAct.Size = new System.Drawing.Size(120, 27);
			this.OptAct.TabIndex = 7;
			this.OptAct.TabStop = true;
			this.OptAct.Text = "Activo";
			this.OptAct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.OptAct.UseVisualStyleBackColor = false;
			// 
			// OptInact
			// 
			this.OptInact.Appearance = System.Windows.Forms.Appearance.Button;
			this.OptInact.BackColor = System.Drawing.SystemColors.Control;
			this.OptInact.Cursor = System.Windows.Forms.Cursors.Default;
			this.OptInact.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OptInact.Location = new System.Drawing.Point(24, 80);
			this.OptInact.Name = "OptInact";
			this.OptInact.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.OptInact.Size = new System.Drawing.Size(120, 27);
			this.OptInact.TabIndex = 6;
			this.OptInact.TabStop = true;
			this.OptInact.Text = "Inactivo";
			this.OptInact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.OptInact.UseVisualStyleBackColor = false;
			// 
			// Frame6
			// 
			this.Frame6.BackColor = System.Drawing.SystemColors.Control;
			this.Frame6.Controls.Add(this.ProgressBar1);
			this.Frame6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame6.Location = new System.Drawing.Point(192, 48);
			this.Frame6.Name = "Frame6";
			this.Frame6.Padding = new System.Windows.Forms.Padding(0);
			this.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame6.Size = new System.Drawing.Size(193, 97);
			this.Frame6.TabIndex = 8;
			this.Frame6.TabStop = false;
			this.Frame6.Text = "Calidad del Cliente";
			// 
			// ProgressBar1
			// 
			this.ProgressBar1.Location = new System.Drawing.Point(56, 24);
			this.ProgressBar1.Maximum = 5;
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(89, 65);
			this.ProgressBar1.TabIndex = 9;
			// 
			// Frame2
			// 
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.OptNo);
			this.Frame2.Controls.Add(this.OptYes);
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(16, 168);
			this.Frame2.Name = "Frame2";
			this.Frame2.Padding = new System.Windows.Forms.Padding(0);
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(153, 97);
			this.Frame2.TabIndex = 40;
			this.Frame2.TabStop = false;
			this.Frame2.Text = "Mayorista";
			// 
			// OptNo
			// 
			this.OptNo.BackColor = System.Drawing.SystemColors.Control;
			this.OptNo.Cursor = System.Windows.Forms.Cursors.Default;
			this.OptNo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OptNo.Location = new System.Drawing.Point(16, 56);
			this.OptNo.Name = "OptNo";
			this.OptNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.OptNo.Size = new System.Drawing.Size(89, 17);
			this.OptNo.TabIndex = 42;
			this.OptNo.TabStop = true;
			this.OptNo.Text = "Minorista";
			this.OptNo.UseVisualStyleBackColor = false;
			// 
			// OptYes
			// 
			this.OptYes.BackColor = System.Drawing.SystemColors.Control;
			this.OptYes.Checked = true;
			this.OptYes.Cursor = System.Windows.Forms.Cursors.Default;
			this.OptYes.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OptYes.Location = new System.Drawing.Point(16, 32);
			this.OptYes.Name = "OptYes";
			this.OptYes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.OptYes.Size = new System.Drawing.Size(97, 17);
			this.OptYes.TabIndex = 41;
			this.OptYes.TabStop = true;
			this.OptYes.Text = "Mayorista";
			this.OptYes.UseVisualStyleBackColor = false;
			// 
			// Frame5
			// 
			this.Frame5.BackColor = System.Drawing.SystemColors.Control;
			this.Frame5.Controls.Add(this.cmbClienteDe);
			this.Frame5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame5.Location = new System.Drawing.Point(16, 272);
			this.Frame5.Name = "Frame5";
			this.Frame5.Padding = new System.Windows.Forms.Padding(0);
			this.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame5.Size = new System.Drawing.Size(329, 73);
			this.Frame5.TabIndex = 43;
			this.Frame5.TabStop = false;
			this.Frame5.Text = "Cliente De";
			// 
			// cmbClienteDe
			// 
			this.cmbClienteDe.BackColor = System.Drawing.SystemColors.Window;
			this.cmbClienteDe.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbClienteDe.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbClienteDe.Location = new System.Drawing.Point(16, 32);
			this.cmbClienteDe.Name = "cmbClienteDe";
			this.cmbClienteDe.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbClienteDe.Size = new System.Drawing.Size(289, 21);
			this.cmbClienteDe.TabIndex = 44;
			this.cmbClienteDe.Text = "ALFREDO FERRERO";
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
			this.tlbEditar});
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.Size = new System.Drawing.Size(1370, 42);
			this.Toolbar1.TabIndex = 47;
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
			this.tlbEditar.Click += new System.EventHandler(this.TlbEditarClick);
			// 
			// frmClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.SSTab1);
			this.Controls.Add(this.Toolbar1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 23);
			this.Name = "frmClientes";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Alta de Clientes";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmClientesLoad);
			this.SSTab1.ResumeLayout(false);
			this.tabBusqueda.ResumeLayout(false);
			this.tabBusqueda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
			this.Frame8.ResumeLayout(false);
			this._SSTab1_TabPage0.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			this._SSTab1_TabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataContactos)).EndInit();
			this._SSTab1_TabPage2.ResumeLayout(false);
			this.Frame3.ResumeLayout(false);
			this.Frame3.PerformLayout();
			this._SSTab1_TabPage3.ResumeLayout(false);
			this._SSTab1_TabPage5.ResumeLayout(false);
			this._SSTab1_TabPage5.PerformLayout();
			this.Frame7.ResumeLayout(false);
			this.Frame6.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.Frame5.ResumeLayout(false);
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.DataGridView gridData;
		public System.Windows.Forms.TextBox txtCriterio;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabBusqueda;
		private System.Windows.Forms.DataGridView dataContactos;
		private System.Windows.Forms.DataGridViewTextBoxColumn colContactoNombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn colContactoDireccion;
			#endregion
	}
}
