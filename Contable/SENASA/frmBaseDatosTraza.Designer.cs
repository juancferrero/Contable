/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 02/07/2014
 * Hora: 01:56 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Contable.SENASA
{
	partial class frmBaseDatosTraza
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseDatosTraza));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tlNuevos = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.tlAgregarMercaderia = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tlEditar = new System.Windows.Forms.ToolStripButton();
			this.tlNuevo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.cmbDescripcion = new System.Windows.Forms.ComboBox();
			this.dtFechaEgreso = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtCantxcaja = new System.Windows.Forms.TextBox();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabProducto = new System.Windows.Forms.TabPage();
			this.txtSerieFinal = new System.Windows.Forms.TextBox();
			this.txtSerieInicio = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLote = new System.Windows.Forms.TextBox();
			this.txtNroFactura = new System.Windows.Forms.TextBox();
			this.txtNroRemito = new System.Windows.Forms.TextBox();
			this.tabCliente = new System.Windows.Forms.TabPage();
			this.lblCUIT = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.lblIDCliente = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.cmbCliente = new System.Windows.Forms.ComboBox();
			this.txtGLNDestino = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tabFechas = new System.Windows.Forms.TabPage();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.tabStock = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.btnQuitarDuplicado = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.gridStock = new System.Windows.Forms.DataGridView();
			this.toolStrip1.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabProducto.SuspendLayout();
			this.tabCliente.SuspendLayout();
			this.tabFechas.SuspendLayout();
			this.tabStock.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridStock)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tlNuevos,
			this.toolStripButton2,
			this.tlAgregarMercaderia,
			this.toolStripSeparator2,
			this.tlEditar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1370, 25);
			this.toolStrip1.TabIndex = 20;
			// 
			// tlNuevos
			// 
			this.tlNuevos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlNuevos.Image = ((System.Drawing.Image)(resources.GetObject("tlNuevos.Image")));
			this.tlNuevos.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlNuevos.Name = "tlNuevos";
			this.tlNuevos.Size = new System.Drawing.Size(23, 22);
			this.tlNuevos.Text = "Nuevo";
			this.tlNuevos.Click += new System.EventHandler(this.TlNuevosClick);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton2.ToolTipText = "Modificar Cajas";
			this.toolStripButton2.Click += new System.EventHandler(this.ToolStripButton2Click);
			// 
			// tlAgregarMercaderia
			// 
			this.tlAgregarMercaderia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlAgregarMercaderia.Image = ((System.Drawing.Image)(resources.GetObject("tlAgregarMercaderia.Image")));
			this.tlAgregarMercaderia.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlAgregarMercaderia.Name = "tlAgregarMercaderia";
			this.tlAgregarMercaderia.Size = new System.Drawing.Size(23, 22);
			this.tlAgregarMercaderia.Text = "Agregar";
			this.tlAgregarMercaderia.ToolTipText = "Agregar Mercaderia a la base";
			this.tlAgregarMercaderia.Click += new System.EventHandler(this.TlAgregarMercaderiaClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tlEditar
			// 
			this.tlEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tlEditar.Image = ((System.Drawing.Image)(resources.GetObject("tlEditar.Image")));
			this.tlEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlEditar.Name = "tlEditar";
			this.tlEditar.Size = new System.Drawing.Size(23, 22);
			this.tlEditar.ToolTipText = "Editar DB";
			this.tlEditar.Click += new System.EventHandler(this.TlEditarClick);
			// 
			// tlNuevo
			// 
			this.tlNuevo.Name = "tlNuevo";
			this.tlNuevo.Size = new System.Drawing.Size(23, 23);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "Editar";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 728);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1370, 22);
			this.statusStrip1.TabIndex = 19;
			// 
			// cmbDescripcion
			// 
			this.cmbDescripcion.FormattingEnabled = true;
			this.cmbDescripcion.Location = new System.Drawing.Point(110, 54);
			this.cmbDescripcion.Name = "cmbDescripcion";
			this.cmbDescripcion.Size = new System.Drawing.Size(238, 21);
			this.cmbDescripcion.TabIndex = 2;
			this.cmbDescripcion.DropDown += new System.EventHandler(this.CmbDescripcionDropDown);
			// 
			// dtFechaEgreso
			// 
			this.dtFechaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFechaEgreso.Location = new System.Drawing.Point(119, 30);
			this.dtFechaEgreso.Name = "dtFechaEgreso";
			this.dtFechaEgreso.Size = new System.Drawing.Size(200, 20);
			this.dtFechaEgreso.TabIndex = 3;
			this.dtFechaEgreso.ValueChanged += new System.EventHandler(this.DtFechaEgresoValueChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 29);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 21);
			this.label7.TabIndex = 17;
			this.label7.Text = "Fecha Egreso";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 57);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 21);
			this.label8.TabIndex = 18;
			this.label8.Text = "Descripcion";
			// 
			// txtCantxcaja
			// 
			this.txtCantxcaja.Location = new System.Drawing.Point(84, 432);
			this.txtCantxcaja.Name = "txtCantxcaja";
			this.txtCantxcaja.Size = new System.Drawing.Size(115, 20);
			this.txtCantxcaja.TabIndex = 27;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabProducto);
			this.tabControl.Controls.Add(this.tabCliente);
			this.tabControl.Controls.Add(this.tabFechas);
			this.tabControl.Controls.Add(this.tabStock);
			this.tabControl.Location = new System.Drawing.Point(12, 31);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(917, 395);
			this.tabControl.TabIndex = 28;
			// 
			// tabProducto
			// 
			this.tabProducto.Controls.Add(this.txtSerieFinal);
			this.tabProducto.Controls.Add(this.txtSerieInicio);
			this.tabProducto.Controls.Add(this.label8);
			this.tabProducto.Controls.Add(this.label5);
			this.tabProducto.Controls.Add(this.label4);
			this.tabProducto.Controls.Add(this.label3);
			this.tabProducto.Controls.Add(this.cmbDescripcion);
			this.tabProducto.Controls.Add(this.label2);
			this.tabProducto.Controls.Add(this.label1);
			this.tabProducto.Controls.Add(this.txtLote);
			this.tabProducto.Controls.Add(this.txtNroFactura);
			this.tabProducto.Controls.Add(this.txtNroRemito);
			this.tabProducto.Location = new System.Drawing.Point(4, 22);
			this.tabProducto.Name = "tabProducto";
			this.tabProducto.Padding = new System.Windows.Forms.Padding(3);
			this.tabProducto.Size = new System.Drawing.Size(909, 369);
			this.tabProducto.TabIndex = 0;
			this.tabProducto.Text = "Producto";
			this.tabProducto.UseVisualStyleBackColor = true;
			// 
			// txtSerieFinal
			// 
			this.txtSerieFinal.Location = new System.Drawing.Point(110, 168);
			this.txtSerieFinal.Name = "txtSerieFinal";
			this.txtSerieFinal.Size = new System.Drawing.Size(100, 20);
			this.txtSerieFinal.TabIndex = 24;
			// 
			// txtSerieInicio
			// 
			this.txtSerieInicio.Location = new System.Drawing.Point(110, 130);
			this.txtSerieInicio.Name = "txtSerieInicio";
			this.txtSerieInicio.Size = new System.Drawing.Size(100, 20);
			this.txtSerieInicio.TabIndex = 23;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 17);
			this.label5.TabIndex = 22;
			this.label5.Text = "Serie Final";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 17);
			this.label4.TabIndex = 21;
			this.label4.Text = "Serie Inicio";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 17);
			this.label3.TabIndex = 20;
			this.label3.Text = "Lote";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(304, 168);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 17);
			this.label2.TabIndex = 19;
			this.label2.Text = "Nro Factura";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(304, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 17);
			this.label1.TabIndex = 18;
			this.label1.Text = "Nro Remito";
			// 
			// txtLote
			// 
			this.txtLote.Location = new System.Drawing.Point(110, 95);
			this.txtLote.Name = "txtLote";
			this.txtLote.Size = new System.Drawing.Size(100, 20);
			this.txtLote.TabIndex = 17;
			// 
			// txtNroFactura
			// 
			this.txtNroFactura.Location = new System.Drawing.Point(398, 165);
			this.txtNroFactura.Name = "txtNroFactura";
			this.txtNroFactura.Size = new System.Drawing.Size(100, 20);
			this.txtNroFactura.TabIndex = 16;
			// 
			// txtNroRemito
			// 
			this.txtNroRemito.Location = new System.Drawing.Point(398, 130);
			this.txtNroRemito.Name = "txtNroRemito";
			this.txtNroRemito.Size = new System.Drawing.Size(100, 20);
			this.txtNroRemito.TabIndex = 15;
			// 
			// tabCliente
			// 
			this.tabCliente.Controls.Add(this.lblCUIT);
			this.tabCliente.Controls.Add(this.label12);
			this.tabCliente.Controls.Add(this.lblIDCliente);
			this.tabCliente.Controls.Add(this.label10);
			this.tabCliente.Controls.Add(this.label9);
			this.tabCliente.Controls.Add(this.cmbCliente);
			this.tabCliente.Controls.Add(this.txtGLNDestino);
			this.tabCliente.Controls.Add(this.label6);
			this.tabCliente.Location = new System.Drawing.Point(4, 22);
			this.tabCliente.Name = "tabCliente";
			this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
			this.tabCliente.Size = new System.Drawing.Size(909, 369);
			this.tabCliente.TabIndex = 1;
			this.tabCliente.Text = "Cliente";
			this.tabCliente.UseVisualStyleBackColor = true;
			// 
			// lblCUIT
			// 
			this.lblCUIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblCUIT.Location = new System.Drawing.Point(135, 95);
			this.lblCUIT.Name = "lblCUIT";
			this.lblCUIT.Size = new System.Drawing.Size(180, 21);
			this.lblCUIT.TabIndex = 34;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(6, 89);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(71, 21);
			this.label12.TabIndex = 33;
			this.label12.Text = "CUIT";
			// 
			// lblIDCliente
			// 
			this.lblIDCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblIDCliente.Location = new System.Drawing.Point(135, 59);
			this.lblIDCliente.Name = "lblIDCliente";
			this.lblIDCliente.Size = new System.Drawing.Size(180, 21);
			this.lblIDCliente.TabIndex = 32;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(6, 61);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(71, 21);
			this.label10.TabIndex = 31;
			this.label10.Text = "ID Cliente";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(6, 28);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 21);
			this.label9.TabIndex = 30;
			this.label9.Text = "Cliente";
			// 
			// cmbCliente
			// 
			this.cmbCliente.FormattingEnabled = true;
			this.cmbCliente.Location = new System.Drawing.Point(133, 28);
			this.cmbCliente.Name = "cmbCliente";
			this.cmbCliente.Size = new System.Drawing.Size(183, 21);
			this.cmbCliente.TabIndex = 29;
			this.cmbCliente.DropDown += new System.EventHandler(this.CmbClienteDropDown);
			this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.CmbClienteSelectedIndexChanged);
			this.cmbCliente.DropDownClosed += new System.EventHandler(this.CmbClienteDropDownClosed);
			// 
			// txtGLNDestino
			// 
			this.txtGLNDestino.Location = new System.Drawing.Point(133, 122);
			this.txtGLNDestino.Name = "txtGLNDestino";
			this.txtGLNDestino.Size = new System.Drawing.Size(96, 20);
			this.txtGLNDestino.TabIndex = 28;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 125);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 21);
			this.label6.TabIndex = 27;
			this.label6.Text = "GLN Destino";
			// 
			// tabFechas
			// 
			this.tabFechas.Controls.Add(this.dateTimePicker1);
			this.tabFechas.Controls.Add(this.label11);
			this.tabFechas.Controls.Add(this.dtFechaEgreso);
			this.tabFechas.Controls.Add(this.label7);
			this.tabFechas.Location = new System.Drawing.Point(4, 22);
			this.tabFechas.Name = "tabFechas";
			this.tabFechas.Padding = new System.Windows.Forms.Padding(3);
			this.tabFechas.Size = new System.Drawing.Size(909, 369);
			this.tabFechas.TabIndex = 2;
			this.tabFechas.Text = "Fechas";
			this.tabFechas.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(119, 76);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 18;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(16, 75);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(79, 21);
			this.label11.TabIndex = 19;
			this.label11.Text = "Fecha Egreso";
			// 
			// tabStock
			// 
			this.tabStock.Controls.Add(this.button1);
			this.tabStock.Controls.Add(this.btnQuitarDuplicado);
			this.tabStock.Controls.Add(this.btnConsultar);
			this.tabStock.Controls.Add(this.gridStock);
			this.tabStock.Location = new System.Drawing.Point(4, 22);
			this.tabStock.Name = "tabStock";
			this.tabStock.Size = new System.Drawing.Size(909, 369);
			this.tabStock.TabIndex = 3;
			this.tabStock.Text = "Stock";
			this.tabStock.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(400, 18);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(103, 30);
			this.button1.TabIndex = 3;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnQuitarDuplicado
			// 
			this.btnQuitarDuplicado.Location = new System.Drawing.Point(185, 18);
			this.btnQuitarDuplicado.Name = "btnQuitarDuplicado";
			this.btnQuitarDuplicado.Size = new System.Drawing.Size(121, 23);
			this.btnQuitarDuplicado.TabIndex = 2;
			this.btnQuitarDuplicado.Text = "Quitar Duplicados";
			this.btnQuitarDuplicado.UseVisualStyleBackColor = true;
			this.btnQuitarDuplicado.Click += new System.EventHandler(this.BtnQuitarDuplicadoClick);
			// 
			// btnConsultar
			// 
			this.btnConsultar.Location = new System.Drawing.Point(55, 18);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(75, 23);
			this.btnConsultar.TabIndex = 1;
			this.btnConsultar.Text = "Consultar";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// gridStock
			// 
			this.gridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridStock.Location = new System.Drawing.Point(3, 61);
			this.gridStock.Name = "gridStock";
			this.gridStock.Size = new System.Drawing.Size(808, 290);
			this.gridStock.TabIndex = 0;
			// 
			// frmBaseDatosTraza
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 750);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.txtCantxcaja);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmBaseDatosTraza";
			this.Text = "BaseDatosTraza";
			this.Load += new System.EventHandler(this.BaseDatosTrazaLoad);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabProducto.ResumeLayout(false);
			this.tabProducto.PerformLayout();
			this.tabCliente.ResumeLayout(false);
			this.tabCliente.PerformLayout();
			this.tabFechas.ResumeLayout(false);
			this.tabStock.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridStock)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.ToolStripButton tlEditar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ToolStripButton tlAgregarMercaderia;
		private System.Windows.Forms.TabPage tabFechas;
		private System.Windows.Forms.TabPage tabCliente;
		private System.Windows.Forms.TabPage tabProducto;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TextBox txtCantxcaja;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton tlNuevos;
		private System.Windows.Forms.ComboBox cmbCliente;
		private System.Windows.Forms.Label lblCUIT;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label lblIDCliente;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cmbDescripcion;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtGLNDestino;
		private System.Windows.Forms.ToolStripButton tlNuevo;
		private System.Windows.Forms.DateTimePicker dtFechaEgreso;
		private System.Windows.Forms.TextBox txtSerieFinal;
		private System.Windows.Forms.TextBox txtSerieInicio;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNroRemito;
		private System.Windows.Forms.TextBox txtNroFactura;
		private System.Windows.Forms.TextBox txtLote;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.TabPage tabStock;
		private System.Windows.Forms.Button btnQuitarDuplicado;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.DataGridView gridStock;
		private System.Windows.Forms.Button button1;
	}
}
