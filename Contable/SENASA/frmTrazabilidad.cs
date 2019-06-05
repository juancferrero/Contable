/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 02/07/2014
 * Hora: 01:55 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using Contable.SENASA.Opercaciones;

using Contable.servicios.pami.org.ar;



namespace Contable.SENASA
{
	/// <summary>
	/// Description of Trazabilidad.
	/// </summary>
	public partial class Trazabilidad : Form
	{
		public Trazabilidad()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			//Add constructor code after the InitializeComponent() call.
			//
		}
		

		
		
		
		
		void TrazabilidadLoad(object sender, EventArgs e)
		{
		
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
#region Datos para la Consulta

			/*Armo una estructura con los datos para cosutar
			 */
			Operaciones.vpConsultaSENASA  datosConsulta = new Operaciones.vpConsultaSENASA();
			
			
			//Cargo los datos
			datosConsulta.IdTransaccion=""; //long
    		datosConsulta.IdEvento=""; //long
    		datosConsulta.GLNOrigen="";//7798181710001"; //long
    		datosConsulta.fechaTransDesde = Convert.ToDateTime("01/01/1900") ; //DateTime
    		datosConsulta.fechaTransHasta = DateTime.Today; //DateTime
    		datosConsulta.fechaOpeDesde = Convert.ToDateTime("01/01/1900") ; //DateTime
    		datosConsulta.fechaOpeHasta= DateTime.Today; //DateTime
    		datosConsulta.GLNInformador=""; //long
    		datosConsulta.IdTipoTransaccion=""; //long
    		datosConsulta.GTINElemento = "";//07798181710551";
    		datosConsulta.NroLote="";
    		datosConsulta.NroSerie="";
    		datosConsulta.NroRemitoFC="";
    		datosConsulta.estadoTransaccion ="";
			


#endregion
			
			 
			//Envia una operacion de consulta al SENASA
			transaccionSenasa[] trans = Contable.SENASA.Opercaciones.Operaciones.ConsultarDatosSENASA("7798195770008", "Ferrero9", datosConsulta );
			
			
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			//ServiciosCliente.Puerto();
		}
	}
}
