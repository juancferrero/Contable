/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 09/09/2014
 * Hora: 11:01 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Contable.Cheques
{
	partial class frmCheqOp
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheqOp));
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.dtpDesde = new System.Windows.Forms.DateTimePicker();
			this.dtpHasta = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tlRefrescar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tlNuevo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tlEliminar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tlEditar = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridDatos
			// 
			this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatos.Location = new System.Drawing.Point(12, 104);
			this.gridDatos.Name = "gridDatos";
			this.gridDatos.Size = new System.Drawing.Size(1233, 407);
			this.gridDatos.TabIndex = 0;
			// 
			// dtpDesde
			// 
			this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDesde.Location = new System.Drawing.Point(95, 53);
			this.dtpDesde.Name = "dtpDesde";
			this.dtpDesde.Size = new System.Drawing.Size(104, 20);
			this.dtpDesde.TabIndex = 1;
			// 
			// dtpHasta
			// 
			this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpHasta.Location = new System.Drawing.Point(307, 53);
			this.dtpHasta.Name = "dtpHasta";
			this.dtpHasta.Size = new System.Drawing.Size(104, 20);
			this.dtpHasta.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(29, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Inicio";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(241, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Fin";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tlRefrescar,
									this.toolStripSeparator1,
									this.tlNuevo,
									this.toolStripSeparator2,
									this.tlEliminar,
									this.toolStripSeparator3,
									this.tlEditar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1301, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tlRefrescar
			// 
			this.tlRefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("tlRefrescar.Image")));
			this.tlRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlRefrescar.Name = "tlRefrescar";
			this.tlRefrescar.Size = new System.Drawing.Size(23, 22);
			this.tlRefrescar.Text = "toolStripButton1";
			this.tlRefrescar.ToolTipText = "Refrescar";
			this.tlRefrescar.Click += new System.EventHandler(this.TlRefrescarClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tlNuevo
			// 
			this.tlNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlNuevo.Enabled = false;
			this.tlNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tlNuevo.Image")));
			this.tlNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlNuevo.Name = "tlNuevo";
			this.tlNuevo.Size = new System.Drawing.Size(23, 22);
			this.tlNuevo.Text = "toolStripButton2";
			this.tlNuevo.ToolTipText = "Nuevo";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tlEliminar
			// 
			this.tlEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tlEliminar.Image")));
			this.tlEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlEliminar.Name = "tlEliminar";
			this.tlEliminar.Size = new System.Drawing.Size(23, 22);
			this.tlEliminar.Text = "toolStripButton3";
			this.tlEliminar.ToolTipText = "Eliminar";
			this.tlEliminar.Click += new System.EventHandler(this.TlEliminarClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// tlEditar
			// 
			this.tlEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlEditar.Image = ((System.Drawing.Image)(resources.GetObject("tlEditar.Image")));
			this.tlEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlEditar.Name = "tlEditar";
			this.tlEditar.Size = new System.Drawing.Size(23, 22);
			this.tlEditar.Text = "toolStripDropDownButton1";
			this.tlEditar.ToolTipText = "Editar";
			this.tlEditar.Click += new System.EventHandler(this.TlEditarClick);
			// 
			// frmCheqOp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1301, 570);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpHasta);
			this.Controls.Add(this.dtpDesde);
			this.Controls.Add(this.gridDatos);
			this.Name = "frmCheqOp";
			this.Text = "Operatoria con Cheques";
			this.Load += new System.EventHandler(this.FrmCheqOpLoad);
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton tlEditar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tlEliminar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tlNuevo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tlRefrescar;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpHasta;
		private System.Windows.Forms.DateTimePicker dtpDesde;
		private System.Windows.Forms.DataGridView gridDatos;
	}
}
