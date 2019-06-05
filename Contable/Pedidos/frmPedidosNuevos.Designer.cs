using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	
	partial class frmPedidosNuevos
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmPedidosNuevos() : base()
		{
			//Llamada necesaria para el Diseñador de Windows Forms.
			InitializeComponent();
			//Éste es un formulario MDI secundario.
			//Este código simula la funcionalidad de VB6 
			// de cargar automáticamente
			// y mostrar el formulario primario de
			// un MDI secundario.
			
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
		public System.Windows.Forms.RichTextBox richNotas;
		public System.Windows.Forms.Label lblFechaEntrega;
		public System.Windows.Forms.GroupBox Frame4;
		public System.Windows.Forms.ComboBox cmbRazonSocial;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.Label lblNumPedido;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button2;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button4;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button6;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button8;
		public System.Windows.Forms.ToolStrip Toolbar1;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidosNuevos));
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.lblNumPedido = new System.Windows.Forms.Label();
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this.tbNuevo = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button2 = new System.Windows.Forms.ToolStripSeparator();
			this.tbGuardar = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button4 = new System.Windows.Forms.ToolStripSeparator();
			this.tbImprimir = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button6 = new System.Windows.Forms.ToolStripSeparator();
			this.tbEliminar = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button8 = new System.Windows.Forms.ToolStripSeparator();
			this.tbEditar = new System.Windows.Forms.ToolStripButton();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabMercaderia = new System.Windows.Forms.TabPage();
			this.tabPedido = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.richNotas = new System.Windows.Forms.RichTextBox();
			this.Frame4 = new System.Windows.Forms.GroupBox();
			this.MonthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.lblFechaEntrega = new System.Windows.Forms.Label();
			this.dgwMercaderia = new System.Windows.Forms.DataGridView();
			this.dgwPedido = new System.Windows.Forms.DataGridView();
			this.Frame2.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.Toolbar1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabMercaderia.SuspendLayout();
			this.tabPedido.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.Frame4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgwMercaderia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgwPedido)).BeginInit();
			this.SuspendLayout();
			// 
			// Frame2
			// 
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.cmbRazonSocial);
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(12, 32);
			this.Frame2.Name = "Frame2";
			this.Frame2.Padding = new System.Windows.Forms.Padding(0);
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(273, 49);
			this.Frame2.TabIndex = 7;
			this.Frame2.TabStop = false;
			this.Frame2.Text = "Cliente";
			// 
			// cmbRazonSocial
			// 
			this.cmbRazonSocial.BackColor = System.Drawing.SystemColors.Window;
			this.cmbRazonSocial.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbRazonSocial.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbRazonSocial.Location = new System.Drawing.Point(8, 16);
			this.cmbRazonSocial.Name = "cmbRazonSocial";
			this.cmbRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbRazonSocial.Size = new System.Drawing.Size(257, 21);
			this.cmbRazonSocial.Sorted = true;
			this.cmbRazonSocial.TabIndex = 8;
			this.cmbRazonSocial.DropDown += new System.EventHandler(this.CmbRazonSocialDropDown);
			this.cmbRazonSocial.SelectedIndexChanged += new System.EventHandler(this.CmbRazonSocialSelectedIndexChanged);
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.lblNumPedido);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(375, 32);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(177, 49);
			this.Frame1.TabIndex = 5;
			this.Frame1.TabStop = false;
			this.Frame1.Text = "Nº de Pedido";
			// 
			// lblNumPedido
			// 
			this.lblNumPedido.BackColor = System.Drawing.SystemColors.Control;
			this.lblNumPedido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblNumPedido.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblNumPedido.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNumPedido.Location = new System.Drawing.Point(14, 16);
			this.lblNumPedido.Name = "lblNumPedido";
			this.lblNumPedido.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblNumPedido.Size = new System.Drawing.Size(145, 25);
			this.lblNumPedido.TabIndex = 6;
			this.lblNumPedido.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Toolbar1
			// 
			this.Toolbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tbNuevo,
			this._Toolbar1_Button2,
			this.tbGuardar,
			this._Toolbar1_Button4,
			this.tbImprimir,
			this._Toolbar1_Button6,
			this.tbEliminar,
			this._Toolbar1_Button8,
			this.tbEditar});
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.Size = new System.Drawing.Size(1016, 29);
			this.Toolbar1.TabIndex = 21;
			// 
			// tbNuevo
			// 
			this.tbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tbNuevo.Image")));
			this.tbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tbNuevo.Name = "tbNuevo";
			this.tbNuevo.Size = new System.Drawing.Size(26, 26);
			this.tbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbNuevo.ToolTipText = "Nuevo";
			this.tbNuevo.Click += new System.EventHandler(this.TbNuevoClick);
			// 
			// _Toolbar1_Button2
			// 
			this._Toolbar1_Button2.Name = "_Toolbar1_Button2";
			this._Toolbar1_Button2.Size = new System.Drawing.Size(6, 29);
			// 
			// tbGuardar
			// 
			this.tbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tbGuardar.Image")));
			this.tbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tbGuardar.Name = "tbGuardar";
			this.tbGuardar.Size = new System.Drawing.Size(26, 26);
			this.tbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbGuardar.ToolTipText = "Guardar";
			// 
			// _Toolbar1_Button4
			// 
			this._Toolbar1_Button4.Name = "_Toolbar1_Button4";
			this._Toolbar1_Button4.Size = new System.Drawing.Size(6, 29);
			// 
			// tbImprimir
			// 
			this.tbImprimir.Enabled = false;
			this.tbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tbImprimir.Image")));
			this.tbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tbImprimir.Name = "tbImprimir";
			this.tbImprimir.Size = new System.Drawing.Size(26, 26);
			this.tbImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbImprimir.ToolTipText = "Imprimir";
			// 
			// _Toolbar1_Button6
			// 
			this._Toolbar1_Button6.Name = "_Toolbar1_Button6";
			this._Toolbar1_Button6.Size = new System.Drawing.Size(6, 29);
			// 
			// tbEliminar
			// 
			this.tbEliminar.Enabled = false;
			this.tbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tbEliminar.Image")));
			this.tbEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tbEliminar.Name = "tbEliminar";
			this.tbEliminar.Size = new System.Drawing.Size(26, 26);
			this.tbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbEliminar.ToolTipText = "Anular";
			// 
			// _Toolbar1_Button8
			// 
			this._Toolbar1_Button8.Name = "_Toolbar1_Button8";
			this._Toolbar1_Button8.Size = new System.Drawing.Size(6, 29);
			// 
			// tbEditar
			// 
			this.tbEditar.Enabled = false;
			this.tbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tbEditar.Image")));
			this.tbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tbEditar.Name = "tbEditar";
			this.tbEditar.Size = new System.Drawing.Size(26, 26);
			this.tbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbEditar.ToolTipText = "Editar";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabMercaderia);
			this.tabControl1.Controls.Add(this.tabPedido);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(20, 87);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(996, 407);
			this.tabControl1.TabIndex = 26;
			// 
			// tabMercaderia
			// 
			this.tabMercaderia.Controls.Add(this.dgwMercaderia);
			this.tabMercaderia.Location = new System.Drawing.Point(4, 22);
			this.tabMercaderia.Name = "tabMercaderia";
			this.tabMercaderia.Padding = new System.Windows.Forms.Padding(3);
			this.tabMercaderia.Size = new System.Drawing.Size(988, 381);
			this.tabMercaderia.TabIndex = 0;
			this.tabMercaderia.Text = "Mercaderia";
			this.tabMercaderia.UseVisualStyleBackColor = true;
			// 
			// tabPedido
			// 
			this.tabPedido.Controls.Add(this.dgwPedido);
			this.tabPedido.Location = new System.Drawing.Point(4, 22);
			this.tabPedido.Name = "tabPedido";
			this.tabPedido.Padding = new System.Windows.Forms.Padding(3);
			this.tabPedido.Size = new System.Drawing.Size(988, 381);
			this.tabPedido.TabIndex = 1;
			this.tabPedido.Text = "Pedido";
			this.tabPedido.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.Frame4);
			this.tabPage3.Controls.Add(this.richNotas);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(988, 381);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Varios";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// richNotas
			// 
			this.richNotas.Location = new System.Drawing.Point(351, 28);
			this.richNotas.Name = "richNotas";
			this.richNotas.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.richNotas.Size = new System.Drawing.Size(585, 185);
			this.richNotas.TabIndex = 24;
			this.richNotas.Text = "";
			// 
			// Frame4
			// 
			this.Frame4.BackColor = System.Drawing.SystemColors.Control;
			this.Frame4.Controls.Add(this.MonthCalendar1);
			this.Frame4.Controls.Add(this.lblFechaEntrega);
			this.Frame4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame4.Location = new System.Drawing.Point(43, 28);
			this.Frame4.Name = "Frame4";
			this.Frame4.Padding = new System.Windows.Forms.Padding(0);
			this.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame4.Size = new System.Drawing.Size(201, 233);
			this.Frame4.TabIndex = 25;
			this.Frame4.TabStop = false;
			this.Frame4.Text = "Fecha de Entrega";
			// 
			// MonthCalendar1
			// 
			this.MonthCalendar1.Location = new System.Drawing.Point(9, 50);
			this.MonthCalendar1.Name = "MonthCalendar1";
			this.MonthCalendar1.TabIndex = 24;
			// 
			// lblFechaEntrega
			// 
			this.lblFechaEntrega.BackColor = System.Drawing.SystemColors.Control;
			this.lblFechaEntrega.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblFechaEntrega.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblFechaEntrega.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblFechaEntrega.Location = new System.Drawing.Point(8, 24);
			this.lblFechaEntrega.Name = "lblFechaEntrega";
			this.lblFechaEntrega.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFechaEntrega.Size = new System.Drawing.Size(113, 17);
			this.lblFechaEntrega.TabIndex = 23;
			// 
			// dgwMercaderia
			// 
			this.dgwMercaderia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwMercaderia.Location = new System.Drawing.Point(13, 54);
			this.dgwMercaderia.Name = "dgwMercaderia";
			this.dgwMercaderia.Size = new System.Drawing.Size(967, 321);
			this.dgwMercaderia.TabIndex = 25;
			// 
			// dgwPedido
			// 
			this.dgwPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwPedido.Location = new System.Drawing.Point(3, 6);
			this.dgwPedido.Name = "dgwPedido";
			this.dgwPedido.Size = new System.Drawing.Size(977, 369);
			this.dgwPedido.TabIndex = 26;
			// 
			// frmPedidosNuevos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1016, 734);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.Toolbar1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 23);
			this.Name = "frmPedidosNuevos";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Pedidos Nuevos";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmPedidosNuevosLoad);
			this.Frame2.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabMercaderia.ResumeLayout(false);
			this.tabPedido.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.Frame4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgwMercaderia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgwPedido)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		public System.Windows.Forms.ToolStripButton tbEditar;
		public System.Windows.Forms.ToolStripButton tbEliminar;
		public System.Windows.Forms.ToolStripButton tbImprimir;
		public System.Windows.Forms.ToolStripButton tbGuardar;
		public System.Windows.Forms.ToolStripButton tbNuevo;
		internal System.Windows.Forms.DataGridView dgwMercaderia;
		internal System.Windows.Forms.DataGridView dgwPedido;
			#endregion
		internal System.Windows.Forms.MonthCalendar MonthCalendar1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabMercaderia;
		private System.Windows.Forms.TabPage tabPedido;
		private System.Windows.Forms.TabPage tabPage3;
	}
}
