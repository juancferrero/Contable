/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 22/09/2016
 * Hora: 11:00 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using Contable.Modulos;

namespace Contable.Facturas
{
	/// <summary>
	/// Description of frmDocumentoFiscal.
	/// </summary>
	public partial class frmDocumentoFiscal : Form
	{
		
		internal VariablesPropias.VariablesPropias.vpFactura miFactura;
		internal VariablesPropias.VariablesPropias.vpMargenesFact miMargenes;

		internal VariablesPropias.VariablesPropias.vpRemito miRemito;
		internal  VariablesPropias.VariablesPropias.vpClientes clie;
		
		
		
		public frmDocumentoFiscal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
				
			
		}
		
		
		
		
		void FrmDocumentoFiscalLoad(object sender, EventArgs e)
		{
			//Coloca la Fecha
			dtFecha.Value = DateTime.Today;
				
								
			
			//Genera un datasource para pasarlo al combo
            cmbRazonSocial.DataSource = OperacionesComunes.FuenteObtenerClientes();
            cmbRazonSocial.DisplayMember = "Nombre";
			
			
			SubTicketAFIP();
			
			
		}
		
		
		
public void SubTicketAFIP()
		{
			//Dimensiono una variable propia (todas las vp... lo son)
			AFIP.AFIP.vpAFIPTicket TicketAccAFIP = new AFIP.AFIP.vpAFIPTicket();


			//Esta Function Obtiene un ticket de acceso a la AFIP
			TicketAccAFIP = AFIP.AFIP.TicketAccesoAFIP();

			//Aqui lo que se hace es pasar los datos del token y el sign para dos txt que estan en el formulario
			//La idea es sacar estas lineas pronto porque son obsoletas
			//30/5/13
			lblToken.Text = TicketAccAFIP.vpAFIPTicketToken;
			lblSign.Text = TicketAccAFIP.vpAFIPTicketSign;



/*
			//Cargo los datos del Ticket en una clase publica que esta en el MDI
			//de esta manera lo que hago es que este disponible para todo el proyecto
			//Cada vez que se use en una factura corroborará el ticket y de esta manera no hay que 
			//cerrar la ventana para hacer otra factura.
			//El ticket es algo importante por eso pienso que debe estar en el MDI para que sea de acceso
			//publico.
			//30/5/13
			MDIPrincipal.ClaseAFIP.ptAFIPTicketToken = TicketAccAFIP.vpAFIPTicketToken;
			MDIPrincipal.ClaseAFIP.ptAFIPTicketSign = TicketAccAFIP.vpAFIPTicketSign;
			MDIPrincipal.ClaseAFIP.ptAFIPTicketGenerationTime = TicketAccAFIP.vpAFIPTicketGenerationTime;
			MDIPrincipal.ClaseAFIP.ptAFIPTicketExpirationTime = TicketAccAFIP.vpAFIPTicketExpirationTime;
			MDIPrincipal.ClaseAFIP.ptAFIPTicketService = TicketAccAFIP.vpAFIPTicketService;
			MDIPrincipal.ClaseAFIP.ptAFIPTicketUniqueID = TicketAccAFIP.vpAFIPTicketUniqueID;

			My.MyProject.Forms.MDIPrincipal.ToolStripStatusEstadoServidor.Text = "SI";
*/
		}
		
		void CmbRazonSocialDropDown(object sender, EventArgs e)
		{
			//Solo muestra la columna de NOMBRE
			cmbRazonSocial.DisplayMember = "Nombre"; 
		}

		void CmbRazonSocialSelectedIndexChanged(object sender, EventArgs e)
		{
			//Carga los clientes
			CargarClientes();
			
			
			
		}


/// <summary>
/// Esta funcion coloca los datos en cada uno de los items del recibo
/// </summary>		
		public void CargarClientes()
		{
		
		
			//Cargo el cliente a la variable publica
			clie =  OperacionesComunes.ObtenerCliente(cmbRazonSocial.Text);
		
			lblIDCliente.Text = clie.strid;
			lblCUIT.Text = Convert.ToString (clie.dblCUIT);
			lblDireccion.Text  = clie.strDireccion;
			lblLocalidad.Text = clie.strLocalidad;				
			lblProvincia.Text = clie.strProvincia; 
		
		}	
		
		
	}
}
