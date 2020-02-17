
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	
	partial class frmBancos
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmBancos() : base()
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
		private System.ComponentModel.IContainer components = new System.ComponentModel.Container();
		public System.Windows.Forms.Button Command2;
		public System.Windows.Forms.Button Command1;
		public System.Windows.Forms.TextBox Text2;
		public System.Windows.Forms.TextBox Text1;
		public System.Windows.Forms.TextBox Text3;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button1;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button2;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button3;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button4;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button5;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button6;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button7;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button8;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button9;
		public System.Windows.Forms.ToolStrip Toolbar1;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBancos));
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this._Toolbar1_Button1 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button2 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button3 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button4 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button5 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button6 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button7 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button8 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button9 = new System.Windows.Forms.ToolStripButton();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabGeneral = new System.Windows.Forms.TabPage();
			this.tabDatos = new System.Windows.Forms.TabPage();
			this.tabBusqueda = new System.Windows.Forms.TabPage();
			this.DataGridView2 = new System.Windows.Forms.DataGridView();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Command2 = new System.Windows.Forms.Button();
			this.Command1 = new System.Windows.Forms.Button();
			this.Text2 = new System.Windows.Forms.TextBox();
			this.Text1 = new System.Windows.Forms.TextBox();
			this.Text3 = new System.Windows.Forms.TextBox();
			this.Toolbar1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			this.tabDatos.SuspendLayout();
			this.tabBusqueda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// Toolbar1
			// 
			this.Toolbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this._Toolbar1_Button1,
			this._Toolbar1_Button2,
			this._Toolbar1_Button3,
			this._Toolbar1_Button4,
			this._Toolbar1_Button5,
			this._Toolbar1_Button6,
			this._Toolbar1_Button7,
			this._Toolbar1_Button8,
			this._Toolbar1_Button9});
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.Size = new System.Drawing.Size(1370, 42);
			this.Toolbar1.TabIndex = 2;
			// 
			// _Toolbar1_Button1
			// 
			this._Toolbar1_Button1.AutoSize = false;
			this._Toolbar1_Button1.Image = ((System.Drawing.Image)(resources.GetObject("_Toolbar1_Button1.Image")));
			this._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button1.Name = "_Toolbar1_Button1";
			this._Toolbar1_Button1.Size = new System.Drawing.Size(40, 39);
			this._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button1.ToolTipText = "Nuevo";
			// 
			// _Toolbar1_Button2
			// 
			this._Toolbar1_Button2.Name = "_Toolbar1_Button2";
			this._Toolbar1_Button2.Size = new System.Drawing.Size(6, 42);
			// 
			// _Toolbar1_Button3
			// 
			this._Toolbar1_Button3.AutoSize = false;
			this._Toolbar1_Button3.Image = ((System.Drawing.Image)(resources.GetObject("_Toolbar1_Button3.Image")));
			this._Toolbar1_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button3.Name = "_Toolbar1_Button3";
			this._Toolbar1_Button3.Size = new System.Drawing.Size(40, 39);
			this._Toolbar1_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button3.ToolTipText = "Guardar";
			// 
			// _Toolbar1_Button4
			// 
			this._Toolbar1_Button4.AutoSize = false;
			this._Toolbar1_Button4.Name = "_Toolbar1_Button4";
			this._Toolbar1_Button4.Size = new System.Drawing.Size(0, 39);
			// 
			// _Toolbar1_Button5
			// 
			this._Toolbar1_Button5.AutoSize = false;
			this._Toolbar1_Button5.Enabled = false;
			this._Toolbar1_Button5.Image = ((System.Drawing.Image)(resources.GetObject("_Toolbar1_Button5.Image")));
			this._Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button5.Name = "_Toolbar1_Button5";
			this._Toolbar1_Button5.Size = new System.Drawing.Size(40, 39);
			this._Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button5.ToolTipText = "Imprimir";
			this._Toolbar1_Button5.Click += new System.EventHandler(this._Toolbar1_Button5Click);
			// 
			// _Toolbar1_Button6
			// 
			this._Toolbar1_Button6.Name = "_Toolbar1_Button6";
			this._Toolbar1_Button6.Size = new System.Drawing.Size(6, 42);
			// 
			// _Toolbar1_Button7
			// 
			this._Toolbar1_Button7.AutoSize = false;
			this._Toolbar1_Button7.Enabled = false;
			this._Toolbar1_Button7.Image = ((System.Drawing.Image)(resources.GetObject("_Toolbar1_Button7.Image")));
			this._Toolbar1_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button7.Name = "_Toolbar1_Button7";
			this._Toolbar1_Button7.Size = new System.Drawing.Size(40, 39);
			this._Toolbar1_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button7.ToolTipText = "Anular";
			// 
			// _Toolbar1_Button8
			// 
			this._Toolbar1_Button8.Name = "_Toolbar1_Button8";
			this._Toolbar1_Button8.Size = new System.Drawing.Size(6, 42);
			// 
			// _Toolbar1_Button9
			// 
			this._Toolbar1_Button9.AutoSize = false;
			this._Toolbar1_Button9.Enabled = false;
			this._Toolbar1_Button9.Image = ((System.Drawing.Image)(resources.GetObject("_Toolbar1_Button9.Image")));
			this._Toolbar1_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button9.Name = "_Toolbar1_Button9";
			this._Toolbar1_Button9.Size = new System.Drawing.Size(40, 39);
			this._Toolbar1_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button9.ToolTipText = "Editar";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabGeneral);
			this.tabControl1.Controls.Add(this.tabDatos);
			this.tabControl1.Controls.Add(this.tabBusqueda);
			this.tabControl1.Location = new System.Drawing.Point(12, 64);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(976, 321);
			this.tabControl1.TabIndex = 9;
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.Command2);
			this.tabGeneral.Controls.Add(this.Command1);
			this.tabGeneral.Controls.Add(this.Text2);
			this.tabGeneral.Controls.Add(this.Text1);
			this.tabGeneral.Controls.Add(this.Text3);
			this.tabGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.tabGeneral.Size = new System.Drawing.Size(968, 295);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			this.tabGeneral.UseVisualStyleBackColor = true;
			// 
			// tabDatos
			// 
			this.tabDatos.Controls.Add(this.DataGridView1);
			this.tabDatos.Location = new System.Drawing.Point(4, 22);
			this.tabDatos.Name = "tabDatos";
			this.tabDatos.Padding = new System.Windows.Forms.Padding(3);
			this.tabDatos.Size = new System.Drawing.Size(563, 295);
			this.tabDatos.TabIndex = 1;
			this.tabDatos.Text = "Datos";
			this.tabDatos.UseVisualStyleBackColor = true;
			// 
			// tabBusqueda
			// 
			this.tabBusqueda.Controls.Add(this.DataGridView2);
			this.tabBusqueda.Location = new System.Drawing.Point(4, 22);
			this.tabBusqueda.Name = "tabBusqueda";
			this.tabBusqueda.Size = new System.Drawing.Size(563, 295);
			this.tabBusqueda.TabIndex = 2;
			this.tabBusqueda.Text = "Busqueda";
			this.tabBusqueda.UseVisualStyleBackColor = true;
			// 
			// DataGridView2
			// 
			this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView2.Location = new System.Drawing.Point(161, 72);
			this.DataGridView2.Name = "DataGridView2";
			this.DataGridView2.Size = new System.Drawing.Size(240, 150);
			this.DataGridView2.TabIndex = 10;
			// 
			// DataGridView1
			// 
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(161, 72);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new System.Drawing.Size(240, 150);
			this.DataGridView1.TabIndex = 9;
			// 
			// Command2
			// 
			this.Command2.BackColor = System.Drawing.SystemColors.Control;
			this.Command2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command2.Location = new System.Drawing.Point(65, 142);
			this.Command2.Name = "Command2";
			this.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command2.Size = new System.Drawing.Size(153, 25);
			this.Command2.TabIndex = 12;
			this.Command2.Text = "Command2";
			this.Command2.UseVisualStyleBackColor = false;
			// 
			// Command1
			// 
			this.Command1.BackColor = System.Drawing.SystemColors.Control;
			this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Command1.Location = new System.Drawing.Point(49, 62);
			this.Command1.Name = "Command1";
			this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Command1.Size = new System.Drawing.Size(137, 57);
			this.Command1.TabIndex = 11;
			this.Command1.Text = "Command1";
			this.Command1.UseVisualStyleBackColor = false;
			// 
			// Text2
			// 
			this.Text2.AcceptsReturn = true;
			this.Text2.BackColor = System.Drawing.SystemColors.Window;
			this.Text2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text2.Location = new System.Drawing.Point(281, 70);
			this.Text2.MaxLength = 0;
			this.Text2.Name = "Text2";
			this.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text2.Size = new System.Drawing.Size(217, 20);
			this.Text2.TabIndex = 10;
			this.Text2.Text = "Clientes";
			// 
			// Text1
			// 
			this.Text1.AcceptsReturn = true;
			this.Text1.BackColor = System.Drawing.SystemColors.Window;
			this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text1.Location = new System.Drawing.Point(281, 38);
			this.Text1.MaxLength = 0;
			this.Text1.Name = "Text1";
			this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text1.Size = new System.Drawing.Size(217, 20);
			this.Text1.TabIndex = 9;
			this.Text1.Text = "*";
			// 
			// Text3
			// 
			this.Text3.AcceptsReturn = true;
			this.Text3.BackColor = System.Drawing.SystemColors.Window;
			this.Text3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text3.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text3.Location = new System.Drawing.Point(281, 102);
			this.Text3.MaxLength = 0;
			this.Text3.Name = "Text3";
			this.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text3.Size = new System.Drawing.Size(217, 20);
			this.Text3.TabIndex = 8;
			this.Text3.Text = "Nombre = N";
			// 
			// frmBancos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.Toolbar1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 30);
			this.Name = "frmBancos";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "ABM Bancos";
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.tabGeneral.PerformLayout();
			this.tabDatos.ResumeLayout(false);
			this.tabBusqueda.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.DataGridView DataGridView1;
			#endregion
		internal System.Windows.Forms.DataGridView DataGridView2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabGeneral;
		private System.Windows.Forms.TabPage tabDatos;
		private System.Windows.Forms.TabPage tabBusqueda;
	}
}
