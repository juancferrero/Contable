using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Security.Tokens;
using System.Text;
using System.Xml;
using Contable.Modulos;
using System.Windows.Forms;

using Contable.servicios.pami.org.ar;
using Contable.SENASA.Opercaciones;

namespace Contable.SENASA
{[MessageContract]
    public class ServiceClient
    {

        private string EndPointAddr = "https://servicios.pami.org.ar/trazaagr.WebService";
        private string WsUser = "";
        private string WsPass = "";


        public ServiceClient(string WsUser, string WsPass)
        {
            this.WsUser = WsUser;
            this.WsPass = WsPass;
            
        }
        
        
#region A desarrollar

        
        public saveTransaccionesResponse SendTransaccion(transaccionSenasaDTO[] transacciones, string usr, string pass)
        {
            
        	//Esto carga un nuevo cliente para el web service
        	IWebServiceSenasaPortType client = GetClient();
            
        	
        	try
            {
                //Crea el request para enviar a trazabilidad
        		saveTransacciones request = new saveTransacciones(transacciones, usr, pass);
                
        		
        		
        		//Escribe un XML en el disco con los datos del request    
                Contable.Modulos.Escribir_XML.EscribirTicketSenasaRequest(request);
                
                //Envia la transaccion y guarda la respuesta
        		saveTransaccionesResponse response = client.saveTransacciones(request);
                 
        		//Escribe un XML en el disco con los datos del request
                Contable.Modulos.Escribir_XML.EscribirTicketSenasaResponse (response);
                
        		return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /*public sendCancelaTransacResponse SendCancelacTransac(long idTransaccion, string usr, string pass)
        {
            IWebServiceSDRNPortType client = GetClient();

            try
            {
                sendCancelaTransac request = new sendCancelaTransac(idTransaccion, usr, pass);
                sendCancelaTransacResponse response = client.sendCancelaTransac(request);    //.sendCancelacTransacc(request);)
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        */
       
#endregion


#region Desarrolladas


/// <summary>
/// Confirma las transacciones pendientes
/// </summary>
/// <param name="usr">Usuario del sistema</param>
/// <param name="pass">Password del sistema</param>
/// <param name="transacciones">Un array de la estructura de confirma transacciones</param>
/// <returns></returns>
       public sendConfirmaTransaccResponse SendConfirmaTransac(string usr, string pass, confirmacionTransaccionSenasaDTO[] transacciones)
        {
	       

	       	//para cargar los proxis del sistema y no los de SENASA
	       	//UsaProxyDelSistema();
	       	
	       	//Esto carga un nuevo cliente para el web service    
	       	IWebServiceSenasaPortType client = GetClient();
	       	
	     			
	       	
            try
            {
                //Crea el request para enviar a trazabilidad
            	sendConfirmaTransacc request = new sendConfirmaTransacc(usr, pass, transacciones);
                
                  
           		//Escribe un XML en el disco con los datos del request    
                Contable.Modulos.Escribir_XML.EscribirTicketSenasaRequest(request);
                
                //Envia la transaccion y guarda la respuesta
                sendConfirmaTransaccResponse response = client.sendConfirmaTransacc(request);  
             	
                //Escribe un XML en el disco con los datos del request
                Contable.Modulos.Escribir_XML.EscribirTicketSenasaResponse (response);
                
                return response;
            }
            catch (Exception e)
            {
            	MessageBox.Show( e.Message);
            	throw e;
            }
        }
        
       
/// <summary>
/// Obtiene las transacciones pendientes de aceptacion.
/// </summary>
/// <param name="usser">Usuario del sistema</param>
/// <param name="pass">Password del sistema</param>
/// <param name="consulta">Estrucutra con los datos de la consulta</param>
/// <returns>Devuelve un array con los productos no aceptrados aun</returns>
        public getTransaccionesResponse GetTransacciones(string usser, 
                                                        string pass, 
                                                        Operaciones.vpConsultaSENASA consulta) 
        {
            
       	//Esto carga un nuevo cliente para el web service 
       	IWebServiceSenasaPortType client = GetClient();

            try
            {
                getTransacciones request = new getTransacciones(usser, 
                                                        pass, 
                                                        
                                                        consulta.IdTransaccion,//JCF
                                                        consulta.IdEvento,//JCF
                                                        consulta.GLNOrigen,
                                                        consulta.fechaTransDesde.ToShortDateString(),//JCF
														consulta.fechaTransHasta.ToShortDateString(),//JCF
                                                        consulta.fechaOpeDesde.ToShortDateString(),
                                                        consulta.fechaOpeHasta.ToShortDateString(), 
                                                        consulta.GLNInformador,
                                                       	consulta.IdTipoTransaccion,//JCF
                                                        consulta.GTINElemento,//JCF
                                                        consulta.NroLote,
                                                        consulta.NroSerie,
                                                        consulta.NroRemitoFC,
                                                        consulta.estadoTransaccion);
                
            	
            	//Carga en la respuesta el resultado del getTransacciones
                getTransaccionesResponse response = client.getTransacciones(request);
                
                
                //retorno
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


#endregion





		public static void UsaProxyDelSistema()
            {
                IWebProxy proxy = WebRequest.GetSystemWebProxy();
                proxy.Credentials = CredentialCache.DefaultCredentials;
                WebRequest.DefaultWebProxy = proxy;
            }
      
       
       
#region Conexion al Senasa

 		private IWebServiceSenasaPortType GetClient()
        {

            CustomBinding customBinding = (CustomBinding)CreateMultiFactorAuthenticationBinding();

            EndpointAddress endpointAddress = new EndpointAddress(this.EndPointAddr);
            
           
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



#endregion
       
       
       
       

    }

   
}