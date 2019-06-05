/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 24/07/2018
 * Hora: 10:56 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;


using System.Configuration;

using ConexionDB;
using Contable;
using VariablesPropias;
using CodigoDeBarras;

using Contable.SENASA.Opercaciones;

using Contable.servicios.pami.org.ar;

namespace Contable.Modulos
{
	/// <summary>
	/// Description of OperacionesTrazabilidad.
	/// </summary>
	public class OperacionesTrazabilidad
	{
		public OperacionesTrazabilidad()
		{
		}
	
	

/*id_transaccion_global
id_transaccion
f_transaccion
f_operacion
f_vencimiento
f_elaboracion
d_evento
n_cantidad
id_unidad
d_unidad
cod_producto
n_serie
n_lote
n_cai
n_cae
d_motivo_destruccion
observaciones
n_vale_compra
apellidoNombre
direccion
numero
localidad
provincia
n_postal
cuit
gln_informador
d_agente_informador
gln_origen
d_agente_origen
gln_destino
d_agente_destino
id_motivo_destruccion
en_transporte
n_manifiesto
n_remito_ingreso
n_remito_egreso
motivo_devolucion
d_estado_transaccion
d_tipo_transaccion
stock
d_producto

 * 
 */

		
	
/// <summary>
/// Guada en el Stock 
/// </summary>
/// <param name="datosGuardar"></param>
	public static void Guardar(transaccionSenasa datosGuardar)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseTrazabilidad"].ToString());
			
			
			
			 /*                
							                "id_transaccion, f_transaccion, " +
											"f_operacion, f_vencimiento, f_elaboracion, " +
											"d_evento, n_cantidad, " +
											"id_unidad, d_unidad, " +
											"cod_producto, n_serie,	n_lote, " + 
											"n_cai, n_cae, " + 
											"d_motivo_destruccion, observaciones, " +
											"n_vale_compra, " +
											"apellidoNombre,	direccion, numero, " +
											"localidad,	provincia, n_postal, cuit, " +
											"gln_informador, d_agente_informador, " +
											"gln_origen, d_agente_origen, " +
											"gln_destino, d_agente_destino, " +
											"id_motivo_destruccion,	en_transporte, " +
											"n_manifiesto,	n_remito_ingreso, n_remito_egreso, " +
											"motivo_devolucion,	d_estado_transaccion, " +
											"d_tipo_transaccion, stock, d_producto" , +
											*/
			
			

			try
			 {
							//Guardo los datos dentro de la tabla
			ConexionAccess2007.InsertarFila("Stock", 
			                                "id_transaccion, " +
			                                "f_transaccion, " +
							                "f_operacion, " +
							                "d_evento, " +
							                "d_agente_informador, " +
											"d_agente_origen, " +
											"d_agente_destino, " +              
							                "d_producto, " +             
							                "cod_producto, " +
							                "n_cantidad, " +
							                "d_estado_transaccion, " +
							                "d_tipo_transaccion, " +
							                "n_serie, " +
							                "n_lote, " +
							                "n_remito_ingreso, " +
							                "d_motivo_destruccion, " +
							                //"en_transporte, " +
							                "motivo_devolucion, " +
							                //"observaciones"//, " +
											"n_vale_compra, " +
											 "apellidoNombre, " +
											 "direccion, " +
											 "numero, " +
											 "localidad, " +
											 "provincia, " +
											 "n_postal, " +
											 "cuit, " + 
											 "stock"
											,
											
											"" + datosGuardar.id_transaccion + ", " +   							
									        "'" + datosGuardar.f_transaccion.ToShortDateString() +"', " + 							
									        "'" + datosGuardar.f_operacion.ToShortDateString() + "', " + 							
									        "'" + datosGuardar.d_evento + "', " + 							
									        "'" + datosGuardar.d_agente_informador + "', " + 									
									        "'" + datosGuardar.d_agente_origen + "', " +										
									        "'" + datosGuardar.d_agente_destino + "', " +										
									        "'" + datosGuardar.d_producto + "', " +							
									        "'" + datosGuardar.cod_producto  + "', " +									
									        datosGuardar.cantidad + ", " +										
									        //"'" + datosGuardar.d_envase + "', " +							
									        "'" + datosGuardar.d_estado_transaccion + "', " +								
									        "'" + datosGuardar.d_tipo_transaccion + "', " +									
									        "'" + datosGuardar.n_serie + "', " +									
									        "'" + datosGuardar.n_lote + "', " +									
									        "'" + datosGuardar.n_remito + "', " +							
									        "'" + datosGuardar.d_motivo_destruccion + "', " +							
									        //"'" + datosGuardar.en_transporte + "', " +							
									        "'" + datosGuardar.motivo_devolucion + "', " +						
									        //"" + datosGuardar.observaciones + ""//"', " +							
									        "'" + datosGuardar.n_vale_compra + "', " +							
									        "'" + datosGuardar.apellidoNombres + "', " +						
									        "'" + datosGuardar.direccion + "', " +								
									        datosGuardar.numero + ", " + 										
									        //datosGuardar.numeroSpecified;										
									        "'" + datosGuardar.localidad + "', " +										
									        //datosGuardar.localidadSpecified 									
									        "'" + datosGuardar.provincia + "', " +										
									        //datosGuardar.provinciaSpecified;  								
									        "'" + datosGuardar.n_postal + "', " +								
									        "'" + datosGuardar.cuit + "', " + 
									        datosGuardar.cantidad, false   );
							

							
				//MessageBox.Show ("Registro guardado", "Guardado");
				
				
			}
			catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
			
			//Cerrar la conexion
            ConexionAccess2007.Desconectar();
            
		}
	
	
	
	
/// <summary>
/// Arma un Source para un grid con el stock de lo que haya en la base
/// </summary>
/// <returns></returns>
	public static BindingSource FuenteObtenerStockTrazabilidad()
	{
		//usa los datos guardados de donde esta la base de datos para no tener que copiar siempre lo mismo
		ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseTrazabilidad"]));
		
		//Hace la consulta segun criterio
		//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
		ConexionAccess2007.Consultar("Stock", 
		                             "*", 
		                             "ID");

		 
		//Desconecto para no tener problemas
		ConexionAccess2007.Desconectar ();
		
		//Cargo los datos en el grid
		return ConexionAccess2007.Source;
	}	
	
	
	
	
	public static void ModificarStockTrazabilidad(string ID)
		{
			//usa los datos guardados de donde esta la base de datos para no tener que copiar siempre lo mismo
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseTrazabilidad"]));
		
			
			
			ConexionAccess2007.ModificarFila("Stock", "id_transaccion = " + ID, "ID = " + ID);
			
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
		}
	
	
	public static void Eliminar (string ID)
		{
			//Esta funcion conecta con la base de datos a trabajar
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseTrazabilidad"]));
			
			ConexionAccess2007.EliminarFila("Stock", "ID="+ ID , false );
				
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
		}
	
	}
	
}
