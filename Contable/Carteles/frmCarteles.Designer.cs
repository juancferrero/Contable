using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	partial class frmCarteles
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmCarteles() : base()
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
		public System.Windows.Forms.TextBox txtCopias1;
		public System.Windows.Forms.ComboBox cmbRazonSocial1;
		public System.Windows.Forms.Label _Lbl_30;
		public System.Windows.Forms.Label lblCP1;
		public System.Windows.Forms.Label lblProvincia1;
		public System.Windows.Forms.Label lblLocalidad1;
		public System.Windows.Forms.Label lblDireccion1;
		public System.Windows.Forms.Label _Lbl_13;
		public System.Windows.Forms.Label _Lbl_1;
		public System.Windows.Forms.Label _Lbl_2;
		public System.Windows.Forms.Label _Lbl_3;
		public System.Windows.Forms.Label _Lbl_0;
		public System.Windows.Forms.GroupBox Cartel1;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.ToolStripButton tlbNuevo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		public System.Windows.Forms.ToolStripButton tlbGuardar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		public System.Windows.Forms.ToolStripButton tbImprimir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		public System.Windows.Forms.ToolStripButton tlbAnual;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		public System.Windows.Forms.ToolStripButton tlbEditar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton tlbCorreo;
		private System.Windows.Forms.ToolStripButton tlbCarteles;
		private System.Windows.Forms.DataGridView dataGridView1;
		//public Microsoft.VisualBasic.Compatibility.VB6.LabelArray Lbl;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarteles));
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Cartel1 = new System.Windows.Forms.GroupBox();
			this.txtCopias1 = new System.Windows.Forms.TextBox();
			this.cmbRazonSocial1 = new System.Windows.Forms.ComboBox();
			this._Lbl_30 = new System.Windows.Forms.Label();
			this.lblCP1 = new System.Windows.Forms.Label();
			this.lblProvincia1 = new System.Windows.Forms.Label();
			this.lblLocalidad1 = new System.Windows.Forms.Label();
			this.lblDireccion1 = new System.Windows.Forms.Label();
			this._Lbl_13 = new System.Windows.Forms.Label();
			this._Lbl_1 = new System.Windows.Forms.Label();
			this._Lbl_2 = new System.Windows.Forms.Label();
			this._Lbl_3 = new System.Windows.Forms.Label();
			this._Lbl_0 = new System.Windows.Forms.Label();
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this.tlbNuevo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbGuardar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tbImprimir = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbAnual = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbEditar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbCorreo = new System.Windows.Forms.ToolStripButton();
			this.tlbCarteles = new System.Windows.Forms.ToolStripButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Cartel1.SuspendLayout();
			this.Toolbar1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Cartel1
			// 
			this.Cartel1.BackColor = System.Drawing.SystemColors.Control;
			this.Cartel1.Controls.Add(this.txtCopias1);
			this.Cartel1.Controls.Add(this.cmbRazonSocial1);
			this.Cartel1.Controls.Add(this._Lbl_30);
			this.Cartel1.Controls.Add(this.lblCP1);
			this.Cartel1.Controls.Add(this.lblProvincia1);
			this.Cartel1.Controls.Add(this.lblLocalidad1);
			this.Cartel1.Controls.Add(this.lblDireccion1);
			this.Cartel1.Controls.Add(this._Lbl_13);
			this.Cartel1.Controls.Add(this._Lbl_1);
			this.Cartel1.Controls.Add(this._Lbl_2);
			this.Cartel1.Controls.Add(this._Lbl_3);
			this.Cartel1.Controls.Add(this._Lbl_0);
			this.Cartel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Cartel1.Location = new System.Drawing.Point(0, 32);
			this.Cartel1.Name = "Cartel1";
			this.Cartel1.Padding = new System.Windows.Forms.Padding(0);
			this.Cartel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Cartel1.Size = new System.Drawing.Size(353, 145);
			this.Cartel1.TabIndex = 0;
			this.Cartel1.TabStop = false;
			this.Cartel1.Visible = false;
			// 
			// txtCopias1
			// 
			this.txtCopias1.AcceptsReturn = true;
			this.txtCopias1.BackColor = System.Drawing.SystemColors.Window;
			this.txtCopias1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCopias1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCopias1.Location = new System.Drawing.Point(304, 48);
			this.txtCopias1.MaxLength = 0;
			this.txtCopias1.Name = "txtCopias1";
			this.txtCopias1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCopias1.Size = new System.Drawing.Size(25, 20);
			this.txtCopias1.TabIndex = 4;
			// 
			// cmbRazonSocial1
			// 
			this.cmbRazonSocial1.BackColor = System.Drawing.SystemColors.Window;
			this.cmbRazonSocial1.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbRazonSocial1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbRazonSocial1.Location = new System.Drawing.Point(8, 24);
			this.cmbRazonSocial1.Name = "cmbRazonSocial1";
			this.cmbRazonSocial1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbRazonSocial1.Size = new System.Drawing.Size(329, 21);
			this.cmbRazonSocial1.Sorted = true;
			this.cmbRazonSocial1.TabIndex = 1;
			// 
			// _Lbl_30
			// 
			this._Lbl_30.AutoSize = true;
			this._Lbl_30.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_30.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_30.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_30.Location = new System.Drawing.Point(168, 96);
			this._Lbl_30.Name = "_Lbl_30";
			this._Lbl_30.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_30.Size = new System.Drawing.Size(21, 13);
			this._Lbl_30.TabIndex = 76;
			this._Lbl_30.Text = "CP";
			this._Lbl_30.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblCP1
			// 
			this.lblCP1.BackColor = System.Drawing.SystemColors.Control;
			this.lblCP1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCP1.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCP1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCP1.Location = new System.Drawing.Point(168, 112);
			this.lblCP1.Name = "lblCP1";
			this.lblCP1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCP1.Size = new System.Drawing.Size(65, 20);
			this.lblCP1.TabIndex = 75;
			// 
			// lblProvincia1
			// 
			this.lblProvincia1.BackColor = System.Drawing.SystemColors.Control;
			this.lblProvincia1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProvincia1.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblProvincia1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProvincia1.Location = new System.Drawing.Point(240, 112);
			this.lblProvincia1.Name = "lblProvincia1";
			this.lblProvincia1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblProvincia1.Size = new System.Drawing.Size(97, 20);
			this.lblProvincia1.TabIndex = 5;
			// 
			// lblLocalidad1
			// 
			this.lblLocalidad1.BackColor = System.Drawing.SystemColors.Control;
			this.lblLocalidad1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLocalidad1.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLocalidad1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLocalidad1.Location = new System.Drawing.Point(8, 112);
			this.lblLocalidad1.Name = "lblLocalidad1";
			this.lblLocalidad1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLocalidad1.Size = new System.Drawing.Size(153, 20);
			this.lblLocalidad1.TabIndex = 7;
			// 
			// lblDireccion1
			// 
			this.lblDireccion1.BackColor = System.Drawing.SystemColors.Control;
			this.lblDireccion1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDireccion1.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDireccion1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDireccion1.Location = new System.Drawing.Point(8, 72);
			this.lblDireccion1.Name = "lblDireccion1";
			this.lblDireccion1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDireccion1.Size = new System.Drawing.Size(321, 20);
			this.lblDireccion1.TabIndex = 6;
			// 
			// _Lbl_13
			// 
			this._Lbl_13.AutoSize = true;
			this._Lbl_13.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_13.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_13.Location = new System.Drawing.Point(264, 48);
			this._Lbl_13.Name = "_Lbl_13";
			this._Lbl_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_13.Size = new System.Drawing.Size(39, 13);
			this._Lbl_13.TabIndex = 11;
			this._Lbl_13.Text = "Copias";
			this._Lbl_13.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_1
			// 
			this._Lbl_1.AutoSize = true;
			this._Lbl_1.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_1.Location = new System.Drawing.Point(8, 56);
			this._Lbl_1.Name = "_Lbl_1";
			this._Lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_1.Size = new System.Drawing.Size(52, 13);
			this._Lbl_1.TabIndex = 10;
			this._Lbl_1.Text = "Direccion";
			this._Lbl_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_2
			// 
			this._Lbl_2.AutoSize = true;
			this._Lbl_2.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_2.Location = new System.Drawing.Point(8, 96);
			this._Lbl_2.Name = "_Lbl_2";
			this._Lbl_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_2.Size = new System.Drawing.Size(53, 13);
			this._Lbl_2.TabIndex = 9;
			this._Lbl_2.Text = "Localidad";
			this._Lbl_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_3
			// 
			this._Lbl_3.AutoSize = true;
			this._Lbl_3.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_3.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_3.Location = new System.Drawing.Point(240, 96);
			this._Lbl_3.Name = "_Lbl_3";
			this._Lbl_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_3.Size = new System.Drawing.Size(51, 13);
			this._Lbl_3.TabIndex = 8;
			this._Lbl_3.Text = "Provincia";
			this._Lbl_3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_0
			// 
			this._Lbl_0.AutoSize = true;
			this._Lbl_0.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_0.Location = new System.Drawing.Point(8, 8);
			this._Lbl_0.Name = "_Lbl_0";
			this._Lbl_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_0.Size = new System.Drawing.Size(70, 13);
			this._Lbl_0.TabIndex = 2;
			this._Lbl_0.Text = "Razon Social";
			this._Lbl_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Toolbar1
			// 
			this.Toolbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tlbNuevo,
			this.toolStripSeparator1,
			this.tlbGuardar,
			this.toolStripSeparator2,
			this.tbImprimir,
			this.toolStripSeparator3,
			this.tlbAnual,
			this.toolStripSeparator4,
			this.tlbEditar,
			this.toolStripSeparator5,
			this.tlbCorreo,
			this.tlbCarteles});
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.Size = new System.Drawing.Size(1298, 29);
			this.Toolbar1.TabIndex = 159;
			// 
			// tlbNuevo
			// 
			this.tlbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tlbNuevo.Image")));
			this.tlbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbNuevo.Name = "tlbNuevo";
			this.tlbNuevo.Size = new System.Drawing.Size(26, 26);
			this.tlbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbNuevo.ToolTipText = "Nuevo";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
			// 
			// tlbGuardar
			// 
			this.tlbGuardar.Enabled = false;
			this.tlbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tlbGuardar.Image")));
			this.tlbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbGuardar.Name = "tlbGuardar";
			this.tlbGuardar.Size = new System.Drawing.Size(26, 26);
			this.tlbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbGuardar.ToolTipText = "Guardar";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
			// 
			// tbImprimir
			// 
			this.tbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tbImprimir.Image")));
			this.tbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tbImprimir.Name = "tbImprimir";
			this.tbImprimir.Size = new System.Drawing.Size(26, 26);
			this.tbImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbImprimir.ToolTipText = "Imprimir";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
			// 
			// tlbAnual
			// 
			this.tlbAnual.Image = ((System.Drawing.Image)(resources.GetObject("tlbAnual.Image")));
			this.tlbAnual.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbAnual.Name = "tlbAnual";
			this.tlbAnual.Size = new System.Drawing.Size(26, 26);
			this.tlbAnual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbAnual.ToolTipText = "Anular";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
			// 
			// tlbEditar
			// 
			this.tlbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tlbEditar.Image")));
			this.tlbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbEditar.Name = "tlbEditar";
			this.tlbEditar.Size = new System.Drawing.Size(26, 26);
			this.tlbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbEditar.ToolTipText = "Editar";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
			// 
			// tlbCorreo
			// 
			this.tlbCorreo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlbCorreo.Image = ((System.Drawing.Image)(resources.GetObject("tlbCorreo.Image")));
			this.tlbCorreo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbCorreo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlbCorreo.Name = "tlbCorreo";
			this.tlbCorreo.Size = new System.Drawing.Size(26, 26);
			this.tlbCorreo.Text = "Correspondencia";
			// 
			// tlbCarteles
			// 
			this.tlbCarteles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlbCarteles.Image = ((System.Drawing.Image)(resources.GetObject("tlbCarteles.Image")));
			this.tlbCarteles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbCarteles.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlbCarteles.Name = "tlbCarteles";
			this.tlbCarteles.Size = new System.Drawing.Size(26, 26);
			this.tlbCarteles.Text = "Cartel";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(424, 40);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(786, 400);
			this.dataGridView1.TabIndex = 160;
			// 
			// frmCarteles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1298, 663);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Toolbar1);
			this.Controls.Add(this.Cartel1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 25);
			this.Name = "frmCarteles";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Generador de Carteles";
			this.Load += new System.EventHandler(this.FrmCartelesLoad);
			this.Cartel1.ResumeLayout(false);
			this.Cartel1.PerformLayout();
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
	}
}
