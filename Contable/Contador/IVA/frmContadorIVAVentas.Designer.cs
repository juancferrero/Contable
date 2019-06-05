
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{

	partial class frmContadorIVAVentas
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmContadorIVAVentas() : base()
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
		public System.Windows.Forms.TabPage _SSTab1_TabPage0;
		public System.Windows.Forms.TabPage _SSTab1_TabPage1;
		public System.Windows.Forms.TabPage _SSTab1_TabPage2;
		public System.Windows.Forms.TabPage _SSTab1_TabPage3;
		public System.Windows.Forms.TabControl SSTab1;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContadorIVAVentas));
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SSTab1 = new System.Windows.Forms.TabControl();
			this._SSTab1_TabPage0 = new System.Windows.Forms.TabPage();
			this.CalFechaFin = new System.Windows.Forms.MonthCalendar();
			this.CalFechaInicio = new System.Windows.Forms.MonthCalendar();
			this._SSTab1_TabPage1 = new System.Windows.Forms.TabPage();
			this.dtGridFacturas = new System.Windows.Forms.DataGridView();
			this._SSTab1_TabPage2 = new System.Windows.Forms.TabPage();
			this.dtGridProvincias = new System.Windows.Forms.DataGridView();
			this._SSTab1_TabPage3 = new System.Windows.Forms.TabPage();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsRefrescar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsImprimir = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsBoleta = new System.Windows.Forms.ToolStripButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblSubTotal = new System.Windows.Forms.Label();
			this.lblIVA = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.SSTab1.SuspendLayout();
			this._SSTab1_TabPage0.SuspendLayout();
			this._SSTab1_TabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtGridFacturas)).BeginInit();
			this._SSTab1_TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtGridProvincias)).BeginInit();
			this._SSTab1_TabPage3.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SSTab1
			// 
			this.SSTab1.Controls.Add(this._SSTab1_TabPage0);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage1);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage2);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage3);
			this.SSTab1.ItemSize = new System.Drawing.Size(42, 18);
			this.SSTab1.Location = new System.Drawing.Point(0, 28);
			this.SSTab1.Name = "SSTab1";
			this.SSTab1.SelectedIndex = 0;
			this.SSTab1.Size = new System.Drawing.Size(1304, 644);
			this.SSTab1.TabIndex = 4;
			// 
			// _SSTab1_TabPage0
			// 
			this._SSTab1_TabPage0.Controls.Add(this.CalFechaFin);
			this._SSTab1_TabPage0.Controls.Add(this.CalFechaInicio);
			this._SSTab1_TabPage0.Location = new System.Drawing.Point(4, 22);
			this._SSTab1_TabPage0.Name = "_SSTab1_TabPage0";
			this._SSTab1_TabPage0.Size = new System.Drawing.Size(1193, 618);
			this._SSTab1_TabPage0.TabIndex = 0;
			this._SSTab1_TabPage0.Text = "Inicio";
			// 
			// CalFechaFin
			// 
			this.CalFechaFin.Location = new System.Drawing.Point(292, 51);
			this.CalFechaFin.Name = "CalFechaFin";
			this.CalFechaFin.TabIndex = 13;
			// 
			// CalFechaInicio
			// 
			this.CalFechaInicio.Location = new System.Drawing.Point(23, 51);
			this.CalFechaInicio.Name = "CalFechaInicio";
			this.CalFechaInicio.TabIndex = 12;
			// 
			// _SSTab1_TabPage1
			// 
			this._SSTab1_TabPage1.Controls.Add(this.dtGridFacturas);
			this._SSTab1_TabPage1.Location = new System.Drawing.Point(4, 22);
			this._SSTab1_TabPage1.Name = "_SSTab1_TabPage1";
			this._SSTab1_TabPage1.Size = new System.Drawing.Size(1296, 618);
			this._SSTab1_TabPage1.TabIndex = 1;
			this._SSTab1_TabPage1.Text = "Facturas";
			// 
			// dtGridFacturas
			// 
			this.dtGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtGridFacturas.Location = new System.Drawing.Point(3, 3);
			this.dtGridFacturas.Name = "dtGridFacturas";
			this.dtGridFacturas.Size = new System.Drawing.Size(1234, 382);
			this.dtGridFacturas.TabIndex = 0;
			// 
			// _SSTab1_TabPage2
			// 
			this._SSTab1_TabPage2.Controls.Add(this.dtGridProvincias);
			this._SSTab1_TabPage2.Location = new System.Drawing.Point(4, 22);
			this._SSTab1_TabPage2.Name = "_SSTab1_TabPage2";
			this._SSTab1_TabPage2.Size = new System.Drawing.Size(1296, 618);
			this._SSTab1_TabPage2.TabIndex = 2;
			this._SSTab1_TabPage2.Text = "Provincias";
			// 
			// dtGridProvincias
			// 
			this.dtGridProvincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtGridProvincias.Location = new System.Drawing.Point(3, 3);
			this.dtGridProvincias.Name = "dtGridProvincias";
			this.dtGridProvincias.Size = new System.Drawing.Size(1129, 440);
			this.dtGridProvincias.TabIndex = 0;
			// 
			// _SSTab1_TabPage3
			// 
			this._SSTab1_TabPage3.Controls.Add(this.lblTotal);
			this._SSTab1_TabPage3.Controls.Add(this.lblIVA);
			this._SSTab1_TabPage3.Controls.Add(this.lblSubTotal);
			this._SSTab1_TabPage3.Controls.Add(this.label3);
			this._SSTab1_TabPage3.Controls.Add(this.label2);
			this._SSTab1_TabPage3.Controls.Add(this.label1);
			this._SSTab1_TabPage3.Location = new System.Drawing.Point(4, 22);
			this._SSTab1_TabPage3.Name = "_SSTab1_TabPage3";
			this._SSTab1_TabPage3.Size = new System.Drawing.Size(1296, 618);
			this._SSTab1_TabPage3.TabIndex = 3;
			this._SSTab1_TabPage3.Text = "Resumenes";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsRefrescar,
			this.toolStripSeparator1,
			this.tsImprimir,
			this.toolStripSeparator2,
			this.tsBoleta});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1370, 25);
			this.toolStrip1.TabIndex = 18;
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
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tsBoleta
			// 
			this.tsBoleta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsBoleta.Image = ((System.Drawing.Image)(resources.GetObject("tsBoleta.Image")));
			this.tsBoleta.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsBoleta.Name = "tsBoleta";
			this.tsBoleta.Size = new System.Drawing.Size(23, 22);
			this.tsBoleta.Text = "toolStripButton3";
			this.tsBoleta.ToolTipText = "Boleta";
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Location = new System.Drawing.Point(21, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "SubTotal";
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(21, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "IVA";
			// 
			// label3
			// 
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Location = new System.Drawing.Point(21, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Total";
			// 
			// lblSubTotal
			// 
			this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblSubTotal.Location = new System.Drawing.Point(127, 24);
			this.lblSubTotal.Name = "lblSubTotal";
			this.lblSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblSubTotal.Size = new System.Drawing.Size(100, 23);
			this.lblSubTotal.TabIndex = 3;
			this.lblSubTotal.Text = "0";
			// 
			// lblIVA
			// 
			this.lblIVA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblIVA.Location = new System.Drawing.Point(127, 56);
			this.lblIVA.Name = "lblIVA";
			this.lblIVA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblIVA.Size = new System.Drawing.Size(100, 23);
			this.lblIVA.TabIndex = 4;
			this.lblIVA.Text = "0";
			// 
			// lblTotal
			// 
			this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTotal.Location = new System.Drawing.Point(127, 90);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblTotal.Size = new System.Drawing.Size(100, 23);
			this.lblTotal.TabIndex = 5;
			this.lblTotal.Text = "0";
			// 
			// frmContadorIVAVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1370, 750);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.SSTab1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 28);
			this.Name = "frmContadorIVAVentas";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Subdiario IVA VENTAS";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.SSTab1.ResumeLayout(false);
			this._SSTab1_TabPage0.ResumeLayout(false);
			this._SSTab1_TabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtGridFacturas)).EndInit();
			this._SSTab1_TabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtGridProvincias)).EndInit();
			this._SSTab1_TabPage3.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.MonthCalendar CalFechaFin;
		internal System.Windows.Forms.MonthCalendar CalFechaInicio;
		internal System.Windows.Forms.DataGridView dtGridFacturas;
		internal System.Windows.Forms.DataGridView dtGridProvincias;
			#endregion
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton tsRefrescar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsImprimir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsBoleta;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblIVA;
		private System.Windows.Forms.Label lblSubTotal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
