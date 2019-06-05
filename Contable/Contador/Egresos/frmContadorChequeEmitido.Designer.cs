
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	
	partial class frmContadorChequeEmitido
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmContadorChequeEmitido() : base()
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
				//if ((components != null)) {
				//	components.Dispose();
				//}
			}
			base.Dispose(Disposing);
		}
//Requerido por el Diseñador de Windows Forms
		//private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ComboBox cmbAno;
		public System.Windows.Forms.ComboBox cmbBanco;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.ComboBox cmbMes;
		//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
		//Se puede modificar mediante el Diseñador de Windows Forms.
		//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.cmbAno = new System.Windows.Forms.ComboBox();
			this.cmbBanco = new System.Windows.Forms.ComboBox();
			this.Command1 = new System.Windows.Forms.Button();
			this.cmbMes = new System.Windows.Forms.ComboBox();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbAno
			// 
			this.cmbAno.BackColor = System.Drawing.SystemColors.Window;
			this.cmbAno.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbAno.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbAno.Location = new System.Drawing.Point(384, 96);
			this.cmbAno.Name = "cmbAno";
			this.cmbAno.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbAno.Size = new System.Drawing.Size(121, 21);
			this.cmbAno.TabIndex = 4;
			this.cmbAno.Text = "cmbAno";
			// 
			// cmbBanco
			// 
			this.cmbBanco.BackColor = System.Drawing.SystemColors.Window;
			this.cmbBanco.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbBanco.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbBanco.Location = new System.Drawing.Point(24, 96);
			this.cmbBanco.Name = "cmbBanco";
			this.cmbBanco.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbBanco.Size = new System.Drawing.Size(137, 21);
			this.cmbBanco.TabIndex = 3;
			this.cmbBanco.Text = "Banco";
			// 
			// Command1
			// 
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(520, 152);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(113, 25);
			this.Command1.TabIndex = 2;
			this.Command1.Text = "Command1";
			this.Command1.UseVisualStyleBackColor = false;
			// 
			// cmbMes
			// 
			this.cmbMes.BackColor = System.Drawing.SystemColors.Window;
			this.cmbMes.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbMes.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbMes.Location = new System.Drawing.Point(168, 96);
			this.cmbMes.Name = "cmbMes";
			this.cmbMes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbMes.Size = new System.Drawing.Size(201, 21);
			this.cmbMes.TabIndex = 1;
			this.cmbMes.Text = "Mes";
			// 
			// DataGridView1
			// 
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(260, 242);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new System.Drawing.Size(240, 150);
			this.DataGridView1.TabIndex = 5;
			// 
			// frmContadorChequeEmitido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1016, 734);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.cmbAno);
			this.Controls.Add(this.cmbBanco);
			this.Controls.Add(this.Command1);
			this.Controls.Add(this.cmbMes);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 30);
			this.Name = "frmContadorChequeEmitido";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Form2";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
			#endregion
		internal System.Windows.Forms.DataGridView DataGridView1;
	}
}
