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
	partial class frmRepVentas
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmRepVentas() : base()
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
		public System.Windows.Forms.ComboBox cmbaño;
		public System.Windows.Forms.Label Label1;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepVentas));
			this.cmbaño = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tlActualizar = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripSeparator();
			this.tlImprimir = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbaño
			// 
			this.cmbaño.BackColor = System.Drawing.SystemColors.Window;
			this.cmbaño.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbaño.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbaño.Location = new System.Drawing.Point(54, 46);
			this.cmbaño.Name = "cmbaño";
			this.cmbaño.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbaño.Size = new System.Drawing.Size(145, 21);
			this.cmbaño.TabIndex = 5;
			this.cmbaño.DropDown += new System.EventHandler(this.CmbañoDropDown);
			this.cmbaño.SelectedIndexChanged += new System.EventHandler(this.CmbañoSelectedIndexChanged);
			this.cmbaño.DropDownClosed += new System.EventHandler(this.CmbañoDropDownClosed);
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(14, 46);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(33, 17);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Año";
			// 
			// gridDatos
			// 
			this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatos.Location = new System.Drawing.Point(30, 73);
			this.gridDatos.Name = "gridDatos";
			this.gridDatos.Size = new System.Drawing.Size(905, 637);
			this.gridDatos.TabIndex = 23;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tlActualizar,
			this.toolStripDropDownButton1,
			this.tlImprimir});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
			this.toolStrip1.TabIndex = 24;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tlActualizar
			// 
			this.tlActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlActualizar.Image = ((System.Drawing.Image)(resources.GetObject("tlActualizar.Image")));
			this.tlActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlActualizar.Name = "tlActualizar";
			this.tlActualizar.Size = new System.Drawing.Size(23, 22);
			this.tlActualizar.Text = "Actualizar";
			this.tlActualizar.Click += new System.EventHandler(this.TlActualizarClick);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(6, 25);
			// 
			// tlImprimir
			// 
			this.tlImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlImprimir.Enabled = false;
			this.tlImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tlImprimir.Image")));
			this.tlImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlImprimir.Name = "tlImprimir";
			this.tlImprimir.Size = new System.Drawing.Size(23, 22);
			this.tlImprimir.Text = "Imprimir";
			// 
			// frmRepVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1016, 734);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.gridDatos);
			this.Controls.Add(this.cmbaño);
			this.Controls.Add(this.Label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 26);
			this.Name = "frmRepVentas";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Informe Anual de Ventas y Cobranzas";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.DataGridView gridDatos;
		private System.Windows.Forms.ToolStripButton tlImprimir;
		private System.Windows.Forms.ToolStripSeparator toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripButton tlActualizar;
		private System.Windows.Forms.ToolStrip toolStrip1;
			#endregion
	}
}
