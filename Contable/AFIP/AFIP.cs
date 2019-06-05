/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 23/02/2017
 * Hora: 10:21 a.m.
 * 
 * Este modulo sirve para obterner un ticket de la AFIP para la facturacion.
 */
using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Xml;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Runtime.InteropServices;

using System.Configuration; 
using System.Xml.Serialization;

namespace Contable.AFIP
{
	/// <summary>
	/// Description of AFIP.
	/// </summary>
	public class AFIP
	{
/// <summary>
/// 
/// </summary>
		public AFIP()
		{
		}
		
		

/// <summary>
/// Esta estructura es para contener toda la informacion que nos da el ticket de la AFIP
/// </summary>
		public struct vpAFIPTicket
		{
		
/// <summary>
/// Token del ticket
/// </summary>
			public string vpAFIPTicketToken;
/// <summary>
/// Firma del ticket
/// </summary>
			public string vpAFIPTicketSign;
/// <summary>
/// Fehca de generacion del ticket
/// </summary>
			public System.DateTime vpAFIPTicketGenerationTime;
/// <summary>
/// Fecha de expiracion del ticket
/// </summary>
			public System.DateTime vpAFIPTicketExpirationTime;
/// <summary>
/// Servicio al que accede el ticket
/// </summary>
			public string vpAFIPTicketService;
/// <summary>
/// Id del ticket
/// </summary>
			public double vpAFIPTicketUniqueID;
		}


/// <summary>
/// Obtiene un Ticket de Acceso para consumir WS
/// </summary>
/// <returns></returns>
		public static vpAFIPTicket TicketAccesoAFIP()
		{


#region VARIABLES
			vpAFIPTicket Ticket =  new vpAFIPTicket ();
   
	        string strUrlWsaaWsdl = "https://wsaa.afip.gov.ar/ws/services/LoginCms?WSDL";
	        string strIdServicioNegocio = "wsfe";
	        string strRutaCertSigner = 	ConfigurationManager.AppSettings["AFIPCertificadosRuta"]+
	        							ConfigurationManager.AppSettings["AFIPCertificadosCert"];			
	        //string strRutaCertSigner = "C:\\OpenSSL-Win32\\bin\\2017alias.pfx" ; //TODO: poner en donde esta el certificado
	        string clave = "AF";
	        SecureString strPasswordSecureString = new SecureString();
			
	        //Setea a Nulo
		    LoginTicket objTicketRespuesta = null;
		    string strTicketRespuesta = null;

#endregion
			
        

        
			//Esto hace la clave del certificado
            foreach (char c in clave) strPasswordSecureString.AppendChar(c);
            strPasswordSecureString.MakeReadOnly();
		
            

        try
        {
  
            objTicketRespuesta = new LoginTicket();
  
            strTicketRespuesta = objTicketRespuesta.ObtenerLoginTicketResponse(strIdServicioNegocio, 
                                                                               strUrlWsaaWsdl, 
                                                                               strRutaCertSigner, 
                                                                               strPasswordSecureString);
            
            
          MessageBox.Show ("***CONTENIDO DEL TICKET RESPUESTA:" + Environment.NewLine +
                             "   Token:" + objTicketRespuesta.Token + Environment.NewLine +
                             "   Sign:" + objTicketRespuesta.Sign + Environment.NewLine + 
                             "   GenerationTime:" + Convert.ToString(objTicketRespuesta.GenerationTime) + Environment.NewLine + 
                             "   ExpirationTime:" + Convert.ToString(objTicketRespuesta.ExpirationTime) + Environment.NewLine +
                             "   Service:" + objTicketRespuesta.Service + Environment.NewLine +
                             "   UniqueID:" + Convert.ToString(objTicketRespuesta.UniqueId));

			Ticket.vpAFIPTicketSign = objTicketRespuesta.Sign;
			Ticket.vpAFIPTicketToken = objTicketRespuesta.Token;
			Ticket.vpAFIPTicketGenerationTime = objTicketRespuesta.GenerationTime;
			Ticket.vpAFIPTicketExpirationTime = objTicketRespuesta.ExpirationTime;
			Ticket.vpAFIPTicketService = objTicketRespuesta.Service;
			Ticket.vpAFIPTicketUniqueID = objTicketRespuesta.UniqueId;
            
        }
        catch (Exception excepcionAlObtenerTicket)
        {
            MessageBox.Show ("***EXCEPCION AL OBTENER TICKET: " + excepcionAlObtenerTicket.Message);
           
        }
       
        
        
        //HASTA ACA EL EL TEMA DEL TICKET 

			
			//LO QUE SIGUE TENDRIA QUE IR EN OTRA FUNCION



			//12/06/2012 La AFIP retiro unilateralmente la posibilidad de obtener el Tipo de Cambio
			//frmDocFiscal3.lblDolar.Text = CotizacionDivisa("DOL", Ticket.vpAFIPTicketToken, Ticket.vpAFIPTicketSign)
			//frmDocFiscal3.lblDolar.Text = CotizacionDivisa("PES", Ticket.vpAFIPTicketToken, Ticket.vpAFIPTicketSign)



			//Facturacion Electronica Requerimiento de Autorizacion
			servicios1.afip.gov.ar.FEAuthRequest objFEAuthRequest = new servicios1.afip.gov.ar.FEAuthRequest();



			
			objFEAuthRequest.Cuit = Convert.ToInt64("30708466200");
			//este es el CUIT guardado en la compu
			objFEAuthRequest.Token = Ticket.vpAFIPTicketToken;
			objFEAuthRequest.Sign = Ticket.vpAFIPTicketSign;





			//ESTO ES DEL TICKET PARA GUARDARLO EN EL DISCO

			// Obtengo los XML de request/response y los escribo en el disco
			XmlSerializer writer1 = new XmlSerializer(typeof(servicios1.afip.gov.ar.FEAuthRequest));
			StreamWriter file1 = new StreamWriter("C:\\" + 	Convert.ToString(objTicketRespuesta.Service) + " - " + 
			                                      			Convert.ToString(objTicketRespuesta.UniqueId) + " - " + 
			                                      			Ticket.vpAFIPTicketExpirationTime.ToString().Replace("/", "-").ToString().Replace( ":", "=") + ".xml");
			writer1.Serialize(file1, objFEAuthRequest);
			file1.Close();


			return Ticket;
        
        
        
        
        
    }

   
/// <summary>
/// Busca el Ultimo comprobante
/// </summary>
/// <param name="strToken">Paso el Token</param>
/// <param name="strFirma"> Paso la Firma</param>
/// <param name="intPtoVenta">Paso el punto de venta</param>
/// <param name="intTipoCbe">Paso el tipo de comprobante</param>
/// <returns></returns>
		public static int UltimoComprobante(string strToken, string strFirma, int intPtoVenta, int intTipoCbe)
		{

			//Esto recupera el ultimo comprobante realizado

			//Crea el objeto para Recuperar el ultimo combrobante
			servicios1.afip.gov.ar.FERecuperaLastCbteResponse objFERecuperarLastCbte = null;


			//web service de Facturacion Electronica
			servicios1.afip.gov.ar.Service objWSFE = new servicios1.afip.gov.ar.Service();

			//Facturacion Electronica Requerimiento de Autorizacion
			servicios1.afip.gov.ar.FEAuthRequest objFEAuthRequest = new servicios1.afip.gov.ar.FEAuthRequest();


			//Este es el CUIT guardado en el registro del sistema.
			objFEAuthRequest.Cuit = Convert.ToInt64 ("30708466200");
			objFEAuthRequest.Token = strToken;
			objFEAuthRequest.Sign = strFirma;

			// Invoco al método FECompUltimoAutorizado
			try {
				objFERecuperarLastCbte = objWSFE.FECompUltimoAutorizado(objFEAuthRequest,intPtoVenta,intTipoCbe);
				return Convert.ToInt32(objFERecuperarLastCbte.CbteNro.ToString()) + 1;

			} catch (Exception ex) {
				MessageBox.Show(ex.Message);

				//Devuelve 0
				return 0;
			}
		}
		
		
		
		
/// <summary>
/// Obtiene la cotizacion de la divisa solicitada. En valores de divisa no de billete
/// </summary>
/// <param name="strIdMoneda"></param>
/// <param name="strToken"></param>
/// <param name="strFirma"></param>
/// <returns>El valor de la moneda en texto</returns>
public static string CotizacionDivisa(string strIdMoneda, string strToken, string strFirma)
		{
			//Dimensiono la variable para obtener la respuesta de la cotizacion.
			servicios1.afip.gov.ar.FECotizacionResponse objFEParamCotizacionResponse ;

			//web service de Facturacion Electronica
			servicios1.afip.gov.ar.Service objWSFE = new servicios1.afip.gov.ar.Service();

			//Facturacion Electronica Requerimiento de Autorizacion
			servicios1.afip.gov.ar.FEAuthRequest objFEAuthRequest = new servicios1.afip.gov.ar.FEAuthRequest();


			//Este es el CUIT guardado en el registro del sistema.
			objFEAuthRequest.Cuit = Convert.ToInt64 ("30708466200");//TODO:Luego ponerlo en las opciones del sistema 
			objFEAuthRequest.Token = strToken;
			objFEAuthRequest.Sign = strFirma;


			// Invoco al método FEParamGetCotizacion
			try {
				objFEParamCotizacionResponse = objWSFE.FEParamGetCotizacion(objFEAuthRequest, strIdMoneda);

				return objFEParamCotizacionResponse.ResultGet.MonCotiz.ToString();

			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
				//Si no encuentra la cotizacion devuelve vacio
				return "1";


			}

		}
		

		
		
/// <summary>
/// 
/// </summary>
/// <param name="strToken"></param>
/// <param name="strFirma"></param>
/// <param name="lngNumCbte"></param>
/// <returns></returns>
		public static servicios1.afip.gov.ar.FECompConsultaResponse ComprobantesAutorizados(string strToken, string strFirma, long lngNumCbte)
		{

			//Esto recupera el ultimo comprobante realizado

			//Crea el objeto para Recuperar el ultimo combrobante
			servicios1.afip.gov.ar.FECompConsultaReq objFERecuperarCbtesReq = new servicios1.afip.gov.ar.FECompConsultaReq();
			servicios1.afip.gov.ar.FECompConsultaResponse objFERecuperarCbtesResp = new servicios1.afip.gov.ar.FECompConsultaResponse();

			//web service de Facturacion Electronica
			servicios1.afip.gov.ar.Service objWSFE = new servicios1.afip.gov.ar.Service();

			//Facturacion Electronica Requerimiento de Autorizacion
			servicios1.afip.gov.ar.FEAuthRequest objFEAuthRequest = new servicios1.afip.gov.ar.FEAuthRequest();


			//Este es el CUIT guardado en el registro del sistema.
			objFEAuthRequest.Cuit = Convert.ToInt64 ("30708466200");
			objFEAuthRequest.Token = strToken;
			objFEAuthRequest.Sign = strFirma;

			objFERecuperarCbtesReq.PtoVta = 3;
			objFERecuperarCbtesReq.CbteTipo = 1;
			objFERecuperarCbtesReq.CbteNro = lngNumCbte;


			// Invoco al método FECompConsultaResponse
			try {
				objFERecuperarCbtesResp = objWSFE.FECompConsultar(objFEAuthRequest, objFERecuperarCbtesReq);
				return objFERecuperarCbtesResp;


			} catch (Exception ex) {
				MessageBox.Show(ex.Message);

				//Devuelve 0
				return null;
			}
		}

/// <summary>
/// Genera la fecha con formato EEUU
/// </summary>
/// <returns></returns>
		public static string FechaInversa( DateTime fecha)
		{
			//Dimensiono las variables
			string Dia = null;
			string Mes = null;
			string Ano = null;

			//Esto establece la fecha como la del sistema

			//Carga el Año
			Ano = fecha.Year.ToString();

			//Carga el Mes
			if (fecha.Month < 10) {
				Mes = "0" +fecha.Month.ToString();
			} else {
				Mes = fecha.Month.ToString();
			}

			//Carga el Dia
			if (fecha.Day < 10) {
				Dia = "0" + fecha.Day.ToString();
			} else {
				Dia = fecha.Day.ToString();
			}


			//Devuelve el dato como la fecha invertida 
			return Ano + Mes + Dia;

		}

		
/// <summary>
/// Envia una Factura a la AFIP
/// </summary>
/// <param name="Factura"></param>
/// <param name="strToken"></param>
/// <param name="strSign"></param>
/// <returns></returns>
		public static servicios1.afip.gov.ar.FECAEResponse EnviarFacturaAFIP(VariablesPropias.VariablesPropias.vpFactura Factura, string strToken, string strSign)
		{
			//web service de Facturacion Electronica
			servicios1.afip.gov.ar.Service objWSFE = new servicios1.afip.gov.ar.Service();



			//Crea el objeto de respuesta de la factura
			servicios1.afip.gov.ar.FECAEResponse objFECAEResponse = new servicios1.afip.gov.ar.FECAEResponse();

			servicios1.afip.gov.ar.FECAEDetResponse objFECAEDetResponse = new servicios1.afip.gov.ar.FECAEDetResponse();



			//Crea el objeto para Armar la factura
			//Request General
			servicios1.afip.gov.ar.FECAERequest objFECAERequest = new servicios1.afip.gov.ar.FECAERequest();

			//Request de la Cabecera
			servicios1.afip.gov.ar.FECAECabRequest objFECAECabRequest = new servicios1.afip.gov.ar.FECAECabRequest();

			//Request del Detalle
			int indice = 0;
			//Cantidad de documentos a enviar
			int indIVA = 0;
			servicios1.afip.gov.ar.FECAEDetRequest[] objFECAEDetRequestArray = new servicios1.afip.gov.ar.FECAEDetRequest[indice + 1];
			servicios1.afip.gov.ar.FECAEDetRequest objFECAEDetRequest = new servicios1.afip.gov.ar.FECAEDetRequest();
			servicios1.afip.gov.ar.AlicIva[] objFECAEDetIVAArray = new servicios1.afip.gov.ar.AlicIva[indIVA + 1];

			servicios1.afip.gov.ar.AlicIva objFECAEDetIVA = new servicios1.afip.gov.ar.AlicIva();


			//Armar la Cabecera de la factura
			int cantregistros = 1;
			var _with1 = objFECAECabRequest;
			_with1.CantReg = cantregistros;
			_with1.PtoVta = Convert.ToInt32(Factura.intSucursal);
			_with1.CbteTipo = Convert.ToInt32(Factura.strCodFc);


			var _with2 = objFECAEDetIVA;
			
			/*
			 El Id tiene varios tipos
			 0% = 3
			 10,5% = ??
			 21% = 5
			 
			 */
			_with2.Id = Factura.IdIVA;
			

			_with2.BaseImp = Convert.ToDouble(Factura.curSubTotal);
			_with2.Importe = Convert.ToDouble(Factura.curIVA);



			objFECAEDetIVAArray[0] = objFECAEDetIVA;



			//Armar el detalle de la factura
			var _with3 = objFECAEDetRequest;
			//este es el Request para la unica factura
			//Ingreso los datos del cliente
			_with3.Concepto = 1;
			// Esto es productos
			_with3.DocTipo = 80;
			// Esto es Cuit
			_with3.DocNro = Convert.ToInt64(Factura.Cliente.dblCUIT);
			// El CUIT del cliente

			//.CbteDesde = CLng(cmbSucursal.Text & "-" & txtNumFact.Text)
			_with3.CbteDesde = Convert.ToInt64(Factura.dblNumFact);
			//.CbteHasta = CLng(cmbSucursal.Text & "-" & txtNumFact.Text)
			_with3.CbteHasta = Convert.ToInt64(Factura.dblNumFact);

			//.ImpTotal = CDbl(lblTotalUSD.Text)
			_with3.ImpTotal = Convert.ToDouble(Factura.curTotal);
			_with3.ImpTotConc = 0;
			//No se que es
			//.ImpNeto = CDbl(lblSubtotalUSD.Text)
			_with3.ImpNeto = Convert.ToDouble(Factura.curSubTotal);
			_with3.ImpOpEx = 0;
			//.ImpIVA = CDbl(lblIvaUSD.Text)
			_with3.ImpIVA = Convert.ToDouble(Factura.curIVA);
			_with3.ImpTrib = _with3.ImpTotConc + _with3.ImpOpEx;
			//+ .ImpIVA

			//.MonId = "DOL"
			//.MonCotiz = CDbl(FormatNumber(lblDolar.Text, 6))

			_with3.MonId = "PES";
			_with3.MonCotiz = Convert.ToDouble("1");


		
			//Utiliza la funcion de FechaInversa para darle el formato correcto 
			_with3.CbteFch = FechaInversa(DateTime.Today);

			_with3.Iva = objFECAEDetIVAArray;
			//.Iva = CDbl(lblIvaUSD.Text)

			objFECAEDetRequestArray[0] = objFECAEDetRequest;
			// Carga el Request en un array (de un solo item)



			//Arma el Request para todas las facturas que se manden
			var _with4 = objFECAERequest;
			//Cabecera
			_with4.FeCabReq = objFECAECabRequest;

			//Cuerpo
			_with4.FeDetReq = objFECAEDetRequestArray;



			//Facturacion Electronica Requerimiento de Autorizacion
			servicios1.afip.gov.ar.FEAuthRequest objFEAuthRequest = new servicios1.afip.gov.ar.FEAuthRequest();


			objFEAuthRequest.Cuit = Convert.ToInt64 ("30708466200");//TODO Cambiar
			//este es el CUIT guardado en la compu
			objFEAuthRequest.Token = strToken;
			objFEAuthRequest.Sign = strSign;



			// Invoco al método FECAESolicitar
			try {
				objFECAEResponse = objWSFE.FECAESolicitar(objFEAuthRequest, objFECAERequest);


				MessageBox.Show ("***CONTENIDO DE RESPUESTA:" + 
				                 System.Environment.NewLine + 
				                 "   CUIT:" + Convert.ToString(objFECAEResponse.FeCabResp.Cuit) + 
				                 System.Environment.NewLine + 
				                 "   Pto Vta:" + Convert.ToString(objFECAEResponse.FeCabResp.PtoVta) + 
				                 System.Environment.NewLine + 
				                 "   Fch Proceso:" + objFECAEResponse.FeCabResp.FchProceso + 
				                 System.Environment.NewLine + 
				                 "   Cant reg:" + Convert.ToString(objFECAEResponse.FeCabResp.CantReg) + 
				                 System.Environment.NewLine + 
				                 "   Resultado:" + objFECAEResponse.FeCabResp.Resultado +
				                 System.Environment.NewLine + 
				                 "   Reproceso:" + objFECAEResponse.FeCabResp.Reproceso + 
				                 System.Environment.NewLine);



			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
				return objFECAEResponse;
			}



			// Obtengo los XML de request/response y los escribo en el disco
			XmlSerializer writer1 = new XmlSerializer(typeof(servicios1.afip.gov.ar.FECAERequest));
			StreamWriter file1 = new StreamWriter("C:\\" + Factura.intSucursal + "-" + Factura.dblNumFact + " - " + Factura.Cliente.strNombre + " - wsfe_FERequest.xml");
			writer1.Serialize(file1, objFECAERequest);
			file1.Close();
			
			XmlSerializer writer2 = new XmlSerializer(typeof(servicios1.afip.gov.ar.FECAEResponse));
			StreamWriter file2 = new StreamWriter("C:\\" + Factura.intSucursal + "-" + Factura.dblNumFact + " - " + Factura.Cliente.strNombre + " - wsfe_FEResponse.xml");
			writer2.Serialize(file2, objFECAEResponse);
			file2.Close();


			return objFECAEResponse;


		}


		
		
		
		//public static servicios1.afip.gov.ar.MonedaResponse Moneda (string strToken, string strFirma)
		//{
		//Va como consultar las monedas disponibles.
		//}
		
}
		
	}
	
	
	
	
	
	
	
	
	
	

