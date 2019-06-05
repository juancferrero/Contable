/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 03/01/2017
 * Hora: 11:55 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Contable.MigrarDB;
using Contable.AFIP;
using Contable.Modulos;

using ImprimirEjemplo;


namespace Contable.Pruebas
{
	/// <summary>
	/// Description of frmPruebas.
	/// </summary>
	public partial class frmPruebas : Form
	{
		
		
		
		public frmPruebas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MigrarDB.MigrarDB.MigrarCheques(textBox1.Text,textBox2.Text );
		}
		void Button3Click(object sender, EventArgs e)
		{
			MessageBox.Show ( AFIP.AFIP.UltimoComprobante (lblToken.Text, lblSign.Text, 3, 1).ToString());
		}
		void FrmPruebasLoad(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			AFIP.AFIP.vpAFIPTicket Ticket = new AFIP.AFIP.vpAFIPTicket();
			
			Ticket = AFIP.AFIP.TicketAccesoAFIP();
			
			lblSign.Text = Ticket.vpAFIPTicketSign;
			lblToken.Text = Ticket.vpAFIPTicketToken;
		}
		void Button4Click(object sender, EventArgs e)
		{
			
			lblCAE.Text = AFIP.AFIP.ComprobantesAutorizados(lblToken.Text, lblSign.Text,Convert.ToInt64(txtNumFact.Text)).ResultGet.CodAutorizacion;
			
			MessageBox.Show(AFIP.AFIP.ComprobantesAutorizados(lblToken.Text, lblSign.Text,Convert.ToInt64(txtNumFact.Text)).ResultGet.CodAutorizacion + Environment.NewLine  +
			                AFIP.AFIP.ComprobantesAutorizados(lblToken.Text, lblSign.Text,Convert.ToInt64(txtNumFact.Text)).ResultGet.DocNro.ToString()+ Environment.NewLine  +
			                AFIP.AFIP.ComprobantesAutorizados(lblToken.Text, lblSign.Text,Convert.ToInt64(txtNumFact.Text)).ResultGet.ImpNeto + Environment.NewLine  +
			                AFIP.AFIP.ComprobantesAutorizados(lblToken.Text, lblSign.Text,Convert.ToInt64(txtNumFact.Text)).ResultGet.ImpIVA + Environment.NewLine  +
			                AFIP.AFIP.ComprobantesAutorizados(lblToken.Text, lblSign.Text,Convert.ToInt64(txtNumFact.Text)).ResultGet.ImpTotal + Environment.NewLine  +
			                AFIP.AFIP.ComprobantesAutorizados(lblToken.Text, lblSign.Text,Convert.ToInt64(txtNumFact.Text)).ResultGet.CbteFch, "Datos de comprobante");
		}
		void Button5Click(object sender, EventArgs e)
		{
	
			VariablesPropias.VariablesPropias.vpRecibo reci = new VariablesPropias.VariablesPropias.vpRecibo();
				
			reci= Modulos.Recibos.CargarRecibo(Convert.ToInt32 (txtNumRecibo.Text));
			
			// MessageBox.Show (reci.Cliente.strDireccion);
			Imprimir.Imprimir_Recibo(reci);
			
		}
		void Button6Click(object sender, EventArgs e)
		{
			VariablesPropias.VariablesPropias.vpFactura  reci = new VariablesPropias.VariablesPropias.vpFactura();
				
			reci= Modulos.Documentos_Fiscales.CargarFCA(Convert.ToInt32 (txtNumFactura.Text));
			
			// MessageBox.Show (reci.Cliente.strDireccion);
			Imprimir.Imprimir_Factura(reci);
		}
		void Button7Click(object sender, EventArgs e)
		{
			MigrarDB.MigrarDB.ModificarReciboImprimible();
		}
		void Button8Click(object sender, EventArgs e)
		{
	
		}
		void BtnImprimirReciboClick(object sender, EventArgs e)
		{
	
		}
	}
}
