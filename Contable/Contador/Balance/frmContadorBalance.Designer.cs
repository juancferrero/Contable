﻿/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 24/11/2016
 * Hora: 06:47 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Contable.Contador.Balance
{
	partial class frmContadorBalance
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView gridBalance;
		private System.Windows.Forms.Button button2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.gridBalance = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridBalance)).BeginInit();
			this.SuspendLayout();
			// 
			// gridBalance
			// 
			this.gridBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridBalance.Location = new System.Drawing.Point(12, 103);
			this.gridBalance.Name = "gridBalance";
			this.gridBalance.Size = new System.Drawing.Size(1008, 387);
			this.gridBalance.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(794, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(162, 38);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(877, 68);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(153, 29);
			this.button2.TabIndex = 3;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// frmContadorBalance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1363, 711);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.gridBalance);
			this.Name = "frmContadorBalance";
			this.Text = "frmContadorBalance";
			this.Load += new System.EventHandler(this.FrmContadorBalanceLoad);
			((System.ComponentModel.ISupportInitialize)(this.gridBalance)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
