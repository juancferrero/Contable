
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	
	partial class frmContadorDepositosBancarios
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmContadorDepositosBancarios() : base()
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
		//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
		//Se puede modificar mediante el Diseñador de Windows Forms.
		//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// DataGridView1
			// 
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(12, 12);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new System.Drawing.Size(240, 150);
			this.DataGridView1.TabIndex = 0;
			// 
			// frmContadorDepositosBancarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(563, 405);
			this.Controls.Add(this.DataGridView1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 30);
			this.Name = "frmContadorDepositosBancarios";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Listado de Depositos";
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
			#endregion
		internal System.Windows.Forms.DataGridView DataGridView1;
	}
}
