namespace Contable.SENASA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.txtUser = new System.Windows.Forms.TextBox();
        	this.txtPass = new System.Windows.Forms.TextBox();
        	this.txtCufe = new System.Windows.Forms.TextBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.btnEnviarDatos = new System.Windows.Forms.Button();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label6 = new System.Windows.Forms.Label();
        	this.txtResultado = new System.Windows.Forms.TextBox();
        	this.txtErrores = new System.Windows.Forms.TextBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.txtTransaccion = new System.Windows.Forms.TextBox();
        	this.btnSalir = new System.Windows.Forms.Button();
        	this.btnLimpiar = new System.Windows.Forms.Button();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.BackColor = System.Drawing.Color.Transparent;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(73, 36);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(50, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Usuario";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.BackColor = System.Drawing.Color.Transparent;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(212, 36);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(71, 13);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "Contraseña";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.BackColor = System.Drawing.Color.Transparent;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(339, 36);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(33, 13);
        	this.label3.TabIndex = 2;
        	this.label3.Text = "Cufe";
        	// 
        	// txtUser
        	// 
        	this.txtUser.AcceptsTab = true;
        	this.txtUser.Location = new System.Drawing.Point(76, 57);
        	this.txtUser.MaxLength = 13;
        	this.txtUser.Name = "txtUser";
        	this.txtUser.Size = new System.Drawing.Size(104, 20);
        	this.txtUser.TabIndex = 1;
        	this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
        	// 
        	// txtPass
        	// 
        	this.txtPass.Location = new System.Drawing.Point(215, 57);
        	this.txtPass.MaxLength = 15;
        	this.txtPass.Name = "txtPass";
        	this.txtPass.Size = new System.Drawing.Size(102, 20);
        	this.txtPass.TabIndex = 2;
        	this.txtPass.UseSystemPasswordChar = true;
        	// 
        	// txtCufe
        	// 
        	this.txtCufe.Location = new System.Drawing.Point(342, 57);
        	this.txtCufe.MaxLength = 13;
        	this.txtCufe.Name = "txtCufe";
        	this.txtCufe.Size = new System.Drawing.Size(111, 20);
        	this.txtCufe.TabIndex = 3;
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.BackColor = System.Drawing.Color.Transparent;
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(104, 111);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(47, 13);
        	this.label4.TabIndex = 6;
        	this.label4.Text = "Evento";
        	// 
        	// comboBox1
        	// 
        	this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBox1.FormattingEnabled = true;
        	this.comboBox1.Items.AddRange(new object[] {
        	        	        	"VENTA"});
        	this.comboBox1.Location = new System.Drawing.Point(155, 106);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.Size = new System.Drawing.Size(242, 21);
        	this.comboBox1.TabIndex = 7;
        	
        	// 
        	// btnEnviarDatos
        	// 
        	this.btnEnviarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnEnviarDatos.Location = new System.Drawing.Point(170, 156);
        	this.btnEnviarDatos.Name = "btnEnviarDatos";
        	this.btnEnviarDatos.Size = new System.Drawing.Size(202, 32);
        	this.btnEnviarDatos.TabIndex = 8;
        	this.btnEnviarDatos.Text = "Enviar Datos";
        	this.btnEnviarDatos.UseVisualStyleBackColor = true;
        	this.btnEnviarDatos.Click += new System.EventHandler(this.btnEnviarDatos_Click);
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.BackColor = System.Drawing.Color.Transparent;
        	this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label5.Location = new System.Drawing.Point(33, 220);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(67, 13);
        	this.label5.TabIndex = 9;
        	this.label5.Text = "Respuesta";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.BackColor = System.Drawing.Color.Transparent;
        	this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label6.Location = new System.Drawing.Point(36, 265);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(64, 13);
        	this.label6.TabIndex = 10;
        	this.label6.Text = "Resultado";
        	// 
        	// txtResultado
        	// 
        	this.txtResultado.Location = new System.Drawing.Point(36, 236);
        	this.txtResultado.Name = "txtResultado";
        	this.txtResultado.Size = new System.Drawing.Size(81, 20);
        	this.txtResultado.TabIndex = 11;
        	// 
        	// txtErrores
        	// 
        	this.txtErrores.ForeColor = System.Drawing.Color.Black;
        	this.txtErrores.Location = new System.Drawing.Point(36, 281);
        	this.txtErrores.Multiline = true;
        	this.txtErrores.Name = "txtErrores";
        	this.txtErrores.ReadOnly = true;
        	this.txtErrores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.txtErrores.Size = new System.Drawing.Size(457, 108);
        	this.txtErrores.TabIndex = 12;
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.BackColor = System.Drawing.Color.Transparent;
        	this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label7.Location = new System.Drawing.Point(310, 220);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(180, 13);
        	this.label7.TabIndex = 15;
        	this.label7.Text = "Código de Transacción global:";
        	// 
        	// txtTransaccion
        	// 
        	this.txtTransaccion.Location = new System.Drawing.Point(313, 236);
        	this.txtTransaccion.Multiline = true;
        	this.txtTransaccion.Name = "txtTransaccion";
        	this.txtTransaccion.ReadOnly = true;
        	this.txtTransaccion.Size = new System.Drawing.Size(84, 22);
        	this.txtTransaccion.TabIndex = 14;
        	// 
        	// btnSalir
        	// 
        	this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnSalir.Location = new System.Drawing.Point(313, 439);
        	this.btnSalir.Name = "btnSalir";
        	this.btnSalir.Size = new System.Drawing.Size(107, 38);
        	this.btnSalir.TabIndex = 20;
        	this.btnSalir.Text = "Salir";
        	this.btnSalir.UseVisualStyleBackColor = true;
        	this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
        	// 
        	// btnLimpiar
        	// 
        	this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.btnLimpiar.Location = new System.Drawing.Point(107, 439);
        	this.btnLimpiar.Name = "btnLimpiar";
        	this.btnLimpiar.Size = new System.Drawing.Size(100, 38);
        	this.btnLimpiar.TabIndex = 21;
        	this.btnLimpiar.Text = "Limpiar";
        	this.btnLimpiar.UseVisualStyleBackColor = true;
        	this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
        	// 
        	// Form1
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackgroundImage = global::WebServiceTrazaSenasa.Properties.Resources.sedro3;
        	this.ClientSize = new System.Drawing.Size(533, 499);
        	this.Controls.Add(this.btnLimpiar);
        	this.Controls.Add(this.btnSalir);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.txtTransaccion);
        	this.Controls.Add(this.txtErrores);
        	this.Controls.Add(this.txtResultado);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.btnEnviarDatos);
        	this.Controls.Add(this.comboBox1);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.txtCufe);
        	this.Controls.Add(this.txtPass);
        	this.Controls.Add(this.txtUser);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "Form1";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Sistema Nacional de TRAZABILIDAD Fitosanitarios";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtCufe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEnviarDatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtErrores;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTransaccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

