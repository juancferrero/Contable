/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 06/01/2016
 * Hora: 06:22 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Configuration; 
using VariablesPropias;
using ConexionDB;

namespace Contable.Modulos
{
	/// <summary>
	/// Description of Clientes.
	/// </summary>
	public class Clientes
	{
		public Clientes()
		{
		}
		
		public static VariablesPropias.VariablesPropias.vpClientes  ObtenerCliente (string strClieNombre)
		{
			
			#region VARIABLES 
			
			VariablesPropias.VariablesPropias.vpClientes clientes = new VariablesPropias.VariablesPropias.vpClientes();
			
			#endregion
			
			
			
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("Clientes",  "*", "Nombre", strClieNombre ,"Nombre");
			
			/*
			 Es necesario que se arme una base de datos de contactos para sacar de ahi.
			 Con esto se gana sacar los contactos de la base de datos principal.
			 */
			
			clientes.strid = ConexionAccess2007.Table.Rows[0].ItemArray[0].ToString();
			clientes.strNombre = strClieNombre;
			clientes.strDireccion = ConexionAccess2007.Table.Rows[0].ItemArray[2].ToString();
			clientes.strLocalidad  = ConexionAccess2007.Table.Rows[0].ItemArray[3].ToString();
			clientes.strProvincia = ConexionAccess2007.Table.Rows[0].ItemArray[4].ToString();
			clientes.strTelefono1 = ConexionAccess2007.Table.Rows[0].ItemArray[5].ToString();
			clientes.strTelefono2 = ConexionAccess2007.Table.Rows[0].ItemArray[6].ToString();
			clientes.strTelefono3 = ConexionAccess2007.Table.Rows[0].ItemArray[7].ToString();
			clientes.dblCUIT = Convert.ToDouble( ConexionAccess2007.Table.Rows[0].ItemArray[13].ToString());
			
			clientes.strCodPos = ConexionAccess2007.Table.Rows[0].ItemArray[12].ToString();
			
			//Transporte
			clientes.Transporte.intTranspId = Convert.ToInt32 ( ConexionAccess2007.Table.Rows[0].ItemArray[12].ToString());
			clientes.Transporte = OperacionesComunes.ObtenerTransporte(clientes.Transporte.intTranspId.ToString());
			
			/*
			 Aca va la otra parte donde se arregla la base y se colocan los valore de la base de datos de contactos
			 */
			
			clientes.Contactos = new VariablesPropias.VariablesPropias.vpClieContacto[10];
			clientes.Contactos[0].strNombre  = ConexionAccess2007.Table.Rows[0].ItemArray[9].ToString(); 
			clientes.Contactos[1].strNombre  = ConexionAccess2007.Table.Rows[0].ItemArray[10].ToString();
			clientes.Contactos[2].strNombre  = ConexionAccess2007.Table.Rows[0].ItemArray[11].ToString();
			
			
			//Variable Memo con los datos de la empresa
			clientes.memoVarios = ConexionAccess2007.Table.Rows[0].ItemArray[20].ToString();
			
			
			
			
			
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			//try {
			
			//Cargo los datos en la funcion
			return clientes;
			
				//ConexionAccess2007.Table.Rows[0].ItemArray[1].ToString();
			
			//} catch (Exception e) {
			//	MessageBox.Show(e.Message.ToString());
				
				
			//return text.Text; 
				
				//throw;
			//}
			
			
			
			
		}		
		
		
		
		
		
		
		
	}
}
