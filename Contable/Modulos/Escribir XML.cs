/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 13/07/2018
 * Hora: 10:06 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
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




using System.Linq;

using System.Runtime.Remoting.Messaging;

using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Security.Tokens;

using Contable.servicios.pami.org.ar;


namespace Contable.Modulos
{
	/// <summary>
	/// Description of Escribir_XML.
	/// </summary>
	public class Escribir_XML
	{
		public Escribir_XML()
		{
		}
		
#region Confirma Transaccion
/// <summary>
/// Escribe un ticket en XML de la respuesta en el disco 
/// </summary>
/// <param name="pepe">sendConfirmaTransaccResponse estructura del SENASA</param>
		public static void EscribirTicketSenasaResponse(sendConfirmaTransaccResponse pepe)
		{//ESTO ES DEL TICKET PARA GUARDARLO EN EL DISCO

			// Obtengo los XML de request/response y los escribo en el disco
			XmlSerializer writer1 = new XmlSerializer(typeof(sendConfirmaTransaccResponse));
			StreamWriter file1 = new StreamWriter("C:\\ConfirmaTranaccionResponse - " + 
												pepe.@return.codigoTransaccion + " - " + 
												DateTime.Now.ToString("dd-MM-yyyy")  + " - " +
												DateTime.Now.Hour.ToString() + "-" +
												DateTime.Now.Minute.ToString() + "-" +
												DateTime.Now.Second.ToString() + "-" +
												".xml");
			writer1.Serialize(file1, pepe);
			file1.Close();
		}
		
		public static void EscribirTicketSenasaRequest(sendConfirmaTransacc pepe)
		{//ESTO ES DEL TICKET PARA GUARDARLO EN EL DISCO

			// Obtengo los XML de request/response y los escribo en el disco
			XmlSerializer writer1 = new XmlSerializer(typeof(sendConfirmaTransacc));
			StreamWriter file1 = new StreamWriter("C:\\ConfirmaTranaccionRequest - " + 
			                                    pepe.arg2.Length.ToString() + "-" +
												DateTime.Now.ToString("dd-MM-yyyy")  + " - " +
												DateTime.Now.Hour.ToString() + "-" +
												DateTime.Now.Minute.ToString() + "-" +
												DateTime.Now.Second.ToString() + "-" +
												".xml");
			writer1.Serialize(file1, pepe);
			file1.Close();
		}
#endregion		


		
#region Send Transaccion
		public static void EscribirTicketSenasaResponse(saveTransaccionesResponse pepe)
		{//ESTO ES DEL TICKET PARA GUARDARLO EN EL DISCO

			// Obtengo los XML de request/response y los escribo en el disco
			XmlSerializer writer1 = new XmlSerializer(typeof(sendConfirmaTransaccResponse));
			StreamWriter file1 = new StreamWriter("C:\\ConfirmaTranaccionResponse - " + 
												pepe.@return.codigoTransaccion + " - " + 
												DateTime.Now.ToString("dd-MM-yyyy")  + " - " +
												DateTime.Now.Hour.ToString() + "-" +
												DateTime.Now.Minute.ToString() + "-" +
												DateTime.Now.Second.ToString() + "-" +
												".xml");
			writer1.Serialize(file1, pepe);
			file1.Close();
		}
		
		public static void EscribirTicketSenasaRequest(saveTransacciones pepe)
		{//ESTO ES DEL TICKET PARA GUARDARLO EN EL DISCO

			// Obtengo los XML de request/response y los escribo en el disco
			XmlSerializer writer1 = new XmlSerializer(typeof(sendConfirmaTransacc));
			StreamWriter file1 = new StreamWriter("C:\\ConfirmaTranaccionRequest - " + 
			                                    pepe.arg2.Length.ToString() + "-" +
												DateTime.Now.ToString("dd-MM-yyyy")  + " - " +
												DateTime.Now.Hour.ToString() + "-" +
												DateTime.Now.Minute.ToString() + "-" +
												DateTime.Now.Second.ToString() + "-" +
												".xml");
			writer1.Serialize(file1, pepe);
			file1.Close();
		}
#endregion		


	}
}
