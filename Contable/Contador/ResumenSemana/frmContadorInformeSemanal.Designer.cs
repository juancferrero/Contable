﻿//using Microsoft.VisualBasic;
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
	partial class frmContadorInformeSemanal
	{
		#region "Código generado por el Diseñador de Windows Forms "
		//[System.Diagnostics.DebuggerNonUserCode()]
		public frmContadorInformeSemanal() : base()
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
		/*[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool Disposing)
		{
			if (Disposing) {
				if ((components != null)) {
					components.Dispose();
				}
			}
			base.Dispose(Disposing);
		}*/
//Requerido por el Diseñador de Windows Forms
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.Label Label18;
		public System.Windows.Forms.Label Label16;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.TabPage _SSTab1_TabPage0;
		public System.Windows.Forms.Label Label17;
		public System.Windows.Forms.Label Label19;
		public System.Windows.Forms.TabPage _SSTab1_TabPage1;
		public System.Windows.Forms.Label Label21;
		public System.Windows.Forms.Label Label20;
		public System.Windows.Forms.TabPage _SSTab1_TabPage2;
		public System.Windows.Forms.Label _Lbl_1;
		public System.Windows.Forms.Label _Lbl_2;
		public System.Windows.Forms.TabPage _SSTab1_TabPage3;
		public System.Windows.Forms.TabPage _SSTab1_TabPage4;
		public System.Windows.Forms.TabPage _SSTab1_TabPage5;
		public System.Windows.Forms.TabPage _SSTab1_TabPage6;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label10;
		public System.Windows.Forms.Button cmdImprimirVentas;
		public System.Windows.Forms.TabPage _SSTab1_TabPage7;
		public System.Windows.Forms.TabPage _SSTab1_TabPage8;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.TextBox txtInterdepositos;
		public System.Windows.Forms.TextBox txtEfectivo;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.TextBox txtFactImpagas;
		public System.Windows.Forms.Label _Lbl_0;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.TextBox Text2;
		public System.Windows.Forms.TextBox txtVentasAcumuladas;
		public System.Windows.Forms.TextBox txtTotalVentas;
		public System.Windows.Forms.TextBox txtVentas;
		public System.Windows.Forms.Label Label15;
		public System.Windows.Forms.Label Label12;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.GroupBox Frame3;
		public System.Windows.Forms.TextBox txtChequesCartera;
		public System.Windows.Forms.TextBox txtValoresEfectCobrados;
		public System.Windows.Forms.TextBox txtChequesDepositados;
		public System.Windows.Forms.TextBox txtRecibos;
		public System.Windows.Forms.TextBox txtTotalCobros;
		public System.Windows.Forms.Label Label14;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label13;
		public System.Windows.Forms.GroupBox Frame4;
		public System.Windows.Forms.TabPage _SSTab1_TabPage9;
		public System.Windows.Forms.TabControl SSTab1;
		//public Microsoft.VisualBasic.Compatibility.VB6.LabelArray Lbl;
//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
//Se puede modificar mediante el Diseñador de Windows Forms.
//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContadorInformeSemanal));
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SSTab1 = new System.Windows.Forms.TabControl();
			this._SSTab1_TabPage0 = new System.Windows.Forms.TabPage();
			this.gridInterdepositosRecibidos = new System.Windows.Forms.DataGridView();
			this.gridChequesRecibidos = new System.Windows.Forms.DataGridView();
			this.gridEfectivo = new System.Windows.Forms.DataGridView();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this._SSTab1_TabPage1 = new System.Windows.Forms.TabPage();
			this.DataGridView4 = new System.Windows.Forms.DataGridView();
			this.DataGridView3 = new System.Windows.Forms.DataGridView();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this._SSTab1_TabPage2 = new System.Windows.Forms.TabPage();
			this.gridChequesDepNoEnFecha = new System.Windows.Forms.DataGridView();
			this.gridChequesDepEnFecha = new System.Windows.Forms.DataGridView();
			this.Label21 = new System.Windows.Forms.Label();
			this.Label20 = new System.Windows.Forms.Label();
			this._SSTab1_TabPage3 = new System.Windows.Forms.TabPage();
			this.gridFactImpagas = new System.Windows.Forms.DataGridView();
			this.gridFactHechas = new System.Windows.Forms.DataGridView();
			this._Lbl_1 = new System.Windows.Forms.Label();
			this._Lbl_2 = new System.Windows.Forms.Label();
			this._SSTab1_TabPage4 = new System.Windows.Forms.TabPage();
			this.gridChequesXCobrar = new System.Windows.Forms.DataGridView();
			this._SSTab1_TabPage5 = new System.Windows.Forms.TabPage();
			this._SSTab1_TabPage6 = new System.Windows.Forms.TabPage();
			this.DataGridView9 = new System.Windows.Forms.DataGridView();
			this._SSTab1_TabPage7 = new System.Windows.Forms.TabPage();
			this.DataGridView13 = new System.Windows.Forms.DataGridView();
			this.DataGridView11 = new System.Windows.Forms.DataGridView();
			this.DataGridView12 = new System.Windows.Forms.DataGridView();
			this.DataGridView10 = new System.Windows.Forms.DataGridView();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.cmdImprimirVentas = new System.Windows.Forms.Button();
			this._SSTab1_TabPage8 = new System.Windows.Forms.TabPage();
			this.label11 = new System.Windows.Forms.Label();
			this.gridRecibos = new System.Windows.Forms.DataGridView();
			this._SSTab1_TabPage9 = new System.Windows.Forms.TabPage();
			this.calCalendario = new System.Windows.Forms.MonthCalendar();
			this.Label9 = new System.Windows.Forms.Label();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.txtInterdepositos = new System.Windows.Forms.TextBox();
			this.txtEfectivo = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.txtFactHechas = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.txtFactImpagas = new System.Windows.Forms.TextBox();
			this._Lbl_0 = new System.Windows.Forms.Label();
			this.Text2 = new System.Windows.Forms.TextBox();
			this.Frame3 = new System.Windows.Forms.GroupBox();
			this.txtVentasAcumuladas = new System.Windows.Forms.TextBox();
			this.txtTotalVentas = new System.Windows.Forms.TextBox();
			this.txtVentas = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Frame4 = new System.Windows.Forms.GroupBox();
			this.txtChequesCartera = new System.Windows.Forms.TextBox();
			this.txtValoresEfectCobrados = new System.Windows.Forms.TextBox();
			this.txtChequesDepositados = new System.Windows.Forms.TextBox();
			this.txtRecibos = new System.Windows.Forms.TextBox();
			this.txtTotalCobros = new System.Windows.Forms.TextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tlActualizar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtChequesRecibidos = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.SSTab1.SuspendLayout();
			this._SSTab1_TabPage0.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridInterdepositosRecibidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridChequesRecibidos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEfectivo)).BeginInit();
			this._SSTab1_TabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).BeginInit();
			this._SSTab1_TabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridChequesDepNoEnFecha)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridChequesDepEnFecha)).BeginInit();
			this._SSTab1_TabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridFactImpagas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridFactHechas)).BeginInit();
			this._SSTab1_TabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridChequesXCobrar)).BeginInit();
			this._SSTab1_TabPage6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView9)).BeginInit();
			this._SSTab1_TabPage7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView10)).BeginInit();
			this._SSTab1_TabPage8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridRecibos)).BeginInit();
			this._SSTab1_TabPage9.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.Frame3.SuspendLayout();
			this.Frame4.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SSTab1
			// 
			this.SSTab1.Controls.Add(this._SSTab1_TabPage0);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage1);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage2);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage3);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage4);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage5);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage6);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage7);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage8);
			this.SSTab1.Controls.Add(this._SSTab1_TabPage9);
			this.SSTab1.ItemSize = new System.Drawing.Size(42, 36);
			this.SSTab1.Location = new System.Drawing.Point(12, 48);
			this.SSTab1.Name = "SSTab1";
			this.SSTab1.SelectedIndex = 7;
			this.SSTab1.Size = new System.Drawing.Size(1009, 633);
			this.SSTab1.TabIndex = 0;
			// 
			// _SSTab1_TabPage0
			// 
			this._SSTab1_TabPage0.Controls.Add(this.gridInterdepositosRecibidos);
			this._SSTab1_TabPage0.Controls.Add(this.gridChequesRecibidos);
			this._SSTab1_TabPage0.Controls.Add(this.gridEfectivo);
			this._SSTab1_TabPage0.Controls.Add(this.Label18);
			this._SSTab1_TabPage0.Controls.Add(this.Label16);
			this._SSTab1_TabPage0.Controls.Add(this.Label1);
			this._SSTab1_TabPage0.Location = new System.Drawing.Point(4, 40);
			this._SSTab1_TabPage0.Name = "_SSTab1_TabPage0";
			this._SSTab1_TabPage0.Size = new System.Drawing.Size(1001, 589);
			this._SSTab1_TabPage0.TabIndex = 0;
			this._SSTab1_TabPage0.Text = "Valores Recibidos";
			// 
			// gridInterdepositosRecibidos
			// 
			this.gridInterdepositosRecibidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridInterdepositosRecibidos.Location = new System.Drawing.Point(8, 420);
			this.gridInterdepositosRecibidos.Name = "gridInterdepositosRecibidos";
			this.gridInterdepositosRecibidos.Size = new System.Drawing.Size(785, 150);
			this.gridInterdepositosRecibidos.TabIndex = 22;
			// 
			// gridChequesRecibidos
			// 
			this.gridChequesRecibidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridChequesRecibidos.Location = new System.Drawing.Point(8, 236);
			this.gridChequesRecibidos.Name = "gridChequesRecibidos";
			this.gridChequesRecibidos.Size = new System.Drawing.Size(816, 150);
			this.gridChequesRecibidos.TabIndex = 21;
			// 
			// gridEfectivo
			// 
			this.gridEfectivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridEfectivo.Location = new System.Drawing.Point(8, 49);
			this.gridEfectivo.Name = "gridEfectivo";
			this.gridEfectivo.Size = new System.Drawing.Size(816, 150);
			this.gridEfectivo.TabIndex = 20;
			// 
			// Label18
			// 
			this.Label18.BackColor = System.Drawing.SystemColors.Control;
			this.Label18.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label18.Location = new System.Drawing.Point(16, 400);
			this.Label18.Name = "Label18";
			this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label18.Size = new System.Drawing.Size(121, 17);
			this.Label18.TabIndex = 14;
			this.Label18.Text = "INTERDEPOSITOS";
			// 
			// Label16
			// 
			this.Label16.BackColor = System.Drawing.SystemColors.Control;
			this.Label16.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label16.Location = new System.Drawing.Point(16, 216);
			this.Label16.Name = "Label16";
			this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label16.Size = new System.Drawing.Size(81, 17);
			this.Label16.TabIndex = 15;
			this.Label16.Text = "CHEQUES";
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(15, 29);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(145, 17);
			this.Label1.TabIndex = 16;
			this.Label1.Text = "EFECTIVO";
			// 
			// _SSTab1_TabPage1
			// 
			this._SSTab1_TabPage1.Controls.Add(this.DataGridView4);
			this._SSTab1_TabPage1.Controls.Add(this.DataGridView3);
			this._SSTab1_TabPage1.Controls.Add(this.Label17);
			this._SSTab1_TabPage1.Controls.Add(this.Label19);
			this._SSTab1_TabPage1.Location = new System.Drawing.Point(4, 40);
			this._SSTab1_TabPage1.Name = "_SSTab1_TabPage1";
			this._SSTab1_TabPage1.Size = new System.Drawing.Size(1001, 589);
			this._SSTab1_TabPage1.TabIndex = 1;
			this._SSTab1_TabPage1.Text = "Interdepósitos";
			// 
			// DataGridView4
			// 
			this.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView4.Location = new System.Drawing.Point(19, 303);
			this.DataGridView4.Name = "DataGridView4";
			this.DataGridView4.Size = new System.Drawing.Size(816, 150);
			this.DataGridView4.TabIndex = 15;
			// 
			// DataGridView3
			// 
			this.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView3.Location = new System.Drawing.Point(19, 49);
			this.DataGridView3.Name = "DataGridView3";
			this.DataGridView3.Size = new System.Drawing.Size(816, 150);
			this.DataGridView3.TabIndex = 14;
			// 
			// Label17
			// 
			this.Label17.BackColor = System.Drawing.SystemColors.Control;
			this.Label17.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label17.Location = new System.Drawing.Point(16, 29);
			this.Label17.Name = "Label17";
			this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label17.Size = new System.Drawing.Size(121, 17);
			this.Label17.TabIndex = 13;
			this.Label17.Text = "Banco Nación";
			// 
			// Label19
			// 
			this.Label19.BackColor = System.Drawing.SystemColors.Control;
			this.Label19.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label19.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label19.Location = new System.Drawing.Point(16, 269);
			this.Label19.Name = "Label19";
			this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label19.Size = new System.Drawing.Size(121, 17);
			this.Label19.TabIndex = 12;
			this.Label19.Text = "Banco Galicia";
			// 
			// _SSTab1_TabPage2
			// 
			this._SSTab1_TabPage2.Controls.Add(this.gridChequesDepNoEnFecha);
			this._SSTab1_TabPage2.Controls.Add(this.gridChequesDepEnFecha);
			this._SSTab1_TabPage2.Controls.Add(this.Label21);
			this._SSTab1_TabPage2.Controls.Add(this.Label20);
			this._SSTab1_TabPage2.Location = new System.Drawing.Point(4, 40);
			this._SSTab1_TabPage2.Name = "_SSTab1_TabPage2";
			this._SSTab1_TabPage2.Size = new System.Drawing.Size(1001, 589);
			this._SSTab1_TabPage2.TabIndex = 2;
			this._SSTab1_TabPage2.Text = "Cheques Depositados";
			// 
			// gridChequesDepNoEnFecha
			// 
			this.gridChequesDepNoEnFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridChequesDepNoEnFecha.Location = new System.Drawing.Point(8, 257);
			this.gridChequesDepNoEnFecha.Name = "gridChequesDepNoEnFecha";
			this.gridChequesDepNoEnFecha.Size = new System.Drawing.Size(816, 150);
			this.gridChequesDepNoEnFecha.TabIndex = 60;
			// 
			// gridChequesDepEnFecha
			// 
			this.gridChequesDepEnFecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridChequesDepEnFecha.Location = new System.Drawing.Point(8, 41);
			this.gridChequesDepEnFecha.Name = "gridChequesDepEnFecha";
			this.gridChequesDepEnFecha.Size = new System.Drawing.Size(816, 150);
			this.gridChequesDepEnFecha.TabIndex = 59;
			// 
			// Label21
			// 
			this.Label21.BackColor = System.Drawing.SystemColors.Control;
			this.Label21.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label21.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label21.Location = new System.Drawing.Point(8, 237);
			this.Label21.Name = "Label21";
			this.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label21.Size = new System.Drawing.Size(137, 17);
			this.Label21.TabIndex = 10;
			this.Label21.Text = "Fuera de Fecha";
			// 
			// Label20
			// 
			this.Label20.BackColor = System.Drawing.SystemColors.Control;
			this.Label20.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label20.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label20.Location = new System.Drawing.Point(8, 13);
			this.Label20.Name = "Label20";
			this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label20.Size = new System.Drawing.Size(177, 25);
			this.Label20.TabIndex = 11;
			this.Label20.Text = "En Fecha";
			// 
			// _SSTab1_TabPage3
			// 
			this._SSTab1_TabPage3.Controls.Add(this.gridFactImpagas);
			this._SSTab1_TabPage3.Controls.Add(this.gridFactHechas);
			this._SSTab1_TabPage3.Controls.Add(this._Lbl_1);
			this._SSTab1_TabPage3.Controls.Add(this._Lbl_2);
			this._SSTab1_TabPage3.Location = new System.Drawing.Point(4, 40);
			this._SSTab1_TabPage3.Name = "_SSTab1_TabPage3";
			this._SSTab1_TabPage3.Size = new System.Drawing.Size(1001, 589);
			this._SSTab1_TabPage3.TabIndex = 3;
			this._SSTab1_TabPage3.Text = "Facturas ";
			// 
			// gridFactImpagas
			// 
			this.gridFactImpagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridFactImpagas.Location = new System.Drawing.Point(8, 305);
			this.gridFactImpagas.Name = "gridFactImpagas";
			this.gridFactImpagas.Size = new System.Drawing.Size(816, 150);
			this.gridFactImpagas.TabIndex = 45;
			// 
			// gridFactHechas
			// 
			this.gridFactHechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridFactHechas.Location = new System.Drawing.Point(8, 87);
			this.gridFactHechas.Name = "gridFactHechas";
			this.gridFactHechas.Size = new System.Drawing.Size(816, 150);
			this.gridFactHechas.TabIndex = 44;
			// 
			// _Lbl_1
			// 
			this._Lbl_1.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Lbl_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_1.Location = new System.Drawing.Point(8, 48);
			this._Lbl_1.Name = "_Lbl_1";
			this._Lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_1.Size = new System.Drawing.Size(129, 25);
			this._Lbl_1.TabIndex = 9;
			this._Lbl_1.Text = "Facturas Hechas";
			// 
			// _Lbl_2
			// 
			this._Lbl_2.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Lbl_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_2.Location = new System.Drawing.Point(8, 266);
			this._Lbl_2.Name = "_Lbl_2";
			this._Lbl_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_2.Size = new System.Drawing.Size(137, 25);
			this._Lbl_2.TabIndex = 18;
			this._Lbl_2.Text = "Facturas Impagas";
			// 
			// _SSTab1_TabPage4
			// 
			this._SSTab1_TabPage4.Controls.Add(this.gridChequesXCobrar);
			this._SSTab1_TabPage4.Location = new System.Drawing.Point(4, 40);
			this._SSTab1_TabPage4.Name = "_SSTab1_TabPage4";
			this._SSTab1_TabPage4.Size = new System.Drawing.Size(1001, 589);
			this._SSTab1_TabPage4.TabIndex = 4;
			this._SSTab1_TabPage4.Text = "Cheques A Cobrar";
			// 
			// gridChequesXCobrar
			// 
			this.gridChequesXCobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridChequesXCobrar.Location = new System.Drawing.Point(3, 3);
			this.gridChequesXCobrar.Name = "gridChequesXCobrar";
			this.gridChequesXCobrar.Size = new System.Drawing.Size(816, 362);
			this.gridChequesXCobrar.TabIndex = 0;
			// 
			// _SSTab1_TabPage5
			// 
			this._SSTab1_TabPage5.Location = new System.Drawing.Point(4, 40);
			this._SSTab1_TabPage5.Name = "_SSTab1_TabPage5";
			this._SSTab1_TabPage5.Size = new System.Drawing.Size(1001, 589);
			this._SSTab1_TabPage5.TabIndex = 5;
			this._SSTab1_TabPage5.Text = "Total de Ventas y Consignaciones";
			// 
			// _SSTab1_TabPage6
			// 
			this._SSTab1_TabPage6.Controls.Add(this.DataGridView9);
			this._SSTab1_TabPage6.Location = new System.Drawing.Point(4, 40);
			this._SSTab1_TabPage6.Name = "_SSTab1_TabPage6";
			this._SSTab1_TabPage6.Size = new System.Drawing.Size(1001, 589);
			this._SSTab1_TabPage6.TabIndex = 6;
			this._SSTab1_TabPage6.Text = "Stock";
			// 
			// DataGridView9
			// 
			this.DataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView9.Location = new System.Drawing.Point(8, 3);
			this.DataGridView9.Name = "DataGridView9";
			this.DataGridView9.Size = new System.Drawing.Size(816, 359);
			this.DataGridView9.TabIndex = 49;
			// 
			// _SSTab1_TabPage7
			// 
			this._SSTab1_TabPage7.Controls.Add(this.DataGridView13);
			this._SSTab1_TabPage7.Controls.Add(this.DataGridView11);
			this._SSTab1_TabPage7.Controls.Add(this.DataGridView12);
			this._SSTab1_TabPage7.Controls.Add(this.DataGridView10);
			this._SSTab1_TabPage7.Controls.Add(this.Label8);
			this._SSTab1_TabPage7.Controls.Add(this.Label10);
			this._SSTab1_TabPage7.Controls.Add(this.cmdImprimirVentas);
			this._SSTab1_TabPage7.Location = new System.Drawing.Point(4, 40);
			this._SSTab1_TabPage7.Name = "_SSTab1_TabPage7";
			this._SSTab1_TabPage7.Size = new System.Drawing.Size(1001, 589);
			this._SSTab1_TabPage7.TabIndex = 7;
			this._SSTab1_TabPage7.Text = "Ventas";
			// 
			// DataGridView13
			// 
			this.DataGridView13.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView13.Location = new System.Drawing.Point(504, 106);
			this.DataGridView13.Name = "DataGridView13";
			this.DataGridView13.Size = new System.Drawing.Size(240, 150);
			this.DataGridView13.TabIndex = 47;
			// 
			// DataGridView11
			// 
			this.DataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView11.Location = new System.Drawing.Point(519, 287);
			this.DataGridView11.Name = "DataGridView11";
			this.DataGridView11.Size = new System.Drawing.Size(240, 150);
			this.DataGridView11.TabIndex = 47;
			// 
			// DataGridView12
			// 
			this.DataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView12.Location = new System.Drawing.Point(48, 106);
			this.DataGridView12.Name = "DataGridView12";
			this.DataGridView12.Size = new System.Drawing.Size(240, 150);
			this.DataGridView12.TabIndex = 47;
			// 
			// DataGridView10
			// 
			this.DataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView10.Location = new System.Drawing.Point(63, 287);
			this.DataGridView10.Name = "DataGridView10";
			this.DataGridView10.Size = new System.Drawing.Size(240, 150);
			this.DataGridView10.TabIndex = 47;
			// 
			// Label8
			// 
			this.Label8.BackColor = System.Drawing.SystemColors.Control;
			this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label8.Location = new System.Drawing.Point(48, 64);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(217, 25);
			this.Label8.TabIndex = 41;
			this.Label8.Text = "DOLARES";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Label10
			// 
			this.Label10.BackColor = System.Drawing.SystemColors.Control;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label10.Location = new System.Drawing.Point(504, 64);
			this.Label10.Name = "Label10";
			this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label10.Size = new System.Drawing.Size(217, 25);
			this.Label10.TabIndex = 42;
			this.Label10.Text = "PESOS";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// cmdImprimirVentas
			// 
			this.cmdImprimirVentas.BackColor = System.Drawing.SystemColors.Control;
			this.cmdImprimirVentas.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdImprimirVentas.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdImprimirVentas.Location = new System.Drawing.Point(800, 528);
			this.cmdImprimirVentas.Name = "cmdImprimirVentas";
			this.cmdImprimirVentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdImprimirVentas.Size = new System.Drawing.Size(97, 57);
			this.cmdImprimirVentas.TabIndex = 46;
			this.cmdImprimirVentas.Text = "Imprimir";
			this.cmdImprimirVentas.UseVisualStyleBackColor = false;
			// 
			// _SSTab1_TabPage8
			// 
			this._SSTab1_TabPage8.Controls.Add(this.label11);
			this._SSTab1_TabPage8.Controls.Add(this.gridRecibos);
			this._SSTab1_TabPage8.Location = new System.Drawing.Point(4, 40);
			this._SSTab1_TabPage8.Name = "_SSTab1_TabPage8";
			this._SSTab1_TabPage8.Size = new System.Drawing.Size(1001, 589);
			this._SSTab1_TabPage8.TabIndex = 8;
			this._SSTab1_TabPage8.Text = "Cobranzas";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.Control;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Cursor = System.Windows.Forms.Cursors.Default;
			this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label11.Location = new System.Drawing.Point(19, 23);
			this.label11.Name = "label11";
			this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label11.Size = new System.Drawing.Size(129, 25);
			this.label11.TabIndex = 10;
			this.label11.Text = "Recibos Hechos";
			// 
			// gridRecibos
			// 
			this.gridRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridRecibos.Location = new System.Drawing.Point(19, 68);
			this.gridRecibos.Name = "gridRecibos";
			this.gridRecibos.Size = new System.Drawing.Size(816, 322);
			this.gridRecibos.TabIndex = 0;
			// 
			// _SSTab1_TabPage9
			// 
			this._SSTab1_TabPage9.Controls.Add(this.groupBox1);
			this._SSTab1_TabPage9.Controls.Add(this.calCalendario);
			this._SSTab1_TabPage9.Controls.Add(this.Label9);
			this._SSTab1_TabPage9.Controls.Add(this.Frame1);
			this._SSTab1_TabPage9.Controls.Add(this.Frame2);
			this._SSTab1_TabPage9.Controls.Add(this.Text2);
			this._SSTab1_TabPage9.Controls.Add(this.Frame3);
			this._SSTab1_TabPage9.Controls.Add(this.Frame4);
			this._SSTab1_TabPage9.Location = new System.Drawing.Point(4, 40);
			this._SSTab1_TabPage9.Name = "_SSTab1_TabPage9";
			this._SSTab1_TabPage9.Size = new System.Drawing.Size(1001, 589);
			this._SSTab1_TabPage9.TabIndex = 9;
			this._SSTab1_TabPage9.Text = "General";
			// 
			// calCalendario
			// 
			this.calCalendario.Location = new System.Drawing.Point(397, 50);
			this.calCalendario.Name = "calCalendario";
			this.calCalendario.TabIndex = 48;
			// 
			// Label9
			// 
			this.Label9.BackColor = System.Drawing.SystemColors.Control;
			this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label9.Location = new System.Drawing.Point(16, 72);
			this.Label9.Name = "Label9";
			this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label9.Size = new System.Drawing.Size(121, 17);
			this.Label9.TabIndex = 0;
			this.Label9.Text = "Facturas Impagas desde:";
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.txtInterdepositos);
			this.Frame1.Controls.Add(this.txtEfectivo);
			this.Frame1.Controls.Add(this.Label6);
			this.Frame1.Controls.Add(this.Label5);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(24, 320);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(297, 97);
			this.Frame1.TabIndex = 20;
			this.Frame1.TabStop = false;
			this.Frame1.Text = "Valores Efectivamente Cobrados";
			// 
			// txtInterdepositos
			// 
			this.txtInterdepositos.AcceptsReturn = true;
			this.txtInterdepositos.BackColor = System.Drawing.SystemColors.Window;
			this.txtInterdepositos.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtInterdepositos.Enabled = false;
			this.txtInterdepositos.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtInterdepositos.Location = new System.Drawing.Point(176, 56);
			this.txtInterdepositos.MaxLength = 0;
			this.txtInterdepositos.Name = "txtInterdepositos";
			this.txtInterdepositos.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtInterdepositos.Size = new System.Drawing.Size(105, 20);
			this.txtInterdepositos.TabIndex = 26;
			this.txtInterdepositos.Text = "$ 0";
			this.txtInterdepositos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtEfectivo
			// 
			this.txtEfectivo.AcceptsReturn = true;
			this.txtEfectivo.BackColor = System.Drawing.SystemColors.Window;
			this.txtEfectivo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEfectivo.Enabled = false;
			this.txtEfectivo.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtEfectivo.Location = new System.Drawing.Point(176, 24);
			this.txtEfectivo.MaxLength = 0;
			this.txtEfectivo.Name = "txtEfectivo";
			this.txtEfectivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtEfectivo.Size = new System.Drawing.Size(105, 20);
			this.txtEfectivo.TabIndex = 21;
			this.txtEfectivo.Text = "$ 0";
			this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Label6
			// 
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(56, 56);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(113, 20);
			this.Label6.TabIndex = 27;
			this.Label6.Text = "Interdepositos";
			// 
			// Label5
			// 
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(24, 24);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(145, 20);
			this.Label5.TabIndex = 22;
			this.Label5.Text = "Valores en Efectivo";
			// 
			// Frame2
			// 
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.txtFactHechas);
			this.Frame2.Controls.Add(this.label22);
			this.Frame2.Controls.Add(this.txtFactImpagas);
			this.Frame2.Controls.Add(this._Lbl_0);
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(648, 50);
			this.Frame2.Name = "Frame2";
			this.Frame2.Padding = new System.Windows.Forms.Padding(0);
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(297, 89);
			this.Frame2.TabIndex = 23;
			this.Frame2.TabStop = false;
			this.Frame2.Text = "Facturas";
			// 
			// txtFactHechas
			// 
			this.txtFactHechas.AcceptsReturn = true;
			this.txtFactHechas.BackColor = System.Drawing.SystemColors.Window;
			this.txtFactHechas.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtFactHechas.Enabled = false;
			this.txtFactHechas.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtFactHechas.Location = new System.Drawing.Point(168, 54);
			this.txtFactHechas.MaxLength = 0;
			this.txtFactHechas.Name = "txtFactHechas";
			this.txtFactHechas.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtFactHechas.Size = new System.Drawing.Size(105, 20);
			this.txtFactHechas.TabIndex = 26;
			this.txtFactHechas.Text = "$ 0";
			this.txtFactHechas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.SystemColors.Control;
			this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label22.Cursor = System.Windows.Forms.Cursors.Default;
			this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label22.Location = new System.Drawing.Point(24, 54);
			this.label22.Name = "label22";
			this.label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label22.Size = new System.Drawing.Size(137, 20);
			this.label22.TabIndex = 27;
			this.label22.Text = "Facturas Hechas";
			// 
			// txtFactImpagas
			// 
			this.txtFactImpagas.AcceptsReturn = true;
			this.txtFactImpagas.BackColor = System.Drawing.SystemColors.Window;
			this.txtFactImpagas.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtFactImpagas.Enabled = false;
			this.txtFactImpagas.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtFactImpagas.Location = new System.Drawing.Point(167, 22);
			this.txtFactImpagas.MaxLength = 0;
			this.txtFactImpagas.Name = "txtFactImpagas";
			this.txtFactImpagas.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtFactImpagas.Size = new System.Drawing.Size(105, 20);
			this.txtFactImpagas.TabIndex = 24;
			this.txtFactImpagas.Text = "$ 0";
			this.txtFactImpagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// _Lbl_0
			// 
			this._Lbl_0.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._Lbl_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_0.Location = new System.Drawing.Point(23, 22);
			this._Lbl_0.Name = "_Lbl_0";
			this._Lbl_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_0.Size = new System.Drawing.Size(137, 25);
			this._Lbl_0.TabIndex = 25;
			this._Lbl_0.Text = "Facturas Impagas";
			// 
			// Text2
			// 
			this.Text2.AcceptsReturn = true;
			this.Text2.BackColor = System.Drawing.SystemColors.Window;
			this.Text2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.Text2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Text2.Location = new System.Drawing.Point(144, 72);
			this.Text2.MaxLength = 0;
			this.Text2.Name = "Text2";
			this.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text2.Size = new System.Drawing.Size(73, 20);
			this.Text2.TabIndex = 0;
			// 
			// Frame3
			// 
			this.Frame3.BackColor = System.Drawing.SystemColors.Control;
			this.Frame3.Controls.Add(this.txtVentasAcumuladas);
			this.Frame3.Controls.Add(this.txtTotalVentas);
			this.Frame3.Controls.Add(this.txtVentas);
			this.Frame3.Controls.Add(this.Label15);
			this.Frame3.Controls.Add(this.Label12);
			this.Frame3.Controls.Add(this.Label2);
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.Location = new System.Drawing.Point(16, 104);
			this.Frame3.Name = "Frame3";
			this.Frame3.Padding = new System.Windows.Forms.Padding(0);
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Size = new System.Drawing.Size(369, 177);
			this.Frame3.TabIndex = 30;
			this.Frame3.TabStop = false;
			this.Frame3.Text = "Ventas";
			// 
			// txtVentasAcumuladas
			// 
			this.txtVentasAcumuladas.AcceptsReturn = true;
			this.txtVentasAcumuladas.BackColor = System.Drawing.SystemColors.Window;
			this.txtVentasAcumuladas.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtVentasAcumuladas.Enabled = false;
			this.txtVentasAcumuladas.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtVentasAcumuladas.Location = new System.Drawing.Point(184, 88);
			this.txtVentasAcumuladas.MaxLength = 0;
			this.txtVentasAcumuladas.Name = "txtVentasAcumuladas";
			this.txtVentasAcumuladas.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtVentasAcumuladas.Size = new System.Drawing.Size(169, 20);
			this.txtVentasAcumuladas.TabIndex = 33;
			this.txtVentasAcumuladas.Text = "$ 0";
			this.txtVentasAcumuladas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTotalVentas
			// 
			this.txtTotalVentas.AcceptsReturn = true;
			this.txtTotalVentas.BackColor = System.Drawing.SystemColors.Window;
			this.txtTotalVentas.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTotalVentas.Enabled = false;
			this.txtTotalVentas.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTotalVentas.Location = new System.Drawing.Point(184, 128);
			this.txtTotalVentas.MaxLength = 0;
			this.txtTotalVentas.Name = "txtTotalVentas";
			this.txtTotalVentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTotalVentas.Size = new System.Drawing.Size(169, 20);
			this.txtTotalVentas.TabIndex = 32;
			this.txtTotalVentas.Text = "$ 0";
			this.txtTotalVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtVentas
			// 
			this.txtVentas.AcceptsReturn = true;
			this.txtVentas.BackColor = System.Drawing.SystemColors.Window;
			this.txtVentas.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtVentas.Enabled = false;
			this.txtVentas.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtVentas.Location = new System.Drawing.Point(184, 48);
			this.txtVentas.MaxLength = 0;
			this.txtVentas.Name = "txtVentas";
			this.txtVentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtVentas.Size = new System.Drawing.Size(169, 20);
			this.txtVentas.TabIndex = 31;
			this.txtVentas.Text = "$ 0";
			this.txtVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Label15
			// 
			this.Label15.BackColor = System.Drawing.SystemColors.Control;
			this.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label15.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label15.Location = new System.Drawing.Point(8, 88);
			this.Label15.Name = "Label15";
			this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label15.Size = new System.Drawing.Size(169, 25);
			this.Label15.TabIndex = 36;
			this.Label15.Text = "Ventas Acumuladas";
			// 
			// Label12
			// 
			this.Label12.BackColor = System.Drawing.SystemColors.Control;
			this.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label12.Location = new System.Drawing.Point(0, 128);
			this.Label12.Name = "Label12";
			this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label12.Size = new System.Drawing.Size(177, 25);
			this.Label12.TabIndex = 35;
			this.Label12.Text = "Total Ventas Realizadas";
			// 
			// Label2
			// 
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(8, 48);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(169, 25);
			this.Label2.TabIndex = 34;
			this.Label2.Text = "Ventas Realizadas";
			// 
			// Frame4
			// 
			this.Frame4.BackColor = System.Drawing.SystemColors.Control;
			this.Frame4.Controls.Add(this.txtChequesCartera);
			this.Frame4.Controls.Add(this.txtValoresEfectCobrados);
			this.Frame4.Controls.Add(this.txtChequesDepositados);
			this.Frame4.Controls.Add(this.txtRecibos);
			this.Frame4.Controls.Add(this.txtTotalCobros);
			this.Frame4.Controls.Add(this.Label14);
			this.Frame4.Controls.Add(this.Label7);
			this.Frame4.Controls.Add(this.Label4);
			this.Frame4.Controls.Add(this.Label3);
			this.Frame4.Controls.Add(this.Label13);
			this.Frame4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame4.Location = new System.Drawing.Point(516, 245);
			this.Frame4.Name = "Frame4";
			this.Frame4.Padding = new System.Windows.Forms.Padding(0);
			this.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame4.Size = new System.Drawing.Size(465, 297);
			this.Frame4.TabIndex = 47;
			this.Frame4.TabStop = false;
			this.Frame4.Text = "Cobros";
			// 
			// txtChequesCartera
			// 
			this.txtChequesCartera.AcceptsReturn = true;
			this.txtChequesCartera.BackColor = System.Drawing.SystemColors.Window;
			this.txtChequesCartera.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtChequesCartera.Enabled = false;
			this.txtChequesCartera.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtChequesCartera.Location = new System.Drawing.Point(272, 168);
			this.txtChequesCartera.MaxLength = 0;
			this.txtChequesCartera.Name = "txtChequesCartera";
			this.txtChequesCartera.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtChequesCartera.Size = new System.Drawing.Size(169, 20);
			this.txtChequesCartera.TabIndex = 52;
			this.txtChequesCartera.Text = "$ 0";
			this.txtChequesCartera.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtValoresEfectCobrados
			// 
			this.txtValoresEfectCobrados.AcceptsReturn = true;
			this.txtValoresEfectCobrados.BackColor = System.Drawing.SystemColors.Window;
			this.txtValoresEfectCobrados.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtValoresEfectCobrados.Enabled = false;
			this.txtValoresEfectCobrados.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtValoresEfectCobrados.Location = new System.Drawing.Point(272, 128);
			this.txtValoresEfectCobrados.MaxLength = 0;
			this.txtValoresEfectCobrados.Name = "txtValoresEfectCobrados";
			this.txtValoresEfectCobrados.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtValoresEfectCobrados.Size = new System.Drawing.Size(169, 20);
			this.txtValoresEfectCobrados.TabIndex = 51;
			this.txtValoresEfectCobrados.Text = "$ 0";
			this.txtValoresEfectCobrados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtChequesDepositados
			// 
			this.txtChequesDepositados.AcceptsReturn = true;
			this.txtChequesDepositados.BackColor = System.Drawing.SystemColors.Window;
			this.txtChequesDepositados.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtChequesDepositados.Enabled = false;
			this.txtChequesDepositados.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtChequesDepositados.Location = new System.Drawing.Point(272, 96);
			this.txtChequesDepositados.MaxLength = 0;
			this.txtChequesDepositados.Name = "txtChequesDepositados";
			this.txtChequesDepositados.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtChequesDepositados.Size = new System.Drawing.Size(169, 20);
			this.txtChequesDepositados.TabIndex = 50;
			this.txtChequesDepositados.Text = "$ 0";
			this.txtChequesDepositados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtRecibos
			// 
			this.txtRecibos.AcceptsReturn = true;
			this.txtRecibos.BackColor = System.Drawing.SystemColors.Window;
			this.txtRecibos.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtRecibos.Enabled = false;
			this.txtRecibos.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtRecibos.Location = new System.Drawing.Point(272, 56);
			this.txtRecibos.MaxLength = 0;
			this.txtRecibos.Name = "txtRecibos";
			this.txtRecibos.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtRecibos.Size = new System.Drawing.Size(169, 20);
			this.txtRecibos.TabIndex = 49;
			this.txtRecibos.Text = "$ 0";
			this.txtRecibos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTotalCobros
			// 
			this.txtTotalCobros.AcceptsReturn = true;
			this.txtTotalCobros.BackColor = System.Drawing.SystemColors.Window;
			this.txtTotalCobros.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTotalCobros.Enabled = false;
			this.txtTotalCobros.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTotalCobros.Location = new System.Drawing.Point(272, 208);
			this.txtTotalCobros.MaxLength = 0;
			this.txtTotalCobros.Name = "txtTotalCobros";
			this.txtTotalCobros.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTotalCobros.Size = new System.Drawing.Size(169, 20);
			this.txtTotalCobros.TabIndex = 48;
			this.txtTotalCobros.Text = "$ 0";
			this.txtTotalCobros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Label14
			// 
			this.Label14.BackColor = System.Drawing.SystemColors.Control;
			this.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label14.Location = new System.Drawing.Point(96, 168);
			this.Label14.Name = "Label14";
			this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label14.Size = new System.Drawing.Size(169, 25);
			this.Label14.TabIndex = 57;
			this.Label14.Text = "Cheques en Cartera";
			// 
			// Label7
			// 
			this.Label7.BackColor = System.Drawing.SystemColors.Control;
			this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.Location = new System.Drawing.Point(16, 128);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(249, 25);
			this.Label7.TabIndex = 56;
			this.Label7.Text = "Valores Efectivamente Cobrados";
			// 
			// Label4
			// 
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(96, 96);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(169, 25);
			this.Label4.TabIndex = 55;
			this.Label4.Text = "Valores Despositados";
			// 
			// Label3
			// 
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(96, 56);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(169, 25);
			this.Label3.TabIndex = 54;
			this.Label3.Text = "Cobros Efectuados";
			// 
			// Label13
			// 
			this.Label13.BackColor = System.Drawing.SystemColors.Control;
			this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label13.Location = new System.Drawing.Point(88, 208);
			this.Label13.Name = "Label13";
			this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label13.Size = new System.Drawing.Size(177, 25);
			this.Label13.TabIndex = 53;
			this.Label13.Text = "Total Cobros Realizados";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tlActualizar,
			this.toolStripSeparator1,
			this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1172, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tlActualizar
			// 
			this.tlActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlActualizar.Image = ((System.Drawing.Image)(resources.GetObject("tlActualizar.Image")));
			this.tlActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlActualizar.Name = "tlActualizar";
			this.tlActualizar.Size = new System.Drawing.Size(23, 22);
			this.tlActualizar.Text = "toolStripButton1";
			this.tlActualizar.Click += new System.EventHandler(this.TlActualizarClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtChequesRecibidos);
			this.groupBox1.Controls.Add(this.label23);
			this.groupBox1.Location = new System.Drawing.Point(648, 172);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(333, 67);
			this.groupBox1.TabIndex = 49;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// txtChequesRecibidos
			// 
			this.txtChequesRecibidos.AcceptsReturn = true;
			this.txtChequesRecibidos.BackColor = System.Drawing.SystemColors.Window;
			this.txtChequesRecibidos.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtChequesRecibidos.Enabled = false;
			this.txtChequesRecibidos.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtChequesRecibidos.Location = new System.Drawing.Point(154, 20);
			this.txtChequesRecibidos.MaxLength = 0;
			this.txtChequesRecibidos.Name = "txtChequesRecibidos";
			this.txtChequesRecibidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtChequesRecibidos.Size = new System.Drawing.Size(105, 20);
			this.txtChequesRecibidos.TabIndex = 28;
			this.txtChequesRecibidos.Text = "$ 0";
			this.txtChequesRecibidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.SystemColors.Control;
			this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label23.Cursor = System.Windows.Forms.Cursors.Default;
			this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label23.Location = new System.Drawing.Point(10, 20);
			this.label23.Name = "label23";
			this.label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label23.Size = new System.Drawing.Size(137, 20);
			this.label23.TabIndex = 29;
			this.label23.Text = "Cheques Recibidos";
			// 
			// frmContadorInformeSemanal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1172, 657);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.SSTab1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Location = new System.Drawing.Point(4, 26);
			this.Name = "frmContadorInformeSemanal";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "Informe de Actividades Mensuales";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmContadorInformeSemanalLoad);
			this.SSTab1.ResumeLayout(false);
			this._SSTab1_TabPage0.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridInterdepositosRecibidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridChequesRecibidos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridEfectivo)).EndInit();
			this._SSTab1_TabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).EndInit();
			this._SSTab1_TabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridChequesDepNoEnFecha)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridChequesDepEnFecha)).EndInit();
			this._SSTab1_TabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridFactImpagas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridFactHechas)).EndInit();
			this._SSTab1_TabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridChequesXCobrar)).EndInit();
			this._SSTab1_TabPage6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView9)).EndInit();
			this._SSTab1_TabPage7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DataGridView13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataGridView10)).EndInit();
			this._SSTab1_TabPage8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridRecibos)).EndInit();
			this._SSTab1_TabPage9.ResumeLayout(false);
			this._SSTab1_TabPage9.PerformLayout();
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			this.Frame2.ResumeLayout(false);
			this.Frame2.PerformLayout();
			this.Frame3.ResumeLayout(false);
			this.Frame3.PerformLayout();
			this.Frame4.ResumeLayout(false);
			this.Frame4.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripButton tlActualizar;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		internal System.Windows.Forms.DataGridView gridInterdepositosRecibidos;
		internal System.Windows.Forms.DataGridView gridChequesDepEnFecha;
		internal System.Windows.Forms.DataGridView gridChequesDepNoEnFecha;
		internal System.Windows.Forms.DataGridView gridChequesRecibidos;
		private System.Windows.Forms.DataGridView gridChequesXCobrar;
		internal System.Windows.Forms.DataGridView gridEfectivo;
		private System.Windows.Forms.DataGridView gridRecibos;
		public System.Windows.Forms.Label label11;
		internal System.Windows.Forms.DataGridView gridFactImpagas;
		internal System.Windows.Forms.DataGridView gridFactHechas;
		internal System.Windows.Forms.MonthCalendar calCalendario;
		internal System.Windows.Forms.DataGridView DataGridView4;
		internal System.Windows.Forms.DataGridView DataGridView3;
		internal System.Windows.Forms.DataGridView DataGridView9;
		internal System.Windows.Forms.DataGridView DataGridView13;
		internal System.Windows.Forms.DataGridView DataGridView11;
		internal System.Windows.Forms.DataGridView DataGridView12;
		internal System.Windows.Forms.DataGridView DataGridView10;
		public System.Windows.Forms.TextBox txtFactHechas;
		public System.Windows.Forms.Label label22;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.TextBox txtChequesRecibidos;
		public System.Windows.Forms.Label label23;
			#endregion
		
		
	}
}
