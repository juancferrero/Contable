/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 29/04/2016
 * Hora: 03:51 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

using Contable.Modulos;
using ConexionDB;

using VariablesPropias;

using System.Configuration;

namespace Contable.MigrarDB
{
	/// <summary>
	/// Description of MigrarDB.
	/// </summary>
	public class MigrarDB
	{
		public MigrarDB()
		{
		}
		
		/// <summary>
		/// Modifica el nombre del banco en los cheques para que luego se pueda arreglar el ID del cheque
		/// </summary>
		/// <param name="BancoInicio">Nombre Inicial del Banco</param>
		/// <param name="BancoFin">Nombre del banco como quedara</param>
		public static void MigrarCheques(string BancoInicio, string BancoFin )
		{
		
		//Conectar a la base de datos		
		ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
				
		//Hace la consulta asumiendo que el cliente esta activo
		ConexionAccess2007.ModificarFila("Cheque", "Banco = '" + BancoFin +"'", "Banco = '" + BancoInicio +"'");
				
		
		
		//Cerrar la conexion
	    ConexionAccess2007.Desconectar();	
		
		
		}
		
		
		
		
		public static void ModificarReciboImprimible()
		{
		
		//Conectar a la base de datos		
		ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
				
		//Hace la consulta asumiendo que el cliente esta activo
		ConexionAccess2007.ModificarFila("Recibo", "ChequeNro2 = 0", "ChequeNro2 IS NULL");
				
		
		
		//Cerrar la conexion
	    ConexionAccess2007.Desconectar();	
		
		
		}
		
		
		
/*	
/// <summary>
/// Mueve un cheque a la base nueva.
/// </summary>
/// <param name="vpCheque">El objeto vpCheque que ingresa se guardara en la base nueva de cheques</param>
		public static void MoverChequeANuevaDB (VariablesPropias.VariablesPropias.vpCheque vpCheque)
		{
		//Conectar a la base de datos		
		ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseChequesProduccion"]));
				
		//Hace la consulta asumiendo que el cliente esta activo
		ConexionAccess2007.InsertarFila("Cheque", 
		                                "IDCheque, FechaEmision, FechaPago, FechaIngreso, FechaDeposito, " +
										"Importe, ImporteUSD, IDCliente, IDRecibo, Estado",
										"'" + vpCheque.strIDCheque + "'" +
										
);
	/*
 	* IDCheque
	* FechaEmision
	* FechaPago
	* FechaIngreso
FechaDeposito
Importe
ImporteUSD
IDCliente
IDRecibo
Estado
*			
		
		
		//Cerrar la conexion
	    ConexionAccess2007.Desconectar();	
		
		}
		
*/		
		
		
		
		
		
		
		
		
		
	}
	
}
