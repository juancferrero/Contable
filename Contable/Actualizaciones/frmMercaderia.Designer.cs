
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	
	partial class frmMercaderia
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmMercaderia() : base()
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
		public System.Windows.Forms.TabPage _tabMercaderia_TabPage0;
		public System.Windows.Forms.TabPage _tabMercaderia_TabPage1;
		public System.Windows.Forms.TabPage _tabMercaderia_TabPage2;
		public System.Windows.Forms.TabPage _tabMercaderia_TabPage3;
		public System.Windows.Forms.TabPage _tabMercaderia_TabPage4;
		public System.Windows.Forms.TabPage _tabMercaderia_TabPage5;
		public System.Windows.Forms.TabPage _tabMercaderia_TabPage6;
		public System.Windows.Forms.TabPage _tabMercaderia_TabPage7;
		public System.Windows.Forms.TabPage _tabMercaderia_TabPage8;
		public System.Windows.Forms.TabPage _tabMercaderia_TabPage9;
		public System.Windows.Forms.TabControl tabMercaderia;
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
			this.components = new System.ComponentModel.Container();
			this.tabMercaderia = new System.Windows.Forms.TabControl();
			this._tabMercaderia_TabPage0 = new System.Windows.Forms.TabPage();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this._tabMercaderia_TabPage1 = new System.Windows.Forms.TabPage();
			this.DataGridView2 = new System.Windows.Forms.DataGridView();
			this._tabMercaderia_TabPage2 = new System.Windows.Forms.TabPage();
			this.DataGridView3 = new System.Windows.Forms.DataGridView();
			this._tabMercaderia_TabPage3 = new System.Windows.Forms.TabPage();
			this.DataGridView4 = new System.Windows.Forms.DataGridView();
			this._tabMercaderia_TabPage4 = new System.Windows.Forms.TabPage();
			this.DataGridView5 = new System.Windows.Forms.DataGridView();
			this._tabMercaderia_TabPage5 = new System.Windows.Forms.TabPage();
			this._tabMercaderia_TabPage6 = new System.Windows.Forms.TabPage();
			this.DataGridView6 = new System.Windows.Forms.DataGridView();
			this._tabMercaderia_TabPage7 = new System.Windows.Forms.TabPage();
			this.DataGridView7 = new System.Windows.Forms.DataGridView();
			this._tabMercaderia_TabPage8 = new System.Windows.Forms.TabPage();
			this.DataGridView8 = new System.Windows.Forms.DataGridView();
			this._tabMercaderia_TabPage9 = new System.Windows.Forms.TabPage();
			this.DataGridView9 = new System.Windows.Forms.DataGridView();
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
			this.tabMercaderia.SuspendLayout();
			this._tabMercaderia_TabPage0.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
			this._tabMercaderia_TabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
			this._tabMercaderia_TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).BeginInit();
			this._tabMercaderia_TabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView4)).BeginInit();
			this._tabMercaderia_TabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView5)).BeginInit();
			this._tabMercaderia_TabPage6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView6)).BeginInit();
			this._tabMercaderia_TabPage7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView7)).BeginInit();
			this._tabMercaderia_TabPage8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView8)).BeginInit();
			this._tabMercaderia_TabPage9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView9)).BeginInit();
			this.Toolbar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabMercaderia
			// 
			this.tabMercaderia.Controls.Add(this._tabMercaderia_TabPage0);
			this.tabMercaderia.Controls.Add(this._tabMercaderia_TabPage1);
			this.tabMercaderia.Controls.Add(this._tabMercaderia_TabPage2);
			this.tabMercaderia.Controls.Add(this._tabMercaderia_TabPage3);
			this.tabMercaderia.Controls.Add(this._tabMercaderia_TabPage4);
			this.tabMercaderia.Controls.Add(this._tabMercaderia_TabPage5);
			this.tabMercaderia.Controls.Add(this._tabMercaderia_TabPage6);
			this.tabMercaderia.Controls.Add(this._tabMercaderia_TabPage7);
			this.tabMercaderia.Controls.Add(this._tabMercaderia_TabPage8);
			this.tabMercaderia.Controls.Add(this._tabMercaderia_TabPage9);
			this.tabMercaderia.ItemSize = new System.Drawing.Size(42, 18);
			this.tabMercaderia.Location = new System.Drawing.Point(8, 56);
			this.tabMercaderia.Name = "tabMercaderia";
			this.tabMercaderia.SelectedIndex = 0;
			this.tabMercaderia.Size = new System.Drawing.Size(1003, 676);
			this.tabMercaderia.TabIndex = 1;
			// 
			// _tabMercaderia_TabPage0
			// 
			this._tabMercaderia_TabPage0.Controls.Add(this.DataGridView1);
			this._tabMercaderia_TabPage0.Location = new System.Drawing.Point(4, 22);
			this._tabMercaderia_TabPage0.Name = "_tabMercaderia_TabPage0";
			this._tabMercaderia_TabPage0.Size = new System.Drawing.Size(995, 650);
			this._tabMercaderia_TabPage0.TabIndex = 0;
			this._tabMercaderia_TabPage0.Text = "HERBICIDAS";
			// 
			// DataGridView1
			// 
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(304, 165);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.Size = new System.Drawing.Size(240, 150);
			this.DataGridView1.TabIndex = 0;
			// 
			// _tabMercaderia_TabPage1
			// 
			this._tabMercaderia_TabPage1.Controls.Add(this.DataGridView2);
			this._tabMercaderia_TabPage1.Location = new System.Drawing.Point(4, 22);
			this._tabMercaderia_TabPage1.Name = "_tabMercaderia_TabPage1";
			this._tabMercaderia_TabPage1.Size = new System.Drawing.Size(995, 650);
			this._tabMercaderia_TabPage1.TabIndex = 1;
			this._tabMercaderia_TabPage1.Text = "INSECTICIDAS";
			// 
			// DataGridView2
			// 
			this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView2.Location = new System.Drawing.Point(366, 263);
			this.DataGridView2.Name = "DataGridView2";
			this.DataGridView2.Size = new System.Drawing.Size(240, 150);
			this.DataGridView2.TabIndex = 0;
			// 
			// _tabMercaderia_TabPage2
			// 
			this._tabMercaderia_TabPage2.Controls.Add(this.DataGridView3);
			this._tabMercaderia_TabPage2.Location = new System.Drawing.Point(4, 22);
			this._tabMercaderia_TabPage2.Name = "_tabMercaderia_TabPage2";
			this._tabMercaderia_TabPage2.Size = new System.Drawing.Size(995, 650);
			this._tabMercaderia_TabPage2.TabIndex = 2;
			this._tabMercaderia_TabPage2.Text = "FUNGICIDAS";
			// 
			// DataGridView3
			// 
			this.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView3.Location = new System.Drawing.Point(377, 250);
			this.DataGridView3.Name = "DataGridView3";
			this.DataGridView3.Size = new System.Drawing.Size(240, 150);
			this.DataGridView3.TabIndex = 1;
			// 
			// _tabMercaderia_TabPage3
			// 
			this._tabMercaderia_TabPage3.Controls.Add(this.DataGridView4);
			this._tabMercaderia_TabPage3.Location = new System.Drawing.Point(4, 22);
			this._tabMercaderia_TabPage3.Name = "_tabMercaderia_TabPage3";
			this._tabMercaderia_TabPage3.Size = new System.Drawing.Size(995, 650);
			this._tabMercaderia_TabPage3.TabIndex = 3;
			this._tabMercaderia_TabPage3.Text = "CURASEMILLAS";
			// 
			// DataGridView4
			// 
			this.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView4.Location = new System.Drawing.Point(377, 250);
			this.DataGridView4.Name = "DataGridView4";
			this.DataGridView4.Size = new System.Drawing.Size(240, 150);
			this.DataGridView4.TabIndex = 1;
			// 
			// _tabMercaderia_TabPage4
			// 
			this._tabMercaderia_TabPage4.Controls.Add(this.DataGridView5);
			this._tabMercaderia_TabPage4.Location = new System.Drawing.Point(4, 22);
			this._tabMercaderia_TabPage4.Name = "_tabMercaderia_TabPage4";
			this._tabMercaderia_TabPage4.Size = new System.Drawing.Size(995, 650);
			this._tabMercaderia_TabPage4.TabIndex = 4;
			this._tabMercaderia_TabPage4.Text = "DOMISANITARIOS";
			// 
			// DataGridView5
			// 
			this.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView5.Location = new System.Drawing.Point(377, 250);
			this.DataGridView5.Name = "DataGridView5";
			this.DataGridView5.Size = new System.Drawing.Size(240, 150);
			this.DataGridView5.TabIndex = 1;
			// 
			// _tabMercaderia_TabPage5
			// 
			this._tabMercaderia_TabPage5.Location = new System.Drawing.Point(4, 22);
			this._tabMercaderia_TabPage5.Name = "_tabMercaderia_TabPage5";
			this._tabMercaderia_TabPage5.Size = new System.Drawing.Size(995, 650);
			this._tabMercaderia_TabPage5.TabIndex = 5;
			this._tabMercaderia_TabPage5.Text = "S/C";
			// 
			// _tabMercaderia_TabPage6
			// 
			this._tabMercaderia_TabPage6.Controls.Add(this.DataGridView6);
			this._tabMercaderia_TabPage6.Location = new System.Drawing.Point(4, 22);
			this._tabMercaderia_TabPage6.Name = "_tabMercaderia_TabPage6";
			this._tabMercaderia_TabPage6.Size = new System.Drawing.Size(995, 650);
			this._tabMercaderia_TabPage6.TabIndex = 6;
			this._tabMercaderia_TabPage6.Text = "FITOREGULADOR";
			// 
			// DataGridView6
			// 
			this.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView6.Location = new System.Drawing.Point(377, 250);
			this.DataGridView6.Name = "DataGridView6";
			this.DataGridView6.Size = new System.Drawing.Size(240, 150);
			this.DataGridView6.TabIndex = 1;
			// 
			// _tabMercaderia_TabPage7
			// 
			this._tabMercaderia_TabPage7.Controls.Add(this.DataGridView7);
			this._tabMercaderia_TabPage7.Location = new System.Drawing.Point(4, 22);
			this._tabMercaderia_TabPage7.Name = "_tabMercaderia_TabPage7";
			this._tabMercaderia_TabPage7.Size = new System.Drawing.Size(995, 650);
			this._tabMercaderia_TabPage7.TabIndex = 7;
			this._tabMercaderia_TabPage7.Text = "REPELENTES";
			// 
			// DataGridView7
			// 
			this.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView7.Location = new System.Drawing.Point(377, 250);
			this.DataGridView7.Name = "DataGridView7";
			this.DataGridView7.Size = new System.Drawing.Size(240, 150);
			this.DataGridView7.TabIndex = 1;
			// 
			// _tabMercaderia_TabPage8
			// 
			this._tabMercaderia_TabPage8.Controls.Add(this.DataGridView8);
			this._tabMercaderia_TabPage8.Location = new System.Drawing.Point(4, 22);
			this._tabMercaderia_TabPage8.Name = "_tabMercaderia_TabPage8";
			this._tabMercaderia_TabPage8.Size = new System.Drawing.Size(995, 650);
			this._tabMercaderia_TabPage8.TabIndex = 8;
			this._tabMercaderia_TabPage8.Text = "FERTILIZANTES";
			// 
			// DataGridView8
			// 
			this.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView8.Location = new System.Drawing.Point(377, 250);
			this.DataGridView8.Name = "DataGridView8";
			this.DataGridView8.Size = new System.Drawing.Size(240, 150);
			this.DataGridView8.TabIndex = 1;
			// 
			// _tabMercaderia_TabPage9
			// 
			this._tabMercaderia_TabPage9.Controls.Add(this.DataGridView9);
			this._tabMercaderia_TabPage9.Location = new System.Drawing.Point(4, 22);
			this._tabMercaderia_TabPage9.Name = "_tabMercaderia_TabPage9";
			this._tabMercaderia_TabPage9.Size = new System.Drawing.Size(995, 650);
			this._tabMercaderia_TabPage9.TabIndex = 9;
			this._tabMercaderia_TabPage9.Text = "VARIOS";
			// 
			// DataGridView9
			// 
			this.DataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView9.Location = new System.Drawing.Point(377, 250);
			this.DataGridView9.Name = "DataGridView9";
			this.DataGridView9.Size = new System.Drawing.Size(240, 150);
			this.DataGridView9.TabIndex = 1;
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
			this.Toolbar1.Size = new System.Drawing.Size(1016, 42);
			this.Toolbar1.TabIndex = 0;
			// 
			// _Toolbar1_Button1
			// 
			this._Toolbar1_Button1.AutoSize = false;
			this._Toolbar1_Button1.ImageIndex = -1;
			this._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button1.Name = "_Toolbar1_Button1";
			this._Toolbar1_Button1.Size = new System.Drawing.Size(40, 39);
			this._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button1.ToolTipText = "Nuevo";
			// 
			// _Toolbar1_Button2
			// 
			this._Toolbar1_Button2.AutoSize = false;
			this._Toolbar1_Button2.Name = "_Toolbar1_Button2";
			this._Toolbar1_Button2.Size = new System.Drawing.Size(40, 39);
			// 
			// _Toolbar1_Button3
			// 
			this._Toolbar1_Button3.AutoSize = false;
			this._Toolbar1_Button3.ImageIndex = -1;
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
			this._Toolbar1_Button5.ImageIndex = -1;
			this._Toolbar1_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button5.Name = "_Toolbar1_Button5";
			this._Toolbar1_Button5.Size = new System.Drawing.Size(40, 39);
			this._Toolbar1_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button5.ToolTipText = "Imprimir";
			// 
			// _Toolbar1_Button6
			// 
			this._Toolbar1_Button6.AutoSize = false;
			this._Toolbar1_Button6.Name = "_Toolbar1_Button6";
			this._Toolbar1_Button6.Size = new System.Drawing.Size(40, 39);
			// 
			// _Toolbar1_Button7
			// 
			this._Toolbar1_Button7.AutoSize = false;
			this._Toolbar1_Button7.ImageIndex = -1;
			this._Toolbar1_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button7.Name = "_Toolbar1_Button7";
			this._Toolbar1_Button7.Size = new System.Drawing.Size(40, 39);
			this._Toolbar1_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button7.ToolTipText = "Anular";
			// 
			// _Toolbar1_Button8
			// 
			this._Toolbar1_Button8.AutoSize = false;
			this._Toolbar1_Button8.Name = "_Toolbar1_Button8";
			this._Toolbar1_Button8.Size = new System.Drawing.Size(40, 39);
			// 
			// _Toolbar1_Button9
			// 
			this._Toolbar1_Button9.AutoSize = false;
			this._Toolbar1_Button9.ImageIndex = -1;
			this._Toolbar1_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button9.Name = "_Toolbar1_Button9";
			this._Toolbar1_Button9.Size = new System.Drawing.Size(40, 39);
			this._Toolbar1_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button9.ToolTipText = "Editar";
			// 
			// frmMercaderia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1016, 734);
			this.Controls.Add(this.tabMercaderia);
			this.Controls.Add(this.Toolbar1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 30);
			this.Name = "frmMercaderia";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Mecaderia";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.tabMercaderia.ResumeLayout(false);
			this._tabMercaderia_TabPage0.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
			this._tabMercaderia_TabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
			this._tabMercaderia_TabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).EndInit();
			this._tabMercaderia_TabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView4)).EndInit();
			this._tabMercaderia_TabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView5)).EndInit();
			this._tabMercaderia_TabPage6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView6)).EndInit();
			this._tabMercaderia_TabPage7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView7)).EndInit();
			this._tabMercaderia_TabPage8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView8)).EndInit();
			this._tabMercaderia_TabPage9.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView9)).EndInit();
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.DataGridView DataGridView2;
		internal System.Windows.Forms.DataGridView DataGridView3;
		internal System.Windows.Forms.DataGridView DataGridView4;
		internal System.Windows.Forms.DataGridView DataGridView5;
		internal System.Windows.Forms.DataGridView DataGridView6;
		internal System.Windows.Forms.DataGridView DataGridView7;
		internal System.Windows.Forms.DataGridView DataGridView8;
			#endregion
		internal System.Windows.Forms.DataGridView DataGridView9;
	}
}
