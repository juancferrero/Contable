
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	partial class frmContadorIVACompras
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmContadorIVACompras() : base()
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
		public System.Windows.Forms.ComboBox cmbAno;
		public System.Windows.Forms.ComboBox cmbMes;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button2;
		public System.Windows.Forms.ToolStrip Toolbar1;
		//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
		//Se puede modificar mediante el Diseñador de Windows Forms.
		//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContadorIVACompras));
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.cmbAno = new System.Windows.Forms.ComboBox();
			this.cmbMes = new System.Windows.Forms.ComboBox();
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this.tlbNuevo = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button2 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbGuardar = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button4 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbImprimir = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button6 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbAnular = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button8 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbEditar = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button10 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbListar = new System.Windows.Forms.ToolStripButton();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.tabConceptos = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.Toolbar1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
			this.tabConceptos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbAno
			// 
			this.cmbAno.BackColor = System.Drawing.SystemColors.Window;
			this.cmbAno.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbAno.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbAno.Location = new System.Drawing.Point(570, 48);
			this.cmbAno.Name = "cmbAno";
			this.cmbAno.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbAno.Size = new System.Drawing.Size(121, 21);
			this.cmbAno.TabIndex = 2;
			this.cmbAno.Text = "2003";
			this.cmbAno.DropDown += new System.EventHandler(this.CmbAnoDropDown);
			this.cmbAno.SelectedIndexChanged += new System.EventHandler(this.CmbAnoSelectedIndexChanged);
			// 
			// cmbMes
			// 
			this.cmbMes.BackColor = System.Drawing.SystemColors.Window;
			this.cmbMes.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbMes.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbMes.Location = new System.Drawing.Point(426, 48);
			this.cmbMes.Name = "cmbMes";
			this.cmbMes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbMes.Size = new System.Drawing.Size(121, 21);
			this.cmbMes.TabIndex = 1;
			this.cmbMes.Text = "1";
			this.cmbMes.DropDown += new System.EventHandler(this.CmbMesDropDown);
			this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.CmbMesSelectedIndexChanged);
			// 
			// Toolbar1
			// 
			this.Toolbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tlbNuevo,
			this._Toolbar1_Button2,
			this.tlbGuardar,
			this._Toolbar1_Button4,
			this.tlbImprimir,
			this._Toolbar1_Button6,
			this.tlbAnular,
			this._Toolbar1_Button8,
			this.tlbEditar,
			this._Toolbar1_Button10,
			this.tlbListar});
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.Size = new System.Drawing.Size(1370, 42);
			this.Toolbar1.TabIndex = 41;
			// 
			// tlbNuevo
			// 
			this.tlbNuevo.AutoSize = false;
			this.tlbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tlbNuevo.Image")));
			this.tlbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbNuevo.Name = "tlbNuevo";
			this.tlbNuevo.Size = new System.Drawing.Size(40, 39);
			this.tlbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbNuevo.ToolTipText = "Nuevo";
			this.tlbNuevo.Click += new System.EventHandler(this.TlbNuevoClick);
			// 
			// _Toolbar1_Button2
			// 
			this._Toolbar1_Button2.Name = "_Toolbar1_Button2";
			this._Toolbar1_Button2.Size = new System.Drawing.Size(6, 42);
			// 
			// tlbGuardar
			// 
			this.tlbGuardar.AutoSize = false;
			this.tlbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tlbGuardar.Image")));
			this.tlbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbGuardar.Name = "tlbGuardar";
			this.tlbGuardar.Size = new System.Drawing.Size(40, 39);
			this.tlbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbGuardar.ToolTipText = "Guardar";
			// 
			// _Toolbar1_Button4
			// 
			this._Toolbar1_Button4.AutoSize = false;
			this._Toolbar1_Button4.Name = "_Toolbar1_Button4";
			this._Toolbar1_Button4.Size = new System.Drawing.Size(0, 39);
			// 
			// tlbImprimir
			// 
			this.tlbImprimir.AutoSize = false;
			this.tlbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tlbImprimir.Image")));
			this.tlbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbImprimir.Name = "tlbImprimir";
			this.tlbImprimir.Size = new System.Drawing.Size(40, 39);
			this.tlbImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbImprimir.ToolTipText = "Imprimir";
			this.tlbImprimir.Click += new System.EventHandler(this.TlbImprimirClick);
			// 
			// _Toolbar1_Button6
			// 
			this._Toolbar1_Button6.Name = "_Toolbar1_Button6";
			this._Toolbar1_Button6.Size = new System.Drawing.Size(6, 42);
			// 
			// tlbAnular
			// 
			this.tlbAnular.AutoSize = false;
			this.tlbAnular.Image = ((System.Drawing.Image)(resources.GetObject("tlbAnular.Image")));
			this.tlbAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbAnular.Name = "tlbAnular";
			this.tlbAnular.Size = new System.Drawing.Size(40, 39);
			this.tlbAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbAnular.ToolTipText = "Anular";
			this.tlbAnular.Click += new System.EventHandler(this.TlbAnularClick);
			// 
			// _Toolbar1_Button8
			// 
			this._Toolbar1_Button8.Name = "_Toolbar1_Button8";
			this._Toolbar1_Button8.Size = new System.Drawing.Size(6, 42);
			// 
			// tlbEditar
			// 
			this.tlbEditar.AutoSize = false;
			this.tlbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tlbEditar.Image")));
			this.tlbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbEditar.Name = "tlbEditar";
			this.tlbEditar.Size = new System.Drawing.Size(40, 39);
			this.tlbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbEditar.ToolTipText = "Editar";
			this.tlbEditar.Click += new System.EventHandler(this.TlbEditarClick);
			// 
			// _Toolbar1_Button10
			// 
			this._Toolbar1_Button10.Name = "_Toolbar1_Button10";
			this._Toolbar1_Button10.Size = new System.Drawing.Size(6, 42);
			// 
			// tlbListar
			// 
			this.tlbListar.AutoSize = false;
			this.tlbListar.Image = ((System.Drawing.Image)(resources.GetObject("tlbListar.Image")));
			this.tlbListar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbListar.Name = "tlbListar";
			this.tlbListar.Size = new System.Drawing.Size(40, 39);
			this.tlbListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbListar.ToolTipText = "Listar";
			this.tlbListar.Click += new System.EventHandler(this.TlbListarClick);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabGeneral);
			this.tabControl1.Controls.Add(this.tabConceptos);
			this.tabControl1.Location = new System.Drawing.Point(0, 75);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1188, 533);
			this.tabControl1.TabIndex = 42;
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.gridDatos);
			this.tabGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabGeneral.Size = new System.Drawing.Size(1180, 507);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			this.tabGeneral.UseVisualStyleBackColor = true;
			// 
			// gridDatos
			// 
			this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatos.Location = new System.Drawing.Point(0, 0);
			this.gridDatos.Name = "gridDatos";
			this.gridDatos.Size = new System.Drawing.Size(1174, 493);
			this.gridDatos.TabIndex = 6;
			this.gridDatos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridDatosRowHeaderMouseClick);
			this.gridDatos.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.GridDatosRowStateChanged);
			// 
			// tabConceptos
			// 
			this.tabConceptos.Controls.Add(this.dataGridView2);
			this.tabConceptos.Location = new System.Drawing.Point(4, 22);
			this.tabConceptos.Name = "tabConceptos";
			this.tabConceptos.Padding = new System.Windows.Forms.Padding(3);
			this.tabConceptos.Size = new System.Drawing.Size(1180, 507);
			this.tabConceptos.TabIndex = 1;
			this.tabConceptos.Text = "Conceptos";
			this.tabConceptos.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(6, 6);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(1030, 493);
			this.dataGridView2.TabIndex = 7;
			// 
			// frmContadorIVACompras
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1370, 750);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.Toolbar1);
			this.Controls.Add(this.cmbAno);
			this.Controls.Add(this.cmbMes);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 30);
			this.Name = "frmContadorIVACompras";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Subdiario IVA COMPRAS";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmContadorIVAComprasLoad);
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
			this.tabConceptos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
			#endregion
		public System.Windows.Forms.ToolStripButton tlbNuevo;
		public System.Windows.Forms.ToolStripButton tlbGuardar;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button4;
		public System.Windows.Forms.ToolStripButton tlbImprimir;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button6;
		public System.Windows.Forms.ToolStripButton tlbAnular;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button8;
		public System.Windows.Forms.ToolStripButton tlbEditar;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button10;
		public System.Windows.Forms.ToolStripButton tlbListar;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.TabPage tabConceptos;
		internal System.Windows.Forms.DataGridView dataGridView2;
		internal System.Windows.Forms.DataGridView gridDatos;
	}
}
