
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace Contable
{
	partial class frmCheques
	{
		#region "Código generado por el Diseñador de Windows Forms "
		[System.Diagnostics.DebuggerNonUserCode()]
		public frmCheques() : base()
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
				/*if ((components != null)) {
					components.Dispose();
				}*/
			}
			base.Dispose(Disposing);
		}
//Requerido por el Diseñador de Windows Forms
		//private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ComboBox cmbRazonSocial;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtCuenta;
		private System.Windows.Forms.TextBox txtNumCheq;
		private System.Windows.Forms.TextBox txtCP;
		private System.Windows.Forms.TextBox txtSuc;
		private System.Windows.Forms.TextBox txtBanco;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.ToolStripButton tlbNuevo;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button2;
		public System.Windows.Forms.ToolStripButton tlbGuardar;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button4;
		public System.Windows.Forms.ToolStripButton tlbImprimir;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button6;
		public System.Windows.Forms.ToolStripButton tlbAnular;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button8;
		public System.Windows.Forms.ToolStripButton tlbEditar;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button10;
		public System.Windows.Forms.ToolStripButton tlbFacturar;
		//public System.Windows.Forms.ComboBox cmbRazonSocial;
		public System.Windows.Forms.TextBox txtImporte;
		private System.Windows.Forms.Label lblIDCliente;
		private System.Windows.Forms.DateTimePicker dtFechaEmision;
		private System.Windows.Forms.DateTimePicker dtFechaPago;
		//private System.Windows.Forms.DateTimePicker dtFechaPago;
		//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheques));
			this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
			this.txtImporte = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCuenta = new System.Windows.Forms.TextBox();
			this.txtNumCheq = new System.Windows.Forms.TextBox();
			this.txtCP = new System.Windows.Forms.TextBox();
			this.txtSuc = new System.Windows.Forms.TextBox();
			this.txtBanco = new System.Windows.Forms.TextBox();
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
			this.tlbFacturar = new System.Windows.Forms.ToolStripButton();
			this.lblIDCliente = new System.Windows.Forms.Label();
			this.dtFechaEmision = new System.Windows.Forms.DateTimePicker();
			this.dtFechaPago = new System.Windows.Forms.DateTimePicker();
			this.groupBox1.SuspendLayout();
			this.Toolbar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cmbRazonSocial
			// 
			this.cmbRazonSocial.BackColor = System.Drawing.SystemColors.Window;
			this.cmbRazonSocial.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbRazonSocial.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbRazonSocial.Location = new System.Drawing.Point(79, 193);
			this.cmbRazonSocial.Name = "cmbRazonSocial";
			this.cmbRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbRazonSocial.Size = new System.Drawing.Size(321, 21);
			this.cmbRazonSocial.Sorted = true;
			this.cmbRazonSocial.TabIndex = 6;
			this.cmbRazonSocial.DropDown += new System.EventHandler(this.CmbRazonSocialDropDown);
			this.cmbRazonSocial.SelectedIndexChanged += new System.EventHandler(this.CmbRazonSocialSelectedIndexChanged);
			// 
			// txtImporte
			// 
			this.txtImporte.AcceptsReturn = true;
			this.txtImporte.BackColor = System.Drawing.SystemColors.Window;
			this.txtImporte.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtImporte.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtImporte.Location = new System.Drawing.Point(518, 97);
			this.txtImporte.MaxLength = 0;
			this.txtImporte.Name = "txtImporte";
			this.txtImporte.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtImporte.Size = new System.Drawing.Size(165, 20);
			this.txtImporte.TabIndex = 5;
			this.txtImporte.Text = "0";
			// 
			// Label7
			// 
			this.Label7.AutoSize = true;
			this.Label7.BackColor = System.Drawing.SystemColors.Control;
			this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.Location = new System.Drawing.Point(32, 196);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(41, 15);
			this.Label7.TabIndex = 15;
			this.Label7.Text = "Cliente";
			// 
			// Label6
			// 
			this.Label6.AutoSize = true;
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(468, 100);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(44, 15);
			this.Label6.TabIndex = 14;
			this.Label6.Text = "Importe";
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(34, 124);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(84, 15);
			this.Label2.TabIndex = 10;
			this.Label2.Text = "Fecha De Pago";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(34, 97);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(95, 15);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "Fecha De Emisión";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCuenta);
			this.groupBox1.Controls.Add(this.txtNumCheq);
			this.groupBox1.Controls.Add(this.txtCP);
			this.groupBox1.Controls.Add(this.txtSuc);
			this.groupBox1.Controls.Add(this.txtBanco);
			this.groupBox1.Location = new System.Drawing.Point(574, 155);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(109, 96);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos del Cheque";
			// 
			// txtCuenta
			// 
			this.txtCuenta.Location = new System.Drawing.Point(30, 70);
			this.txtCuenta.MaxLength = 11;
			this.txtCuenta.Name = "txtCuenta";
			this.txtCuenta.Size = new System.Drawing.Size(74, 20);
			this.txtCuenta.TabIndex = 4;
			this.txtCuenta.Text = "00000000000";
			// 
			// txtNumCheq
			// 
			this.txtNumCheq.Location = new System.Drawing.Point(48, 44);
			this.txtNumCheq.MaxLength = 8;
			this.txtNumCheq.Name = "txtNumCheq";
			this.txtNumCheq.Size = new System.Drawing.Size(55, 20);
			this.txtNumCheq.TabIndex = 3;
			this.txtNumCheq.Text = "00000000";
			// 
			// txtCP
			// 
			this.txtCP.Location = new System.Drawing.Point(70, 18);
			this.txtCP.MaxLength = 4;
			this.txtCP.Name = "txtCP";
			this.txtCP.Size = new System.Drawing.Size(34, 20);
			this.txtCP.TabIndex = 2;
			this.txtCP.Text = "0000";
			// 
			// txtSuc
			// 
			this.txtSuc.Location = new System.Drawing.Point(40, 19);
			this.txtSuc.MaxLength = 3;
			this.txtSuc.Name = "txtSuc";
			this.txtSuc.Size = new System.Drawing.Size(24, 20);
			this.txtSuc.TabIndex = 1;
			this.txtSuc.Text = "000";
			// 
			// txtBanco
			// 
			this.txtBanco.Location = new System.Drawing.Point(7, 18);
			this.txtBanco.MaxLength = 3;
			this.txtBanco.Name = "txtBanco";
			this.txtBanco.Size = new System.Drawing.Size(27, 20);
			this.txtBanco.TabIndex = 0;
			this.txtBanco.Text = "000";
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
			this.tlbFacturar});
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.Size = new System.Drawing.Size(947, 42);
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
			this.tlbGuardar.Click += new System.EventHandler(this.TlbGuardarClick);
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
			this.tlbImprimir.Enabled = false;
			this.tlbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tlbImprimir.Image")));
			this.tlbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbImprimir.Name = "tlbImprimir";
			this.tlbImprimir.Size = new System.Drawing.Size(40, 39);
			this.tlbImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbImprimir.ToolTipText = "Imprimir";
			// 
			// _Toolbar1_Button6
			// 
			this._Toolbar1_Button6.Name = "_Toolbar1_Button6";
			this._Toolbar1_Button6.Size = new System.Drawing.Size(6, 42);
			// 
			// tlbAnular
			// 
			this.tlbAnular.AutoSize = false;
			this.tlbAnular.Enabled = false;
			this.tlbAnular.Image = ((System.Drawing.Image)(resources.GetObject("tlbAnular.Image")));
			this.tlbAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbAnular.Name = "tlbAnular";
			this.tlbAnular.Size = new System.Drawing.Size(40, 39);
			this.tlbAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbAnular.ToolTipText = "Anular";
			// 
			// _Toolbar1_Button8
			// 
			this._Toolbar1_Button8.Name = "_Toolbar1_Button8";
			this._Toolbar1_Button8.Size = new System.Drawing.Size(6, 42);
			// 
			// tlbEditar
			// 
			this.tlbEditar.AutoSize = false;
			this.tlbEditar.Enabled = false;
			this.tlbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tlbEditar.Image")));
			this.tlbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbEditar.Name = "tlbEditar";
			this.tlbEditar.Size = new System.Drawing.Size(40, 39);
			this.tlbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbEditar.ToolTipText = "Editar";
			// 
			// _Toolbar1_Button10
			// 
			this._Toolbar1_Button10.Name = "_Toolbar1_Button10";
			this._Toolbar1_Button10.Size = new System.Drawing.Size(6, 42);
			// 
			// tlbFacturar
			// 
			this.tlbFacturar.AutoSize = false;
			this.tlbFacturar.Enabled = false;
			this.tlbFacturar.Image = ((System.Drawing.Image)(resources.GetObject("tlbFacturar.Image")));
			this.tlbFacturar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbFacturar.Name = "tlbFacturar";
			this.tlbFacturar.Size = new System.Drawing.Size(40, 39);
			this.tlbFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbFacturar.ToolTipText = "Facturar";
			// 
			// lblIDCliente
			// 
			this.lblIDCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblIDCliente.Location = new System.Drawing.Point(406, 195);
			this.lblIDCliente.Name = "lblIDCliente";
			this.lblIDCliente.Size = new System.Drawing.Size(129, 16);
			this.lblIDCliente.TabIndex = 42;
			// 
			// dtFechaEmision
			// 
			this.dtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaEmision.Location = new System.Drawing.Point(148, 97);
			this.dtFechaEmision.Name = "dtFechaEmision";
			this.dtFechaEmision.Size = new System.Drawing.Size(104, 20);
			this.dtFechaEmision.TabIndex = 43;
			// 
			// dtFechaPago
			// 
			this.dtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaPago.Location = new System.Drawing.Point(148, 118);
			this.dtFechaPago.Name = "dtFechaPago";
			this.dtFechaPago.Size = new System.Drawing.Size(104, 20);
			this.dtFechaPago.TabIndex = 44;
			// 
			// frmCheques
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(947, 336);
			this.Controls.Add(this.dtFechaPago);
			this.Controls.Add(this.dtFechaEmision);
			this.Controls.Add(this.lblIDCliente);
			this.Controls.Add(this.Toolbar1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.cmbRazonSocial);
			this.Controls.Add(this.txtImporte);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(4, 30);
			this.Name = "frmCheques";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Cheques Nuevos";
			this.Load += new System.EventHandler(this.FrmChequesLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
	}
}
