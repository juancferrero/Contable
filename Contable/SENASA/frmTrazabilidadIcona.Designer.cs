/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 25/01/2017
 * Hora: 12:30 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Contable.SENASA
{
	partial class frmTrazabilidadIcona
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView gridDatos;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Icona;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ferrero;
		private System.Windows.Forms.DataGridViewTextBoxColumn GTINIcona;
		private System.Windows.Forms.DataGridViewTextBoxColumn colGTINFerrero;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button1;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button2;
		public System.Windows.Forms.ToolStripButton tlbGuardar;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button4;
		public System.Windows.Forms.ToolStripButton tbImprimir;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button6;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button7;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button8;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnIniciar;
		private System.Windows.Forms.Button btnParar;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TextBox txtTiempoRetardo;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrazabilidadIcona));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this._Toolbar1_Button1 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button2 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbGuardar = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button4 = new System.Windows.Forms.ToolStripSeparator();
			this.tbImprimir = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button6 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button7 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button8 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button9 = new System.Windows.Forms.ToolStripButton();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.Icona = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ferrero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GTINIcona = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGTINFerrero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnParar = new System.Windows.Forms.Button();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.txtTiempoRetardo = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.Toolbar1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// Toolbar1
			// 
			this.Toolbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this._Toolbar1_Button1,
			this._Toolbar1_Button2,
			this.tlbGuardar,
			this._Toolbar1_Button4,
			this.tbImprimir,
			this._Toolbar1_Button6,
			this._Toolbar1_Button7,
			this._Toolbar1_Button8,
			this._Toolbar1_Button9});
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.Size = new System.Drawing.Size(1215, 39);
			this.Toolbar1.TabIndex = 145;
			// 
			// _Toolbar1_Button1
			// 
			this._Toolbar1_Button1.Image = ((System.Drawing.Image)(resources.GetObject("_Toolbar1_Button1.Image")));
			this._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button1.Name = "_Toolbar1_Button1";
			this._Toolbar1_Button1.Size = new System.Drawing.Size(26, 36);
			this._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button1.ToolTipText = "Nuevo";
			// 
			// _Toolbar1_Button2
			// 
			this._Toolbar1_Button2.Name = "_Toolbar1_Button2";
			this._Toolbar1_Button2.Size = new System.Drawing.Size(6, 39);
			// 
			// tlbGuardar
			// 
			this.tlbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tlbGuardar.Image")));
			this.tlbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbGuardar.Name = "tlbGuardar";
			this.tlbGuardar.Size = new System.Drawing.Size(26, 36);
			this.tlbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbGuardar.ToolTipText = "Guardar";
			this.tlbGuardar.Click += new System.EventHandler(this.TlbGuardarClick);
			// 
			// _Toolbar1_Button4
			// 
			this._Toolbar1_Button4.AutoSize = false;
			this._Toolbar1_Button4.Name = "_Toolbar1_Button4";
			this._Toolbar1_Button4.Size = new System.Drawing.Size(0, 39);
			// 
			// tbImprimir
			// 
			this.tbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tbImprimir.Image")));
			this.tbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tbImprimir.Name = "tbImprimir";
			this.tbImprimir.Size = new System.Drawing.Size(26, 36);
			this.tbImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbImprimir.ToolTipText = "Imprimir";
			// 
			// _Toolbar1_Button6
			// 
			this._Toolbar1_Button6.Name = "_Toolbar1_Button6";
			this._Toolbar1_Button6.Size = new System.Drawing.Size(6, 39);
			// 
			// _Toolbar1_Button7
			// 
			this._Toolbar1_Button7.Image = ((System.Drawing.Image)(resources.GetObject("_Toolbar1_Button7.Image")));
			this._Toolbar1_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button7.Name = "_Toolbar1_Button7";
			this._Toolbar1_Button7.Size = new System.Drawing.Size(26, 36);
			this._Toolbar1_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button7.ToolTipText = "Anular";
			// 
			// _Toolbar1_Button8
			// 
			this._Toolbar1_Button8.Name = "_Toolbar1_Button8";
			this._Toolbar1_Button8.Size = new System.Drawing.Size(6, 39);
			// 
			// _Toolbar1_Button9
			// 
			this._Toolbar1_Button9.Image = ((System.Drawing.Image)(resources.GetObject("_Toolbar1_Button9.Image")));
			this._Toolbar1_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button9.Name = "_Toolbar1_Button9";
			this._Toolbar1_Button9.Size = new System.Drawing.Size(26, 36);
			this._Toolbar1_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button9.ToolTipText = "Editar";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(0, 42);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(894, 419);
			this.tabControl1.TabIndex = 156;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.gridDatos);
			this.tabPage1.Controls.Add(this.btnParar);
			this.tabPage1.Controls.Add(this.btnIniciar);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(886, 393);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Automatico";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(44, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 20);
			this.label1.TabIndex = 161;
			this.label1.Text = "Codigo";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(102, 9);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(425, 20);
			this.textBox1.TabIndex = 160;
			// 
			// gridDatos
			// 
			this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Icona,
			this.Ferrero,
			this.GTINIcona,
			this.colGTINFerrero});
			this.gridDatos.Location = new System.Drawing.Point(3, 44);
			this.gridDatos.Name = "gridDatos";
			this.gridDatos.Size = new System.Drawing.Size(462, 262);
			this.gridDatos.TabIndex = 159;
			// 
			// Icona
			// 
			this.Icona.HeaderText = "Icona";
			this.Icona.Name = "Icona";
			// 
			// Ferrero
			// 
			this.Ferrero.HeaderText = "Ferrero";
			this.Ferrero.Name = "Ferrero";
			// 
			// GTINIcona
			// 
			this.GTINIcona.HeaderText = "GTINIcona";
			this.GTINIcona.Name = "GTINIcona";
			// 
			// colGTINFerrero
			// 
			this.colGTINFerrero.HeaderText = "GTINFerrero";
			this.colGTINFerrero.Name = "colGTINFerrero";
			// 
			// btnParar
			// 
			this.btnParar.Location = new System.Drawing.Point(608, 248);
			this.btnParar.Name = "btnParar";
			this.btnParar.Size = new System.Drawing.Size(129, 33);
			this.btnParar.TabIndex = 158;
			this.btnParar.Text = "Parar";
			this.btnParar.UseVisualStyleBackColor = true;
			// 
			// btnIniciar
			// 
			this.btnIniciar.Location = new System.Drawing.Point(608, 217);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(121, 25);
			this.btnIniciar.TabIndex = 156;
			this.btnIniciar.Text = "Iniciar";
			this.btnIniciar.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.textBox5);
			this.tabPage2.Controls.Add(this.textBox4);
			this.tabPage2.Controls.Add(this.textBox3);
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(886, 393);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Manual";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(623, 263);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 158;
			this.label7.Text = "label7";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(505, 267);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 28);
			this.label6.TabIndex = 157;
			this.label6.Text = "label6";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(348, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 13);
			this.label5.TabIndex = 156;
			this.label5.Text = "Nro de unidad";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 13);
			this.label4.TabIndex = 155;
			this.label4.Text = "Fecha Vencimiento";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(384, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 13);
			this.label3.TabIndex = 154;
			this.label3.Text = "Fecha Manufactura";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 153;
			this.label2.Text = "GTIN";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.txtTiempoRetardo);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(886, 393);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Configuracion";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// txtTiempoRetardo
			// 
			this.txtTiempoRetardo.Location = new System.Drawing.Point(138, 17);
			this.txtTiempoRetardo.Name = "txtTiempoRetardo";
			this.txtTiempoRetardo.Size = new System.Drawing.Size(58, 20);
			this.txtTiempoRetardo.TabIndex = 1;
			this.txtTiempoRetardo.Text = "3000";
			this.txtTiempoRetardo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(129, 17);
			this.label8.TabIndex = 0;
			this.label8.Text = "Tiempo de retardo (ms)";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(61, 28);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(317, 20);
			this.textBox2.TabIndex = 159;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(490, 28);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(335, 20);
			this.textBox3.TabIndex = 160;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(122, 81);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(220, 20);
			this.textBox4.TabIndex = 161;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(428, 77);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(349, 20);
			this.textBox5.TabIndex = 162;
			// 
			// frmTrazabilidadIcona
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1215, 535);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.Toolbar1);
			this.Name = "frmTrazabilidadIcona";
			this.Text = "frmTrazabilidadIcona";
			this.Load += new System.EventHandler(this.FrmTrazabilidadIconaLoad);
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
