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
	partial class frmClieReporteDeduda
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmClieReporteDeduda() : base()
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
		public System.Windows.Forms.ComboBox cmbRazonSocial;
		public System.Windows.Forms.RadioButton optTodo;
		public System.Windows.Forms.RadioButton optAno;
		public System.Windows.Forms.RadioButton optMes;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.Button cmdImprimir;
		//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
		//Se puede modificar mediante el Diseñador de Windows Forms.
		//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.optTodo = new System.Windows.Forms.RadioButton();
			this.optAno = new System.Windows.Forms.RadioButton();
			this.optMes = new System.Windows.Forms.RadioButton();
			this.cmdImprimir = new System.Windows.Forms.Button();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Frame1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbRazonSocial
			// 
			this.cmbRazonSocial.BackColor = System.Drawing.Color.White;
			this.cmbRazonSocial.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbRazonSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRazonSocial.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbRazonSocial.Location = new System.Drawing.Point(8, 16);
			this.cmbRazonSocial.Name = "cmbRazonSocial";
			this.cmbRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbRazonSocial.Size = new System.Drawing.Size(225, 21);
			this.cmbRazonSocial.Sorted = true;
			this.cmbRazonSocial.TabIndex = 6;
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.optTodo);
			this.Frame1.Controls.Add(this.optAno);
			this.Frame1.Controls.Add(this.optMes);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(696, 80);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(185, 201);
			this.Frame1.TabIndex = 2;
			this.Frame1.TabStop = false;
			this.Frame1.Text = "Periodo de Tiempo";
			// 
			// optTodo
			// 
			this.optTodo.BackColor = System.Drawing.SystemColors.Control;
			this.optTodo.Checked = true;
			this.optTodo.Cursor = System.Windows.Forms.Cursors.Default;
			this.optTodo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optTodo.Location = new System.Drawing.Point(24, 152);
			this.optTodo.Name = "optTodo";
			this.optTodo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optTodo.Size = new System.Drawing.Size(129, 33);
			this.optTodo.TabIndex = 5;
			this.optTodo.TabStop = true;
			this.optTodo.Text = "Todo";
			this.optTodo.UseVisualStyleBackColor = false;
			// 
			// optAno
			// 
			this.optAno.BackColor = System.Drawing.SystemColors.Control;
			this.optAno.Cursor = System.Windows.Forms.Cursors.Default;
			this.optAno.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optAno.Location = new System.Drawing.Point(24, 100);
			this.optAno.Name = "optAno";
			this.optAno.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optAno.Size = new System.Drawing.Size(129, 33);
			this.optAno.TabIndex = 4;
			this.optAno.TabStop = true;
			this.optAno.Text = "Año";
			this.optAno.UseVisualStyleBackColor = false;
			// 
			// optMes
			// 
			this.optMes.BackColor = System.Drawing.SystemColors.Control;
			this.optMes.Cursor = System.Windows.Forms.Cursors.Default;
			this.optMes.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optMes.Location = new System.Drawing.Point(24, 48);
			this.optMes.Name = "optMes";
			this.optMes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optMes.Size = new System.Drawing.Size(129, 33);
			this.optMes.TabIndex = 3;
			this.optMes.TabStop = true;
			this.optMes.Text = "Mes";
			this.optMes.UseVisualStyleBackColor = false;
			// 
			// cmdImprimir
			// 
			this.cmdImprimir.BackColor = System.Drawing.SystemColors.Control;
			this.cmdImprimir.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdImprimir.Location = new System.Drawing.Point(768, 387);
			this.cmdImprimir.Name = "cmdImprimir";
			this.cmdImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdImprimir.Size = new System.Drawing.Size(81, 33);
			this.cmdImprimir.TabIndex = 1;
			this.cmdImprimir.Text = "Imprimir";
			this.cmdImprimir.UseVisualStyleBackColor = false;
			// 
			// DataGridView1
			// 
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(13, 80);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new System.Drawing.Size(612, 374);
			this.DataGridView1.TabIndex = 7;
			// 
			// frmClieReporteDeduda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1370, 750);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.cmbRazonSocial);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.cmdImprimir);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 30);
			this.Name = "frmClieReporteDeduda";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Cuenta  Corriente";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Frame1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
			#endregion
		internal System.Windows.Forms.DataGridView DataGridView1;
	}
}
