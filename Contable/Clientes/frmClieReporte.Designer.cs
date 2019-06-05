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
	partial class frmClieReporte
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmClieReporte() : base()
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
		public System.Windows.Forms.Label lblactivos;
		public System.Windows.Forms.Label lblIntermedios;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label lblInactivos;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.Button cmdOrganizar;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.RadioButton Option5;
		public System.Windows.Forms.RadioButton Option4;
		public System.Windows.Forms.RadioButton Option3;
		public System.Windows.Forms.RadioButton Option2;
		public System.Windows.Forms.RadioButton Option1;
		public System.Windows.Forms.GroupBox Frame1;
		//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
		//Se puede modificar mediante el Diseñador de Windows Forms.
		//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.lblactivos = new System.Windows.Forms.Label();
			this.lblIntermedios = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.lblInactivos = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.cmdOrganizar = new System.Windows.Forms.Button();
			this.Command1 = new System.Windows.Forms.Button();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.Option5 = new System.Windows.Forms.RadioButton();
			this.Option4 = new System.Windows.Forms.RadioButton();
			this.Option3 = new System.Windows.Forms.RadioButton();
			this.Option2 = new System.Windows.Forms.RadioButton();
			this.Option1 = new System.Windows.Forms.RadioButton();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Frame2.SuspendLayout();
			this.Frame1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Frame2
			// 
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.lblactivos);
			this.Frame2.Controls.Add(this.lblIntermedios);
			this.Frame2.Controls.Add(this.Label1);
			this.Frame2.Controls.Add(this.Label2);
			this.Frame2.Controls.Add(this.lblInactivos);
			this.Frame2.Controls.Add(this.Label3);
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(808, 64);
			this.Frame2.Name = "Frame2";
			this.Frame2.Padding = new System.Windows.Forms.Padding(0);
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(201, 105);
			this.Frame2.TabIndex = 9;
			this.Frame2.TabStop = false;
			this.Frame2.Text = "Clientes";
			// 
			// lblactivos
			// 
			this.lblactivos.BackColor = System.Drawing.SystemColors.Control;
			this.lblactivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblactivos.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblactivos.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblactivos.Location = new System.Drawing.Point(120, 24);
			this.lblactivos.Name = "lblactivos";
			this.lblactivos.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblactivos.Size = new System.Drawing.Size(73, 17);
			this.lblactivos.TabIndex = 15;
			this.lblactivos.Text = "0";
			// 
			// lblIntermedios
			// 
			this.lblIntermedios.BackColor = System.Drawing.SystemColors.Control;
			this.lblIntermedios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblIntermedios.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblIntermedios.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblIntermedios.Location = new System.Drawing.Point(120, 48);
			this.lblIntermedios.Name = "lblIntermedios";
			this.lblIntermedios.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblIntermedios.Size = new System.Drawing.Size(73, 17);
			this.lblIntermedios.TabIndex = 14;
			this.lblIntermedios.Text = "0";
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
			this.Label1.Size = new System.Drawing.Size(97, 17);
			this.Label1.TabIndex = 13;
			this.Label1.Text = "Activos";
			// 
			// Label2
			// 
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(8, 48);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(97, 17);
			this.Label2.TabIndex = 12;
			this.Label2.Text = "Intermedios";
			// 
			// lblInactivos
			// 
			this.lblInactivos.BackColor = System.Drawing.SystemColors.Control;
			this.lblInactivos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblInactivos.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblInactivos.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblInactivos.Location = new System.Drawing.Point(120, 72);
			this.lblInactivos.Name = "lblInactivos";
			this.lblInactivos.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblInactivos.Size = new System.Drawing.Size(73, 17);
			this.lblInactivos.TabIndex = 11;
			this.lblInactivos.Text = "0";
			// 
			// Label3
			// 
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(8, 72);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(97, 17);
			this.Label3.TabIndex = 10;
			this.Label3.Text = "Inactivos";
			// 
			// cmdOrganizar
			// 
			this.cmdOrganizar.BackColor = System.Drawing.SystemColors.Control;
			this.cmdOrganizar.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdOrganizar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdOrganizar.Location = new System.Drawing.Point(824, 456);
			this.cmdOrganizar.Name = "cmdOrganizar";
			this.cmdOrganizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdOrganizar.Size = new System.Drawing.Size(153, 49);
			this.cmdOrganizar.TabIndex = 8;
			this.cmdOrganizar.Text = "Organizar";
			this.cmdOrganizar.UseVisualStyleBackColor = false;
			// 
			// Command1
			// 
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(824, 384);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(153, 41);
			this.Command1.TabIndex = 7;
			this.Command1.Text = "Imprimir Reporte";
			this.Command1.UseVisualStyleBackColor = false;
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.Option5);
			this.Frame1.Controls.Add(this.Option4);
			this.Frame1.Controls.Add(this.Option3);
			this.Frame1.Controls.Add(this.Option2);
			this.Frame1.Controls.Add(this.Option1);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(816, 184);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(193, 185);
			this.Frame1.TabIndex = 1;
			this.Frame1.TabStop = false;
			// 
			// Option5
			// 
			this.Option5.BackColor = System.Drawing.SystemColors.Control;
			this.Option5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Option5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Option5.Location = new System.Drawing.Point(24, 144);
			this.Option5.Name = "Option5";
			this.Option5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Option5.Size = new System.Drawing.Size(153, 25);
			this.Option5.TabIndex = 6;
			this.Option5.TabStop = true;
			this.Option5.Text = "Importe Final";
			this.Option5.UseVisualStyleBackColor = false;
			// 
			// Option4
			// 
			this.Option4.BackColor = System.Drawing.SystemColors.Control;
			this.Option4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Option4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Option4.Location = new System.Drawing.Point(24, 112);
			this.Option4.Name = "Option4";
			this.Option4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Option4.Size = new System.Drawing.Size(153, 25);
			this.Option4.TabIndex = 5;
			this.Option4.TabStop = true;
			this.Option4.Text = "Fecha";
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
			this.Option3.Size = new System.Drawing.Size(153, 25);
			this.Option3.TabIndex = 4;
			this.Option3.TabStop = true;
			this.Option3.Text = "Provincia";
			this.Option3.UseVisualStyleBackColor = false;
			// 
			// Option2
			// 
			this.Option2.BackColor = System.Drawing.SystemColors.Control;
			this.Option2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Option2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Option2.Location = new System.Drawing.Point(24, 48);
			this.Option2.Name = "Option2";
			this.Option2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Option2.Size = new System.Drawing.Size(153, 25);
			this.Option2.TabIndex = 3;
			this.Option2.TabStop = true;
			this.Option2.Text = "Localidad";
			this.Option2.UseVisualStyleBackColor = false;
			// 
			// Option1
			// 
			this.Option1.BackColor = System.Drawing.SystemColors.Control;
			this.Option1.Checked = true;
			this.Option1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Option1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Option1.Location = new System.Drawing.Point(24, 16);
			this.Option1.Name = "Option1";
			this.Option1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Option1.Size = new System.Drawing.Size(153, 25);
			this.Option1.TabIndex = 2;
			this.Option1.TabStop = true;
			this.Option1.Text = "Cliente";
			this.Option1.UseVisualStyleBackColor = false;
			// 
			// DataGridView1
			// 
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(13, 28);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new System.Drawing.Size(690, 409);
			this.DataGridView1.TabIndex = 10;
			// 
			// frmClieReporte
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1016, 734);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.cmdOrganizar);
			this.Controls.Add(this.Command1);
			this.Controls.Add(this.Frame1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 26);
			this.Name = "frmClieReporte";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Reporte Por Cliente";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Frame2.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
			#endregion
		internal System.Windows.Forms.DataGridView DataGridView1;
	}
}
