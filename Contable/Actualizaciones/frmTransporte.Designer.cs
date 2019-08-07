
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	
	partial class frmTransporte
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmTransporte() : base()
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
		public System.Windows.Forms.RadioButton optDestino;
		public System.Windows.Forms.RadioButton optNombre;
		public System.Windows.Forms.GroupBox Frame3;
		public System.Windows.Forms.TextBox Text1;
		public System.Windows.Forms.TextBox txtTranspNum;
		public System.Windows.Forms.TextBox txtTranspNombre;
		public System.Windows.Forms.TextBox txtTranspDireccion;
		public System.Windows.Forms.TextBox txtTranspLocalidad;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.TabPage tabGeneral;
		public System.Windows.Forms.TextBox txtTranspTel1;
		public System.Windows.Forms.TextBox txtTranspTel2;
		public System.Windows.Forms.TextBox txtTranspTel3;
		public System.Windows.Forms.TextBox txtTranspTel4;
		public System.Windows.Forms.TextBox txtTranspTel5;
		public System.Windows.Forms.TextBox txtTranspHorario;
		public System.Windows.Forms.TextBox txtTranspFax;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label10;
		public System.Windows.Forms.Label Label11;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.TabPage tabContacto;
		public System.Windows.Forms.RichTextBox RichDestinos;
		public System.Windows.Forms.TabPage tabDestintos;
		public System.Windows.Forms.TabControl SSTab1;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button4;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button8;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.Label Label12;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransporte));
			this.txtTranspTel5 = new System.Windows.Forms.TextBox();
			this.txtTranspFax = new System.Windows.Forms.TextBox();
			this.SSTab1 = new System.Windows.Forms.TabControl();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.txtTranspNum = new System.Windows.Forms.TextBox();
			this.txtTranspNombre = new System.Windows.Forms.TextBox();
			this.txtTranspDireccion = new System.Windows.Forms.TextBox();
			this.txtTranspLocalidad = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.tabContacto = new System.Windows.Forms.TabPage();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.txtTranspTel1 = new System.Windows.Forms.TextBox();
			this.txtTranspTel2 = new System.Windows.Forms.TextBox();
			this.txtTranspTel3 = new System.Windows.Forms.TextBox();
			this.txtTranspTel4 = new System.Windows.Forms.TextBox();
			this.txtTranspHorario = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.tabDestintos = new System.Windows.Forms.TabPage();
			this.RichDestinos = new System.Windows.Forms.RichTextBox();
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
			this.tabBusqueda = new System.Windows.Forms.TabPage();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Frame3 = new System.Windows.Forms.GroupBox();
			this.optDestino = new System.Windows.Forms.RadioButton();
			this.optNombre = new System.Windows.Forms.RadioButton();
			this.Text1 = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.SSTab1.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.tabContacto.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.tabDestintos.SuspendLayout();
			this.Toolbar1.SuspendLayout();
			this.tabBusqueda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
			this.Frame3.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtTranspTel5
			// 
			this.txtTranspTel5.AcceptsReturn = true;
			this.txtTranspTel5.BackColor = System.Drawing.SystemColors.Window;
			this.txtTranspTel5.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTranspTel5.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTranspTel5.Location = new System.Drawing.Point(144, 160);
			this.txtTranspTel5.MaxLength = 0;
			this.txtTranspTel5.Name = "txtTranspTel5";
			this.txtTranspTel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTranspTel5.Size = new System.Drawing.Size(200, 20);
			this.txtTranspTel5.TabIndex = 13;
			// 
			// txtTranspFax
			// 
			this.txtTranspFax.AcceptsReturn = true;
			this.txtTranspFax.BackColor = System.Drawing.SystemColors.Window;
			this.txtTranspFax.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTranspFax.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTranspFax.Location = new System.Drawing.Point(144, 192);
			this.txtTranspFax.MaxLength = 0;
			this.txtTranspFax.Name = "txtTranspFax";
			this.txtTranspFax.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTranspFax.Size = new System.Drawing.Size(200, 20);
			this.txtTranspFax.TabIndex = 11;
			// 
			// SSTab1
			// 
			this.SSTab1.Controls.Add(this.tabBusqueda);
			this.SSTab1.Controls.Add(this.tabGeneral);
			this.SSTab1.Controls.Add(this.tabContacto);
			this.SSTab1.Controls.Add(this.tabDestintos);
			this.SSTab1.ItemSize = new System.Drawing.Size(42, 18);
			this.SSTab1.Location = new System.Drawing.Point(32, 72);
			this.SSTab1.Name = "SSTab1";
			this.SSTab1.SelectedIndex = 0;
			this.SSTab1.Size = new System.Drawing.Size(993, 519);
			this.SSTab1.TabIndex = 0;
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.Frame1);
			this.tabGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Size = new System.Drawing.Size(425, 319);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.txtTranspNum);
			this.Frame1.Controls.Add(this.txtTranspNombre);
			this.Frame1.Controls.Add(this.txtTranspDireccion);
			this.Frame1.Controls.Add(this.txtTranspLocalidad);
			this.Frame1.Controls.Add(this.Label1);
			this.Frame1.Controls.Add(this.Label2);
			this.Frame1.Controls.Add(this.Label3);
			this.Frame1.Controls.Add(this.Label4);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(16, 40);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(377, 193);
			this.Frame1.TabIndex = 1;
			this.Frame1.TabStop = false;
			// 
			// txtTranspNum
			// 
			this.txtTranspNum.AcceptsReturn = true;
			this.txtTranspNum.BackColor = System.Drawing.SystemColors.Window;
			this.txtTranspNum.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTranspNum.Enabled = false;
			this.txtTranspNum.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTranspNum.Location = new System.Drawing.Point(144, 24);
			this.txtTranspNum.MaxLength = 0;
			this.txtTranspNum.Name = "txtTranspNum";
			this.txtTranspNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTranspNum.Size = new System.Drawing.Size(200, 20);
			this.txtTranspNum.TabIndex = 5;
			// 
			// txtTranspNombre
			// 
			this.txtTranspNombre.AcceptsReturn = true;
			this.txtTranspNombre.BackColor = System.Drawing.SystemColors.Window;
			this.txtTranspNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTranspNombre.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTranspNombre.Location = new System.Drawing.Point(144, 56);
			this.txtTranspNombre.MaxLength = 0;
			this.txtTranspNombre.Name = "txtTranspNombre";
			this.txtTranspNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTranspNombre.Size = new System.Drawing.Size(200, 20);
			this.txtTranspNombre.TabIndex = 4;
			// 
			// txtTranspDireccion
			// 
			this.txtTranspDireccion.AcceptsReturn = true;
			this.txtTranspDireccion.BackColor = System.Drawing.SystemColors.Window;
			this.txtTranspDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTranspDireccion.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTranspDireccion.Location = new System.Drawing.Point(144, 88);
			this.txtTranspDireccion.MaxLength = 0;
			this.txtTranspDireccion.Name = "txtTranspDireccion";
			this.txtTranspDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTranspDireccion.Size = new System.Drawing.Size(200, 20);
			this.txtTranspDireccion.TabIndex = 3;
			// 
			// txtTranspLocalidad
			// 
			this.txtTranspLocalidad.AcceptsReturn = true;
			this.txtTranspLocalidad.BackColor = System.Drawing.SystemColors.Window;
			this.txtTranspLocalidad.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTranspLocalidad.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTranspLocalidad.Location = new System.Drawing.Point(144, 120);
			this.txtTranspLocalidad.MaxLength = 0;
			this.txtTranspLocalidad.Name = "txtTranspLocalidad";
			this.txtTranspLocalidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTranspLocalidad.Size = new System.Drawing.Size(200, 20);
			this.txtTranspLocalidad.TabIndex = 2;
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(8, 24);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(133, 20);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "Numero";
			// 
			// Label2
			// 
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(8, 56);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(133, 20);
			this.Label2.TabIndex = 8;
			this.Label2.Text = "Nombre";
			// 
			// Label3
			// 
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(8, 88);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(133, 20);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "Dirección ";
			// 
			// Label4
			// 
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(8, 120);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(133, 20);
			this.Label4.TabIndex = 6;
			this.Label4.Text = "Localidad";
			// 
			// tabContacto
			// 
			this.tabContacto.Controls.Add(this.Frame2);
			this.tabContacto.Location = new System.Drawing.Point(4, 22);
			this.tabContacto.Name = "tabContacto";
			this.tabContacto.Size = new System.Drawing.Size(425, 319);
			this.tabContacto.TabIndex = 1;
			this.tabContacto.Text = "Contacto";
			// 
			// Frame2
			// 
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.txtTranspTel1);
			this.Frame2.Controls.Add(this.txtTranspTel2);
			this.Frame2.Controls.Add(this.txtTranspTel3);
			this.Frame2.Controls.Add(this.txtTranspTel4);
			this.Frame2.Controls.Add(this.txtTranspTel5);
			this.Frame2.Controls.Add(this.txtTranspHorario);
			this.Frame2.Controls.Add(this.txtTranspFax);
			this.Frame2.Controls.Add(this.Label5);
			this.Frame2.Controls.Add(this.Label6);
			this.Frame2.Controls.Add(this.Label7);
			this.Frame2.Controls.Add(this.Label8);
			this.Frame2.Controls.Add(this.Label9);
			this.Frame2.Controls.Add(this.Label10);
			this.Frame2.Controls.Add(this.Label11);
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(16, 40);
			this.Frame2.Name = "Frame2";
			this.Frame2.Padding = new System.Windows.Forms.Padding(0);
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(353, 273);
			this.Frame2.TabIndex = 10;
			this.Frame2.TabStop = false;
			// 
			// txtTranspTel1
			// 
			this.txtTranspTel1.AcceptsReturn = true;
			this.txtTranspTel1.BackColor = System.Drawing.SystemColors.Window;
			this.txtTranspTel1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTranspTel1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTranspTel1.Location = new System.Drawing.Point(144, 32);
			this.txtTranspTel1.MaxLength = 0;
			this.txtTranspTel1.Name = "txtTranspTel1";
			this.txtTranspTel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTranspTel1.Size = new System.Drawing.Size(200, 20);
			this.txtTranspTel1.TabIndex = 17;
			// 
			// txtTranspTel2
			// 
			this.txtTranspTel2.AcceptsReturn = true;
			this.txtTranspTel2.BackColor = System.Drawing.SystemColors.Window;
			this.txtTranspTel2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTranspTel2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTranspTel2.Location = new System.Drawing.Point(144, 64);
			this.txtTranspTel2.MaxLength = 0;
			this.txtTranspTel2.Name = "txtTranspTel2";
			this.txtTranspTel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTranspTel2.Size = new System.Drawing.Size(200, 20);
			this.txtTranspTel2.TabIndex = 16;
			// 
			// txtTranspTel3
			// 
			this.txtTranspTel3.AcceptsReturn = true;
			this.txtTranspTel3.BackColor = System.Drawing.SystemColors.Window;
			this.txtTranspTel3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTranspTel3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTranspTel3.Location = new System.Drawing.Point(144, 96);
			this.txtTranspTel3.MaxLength = 0;
			this.txtTranspTel3.Name = "txtTranspTel3";
			this.txtTranspTel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTranspTel3.Size = new System.Drawing.Size(200, 20);
			this.txtTranspTel3.TabIndex = 15;
			// 
			// txtTranspTel4
			// 
			this.txtTranspTel4.AcceptsReturn = true;
			this.txtTranspTel4.BackColor = System.Drawing.SystemColors.Window;
			this.txtTranspTel4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTranspTel4.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTranspTel4.Location = new System.Drawing.Point(144, 128);
			this.txtTranspTel4.MaxLength = 0;
			this.txtTranspTel4.Name = "txtTranspTel4";
			this.txtTranspTel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTranspTel4.Size = new System.Drawing.Size(200, 20);
			this.txtTranspTel4.TabIndex = 14;
			// 
			// txtTranspHorario
			// 
			this.txtTranspHorario.AcceptsReturn = true;
			this.txtTranspHorario.BackColor = System.Drawing.SystemColors.Window;
			this.txtTranspHorario.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTranspHorario.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTranspHorario.Location = new System.Drawing.Point(144, 224);
			this.txtTranspHorario.MaxLength = 0;
			this.txtTranspHorario.Name = "txtTranspHorario";
			this.txtTranspHorario.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTranspHorario.Size = new System.Drawing.Size(200, 20);
			this.txtTranspHorario.TabIndex = 12;
			// 
			// Label5
			// 
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(8, 32);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(133, 20);
			this.Label5.TabIndex = 24;
			this.Label5.Text = "Telefono1";
			// 
			// Label6
			// 
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(8, 64);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(133, 20);
			this.Label6.TabIndex = 23;
			this.Label6.Text = "Telefono2";
			// 
			// Label7
			// 
			this.Label7.BackColor = System.Drawing.SystemColors.Control;
			this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.Location = new System.Drawing.Point(8, 96);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(133, 20);
			this.Label7.TabIndex = 22;
			this.Label7.Text = "Telefono3";
			// 
			// Label8
			// 
			this.Label8.BackColor = System.Drawing.SystemColors.Control;
			this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label8.Location = new System.Drawing.Point(8, 128);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(133, 20);
			this.Label8.TabIndex = 21;
			this.Label8.Text = "Telefono4";
			// 
			// Label9
			// 
			this.Label9.BackColor = System.Drawing.SystemColors.Control;
			this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label9.Location = new System.Drawing.Point(8, 160);
			this.Label9.Name = "Label9";
			this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label9.Size = new System.Drawing.Size(133, 20);
			this.Label9.TabIndex = 20;
			this.Label9.Text = "Telefono5";
			// 
			// Label10
			// 
			this.Label10.BackColor = System.Drawing.SystemColors.Control;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label10.Location = new System.Drawing.Point(8, 224);
			this.Label10.Name = "Label10";
			this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label10.Size = new System.Drawing.Size(133, 20);
			this.Label10.TabIndex = 19;
			this.Label10.Text = "Horario";
			// 
			// Label11
			// 
			this.Label11.BackColor = System.Drawing.SystemColors.Control;
			this.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label11.Location = new System.Drawing.Point(8, 192);
			this.Label11.Name = "Label11";
			this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label11.Size = new System.Drawing.Size(133, 20);
			this.Label11.TabIndex = 18;
			this.Label11.Text = "Fax";
			// 
			// tabDestintos
			// 
			this.tabDestintos.Controls.Add(this.RichDestinos);
			this.tabDestintos.Location = new System.Drawing.Point(4, 22);
			this.tabDestintos.Name = "tabDestintos";
			this.tabDestintos.Size = new System.Drawing.Size(425, 319);
			this.tabDestintos.TabIndex = 2;
			this.tabDestintos.Text = "Destinos";
			// 
			// RichDestinos
			// 
			this.RichDestinos.Location = new System.Drawing.Point(24, 56);
			this.RichDestinos.Name = "RichDestinos";
			this.RichDestinos.Size = new System.Drawing.Size(313, 193);
			this.RichDestinos.TabIndex = 25;
			this.RichDestinos.Text = "";
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
			this.Toolbar1.Size = new System.Drawing.Size(1016, 42);
			this.Toolbar1.TabIndex = 48;
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
			// 
			// tabBusqueda
			// 
			this.tabBusqueda.Controls.Add(this.DataGridView1);
			this.tabBusqueda.Controls.Add(this.Frame3);
			this.tabBusqueda.Controls.Add(this.Text1);
			this.tabBusqueda.Controls.Add(this.Label12);
			this.tabBusqueda.Location = new System.Drawing.Point(4, 22);
			this.tabBusqueda.Name = "tabBusqueda";
			this.tabBusqueda.Size = new System.Drawing.Size(985, 493);
			this.tabBusqueda.TabIndex = 3;
			this.tabBusqueda.Text = "Busqueda";
			this.tabBusqueda.UseVisualStyleBackColor = true;
			// 
			// DataGridView1
			// 
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(131, 50);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new System.Drawing.Size(661, 357);
			this.DataGridView1.TabIndex = 35;
			// 
			// Frame3
			// 
			this.Frame3.BackColor = System.Drawing.SystemColors.Control;
			this.Frame3.Controls.Add(this.optDestino);
			this.Frame3.Controls.Add(this.optNombre);
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.Location = new System.Drawing.Point(3, 50);
			this.Frame3.Name = "Frame3";
			this.Frame3.Padding = new System.Windows.Forms.Padding(0);
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Size = new System.Drawing.Size(121, 65);
			this.Frame3.TabIndex = 34;
			this.Frame3.TabStop = false;
			this.Frame3.Text = "Opciones";
			// 
			// optDestino
			// 
			this.optDestino.BackColor = System.Drawing.SystemColors.Control;
			this.optDestino.Cursor = System.Windows.Forms.Cursors.Default;
			this.optDestino.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optDestino.Location = new System.Drawing.Point(16, 40);
			this.optDestino.Name = "optDestino";
			this.optDestino.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optDestino.Size = new System.Drawing.Size(65, 17);
			this.optDestino.TabIndex = 32;
			this.optDestino.TabStop = true;
			this.optDestino.Text = "Destino";
			this.optDestino.UseVisualStyleBackColor = false;
			// 
			// optNombre
			// 
			this.optNombre.BackColor = System.Drawing.SystemColors.Control;
			this.optNombre.Checked = true;
			this.optNombre.Cursor = System.Windows.Forms.Cursors.Default;
			this.optNombre.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optNombre.Location = new System.Drawing.Point(16, 16);
			this.optNombre.Name = "optNombre";
			this.optNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optNombre.Size = new System.Drawing.Size(81, 17);
			this.optNombre.TabIndex = 31;
			this.optNombre.TabStop = true;
			this.optNombre.Text = "Nombre";
			this.optNombre.UseVisualStyleBackColor = false;
			// 
			// Text1
			// 
			this.Text1.AcceptsReturn = true;
			this.Text1.BackColor = System.Drawing.SystemColors.Window;
			this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text1.Location = new System.Drawing.Point(131, 18);
			this.Text1.MaxLength = 0;
			this.Text1.Name = "Text1";
			this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text1.Size = new System.Drawing.Size(375, 20);
			this.Text1.TabIndex = 32;
			// 
			// Label12
			// 
			this.Label12.BackColor = System.Drawing.SystemColors.Control;
			this.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label12.Location = new System.Drawing.Point(3, 18);
			this.Label12.Name = "Label12";
			this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label12.Size = new System.Drawing.Size(121, 17);
			this.Label12.TabIndex = 33;
			this.Label12.Text = "Filtar por:";
			this.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// frmTransporte
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1016, 734);
			this.Controls.Add(this.Toolbar1);
			this.Controls.Add(this.SSTab1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 23);
			this.Name = "frmTransporte";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Transportes ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.SSTab1.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			this.tabContacto.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.Frame2.PerformLayout();
			this.tabDestintos.ResumeLayout(false);
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			this.tabBusqueda.ResumeLayout(false);
			this.tabBusqueda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			this.Frame3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
			#endregion
		internal System.Windows.Forms.DataGridView DataGridView1;
		public System.Windows.Forms.ToolStripButton tlbNuevo;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button2;
		public System.Windows.Forms.ToolStripButton tlbGuardar;
		public System.Windows.Forms.ToolStripButton tlbImprimir;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button6;
		public System.Windows.Forms.ToolStripButton tlbAnular;
		public System.Windows.Forms.ToolStripButton tlbEditar;
		private System.Windows.Forms.TabPage tabBusqueda;
	}
}
