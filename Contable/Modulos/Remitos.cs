/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 01/03/2017
 * Hora: 07:26 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;
	
using System.Configuration;
using ImprimirEjemplo;

using ConexionDB;
using VariablesPropias;
using CodigoDeBarras;

using Contable.Modulos;

using Contable.InputBox;

namespace Contable.Modulos
{
	/// <summary>
	/// Description of Remitos.
	/// </summary>
	public class Remitos
	{
		public Remitos()
		{
		}
		
		
		/// <summary>
/// Sobrecarga de la funcion CargarRemito. Con esta lo hacemos desde la base de datos en vez de desde el form.
/// </summary>
/// <param name="intNumeroRemito">
/// Es el numero del remito. Deberia ser el ID del remito y ser un string. 
/// Veremos como lo arreglamos en el futuro.
/// </param>
		public static VariablesPropias.VariablesPropias.vpRemito CargarRemito(int intNumeroRemito)
		{
			
			
			
			#region Variables
				VariablesPropias.VariablesPropias.vpRemito remi = new VariablesPropias.VariablesPropias.vpRemito();
			#endregion
			
			#region DB
			
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//tener en cuenta que primero va la condicion y luego el Order by
            ConexionAccess2007.Consultar("Remitos", "*", "NumRemito = " + intNumeroRemito , "NumRemito" );
			
            //Nueva Tabla
            DataTable Remito = new DataTable();
 			//Cargo la tabla con los datos de la Base de Datos
            Remito = ConexionAccess2007.Table;

			
            #endregion
            
            //Cargo los datos en una vp (Variable propia) para despues pasarlo a cada parte
			//lo hago asi para que luego si cambio algo no se joda todo.
				
            
            remi.dtFecha = Convert.ToDateTime (Remito.Rows[0]["Fecha"].ToString());
			
			//Id del remito es todo el numero del remito
			//TODO: Mejorar esto porque esta mal.
			remi.IDRemito = "0001-0000"+ intNumeroRemito.ToString() ;
			
				
				
			
			
			
            
   /*         
TODO: Ver como cargar la posicion ante el IVA como un string y no 6 booleanos
IVARespIns
IVARespNoIns
IVARegMono
IVANoResp
IVAExento
IVAConsFinal
*/


			//CLiente
			
			
			remi.Cliente = OperacionesComunes.ObtenerCliente(Remito.Rows[0]["Nombre"].ToString());
			//remi.Cliente.strNombre = Remito.Rows[0]["Nombre"].ToString();
			//remi.Cliente.strDireccion =  Remito.Rows[0]["Direccion"].ToString();
			//remi.Cliente.strLocalidad =  Remito.Rows[0]["Nombre"].ToString();
			//remi.Cliente.strProvincia =  Remito.Rows[0]["Nombre"].ToString();
			//remi.Cliente.dblCUIT = Convert.ToDouble ( Remito.Rows[0]["CUIT"].ToString());
			//remi.Cliente.strPosIVA =  Remito.Rows[0]["Nombre"].ToString();
			
								
			//Transporte
			remi.Transporte.strNombre = Remito.Rows[0]["TranspNombre"].ToString();
			remi.Transporte.strDireccion = Remito.Rows[0]["TranspDireccion"].ToString();
				
			//Productos
				//Producto 1
			remi.Producto1.intCantidad = Convert.ToInt16  (Remito.Rows[0]["Cant1"].ToString());
			remi.Producto1.strDescripcion = Remito.Rows[0]["Deatalle1"].ToString();
			remi.Producto1.curPrecioNeto = Convert.ToDecimal (Remito.Rows[0]["Precio1"].ToString()) / Convert.ToInt16  (Remito.Rows[0]["Cant1"].ToString());;
			remi.Producto1.curPrecioTotal = remi.Producto1.curPrecioNeto  * Convert.ToInt16  (Remito.Rows[0]["Cant1"].ToString());
			remi.Producto1.Trazabilidad.strNumPartida = Remito.Rows[0]["IDProdu1"].ToString();
	
				//Producto 2
			remi.Producto2.intCantidad = Convert.ToInt16  (Remito.Rows[0]["Cant2"].ToString());
			remi.Producto2.strDescripcion = Remito.Rows[0]["Deatalle2"].ToString();
			if (Convert.ToInt16  (Remito.Rows[0]["Cant2"].ToString()) >0 ) 
				{
				remi.Producto2.curPrecioNeto = Convert.ToDecimal (Remito.Rows[0]["Precio2"].ToString()) / Convert.ToInt16  (Remito.Rows[0]["Cant2"].ToString());
				}
			remi.Producto2.curPrecioTotal  = remi.Producto2.curPrecioNeto  * Convert.ToInt16  (Remito.Rows[0]["Cant2"].ToString());
			remi.Producto2.Trazabilidad.strNumPartida = Remito.Rows[0]["IDProdu2"].ToString();

				//Producto 3
			remi.Producto3.intCantidad = Convert.ToInt16  (Remito.Rows[0]["Cant3"].ToString());
			remi.Producto3.strDescripcion = Remito.Rows[0]["Deatalle3"].ToString();
			if (Convert.ToInt16  (Remito.Rows[0]["Cant3"].ToString()) >0 ) 
				{
				remi.Producto3.curPrecioNeto = Convert.ToDecimal (Remito.Rows[0]["Precio3"].ToString()) / Convert.ToInt16  (Remito.Rows[0]["Cant3"].ToString());
				}
			remi.Producto3.curPrecioTotal  = remi.Producto3.curPrecioNeto  * Convert.ToInt16  (Remito.Rows[0]["Cant3"].ToString());
			remi.Producto3.Trazabilidad.strNumPartida = Remito.Rows[0]["IDProdu3"].ToString();

				//Producto 4
			remi.Producto4.intCantidad = Convert.ToInt16  (Remito.Rows[0]["Cant4"].ToString());
			remi.Producto4.strDescripcion = Remito.Rows[0]["Deatalle4"].ToString();
			if (Convert.ToInt16  (Remito.Rows[0]["Cant4"].ToString()) >0 ) 
				{
				remi.Producto4.curPrecioNeto = Convert.ToDecimal (Remito.Rows[0]["Precio4"].ToString()) / Convert.ToInt16  (Remito.Rows[0]["Cant4"].ToString());
				}
			remi.Producto4.curPrecioTotal  = remi.Producto4.curPrecioNeto  * Convert.ToInt16  (Remito.Rows[0]["Cant4"].ToString());
			remi.Producto4.Trazabilidad.strNumPartida = Remito.Rows[0]["IDProdu4"].ToString();
				
				//Producto 5
			remi.Producto5.intCantidad = Convert.ToInt16  (Remito.Rows[0]["Cant5"].ToString());
			remi.Producto5.strDescripcion = Remito.Rows[0]["Deatalle5"].ToString();
			if (Convert.ToInt16  (Remito.Rows[0]["Cant5"].ToString()) >0 ) 
				{
				remi.Producto5.curPrecioNeto = Convert.ToDecimal (Remito.Rows[0]["Precio5"].ToString()) / Convert.ToInt16  (Remito.Rows[0]["Cant5"].ToString());
				}
			remi.Producto5.curPrecioTotal  = remi.Producto5.curPrecioNeto  * Convert.ToInt16  (Remito.Rows[0]["Cant5"].ToString());
			remi.Producto5.Trazabilidad.strNumPartida = Remito.Rows[0]["IDProdu5"].ToString();
			
			
			//Chofer
			remi.strChofer = "Maximiliano Esposito DNI 37.375.313";

			//Valor Declarado
			remi.curTotal = Convert.ToDecimal(Remito.Rows[0]["ValorDeclarado"].ToString());
				
			//Nota
			remi.strNota = Remito.Rows[0]["Notas"].ToString();
				
			
			
			
			
			
		
		
			
			
			 //Cerrar la conexion
            ConexionAccess2007.Desconectar();
			
			
			return remi;
		}
	}
}
