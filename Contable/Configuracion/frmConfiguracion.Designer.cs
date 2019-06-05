/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 07/07/2014
 * Hora: 08:00 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Contable.Configuracion
{
	partial class frmConfiguracion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
			this.txtBaseDeDatos = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBaseProduccion = new System.Windows.Forms.TextBox();
			this.txtBasePruebas = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBDTrazabilidad = new System.Windows.Forms.TextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.txtNroCAI = new System.Windows.Forms.TextBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.checkFacturarAFIP = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tabCheques = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBaseChequesProduccion = new System.Windows.Forms.TextBox();
			this.textBaseChequesPrueba = new System.Windows.Forms.TextBox();
			this.textBaseCheques = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsGuardar = new System.Windows.Forms.ToolStripButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tabCheques.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtBaseDeDatos
			// 
			this.txtBaseDeDatos.Location = new System.Drawing.Point(162, 19);
			this.txtBaseDeDatos.Name = "txtBaseDeDatos";
			this.txtBaseDeDatos.Size = new System.Drawing.Size(513, 20);
			this.txtBaseDeDatos.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Base de Datos";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabCheques);
			this.tabControl1.Location = new System.Drawing.Point(0, 28);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1018, 440);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.txtBaseProduccion);
			this.tabPage1.Controls.Add(this.txtBasePruebas);
			this.tabPage1.Controls.Add(this.txtBaseDeDatos);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1010, 414);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "General";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(150, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Base de Datos - Produccion";
			this.label4.Click += new System.EventHandler(this.Label3Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Base de Datos - Prueba";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// txtBaseProduccion
			// 
			this.txtBaseProduccion.Location = new System.Drawing.Point(162, 71);
			this.txtBaseProduccion.Name = "txtBaseProduccion";
			this.txtBaseProduccion.Size = new System.Drawing.Size(513, 20);
			this.txtBaseProduccion.TabIndex = 0;
			// 
			// txtBasePruebas
			// 
			this.txtBasePruebas.Location = new System.Drawing.Point(162, 45);
			this.txtBasePruebas.Name = "txtBasePruebas";
			this.txtBasePruebas.Size = new System.Drawing.Size(513, 20);
			this.txtBasePruebas.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.txtBDTrazabilidad);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1010, 414);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Trazabilidad";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Base Trazabilidad";
			// 
			// txtBDTrazabilidad
			// 
			this.txtBDTrazabilidad.Location = new System.Drawing.Point(113, 22);
			this.txtBDTrazabilidad.Name = "txtBDTrazabilidad";
			this.txtBDTrazabilidad.Size = new System.Drawing.Size(513, 20);
			this.txtBDTrazabilidad.TabIndex = 2;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.txtNroCAI);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1010, 414);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Remitos";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Base CAI";
			// 
			// txtNroCAI
			// 
			this.txtNroCAI.Location = new System.Drawing.Point(122, 31);
			this.txtNroCAI.Name = "txtNroCAI";
			this.txtNroCAI.Size = new System.Drawing.Size(513, 20);
			this.txtNroCAI.TabIndex = 4;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.groupBox2);
			this.tabPage4.Controls.Add(this.groupBox1);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(1010, 414);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "AFIP";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.checkFacturarAFIP);
			this.groupBox2.Location = new System.Drawing.Point(398, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 100);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Control de Facturacion AFIP";
			// 
			// checkFacturarAFIP
			// 
			this.checkFacturarAFIP.Location = new System.Drawing.Point(6, 19);
			this.checkFacturarAFIP.Name = "checkFacturarAFIP";
			this.checkFacturarAFIP.Size = new System.Drawing.Size(104, 24);
			this.checkFacturarAFIP.TabIndex = 0;
			this.checkFacturarAFIP.Text = "¿Facturar?";
			this.checkFacturarAFIP.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(384, 169);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Certificados";
			// 
			// tabCheques
			// 
			this.tabCheques.Controls.Add(this.label6);
			this.tabCheques.Controls.Add(this.label7);
			this.tabCheques.Controls.Add(this.label8);
			this.tabCheques.Controls.Add(this.textBaseChequesProduccion);
			this.tabCheques.Controls.Add(this.textBaseChequesPrueba);
			this.tabCheques.Controls.Add(this.textBaseCheques);
			this.tabCheques.Location = new System.Drawing.Point(4, 22);
			this.tabCheques.Name = "tabCheques";
			this.tabCheques.Size = new System.Drawing.Size(1010, 414);
			this.tabCheques.TabIndex = 4;
			this.tabCheques.Text = "Cheques";
			this.tabCheques.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 85);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(150, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Base de Datos - Produccion";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 59);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(150, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "Base de Datos - Prueba";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 33);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(150, 20);
			this.label8.TabIndex = 7;
			this.label8.Text = "Base de Datos";
			// 
			// textBaseChequesProduccion
			// 
			this.textBaseChequesProduccion.Location = new System.Drawing.Point(164, 85);
			this.textBaseChequesProduccion.Name = "textBaseChequesProduccion";
			this.textBaseChequesProduccion.Size = new System.Drawing.Size(513, 20);
			this.textBaseChequesProduccion.TabIndex = 2;
			// 
			// textBaseChequesPrueba
			// 
			this.textBaseChequesPrueba.Location = new System.Drawing.Point(164, 59);
			this.textBaseChequesPrueba.Name = "textBaseChequesPrueba";
			this.textBaseChequesPrueba.Size = new System.Drawing.Size(513, 20);
			this.textBaseChequesPrueba.TabIndex = 3;
			// 
			// textBaseCheques
			// 
			this.textBaseCheques.Location = new System.Drawing.Point(164, 33);
			this.textBaseCheques.Name = "textBaseCheques";
			this.textBaseCheques.Size = new System.Drawing.Size(513, 20);
			this.textBaseCheques.TabIndex = 4;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsGuardar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1077, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsGuardar
			// 
			this.tsGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsGuardar.Image")));
			this.tsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsGuardar.Name = "tsGuardar";
			this.tsGuardar.Size = new System.Drawing.Size(69, 22);
			this.tsGuardar.Text = "Guardar";
			this.tsGuardar.Click += new System.EventHandler(this.TsGuardarClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.checkBox3);
			this.groupBox3.Controls.Add(this.checkBox2);
			this.groupBox3.Controls.Add(this.checkBox1);
			this.groupBox3.Enabled = false;
			this.groupBox3.Location = new System.Drawing.Point(8, 137);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(288, 117);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Generales";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(6, 28);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Buscar Pedidos";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(6, 57);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 24);
			this.checkBox2.TabIndex = 2;
			this.checkBox2.Text = "Buscar Cheques";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(6, 87);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(104, 24);
			this.checkBox3.TabIndex = 3;
			this.checkBox3.Text = "Mails";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// frmConfiguracion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1077, 596);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.tabControl1);
			this.Name = "frmConfiguracion";
			this.Text = "frmConfiguracion";
			this.Load += new System.EventHandler(this.FrmConfiguracionLoad);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tabCheques.ResumeLayout(false);
			this.tabCheques.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.TextBox txtNroCAI;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TextBox txtBaseProduccion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolStripButton tsGuardar;
		private System.Windows.Forms.TextBox txtBasePruebas;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.TextBox txtBDTrazabilidad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBaseDeDatos;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkFacturarAFIP;
		private System.Windows.Forms.TabPage tabCheques;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBaseChequesProduccion;
		private System.Windows.Forms.TextBox textBaseChequesPrueba;
		private System.Windows.Forms.TextBox textBaseCheques;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}
