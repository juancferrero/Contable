/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 23/02/2017
 * Hora: 09:25 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */

using System;
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

namespace Contable.AFIP
{
	/// <summary>
	/// Description of WSAA_JCF.
	/// </summary>
	public class WSAA_JCF
	{
/// <summary>
/// Acceso al WSAA hecho por Juan C Ferrero
/// </summary>
		public WSAA_JCF()
		{
		}
		
		
	}
		
		

/// <summary>
/// Clase para crear objetos Login Tickets
/// </summary>
/// <remarks>
/// Ver documentacion: 
///    Especificacion Tecnica del Webservice de Autenticacion y Autorizacion
///    Version 1.0
///    Departamento de Seguridad Informatica - AFIP
/// </remarks>
public class LoginTicket
{ 
    public UInt32 UniqueId; // Entero de 32 bits sin signo que identifica el requerimiento
    public DateTime GenerationTime; // Momento en que fue generado el requerimiento
    public DateTime ExpirationTime; // Momento en el que expira la solicitud
    public string Service; // Identificacion del WSN para el cual se solicita el TA
    public string Sign; // Firma de seguridad recibida en la respuesta
    public string Token; // Token de seguridad recibido en la respuesta
    public XmlDocument XmlLoginTicketRequest = null;
    public XmlDocument XmlLoginTicketResponse = null;
    public string RutaDelCertificadoFirmante;
    public string XmlStrLoginTicketRequestTemplate = "<loginTicketRequest><header><uniqueId></uniqueId><generationTime></generationTime><expirationTime></expirationTime></header><service></service></loginTicketRequest>";
    private static UInt32 _globalUniqueID = 0; // OJO! NO ES THREAD-SAFE

    /// <summary>
    /// Construye un Login Ticket obtenido del WSAA
    /// </summary>
    /// <param name="argServicio">Servicio al que se desea acceder</param>
    /// <param name="argUrlWsaa">URL del WSAA</param>
    /// <param name="argRutaCertX509Firmante">Ruta del certificado X509 (con clave privada) usado para firmar</param>
    /// <param name="argPassword">Password del certificado X509 (con clave privada) usado para firmar</param>
    /// <param name="argProxy">IP:port del proxy</param>
    /// <param name="argProxyUser">Usuario del proxy</param>''' 
    /// <param name="argProxyPassword">Password del proxy</param>
    /// <param name="argVerbose">Nivel detallado de descripcion? true/false</param>
    /// <remarks></remarks>
    public string ObtenerLoginTicketResponse(string argServicio, string argUrlWsaa, string argRutaCertX509Firmante, SecureString argPassword)
    {
        const string ID_FNC = "[ObtenerLoginTicketResponse]";
        this.RutaDelCertificadoFirmante = argRutaCertX509Firmante;
        //this._verboseMode = argVerbose;
        //CertificadosX509Lib.VerboseMode = argVerbose;
        string cmsFirmadoBase64 = null;
        string loginTicketResponse = null;
        XmlNode xmlNodoUniqueId = default(XmlNode);
        XmlNode xmlNodoGenerationTime = default(XmlNode);
        XmlNode xmlNodoExpirationTime = default(XmlNode);
        XmlNode xmlNodoService = default(XmlNode);

        // PASO 1: Genero el Login Ticket Request
        try
        {
            _globalUniqueID += 1;

            XmlLoginTicketRequest = new XmlDocument();
            XmlLoginTicketRequest.LoadXml(XmlStrLoginTicketRequestTemplate);

            xmlNodoUniqueId = XmlLoginTicketRequest.SelectSingleNode("//uniqueId");
            xmlNodoGenerationTime = XmlLoginTicketRequest.SelectSingleNode("//generationTime");
            xmlNodoExpirationTime = XmlLoginTicketRequest.SelectSingleNode("//expirationTime");
            xmlNodoService = XmlLoginTicketRequest.SelectSingleNode("//service");
            xmlNodoGenerationTime.InnerText = DateTime.Now.AddMinutes(-10).ToString("s");
            xmlNodoExpirationTime.InnerText = DateTime.Now.AddMinutes(+10).ToString("s");
            xmlNodoUniqueId.InnerText = Convert.ToString(_globalUniqueID);
            xmlNodoService.InnerText = argServicio;
            this.Service = argServicio;

            
        }
        catch (Exception excepcionAlGenerarLoginTicketRequest) 
        {
            throw new Exception(ID_FNC + "***Error GENERANDO el LoginTicketRequest : " + excepcionAlGenerarLoginTicketRequest.Message + excepcionAlGenerarLoginTicketRequest.StackTrace);
        }

        // PASO 2: Firmo el Login Ticket Request
        try
        {
			
        	//Obtiene el certificado desde el archivo
            X509Certificate2 certFirmante = CertificadosX509Lib.ObtieneCertificadoDesdeArchivo(RutaDelCertificadoFirmante, argPassword);


            // Convierto el Login Ticket Request a bytes, firmo el msg y lo convierto a Base64
            Encoding EncodedMsg = Encoding.UTF8;
            byte[] msgBytes = EncodedMsg.GetBytes(XmlLoginTicketRequest.OuterXml);
            byte[] encodedSignedCms = CertificadosX509Lib.FirmaBytesMensaje(msgBytes, certFirmante);
            cmsFirmadoBase64 = Convert.ToBase64String(encodedSignedCms);
        }
        catch (Exception excepcionAlFirmar)
        {
            throw new Exception(ID_FNC + "***Error FIRMANDO el LoginTicketRequest : " + excepcionAlFirmar.Message);
        }

        
        // PASO 3: Invoco al WSAA para obtener el Login Ticket Response
        try
        {
          
			//conecto con el servicio WSAAA
            wsaa.afip.gov.ar.LoginCMSService servicioWsaa = new wsaa.afip.gov.ar.LoginCMSService();
            servicioWsaa.Url = argUrlWsaa;

          	//Hago el Login
            loginTicketResponse = servicioWsaa.loginCms(cmsFirmadoBase64);

            
        }
        catch (Exception excepcionAlInvocarWsaa)
        {
            throw new Exception(ID_FNC + "***Error INVOCANDO al servicio WSAA : " + excepcionAlInvocarWsaa.Message);
        }

        
        // PASO 4: Analizo el Login Ticket Response recibido del WSAA
        try
        {
            XmlLoginTicketResponse = new XmlDocument();
            XmlLoginTicketResponse.LoadXml(loginTicketResponse);

            this.UniqueId = UInt32.Parse(XmlLoginTicketResponse.SelectSingleNode("//uniqueId").InnerText);
            this.GenerationTime = DateTime.Parse(XmlLoginTicketResponse.SelectSingleNode("//generationTime").InnerText);
            this.ExpirationTime = DateTime.Parse(XmlLoginTicketResponse.SelectSingleNode("//expirationTime").InnerText);
            this.Sign = XmlLoginTicketResponse.SelectSingleNode("//sign").InnerText;
            this.Token = XmlLoginTicketResponse.SelectSingleNode("//token").InnerText;
        }
        catch (Exception excepcionAlAnalizarLoginTicketResponse)
        {
            throw new Exception(ID_FNC + "***Error ANALIZANDO el LoginTicketResponse : " + excepcionAlAnalizarLoginTicketResponse.Message);
        }
        return loginTicketResponse;
    }
}

/// <summary>
/// Libreria de utilidades para manejo de certificados
/// </summary>
/// <remarks></remarks>
class CertificadosX509Lib
{
    //public static bool VerboseMode = false;

