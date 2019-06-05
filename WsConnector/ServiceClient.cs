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


using WsConnector.ServiceReference;

namespace WsConnector
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

        public saveTransaccionesResponse SendTransaccion(transaccionSenasaDTO[] transacciones, string usr, string pass)
        {
            IWebServiceSenasaPortType client = GetClient();
            try
            {
                saveTransacciones request = new saveTransacciones(transacciones, usr, pass);
                saveTransaccionesResponse response = client.saveTransacciones(request); 
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

        public getTransaccionesResponse GetTransacciones(string usser, 
                                                        string pass, 
                                                        
                                                        string IdTransaccion,//JCF
                                                        string IdEvento,//JCF
                                                        string GLNOrigen,
														string fechaTransDesde,//JCF
														string fechaTransHasta,//JCF
                                                        string fechaOpeDesde,
                                                        string fechaOpeHasta, 
                                                        string GLNInformador,
                                                       	string IdTipoTransaccion,//JCF
                                                        string GTINElemento,//JCF
                                                        string NroLote,
                                                        string NroSerie,
                                                        string NroRemitoFC,                                                        
                                                        //long GLNDestino,
                                                        //DateTime fechaVencimientoDesde, 
                                                        //DateTime fechaVencimientoHasta, 
                                                        //long nroRemito, 
                                                        //long nroFactura, 
                                                        string estadoTransaccion)    //string usr, string pass, long GLNInformador, long GLNOrigen, long GLNDestino, string GTIN, long idEvento, string fechaOpeDesde, string fechaOpeHasta, string fechaTranDesde, string fechaTranHasta, string fechaVencimientoDesde, string fechaVencimientoHasta, long nroRemito, long nroFactura, long estadoTransaccion
        {
            IWebServiceSenasaPortType client = GetClient();

            try
            {
                getTransacciones request = new getTransacciones(usser, 
                                                        pass, 
                                                        
                                                        IdTransaccion,//JCF
                                                        IdEvento,//JCF
                                                        GLNOrigen,
														fechaTransDesde,//JCF
														fechaTransHasta,//JCF
                                                        fechaOpeDesde,
                                                        fechaOpeHasta, 
                                                        GLNInformador,
                                                       	IdTipoTransaccion,//JCF
                                                        GTINElemento,//JCF
                                                        NroLote,
                                                        NroSerie,
                                                        NroRemitoFC,
                                                       estadoTransaccion);
                
                getTransaccionesResponse response = client.getTransacciones(request);
                
                return response;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

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

        public static Binding CreateMultiFactorAuthenticationBinding()
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