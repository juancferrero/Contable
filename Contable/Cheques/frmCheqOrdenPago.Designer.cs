
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	
	partial class frmCheqOrdenPago
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmCheqOrdenPago() : base()
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
		public System.Windows.Forms.Button cmdNoDepositar;
		public System.Windows.Forms.Button cmdGuardar;
		public System.Windows.Forms.Button cmdImprimir;
		public System.Windows.Forms.Label Label1;
		//public Microsoft.VisualBasic.PowerPacks.LineShape Line1;
		//public Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.cmdNoDepositar = new System.Windows.Forms.Button();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.cmdImprimir = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.DataGridView2 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdNoDepositar
			// 
			this.cmdNoDepositar.BackColor = System.Drawing.SystemColors.Control;
			this.cmdNoDepositar.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdNoDepositar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdNoDepositar.Location = new System.Drawing.Point(472, 560);
			this.cmdNoDepositar.Name = "cmdNoDepositar";
			this.cmdNoDepositar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdNoDepositar.Size = new System.Drawing.Size(81, 33);
			this.cmdNoDepositar.TabIndex = 5;
			this.cmdNoDepositar.Text = "No Depositar";
			this.cmdNoDepositar.UseVisualStyleBackColor = false;
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.BackColor = System.Drawing.SystemColors.Control;
			this.cmdGuardar.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdGuardar.Location = new System.Drawing.Point(328, 560);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdGuardar.Size = new System.Drawing.Size(81, 33);
			this.cmdGuardar.TabIndex = 3;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = false;
			// 
			// cmdImprimir
			// 
			this.cmdImprimir.BackColor = System.Drawing.SystemColors.Control;
			this.cmdImprimir.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdImprimir.Enabled = false;
			this.cmdImprimir.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdImprimir.Location = new System.Drawing.Point(592, 560);
			this.cmdImprimir.Name = "cmdImprimir";
			this.cmdImprimir.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdImprimir.Size = new System.Drawing.Size(81, 33);
			this.cmdImprimir.TabIndex = 2;
			this.cmdImprimir.Text = "Imprimir";
			this.cmdImprimir.UseVisualStyleBackColor = false;
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(32, 568);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(209, 25);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Label1";
			// 
			// DataGridView1
			// 
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(32, 12);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new System.Drawing.Size(240, 150);
			this.DataGridView1.TabIndex = 7;
			// 
			// DataGridView2
			// 
			this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView2.Location = new System.Drawing.Point(32, 199);
			this.DataGridView2.Name = "DataGridView2";
			this.DataGridView2.Size = new System.Drawing.Size(240, 150);
			this.DataGridView2.TabIndex = 7;
			// 
			// frmCheqOrdenPago
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1016, 734);
			this.Controls.Add(this.DataGridView2);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.cmdNoDepositar);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.cmdImprimir);
			this.Controls.Add(this.Label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 30);
			this.Name = "frmCheqOrdenPago";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Orden de Pago";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
			this.ResumeLayout(false);
		}
		internal System.Windows.Forms.DataGridView DataGridView1;
			#endregion
		internal System.Windows.Forms.DataGridView DataGridView2;
	}
}
