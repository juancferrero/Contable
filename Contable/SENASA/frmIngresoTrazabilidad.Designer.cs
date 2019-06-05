/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 22/01/2015
 * Hora: 05:28 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Contable.SENASA
{
	partial class frmIngresoTrazabilidad
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoTrazabilidad));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tlNuevos = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.tlAgregarMercaderia = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tlEditar = new System.Windows.Forms.ToolStripButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbDescripcion = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLote = new System.Windows.Forms.TextBox();
			this.txtNroFactura = new System.Windows.Forms.TextBox();
			this.txtNroGTIN = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtSerieFinal = new System.Windows.Forms.TextBox();
			this.txtSerieInicio = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.toolStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tlNuevos,
			this.toolStripButton2,
			this.tlAgregarMercaderia,
			this.toolStripSeparator2,
			this.tlEditar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1370, 25);
			this.toolStrip1.TabIndex = 21;
			// 
			// tlNuevos
			// 
			this.tlNuevos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlNuevos.Image = ((System.Drawing.Image)(resources.GetObject("tlNuevos.Image")));
			this.tlNuevos.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlNuevos.Name = "tlNuevos";
			this.tlNuevos.Size = new System.Drawing.Size(23, 22);
			this.tlNuevos.Text = "Nuevo";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton2.ToolTipText = "Modificar Cajas";
			// 
			// tlAgregarMercaderia
			// 
			this.tlAgregarMercaderia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlAgregarMercaderia.Image = ((System.Drawing.Image)(resources.GetObject("tlAgregarMercaderia.Image")));
			this.tlAgregarMercaderia.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlAgregarMercaderia.Name = "tlAgregarMercaderia";
			this.tlAgregarMercaderia.Size = new System.Drawing.Size(23, 22);
			this.tlAgregarMercaderia.Text = "Agregar";
			this.tlAgregarMercaderia.ToolTipText = "Agregar Mercaderia a la base";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tlEditar
			// 
			this.tlEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlEditar.Image = ((System.Drawing.Image)(resources.GetObject("tlEditar.Image")));
			this.tlEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlEditar.Name = "tlEditar";
			this.tlEditar.Size = new System.Drawing.Size(23, 22);
			this.tlEditar.ToolTipText = "Editar DB";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cmbDescripcion);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtLote);
			this.groupBox1.Controls.Add(this.txtNroFactura);
			this.groupBox1.Controls.Add(this.txtNroGTIN);
			this.groupBox1.Location = new System.Drawing.Point(67, 62);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 325);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Producto";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(24, 33);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 21);
			this.label8.TabIndex = 29;
			this.label8.Text = "Descripcion";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(53, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 20);
			this.label3.TabIndex = 32;
			this.label3.Text = "Lote";
			// 
			// cmbDescripcion
			// 
			this.cmbDescripcion.FormattingEnabled = true;
			this.cmbDescripcion.Location = new System.Drawing.Point(100, 30);
			this.cmbDescripcion.Name = "cmbDescripcion";
			this.cmbDescripcion.Size = new System.Drawing.Size(238, 21);
			this.cmbDescripcion.TabIndex = 25;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(92, 244);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 17);
			this.label2.TabIndex = 31;
			this.label2.Text = "Nro Factura";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(438, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 17);
			this.label1.TabIndex = 30;
			this.label1.Text = "GTIN";
			// 
			// txtLote
			// 
			this.txtLote.Location = new System.Drawing.Point(100, 71);
			this.txtLote.Name = "txtLote";
			this.txtLote.Size = new System.Drawing.Size(238, 20);
			this.txtLote.TabIndex = 28;
			// 
			// txtNroFactura
			// 
			this.txtNroFactura.Location = new System.Drawing.Point(186, 241);
			this.txtNroFactura.Name = "txtNroFactura";
			this.txtNroFactura.Size = new System.Drawing.Size(100, 20);
			this.txtNroFactura.TabIndex = 27;
			// 
			// txtNroGTIN
			// 
			this.txtNroGTIN.Location = new System.Drawing.Point(482, 30);
			this.txtNroGTIN.Name = "txtNroGTIN";
			this.txtNroGTIN.Size = new System.Drawing.Size(234, 20);
			this.txtNroGTIN.TabIndex = 26;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtSerieFinal);
			this.groupBox2.Controls.Add(this.txtSerieInicio);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(459, 136);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(288, 125);
			this.groupBox2.TabIndex = 37;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Serie";
			// 
			// txtSerieFinal
			// 
			this.txtSerieFinal.Location = new System.Drawing.Point(100, 69);
			this.txtSerieFinal.Name = "txtSerieFinal";
			this.txtSerieFinal.Size = new System.Drawing.Size(100, 20);
			this.txtSerieFinal.TabIndex = 40;
			// 
			// txtSerieInicio
			// 
			this.txtSerieInicio.Location = new System.Drawing.Point(100, 31);
			this.txtSerieInicio.Name = "txtSerieInicio";
			this.txtSerieInicio.Size = new System.Drawing.Size(100, 20);
			this.txtSerieInicio.TabIndex = 39;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 69);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 17);
			this.label5.TabIndex = 38;
			this.label5.Text = "Serie Final";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 17);
			this.label4.TabIndex = 37;
			this.label4.Text = "Serie Inicio";
			// 
			// frmIngresoTrazabilidad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 750);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmIngresoTrazabilidad";
			this.Text = "frmIngresoTrazabilidad";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripButton tlEditar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tlAgregarMercaderia;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton tlNuevos;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtSerieFinal;
		private System.Windows.Forms.TextBox txtSerieInicio;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbDescripcion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLote;
		private System.Windows.Forms.TextBox txtNroFactura;
		private System.Windows.Forms.TextBox txtNroGTIN;
	}
}
