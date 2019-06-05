/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 25/01/2017
 * Hora: 12:30 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

using System.Configuration;

using ConexionDB;



namespace Contable.SENASA
{
	/// <summary>
	/// Description of frmTrazabilidadIcona.
	/// </summary>
	public partial class frmTrazabilidadIcona : Form
	{
		
		/// <summary>
		/// Esta parte del programa permite ingresar los productos de otro GTIN y convertirlos a los
		/// de la empresa.
		/// Tiene dos formas una de forma automatica y la otra manual
		/// Tambien tiene la posibilidad de configurar los tiempos y las formas de guardar los codigos. 
		/// </summary>
		public frmTrazabilidadIcona()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Timer1Tick(object sender, EventArgs e)
		{
			//El intervalo lo tengo que colocar en el tick
			timer1.Interval = Convert.ToInt32(txtTiempoRetardo.Text); // 3000; //3 seg.
			
			//funcion para guardar el codigo en la base de datos
			GuardarSoloCodigoIcona("");
			//btnCargar.PerformClick(); //Hace el click del boton//
			
			SystemSounds.Beep.Play(); //Hace sonar un ding para saber que se coloco bien//
		
			
		}
		void FrmTrazabilidadIconaLoad(object sender, EventArgs e)
		{
			textBox1.Focus();
		}
		void Button1Click(object sender, EventArgs e)
		{
			timer1.Start();
			
		}
	
		void BtnPararClick(object sender, EventArgs e)
		{
			timer1.Stop();
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			timer1.Stop();
			if (textBox1.TextLength == 56) {
				timer1.Start();
				
			}
		}
		
		/// <summary>
		/// Esta funcion permite guardar el codigo en la base de datos directamente
		/// </summary>
		/// <param name="strCodigo"></param>
		void GuardarSoloCodigoIcona (string strCodigo)
		{
		
		if (textBox1.Text != "" ) {
			
			
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseTrazabilidadICONA"].ToString());
			
			try
			 {
							//Guardo los datos dentro de la tabla
			ConexionAccess2007.InsertarFila("Icona", 
			                                "CodigoIcona, Fecha, " + 
			                                "TipoProducto", 
			                                "'" +  textBox1.Text.Trim() + "', "+
											"'" + DateTime.Today.ToShortDateString() + "', " +
											"'Lata Fosfuro pastillas x 480'",false );

									
			}
			catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
			
			//Cerrar la conexion
            ConexionAccess2007.Desconectar();
            
	
            //Borro el texto para volver a cargarlo
             textBox1.Text = "";
            
	}
		
		}
		void TlbGuardarClick(object sender, EventArgs e)
		{
			//funcion para guardar el codigo en la base de datos
			GuardarSoloCodigoIcona("");
		}
		
	}
}
