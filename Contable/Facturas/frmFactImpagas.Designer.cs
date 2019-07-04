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
	//[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class frmFactImpagas
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmFactImpagas() : base()
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
				/*if ((components != null)) {
					components.Dispose();
				}*/
			}
			base.Dispose(Disposing);
		}
//Requerido por el Diseñador de Windows Forms
		//private System.ComponentModel.IContainer components;
		public System.Windows.Forms.CheckBox chEnVigencia;
		public System.Windows.Forms.CheckBox chVencidas90;
		public System.Windows.Forms.CheckBox chVencidas60;
		public System.Windows.Forms.CheckBox chVencidas30;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label lblFactTotal;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label lblPorcTot;
		public System.Windows.Forms.Label lblFactEnVigencia;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label lblPorcVi;
		public System.Windows.Forms.Label lblFactVencidas60;
		public System.Windows.Forms.Label lblNumv60;
		public System.Windows.Forms.Label lblNumv30;
		public System.Windows.Forms.Label lblFactVencidas30;
		public System.Windows.Forms.Label lblNumv90;
		public System.Windows.Forms.Label lblFactVencidas90;
		public System.Windows.Forms.Label lblPorc30;
		public System.Windows.Forms.Label lblPorc60;
		public System.Windows.Forms.Label lblPorc90;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.RadioButton Option4;
		public System.Windows.Forms.RadioButton Option3;
		public System.Windows.Forms.RadioButton Option2;
		public System.Windows.Forms.RadioButton Option1;
		public System.Windows.Forms.GroupBox frmOrden;
		public System.Windows.Forms.ComboBox cmbAño;
		public System.Windows.Forms.Label lblPorcentaje;
		public System.Windows.Forms.Label Label1;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactImpagas));
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.chEnVigencia = new System.Windows.Forms.CheckBox();
			this.chVencidas90 = new System.Windows.Forms.CheckBox();
			this.chVencidas60 = new System.Windows.Forms.CheckBox();
			this.chVencidas30 = new System.Windows.Forms.CheckBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.lblFactTotal = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.lblPorcTot = new System.Windows.Forms.Label();
			this.lblFactEnVigencia = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.lblPorcVi = new System.Windows.Forms.Label();
			this.lblFactVencidas60 = new System.Windows.Forms.Label();
			this.lblNumv60 = new System.Windows.Forms.Label();
			this.lblNumv30 = new System.Windows.Forms.Label();
			this.lblFactVencidas30 = new System.Windows.Forms.Label();
			this.lblNumv90 = new System.Windows.Forms.Label();
			this.lblFactVencidas90 = new System.Windows.Forms.Label();
			this.lblPorc30 = new System.Windows.Forms.Label();
			this.lblPorc60 = new System.Windows.Forms.Label();
			this.lblPorc90 = new System.Windows.Forms.Label();
			this.frmOrden = new System.Windows.Forms.GroupBox();
			this.Option4 = new System.Windows.Forms.RadioButton();
			this.Option3 = new System.Windows.Forms.RadioButton();
			this.Option2 = new System.Windows.Forms.RadioButton();
			this.Option1 = new System.Windows.Forms.RadioButton();
			this.cmbAño = new System.Windows.Forms.ComboBox();
			this.lblPorcentaje = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tlActualizar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tlImprimir = new System.Windows.Forms.ToolStripButton();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.Frame1.SuspendLayout();
			this.frmOrden.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.chEnVigencia);
			this.Frame1.Controls.Add(this.chVencidas90);
			this.Frame1.Controls.Add(this.chVencidas60);
			this.Frame1.Controls.Add(this.chVencidas30);
			this.Frame1.Controls.Add(this.Label6);
			this.Frame1.Controls.Add(this.lblFactTotal);
			this.Frame1.Controls.Add(this.Label8);
			this.Frame1.Controls.Add(this.lblPorcTot);
			this.Frame1.Controls.Add(this.lblFactEnVigencia);
			this.Frame1.Controls.Add(this.Label5);
			this.Frame1.Controls.Add(this.lblPorcVi);
			this.Frame1.Controls.Add(this.lblFactVencidas60);
			this.Frame1.Controls.Add(this.lblNumv60);
			this.Frame1.Controls.Add(this.lblNumv30);
			this.Frame1.Controls.Add(this.lblFactVencidas30);
			this.Frame1.Controls.Add(this.lblNumv90);
			this.Frame1.Controls.Add(this.lblFactVencidas90);
			this.Frame1.Controls.Add(this.lblPorc30);
			this.Frame1.Controls.Add(this.lblPorc60);
			this.Frame1.Controls.Add(this.lblPorc90);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(180, 147);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(329, 153);
			this.Frame1.TabIndex = 11;
			this.Frame1.TabStop = false;
			this.Frame1.Text = "Condiciones";
			// 
			// chEnVigencia
			// 
			this.chEnVigencia.Appearance = System.Windows.Forms.Appearance.Button;
			this.chEnVigencia.BackColor = System.Drawing.SystemColors.Control;
			this.chEnVigencia.Checked = true;
			this.chEnVigencia.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chEnVigencia.Cursor = System.Windows.Forms.Cursors.Default;
			this.chEnVigencia.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chEnVigencia.Location = new System.Drawing.Point(8, 96);
			this.chEnVigencia.Name = "chEnVigencia";
			this.chEnVigencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chEnVigencia.Size = new System.Drawing.Size(89, 17);
			this.chEnVigencia.TabIndex = 15;
			this.chEnVigencia.Text = "En Vigencia";
			this.chEnVigencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chEnVigencia.UseVisualStyleBackColor = false;
			// 
			// chVencidas90
			// 
			this.chVencidas90.Appearance = System.Windows.Forms.Appearance.Button;
			this.chVencidas90.BackColor = System.Drawing.SystemColors.Control;
			this.chVencidas90.Checked = true;
			this.chVencidas90.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chVencidas90.Cursor = System.Windows.Forms.Cursors.Default;
			this.chVencidas90.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chVencidas90.Location = new System.Drawing.Point(8, 72);
			this.chVencidas90.Name = "chVencidas90";
			this.chVencidas90.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chVencidas90.Size = new System.Drawing.Size(89, 17);
			this.chVencidas90.TabIndex = 14;
			this.chVencidas90.Text = "Vencidas 90";
			this.chVencidas90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chVencidas90.UseVisualStyleBackColor = false;
			// 
			// chVencidas60
			// 
			this.chVencidas60.Appearance = System.Windows.Forms.Appearance.Button;
			this.chVencidas60.BackColor = System.Drawing.SystemColors.Control;
			this.chVencidas60.Checked = true;
			this.chVencidas60.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chVencidas60.Cursor = System.Windows.Forms.Cursors.Default;
			this.chVencidas60.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chVencidas60.Location = new System.Drawing.Point(8, 48);
			this.chVencidas60.Name = "chVencidas60";
			this.chVencidas60.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chVencidas60.Size = new System.Drawing.Size(89, 17);
			this.chVencidas60.TabIndex = 13;
			this.chVencidas60.Text = "Vencidas 60";
			this.chVencidas60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chVencidas60.UseVisualStyleBackColor = false;
			// 
			// chVencidas30
			// 
			this.chVencidas30.Appearance = System.Windows.Forms.Appearance.Button;
			this.chVencidas30.BackColor = System.Drawing.SystemColors.Control;
			this.chVencidas30.Checked = true;
			this.chVencidas30.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chVencidas30.Cursor = System.Windows.Forms.Cursors.Default;
			this.chVencidas30.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chVencidas30.Location = new System.Drawing.Point(8, 24);
			this.chVencidas30.Name = "chVencidas30";
			this.chVencidas30.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chVencidas30.Size = new System.Drawing.Size(89, 17);
			this.chVencidas30.TabIndex = 12;
			this.chVencidas30.Text = "Vencidas 30";
			this.chVencidas30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chVencidas30.UseVisualStyleBackColor = false;
			// 
			// Label6
			// 
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(104, 120);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(41, 17);
			this.Label6.TabIndex = 31;
			this.Label6.Text = "0";
			// 
			// lblFactTotal
			// 
			this.lblFactTotal.BackColor = System.Drawing.SystemColors.Control;
			this.lblFactTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblFactTotal.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblFactTotal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblFactTotal.Location = new System.Drawing.Point(152, 120);
			this.lblFactTotal.Name = "lblFactTotal";
			this.lblFactTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFactTotal.Size = new System.Drawing.Size(113, 17);
			this.lblFactTotal.TabIndex = 30;
			this.lblFactTotal.Text = "0";
			// 
			// Label8
			// 
			this.Label8.BackColor = System.Drawing.SystemColors.Control;
			this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label8.Location = new System.Drawing.Point(8, 120);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(89, 17);
			this.Label8.TabIndex = 29;
			this.Label8.Text = "Total";
			// 
			// lblPorcTot
			// 
			this.lblPorcTot.BackColor = System.Drawing.SystemColors.Control;
			this.lblPorcTot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPorcTot.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblPorcTot.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPorcTot.Location = new System.Drawing.Point(272, 120);
			this.lblPorcTot.Name = "lblPorcTot";
			this.lblPorcTot.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPorcTot.Size = new System.Drawing.Size(41, 17);
			this.lblPorcTot.TabIndex = 28;
			this.lblPorcTot.Text = "0";
			// 
			// lblFactEnVigencia
			// 
			this.lblFactEnVigencia.BackColor = System.Drawing.SystemColors.Control;
			this.lblFactEnVigencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblFactEnVigencia.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblFactEnVigencia.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblFactEnVigencia.Location = new System.Drawing.Point(152, 96);
			this.lblFactEnVigencia.Name = "lblFactEnVigencia";
			this.lblFactEnVigencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFactEnVigencia.Size = new System.Drawing.Size(113, 17);
			this.lblFactEnVigencia.TabIndex = 27;
			this.lblFactEnVigencia.Text = "0";
			// 
			// Label5
			// 
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(104, 96);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(41, 17);
			this.Label5.TabIndex = 26;
			this.Label5.Text = "0";
			// 
			// lblPorcVi
			// 
			this.lblPorcVi.BackColor = System.Drawing.SystemColors.Control;
			this.lblPorcVi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPorcVi.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblPorcVi.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPorcVi.Location = new System.Drawing.Point(272, 96);
			this.lblPorcVi.Name = "lblPorcVi";
			this.lblPorcVi.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPorcVi.Size = new System.Drawing.Size(41, 17);
			this.lblPorcVi.TabIndex = 25;
			this.lblPorcVi.Text = "0";
			// 
			// lblFactVencidas60
			// 
			this.lblFactVencidas60.BackColor = System.Drawing.SystemColors.Control;
			this.lblFactVencidas60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblFactVencidas60.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblFactVencidas60.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblFactVencidas60.Location = new System.Drawing.Point(152, 48);
			this.lblFactVencidas60.Name = "lblFactVencidas60";
			this.lblFactVencidas60.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFactVencidas60.Size = new System.Drawing.Size(113, 17);
			this.lblFactVencidas60.TabIndex = 24;
			this.lblFactVencidas60.Text = "0";
			// 
			// lblNumv60
			// 
			this.lblNumv60.BackColor = System.Drawing.SystemColors.Control;
			this.lblNumv60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblNumv60.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblNumv60.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNumv60.Location = new System.Drawing.Point(104, 48);
			this.lblNumv60.Name = "lblNumv60";
			this.lblNumv60.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblNumv60.Size = new System.Drawing.Size(41, 17);
			this.lblNumv60.TabIndex = 23;
			this.lblNumv60.Text = "0";
			// 
			// lblNumv30
			// 
			this.lblNumv30.BackColor = System.Drawing.SystemColors.Control;
			this.lblNumv30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblNumv30.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblNumv30.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNumv30.Location = new System.Drawing.Point(104, 24);
			this.lblNumv30.Name = "lblNumv30";
			this.lblNumv30.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblNumv30.Size = new System.Drawing.Size(41, 17);
			this.lblNumv30.TabIndex = 22;
			this.lblNumv30.Text = "0";
			// 
			// lblFactVencidas30
			// 
			this.lblFactVencidas30.BackColor = System.Drawing.SystemColors.Control;
			this.lblFactVencidas30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblFactVencidas30.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblFactVencidas30.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblFactVencidas30.Location = new System.Drawing.Point(152, 24);
			this.lblFactVencidas30.Name = "lblFactVencidas30";
			this.lblFactVencidas30.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFactVencidas30.Size = new System.Drawing.Size(113, 17);
			this.lblFactVencidas30.TabIndex = 21;
			this.lblFactVencidas30.Text = "0";
			// 
			// lblNumv90
			// 
			this.lblNumv90.BackColor = System.Drawing.SystemColors.Control;
			this.lblNumv90.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblNumv90.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblNumv90.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNumv90.Location = new System.Drawing.Point(104, 72);
			this.lblNumv90.Name = "lblNumv90";
			this.lblNumv90.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblNumv90.Size = new System.Drawing.Size(41, 17);
			this.lblNumv90.TabIndex = 20;
			this.lblNumv90.Text = "0";
			// 
			// lblFactVencidas90
			// 
			this.lblFactVencidas90.BackColor = System.Drawing.SystemColors.Control;
			this.lblFactVencidas90.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblFactVencidas90.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblFactVencidas90.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblFactVencidas90.Location = new System.Drawing.Point(152, 72);
			this.lblFactVencidas90.Name = "lblFactVencidas90";
			this.lblFactVencidas90.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFactVencidas90.Size = new System.Drawing.Size(113, 17);
			this.lblFactVencidas90.TabIndex = 19;
			this.lblFactVencidas90.Text = "0";
			// 
			// lblPorc30
			// 
			this.lblPorc30.BackColor = System.Drawing.SystemColors.Control;
			this.lblPorc30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPorc30.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblPorc30.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPorc30.Location = new System.Drawing.Point(272, 24);
			this.lblPorc30.Name = "lblPorc30";
			this.lblPorc30.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPorc30.Size = new System.Drawing.Size(41, 17);
			this.lblPorc30.TabIndex = 18;
			this.lblPorc30.Text = "0";
			// 
			// lblPorc60
			// 
			this.lblPorc60.BackColor = System.Drawing.SystemColors.Control;
			this.lblPorc60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPorc60.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblPorc60.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPorc60.Location = new System.Drawing.Point(272, 48);
			this.lblPorc60.Name = "lblPorc60";
			this.lblPorc60.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPorc60.Size = new System.Drawing.Size(41, 17);
			this.lblPorc60.TabIndex = 17;
			this.lblPorc60.Text = "0";
			// 
			// lblPorc90
			// 
			this.lblPorc90.BackColor = System.Drawing.SystemColors.Control;
			this.lblPorc90.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPorc90.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblPorc90.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPorc90.Location = new System.Drawing.Point(272, 72);
			this.lblPorc90.Name = "lblPorc90";
			this.lblPorc90.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPorc90.Size = new System.Drawing.Size(41, 17);
			this.lblPorc90.TabIndex = 16;
			this.lblPorc90.Text = "0";
			// 
			// frmOrden
			// 
			this.frmOrden.BackColor = System.Drawing.SystemColors.Control;
			this.frmOrden.Controls.Add(this.Option4);
			this.frmOrden.Controls.Add(this.Option3);
			this.frmOrden.Controls.Add(this.Option2);
			this.frmOrden.Controls.Add(this.Option1);
			this.frmOrden.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frmOrden.Location = new System.Drawing.Point(316, 358);
			this.frmOrden.Name = "frmOrden";
			this.frmOrden.Padding = new System.Windows.Forms.Padding(0);
			this.frmOrden.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frmOrden.Size = new System.Drawing.Size(193, 161);
			this.frmOrden.TabIndex = 4;
			this.frmOrden.TabStop = false;
			this.frmOrden.Text = "Orden";
			// 
			// Option4
			// 
			this.Option4.BackColor = System.Drawing.SystemColors.Control;
			this.Option4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Option4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Option4.Location = new System.Drawing.Point(24, 104);
			this.Option4.Name = "Option4";
			this.Option4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Option4.Size = new System.Drawing.Size(145, 25);
			this.Option4.TabIndex = 8;
			this.Option4.TabStop = true;
			this.Option4.Text = "Importe";
			this.Option4.UseVisualStyleBackColor = false;
			// 
			// Option3
			// 
			this.Option3.BackColor = System.Drawing.SystemColors.Control;
			this.Option3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Option3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Option3.Location = new System.Drawing.Point(24, 80);
			this.Option3.Name = "Option3";
			this.Option3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Option3.Size = new System.Drawing.Size(145, 25);
			this.Option3.TabIndex = 7;
			this.Option3.TabStop = true;
			this.Option3.Text = "Vigencia";
			this.Option3.UseVisualStyleBackColor = false;
			// 
			// Option2
			// 
			this.Option2.BackColor = System.Drawing.SystemColors.Control;
			this.Option2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Option2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Option2.Location = new System.Drawing.Point(24, 56);
			this.Option2.Name = "Option2";
			this.Option2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Option2.Size = new System.Drawing.Size(145, 25);
			this.Option2.TabIndex = 6;
			this.Option2.TabStop = true;
			this.Option2.Text = "Fecha";
			this.Option2.UseVisualStyleBackColor = false;
			// 
			// Option1
			// 
			this.Option1.BackColor = System.Drawing.SystemColors.Control;
			this.Option1.Checked = true;
			this.Option1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Option1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Option1.Location = new System.Drawing.Point(24, 32);
			this.Option1.Name = "Option1";
			this.Option1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Option1.Size = new System.Drawing.Size(145, 25);
			this.Option1.TabIndex = 5;
			this.Option1.TabStop = true;
			this.Option1.Text = "Cliente";
			this.Option1.UseVisualStyleBackColor = false;
			// 
			// cmbAño
			// 
			this.cmbAño.BackColor = System.Drawing.SystemColors.Window;
			this.cmbAño.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbAño.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbAño.Location = new System.Drawing.Point(343, 74);
			this.cmbAño.Name = "cmbAño";
			this.cmbAño.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbAño.Size = new System.Drawing.Size(145, 21);
			this.cmbAño.TabIndex = 1;
			// 
			// lblPorcentaje
			// 
			this.lblPorcentaje.BackColor = System.Drawing.SystemColors.Control;
			this.lblPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPorcentaje.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblPorcentaje.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPorcentaje.Location = new System.Drawing.Point(359, 22);
			this.lblPorcentaje.Name = "lblPorcentaje";
			this.lblPorcentaje.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPorcentaje.Size = new System.Drawing.Size(129, 49);
			this.lblPorcentaje.TabIndex = 9;
			this.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(271, 74);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(73, 21);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Desde el año";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tlActualizar,
			this.toolStripSeparator1,
			this.tlImprimir});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1011, 25);
			this.toolStrip1.TabIndex = 13;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tlActualizar
			// 
			this.tlActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlActualizar.Image = ((System.Drawing.Image)(resources.GetObject("tlActualizar.Image")));
			this.tlActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlActualizar.Name = "tlActualizar";
			this.tlActualizar.Size = new System.Drawing.Size(23, 22);
			this.tlActualizar.Text = "toolStripButton1";
			this.tlActualizar.ToolTipText = "Actualizar";
			this.tlActualizar.Click += new System.EventHandler(this.TlActualizarClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tlImprimir
			// 
			this.tlImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlImprimir.Enabled = false;
			this.tlImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tlImprimir.Image")));
			this.tlImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlImprimir.Name = "tlImprimir";
			this.tlImprimir.Size = new System.Drawing.Size(23, 22);
			this.tlImprimir.Text = "toolStripButton2";
			this.tlImprimir.ToolTipText = "Imprimir";
			this.tlImprimir.Click += new System.EventHandler(this.TlImprimirClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 28);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(853, 557);
			this.tabControl1.TabIndex = 14;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.gridDatos);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(845, 531);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Facturas Pendientes";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// gridDatos
			// 
			this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatos.Location = new System.Drawing.Point(0, 0);
			this.gridDatos.Name = "gridDatos";
			this.gridDatos.Size = new System.Drawing.Size(842, 527);
			this.gridDatos.TabIndex = 13;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.frmOrden);
			this.tabPage2.Controls.Add(this.Label1);
			this.tabPage2.Controls.Add(this.Frame1);
			this.tabPage2.Controls.Add(this.lblPorcentaje);
			this.tabPage2.Controls.Add(this.cmbAño);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(845, 531);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Informacion General";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// frmFactImpagas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1011, 734);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.toolStrip1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 30);
			this.Name = "frmFactImpagas";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Facturas Impagas";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Frame1.ResumeLayout(false);
			this.frmOrden.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.DataGridView gridDatos;
		private System.Windows.Forms.ToolStripButton tlImprimir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tlActualizar;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
			#endregion
	}
}
