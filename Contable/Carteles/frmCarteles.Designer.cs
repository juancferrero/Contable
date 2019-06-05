using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	partial class frmCarteles
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmCarteles() : base()
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
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.Button cmdSobres;
		public System.Windows.Forms.RadioButton Option6;
		public System.Windows.Forms.RadioButton Option5;
		public System.Windows.Forms.RadioButton Option4;
		public System.Windows.Forms.RadioButton Option3;
		public System.Windows.Forms.RadioButton Option2;
		public System.Windows.Forms.RadioButton Option1;
		public System.Windows.Forms.GroupBox Cantidad;
		public System.Windows.Forms.ComboBox cmbRazonSocial2;
		public System.Windows.Forms.TextBox txtCopias2;
		public System.Windows.Forms.Label _Lbl_35;
		public System.Windows.Forms.Label lblCP2;
		public System.Windows.Forms.Label _Lbl_8;
		public System.Windows.Forms.Label _Lbl_7;
		public System.Windows.Forms.Label _Lbl_6;
		public System.Windows.Forms.Label _Lbl_5;
		public System.Windows.Forms.Label _Lbl_4;
		public System.Windows.Forms.Label lblDireccion2;
		public System.Windows.Forms.Label lblLocalidad2;
		public System.Windows.Forms.Label lblProvincia2;
		public System.Windows.Forms.GroupBox Cartel2;
		public System.Windows.Forms.TextBox txtCopias4;
		public System.Windows.Forms.ComboBox cmbRazonSocial4;
		public System.Windows.Forms.Label _Lbl_34;
		public System.Windows.Forms.Label lblCP4;
		public System.Windows.Forms.Label _Lbl_19;
		public System.Windows.Forms.Label _Lbl_18;
		public System.Windows.Forms.Label _Lbl_17;
		public System.Windows.Forms.Label _Lbl_16;
		public System.Windows.Forms.Label _Lbl_15;
		public System.Windows.Forms.Label lblDireccion4;
		public System.Windows.Forms.Label lblLocalidad4;
		public System.Windows.Forms.Label lblProvincia4;
		public System.Windows.Forms.GroupBox Cartel4;
		public System.Windows.Forms.Button cmdImprimir;
		public System.Windows.Forms.TextBox txtCopias1;
		public System.Windows.Forms.ComboBox cmbRazonSocial1;
		public System.Windows.Forms.Label _Lbl_30;
		public System.Windows.Forms.Label lblCP1;
		public System.Windows.Forms.Label lblProvincia1;
		public System.Windows.Forms.Label lblLocalidad1;
		public System.Windows.Forms.Label lblDireccion1;
		public System.Windows.Forms.Label _Lbl_13;
		public System.Windows.Forms.Label _Lbl_1;
		public System.Windows.Forms.Label _Lbl_2;
		public System.Windows.Forms.Label _Lbl_3;
		public System.Windows.Forms.Label _Lbl_0;
		public System.Windows.Forms.GroupBox Cartel1;
		public System.Windows.Forms.TextBox txtCopias3;
		public System.Windows.Forms.ComboBox cmbRazonSocial3;
		public System.Windows.Forms.Label lblCP3;
		public System.Windows.Forms.Label _Lbl_31;
		public System.Windows.Forms.Label lblProvincia3;
		public System.Windows.Forms.Label lblLocalidad3;
		public System.Windows.Forms.Label lblDireccion3;
		public System.Windows.Forms.Label _Lbl_14;
		public System.Windows.Forms.Label _Lbl_12;
		public System.Windows.Forms.Label _Lbl_11;
		public System.Windows.Forms.Label _Lbl_10;
		public System.Windows.Forms.Label _Lbl_9;
		public System.Windows.Forms.GroupBox Cartel3;
		public System.Windows.Forms.ComboBox cmbRazonSocial5;
		public System.Windows.Forms.TextBox txtCopias5;
		public System.Windows.Forms.Label _Lbl_32;
		public System.Windows.Forms.Label lblCP5;
		public System.Windows.Forms.Label lblProvincia5;
		public System.Windows.Forms.Label lblLocalidad5;
		public System.Windows.Forms.Label lblDireccion5;
		public System.Windows.Forms.Label _Lbl_24;
		public System.Windows.Forms.Label _Lbl_23;
		public System.Windows.Forms.Label _Lbl_22;
		public System.Windows.Forms.Label _Lbl_21;
		public System.Windows.Forms.Label _Lbl_20;
		public System.Windows.Forms.GroupBox Cartel5;
		public System.Windows.Forms.ComboBox cmbRazonSocial6;
		public System.Windows.Forms.TextBox txtCopias6;
		public System.Windows.Forms.Label LBLcp6;
		public System.Windows.Forms.Label _Lbl_33;
		public System.Windows.Forms.Label lblProvincia6;
		public System.Windows.Forms.Label lblLocalidad6;
		public System.Windows.Forms.Label lblDireccion6;
		public System.Windows.Forms.Label _Lbl_29;
		public System.Windows.Forms.Label _Lbl_28;
		public System.Windows.Forms.Label _Lbl_27;
		public System.Windows.Forms.Label _Lbl_26;
		public System.Windows.Forms.Label _Lbl_25;
		public System.Windows.Forms.GroupBox Cartel6;
		//public Microsoft.VisualBasic.Compatibility.VB6.LabelArray Lbl;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.cmdImprimir = new System.Windows.Forms.Button();
			this.cmdSobres = new System.Windows.Forms.Button();
			this.Cantidad = new System.Windows.Forms.GroupBox();
			this.Option6 = new System.Windows.Forms.RadioButton();
			this.Option5 = new System.Windows.Forms.RadioButton();
			this.Option4 = new System.Windows.Forms.RadioButton();
			this.Option3 = new System.Windows.Forms.RadioButton();
			this.Option2 = new System.Windows.Forms.RadioButton();
			this.Option1 = new System.Windows.Forms.RadioButton();
			this.Cartel2 = new System.Windows.Forms.GroupBox();
			this.cmbRazonSocial2 = new System.Windows.Forms.ComboBox();
			this.txtCopias2 = new System.Windows.Forms.TextBox();
			this._Lbl_35 = new System.Windows.Forms.Label();
			this.lblCP2 = new System.Windows.Forms.Label();
			this._Lbl_8 = new System.Windows.Forms.Label();
			this._Lbl_7 = new System.Windows.Forms.Label();
			this._Lbl_6 = new System.Windows.Forms.Label();
			this._Lbl_5 = new System.Windows.Forms.Label();
			this._Lbl_4 = new System.Windows.Forms.Label();
			this.lblDireccion2 = new System.Windows.Forms.Label();
			this.lblLocalidad2 = new System.Windows.Forms.Label();
			this.lblProvincia2 = new System.Windows.Forms.Label();
			this.Cartel4 = new System.Windows.Forms.GroupBox();
			this.txtCopias4 = new System.Windows.Forms.TextBox();
			this.cmbRazonSocial4 = new System.Windows.Forms.ComboBox();
			this._Lbl_34 = new System.Windows.Forms.Label();
			this.lblCP4 = new System.Windows.Forms.Label();
			this._Lbl_19 = new System.Windows.Forms.Label();
			this._Lbl_18 = new System.Windows.Forms.Label();
			this._Lbl_17 = new System.Windows.Forms.Label();
			this._Lbl_16 = new System.Windows.Forms.Label();
			this._Lbl_15 = new System.Windows.Forms.Label();
			this.lblDireccion4 = new System.Windows.Forms.Label();
			this.lblLocalidad4 = new System.Windows.Forms.Label();
			this.lblProvincia4 = new System.Windows.Forms.Label();
			this.Cartel1 = new System.Windows.Forms.GroupBox();
			this.txtCopias1 = new System.Windows.Forms.TextBox();
			this.cmbRazonSocial1 = new System.Windows.Forms.ComboBox();
			this._Lbl_30 = new System.Windows.Forms.Label();
			this.lblCP1 = new System.Windows.Forms.Label();
			this.lblProvincia1 = new System.Windows.Forms.Label();
			this.lblLocalidad1 = new System.Windows.Forms.Label();
			this.lblDireccion1 = new System.Windows.Forms.Label();
			this._Lbl_13 = new System.Windows.Forms.Label();
			this._Lbl_1 = new System.Windows.Forms.Label();
			this._Lbl_2 = new System.Windows.Forms.Label();
			this._Lbl_3 = new System.Windows.Forms.Label();
			this._Lbl_0 = new System.Windows.Forms.Label();
			this.Cartel3 = new System.Windows.Forms.GroupBox();
			this.txtCopias3 = new System.Windows.Forms.TextBox();
			this.cmbRazonSocial3 = new System.Windows.Forms.ComboBox();
			this.lblCP3 = new System.Windows.Forms.Label();
			this._Lbl_31 = new System.Windows.Forms.Label();
			this.lblProvincia3 = new System.Windows.Forms.Label();
			this.lblLocalidad3 = new System.Windows.Forms.Label();
			this.lblDireccion3 = new System.Windows.Forms.Label();
			this._Lbl_14 = new System.Windows.Forms.Label();
			this._Lbl_12 = new System.Windows.Forms.Label();
			this._Lbl_11 = new System.Windows.Forms.Label();
			this._Lbl_10 = new System.Windows.Forms.Label();
			this._Lbl_9 = new System.Windows.Forms.Label();
			this.Cartel5 = new System.Windows.Forms.GroupBox();
			this.cmbRazonSocial5 = new System.Windows.Forms.ComboBox();
			this.txtCopias5 = new System.Windows.Forms.TextBox();
			this._Lbl_32 = new System.Windows.Forms.Label();
			this.lblCP5 = new System.Windows.Forms.Label();
			this.lblProvincia5 = new System.Windows.Forms.Label();
			this.lblLocalidad5 = new System.Windows.Forms.Label();
			this.lblDireccion5 = new System.Windows.Forms.Label();
			this._Lbl_24 = new System.Windows.Forms.Label();
			this._Lbl_23 = new System.Windows.Forms.Label();
			this._Lbl_22 = new System.Windows.Forms.Label();
			this._Lbl_21 = new System.Windows.Forms.Label();
			this._Lbl_20 = new System.Windows.Forms.Label();
			this.Cartel6 = new System.Windows.Forms.GroupBox();
			this.cmbRazonSocial6 = new System.Windows.Forms.ComboBox();
			this.txtCopias6 = new System.Windows.Forms.TextBox();
			this.LBLcp6 = new System.Windows.Forms.Label();
			this._Lbl_33 = new System.Windows.Forms.Label();
			this.lblProvincia6 = new System.Windows.Forms.Label();
			this.lblLocalidad6 = new System.Windows.Forms.Label();
			this.lblDireccion6 = new System.Windows.Forms.Label();
			this._Lbl_29 = new System.Windows.Forms.Label();
			this._Lbl_28 = new System.Windows.Forms.Label();
			this._Lbl_27 = new System.Windows.Forms.Label();
			this._Lbl_26 = new System.Windows.Forms.Label();
			this._Lbl_25 = new System.Windows.Forms.Label();
			this.Cantidad.SuspendLayout();
			this.Cartel2.SuspendLayout();
			this.Cartel4.SuspendLayout();
			this.Cartel1.SuspendLayout();
			this.Cartel3.SuspendLayout();
			this.Cartel5.SuspendLayout();
			this.Cartel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmdImprimir
			// 
			this.cmdImprimir.BackColor = System.Drawing.SystemColors.Control;
			this.cmdImprimir.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdImprimir.Location = new System.Drawing.Point(831, 16);
			this.cmdImprimir.Name = "cmdImprimir";
			this.cmdImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdImprimir.Size = new System.Drawing.Size(57, 57);
			this.cmdImprimir.TabIndex = 3;
			this.cmdImprimir.Text = "Carteles";
			this.cmdImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.ToolTip1.SetToolTip(this.cmdImprimir, "Imprimir");
			this.cmdImprimir.UseVisualStyleBackColor = false;
			// 
			// cmdSobres
			// 
			this.cmdSobres.BackColor = System.Drawing.SystemColors.Control;
			this.cmdSobres.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdSobres.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSobres.Location = new System.Drawing.Point(894, 16);
			this.cmdSobres.Name = "cmdSobres";
			this.cmdSobres.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdSobres.Size = new System.Drawing.Size(57, 57);
			this.cmdSobres.TabIndex = 74;
			this.cmdSobres.Text = "Sobres";
			this.cmdSobres.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdSobres.UseVisualStyleBackColor = false;
			// 
			// Cantidad
			// 
			this.Cantidad.BackColor = System.Drawing.SystemColors.Control;
			this.Cantidad.Controls.Add(this.Option6);
			this.Cantidad.Controls.Add(this.Option5);
			this.Cantidad.Controls.Add(this.Option4);
			this.Cantidad.Controls.Add(this.Option3);
			this.Cantidad.Controls.Add(this.Option2);
			this.Cantidad.Controls.Add(this.Option1);
			this.Cantidad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Cantidad.Location = new System.Drawing.Point(829, 96);
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.Padding = new System.Windows.Forms.Padding(0);
			this.Cantidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Cantidad.Size = new System.Drawing.Size(84, 129);
			this.Cantidad.TabIndex = 67;
			this.Cantidad.TabStop = false;
			this.Cantidad.Text = "Cantidad";
			// 
			// Option6
			// 
			this.Option6.BackColor = System.Drawing.SystemColors.Control;
			this.Option6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Option6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Option6.Location = new System.Drawing.Point(16, 96);
			this.Option6.Name = "Option6";
			this.Option6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Option6.Size = new System.Drawing.Size(25, 17);
			this.Option6.TabIndex = 73;
			this.Option6.TabStop = true;
			this.Option6.Text = "6";
			this.Option6.UseVisualStyleBackColor = false;
			// 
			// Option5
			// 
			this.Option5.BackColor = System.Drawing.SystemColors.Control;
			this.Option5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Option5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Option5.Location = new System.Drawing.Point(16, 80);
			this.Option5.Name = "Option5";
			this.Option5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Option5.Size = new System.Drawing.Size(25, 17);
			this.Option5.TabIndex = 72;
			this.Option5.TabStop = true;
			this.Option5.Text = "5";
			this.Option5.UseVisualStyleBackColor = false;
			// 
			// Option4
			// 
			this.Option4.BackColor = System.Drawing.SystemColors.Control;
			this.Option4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Option4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Option4.Location = new System.Drawing.Point(16, 64);
			this.Option4.Name = "Option4";
			this.Option4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Option4.Size = new System.Drawing.Size(25, 17);
			this.Option4.TabIndex = 71;
			this.Option4.TabStop = true;
			this.Option4.Text = "4";
			this.Option4.UseVisualStyleBackColor = false;
			// 
			// Option3
			// 
			this.Option3.BackColor = System.Drawing.SystemColors.Control;
			this.Option3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Option3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Option3.Location = new System.Drawing.Point(16, 48);
			this.Option3.Name = "Option3";
			this.Option3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Option3.Size = new System.Drawing.Size(25, 17);
			this.Option3.TabIndex = 70;
			this.Option3.TabStop = true;
			this.Option3.Text = "3";
			this.Option3.UseVisualStyleBackColor = false;
			// 
			// Option2
			// 
			this.Option2.BackColor = System.Drawing.SystemColors.Control;
			this.Option2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Option2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Option2.Location = new System.Drawing.Point(16, 32);
			this.Option2.Name = "Option2";
			this.Option2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Option2.Size = new System.Drawing.Size(25, 17);
			this.Option2.TabIndex = 69;
			this.Option2.TabStop = true;
			this.Option2.Text = "2";
			this.Option2.UseVisualStyleBackColor = false;
			// 
			// Option1
			// 
			this.Option1.BackColor = System.Drawing.SystemColors.Control;
			this.Option1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Option1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Option1.Location = new System.Drawing.Point(16, 16);
			this.Option1.Name = "Option1";
			this.Option1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Option1.Size = new System.Drawing.Size(25, 17);
			this.Option1.TabIndex = 68;
			this.Option1.TabStop = true;
			this.Option1.Text = "1";
			this.Option1.UseVisualStyleBackColor = false;
			// 
			// Cartel2
			// 
			this.Cartel2.BackColor = System.Drawing.SystemColors.Control;
			this.Cartel2.Controls.Add(this.cmbRazonSocial2);
			this.Cartel2.Controls.Add(this.txtCopias2);
			this.Cartel2.Controls.Add(this._Lbl_35);
			this.Cartel2.Controls.Add(this.lblCP2);
			this.Cartel2.Controls.Add(this._Lbl_8);
			this.Cartel2.Controls.Add(this._Lbl_7);
			this.Cartel2.Controls.Add(this._Lbl_6);
			this.Cartel2.Controls.Add(this._Lbl_5);
			this.Cartel2.Controls.Add(this._Lbl_4);
			this.Cartel2.Controls.Add(this.lblDireccion2);
			this.Cartel2.Controls.Add(this.lblLocalidad2);
			this.Cartel2.Controls.Add(this.lblProvincia2);
			this.Cartel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Cartel2.Location = new System.Drawing.Point(368, 0);
			this.Cartel2.Name = "Cartel2";
			this.Cartel2.Padding = new System.Windows.Forms.Padding(0);
			this.Cartel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Cartel2.Size = new System.Drawing.Size(353, 145);
			this.Cartel2.TabIndex = 12;
			this.Cartel2.TabStop = false;
			this.Cartel2.Visible = false;
			// 
			// cmbRazonSocial2
			// 
			this.cmbRazonSocial2.BackColor = System.Drawing.SystemColors.Window;
			this.cmbRazonSocial2.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbRazonSocial2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbRazonSocial2.Location = new System.Drawing.Point(8, 24);
			this.cmbRazonSocial2.Name = "cmbRazonSocial2";
			this.cmbRazonSocial2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbRazonSocial2.Size = new System.Drawing.Size(329, 21);
			this.cmbRazonSocial2.Sorted = true;
			this.cmbRazonSocial2.TabIndex = 14;
			// 
			// txtCopias2
			// 
			this.txtCopias2.AcceptsReturn = true;
			this.txtCopias2.BackColor = System.Drawing.SystemColors.Window;
			this.txtCopias2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCopias2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCopias2.Location = new System.Drawing.Point(304, 48);
			this.txtCopias2.MaxLength = 0;
			this.txtCopias2.Name = "txtCopias2";
			this.txtCopias2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCopias2.Size = new System.Drawing.Size(25, 20);
			this.txtCopias2.TabIndex = 13;
			// 
			// _Lbl_35
			// 
			this._Lbl_35.AutoSize = true;
			this._Lbl_35.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_35.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_35.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_35.Location = new System.Drawing.Point(168, 96);
			this._Lbl_35.Name = "_Lbl_35";
			this._Lbl_35.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_35.Size = new System.Drawing.Size(21, 13);
			this._Lbl_35.TabIndex = 86;
			this._Lbl_35.Text = "CP";
			this._Lbl_35.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblCP2
			// 
			this.lblCP2.BackColor = System.Drawing.SystemColors.Control;
			this.lblCP2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCP2.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCP2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCP2.Location = new System.Drawing.Point(168, 112);
			this.lblCP2.Name = "lblCP2";
			this.lblCP2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCP2.Size = new System.Drawing.Size(65, 20);
			this.lblCP2.TabIndex = 85;
			// 
			// _Lbl_8
			// 
			this._Lbl_8.AutoSize = true;
			this._Lbl_8.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_8.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_8.Location = new System.Drawing.Point(8, 8);
			this._Lbl_8.Name = "_Lbl_8";
			this._Lbl_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_8.Size = new System.Drawing.Size(70, 13);
			this._Lbl_8.TabIndex = 22;
			this._Lbl_8.Text = "Razon Social";
			this._Lbl_8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_7
			// 
			this._Lbl_7.AutoSize = true;
			this._Lbl_7.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_7.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_7.Location = new System.Drawing.Point(240, 96);
			this._Lbl_7.Name = "_Lbl_7";
			this._Lbl_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_7.Size = new System.Drawing.Size(51, 13);
			this._Lbl_7.TabIndex = 21;
			this._Lbl_7.Text = "Provincia";
			this._Lbl_7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_6
			// 
			this._Lbl_6.AutoSize = true;
			this._Lbl_6.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_6.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_6.Location = new System.Drawing.Point(8, 96);
			this._Lbl_6.Name = "_Lbl_6";
			this._Lbl_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_6.Size = new System.Drawing.Size(53, 13);
			this._Lbl_6.TabIndex = 20;
			this._Lbl_6.Text = "Localidad";
			this._Lbl_6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_5
			// 
			this._Lbl_5.AutoSize = true;
			this._Lbl_5.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_5.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_5.Location = new System.Drawing.Point(8, 56);
			this._Lbl_5.Name = "_Lbl_5";
			this._Lbl_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_5.Size = new System.Drawing.Size(52, 13);
			this._Lbl_5.TabIndex = 19;
			this._Lbl_5.Text = "Direccion";
			this._Lbl_5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_4
			// 
			this._Lbl_4.AutoSize = true;
			this._Lbl_4.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_4.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_4.Location = new System.Drawing.Point(264, 48);
			this._Lbl_4.Name = "_Lbl_4";
			this._Lbl_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_4.Size = new System.Drawing.Size(39, 13);
			this._Lbl_4.TabIndex = 18;
			this._Lbl_4.Text = "Copias";
			this._Lbl_4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblDireccion2
			// 
			this.lblDireccion2.BackColor = System.Drawing.SystemColors.Control;
			this.lblDireccion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDireccion2.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDireccion2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDireccion2.Location = new System.Drawing.Point(8, 72);
			this.lblDireccion2.Name = "lblDireccion2";
			this.lblDireccion2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDireccion2.Size = new System.Drawing.Size(321, 20);
			this.lblDireccion2.TabIndex = 17;
			// 
			// lblLocalidad2
			// 
			this.lblLocalidad2.BackColor = System.Drawing.SystemColors.Control;
			this.lblLocalidad2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLocalidad2.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLocalidad2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLocalidad2.Location = new System.Drawing.Point(8, 112);
			this.lblLocalidad2.Name = "lblLocalidad2";
			this.lblLocalidad2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLocalidad2.Size = new System.Drawing.Size(153, 20);
			this.lblLocalidad2.TabIndex = 16;
			// 
			// lblProvincia2
			// 
			this.lblProvincia2.BackColor = System.Drawing.SystemColors.Control;
			this.lblProvincia2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProvincia2.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblProvincia2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProvincia2.Location = new System.Drawing.Point(240, 112);
			this.lblProvincia2.Name = "lblProvincia2";
			this.lblProvincia2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblProvincia2.Size = new System.Drawing.Size(97, 20);
			this.lblProvincia2.TabIndex = 15;
			// 
			// Cartel4
			// 
			this.Cartel4.BackColor = System.Drawing.SystemColors.Control;
			this.Cartel4.Controls.Add(this.txtCopias4);
			this.Cartel4.Controls.Add(this.cmbRazonSocial4);
			this.Cartel4.Controls.Add(this._Lbl_34);
			this.Cartel4.Controls.Add(this.lblCP4);
			this.Cartel4.Controls.Add(this._Lbl_19);
			this.Cartel4.Controls.Add(this._Lbl_18);
			this.Cartel4.Controls.Add(this._Lbl_17);
			this.Cartel4.Controls.Add(this._Lbl_16);
			this.Cartel4.Controls.Add(this._Lbl_15);
			this.Cartel4.Controls.Add(this.lblDireccion4);
			this.Cartel4.Controls.Add(this.lblLocalidad4);
			this.Cartel4.Controls.Add(this.lblProvincia4);
			this.Cartel4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Cartel4.Location = new System.Drawing.Point(368, 136);
			this.Cartel4.Name = "Cartel4";
			this.Cartel4.Padding = new System.Windows.Forms.Padding(0);
			this.Cartel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Cartel4.Size = new System.Drawing.Size(353, 145);
			this.Cartel4.TabIndex = 34;
			this.Cartel4.TabStop = false;
			this.Cartel4.Visible = false;
			// 
			// txtCopias4
			// 
			this.txtCopias4.AcceptsReturn = true;
			this.txtCopias4.BackColor = System.Drawing.SystemColors.Window;
			this.txtCopias4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCopias4.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCopias4.Location = new System.Drawing.Point(304, 48);
			this.txtCopias4.MaxLength = 0;
			this.txtCopias4.Name = "txtCopias4";
			this.txtCopias4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCopias4.Size = new System.Drawing.Size(25, 20);
			this.txtCopias4.TabIndex = 35;
			// 
			// cmbRazonSocial4
			// 
			this.cmbRazonSocial4.BackColor = System.Drawing.SystemColors.Window;
			this.cmbRazonSocial4.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbRazonSocial4.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbRazonSocial4.Location = new System.Drawing.Point(8, 24);
			this.cmbRazonSocial4.Name = "cmbRazonSocial4";
			this.cmbRazonSocial4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbRazonSocial4.Size = new System.Drawing.Size(329, 21);
			this.cmbRazonSocial4.Sorted = true;
			this.cmbRazonSocial4.TabIndex = 36;
			// 
			// _Lbl_34
			// 
			this._Lbl_34.AutoSize = true;
			this._Lbl_34.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_34.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_34.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_34.Location = new System.Drawing.Point(168, 96);
			this._Lbl_34.Name = "_Lbl_34";
			this._Lbl_34.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_34.Size = new System.Drawing.Size(21, 13);
			this._Lbl_34.TabIndex = 84;
			this._Lbl_34.Text = "CP";
			this._Lbl_34.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblCP4
			// 
			this.lblCP4.BackColor = System.Drawing.SystemColors.Control;
			this.lblCP4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCP4.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCP4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCP4.Location = new System.Drawing.Point(168, 112);
			this.lblCP4.Name = "lblCP4";
			this.lblCP4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCP4.Size = new System.Drawing.Size(65, 20);
			this.lblCP4.TabIndex = 83;
			// 
			// _Lbl_19
			// 
			this._Lbl_19.AutoSize = true;
			this._Lbl_19.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_19.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_19.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_19.Location = new System.Drawing.Point(8, 8);
			this._Lbl_19.Name = "_Lbl_19";
			this._Lbl_19.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_19.Size = new System.Drawing.Size(70, 13);
			this._Lbl_19.TabIndex = 44;
			this._Lbl_19.Text = "Razon Social";
			this._Lbl_19.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_18
			// 
			this._Lbl_18.AutoSize = true;
			this._Lbl_18.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_18.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_18.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_18.Location = new System.Drawing.Point(240, 96);
			this._Lbl_18.Name = "_Lbl_18";
			this._Lbl_18.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_18.Size = new System.Drawing.Size(51, 13);
			this._Lbl_18.TabIndex = 43;
			this._Lbl_18.Text = "Provincia";
			this._Lbl_18.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_17
			// 
			this._Lbl_17.AutoSize = true;
			this._Lbl_17.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_17.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_17.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_17.Location = new System.Drawing.Point(8, 96);
			this._Lbl_17.Name = "_Lbl_17";
			this._Lbl_17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_17.Size = new System.Drawing.Size(53, 13);
			this._Lbl_17.TabIndex = 42;
			this._Lbl_17.Text = "Localidad";
			this._Lbl_17.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_16
			// 
			this._Lbl_16.AutoSize = true;
			this._Lbl_16.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_16.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_16.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_16.Location = new System.Drawing.Point(8, 56);
			this._Lbl_16.Name = "_Lbl_16";
			this._Lbl_16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_16.Size = new System.Drawing.Size(52, 13);
			this._Lbl_16.TabIndex = 41;
			this._Lbl_16.Text = "Direccion";
			this._Lbl_16.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_15
			// 
			this._Lbl_15.AutoSize = true;
			this._Lbl_15.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_15.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_15.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_15.Location = new System.Drawing.Point(264, 48);
			this._Lbl_15.Name = "_Lbl_15";
			this._Lbl_15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_15.Size = new System.Drawing.Size(39, 13);
			this._Lbl_15.TabIndex = 40;
			this._Lbl_15.Text = "Copias";
			this._Lbl_15.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblDireccion4
			// 
			this.lblDireccion4.BackColor = System.Drawing.SystemColors.Control;
			this.lblDireccion4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDireccion4.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDireccion4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDireccion4.Location = new System.Drawing.Point(8, 72);
			this.lblDireccion4.Name = "lblDireccion4";
			this.lblDireccion4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDireccion4.Size = new System.Drawing.Size(321, 20);
			this.lblDireccion4.TabIndex = 39;
			// 
			// lblLocalidad4
			// 
			this.lblLocalidad4.BackColor = System.Drawing.SystemColors.Control;
			this.lblLocalidad4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLocalidad4.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLocalidad4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLocalidad4.Location = new System.Drawing.Point(8, 112);
			this.lblLocalidad4.Name = "lblLocalidad4";
			this.lblLocalidad4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLocalidad4.Size = new System.Drawing.Size(153, 20);
			this.lblLocalidad4.TabIndex = 38;
			// 
			// lblProvincia4
			// 
			this.lblProvincia4.BackColor = System.Drawing.SystemColors.Control;
			this.lblProvincia4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProvincia4.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblProvincia4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProvincia4.Location = new System.Drawing.Point(240, 112);
			this.lblProvincia4.Name = "lblProvincia4";
			this.lblProvincia4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblProvincia4.Size = new System.Drawing.Size(97, 20);
			this.lblProvincia4.TabIndex = 37;
			// 
			// Cartel1
			// 
			this.Cartel1.BackColor = System.Drawing.SystemColors.Control;
			this.Cartel1.Controls.Add(this.txtCopias1);
			this.Cartel1.Controls.Add(this.cmbRazonSocial1);
			this.Cartel1.Controls.Add(this._Lbl_30);
			this.Cartel1.Controls.Add(this.lblCP1);
			this.Cartel1.Controls.Add(this.lblProvincia1);
			this.Cartel1.Controls.Add(this.lblLocalidad1);
			this.Cartel1.Controls.Add(this.lblDireccion1);
			this.Cartel1.Controls.Add(this._Lbl_13);
			this.Cartel1.Controls.Add(this._Lbl_1);
			this.Cartel1.Controls.Add(this._Lbl_2);
			this.Cartel1.Controls.Add(this._Lbl_3);
			this.Cartel1.Controls.Add(this._Lbl_0);
			this.Cartel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Cartel1.Location = new System.Drawing.Point(8, 0);
			this.Cartel1.Name = "Cartel1";
			this.Cartel1.Padding = new System.Windows.Forms.Padding(0);
			this.Cartel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Cartel1.Size = new System.Drawing.Size(353, 145);
			this.Cartel1.TabIndex = 0;
			this.Cartel1.TabStop = false;
			this.Cartel1.Visible = false;
			// 
			// txtCopias1
			// 
			this.txtCopias1.AcceptsReturn = true;
			this.txtCopias1.BackColor = System.Drawing.SystemColors.Window;
			this.txtCopias1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCopias1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCopias1.Location = new System.Drawing.Point(304, 48);
			this.txtCopias1.MaxLength = 0;
			this.txtCopias1.Name = "txtCopias1";
			this.txtCopias1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCopias1.Size = new System.Drawing.Size(25, 20);
			this.txtCopias1.TabIndex = 4;
			// 
			// cmbRazonSocial1
			// 
			this.cmbRazonSocial1.BackColor = System.Drawing.SystemColors.Window;
			this.cmbRazonSocial1.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbRazonSocial1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbRazonSocial1.Location = new System.Drawing.Point(8, 24);
			this.cmbRazonSocial1.Name = "cmbRazonSocial1";
			this.cmbRazonSocial1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbRazonSocial1.Size = new System.Drawing.Size(329, 21);
			this.cmbRazonSocial1.Sorted = true;
			this.cmbRazonSocial1.TabIndex = 1;
			// 
			// _Lbl_30
			// 
			this._Lbl_30.AutoSize = true;
			this._Lbl_30.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_30.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_30.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_30.Location = new System.Drawing.Point(168, 96);
			this._Lbl_30.Name = "_Lbl_30";
			this._Lbl_30.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_30.Size = new System.Drawing.Size(21, 13);
			this._Lbl_30.TabIndex = 76;
			this._Lbl_30.Text = "CP";
			this._Lbl_30.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblCP1
			// 
			this.lblCP1.BackColor = System.Drawing.SystemColors.Control;
			this.lblCP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCP1.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCP1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCP1.Location = new System.Drawing.Point(168, 112);
			this.lblCP1.Name = "lblCP1";
			this.lblCP1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCP1.Size = new System.Drawing.Size(65, 20);
			this.lblCP1.TabIndex = 75;
			// 
			// lblProvincia1
			// 
			this.lblProvincia1.BackColor = System.Drawing.SystemColors.Control;
			this.lblProvincia1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProvincia1.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblProvincia1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProvincia1.Location = new System.Drawing.Point(240, 112);
			this.lblProvincia1.Name = "lblProvincia1";
			this.lblProvincia1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblProvincia1.Size = new System.Drawing.Size(97, 20);
			this.lblProvincia1.TabIndex = 5;
			// 
			// lblLocalidad1
			// 
			this.lblLocalidad1.BackColor = System.Drawing.SystemColors.Control;
			this.lblLocalidad1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLocalidad1.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLocalidad1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLocalidad1.Location = new System.Drawing.Point(8, 112);
			this.lblLocalidad1.Name = "lblLocalidad1";
			this.lblLocalidad1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLocalidad1.Size = new System.Drawing.Size(153, 20);
			this.lblLocalidad1.TabIndex = 7;
			// 
			// lblDireccion1
			// 
			this.lblDireccion1.BackColor = System.Drawing.SystemColors.Control;
			this.lblDireccion1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDireccion1.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDireccion1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDireccion1.Location = new System.Drawing.Point(8, 72);
			this.lblDireccion1.Name = "lblDireccion1";
			this.lblDireccion1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDireccion1.Size = new System.Drawing.Size(321, 20);
			this.lblDireccion1.TabIndex = 6;
			// 
			// _Lbl_13
			// 
			this._Lbl_13.AutoSize = true;
			this._Lbl_13.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_13.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_13.Location = new System.Drawing.Point(264, 48);
			this._Lbl_13.Name = "_Lbl_13";
			this._Lbl_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_13.Size = new System.Drawing.Size(39, 13);
			this._Lbl_13.TabIndex = 11;
			this._Lbl_13.Text = "Copias";
			this._Lbl_13.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_1
			// 
			this._Lbl_1.AutoSize = true;
			this._Lbl_1.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_1.Location = new System.Drawing.Point(8, 56);
			this._Lbl_1.Name = "_Lbl_1";
			this._Lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_1.Size = new System.Drawing.Size(52, 13);
			this._Lbl_1.TabIndex = 10;
			this._Lbl_1.Text = "Direccion";
			this._Lbl_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_2
			// 
			this._Lbl_2.AutoSize = true;
			this._Lbl_2.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_2.Location = new System.Drawing.Point(8, 96);
			this._Lbl_2.Name = "_Lbl_2";
			this._Lbl_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_2.Size = new System.Drawing.Size(53, 13);
			this._Lbl_2.TabIndex = 9;
			this._Lbl_2.Text = "Localidad";
			this._Lbl_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_3
			// 
			this._Lbl_3.AutoSize = true;
			this._Lbl_3.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_3.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_3.Location = new System.Drawing.Point(240, 96);
			this._Lbl_3.Name = "_Lbl_3";
			this._Lbl_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_3.Size = new System.Drawing.Size(51, 13);
			this._Lbl_3.TabIndex = 8;
			this._Lbl_3.Text = "Provincia";
			this._Lbl_3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_0
			// 
			this._Lbl_0.AutoSize = true;
			this._Lbl_0.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_0.Location = new System.Drawing.Point(8, 8);
			this._Lbl_0.Name = "_Lbl_0";
			this._Lbl_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_0.Size = new System.Drawing.Size(70, 13);
			this._Lbl_0.TabIndex = 2;
			this._Lbl_0.Text = "Razon Social";
			this._Lbl_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Cartel3
			// 
			this.Cartel3.BackColor = System.Drawing.SystemColors.Control;
			this.Cartel3.Controls.Add(this.txtCopias3);
			this.Cartel3.Controls.Add(this.cmbRazonSocial3);
			this.Cartel3.Controls.Add(this.lblCP3);
			this.Cartel3.Controls.Add(this._Lbl_31);
			this.Cartel3.Controls.Add(this.lblProvincia3);
			this.Cartel3.Controls.Add(this.lblLocalidad3);
			this.Cartel3.Controls.Add(this.lblDireccion3);
			this.Cartel3.Controls.Add(this._Lbl_14);
			this.Cartel3.Controls.Add(this._Lbl_12);
			this.Cartel3.Controls.Add(this._Lbl_11);
			this.Cartel3.Controls.Add(this._Lbl_10);
			this.Cartel3.Controls.Add(this._Lbl_9);
			this.Cartel3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Cartel3.Location = new System.Drawing.Point(8, 136);
			this.Cartel3.Name = "Cartel3";
			this.Cartel3.Padding = new System.Windows.Forms.Padding(0);
			this.Cartel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Cartel3.Size = new System.Drawing.Size(353, 145);
			this.Cartel3.TabIndex = 23;
			this.Cartel3.TabStop = false;
			this.Cartel3.Visible = false;
			// 
			// txtCopias3
			// 
			this.txtCopias3.AcceptsReturn = true;
			this.txtCopias3.BackColor = System.Drawing.SystemColors.Window;
			this.txtCopias3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCopias3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCopias3.Location = new System.Drawing.Point(304, 48);
			this.txtCopias3.MaxLength = 0;
			this.txtCopias3.Name = "txtCopias3";
			this.txtCopias3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCopias3.Size = new System.Drawing.Size(25, 20);
			this.txtCopias3.TabIndex = 25;
			// 
			// cmbRazonSocial3
			// 
			this.cmbRazonSocial3.BackColor = System.Drawing.SystemColors.Window;
			this.cmbRazonSocial3.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbRazonSocial3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbRazonSocial3.Location = new System.Drawing.Point(8, 24);
			this.cmbRazonSocial3.Name = "cmbRazonSocial3";
			this.cmbRazonSocial3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbRazonSocial3.Size = new System.Drawing.Size(329, 21);
			this.cmbRazonSocial3.Sorted = true;
			this.cmbRazonSocial3.TabIndex = 24;
			// 
			// lblCP3
			// 
			this.lblCP3.BackColor = System.Drawing.SystemColors.Control;
			this.lblCP3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCP3.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCP3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCP3.Location = new System.Drawing.Point(168, 112);
			this.lblCP3.Name = "lblCP3";
			this.lblCP3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCP3.Size = new System.Drawing.Size(65, 20);
			this.lblCP3.TabIndex = 78;
			// 
			// _Lbl_31
			// 
			this._Lbl_31.AutoSize = true;
			this._Lbl_31.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_31.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_31.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_31.Location = new System.Drawing.Point(168, 96);
			this._Lbl_31.Name = "_Lbl_31";
			this._Lbl_31.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_31.Size = new System.Drawing.Size(21, 13);
			this._Lbl_31.TabIndex = 77;
			this._Lbl_31.Text = "CP";
			this._Lbl_31.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblProvincia3
			// 
			this.lblProvincia3.BackColor = System.Drawing.SystemColors.Control;
			this.lblProvincia3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProvincia3.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblProvincia3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProvincia3.Location = new System.Drawing.Point(240, 112);
			this.lblProvincia3.Name = "lblProvincia3";
			this.lblProvincia3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblProvincia3.Size = new System.Drawing.Size(97, 20);
			this.lblProvincia3.TabIndex = 33;
			// 
			// lblLocalidad3
			// 
			this.lblLocalidad3.BackColor = System.Drawing.SystemColors.Control;
			this.lblLocalidad3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLocalidad3.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLocalidad3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLocalidad3.Location = new System.Drawing.Point(8, 112);
			this.lblLocalidad3.Name = "lblLocalidad3";
			this.lblLocalidad3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLocalidad3.Size = new System.Drawing.Size(153, 20);
			this.lblLocalidad3.TabIndex = 32;
			// 
			// lblDireccion3
			// 
			this.lblDireccion3.BackColor = System.Drawing.SystemColors.Control;
			this.lblDireccion3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDireccion3.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDireccion3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDireccion3.Location = new System.Drawing.Point(8, 72);
			this.lblDireccion3.Name = "lblDireccion3";
			this.lblDireccion3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDireccion3.Size = new System.Drawing.Size(321, 20);
			this.lblDireccion3.TabIndex = 31;
			// 
			// _Lbl_14
			// 
			this._Lbl_14.AutoSize = true;
			this._Lbl_14.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_14.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_14.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_14.Location = new System.Drawing.Point(264, 48);
			this._Lbl_14.Name = "_Lbl_14";
			this._Lbl_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_14.Size = new System.Drawing.Size(39, 13);
			this._Lbl_14.TabIndex = 30;
			this._Lbl_14.Text = "Copias";
			this._Lbl_14.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_12
			// 
			this._Lbl_12.AutoSize = true;
			this._Lbl_12.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_12.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_12.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_12.Location = new System.Drawing.Point(8, 56);
			this._Lbl_12.Name = "_Lbl_12";
			this._Lbl_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_12.Size = new System.Drawing.Size(52, 13);
			this._Lbl_12.TabIndex = 29;
			this._Lbl_12.Text = "Direccion";
			this._Lbl_12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_11
			// 
			this._Lbl_11.AutoSize = true;
			this._Lbl_11.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_11.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_11.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_11.Location = new System.Drawing.Point(8, 96);
			this._Lbl_11.Name = "_Lbl_11";
			this._Lbl_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_11.Size = new System.Drawing.Size(53, 13);
			this._Lbl_11.TabIndex = 28;
			this._Lbl_11.Text = "Localidad";
			this._Lbl_11.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_10
			// 
			this._Lbl_10.AutoSize = true;
			this._Lbl_10.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_10.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_10.Location = new System.Drawing.Point(240, 96);
			this._Lbl_10.Name = "_Lbl_10";
			this._Lbl_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_10.Size = new System.Drawing.Size(51, 13);
			this._Lbl_10.TabIndex = 27;
			this._Lbl_10.Text = "Provincia";
			this._Lbl_10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_9
			// 
			this._Lbl_9.AutoSize = true;
			this._Lbl_9.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_9.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_9.Location = new System.Drawing.Point(8, 8);
			this._Lbl_9.Name = "_Lbl_9";
			this._Lbl_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_9.Size = new System.Drawing.Size(70, 13);
			this._Lbl_9.TabIndex = 26;
			this._Lbl_9.Text = "Razon Social";
			this._Lbl_9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Cartel5
			// 
			this.Cartel5.BackColor = System.Drawing.SystemColors.Control;
			this.Cartel5.Controls.Add(this.cmbRazonSocial5);
			this.Cartel5.Controls.Add(this.txtCopias5);
			this.Cartel5.Controls.Add(this._Lbl_32);
			this.Cartel5.Controls.Add(this.lblCP5);
			this.Cartel5.Controls.Add(this.lblProvincia5);
			this.Cartel5.Controls.Add(this.lblLocalidad5);
			this.Cartel5.Controls.Add(this.lblDireccion5);
			this.Cartel5.Controls.Add(this._Lbl_24);
			this.Cartel5.Controls.Add(this._Lbl_23);
			this.Cartel5.Controls.Add(this._Lbl_22);
			this.Cartel5.Controls.Add(this._Lbl_21);
			this.Cartel5.Controls.Add(this._Lbl_20);
			this.Cartel5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Cartel5.Location = new System.Drawing.Point(8, 272);
			this.Cartel5.Name = "Cartel5";
			this.Cartel5.Padding = new System.Windows.Forms.Padding(0);
			this.Cartel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Cartel5.Size = new System.Drawing.Size(353, 153);
			this.Cartel5.TabIndex = 45;
			this.Cartel5.TabStop = false;
			this.Cartel5.Visible = false;
			// 
			// cmbRazonSocial5
			// 
			this.cmbRazonSocial5.BackColor = System.Drawing.SystemColors.Window;
			this.cmbRazonSocial5.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbRazonSocial5.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbRazonSocial5.Location = new System.Drawing.Point(8, 24);
			this.cmbRazonSocial5.Name = "cmbRazonSocial5";
			this.cmbRazonSocial5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbRazonSocial5.Size = new System.Drawing.Size(329, 21);
			this.cmbRazonSocial5.Sorted = true;
			this.cmbRazonSocial5.TabIndex = 47;
			// 
			// txtCopias5
			// 
			this.txtCopias5.AcceptsReturn = true;
			this.txtCopias5.BackColor = System.Drawing.SystemColors.Window;
			this.txtCopias5.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCopias5.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCopias5.Location = new System.Drawing.Point(304, 48);
			this.txtCopias5.MaxLength = 0;
			this.txtCopias5.Name = "txtCopias5";
			this.txtCopias5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCopias5.Size = new System.Drawing.Size(25, 20);
			this.txtCopias5.TabIndex = 46;
			// 
			// _Lbl_32
			// 
			this._Lbl_32.AutoSize = true;
			this._Lbl_32.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_32.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_32.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_32.Location = new System.Drawing.Point(168, 96);
			this._Lbl_32.Name = "_Lbl_32";
			this._Lbl_32.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_32.Size = new System.Drawing.Size(21, 13);
			this._Lbl_32.TabIndex = 80;
			this._Lbl_32.Text = "CP";
			this._Lbl_32.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblCP5
			// 
			this.lblCP5.BackColor = System.Drawing.SystemColors.Control;
			this.lblCP5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCP5.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCP5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCP5.Location = new System.Drawing.Point(168, 112);
			this.lblCP5.Name = "lblCP5";
			this.lblCP5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCP5.Size = new System.Drawing.Size(65, 20);
			this.lblCP5.TabIndex = 79;
			// 
			// lblProvincia5
			// 
			this.lblProvincia5.BackColor = System.Drawing.SystemColors.Control;
			this.lblProvincia5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProvincia5.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblProvincia5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProvincia5.Location = new System.Drawing.Point(240, 112);
			this.lblProvincia5.Name = "lblProvincia5";
			this.lblProvincia5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblProvincia5.Size = new System.Drawing.Size(97, 20);
			this.lblProvincia5.TabIndex = 55;
			// 
			// lblLocalidad5
			// 
			this.lblLocalidad5.BackColor = System.Drawing.SystemColors.Control;
			this.lblLocalidad5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLocalidad5.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLocalidad5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLocalidad5.Location = new System.Drawing.Point(8, 112);
			this.lblLocalidad5.Name = "lblLocalidad5";
			this.lblLocalidad5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLocalidad5.Size = new System.Drawing.Size(153, 20);
			this.lblLocalidad5.TabIndex = 54;
			// 
			// lblDireccion5
			// 
			this.lblDireccion5.BackColor = System.Drawing.SystemColors.Control;
			this.lblDireccion5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDireccion5.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDireccion5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDireccion5.Location = new System.Drawing.Point(8, 72);
			this.lblDireccion5.Name = "lblDireccion5";
			this.lblDireccion5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDireccion5.Size = new System.Drawing.Size(321, 20);
			this.lblDireccion5.TabIndex = 53;
			// 
			// _Lbl_24
			// 
			this._Lbl_24.AutoSize = true;
			this._Lbl_24.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_24.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_24.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_24.Location = new System.Drawing.Point(264, 48);
			this._Lbl_24.Name = "_Lbl_24";
			this._Lbl_24.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_24.Size = new System.Drawing.Size(39, 13);
			this._Lbl_24.TabIndex = 52;
			this._Lbl_24.Text = "Copias";
			this._Lbl_24.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_23
			// 
			this._Lbl_23.AutoSize = true;
			this._Lbl_23.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_23.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_23.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_23.Location = new System.Drawing.Point(8, 56);
			this._Lbl_23.Name = "_Lbl_23";
			this._Lbl_23.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_23.Size = new System.Drawing.Size(52, 13);
			this._Lbl_23.TabIndex = 51;
			this._Lbl_23.Text = "Direccion";
			this._Lbl_23.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_22
			// 
			this._Lbl_22.AutoSize = true;
			this._Lbl_22.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_22.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_22.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_22.Location = new System.Drawing.Point(8, 96);
			this._Lbl_22.Name = "_Lbl_22";
			this._Lbl_22.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_22.Size = new System.Drawing.Size(53, 13);
			this._Lbl_22.TabIndex = 50;
			this._Lbl_22.Text = "Localidad";
			this._Lbl_22.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_21
			// 
			this._Lbl_21.AutoSize = true;
			this._Lbl_21.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_21.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_21.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_21.Location = new System.Drawing.Point(240, 96);
			this._Lbl_21.Name = "_Lbl_21";
			this._Lbl_21.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_21.Size = new System.Drawing.Size(51, 13);
			this._Lbl_21.TabIndex = 49;
			this._Lbl_21.Text = "Provincia";
			this._Lbl_21.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_20
			// 
			this._Lbl_20.AutoSize = true;
			this._Lbl_20.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_20.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_20.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_20.Location = new System.Drawing.Point(8, 8);
			this._Lbl_20.Name = "_Lbl_20";
			this._Lbl_20.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_20.Size = new System.Drawing.Size(70, 13);
			this._Lbl_20.TabIndex = 48;
			this._Lbl_20.Text = "Razon Social";
			this._Lbl_20.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Cartel6
			// 
			this.Cartel6.BackColor = System.Drawing.SystemColors.Control;
			this.Cartel6.Controls.Add(this.cmbRazonSocial6);
			this.Cartel6.Controls.Add(this.txtCopias6);
			this.Cartel6.Controls.Add(this.LBLcp6);
			this.Cartel6.Controls.Add(this._Lbl_33);
			this.Cartel6.Controls.Add(this.lblProvincia6);
			this.Cartel6.Controls.Add(this.lblLocalidad6);
			this.Cartel6.Controls.Add(this.lblDireccion6);
			this.Cartel6.Controls.Add(this._Lbl_29);
			this.Cartel6.Controls.Add(this._Lbl_28);
			this.Cartel6.Controls.Add(this._Lbl_27);
			this.Cartel6.Controls.Add(this._Lbl_26);
			this.Cartel6.Controls.Add(this._Lbl_25);
			this.Cartel6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Cartel6.Location = new System.Drawing.Point(368, 272);
			this.Cartel6.Name = "Cartel6";
			this.Cartel6.Padding = new System.Windows.Forms.Padding(0);
			this.Cartel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Cartel6.Size = new System.Drawing.Size(353, 153);
			this.Cartel6.TabIndex = 56;
			this.Cartel6.TabStop = false;
			this.Cartel6.Visible = false;
			// 
			// cmbRazonSocial6
			// 
			this.cmbRazonSocial6.BackColor = System.Drawing.SystemColors.Window;
			this.cmbRazonSocial6.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbRazonSocial6.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbRazonSocial6.Location = new System.Drawing.Point(8, 24);
			this.cmbRazonSocial6.Name = "cmbRazonSocial6";
			this.cmbRazonSocial6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbRazonSocial6.Size = new System.Drawing.Size(329, 21);
			this.cmbRazonSocial6.Sorted = true;
			this.cmbRazonSocial6.TabIndex = 58;
			// 
			// txtCopias6
			// 
			this.txtCopias6.AcceptsReturn = true;
			this.txtCopias6.BackColor = System.Drawing.SystemColors.Window;
			this.txtCopias6.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCopias6.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCopias6.Location = new System.Drawing.Point(304, 48);
			this.txtCopias6.MaxLength = 0;
			this.txtCopias6.Name = "txtCopias6";
			this.txtCopias6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCopias6.Size = new System.Drawing.Size(25, 20);
			this.txtCopias6.TabIndex = 57;
			// 
			// LBLcp6
			// 
			this.LBLcp6.BackColor = System.Drawing.SystemColors.Control;
			this.LBLcp6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LBLcp6.Cursor = System.Windows.Forms.Cursors.Default;
			this.LBLcp6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LBLcp6.Location = new System.Drawing.Point(168, 112);
			this.LBLcp6.Name = "LBLcp6";
			this.LBLcp6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.LBLcp6.Size = new System.Drawing.Size(65, 20);
			this.LBLcp6.TabIndex = 82;
			// 
			// _Lbl_33
			// 
			this._Lbl_33.AutoSize = true;
			this._Lbl_33.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_33.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_33.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_33.Location = new System.Drawing.Point(168, 96);
			this._Lbl_33.Name = "_Lbl_33";
			this._Lbl_33.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_33.Size = new System.Drawing.Size(21, 13);
			this._Lbl_33.TabIndex = 81;
			this._Lbl_33.Text = "CP";
			this._Lbl_33.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblProvincia6
			// 
			this.lblProvincia6.BackColor = System.Drawing.SystemColors.Control;
			this.lblProvincia6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProvincia6.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblProvincia6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProvincia6.Location = new System.Drawing.Point(240, 112);
			this.lblProvincia6.Name = "lblProvincia6";
			this.lblProvincia6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblProvincia6.Size = new System.Drawing.Size(97, 20);
			this.lblProvincia6.TabIndex = 66;
			// 
			// lblLocalidad6
			// 
			this.lblLocalidad6.BackColor = System.Drawing.SystemColors.Control;
			this.lblLocalidad6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLocalidad6.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLocalidad6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLocalidad6.Location = new System.Drawing.Point(8, 112);
			this.lblLocalidad6.Name = "lblLocalidad6";
			this.lblLocalidad6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLocalidad6.Size = new System.Drawing.Size(153, 20);
			this.lblLocalidad6.TabIndex = 65;
			// 
			// lblDireccion6
			// 
			this.lblDireccion6.BackColor = System.Drawing.SystemColors.Control;
			this.lblDireccion6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDireccion6.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDireccion6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDireccion6.Location = new System.Drawing.Point(8, 72);
			this.lblDireccion6.Name = "lblDireccion6";
			this.lblDireccion6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDireccion6.Size = new System.Drawing.Size(321, 20);
			this.lblDireccion6.TabIndex = 64;
			// 
			// _Lbl_29
			// 
			this._Lbl_29.AutoSize = true;
			this._Lbl_29.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_29.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_29.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_29.Location = new System.Drawing.Point(264, 48);
			this._Lbl_29.Name = "_Lbl_29";
			this._Lbl_29.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_29.Size = new System.Drawing.Size(39, 13);
			this._Lbl_29.TabIndex = 63;
			this._Lbl_29.Text = "Copias";
			this._Lbl_29.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_28
			// 
			this._Lbl_28.AutoSize = true;
			this._Lbl_28.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_28.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_28.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_28.Location = new System.Drawing.Point(8, 56);
			this._Lbl_28.Name = "_Lbl_28";
			this._Lbl_28.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_28.Size = new System.Drawing.Size(52, 13);
			this._Lbl_28.TabIndex = 62;
			this._Lbl_28.Text = "Direccion";
			this._Lbl_28.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_27
			// 
			this._Lbl_27.AutoSize = true;
			this._Lbl_27.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_27.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_27.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_27.Location = new System.Drawing.Point(8, 96);
			this._Lbl_27.Name = "_Lbl_27";
			this._Lbl_27.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_27.Size = new System.Drawing.Size(53, 13);
			this._Lbl_27.TabIndex = 61;
			this._Lbl_27.Text = "Localidad";
			this._Lbl_27.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_26
			// 
			this._Lbl_26.AutoSize = true;
			this._Lbl_26.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_26.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_26.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_26.Location = new System.Drawing.Point(240, 96);
			this._Lbl_26.Name = "_Lbl_26";
			this._Lbl_26.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_26.Size = new System.Drawing.Size(51, 13);
			this._Lbl_26.TabIndex = 60;
			this._Lbl_26.Text = "Provincia";
			this._Lbl_26.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_25
			// 
			this._Lbl_25.AutoSize = true;
			this._Lbl_25.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_25.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_25.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_25.Location = new System.Drawing.Point(8, 8);
			this._Lbl_25.Name = "_Lbl_25";
			this._Lbl_25.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_25.Size = new System.Drawing.Size(70, 13);
			this._Lbl_25.TabIndex = 59;
			this._Lbl_25.Text = "Razon Social";
			this._Lbl_25.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// frmCarteles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1115, 455);
			this.Controls.Add(this.cmdSobres);
			this.Controls.Add(this.Cantidad);
			this.Controls.Add(this.Cartel2);
			this.Controls.Add(this.Cartel4);
			this.Controls.Add(this.cmdImprimir);
			this.Controls.Add(this.Cartel1);
			this.Controls.Add(this.Cartel3);
			this.Controls.Add(this.Cartel5);
			this.Controls.Add(this.Cartel6);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 25);
			this.Name = "frmCarteles";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Generador de Carteles";
			this.Cantidad.ResumeLayout(false);
			this.Cartel2.ResumeLayout(false);
			this.Cartel2.PerformLayout();
			this.Cartel4.ResumeLayout(false);
			this.Cartel4.PerformLayout();
			this.Cartel1.ResumeLayout(false);
			this.Cartel1.PerformLayout();
			this.Cartel3.ResumeLayout(false);
			this.Cartel3.PerformLayout();
			this.Cartel5.ResumeLayout(false);
			this.Cartel5.PerformLayout();
			this.Cartel6.ResumeLayout(false);
			this.Cartel6.PerformLayout();
			this.ResumeLayout(false);
		}
		#endregion
	}
}
