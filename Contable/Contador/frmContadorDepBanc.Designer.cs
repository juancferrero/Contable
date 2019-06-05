
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	
	partial class frmContadorDepBanc
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmContadorDepBanc() : base()
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
		public System.Windows.Forms.ComboBox cmbAno;
		public System.Windows.Forms.ComboBox cmbMes;
		public System.Windows.Forms.ToolStripMenuItem _Toolbar1_Button1_ButtonMenu1;
		public System.Windows.Forms.ToolStripMenuItem _Toolbar1_Button1_ButtonMenu2;
		public System.Windows.Forms.ToolStripDropDownButton _Toolbar1_Button1;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button2;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button3;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button4;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button5;
		public System.Windows.Forms.ToolStripDropDownButton _Toolbar1_Button6;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.Label Label4;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.cmbAno = new System.Windows.Forms.ComboBox();
			this.cmbMes = new System.Windows.Forms.ComboBox();
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this._Toolbar1_Button1 = new System.Windows.Forms.ToolStripDropDownButton();
			this._Toolbar1_Button1_ButtonMenu1 = new System.Windows.Forms.ToolStripMenuItem();
			this._Toolbar1_Button1_ButtonMenu2 = new System.Windows.Forms.ToolStripMenuItem();
			this._Toolbar1_Button2 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button3 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button4 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button5 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button6 = new System.Windows.Forms.ToolStripDropDownButton();
			this.Label4 = new System.Windows.Forms.Label();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.Toolbar1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbAno
			// 
			this.cmbAno.BackColor = System.Drawing.SystemColors.Window;
			this.cmbAno.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbAno.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbAno.Location = new System.Drawing.Point(232, 120);
			this.cmbAno.Name = "cmbAno";
			this.cmbAno.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbAno.Size = new System.Drawing.Size(121, 21);
			this.cmbAno.TabIndex = 1;
			this.cmbAno.Text = "cmbAno";
			// 
			// cmbMes
			// 
			this.cmbMes.BackColor = System.Drawing.SystemColors.Window;
			this.cmbMes.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbMes.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbMes.Location = new System.Drawing.Point(88, 120);
			this.cmbMes.Name = "cmbMes";
			this.cmbMes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbMes.Size = new System.Drawing.Size(121, 21);
			this.cmbMes.TabIndex = 0;
			this.cmbMes.Text = "cmbMes";
			// 
			// Toolbar1
			// 
			this.Toolbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this._Toolbar1_Button1,
									this._Toolbar1_Button2,
									this._Toolbar1_Button3,
									this._Toolbar1_Button4,
									this._Toolbar1_Button5,
									this._Toolbar1_Button6});
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.Size = new System.Drawing.Size(1016, 40);
			this.Toolbar1.TabIndex = 3;
			// 
			// _Toolbar1_Button1
			// 
			this._Toolbar1_Button1.AutoSize = false;
			this._Toolbar1_Button1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this._Toolbar1_Button1_ButtonMenu1,
									this._Toolbar1_Button1_ButtonMenu2});
			this._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button1.Name = "_Toolbar1_Button1";
			this._Toolbar1_Button1.Size = new System.Drawing.Size(88, 37);
			this._Toolbar1_Button1.Text = "[Actualizar]";
			this._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// _Toolbar1_Button1_ButtonMenu1
			// 
			this._Toolbar1_Button1_ButtonMenu1.Name = "_Toolbar1_Button1_ButtonMenu1";
			this._Toolbar1_Button1_ButtonMenu1.Size = new System.Drawing.Size(67, 22);
			// 
			// _Toolbar1_Button1_ButtonMenu2
			// 
			this._Toolbar1_Button1_ButtonMenu2.Name = "_Toolbar1_Button1_ButtonMenu2";
			this._Toolbar1_Button1_ButtonMenu2.Size = new System.Drawing.Size(67, 22);
			// 
			// _Toolbar1_Button2
			// 
			this._Toolbar1_Button2.AutoSize = false;
			this._Toolbar1_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button2.Name = "_Toolbar1_Button2";
			this._Toolbar1_Button2.Size = new System.Drawing.Size(75, 37);
			this._Toolbar1_Button2.Text = "[Imprimir]";
			this._Toolbar1_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// _Toolbar1_Button3
			// 
			this._Toolbar1_Button3.AutoSize = false;
			this._Toolbar1_Button3.Name = "_Toolbar1_Button3";
			this._Toolbar1_Button3.Size = new System.Drawing.Size(75, 37);
			// 
			// _Toolbar1_Button4
			// 
			this._Toolbar1_Button4.AutoSize = false;
			this._Toolbar1_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button4.Name = "_Toolbar1_Button4";
			this._Toolbar1_Button4.Size = new System.Drawing.Size(75, 37);
			this._Toolbar1_Button4.Text = "Enviar a Excel";
			this._Toolbar1_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// _Toolbar1_Button5
			// 
			this._Toolbar1_Button5.AutoSize = false;
			this._Toolbar1_Button5.Name = "_Toolbar1_Button5";
			this._Toolbar1_Button5.Size = new System.Drawing.Size(75, 37);
			// 
			// _Toolbar1_Button6
			// 
			this._Toolbar1_Button6.AutoSize = false;
			this._Toolbar1_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button6.Name = "_Toolbar1_Button6";
			this._Toolbar1_Button6.Size = new System.Drawing.Size(88, 37);
			this._Toolbar1_Button6.Text = "Mes";
			this._Toolbar1_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// Label4
			// 
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(24, 120);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(57, 17);
			this.Label4.TabIndex = 4;
			this.Label4.Text = "Fecha";
			// 
			// DataGridView1
			// 
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(27, 184);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new System.Drawing.Size(217, 183);
			this.DataGridView1.TabIndex = 5;
			// 
			// frmContadorDepBanc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1016, 734);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.cmbAno);
			this.Controls.Add(this.cmbMes);
			this.Controls.Add(this.Toolbar1);
			this.Controls.Add(this.Label4);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 30);
			this.Name = "frmContadorDepBanc";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Depositos Bancarios";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
			#endregion
		internal System.Windows.Forms.DataGridView DataGridView1;
	}
}
