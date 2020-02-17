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
	partial class frmPedidosGeneral
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmPedidosGeneral() : base()
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
				if ((components != null)) {
					components.Dispose();
				}
			}
			base.Dispose(Disposing);
		}
//Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.Timer Timer1;
		public System.Windows.Forms.ToolStrip Toolbar1;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidosGeneral));
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this.tbNuevo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tbGuardar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tbActualizar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tbAnular = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tbEditar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.tbPasarARemito = new System.Windows.Forms.ToolStripButton();
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.gridDatosPedido = new System.Windows.Forms.DataGridView();
			this.Toolbar1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDatosPedido)).BeginInit();
			this.SuspendLayout();
			// 
			// Timer1
			// 
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 30000;
			// 
			// Toolbar1
			// 
			this.Toolbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tbNuevo,
			this.toolStripSeparator1,
			this.tbGuardar,
			this.toolStripSeparator2,
			this.tbActualizar,
			this.toolStripSeparator3,
			this.tbAnular,
			this.toolStripSeparator4,
			this.tbEditar,
			this.toolStripSeparator5,
			this.tbPasarARemito});
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.Size = new System.Drawing.Size(1301, 29);
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
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
			// 
			// tbGuardar
			// 
			this.tbGuardar.Enabled = false;
			this.tbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tbGuardar.Image")));
			this.tbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tbGuardar.Name = "tbGuardar";
			this.tbGuardar.Size = new System.Drawing.Size(26, 26);
			this.tbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbGuardar.ToolTipText = "Guardar";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
			// 
			// tbActualizar
			// 
			this.tbActualizar.Image = ((System.Drawing.Image)(resources.GetObject("tbActualizar.Image")));
			this.tbActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tbActualizar.Name = "tbActualizar";
			this.tbActualizar.Size = new System.Drawing.Size(26, 26);
			this.tbActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbActualizar.ToolTipText = "Actualizar";
			this.tbActualizar.Click += new System.EventHandler(this.TbActualizarClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
			// 
			// tbAnular
			// 
			this.tbAnular.Image = ((System.Drawing.Image)(resources.GetObject("tbAnular.Image")));
			this.tbAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tbAnular.Name = "tbAnular";
			this.tbAnular.Size = new System.Drawing.Size(26, 26);
			this.tbAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbAnular.ToolTipText = "Anular";
			this.tbAnular.Click += new System.EventHandler(this.TbAnularClick);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
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
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
			// 
			// tbPasarARemito
			// 
			this.tbPasarARemito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbPasarARemito.Image = ((System.Drawing.Image)(resources.GetObject("tbPasarARemito.Image")));
			this.tbPasarARemito.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbPasarARemito.Name = "tbPasarARemito";
			this.tbPasarARemito.Size = new System.Drawing.Size(23, 26);
			this.tbPasarARemito.Text = "Pasar A Remito";
			this.tbPasarARemito.Click += new System.EventHandler(this.TbPasarARemitoClick);
			// 
			// gridDatos
			// 
			this.gridDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatos.Location = new System.Drawing.Point(12, 68);
			this.gridDatos.Name = "gridDatos";
			this.gridDatos.Size = new System.Drawing.Size(650, 656);
			this.gridDatos.TabIndex = 22;
			this.gridDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatosCellClick);
			// 
			// gridDatosPedido
			// 
			this.gridDatosPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gridDatosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatosPedido.Location = new System.Drawing.Point(712, 68);
			this.gridDatosPedido.Name = "gridDatosPedido";
			this.gridDatosPedido.Size = new System.Drawing.Size(547, 166);
			this.gridDatosPedido.TabIndex = 23;
			// 
			// frmPedidosGeneral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1301, 750);
			this.Controls.Add(this.gridDatosPedido);
			this.Controls.Add(this.gridDatos);
			this.Controls.Add(this.Toolbar1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 26);
			this.Name = "frmPedidosGeneral";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Pedidos General";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmPedidosGeneralLoad);
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDatosPedido)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripButton tbPasarARemito;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.DataGridView gridDatosPedido;
		private System.Windows.Forms.DataGridView gridDatos;
		public System.Windows.Forms.ToolStripButton tbEditar;
		public System.Windows.Forms.ToolStripButton tbAnular;
		public System.Windows.Forms.ToolStripButton tbActualizar;
		public System.Windows.Forms.ToolStripButton tbGuardar;
		public System.Windows.Forms.ToolStripButton tbNuevo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
			#endregion
	}
}
