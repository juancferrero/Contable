/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 12/07/2018
 * Hora: 10:00 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Contable.SENASA
{
	partial class frmConsultaTraza
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView gridDatosGeneral;
		private System.Windows.Forms.DataGridViewTextBoxColumn coID;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFECHATRANSAC;
		private System.Windows.Forms.DataGridViewTextBoxColumn colFECHAOPERAC;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEVENTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAGEINF;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAGEORI;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAGEDEST;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPRODUCTO;
		private System.Windows.Forms.DataGridViewTextBoxColumn colGTIN;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCANTIDAD;
		private System.Windows.Forms.DataGridViewTextBoxColumn colENVASE;
		private System.Windows.Forms.DataGridViewTextBoxColumn colESTADOTRANSAC;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTIPOTRANSAC;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNUMSERIE;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNUMLOTE;
		private System.Windows.Forms.DataGridViewTextBoxColumn colREMITOFACTURA;
		private System.Windows.Forms.DataGridViewTextBoxColumn colMOTDEVOLUCIÓN;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOBSDEVOLUCION;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtIdTipoTransaccion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtGLNOrigen;
		private System.Windows.Forms.TextBox txtGLNInformador;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtIdEvento;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIdTransaccion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tlbConsultar;
		private System.Windows.Forms.ToolStripButton tlbInformar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaTraza));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.gridDatosGeneral = new System.Windows.Forms.DataGridView();
			this.coID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFECHATRANSAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colFECHAOPERAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEVENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAGEINF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAGEORI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAGEDEST = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGTIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colENVASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colESTADOTRANSAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTIPOTRANSAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNUMSERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNUMLOTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colREMITOFACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colMOTDEVOLUCIÓN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOBSDEVOLUCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtIdTipoTransaccion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtGLNOrigen = new System.Windows.Forms.TextBox();
			this.txtGLNInformador = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIdEvento = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIdTransaccion = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tlbConsultar = new System.Windows.Forms.ToolStripButton();
			this.tlbInformar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDatosGeneral)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 52);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1136, 616);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.gridDatosGeneral);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1128, 590);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "General";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// gridDatosGeneral
			// 
			this.gridDatosGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatosGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.coID,
			this.colFECHATRANSAC,
			this.colFECHAOPERAC,
			this.colEVENTO,
			this.colAGEINF,
			this.colAGEORI,
			this.colAGEDEST,
			this.colPRODUCTO,
			this.colGTIN,
			this.colCANTIDAD,
			this.colENVASE,
			this.colESTADOTRANSAC,
			this.colTIPOTRANSAC,
			this.colNUMSERIE,
			this.colNUMLOTE,
			this.colREMITOFACTURA,
			this.colMOTDEVOLUCIÓN,
			this.colOBSDEVOLUCION});
			this.gridDatosGeneral.Location = new System.Drawing.Point(6, 16);
			this.gridDatosGeneral.Name = "gridDatosGeneral";
			this.gridDatosGeneral.Size = new System.Drawing.Size(1079, 527);
			this.gridDatosGeneral.TabIndex = 0;
			// 
			// coID
			// 
			this.coID.HeaderText = "ID";
			this.coID.Name = "coID";
			// 
			// colFECHATRANSAC
			// 
			this.colFECHATRANSAC.HeaderText = "FECHA TRANSAC";
			this.colFECHATRANSAC.Name = "colFECHATRANSAC";
			// 
			// colFECHAOPERAC
			// 
			this.colFECHAOPERAC.HeaderText = "FECHA OPERAC.";
			this.colFECHAOPERAC.Name = "colFECHAOPERAC";
			// 
			// colEVENTO
			// 
			this.colEVENTO.HeaderText = "EVENTO";
			this.colEVENTO.Name = "colEVENTO";
			// 
			// colAGEINF
			// 
			this.colAGEINF.HeaderText = "AGE. INF.";
			this.colAGEINF.Name = "colAGEINF";
			// 
			// colAGEORI
			// 
			this.colAGEORI.HeaderText = "AGE. ORI.";
			this.colAGEORI.Name = "colAGEORI";
			// 
			// colAGEDEST
			// 
			this.colAGEDEST.HeaderText = "AGE. DEST.";
			this.colAGEDEST.Name = "colAGEDEST";
			// 
			// colPRODUCTO
			// 
			this.colPRODUCTO.HeaderText = "PRODUCTO";
			this.colPRODUCTO.Name = "colPRODUCTO";
			// 
			// colGTIN
			// 
			this.colGTIN.HeaderText = "GTIN";
			this.colGTIN.Name = "colGTIN";
			// 
			// colCANTIDAD
			// 
			this.colCANTIDAD.HeaderText = "CANTIDAD";
			this.colCANTIDAD.Name = "colCANTIDAD";
			// 
			// colENVASE
			// 
			this.colENVASE.HeaderText = "ENVASE";
			this.colENVASE.Name = "colENVASE";
			// 
			// colESTADOTRANSAC
			// 
			this.colESTADOTRANSAC.HeaderText = "ESTADO TRANSAC.";
			this.colESTADOTRANSAC.Name = "colESTADOTRANSAC";
			// 
			// colTIPOTRANSAC
			// 
			this.colTIPOTRANSAC.HeaderText = "TIPO TRANSAC.";
			this.colTIPOTRANSAC.Name = "colTIPOTRANSAC";
			// 
			// colNUMSERIE
			// 
			this.colNUMSERIE.HeaderText = "NUM. SERIE";
			this.colNUMSERIE.Name = "colNUMSERIE";
			// 
			// colNUMLOTE
			// 
			this.colNUMLOTE.HeaderText = "NUM. LOTE";
			this.colNUMLOTE.Name = "colNUMLOTE";
			// 
			// colREMITOFACTURA
			// 
			this.colREMITOFACTURA.HeaderText = "REMITO / FACTURA";
			this.colREMITOFACTURA.Name = "colREMITOFACTURA";
			// 
			// colMOTDEVOLUCIÓN
			// 
			this.colMOTDEVOLUCIÓN.HeaderText = "MOT. DEVOLUCIÓN";
			this.colMOTDEVOLUCIÓN.Name = "colMOTDEVOLUCIÓN";
			// 
			// colOBSDEVOLUCION
			// 
			this.colOBSDEVOLUCION.HeaderText = "OBS. DEVOLUCIÓN";
			this.colOBSDEVOLUCION.Name = "colOBSDEVOLUCION";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.textBox3);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.textBox6);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.txtIdTipoTransaccion);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.txtGLNOrigen);
			this.tabPage2.Controls.Add(this.txtGLNInformador);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.txtIdEvento);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.txtIdTransaccion);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1257, 534);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Detalles";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(191, 370);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Location = new System.Drawing.Point(63, 367);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 14;
			this.label9.Text = "label9";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(191, 347);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 13;
			// 
			// label8
			// 
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label8.Location = new System.Drawing.Point(63, 344);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 12;
			this.label8.Text = "label8";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(191, 306);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Location = new System.Drawing.Point(63, 303);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 10;
			this.label7.Text = "label7";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(191, 262);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 20);
			this.textBox6.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Location = new System.Drawing.Point(63, 259);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 8;
			this.label6.Text = "label6";
			// 
			// txtIdTipoTransaccion
			// 
			this.txtIdTipoTransaccion.Location = new System.Drawing.Point(191, 127);
			this.txtIdTipoTransaccion.Name = "txtIdTipoTransaccion";
			this.txtIdTipoTransaccion.Size = new System.Drawing.Size(100, 20);
			this.txtIdTipoTransaccion.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Location = new System.Drawing.Point(63, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 6;
			this.label5.Text = "IdTipoTransaccion";
			// 
			// txtGLNOrigen
			// 
			this.txtGLNOrigen.Location = new System.Drawing.Point(191, 87);
			this.txtGLNOrigen.Name = "txtGLNOrigen";
			this.txtGLNOrigen.Size = new System.Drawing.Size(100, 20);
			this.txtGLNOrigen.TabIndex = 5;
			// 
			// txtGLNInformador
			// 
			this.txtGLNInformador.Location = new System.Drawing.Point(191, 107);
			this.txtGLNInformador.Name = "txtGLNInformador";
			this.txtGLNInformador.Size = new System.Drawing.Size(100, 20);
			this.txtGLNInformador.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Location = new System.Drawing.Point(63, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "GLNOrigen";
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Location = new System.Drawing.Point(63, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "GLNInformador";
			// 
			// txtIdEvento
			// 
			this.txtIdEvento.Location = new System.Drawing.Point(191, 67);
			this.txtIdEvento.Name = "txtIdEvento";
			this.txtIdEvento.Size = new System.Drawing.Size(100, 20);
			this.txtIdEvento.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(63, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "IdEvento";
			// 
			// txtIdTransaccion
			// 
			this.txtIdTransaccion.Location = new System.Drawing.Point(191, 47);
			this.txtIdTransaccion.Name = "txtIdTransaccion";
			this.txtIdTransaccion.Size = new System.Drawing.Size(100, 20);
			this.txtIdTransaccion.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(63, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "IdTransaccion";
			// 
			// label10
			// 
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Location = new System.Drawing.Point(324, 25);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(128, 14);
			this.label10.TabIndex = 3;
			this.label10.Text = "label10";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tlbConsultar,
			this.tlbInformar,
			this.toolStripSeparator1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1370, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tlbConsultar
			// 
			this.tlbConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlbConsultar.Image = ((System.Drawing.Image)(resources.GetObject("tlbConsultar.Image")));
			this.tlbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlbConsultar.Name = "tlbConsultar";
			this.tlbConsultar.Size = new System.Drawing.Size(23, 22);
			this.tlbConsultar.Text = "Consultar";
			this.tlbConsultar.Click += new System.EventHandler(this.TlbConsultarClick);
			// 
			// tlbInformar
			// 
			this.tlbInformar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlbInformar.Image = ((System.Drawing.Image)(resources.GetObject("tlbInformar.Image")));
			this.tlbInformar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlbInformar.Name = "tlbInformar";
			this.tlbInformar.Size = new System.Drawing.Size(23, 22);
			this.tlbInformar.Text = "Informar";
			this.tlbInformar.Click += new System.EventHandler(this.TlbInformarClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// frmConsultaTraza
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1370, 750);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.tabControl1);
			this.Name = "frmConsultaTraza";
			this.Text = "Consulta al Sistema de Trazabilidad del SENASA";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmConsultaTrazaLoad);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDatosGeneral)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
