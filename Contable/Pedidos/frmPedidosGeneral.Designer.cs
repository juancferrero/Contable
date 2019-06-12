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
		public System.Windows.Forms.RichTextBox richNotas;
		public System.Windows.Forms.Label lblPartida5;
		public System.Windows.Forms.Label lblPartida4;
		public System.Windows.Forms.Label lblPartida3;
		public System.Windows.Forms.Label lblPartida2;
		public System.Windows.Forms.Label lblDescrip5;
		public System.Windows.Forms.Label lblDescrip4;
		public System.Windows.Forms.Label lblDescrip3;
		public System.Windows.Forms.Label lblDescrip2;
		public System.Windows.Forms.Label lblCant5;
		public System.Windows.Forms.Label lblCant4;
		public System.Windows.Forms.Label lblCant3;
		public System.Windows.Forms.Label lblCant2;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label lblDescrip1;
		public System.Windows.Forms.Label lblCant1;
		public System.Windows.Forms.Label lblPartida1;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.GroupBox Frame1;
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
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.richNotas = new System.Windows.Forms.RichTextBox();
			this.lblPartida5 = new System.Windows.Forms.Label();
			this.lblPartida4 = new System.Windows.Forms.Label();
			this.lblPartida3 = new System.Windows.Forms.Label();
			this.lblPartida2 = new System.Windows.Forms.Label();
			this.lblDescrip5 = new System.Windows.Forms.Label();
			this.lblDescrip4 = new System.Windows.Forms.Label();
			this.lblDescrip3 = new System.Windows.Forms.Label();
			this.lblDescrip2 = new System.Windows.Forms.Label();
			this.lblCant5 = new System.Windows.Forms.Label();
			this.lblCant4 = new System.Windows.Forms.Label();
			this.lblCant3 = new System.Windows.Forms.Label();
			this.lblCant2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.lblDescrip1 = new System.Windows.Forms.Label();
			this.lblCant1 = new System.Windows.Forms.Label();
			this.lblPartida1 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this.tbNuevo = new System.Windows.Forms.ToolStripButton();
			this.tbGuardar = new System.Windows.Forms.ToolStripButton();
			this.tbActualizar = new System.Windows.Forms.ToolStripButton();
			this.tbAnular = new System.Windows.Forms.ToolStripButton();
			this.tbEditar = new System.Windows.Forms.ToolStripButton();
			this.tbPasarARemito = new System.Windows.Forms.ToolStripButton();
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.gridDatosPedido = new System.Windows.Forms.DataGridView();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.Frame1.SuspendLayout();
			this.Toolbar1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridDatosPedido)).BeginInit();
			this.SuspendLayout();
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.richNotas);
			this.Frame1.Controls.Add(this.lblPartida5);
			this.Frame1.Controls.Add(this.lblPartida4);
			this.Frame1.Controls.Add(this.lblPartida3);
			this.Frame1.Controls.Add(this.lblPartida2);
			this.Frame1.Controls.Add(this.lblDescrip5);
			this.Frame1.Controls.Add(this.lblDescrip4);
			this.Frame1.Controls.Add(this.lblDescrip3);
			this.Frame1.Controls.Add(this.lblDescrip2);
			this.Frame1.Controls.Add(this.lblCant5);
			this.Frame1.Controls.Add(this.lblCant4);
			this.Frame1.Controls.Add(this.lblCant3);
			this.Frame1.Controls.Add(this.lblCant2);
			this.Frame1.Controls.Add(this.Label1);
			this.Frame1.Controls.Add(this.Label2);
			this.Frame1.Controls.Add(this.lblDescrip1);
			this.Frame1.Controls.Add(this.lblCant1);
			this.Frame1.Controls.Add(this.lblPartida1);
			this.Frame1.Controls.Add(this.Label4);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(527, 251);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(385, 329);
			this.Frame1.TabIndex = 1;
			this.Frame1.TabStop = false;
			this.Frame1.Text = "Datos del Pedido";
			this.Frame1.Visible = false;
			// 
			// richNotas
			// 
			this.richNotas.Location = new System.Drawing.Point(16, 152);
			this.richNotas.Name = "richNotas";
			this.richNotas.Size = new System.Drawing.Size(353, 121);
			this.richNotas.TabIndex = 20;
			this.richNotas.Text = "";
			// 
			// lblPartida5
			// 
			this.lblPartida5.BackColor = System.Drawing.SystemColors.Control;
			this.lblPartida5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPartida5.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblPartida5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPartida5.Location = new System.Drawing.Point(64, 128);
			this.lblPartida5.Name = "lblPartida5";
			this.lblPartida5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPartida5.Size = new System.Drawing.Size(105, 17);
			this.lblPartida5.TabIndex = 19;
			// 
			// lblPartida4
			// 
			this.lblPartida4.BackColor = System.Drawing.SystemColors.Control;
			this.lblPartida4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPartida4.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblPartida4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPartida4.Location = new System.Drawing.Point(64, 112);
			this.lblPartida4.Name = "lblPartida4";
			this.lblPartida4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPartida4.Size = new System.Drawing.Size(105, 17);
			this.lblPartida4.TabIndex = 18;
			// 
			// lblPartida3
			// 
			this.lblPartida3.BackColor = System.Drawing.SystemColors.Control;
			this.lblPartida3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPartida3.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblPartida3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPartida3.Location = new System.Drawing.Point(64, 96);
			this.lblPartida3.Name = "lblPartida3";
			this.lblPartida3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPartida3.Size = new System.Drawing.Size(105, 17);
			this.lblPartida3.TabIndex = 17;
			// 
			// lblPartida2
			// 
			this.lblPartida2.BackColor = System.Drawing.SystemColors.Control;
			this.lblPartida2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPartida2.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblPartida2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPartida2.Location = new System.Drawing.Point(64, 80);
			this.lblPartida2.Name = "lblPartida2";
			this.lblPartida2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPartida2.Size = new System.Drawing.Size(105, 17);
			this.lblPartida2.TabIndex = 16;
			// 
			// lblDescrip5
			// 
			this.lblDescrip5.BackColor = System.Drawing.SystemColors.Control;
			this.lblDescrip5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDescrip5.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDescrip5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDescrip5.Location = new System.Drawing.Point(176, 128);
			this.lblDescrip5.Name = "lblDescrip5";
			this.lblDescrip5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDescrip5.Size = new System.Drawing.Size(193, 17);
			this.lblDescrip5.TabIndex = 15;
			// 
			// lblDescrip4
			// 
			this.lblDescrip4.BackColor = System.Drawing.SystemColors.Control;
			this.lblDescrip4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDescrip4.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDescrip4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDescrip4.Location = new System.Drawing.Point(176, 112);
			this.lblDescrip4.Name = "lblDescrip4";
			this.lblDescrip4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDescrip4.Size = new System.Drawing.Size(193, 17);
			this.lblDescrip4.TabIndex = 14;
			// 
			// lblDescrip3
			// 
			this.lblDescrip3.BackColor = System.Drawing.SystemColors.Control;
			this.lblDescrip3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDescrip3.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDescrip3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDescrip3.Location = new System.Drawing.Point(176, 96);
			this.lblDescrip3.Name = "lblDescrip3";
			this.lblDescrip3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDescrip3.Size = new System.Drawing.Size(193, 17);
			this.lblDescrip3.TabIndex = 13;
			// 
			// lblDescrip2
			// 
			this.lblDescrip2.BackColor = System.Drawing.SystemColors.Control;
			this.lblDescrip2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDescrip2.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDescrip2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDescrip2.Location = new System.Drawing.Point(176, 80);
			this.lblDescrip2.Name = "lblDescrip2";
			this.lblDescrip2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDescrip2.Size = new System.Drawing.Size(193, 17);
			this.lblDescrip2.TabIndex = 12;
			// 
			// lblCant5
			// 
			this.lblCant5.BackColor = System.Drawing.SystemColors.Control;
			this.lblCant5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCant5.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCant5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCant5.Location = new System.Drawing.Point(16, 128);
			this.lblCant5.Name = "lblCant5";
			this.lblCant5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCant5.Size = new System.Drawing.Size(40, 17);
			this.lblCant5.TabIndex = 11;
			// 
			// lblCant4
			// 
			this.lblCant4.BackColor = System.Drawing.SystemColors.Control;
			this.lblCant4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCant4.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCant4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCant4.Location = new System.Drawing.Point(16, 112);
			this.lblCant4.Name = "lblCant4";
			this.lblCant4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCant4.Size = new System.Drawing.Size(40, 17);
			this.lblCant4.TabIndex = 10;
			// 
			// lblCant3
			// 
			this.lblCant3.BackColor = System.Drawing.SystemColors.Control;
			this.lblCant3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCant3.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCant3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCant3.Location = new System.Drawing.Point(16, 96);
			this.lblCant3.Name = "lblCant3";
			this.lblCant3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCant3.Size = new System.Drawing.Size(40, 17);
			this.lblCant3.TabIndex = 9;
			// 
			// lblCant2
			// 
			this.lblCant2.BackColor = System.Drawing.SystemColors.Control;
			this.lblCant2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCant2.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCant2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCant2.Location = new System.Drawing.Point(16, 80);
			this.lblCant2.Name = "lblCant2";
			this.lblCant2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCant2.Size = new System.Drawing.Size(40, 17);
			this.lblCant2.TabIndex = 8;
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(16, 32);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(40, 17);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "Cant";
			// 
			// Label2
			// 
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(176, 32);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(193, 17);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "Descripcion";
			// 
			// lblDescrip1
			// 
			this.lblDescrip1.BackColor = System.Drawing.SystemColors.Control;
			this.lblDescrip1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDescrip1.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDescrip1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDescrip1.Location = new System.Drawing.Point(176, 64);
			this.lblDescrip1.Name = "lblDescrip1";
			this.lblDescrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDescrip1.Size = new System.Drawing.Size(193, 17);
			this.lblDescrip1.TabIndex = 5;
			// 
			// lblCant1
			// 
			this.lblCant1.BackColor = System.Drawing.SystemColors.Control;
			this.lblCant1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCant1.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCant1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCant1.Location = new System.Drawing.Point(16, 64);
			this.lblCant1.Name = "lblCant1";
			this.lblCant1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCant1.Size = new System.Drawing.Size(40, 17);
			this.lblCant1.TabIndex = 4;
			// 
			// lblPartida1
			// 
			this.lblPartida1.BackColor = System.Drawing.SystemColors.Control;
			this.lblPartida1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPartida1.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblPartida1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPartida1.Location = new System.Drawing.Point(64, 64);
			this.lblPartida1.Name = "lblPartida1";
			this.lblPartida1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPartida1.Size = new System.Drawing.Size(105, 17);
			this.lblPartida1.TabIndex = 3;
			// 
			// Label4
			// 
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(64, 32);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(105, 17);
			this.Label4.TabIndex = 2;
			this.Label4.Text = "Partida";
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
			this.Toolbar1.Size = new System.Drawing.Size(1118, 29);
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
			// tbAnular
			// 
			this.tbAnular.Enabled = false;
			this.tbAnular.Image = ((System.Drawing.Image)(resources.GetObject("tbAnular.Image")));
			this.tbAnular.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tbAnular.Name = "tbAnular";
			this.tbAnular.Size = new System.Drawing.Size(26, 26);
			this.tbAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbAnular.ToolTipText = "Anular";
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
			this.gridDatos.Size = new System.Drawing.Size(485, 334);
			this.gridDatos.TabIndex = 22;
			this.gridDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatosCellClick);
			// 
			// gridDatosPedido
			// 
			this.gridDatosPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.gridDatosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatosPedido.Location = new System.Drawing.Point(517, 68);
			this.gridDatosPedido.Name = "gridDatosPedido";
			this.gridDatosPedido.Size = new System.Drawing.Size(547, 166);
			this.gridDatosPedido.TabIndex = 23;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 29);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
			// 
			// frmPedidosGeneral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1118, 750);
			this.Controls.Add(this.gridDatosPedido);
			this.Controls.Add(this.gridDatos);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.Toolbar1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 26);
			this.Name = "frmPedidosGeneral";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Pedidos General";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmPedidosGeneralLoad);
			this.Frame1.ResumeLayout(false);
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
