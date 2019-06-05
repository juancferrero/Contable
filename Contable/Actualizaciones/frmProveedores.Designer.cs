
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{

	partial class frmProveedores
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmProveedores() : base()
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
				if ((components != null)) {
					components.Dispose();
				}
			}
			base.Dispose(Disposing);
		}
//Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.Button cmdPasarAPagos;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label10;
		public System.Windows.Forms.Label Label14;
		public System.Windows.Forms.Label Label15;
		public System.Windows.Forms.TextBox txtID;
		public System.Windows.Forms.TextBox txtCUIT;
		public System.Windows.Forms.TextBox txtRazonSocial;
		public System.Windows.Forms.TextBox txtDireccion;
		public System.Windows.Forms.ComboBox cmbLocalidad;
		public System.Windows.Forms.ComboBox cmbProvincia;
		public System.Windows.Forms.TabPage _SSTab1_TabPage0;
		public System.Windows.Forms.ComboBox cmbItem;
		public System.Windows.Forms.ComboBox cmbSubCuenta;
		public System.Windows.Forms.ComboBox cmbCuenta;
		public System.Windows.Forms.ComboBox cmbConcepto;
		public System.Windows.Forms.Label Label18;
		public System.Windows.Forms.Label Label17;
		public System.Windows.Forms.Label Label16;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.TabPage _SSTab1_TabPage1;
		public System.Windows.Forms.TabPage _SSTab1_TabPage2;
		public System.Windows.Forms.TabControl SSTab1;
		public System.Windows.Forms.Button Command2;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button1;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button2;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button3;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button4;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button5;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button6;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button7;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button8;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button9;
		public System.Windows.Forms.ToolStrip Toolbar1;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.cmdPasarAPagos = new System.Windows.Forms.Button();
			this.SSTab1 = new System.Windows.Forms.TabControl();
			this._SSTab1_TabPage0 = new System.Windows.Forms.TabPage();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtCUIT = new System.Windows.Forms.TextBox();
			this.txtRazonSocial = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.cmbLocalidad = new System.Windows.Forms.ComboBox();
			this.cmbProvincia = new System.Windows.Forms.ComboBox();
			this._SSTab1_TabPage1 = new System.Windows.Forms.TabPage();
			this.cmbItem = new System.Windows.Forms.ComboBox();
			this.cmbSubCuenta = new System.Windows.Forms.ComboBox();
			this.cmbCuenta = new System.Windows.Forms.ComboBox();
			this.cmbConcepto = new System.Windows.Forms.ComboBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this._SSTab1_TabPage2 = new System.Windows.Forms.TabPage();
			this.DataGridView2 = new System.Windows.Forms.DataGridView();
			this.Command2 = new System.Windows.Forms.Button();
			this.Command1 = new System.Windows.Forms.Button();
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this._Toolbar1_Button1 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button2 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button3 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button4 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button5 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button6 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button7 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button8 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button9 = new System.Windows.Forms.ToolStripButton();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.SSTab1.SuspendLayout();
			this._SSTab1_TabPage0.SuspendLayout();
			this._SSTab1_TabPage1.SuspendLayout();
			this._SSTab1_TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
			this.Toolbar1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdPasarAPagos
			// 
			this.cmdPasarAPagos.BackColor = System.Drawing.SystemColors.Control;
			this.cmdPasarAPagos.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdPasarAPagos.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdPasarAPagos.Location = new System.Drawing.Point(864, 216);
			this.cmdPasarAPagos.Name = "cmdPasarAPagos";
			this.cmdPasarAPagos.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdPasarAPagos.Size = new System.Drawing.Size(145, 41);
			this.cmdPasarAPagos.TabIndex = 25;
			this.cmdPasarAPagos.Text = "Pasar Factura";
			this.cmdPasarAPagos.UseVisualStyleBackColor = false;
			// 
			// SSTab1
			// 
			this.SSTab1.Controls.Add(this._SSTab1_TabPage0);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage1);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage2);
			this.SSTab1.ItemSize = new System.Drawing.Size(42, 18);
			this.SSTab1.Location = new System.Drawing.Point(12, 62);
			this.SSTab1.Name = "SSTab1";
			this.SSTab1.SelectedIndex = 0;
			this.SSTab1.Size = new System.Drawing.Size(465, 281);
			this.SSTab1.TabIndex = 4;
			// 
			// _SSTab1_TabPage0
			// 
			this._SSTab1_TabPage0.Controls.Add(this.Label2);
			this._SSTab1_TabPage0.Controls.Add(this.Label4);
			this._SSTab1_TabPage0.Controls.Add(this.Label5);
			this._SSTab1_TabPage0.Controls.Add(this.Label10);
			this._SSTab1_TabPage0.Controls.Add(this.Label14);
			this._SSTab1_TabPage0.Controls.Add(this.Label15);
			this._SSTab1_TabPage0.Controls.Add(this.txtID);
			this._SSTab1_TabPage0.Controls.Add(this.txtCUIT);
			this._SSTab1_TabPage0.Controls.Add(this.txtRazonSocial);
			this._SSTab1_TabPage0.Controls.Add(this.txtDireccion);
			this._SSTab1_TabPage0.Controls.Add(this.cmbLocalidad);
			this._SSTab1_TabPage0.Controls.Add(this.cmbProvincia);
			this._SSTab1_TabPage0.Location = new System.Drawing.Point(4, 22);
			this._SSTab1_TabPage0.Name = "_SSTab1_TabPage0";
			this._SSTab1_TabPage0.Size = new System.Drawing.Size(457, 255);
			this._SSTab1_TabPage0.TabIndex = 0;
			this._SSTab1_TabPage0.Text = "General";
			// 
			// Label2
			// 
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(8, 40);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(81, 21);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "ID";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label4
			// 
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(8, 88);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(81, 21);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "CUIT";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label5
			// 
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(8, 64);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(81, 21);
			this.Label5.TabIndex = 10;
			this.Label5.Text = "Razon Social";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label10
			// 
			this.Label10.BackColor = System.Drawing.SystemColors.Control;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label10.Location = new System.Drawing.Point(8, 112);
			this.Label10.Name = "Label10";
			this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label10.Size = new System.Drawing.Size(81, 21);
			this.Label10.TabIndex = 12;
			this.Label10.Text = "Direccion";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label14
			// 
			this.Label14.BackColor = System.Drawing.SystemColors.Control;
			this.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label14.Location = new System.Drawing.Point(8, 136);
			this.Label14.Name = "Label14";
			this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label14.Size = new System.Drawing.Size(81, 21);
			this.Label14.TabIndex = 13;
			this.Label14.Text = "Localidad";
			this.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label15
			// 
			this.Label15.BackColor = System.Drawing.SystemColors.Control;
			this.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label15.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label15.Location = new System.Drawing.Point(8, 160);
			this.Label15.Name = "Label15";
			this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label15.Size = new System.Drawing.Size(81, 21);
			this.Label15.TabIndex = 14;
			this.Label15.Text = "Provincia";
			this.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtID
			// 
			this.txtID.AcceptsReturn = true;
			this.txtID.BackColor = System.Drawing.SystemColors.Window;
			this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtID.Enabled = false;
			this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtID.Location = new System.Drawing.Point(88, 40);
			this.txtID.MaxLength = 11;
			this.txtID.Name = "txtID";
			this.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtID.Size = new System.Drawing.Size(241, 20);
			this.txtID.TabIndex = 5;
			// 
			// txtCUIT
			// 
			this.txtCUIT.AcceptsReturn = true;
			this.txtCUIT.BackColor = System.Drawing.SystemColors.Window;
			this.txtCUIT.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCUIT.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCUIT.Location = new System.Drawing.Point(88, 88);
			this.txtCUIT.MaxLength = 11;
			this.txtCUIT.Name = "txtCUIT";
			this.txtCUIT.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCUIT.Size = new System.Drawing.Size(241, 20);
			this.txtCUIT.TabIndex = 6;
			// 
			// txtRazonSocial
			// 
			this.txtRazonSocial.AcceptsReturn = true;
			this.txtRazonSocial.BackColor = System.Drawing.SystemColors.Window;
			this.txtRazonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRazonSocial.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtRazonSocial.Location = new System.Drawing.Point(88, 64);
			this.txtRazonSocial.MaxLength = 255;
			this.txtRazonSocial.Name = "txtRazonSocial";
			this.txtRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtRazonSocial.Size = new System.Drawing.Size(241, 20);
			this.txtRazonSocial.TabIndex = 9;
			// 
			// txtDireccion
			// 
			this.txtDireccion.AcceptsReturn = true;
			this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
			this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtDireccion.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtDireccion.Location = new System.Drawing.Point(88, 112);
			this.txtDireccion.MaxLength = 0;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtDireccion.Size = new System.Drawing.Size(241, 20);
			this.txtDireccion.TabIndex = 11;
			// 
			// cmbLocalidad
			// 
			this.cmbLocalidad.BackColor = System.Drawing.SystemColors.Window;
			this.cmbLocalidad.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbLocalidad.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbLocalidad.Location = new System.Drawing.Point(88, 136);
			this.cmbLocalidad.Name = "cmbLocalidad";
			this.cmbLocalidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbLocalidad.Size = new System.Drawing.Size(241, 21);
			this.cmbLocalidad.TabIndex = 23;
			// 
			// cmbProvincia
			// 
			this.cmbProvincia.BackColor = System.Drawing.SystemColors.Window;
			this.cmbProvincia.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbProvincia.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbProvincia.Location = new System.Drawing.Point(88, 160);
			this.cmbProvincia.Name = "cmbProvincia";
			this.cmbProvincia.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbProvincia.Size = new System.Drawing.Size(241, 21);
			this.cmbProvincia.TabIndex = 24;
			// 
			// _SSTab1_TabPage1
			// 
			this._SSTab1_TabPage1.Controls.Add(this.cmbItem);
			this._SSTab1_TabPage1.Controls.Add(this.cmbSubCuenta);
			this._SSTab1_TabPage1.Controls.Add(this.cmbCuenta);
			this._SSTab1_TabPage1.Controls.Add(this.cmbConcepto);
			this._SSTab1_TabPage1.Controls.Add(this.Label18);
			this._SSTab1_TabPage1.Controls.Add(this.Label17);
			this._SSTab1_TabPage1.Controls.Add(this.Label16);
			this._SSTab1_TabPage1.Controls.Add(this.Label1);
			this._SSTab1_TabPage1.Location = new System.Drawing.Point(4, 22);
			this._SSTab1_TabPage1.Name = "_SSTab1_TabPage1";
			this._SSTab1_TabPage1.Size = new System.Drawing.Size(457, 255);
			this._SSTab1_TabPage1.TabIndex = 1;
			this._SSTab1_TabPage1.Text = "Contable";
			// 
			// cmbItem
			// 
			this.cmbItem.BackColor = System.Drawing.SystemColors.Window;
			this.cmbItem.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbItem.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbItem.Location = new System.Drawing.Point(104, 112);
			this.cmbItem.Name = "cmbItem";
			this.cmbItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbItem.Size = new System.Drawing.Size(252, 21);
			this.cmbItem.TabIndex = 18;
			this.cmbItem.Text = " ";
			// 
			// cmbSubCuenta
			// 
			this.cmbSubCuenta.BackColor = System.Drawing.SystemColors.Window;
			this.cmbSubCuenta.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbSubCuenta.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbSubCuenta.Location = new System.Drawing.Point(104, 88);
			this.cmbSubCuenta.Name = "cmbSubCuenta";
			this.cmbSubCuenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbSubCuenta.Size = new System.Drawing.Size(252, 21);
			this.cmbSubCuenta.TabIndex = 17;
			this.cmbSubCuenta.Text = " ";
			// 
			// cmbCuenta
			// 
			this.cmbCuenta.BackColor = System.Drawing.SystemColors.Window;
			this.cmbCuenta.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbCuenta.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbCuenta.Location = new System.Drawing.Point(104, 64);
			this.cmbCuenta.Name = "cmbCuenta";
			this.cmbCuenta.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbCuenta.Size = new System.Drawing.Size(252, 21);
			this.cmbCuenta.TabIndex = 16;
			this.cmbCuenta.Text = " ";
			// 
			// cmbConcepto
			// 
			this.cmbConcepto.BackColor = System.Drawing.SystemColors.Window;
			this.cmbConcepto.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbConcepto.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbConcepto.Location = new System.Drawing.Point(104, 40);
			this.cmbConcepto.Name = "cmbConcepto";
			this.cmbConcepto.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbConcepto.Size = new System.Drawing.Size(252, 21);
			this.cmbConcepto.TabIndex = 15;
			this.cmbConcepto.Text = " ";
			// 
			// Label18
			// 
			this.Label18.BackColor = System.Drawing.SystemColors.Control;
			this.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label18.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label18.Location = new System.Drawing.Point(8, 112);
			this.Label18.Name = "Label18";
			this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label18.Size = new System.Drawing.Size(81, 21);
			this.Label18.TabIndex = 22;
			this.Label18.Text = "Items";
			this.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label17
			// 
			this.Label17.BackColor = System.Drawing.SystemColors.Control;
			this.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label17.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label17.Location = new System.Drawing.Point(8, 88);
			this.Label17.Name = "Label17";
			this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label17.Size = new System.Drawing.Size(81, 21);
			this.Label17.TabIndex = 21;
			this.Label17.Text = "Sub Cuenta";
			this.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label16
			// 
			this.Label16.BackColor = System.Drawing.SystemColors.Control;
			this.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label16.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label16.Location = new System.Drawing.Point(8, 64);
			this.Label16.Name = "Label16";
			this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label16.Size = new System.Drawing.Size(81, 21);
			this.Label16.TabIndex = 20;
			this.Label16.Text = "Cuenta";
			this.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(8, 40);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(81, 21);
			this.Label1.TabIndex = 19;
			this.Label1.Text = "Concepto";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _SSTab1_TabPage2
			// 
			this._SSTab1_TabPage2.Controls.Add(this.DataGridView2);
			this._SSTab1_TabPage2.Location = new System.Drawing.Point(4, 22);
			this._SSTab1_TabPage2.Name = "_SSTab1_TabPage2";
			this._SSTab1_TabPage2.Size = new System.Drawing.Size(457, 255);
			this._SSTab1_TabPage2.TabIndex = 2;
			this._SSTab1_TabPage2.Text = "Facturas";
			// 
			// DataGridView2
			// 
			this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView2.Location = new System.Drawing.Point(3, 3);
			this.DataGridView2.Name = "DataGridView2";
			this.DataGridView2.Size = new System.Drawing.Size(240, 150);
			this.DataGridView2.TabIndex = 23;
			// 
			// Command2
			// 
			this.Command2.BackColor = System.Drawing.SystemColors.Control;
			this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command2.Location = new System.Drawing.Point(872, 120);
			this.Command2.Name = "Command2";
			this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command2.Size = new System.Drawing.Size(121, 41);
			this.Command2.TabIndex = 3;
			this.Command2.Text = "Eliminar Duplicados";
			this.Command2.UseVisualStyleBackColor = false;
			// 
			// Command1
			// 
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(872, 72);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(121, 41);
			this.Command1.TabIndex = 1;
			this.Command1.Text = "Corregir la base de datos";
			this.Command1.UseVisualStyleBackColor = false;
			// 
			// Toolbar1
			// 
			this.Toolbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this._Toolbar1_Button1,
									this._Toolbar1_Button2,
									this._Toolbar1_Button3,
									this._Toolbar1_Button4,
									this._Toolbar1_Button5,
									this._Toolbar1_Button6,
									this._Toolbar1_Button7,
									this._Toolbar1_Button8,
									this._Toolbar1_Button9});
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.Size = new System.Drawing.Size(1016, 42);
			this.Toolbar1.TabIndex = 0;
			// 
			// _Toolbar1_Button1
			// 
			this._Toolbar1_Button1.AutoSize = false;
			this._Toolbar1_Button1.ImageIndex = -1;
			this._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button1.Name = "_Toolbar1_Button1";
			this._Toolbar1_Button1.Size = new System.Drawing.Size(40, 39);
			this._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button1.ToolTipText = "Nuevo";
			// 
			// _Toolbar1_Button2
			// 
			this._Toolbar1_Button2.AutoSize = false;
			this._Toolbar1_Button2.Name = "_Toolbar1_Button2";
			this._Toolbar1_Button2.Size = new System.Drawing.Size(40, 39);
			// 
			// _Toolbar1_Button3
			// 
			this._Toolbar1_Button3.AutoSize = false;
			this._Toolbar1_Button3.Enabled = false;
			this._Toolbar1_Button3.ImageIndex = -1;
			this._Toolbar1_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button3.Name = "_Toolbar1_Button3";
			this._Toolbar1_Button3.Size = new System.Drawing.Size(40, 39);
			this._Toolbar1_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button3.ToolTipText = "Guardar";
			// 
			// _Toolbar1_Button4
			// 
			this._Toolbar1_Button4.AutoSize = false;
			this._Toolbar1_Button4.Name = "_Toolbar1_Button4";
			this._Toolbar1_Button4.Size = new System.Drawing.Size(0, 39);
			// 
			// _Toolbar1_Button5
			// 
			this._Toolbar1_Button5.AutoSize = false;
			this._Toolbar1_Button5.Enabled = false;
			this._Toolbar1_Button5.ImageIndex = -1;
			this._Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button5.Name = "_Toolbar1_Button5";
			this._Toolbar1_Button5.Size = new System.Drawing.Size(40, 39);
			this._Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button5.ToolTipText = "Imprimir";
			// 
			// _Toolbar1_Button6
			// 
			this._Toolbar1_Button6.AutoSize = false;
			this._Toolbar1_Button6.Name = "_Toolbar1_Button6";
			this._Toolbar1_Button6.Size = new System.Drawing.Size(40, 39);
			// 
			// _Toolbar1_Button7
			// 
			this._Toolbar1_Button7.AutoSize = false;
			this._Toolbar1_Button7.Enabled = false;
			this._Toolbar1_Button7.ImageIndex = -1;
			this._Toolbar1_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button7.Name = "_Toolbar1_Button7";
			this._Toolbar1_Button7.Size = new System.Drawing.Size(40, 39);
			this._Toolbar1_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button7.ToolTipText = "Anular";
			// 
			// _Toolbar1_Button8
			// 
			this._Toolbar1_Button8.AutoSize = false;
			this._Toolbar1_Button8.Name = "_Toolbar1_Button8";
			this._Toolbar1_Button8.Size = new System.Drawing.Size(40, 39);
			// 
			// _Toolbar1_Button9
			// 
			this._Toolbar1_Button9.AutoSize = false;
			this._Toolbar1_Button9.ImageIndex = -1;
			this._Toolbar1_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button9.Name = "_Toolbar1_Button9";
			this._Toolbar1_Button9.Size = new System.Drawing.Size(40, 39);
			this._Toolbar1_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button9.ToolTipText = "Editar";
			// 
			// DataGridView1
			// 
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(12, 349);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new System.Drawing.Size(240, 150);
			this.DataGridView1.TabIndex = 26;
			// 
			// frmProveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1016, 734);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.cmdPasarAPagos);
			this.Controls.Add(this.SSTab1);
			this.Controls.Add(this.Command2);
			this.Controls.Add(this.Command1);
			this.Controls.Add(this.Toolbar1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 30);
			this.Name = "frmProveedores";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Proveedores";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.SSTab1.ResumeLayout(false);
			this._SSTab1_TabPage0.ResumeLayout(false);
			this._SSTab1_TabPage0.PerformLayout();
			this._SSTab1_TabPage1.ResumeLayout(false);
			this._SSTab1_TabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		internal System.Windows.Forms.DataGridView DataGridView1;
			#endregion
		internal System.Windows.Forms.DataGridView DataGridView2;
	}
}
