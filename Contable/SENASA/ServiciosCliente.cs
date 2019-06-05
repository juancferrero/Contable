/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 10/10/2017
 * Hora: 10:02 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 

//using WsConnector;


using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Security.Tokens;
using System.Xml;

using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Web.Services.Description;


using Contable.servicios.pami.org.ar;

namespace Contable.SENASA
{
	/// <summary>
	/// Description of ServiciosCliente.
	/// </summary>
	public class ServiciosCliente
	{
		public ServiciosCliente()
		{
		}
		
		
		  
		public static System.Web.Services.Description.PortType Senasaport(System.Web.Services.Description.PortType Puertito )
		{
		
			MessageBox.Show (Puertito.Name);
			 	
			return Puertito;
			
		}
		
		
		public static void Puerto()
   {
      try
      {
         PortTypeCollection myPortTypeCollection;
         System.Web.Services.Description.ServiceDescription myServiceDescription = System.Web.Services.Description.ServiceDescription.Read("IWebServiceSenasa.wsdl");

         myPortTypeCollection = myServiceDescription.PortTypes;
         int noOfPortTypes = myServiceDescription.PortTypes.Count;
         MessageBox.Show ("\nTotal number of PortTypes : "
            + noOfPortTypes);
		
         MessageBox.Show (myPortTypeCollection[0].Name);
         MessageBox.Show (Senasaport( myPortTypeCollection[0]).Name);
         
                  
         //PortType myPortType = myPortTypeCollection["MathServiceSoap"];
         
      }
      catch(Exception e)
      {
           MessageBox.Show ("Exception: " + e.Message);
      }
   }
		
		
		
/// <summary>
/// Esta funcion lo que hace es enviar una transaccion a SENASA
/// </summary>
/// <param name="transacciones">Array de las transacciones a enviar</param>
/// <param name="usr">Usuario</param>
/// <param name="pass">Contraseña</param>
/// <returns>Devuelve un resultado</returns>
		/*public webServiceResult sendTransaccion (transaccionSenasaDTO[] transacciones, string usr, string pass)
		{
			IWebServiceSenasa cliente = new IWebServiceSenasa();
			
			
			
			
		}*/
 		
		
		
		
		
		/*public static void Usuario()
		{
			
			
			
			
			 
			
			
			IWebServiceSenasa juanito = new IWebServiceSenasa();
			
			
			juanito.Url = "https://servicios.pami.org.ar/trazaagr.WebService";
			//juanito.Discover();
			//juanito.UseDefaultCredentials = true;
			
			
			/*
			credenciales.Password = "testwservicepsw";
			credenciales.UserName = "testwservice";*/
			
			
			/*juanito.Credentials  = 
						
			juanito.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap11;
			
			resultadoTransaccionSenasaPaginadoWS pepito = juanito.getTransacciones("7798195770008", "Ferrero9","" ,"" ,"" 
			                                                                       ,"","","","","","","","","","","");
			
			
			MessageBox.Show(pepito.cantPaginas.ToString());
			
			//webServiceResult pepito ;
			//pepito.resultado.ToString();
		}
		
		
		/*
		private IWebServiceSenasa cliente()
		{
		CustomBinding customBinding = (CustomBinding)CreateMultiFactorAuthenticationBinding();

            EndpointAddress endpointAddress = new EndpointAddress("https://servicios.pami.org.ar/trazaagr.WebService");
            
           
            IWebServiceSenasaPortType proxy = ChannelFactory<IWebServiceSenasaPortType>.CreateChannel(customBinding, endpointAddress);
            ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(customXertificateValidation);
            ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Ssl3;
            
            ChannelFactory _bankChannel = new ChannelFactory<IWebServiceSenasaPortType>(customBinding, this.EndPointAddr);
        
     
            ChannelFactory<IWebServiceSenasaPortType> channelFactory = null;
            IWebServiceSenasaPortType client = null;
           
            channelFactory = new ChannelFactory<IWebServiceSenasaPortType>(customBinding, endpointAddress);
            channelFactory.Credentials.UserName.UserName = this.WsUser;
            channelFactory.Credentials.UserName.Password = this.WsPass;
          
            client = channelFactory.CreateChannel();
            
            return client;
		}
*/		
		public static System.ServiceModel.Channels.Binding CreateMultiFactorAuthenticationBinding()
        {
            HttpsTransportBindingElement httpTransport = new HttpsTransportBindingElement();
            httpTransport.MaxReceivedMessageSize = int.MaxValue;
            

            //AddressHeader addressHeader = AddressHeader.CreateAddressHeader("Security", "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd", security, xmlObjectSerializer);
            

            CustomBinding binding = new CustomBinding();
            binding.Name = "myCustomBinding";
           
            TransportSecurityBindingElement messageSecurity = TransportSecurityBindingElement.CreateUserNameOverTransportBindingElement();
            messageSecurity.IncludeTimestamp = false;
            
            messageSecurity.MessageSecurityVersion = MessageSecurityVersion.WSSecurity11WSTrust13WSSecureConversation13WSSecurityPolicy12;
            messageSecurity.SecurityHeaderLayout = SecurityHeaderLayout.Strict;
            messageSecurity.SetKeyDerivation(false);
            TextMessageEncodingBindingElement Quota = new TextMessageEncodingBindingElement(MessageVersion.Soap11, System.Text.Encoding.UTF8);
            Quota.ReaderQuotas.MaxDepth = 32;
            Quota.ReaderQuotas.MaxStringContentLength = Int32.MaxValue;
            Quota.ReaderQuotas.MaxArrayLength = 16384;
            Quota.ReaderQuotas.MaxBytesPerRead = 4096;
            Quota.ReaderQuotas.MaxNameTableCharCount = 16384;
            
            
            binding.Elements.Add(Quota);
            binding.Elements.Add(messageSecurity);
            binding.Elements.Add(httpTransport);
            return binding;
        }

        private static bool customXertificateValidation(object sender, X509Certificate cert, X509Chain chain, System.Net.Security.SslPolicyErrors error)
        {
            if (true)
            {
                return true;
            }
        }


		
		
		
	}
	
	
	
	
	
}