    /// <summary>
    /// Firma mensaje
    /// </summary>
    /// <param name="argBytesMsg">Bytes del mensaje</param>
    /// <param name="argCertFirmante">Certificado usado para firmar</param>
    /// <returns>Bytes del mensaje firmado</returns>
    /// <remarks></remarks>
    public static byte[] FirmaBytesMensaje(byte[] argBytesMsg, X509Certificate2 argCertFirmante)
    {
        const string ID_FNC = "[FirmaBytesMensaje]";
        try
        {
            // Pongo el mensaje en un objeto ContentInfo (requerido para construir el obj SignedCms)
            ContentInfo infoContenido = new ContentInfo(argBytesMsg);
            SignedCms cmsFirmado = new SignedCms(infoContenido);

            // Creo objeto CmsSigner que tiene las caracteristicas del firmante
            CmsSigner cmsFirmante = new CmsSigner(argCertFirmante);
            cmsFirmante.IncludeOption = X509IncludeOption.EndCertOnly;

            // Firmo el mensaje PKCS #7
            cmsFirmado.ComputeSignature(cmsFirmante);

            // Encodeo el mensaje PKCS #7.
            return cmsFirmado.Encode();
        }
        catch (Exception excepcionAlFirmar)
        {
            throw new Exception(ID_FNC + "***Error al firmar: " + excepcionAlFirmar.Message);
        }
    }

    /// <summary>
    /// Lee certificado de disco
    /// </summary>
    /// <param name="argArchivo">Ruta del certificado a leer.</param>
    /// <returns>Un objeto certificado X509</returns>
    /// <remarks></remarks>
    public static X509Certificate2 ObtieneCertificadoDesdeArchivo(string argArchivo, SecureString argPassword)
    {
        const string ID_FNC = "[ObtieneCertificadoDesdeArchivo]";
        X509Certificate2 objCert = new X509Certificate2();
        try
        {
            if (argPassword.IsReadOnly())
            {
                objCert.Import(File.ReadAllBytes(argArchivo), argPassword, X509KeyStorageFlags.PersistKeySet);
            }
            else
            {
                objCert.Import(File.ReadAllBytes(argArchivo));
            }
            return objCert;
        }
        catch (Exception excepcionAlImportarCertificado)
        {
            throw new Exception(ID_FNC + "***Error al leer certificado: " + excepcionAlImportarCertificado.Message);
        }
    }
}



	}

