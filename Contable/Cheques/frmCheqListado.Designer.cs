
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable.Cheques
{
	
	partial class frmCheqListado
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmCheqListado() : base()
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
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTip1;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheqListado));
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsRefrescar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsImprimir = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridDatos
			// 
			this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatos.Location = new System.Drawing.Point(12, 28);
			this.gridDatos.Name = "gridDatos";
			this.gridDatos.Size = new System.Drawing.Size(1180, 455);
			this.gridDatos.TabIndex = 14;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsRefrescar,
			this.toolStripSeparator1,
			this.tsImprimir,
			this.toolStripSeparator2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1227, 25);
			this.toolStrip1.TabIndex = 17;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsRefrescar
			// 
			this.tsRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("tsRefrescar.Image")));
			this.tsRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsRefrescar.Name = "tsRefrescar";
			this.tsRefrescar.Size = new System.Drawing.Size(23, 22);
			this.tsRefrescar.Text = "toolStripButton1";
			this.tsRefrescar.ToolTipText = "Refrescar";
			this.tsRefrescar.Click += new System.EventHandler(this.TsRefrescarClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsImprimir
			// 
			this.tsImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsImprimir.Image")));
			this.tsImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsImprimir.Name = "tsImprimir";
			this.tsImprimir.Size = new System.Drawing.Size(23, 22);
			this.tsImprimir.Text = "toolStripButton2";
			this.tsImprimir.ToolTipText = "Imprimir Listado";
			this.tsImprimir.Click += new System.EventHandler(this.TsImprimirClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// frmCheqListado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1227, 746);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.gridDatos);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 30);
			this.Name = "frmCheqListado";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Listado De Cheques en Cartera";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmCheqListadoLoad);
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.DataGridView gridDatos;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsImprimir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsRefrescar;
		private System.Windows.Forms.ToolStrip toolStrip1;
			#endregion
	}
}
