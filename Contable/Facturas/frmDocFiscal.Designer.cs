//using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Net.Mail;
using System.Net.Mime;
using System.Resources;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

namespace Contable
{
	//[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class frmDocFiscal : System.Windows.Forms.Form
	{

		//Form reemplaza a Dispose para limpiar la lista de componentes.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}

		//Requerido por el Diseñador de Windows Forms

		private System.ComponentModel.IContainer components;
		//NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
		//Se puede modificar usando el Diseñador de Windows Forms.  
		//No lo modifique con el editor de código.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocFiscal));
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this._Lbl_11 = new System.Windows.Forms.Label();
			this._Lbl_12 = new System.Windows.Forms.Label();
			this._Lbl_7 = new System.Windows.Forms.Label();
			this.lblIDCliente = new System.Windows.Forms.Label();
			this._Lbl_10 = new System.Windows.Forms.Label();
			this._Lbl_2 = new System.Windows.Forms.Label();
			this.lblSubtotal = new System.Windows.Forms.Label();
			this._Lbl_1 = new System.Windows.Forms.Label();
			this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
			this.lblIva = new System.Windows.Forms.Label();
			this.cmbPosIVA = new System.Windows.Forms.ComboBox();
			this.lblCod_cbe = new System.Windows.Forms.Label();
			this.frTotales = new System.Windows.Forms.GroupBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.frCliente = new System.Windows.Forms.GroupBox();
			this.cmdClienteNuevo = new System.Windows.Forms.Button();
			this._Lbl_3 = new System.Windows.Forms.Label();
			this.lblLocalidad = new System.Windows.Forms.Label();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblProvincia = new System.Windows.Forms.Label();
			this._Lbl_4 = new System.Windows.Forms.Label();
			this.lblCUIT = new System.Windows.Forms.Label();
			this.lblDolar = new System.Windows.Forms.Label();
			this._Lbl_17 = new System.Windows.Forms.Label();
			this.lblTipoFC = new System.Windows.Forms.Label();
			this.lblFechVtoCAE = new System.Windows.Forms.Label();
			this.frAFIP = new System.Windows.Forms.GroupBox();
			this._Lbl_9 = new System.Windows.Forms.Label();
			this._Lbl_8 = new System.Windows.Forms.Label();
			this.lblCAE = new System.Windows.Forms.Label();
			this.cmbSucursal = new System.Windows.Forms.ComboBox();
			this.txtCodBarNum = new System.Windows.Forms.TextBox();
			this.frFecha = new System.Windows.Forms.GroupBox();
			this.dtFecha = new System.Windows.Forms.DateTimePicker();
			this.frNumFact = new System.Windows.Forms.GroupBox();
			this.txtNumFact = new System.Windows.Forms.TextBox();
			this.frTipoFC = new System.Windows.Forms.GroupBox();
			this.frDescuento = new System.Windows.Forms.GroupBox();
			this.lblDescuento = new System.Windows.Forms.Label();
			this.Frame3 = new System.Windows.Forms.GroupBox();
			this.optPeso = new System.Windows.Forms.RadioButton();
			this.optDolar = new System.Windows.Forms.RadioButton();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.tabDolar = new System.Windows.Forms.TabPage();
			this.frTotalesUSD = new System.Windows.Forms.GroupBox();
			this.lblTotalUSD = new System.Windows.Forms.Label();
			this.lblIvaUSD = new System.Windows.Forms.Label();
			this.lblSubtotalUSD = new System.Windows.Forms.Label();
			this._Lbl_6 = new System.Windows.Forms.Label();
			this._Lbl_5 = new System.Windows.Forms.Label();
			this._Lbl_0 = new System.Windows.Forms.Label();
			this.tabPeso = new System.Windows.Forms.TabPage();
			this.tabAFIP = new System.Windows.Forms.TabPage();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.lblSign = new System.Windows.Forms.Label();
			this.lblToken = new System.Windows.Forms.Label();
			this.gridDatos = new System.Windows.Forms.DataGridView();
			this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProducto = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colUMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colBonif = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAlicuotaIVA = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colSubTotCIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Calendario = new System.Windows.Forms.MonthCalendar();
			this.cmbRemito1 = new System.Windows.Forms.ComboBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbRemito4 = new System.Windows.Forms.ComboBox();
			this.cmbRemito3 = new System.Windows.Forms.ComboBox();
			this.cmbRemito2 = new System.Windows.Forms.ComboBox();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this._Toolbar1_Button1 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button2 = new System.Windows.Forms.ToolStripSeparator();
			this.tlbGuardar = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button4 = new System.Windows.Forms.ToolStripSeparator();
			this.tbImprimir = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button6 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button7 = new System.Windows.Forms.ToolStripButton();
			this._Toolbar1_Button8 = new System.Windows.Forms.ToolStripSeparator();
			this._Toolbar1_Button9 = new System.Windows.Forms.ToolStripButton();
			this.frTotales.SuspendLayout();
			this.frCliente.SuspendLayout();
			this.frAFIP.SuspendLayout();
			this.frFecha.SuspendLayout();
			this.frNumFact.SuspendLayout();
			this.frTipoFC.SuspendLayout();
			this.frDescuento.SuspendLayout();
			this.Frame3.SuspendLayout();
			this.tabDolar.SuspendLayout();
			this.frTotalesUSD.SuspendLayout();
			this.tabPeso.SuspendLayout();
			this.tabAFIP.SuspendLayout();
			this.TabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
			this.Toolbar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Frame1
			// 
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(440, 176);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(185, 1);
			this.Frame1.TabIndex = 2;
			this.Frame1.TabStop = false;
			this.Frame1.Text = "Frame1";
			// 
			// _Lbl_11
			// 
			this._Lbl_11.AutoSize = true;
			this._Lbl_11.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_11.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_11.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_11.Location = new System.Drawing.Point(63, 72);
			this._Lbl_11.Name = "_Lbl_11";
			this._Lbl_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_11.Size = new System.Drawing.Size(40, 13);
			this._Lbl_11.TabIndex = 20;
			this._Lbl_11.Text = "Total $";
			this._Lbl_11.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_12
			// 
			this._Lbl_12.AutoSize = true;
			this._Lbl_12.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_12.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_12.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_12.Location = new System.Drawing.Point(71, 48);
			this._Lbl_12.Name = "_Lbl_12";
			this._Lbl_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_12.Size = new System.Drawing.Size(33, 13);
			this._Lbl_12.TabIndex = 21;
			this._Lbl_12.Text = "IVA $";
			this._Lbl_12.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_7
			// 
			this._Lbl_7.AutoSize = true;
			this._Lbl_7.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_7.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_7.Location = new System.Drawing.Point(280, 104);
			this._Lbl_7.Name = "_Lbl_7";
			this._Lbl_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_7.Size = new System.Drawing.Size(16, 13);
			this._Lbl_7.TabIndex = 53;
			this._Lbl_7.Text = "Id";
			this._Lbl_7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblIDCliente
			// 
			this.lblIDCliente.BackColor = System.Drawing.SystemColors.Control;
			this.lblIDCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblIDCliente.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblIDCliente.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblIDCliente.Location = new System.Drawing.Point(296, 96);
			this.lblIDCliente.Name = "lblIDCliente";
			this.lblIDCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblIDCliente.Size = new System.Drawing.Size(177, 25);
			this.lblIDCliente.TabIndex = 26;
			// 
			// _Lbl_10
			// 
			this._Lbl_10.AutoSize = true;
			this._Lbl_10.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_10.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_10.Location = new System.Drawing.Point(47, 24);
			this._Lbl_10.Name = "_Lbl_10";
			this._Lbl_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_10.Size = new System.Drawing.Size(59, 13);
			this._Lbl_10.TabIndex = 19;
			this._Lbl_10.Text = "SubTotal $";
			this._Lbl_10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_2
			// 
			this._Lbl_2.AutoSize = true;
			this._Lbl_2.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_2.Location = new System.Drawing.Point(16, 80);
			this._Lbl_2.Name = "_Lbl_2";
			this._Lbl_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_2.Size = new System.Drawing.Size(53, 13);
			this._Lbl_2.TabIndex = 13;
			this._Lbl_2.Text = "Localidad";
			this._Lbl_2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblSubtotal
			// 
			this.lblSubtotal.BackColor = System.Drawing.SystemColors.Control;
			this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblSubtotal.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblSubtotal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblSubtotal.Location = new System.Drawing.Point(112, 24);
			this.lblSubtotal.Name = "lblSubtotal";
			this.lblSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblSubtotal.Size = new System.Drawing.Size(81, 17);
			this.lblSubtotal.TabIndex = 18;
			this.lblSubtotal.Text = "0";
			this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_1
			// 
			this._Lbl_1.AutoSize = true;
			this._Lbl_1.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_1.Location = new System.Drawing.Point(16, 48);
			this._Lbl_1.Name = "_Lbl_1";
			this._Lbl_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_1.Size = new System.Drawing.Size(52, 13);
			this._Lbl_1.TabIndex = 14;
			this._Lbl_1.Text = "Direccion";
			this._Lbl_1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cmbRazonSocial
			// 
			this.cmbRazonSocial.BackColor = System.Drawing.SystemColors.Control;
			this.cmbRazonSocial.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbRazonSocial.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbRazonSocial.Location = new System.Drawing.Point(8, 16);
			this.cmbRazonSocial.Name = "cmbRazonSocial";
			this.cmbRazonSocial.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbRazonSocial.Size = new System.Drawing.Size(577, 21);
			this.cmbRazonSocial.Sorted = true;
			this.cmbRazonSocial.TabIndex = 55;
			this.cmbRazonSocial.DropDown += new System.EventHandler(this.CmbRazonSocialDropDown);
			// 
			// lblIva
			// 
			this.lblIva.BackColor = System.Drawing.SystemColors.Control;
			this.lblIva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblIva.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblIva.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblIva.Location = new System.Drawing.Point(112, 48);
			this.lblIva.Name = "lblIva";
			this.lblIva.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblIva.Size = new System.Drawing.Size(81, 17);
			this.lblIva.TabIndex = 17;
			this.lblIva.Text = "0";
			this.lblIva.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cmbPosIVA
			// 
			this.cmbPosIVA.BackColor = System.Drawing.SystemColors.Window;
			this.cmbPosIVA.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbPosIVA.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbPosIVA.Location = new System.Drawing.Point(256, 128);
			this.cmbPosIVA.Name = "cmbPosIVA";
			this.cmbPosIVA.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbPosIVA.Size = new System.Drawing.Size(225, 21);
			this.cmbPosIVA.TabIndex = 54;
			this.cmbPosIVA.Text = "Resp Incripto";
			// 
			// lblCod_cbe
			// 
			this.lblCod_cbe.BackColor = System.Drawing.SystemColors.Control;
			this.lblCod_cbe.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCod_cbe.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCod_cbe.Location = new System.Drawing.Point(53, 32);
			this.lblCod_cbe.Name = "lblCod_cbe";
			this.lblCod_cbe.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCod_cbe.Size = new System.Drawing.Size(24, 17);
			this.lblCod_cbe.TabIndex = 61;
			this.lblCod_cbe.Text = "01";
			// 
			// frTotales
			// 
			this.frTotales.BackColor = System.Drawing.SystemColors.Control;
			this.frTotales.Controls.Add(this._Lbl_12);
			this.frTotales.Controls.Add(this._Lbl_11);
			this.frTotales.Controls.Add(this._Lbl_10);
			this.frTotales.Controls.Add(this.lblSubtotal);
			this.frTotales.Controls.Add(this.lblIva);
			this.frTotales.Controls.Add(this.lblTotal);
			this.frTotales.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frTotales.Location = new System.Drawing.Point(3, 11);
			this.frTotales.Name = "frTotales";
			this.frTotales.Padding = new System.Windows.Forms.Padding(0);
			this.frTotales.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frTotales.Size = new System.Drawing.Size(201, 105);
			this.frTotales.TabIndex = 65;
			this.frTotales.TabStop = false;
			this.frTotales.Text = "En $ (Pesos Argentinos)";
			// 
			// lblTotal
			// 
			this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
			this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTotal.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTotal.Location = new System.Drawing.Point(112, 72);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTotal.Size = new System.Drawing.Size(81, 17);
			this.lblTotal.TabIndex = 16;
			this.lblTotal.Text = "0";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// frCliente
			// 
			this.frCliente.BackColor = System.Drawing.SystemColors.Control;
			this.frCliente.Controls.Add(this.cmbPosIVA);
			this.frCliente.Controls.Add(this.cmdClienteNuevo);
			this.frCliente.Controls.Add(this.cmbRazonSocial);
			this.frCliente.Controls.Add(this.Frame1);
			this.frCliente.Controls.Add(this._Lbl_7);
			this.frCliente.Controls.Add(this.lblIDCliente);
			this.frCliente.Controls.Add(this._Lbl_1);
			this.frCliente.Controls.Add(this._Lbl_2);
			this.frCliente.Controls.Add(this._Lbl_3);
			this.frCliente.Controls.Add(this.lblLocalidad);
			this.frCliente.Controls.Add(this.lblDireccion);
			this.frCliente.Controls.Add(this.lblProvincia);
			this.frCliente.Controls.Add(this._Lbl_4);
			this.frCliente.Controls.Add(this.lblCUIT);
			this.frCliente.Controls.Add(this.lblDolar);
			this.frCliente.Controls.Add(this._Lbl_17);
			this.frCliente.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frCliente.Location = new System.Drawing.Point(11, 117);
			this.frCliente.Name = "frCliente";
			this.frCliente.Padding = new System.Windows.Forms.Padding(0);
			this.frCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frCliente.Size = new System.Drawing.Size(625, 177);
			this.frCliente.TabIndex = 64;
			this.frCliente.TabStop = false;
			// 
			// cmdClienteNuevo
			// 
			this.cmdClienteNuevo.BackColor = System.Drawing.SystemColors.Control;
			this.cmdClienteNuevo.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdClienteNuevo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdClienteNuevo.Location = new System.Drawing.Point(592, 16);
			this.cmdClienteNuevo.Name = "cmdClienteNuevo";
			this.cmdClienteNuevo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdClienteNuevo.Size = new System.Drawing.Size(17, 21);
			this.cmdClienteNuevo.TabIndex = 4;
			this.cmdClienteNuevo.Text = "...";
			this.cmdClienteNuevo.UseVisualStyleBackColor = false;
			// 
			// _Lbl_3
			// 
			this._Lbl_3.AutoSize = true;
			this._Lbl_3.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_3.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_3.Location = new System.Drawing.Point(256, 80);
			this._Lbl_3.Name = "_Lbl_3";
			this._Lbl_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_3.Size = new System.Drawing.Size(51, 13);
			this._Lbl_3.TabIndex = 12;
			this._Lbl_3.Text = "Provincia";
			this._Lbl_3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblLocalidad
			// 
			this.lblLocalidad.BackColor = System.Drawing.SystemColors.Control;
			this.lblLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblLocalidad.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblLocalidad.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblLocalidad.Location = new System.Drawing.Point(72, 72);
			this.lblLocalidad.Name = "lblLocalidad";
			this.lblLocalidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblLocalidad.Size = new System.Drawing.Size(177, 20);
			this.lblLocalidad.TabIndex = 11;
			// 
			// lblDireccion
			// 
			this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
			this.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDireccion.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDireccion.Location = new System.Drawing.Point(72, 48);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDireccion.Size = new System.Drawing.Size(361, 20);
			this.lblDireccion.TabIndex = 10;
			// 
			// lblProvincia
			// 
			this.lblProvincia.BackColor = System.Drawing.SystemColors.Control;
			this.lblProvincia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProvincia.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblProvincia.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProvincia.Location = new System.Drawing.Point(304, 72);
			this.lblProvincia.Name = "lblProvincia";
			this.lblProvincia.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblProvincia.Size = new System.Drawing.Size(169, 20);
			this.lblProvincia.TabIndex = 9;
			// 
			// _Lbl_4
			// 
			this._Lbl_4.AutoSize = true;
			this._Lbl_4.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_4.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_4.Location = new System.Drawing.Point(40, 104);
			this._Lbl_4.Name = "_Lbl_4";
			this._Lbl_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_4.Size = new System.Drawing.Size(32, 13);
			this._Lbl_4.TabIndex = 8;
			this._Lbl_4.Text = "CUIT";
			this._Lbl_4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblCUIT
			// 
			this.lblCUIT.BackColor = System.Drawing.SystemColors.Control;
			this.lblCUIT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCUIT.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCUIT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCUIT.Location = new System.Drawing.Point(72, 96);
			this.lblCUIT.Name = "lblCUIT";
			this.lblCUIT.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCUIT.Size = new System.Drawing.Size(129, 20);
			this.lblCUIT.TabIndex = 7;
			// 
			// lblDolar
			// 
			this.lblDolar.BackColor = System.Drawing.SystemColors.Control;
			this.lblDolar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDolar.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDolar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDolar.Location = new System.Drawing.Point(72, 120);
			this.lblDolar.Name = "lblDolar";
			this.lblDolar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDolar.Size = new System.Drawing.Size(81, 20);
			this.lblDolar.TabIndex = 56;
			// 
			// _Lbl_17
			// 
			this._Lbl_17.AutoSize = true;
			this._Lbl_17.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_17.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_17.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_17.Location = new System.Drawing.Point(40, 128);
			this._Lbl_17.Name = "_Lbl_17";
			this._Lbl_17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_17.Size = new System.Drawing.Size(32, 13);
			this._Lbl_17.TabIndex = 5;
			this._Lbl_17.Text = "Dolar";
			this._Lbl_17.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblTipoFC
			// 
			this.lblTipoFC.AutoSize = true;
			this.lblTipoFC.BackColor = System.Drawing.SystemColors.Control;
			this.lblTipoFC.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblTipoFC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTipoFC.Location = new System.Drawing.Point(56, 13);
			this.lblTipoFC.Name = "lblTipoFC";
			this.lblTipoFC.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTipoFC.Size = new System.Drawing.Size(14, 13);
			this.lblTipoFC.TabIndex = 58;
			this.lblTipoFC.Text = "A";
			// 
			// lblFechVtoCAE
			// 
			this.lblFechVtoCAE.BackColor = System.Drawing.SystemColors.Control;
			this.lblFechVtoCAE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblFechVtoCAE.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblFechVtoCAE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblFechVtoCAE.Location = new System.Drawing.Point(80, 56);
			this.lblFechVtoCAE.Name = "lblFechVtoCAE";
			this.lblFechVtoCAE.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblFechVtoCAE.Size = new System.Drawing.Size(121, 17);
			this.lblFechVtoCAE.TabIndex = 0;
			// 
			// frAFIP
			// 
			this.frAFIP.BackColor = System.Drawing.SystemColors.Control;
			this.frAFIP.Controls.Add(this._Lbl_9);
			this.frAFIP.Controls.Add(this._Lbl_8);
			this.frAFIP.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frAFIP.Location = new System.Drawing.Point(3, 12);
			this.frAFIP.Name = "frAFIP";
			this.frAFIP.Padding = new System.Windows.Forms.Padding(0);
			this.frAFIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frAFIP.Size = new System.Drawing.Size(217, 89);
			this.frAFIP.TabIndex = 76;
			this.frAFIP.TabStop = false;
			this.frAFIP.Text = "AFIP";
			// 
			// _Lbl_9
			// 
			this._Lbl_9.AutoSize = true;
			this._Lbl_9.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_9.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_9.Location = new System.Drawing.Point(2, 56);
			this._Lbl_9.Name = "_Lbl_9";
			this._Lbl_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_9.Size = new System.Drawing.Size(74, 13);
			this._Lbl_9.TabIndex = 59;
			this._Lbl_9.Text = "Fech Vto CAE";
			this._Lbl_9.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_8
			// 
			this._Lbl_8.AutoSize = true;
			this._Lbl_8.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_8.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_8.Location = new System.Drawing.Point(48, 32);
			this._Lbl_8.Name = "_Lbl_8";
			this._Lbl_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_8.Size = new System.Drawing.Size(28, 13);
			this._Lbl_8.TabIndex = 57;
			this._Lbl_8.Text = "CAE";
			this._Lbl_8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblCAE
			// 
			this.lblCAE.BackColor = System.Drawing.SystemColors.Control;
			this.lblCAE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCAE.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblCAE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblCAE.Location = new System.Drawing.Point(80, 24);
			this.lblCAE.Name = "lblCAE";
			this.lblCAE.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblCAE.Size = new System.Drawing.Size(121, 17);
			this.lblCAE.TabIndex = 0;
			// 
			// cmbSucursal
			// 
			this.cmbSucursal.BackColor = System.Drawing.SystemColors.Window;
			this.cmbSucursal.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmbSucursal.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbSucursal.Items.AddRange(new object[] {
			"0001",
			"0002",
			"0003"});
			this.cmbSucursal.Location = new System.Drawing.Point(16, 16);
			this.cmbSucursal.Name = "cmbSucursal";
			this.cmbSucursal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbSucursal.Size = new System.Drawing.Size(65, 21);
			this.cmbSucursal.TabIndex = 43;
			this.cmbSucursal.Text = "0003";
			// 
			// txtCodBarNum
			// 
			this.txtCodBarNum.AcceptsReturn = true;
			this.txtCodBarNum.BackColor = System.Drawing.SystemColors.Window;
			this.txtCodBarNum.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCodBarNum.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCodBarNum.Location = new System.Drawing.Point(103, 523);
			this.txtCodBarNum.MaxLength = 0;
			this.txtCodBarNum.Name = "txtCodBarNum";
			this.txtCodBarNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCodBarNum.Size = new System.Drawing.Size(473, 20);
			this.txtCodBarNum.TabIndex = 78;
			// 
			// frFecha
			// 
			this.frFecha.BackColor = System.Drawing.SystemColors.Control;
			this.frFecha.Controls.Add(this.dtFecha);
			this.frFecha.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frFecha.Location = new System.Drawing.Point(731, 42);
			this.frFecha.Name = "frFecha";
			this.frFecha.Padding = new System.Windows.Forms.Padding(0);
			this.frFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frFecha.Size = new System.Drawing.Size(121, 49);
			this.frFecha.TabIndex = 71;
			this.frFecha.TabStop = false;
			this.frFecha.Text = "Fecha";
			// 
			// dtFecha
			// 
			this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtFecha.Location = new System.Drawing.Point(15, 16);
			this.dtFecha.Name = "dtFecha";
			this.dtFecha.Size = new System.Drawing.Size(90, 20);
			this.dtFecha.TabIndex = 88;
			this.dtFecha.Visible = false;
			// 
			// frNumFact
			// 
			this.frNumFact.BackColor = System.Drawing.SystemColors.Control;
			this.frNumFact.Controls.Add(this.cmbSucursal);
			this.frNumFact.Controls.Add(this.txtNumFact);
			this.frNumFact.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frNumFact.Location = new System.Drawing.Point(527, 42);
			this.frNumFact.Name = "frNumFact";
			this.frNumFact.Padding = new System.Windows.Forms.Padding(0);
			this.frNumFact.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frNumFact.Size = new System.Drawing.Size(193, 41);
			this.frNumFact.TabIndex = 70;
			this.frNumFact.TabStop = false;
			this.frNumFact.Text = "Nro Factura";
			// 
			// txtNumFact
			// 
			this.txtNumFact.AcceptsReturn = true;
			this.txtNumFact.BackColor = System.Drawing.SystemColors.Window;
			this.txtNumFact.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNumFact.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNumFact.Location = new System.Drawing.Point(104, 16);
			this.txtNumFact.MaxLength = 0;
			this.txtNumFact.Name = "txtNumFact";
			this.txtNumFact.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtNumFact.Size = new System.Drawing.Size(81, 20);
			this.txtNumFact.TabIndex = 28;
			// 
			// frTipoFC
			// 
			this.frTipoFC.BackColor = System.Drawing.SystemColors.Control;
			this.frTipoFC.Controls.Add(this.lblCod_cbe);
			this.frTipoFC.Controls.Add(this.lblTipoFC);
			this.frTipoFC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frTipoFC.Location = new System.Drawing.Point(407, 42);
			this.frTipoFC.Name = "frTipoFC";
			this.frTipoFC.Padding = new System.Windows.Forms.Padding(0);
			this.frTipoFC.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frTipoFC.Size = new System.Drawing.Size(114, 56);
			this.frTipoFC.TabIndex = 69;
			this.frTipoFC.TabStop = false;
			this.frTipoFC.Text = "Tipo de Factura";
			// 
			// frDescuento
			// 
			this.frDescuento.BackColor = System.Drawing.SystemColors.Control;
			this.frDescuento.Controls.Add(this.lblDescuento);
			this.frDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frDescuento.Location = new System.Drawing.Point(779, 126);
			this.frDescuento.Name = "frDescuento";
			this.frDescuento.Padding = new System.Windows.Forms.Padding(0);
			this.frDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frDescuento.Size = new System.Drawing.Size(73, 41);
			this.frDescuento.TabIndex = 74;
			this.frDescuento.TabStop = false;
			this.frDescuento.Text = "Descuento";
			// 
			// lblDescuento
			// 
			this.lblDescuento.BackColor = System.Drawing.SystemColors.Control;
			this.lblDescuento.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblDescuento.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblDescuento.Location = new System.Drawing.Point(16, 16);
			this.lblDescuento.Name = "lblDescuento";
			this.lblDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblDescuento.Size = new System.Drawing.Size(41, 17);
			this.lblDescuento.TabIndex = 45;
			this.lblDescuento.Text = "0";
			this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Frame3
			// 
			this.Frame3.BackColor = System.Drawing.SystemColors.Control;
			this.Frame3.Controls.Add(this.optPeso);
			this.Frame3.Controls.Add(this.optDolar);
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.Location = new System.Drawing.Point(642, 117);
			this.Frame3.Name = "Frame3";
			this.Frame3.Padding = new System.Windows.Forms.Padding(0);
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Size = new System.Drawing.Size(129, 50);
			this.Frame3.TabIndex = 73;
			this.Frame3.TabStop = false;
			// 
			// optPeso
			// 
			this.optPeso.Appearance = System.Windows.Forms.Appearance.Button;
			this.optPeso.BackColor = System.Drawing.SystemColors.Control;
			this.optPeso.Cursor = System.Windows.Forms.Cursors.Default;
			this.optPeso.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optPeso.Location = new System.Drawing.Point(72, 16);
			this.optPeso.Name = "optPeso";
			this.optPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optPeso.Size = new System.Drawing.Size(49, 21);
			this.optPeso.TabIndex = 42;
			this.optPeso.TabStop = true;
			this.optPeso.Text = "Peso";
			this.optPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.optPeso.UseVisualStyleBackColor = false;
			// 
			// optDolar
			// 
			this.optDolar.Appearance = System.Windows.Forms.Appearance.Button;
			this.optDolar.BackColor = System.Drawing.SystemColors.Control;
			this.optDolar.Checked = true;
			this.optDolar.Cursor = System.Windows.Forms.Cursors.Default;
			this.optDolar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.optDolar.Location = new System.Drawing.Point(8, 16);
			this.optDolar.Name = "optDolar";
			this.optDolar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.optDolar.Size = new System.Drawing.Size(53, 21);
			this.optDolar.TabIndex = 41;
			this.optDolar.TabStop = true;
			this.optDolar.Text = "Dolar";
			this.optDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.optDolar.UseVisualStyleBackColor = false;
			// 
			// TabControl1
			// 
			this.TabControl1.Location = new System.Drawing.Point(650, 336);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(240, 161);
			this.TabControl1.TabIndex = 80;
			// 
			// tabDolar
			// 
			this.tabDolar.Controls.Add(this.frTotalesUSD);
			this.tabDolar.Location = new System.Drawing.Point(4, 22);
			this.tabDolar.Name = "tabDolar";
			this.tabDolar.Padding = new System.Windows.Forms.Padding(3);
			this.tabDolar.Size = new System.Drawing.Size(232, 135);
			this.tabDolar.TabIndex = 0;
			this.tabDolar.Text = "Dolar";
			this.tabDolar.UseVisualStyleBackColor = true;
			// 
			// frTotalesUSD
			// 
			this.frTotalesUSD.BackColor = System.Drawing.SystemColors.Control;
			this.frTotalesUSD.Controls.Add(this.lblTotalUSD);
			this.frTotalesUSD.Controls.Add(this.lblIvaUSD);
			this.frTotalesUSD.Controls.Add(this.lblSubtotalUSD);
			this.frTotalesUSD.Controls.Add(this._Lbl_6);
			this.frTotalesUSD.Controls.Add(this._Lbl_5);
			this.frTotalesUSD.Controls.Add(this._Lbl_0);
			this.frTotalesUSD.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frTotalesUSD.Location = new System.Drawing.Point(3, 11);
			this.frTotalesUSD.Name = "frTotalesUSD";
			this.frTotalesUSD.Padding = new System.Windows.Forms.Padding(0);
			this.frTotalesUSD.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.frTotalesUSD.Size = new System.Drawing.Size(201, 105);
			this.frTotalesUSD.TabIndex = 76;
			this.frTotalesUSD.TabStop = false;
			this.frTotalesUSD.Text = "En USD (Dolar EEUU)";
			// 
			// lblTotalUSD
			// 
			this.lblTotalUSD.BackColor = System.Drawing.SystemColors.Control;
			this.lblTotalUSD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTotalUSD.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblTotalUSD.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTotalUSD.Location = new System.Drawing.Point(112, 72);
			this.lblTotalUSD.Name = "lblTotalUSD";
			this.lblTotalUSD.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTotalUSD.Size = new System.Drawing.Size(81, 17);
			this.lblTotalUSD.TabIndex = 52;
			this.lblTotalUSD.Text = "0";
			this.lblTotalUSD.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblIvaUSD
			// 
			this.lblIvaUSD.BackColor = System.Drawing.SystemColors.Control;
			this.lblIvaUSD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblIvaUSD.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblIvaUSD.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblIvaUSD.Location = new System.Drawing.Point(112, 48);
			this.lblIvaUSD.Name = "lblIvaUSD";
			this.lblIvaUSD.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblIvaUSD.Size = new System.Drawing.Size(81, 17);
			this.lblIvaUSD.TabIndex = 51;
			this.lblIvaUSD.Text = "0";
			this.lblIvaUSD.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblSubtotalUSD
			// 
			this.lblSubtotalUSD.BackColor = System.Drawing.SystemColors.Control;
			this.lblSubtotalUSD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblSubtotalUSD.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblSubtotalUSD.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblSubtotalUSD.Location = new System.Drawing.Point(112, 24);
			this.lblSubtotalUSD.Name = "lblSubtotalUSD";
			this.lblSubtotalUSD.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblSubtotalUSD.Size = new System.Drawing.Size(81, 17);
			this.lblSubtotalUSD.TabIndex = 50;
			this.lblSubtotalUSD.Text = "0";
			this.lblSubtotalUSD.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_6
			// 
			this._Lbl_6.AutoSize = true;
			this._Lbl_6.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_6.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_6.Location = new System.Drawing.Point(30, 24);
			this._Lbl_6.Name = "_Lbl_6";
			this._Lbl_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_6.Size = new System.Drawing.Size(76, 13);
			this._Lbl_6.TabIndex = 49;
			this._Lbl_6.Text = "SubTotal USD";
			this._Lbl_6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_5
			// 
			this._Lbl_5.AutoSize = true;
			this._Lbl_5.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_5.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_5.Location = new System.Drawing.Point(46, 72);
			this._Lbl_5.Name = "_Lbl_5";
			this._Lbl_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_5.Size = new System.Drawing.Size(57, 13);
			this._Lbl_5.TabIndex = 48;
			this._Lbl_5.Text = "Total USD";
			this._Lbl_5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _Lbl_0
			// 
			this._Lbl_0.AutoSize = true;
			this._Lbl_0.BackColor = System.Drawing.SystemColors.Control;
			this._Lbl_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._Lbl_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._Lbl_0.Location = new System.Drawing.Point(54, 48);
			this._Lbl_0.Name = "_Lbl_0";
			this._Lbl_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Lbl_0.Size = new System.Drawing.Size(50, 13);
			this._Lbl_0.TabIndex = 47;
			this._Lbl_0.Text = "IVA USD";
			this._Lbl_0.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tabPeso
			// 
			this.tabPeso.Controls.Add(this.frTotales);
			this.tabPeso.Location = new System.Drawing.Point(4, 22);
			this.tabPeso.Name = "tabPeso";
			this.tabPeso.Padding = new System.Windows.Forms.Padding(3);
			this.tabPeso.Size = new System.Drawing.Size(232, 135);
			this.tabPeso.TabIndex = 1;
			this.tabPeso.Text = "Peso";
			this.tabPeso.UseVisualStyleBackColor = true;
			// 
			// tabAFIP
			// 
			this.tabAFIP.Controls.Add(this.frAFIP);
			this.tabAFIP.Location = new System.Drawing.Point(4, 22);
			this.tabAFIP.Name = "tabAFIP";
			this.tabAFIP.Size = new System.Drawing.Size(232, 135);
			this.tabAFIP.TabIndex = 2;
			this.tabAFIP.Text = "AFIP";
			this.tabAFIP.UseVisualStyleBackColor = true;
			// 
			// TabPage1
			// 
			this.TabPage1.Controls.Add(this.lblSign);
			this.TabPage1.Controls.Add(this.lblToken);
			this.TabPage1.Location = new System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(232, 135);
			this.TabPage1.TabIndex = 3;
			this.TabPage1.Text = "WebService";
			this.TabPage1.UseVisualStyleBackColor = true;
			// 
			// lblSign
			// 
			this.lblSign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblSign.Location = new System.Drawing.Point(6, 62);
			this.lblSign.Name = "lblSign";
			this.lblSign.Size = new System.Drawing.Size(220, 70);
			this.lblSign.TabIndex = 1;
			this.lblSign.Text = "Sign";
			// 
			// lblToken
			// 
			this.lblToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblToken.Location = new System.Drawing.Point(6, 3);
			this.lblToken.Name = "lblToken";
			this.lblToken.Size = new System.Drawing.Size(220, 59);
			this.lblToken.TabIndex = 0;
			this.lblToken.Text = "Token";
			// 
			// gridDatos
			// 
			this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colCodigo,
			this.colProducto,
			this.colCantidad,
			this.colUMedida,
			this.colPrecioUnitario,
			this.colBonif,
			this.colSubTotal,
			this.colAlicuotaIVA,
			this.colSubTotCIva});
			this.gridDatos.Location = new System.Drawing.Point(19, 314);
			this.gridDatos.Name = "gridDatos";
			this.gridDatos.Size = new System.Drawing.Size(601, 183);
			this.gridDatos.TabIndex = 84;
			// 
			// colCodigo
			// 
			this.colCodigo.HeaderText = "Codigo";
			this.colCodigo.Name = "colCodigo";
			// 
			// colProducto
			// 
			this.colProducto.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.colProducto.HeaderText = "Producto";
			this.colProducto.Name = "colProducto";
			// 
			// colCantidad
			// 
			this.colCantidad.HeaderText = "Cantidad";
			this.colCantidad.Name = "colCantidad";
			this.colCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// colUMedida
			// 
			this.colUMedida.HeaderText = "U. Medida";
			this.colUMedida.Name = "colUMedida";
			this.colUMedida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colUMedida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// colPrecioUnitario
			// 
			this.colPrecioUnitario.HeaderText = "PrecioUnitario(USD)";
			this.colPrecioUnitario.Name = "colPrecioUnitario";
			this.colPrecioUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colPrecioUnitario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// colBonif
			// 
			this.colBonif.HeaderText = "%Bonif";
			this.colBonif.Items.AddRange(new object[] {
			"0",
			"20"});
			this.colBonif.Name = "colBonif";
			// 
			// colSubTotal
			// 
			this.colSubTotal.HeaderText = "Subtotal(USD)";
			this.colSubTotal.Name = "colSubTotal";
			// 
			// colAlicuotaIVA
			// 
			this.colAlicuotaIVA.HeaderText = "Alicuota IVA";
			this.colAlicuotaIVA.Items.AddRange(new object[] {
			"0",
			"10,5",
			"21"});
			this.colAlicuotaIVA.Name = "colAlicuotaIVA";
			this.colAlicuotaIVA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colAlicuotaIVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// colSubTotCIva
			// 
			this.colSubTotCIva.HeaderText = "Subtotal c/Iva (USD)";
			this.colSubTotCIva.Name = "colSubTotCIva";
			// 
			// Calendario
			// 
			this.Calendario.Location = new System.Drawing.Point(706, 509);
			this.Calendario.Name = "Calendario";
			this.Calendario.TabIndex = 89;
			this.Calendario.Visible = false;
			// 
			// cmbRemito1
			// 
			this.cmbRemito1.FormattingEnabled = true;
			this.cmbRemito1.Location = new System.Drawing.Point(4, 16);
			this.cmbRemito1.Name = "cmbRemito1";
			this.cmbRemito1.Size = new System.Drawing.Size(58, 21);
			this.cmbRemito1.TabIndex = 3;
			this.cmbRemito1.Text = "0";
			// 
			// GroupBox1
			// 
			this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.GroupBox1.Controls.Add(this.cmbRemito4);
			this.GroupBox1.Controls.Add(this.cmbRemito3);
			this.GroupBox1.Controls.Add(this.cmbRemito2);
			this.GroupBox1.Controls.Add(this.cmbRemito1);
			this.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.GroupBox1.Location = new System.Drawing.Point(650, 189);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new System.Windows.Forms.Padding(0);
			this.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.GroupBox1.Size = new System.Drawing.Size(236, 105);
			this.GroupBox1.TabIndex = 87;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Remitos";
			// 
			// cmbRemito4
			// 
			this.cmbRemito4.FormattingEnabled = true;
			this.cmbRemito4.Location = new System.Drawing.Point(4, 46);
			this.cmbRemito4.Name = "cmbRemito4";
			this.cmbRemito4.Size = new System.Drawing.Size(58, 21);
			this.cmbRemito4.TabIndex = 0;
			this.cmbRemito4.Text = "0";
			// 
			// cmbRemito3
			// 
			this.cmbRemito3.FormattingEnabled = true;
			this.cmbRemito3.Location = new System.Drawing.Point(144, 16);
			this.cmbRemito3.Name = "cmbRemito3";
			this.cmbRemito3.Size = new System.Drawing.Size(58, 21);
			this.cmbRemito3.TabIndex = 1;
			this.cmbRemito3.Text = "0";
			// 
			// cmbRemito2
			// 
			this.cmbRemito2.FormattingEnabled = true;
			this.cmbRemito2.Location = new System.Drawing.Point(68, 16);
			this.cmbRemito2.Name = "cmbRemito2";
			this.cmbRemito2.Size = new System.Drawing.Size(58, 21);
			this.cmbRemito2.TabIndex = 2;
			this.cmbRemito2.Text = "0";
			// 
			// PictureBox1
			// 
			this.PictureBox1.BackColor = System.Drawing.Color.White;
			this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PictureBox1.Location = new System.Drawing.Point(10, 561);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(625, 39);
			this.PictureBox1.TabIndex = 82;
			this.PictureBox1.TabStop = false;
			// 
			// Toolbar1
			// 
			this.Toolbar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this._Toolbar1_Button1,
			this._Toolbar1_Button2,
			this.tlbGuardar,
			this._Toolbar1_Button4,
			this.tbImprimir,
			this._Toolbar1_Button6,
			this._Toolbar1_Button7,
			this._Toolbar1_Button8,
			this._Toolbar1_Button9});
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.Size = new System.Drawing.Size(1153, 39);
			this.Toolbar1.TabIndex = 145;
			// 
			// _Toolbar1_Button1
			// 
			this._Toolbar1_Button1.Image = ((System.Drawing.Image)(resources.GetObject("_Toolbar1_Button1.Image")));
			this._Toolbar1_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button1.Name = "_Toolbar1_Button1";
			this._Toolbar1_Button1.Size = new System.Drawing.Size(26, 36);
			this._Toolbar1_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button1.ToolTipText = "Nuevo";
			// 
			// _Toolbar1_Button2
			// 
			this._Toolbar1_Button2.Name = "_Toolbar1_Button2";
			this._Toolbar1_Button2.Size = new System.Drawing.Size(6, 39);
			// 
			// tlbGuardar
			// 
			this.tlbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tlbGuardar.Image")));
			this.tlbGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tlbGuardar.Name = "tlbGuardar";
			this.tlbGuardar.Size = new System.Drawing.Size(26, 36);
			this.tlbGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tlbGuardar.ToolTipText = "Guardar";
			// 
			// _Toolbar1_Button4
			// 
			this._Toolbar1_Button4.AutoSize = false;
			this._Toolbar1_Button4.Name = "_Toolbar1_Button4";
			this._Toolbar1_Button4.Size = new System.Drawing.Size(0, 39);
			// 
			// tbImprimir
			// 
			this.tbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tbImprimir.Image")));
			this.tbImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tbImprimir.Name = "tbImprimir";
			this.tbImprimir.Size = new System.Drawing.Size(26, 36);
			this.tbImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tbImprimir.ToolTipText = "Imprimir";
			// 
			// _Toolbar1_Button6
			// 
			this._Toolbar1_Button6.Name = "_Toolbar1_Button6";
			this._Toolbar1_Button6.Size = new System.Drawing.Size(6, 39);
			// 
			// _Toolbar1_Button7
			// 
			this._Toolbar1_Button7.Image = ((System.Drawing.Image)(resources.GetObject("_Toolbar1_Button7.Image")));
			this._Toolbar1_Button7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button7.Name = "_Toolbar1_Button7";
			this._Toolbar1_Button7.Size = new System.Drawing.Size(26, 36);
			this._Toolbar1_Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button7.ToolTipText = "Anular";
			// 
			// _Toolbar1_Button8
			// 
			this._Toolbar1_Button8.Name = "_Toolbar1_Button8";
			this._Toolbar1_Button8.Size = new System.Drawing.Size(6, 39);
			// 
			// _Toolbar1_Button9
			// 
			this._Toolbar1_Button9.Image = ((System.Drawing.Image)(resources.GetObject("_Toolbar1_Button9.Image")));
			this._Toolbar1_Button9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._Toolbar1_Button9.Name = "_Toolbar1_Button9";
			this._Toolbar1_Button9.Size = new System.Drawing.Size(26, 36);
			this._Toolbar1_Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._Toolbar1_Button9.ToolTipText = "Editar";
			// 
			// frmDocFiscal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1153, 746);
			this.Controls.Add(this.Toolbar1);
			this.Controls.Add(this.Calendario);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.gridDatos);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.frCliente);
			this.Controls.Add(this.txtCodBarNum);
			this.Controls.Add(this.frFecha);
			this.Controls.Add(this.frNumFact);
			this.Controls.Add(this.frTipoFC);
			this.Controls.Add(this.frDescuento);
			this.Controls.Add(this.Frame3);
			this.Name = "frmDocFiscal";
			this.Load += new System.EventHandler(this.FrmDocFiscal3Load);
			this.frTotales.ResumeLayout(false);
			this.frTotales.PerformLayout();
			this.frCliente.ResumeLayout(false);
			this.frCliente.PerformLayout();
			this.frAFIP.ResumeLayout(false);
			this.frAFIP.PerformLayout();
			this.frFecha.ResumeLayout(false);
			this.frNumFact.ResumeLayout(false);
			this.frNumFact.PerformLayout();
			this.frTipoFC.ResumeLayout(false);
			this.frTipoFC.PerformLayout();
			this.frDescuento.ResumeLayout(false);
			this.Frame3.ResumeLayout(false);
			this.tabDolar.ResumeLayout(false);
			this.frTotalesUSD.ResumeLayout(false);
			this.frTotalesUSD.PerformLayout();
			this.tabPeso.ResumeLayout(false);
			this.tabAFIP.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
			this.Toolbar1.ResumeLayout(false);
			this.Toolbar1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.Label _Lbl_11;
		public System.Windows.Forms.Label _Lbl_12;
		public System.Windows.Forms.Label _Lbl_7;
		public System.Windows.Forms.Label _Lbl_10;
		public System.Windows.Forms.Label _Lbl_2;
		public System.Windows.Forms.Label lblSubtotal;
		public System.Windows.Forms.Label _Lbl_1;
		//private System.Windows.Forms.ComboBox withEventsField_cmbRazonSocial;
		public System.Windows.Forms.ComboBox cmbRazonSocial;
			/* {
			get { return withEventsField_cmbRazonSocial; }
			set {
				if (withEventsField_cmbRazonSocial != null) {
					withEventsField_cmbRazonSocial.SelectedValueChanged -= cmbRazonSocial_SelectedValueChanged;
				}
				withEventsField_cmbRazonSocial = value;
				if (withEventsField_cmbRazonSocial != null) {
					withEventsField_cmbRazonSocial.SelectedValueChanged += cmbRazonSocial_SelectedValueChanged;
				}
			}
		}*/
		public System.Windows.Forms.Label lblIva;
		public System.Windows.Forms.ComboBox cmbPosIVA;
		public System.Windows.Forms.Label lblCod_cbe;
		public System.Windows.Forms.GroupBox frTotales;
		public System.Windows.Forms.Label lblTotal;
		public System.Windows.Forms.GroupBox frCliente;
		public System.Windows.Forms.Button cmdClienteNuevo;
		public System.Windows.Forms.Label _Lbl_3;
		public System.Windows.Forms.Label lblLocalidad;
		public System.Windows.Forms.Label lblDireccion;
		public System.Windows.Forms.Label lblProvincia;
		public System.Windows.Forms.Label _Lbl_4;
		public System.Windows.Forms.Label lblCUIT;
		//private System.Windows.Forms.Label withEventsField_lblDolar;
		public System.Windows.Forms.Label lblDolar; 
		/*{
			get { return withEventsField_lblDolar; }
			set {
				if (withEventsField_lblDolar != null) {
					withEventsField_lblDolar.DoubleClick -= lblDolar_DoubleClick;
				}
				withEventsField_lblDolar = value;
				if (withEventsField_lblDolar != null) {
					withEventsField_lblDolar.DoubleClick += lblDolar_DoubleClick;
				}
			}
		}*/
		public System.Windows.Forms.Label _Lbl_17;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button6;
		//private System.Windows.Forms.ToolStripButton withEventsField__Toolbar1_Imprimir;
			/*{
			get { return withEventsField__Toolbar1_Imprimir; }
			set {
				if (withEventsField__Toolbar1_Imprimir != null) {
					withEventsField__Toolbar1_Imprimir.Click -= _Toolbar1_Imprimir_Click;
				}
				withEventsField__Toolbar1_Imprimir = value;
				if (withEventsField__Toolbar1_Imprimir != null) {
					withEventsField__Toolbar1_Imprimir.Click += _Toolbar1_Imprimir_Click;
				}
			}
		}*/
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button4;
		//private System.Windows.Forms.ToolStripButton withEventsField__Toolbar1_Guardar;
		 
			/*{
			get { return withEventsField__Toolbar1_Guardar; }
			set {
				if (withEventsField__Toolbar1_Guardar != null) {
					withEventsField__Toolbar1_Guardar.Click -= _Toolbar1_Guardar_Click;
				}
				withEventsField__Toolbar1_Guardar = value;
				if (withEventsField__Toolbar1_Guardar != null) {
					withEventsField__Toolbar1_Guardar.Click += _Toolbar1_Guardar_Click;
				}
			}
		}*/
		//private System.Windows.Forms.ToolStripButton withEventsField__Toolbar1_Nuevo;
		 /*{
			get { return withEventsField__Toolbar1_Nuevo; }
			set {
				if (withEventsField__Toolbar1_Nuevo != null) {
					withEventsField__Toolbar1_Nuevo.Click -= _Toolbar1_Nuevo_Click;
				}
				withEventsField__Toolbar1_Nuevo = value;
				if (withEventsField__Toolbar1_Nuevo != null) {
					withEventsField__Toolbar1_Nuevo.Click += _Toolbar1_Nuevo_Click;
				}
			}
		}*/
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.Label lblTipoFC;
		//private System.Windows.Forms.Label withEventsField_lblFechVtoCAE;
		public System.Windows.Forms.Label lblFechVtoCAE; /*{
			get { return withEventsField_lblFechVtoCAE; }
			set {
				if (withEventsField_lblFechVtoCAE != null) {
					withEventsField_lblFechVtoCAE.TextChanged -= lblFechVtoCAE_TextChanged;
					withEventsField_lblFechVtoCAE.Click -= lblFechVtoCAE_Click;
				}
				withEventsField_lblFechVtoCAE = value;
				if (withEventsField_lblFechVtoCAE != null) {
					withEventsField_lblFechVtoCAE.TextChanged += lblFechVtoCAE_TextChanged;
					withEventsField_lblFechVtoCAE.Click += lblFechVtoCAE_Click;
				}
			}
		}*/
		public System.Windows.Forms.GroupBox frAFIP;
		public System.Windows.Forms.Label _Lbl_9;
		public System.Windows.Forms.Label _Lbl_8;
		//private System.Windows.Forms.Label withEventsField_lblCAE;
		public System.Windows.Forms.Label lblCAE; /*{
			get { return withEventsField_lblCAE; }
			set {
				if (withEventsField_lblCAE != null) {
					withEventsField_lblCAE.DoubleClick -= lblCAE_DoubleClick;
				}
				withEventsField_lblCAE = value;
				if (withEventsField_lblCAE != null) {
					withEventsField_lblCAE.DoubleClick += lblCAE_DoubleClick;
				}
			}
		}*/
		public System.Windows.Forms.ComboBox cmbSucursal;
		//private System.Windows.Forms.TextBox withEventsField_txtCodBarNum;
		public System.Windows.Forms.TextBox txtCodBarNum;/* {
			get { return withEventsField_txtCodBarNum; }
			set {
				if (withEventsField_txtCodBarNum != null) {
					withEventsField_txtCodBarNum.TextChanged -= txtCodBarNum_TextChanged;
				}
				withEventsField_txtCodBarNum = value;
				if (withEventsField_txtCodBarNum != null) {
					withEventsField_txtCodBarNum.TextChanged += txtCodBarNum_TextChanged;
				}
			}
		}*/
		public System.Windows.Forms.GroupBox frFecha;
		//private System.Windows.Forms.Label withEventsField_lblFecha;
		/* {
			get { return withEventsField_lblFecha; }
			set {
				if (withEventsField_lblFecha != null) {
					withEventsField_lblFecha.Click -= lblFecha_Click;
				}
				withEventsField_lblFecha = value;
				if (withEventsField_lblFecha != null) {
					withEventsField_lblFecha.Click += lblFecha_Click;
				}
			}
		}*/
		public System.Windows.Forms.GroupBox frNumFact;
		public System.Windows.Forms.TextBox txtNumFact;
		public System.Windows.Forms.GroupBox frTipoFC;
		public System.Windows.Forms.GroupBox frDescuento;
		public System.Windows.Forms.Label lblDescuento;
		public System.Windows.Forms.GroupBox Frame3;
		public System.Windows.Forms.RadioButton optPeso;
		public System.Windows.Forms.RadioButton optDolar;
		/*internal WindowsApplication1.ClientesDataSet ClientesDataSet;
		internal System.Windows.Forms.BindingSource ClientesDataSetBindingSource;
		internal System.Windows.Forms.BindingSource ClientesBindingSource;
		internal WindowsApplication1.ClientesDataSetTableAdapters.ClientesTableAdapter ClientesTableAdapter;*/
		internal System.Windows.Forms.TabPage tabDolar;
		internal System.Windows.Forms.TabPage tabPeso;
		internal System.Windows.Forms.TabControl TabControl1;
		public System.Windows.Forms.GroupBox frTotalesUSD;
		public System.Windows.Forms.Label lblTotalUSD;
		public System.Windows.Forms.Label lblIvaUSD;
		public System.Windows.Forms.Label lblSubtotalUSD;
		public System.Windows.Forms.Label _Lbl_6;
		public System.Windows.Forms.Label _Lbl_5;
		public System.Windows.Forms.Label _Lbl_0;
		internal System.Windows.Forms.TabPage tabAFIP;
		internal System.Windows.Forms.PictureBox PictureBox1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.Label lblToken;
		internal System.Windows.Forms.Label lblSign;
		//private System.Windows.Forms.DataGridView withEventsField_gridDatos;
		internal System.Windows.Forms.DataGridView gridDatos; /*{
			get { return withEventsField_gridDatos; }
			set {
				if (withEventsField_gridDatos != null) {
					withEventsField_gridDatos.CellEndEdit -= gridDatos_CellEndEdit;
				}
				withEventsField_gridDatos = value;
				if (withEventsField_gridDatos != null) {
					withEventsField_gridDatos.CellEndEdit += gridDatos_CellEndEdit;
				}
			}
		}*/
		//private System.Windows.Forms.MonthCalendar withEventsField_Calendario;
		//internal System.Windows.Forms.MonthCalendar Calendario; /*{
		public  System.Windows.Forms.MonthCalendar Calendario; 
		/*{
			get { return withEventsField_Calendario; }
			set {
				if (withEventsField_Calendario != null) {
					withEventsField_Calendario.DateSelected -= Calendario_DateSelected;
				}
				withEventsField_Calendario = value;
				if (withEventsField_Calendario != null) {
					withEventsField_Calendario.DateSelected += Calendario_DateSelected;
				}
			}
		}*/
		//private System.Windows.Forms.ComboBox withEventsField_cmbRemito1;
		internal System.Windows.Forms.ComboBox cmbRemito1; /*{
			get { return withEventsField_cmbRemito1; }
			set {
				if (withEventsField_cmbRemito1 != null) {
					withEventsField_cmbRemito1.DropDown -= cmbRemito1_DropDown;
					withEventsField_cmbRemito1.SelectedIndexChanged -= cmbRemito1_SelectedIndexChanged;
				}
				withEventsField_cmbRemito1 = value;
				if (withEventsField_cmbRemito1 != null) {
					withEventsField_cmbRemito1.DropDown += cmbRemito1_DropDown;
					withEventsField_cmbRemito1.SelectedIndexChanged += cmbRemito1_SelectedIndexChanged;
				}
			}
		}*/
		public System.Windows.Forms.GroupBox GroupBox1;
		//private System.Windows.Forms.ComboBox withEventsField_cmbRemito4;
		internal System.Windows.Forms.ComboBox cmbRemito4; /*{
			get { return withEventsField_cmbRemito4; }
			set {
				if (withEventsField_cmbRemito4 != null) {
					withEventsField_cmbRemito4.DropDown -= cmbRemito4_DropDown;
					withEventsField_cmbRemito4.SelectedIndexChanged -= cmbRemito4_SelectedIndexChanged;
				}
				withEventsField_cmbRemito4 = value;
				if (withEventsField_cmbRemito4 != null) {
					withEventsField_cmbRemito4.DropDown += cmbRemito4_DropDown;
					withEventsField_cmbRemito4.SelectedIndexChanged += cmbRemito4_SelectedIndexChanged;
				}
			}
		}*/
		//private System.Windows.Forms.ComboBox withEventsField_cmbRemito3;
		internal System.Windows.Forms.ComboBox cmbRemito3; /*{
			get { return withEventsField_cmbRemito3; }
			set {
				if (withEventsField_cmbRemito3 != null) {
					withEventsField_cmbRemito3.DropDown -= cmbRemito3_DropDown;
					withEventsField_cmbRemito3.SelectedIndexChanged -= cmbRemito3_SelectedIndexChanged;
				}
				withEventsField_cmbRemito3 = value;
				if (withEventsField_cmbRemito3 != null) {
					withEventsField_cmbRemito3.DropDown += cmbRemito3_DropDown;
					withEventsField_cmbRemito3.SelectedIndexChanged += cmbRemito3_SelectedIndexChanged;
				}
			}
		}*/
		//private System.Windows.Forms.ComboBox withEventsField_cmbRemito2;
		internal System.Windows.Forms.ComboBox cmbRemito2; /*{
			get { return withEventsField_cmbRemito2; }
			set {
				if (withEventsField_cmbRemito2 != null) {
					withEventsField_cmbRemito2.DropDown -= cmbRemito2_DropDown;
					withEventsField_cmbRemito2.SelectedIndexChanged -= cmbRemito2_SelectedIndexChanged;
				}
				withEventsField_cmbRemito2 = value;
				if (withEventsField_cmbRemito2 != null) {
					withEventsField_cmbRemito2.DropDown += cmbRemito2_DropDown;
					withEventsField_cmbRemito2.SelectedIndexChanged += cmbRemito2_SelectedIndexChanged;
				}
			}
		}*/
		internal System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
		internal System.Windows.Forms.DataGridViewComboBoxColumn colProducto;
		internal System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
		internal System.Windows.Forms.DataGridViewTextBoxColumn colUMedida;
		internal System.Windows.Forms.DataGridViewTextBoxColumn colPrecioUnitario;
		internal System.Windows.Forms.DataGridViewComboBoxColumn colBonif;
		internal System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
		internal System.Windows.Forms.DataGridViewComboBoxColumn colAlicuotaIVA;
		internal System.Windows.Forms.DataGridViewTextBoxColumn colSubTotCIva;
		internal System.Windows.Forms.DateTimePicker dtFecha;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button1;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button2;
		public System.Windows.Forms.ToolStripButton tlbGuardar;
		public System.Windows.Forms.ToolStripButton tbImprimir;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button7;
		public System.Windows.Forms.ToolStripSeparator _Toolbar1_Button8;
		public System.Windows.Forms.ToolStripButton _Toolbar1_Button9;
		public System.Windows.Forms.Label lblIDCliente;
	}
}
