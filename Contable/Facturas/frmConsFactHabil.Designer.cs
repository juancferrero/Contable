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
namespace WindowsApplication1
{
	//[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class frmConsFactHabil : System.Windows.Forms.Form
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
			this.cmdConsultar = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtNumFact = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.lblCAE = new System.Windows.Forms.Label();
			this.lblValorFinal = new System.Windows.Forms.Label();
			this.lblIVA = new System.Windows.Forms.Label();
			this.lblNeto = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//cmdConsultar
			/*
			this.cmdConsultar.Location = new System.Drawing.Point(533, 51);
			this.cmdConsultar.Name = "cmdConsultar";
			this.cmdConsultar.Size = new System.Drawing.Size(72, 46);
			this.cmdConsultar.TabIndex = 0;
			this.cmdConsultar.Text = "Consultar";
			this.cmdConsultar.UseVisualStyleBackColor = true;
			*/
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(55, 35);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(98, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Numero de Factura";
			//
			//txtNumFact
			//
			this.txtNumFact.Location = new System.Drawing.Point(159, 32);
			this.txtNumFact.Name = "txtNumFact";
			this.txtNumFact.Size = new System.Drawing.Size(128, 20);
			this.txtNumFact.TabIndex = 2;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label9);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.lblNeto);
			this.GroupBox1.Controls.Add(this.lblIVA);
			this.GroupBox1.Controls.Add(this.lblValorFinal);
			this.GroupBox1.Controls.Add(this.lblCAE);
			this.GroupBox1.Controls.Add(this.lblRespuesta);
			this.GroupBox1.Location = new System.Drawing.Point(21, 127);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(295, 230);
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Respuesta de la AFIP";
			//
			//lblRespuesta
			//
			this.lblRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRespuesta.Location = new System.Drawing.Point(70, 33);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(84, 15);
			this.lblRespuesta.TabIndex = 0;
			this.lblRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(6, 33);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(58, 13);
			this.Label3.TabIndex = 0;
			this.Label3.Text = "Respuesta";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(6, 88);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(56, 13);
			this.Label4.TabIndex = 0;
			this.Label4.Text = "Valor Final";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(6, 114);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(24, 13);
			this.Label5.TabIndex = 0;
			this.Label5.Text = "IVA";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(6, 59);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(28, 13);
			this.Label6.TabIndex = 0;
			this.Label6.Text = "CAE";
			//
			//lblCAE
			//
			this.lblCAE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblCAE.Location = new System.Drawing.Point(70, 57);
			this.lblCAE.Name = "lblCAE";
			this.lblCAE.Size = new System.Drawing.Size(84, 15);
			this.lblCAE.TabIndex = 0;
			this.lblCAE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//lblValorFinal
			//
			this.lblValorFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblValorFinal.Location = new System.Drawing.Point(70, 86);
			this.lblValorFinal.Name = "lblValorFinal";
			this.lblValorFinal.Size = new System.Drawing.Size(84, 15);
			this.lblValorFinal.TabIndex = 0;
			this.lblValorFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//lblIVA
			//
			this.lblIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblIVA.Location = new System.Drawing.Point(70, 112);
			this.lblIVA.Name = "lblIVA";
			this.lblIVA.Size = new System.Drawing.Size(84, 15);
			this.lblIVA.TabIndex = 0;
			this.lblIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//lblNeto
			//
			this.lblNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblNeto.Location = new System.Drawing.Point(70, 137);
			this.lblNeto.Name = "lblNeto";
			this.lblNeto.Size = new System.Drawing.Size(84, 15);
			this.lblNeto.TabIndex = 0;
			this.lblNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Location = new System.Drawing.Point(6, 139);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(57, 13);
			this.Label9.TabIndex = 0;
			this.Label9.Text = "Valor Neto";
			//
			//frmConsFactHabil
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1112, 572);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.txtNumFact);
			this.Controls.Add(this.Label1);
			//this.Controls.Add(this.cmdConsultar);
			this.Name = "frmConsFactHabil";
			this.Text = "frmConsFactHabil";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		/*private System.Windows.Forms.Button withEventsField_cmdConsultar;
		internal System.Windows.Forms.Button cmdConsultar {
			get { return withEventsField_cmdConsultar; }
			set {
				if (withEventsField_cmdConsultar != null) {
					withEventsField_cmdConsultar.Click -= cmdConsultar_Click;
				}
				withEventsField_cmdConsultar = value;
				if (withEventsField_cmdConsultar != null) {
					withEventsField_cmdConsultar.Click += cmdConsultar_Click;
				}
			}
		}*/
	
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtNumFact;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label lblRespuesta;
		internal System.Windows.Forms.Label lblCAE;
		internal System.Windows.Forms.Label lblIVA;
		internal System.Windows.Forms.Label lblValorFinal;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label lblNeto;
	}
}
