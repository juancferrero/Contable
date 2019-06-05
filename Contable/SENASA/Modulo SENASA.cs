/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 29/11/2014
 * Hora: 04:36 p.m.
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

using Contable.servicios.pami.org.ar;
using Contable.Modulos;




namespace Contable.SENASA.Opercaciones
{
		
	/// <summary>
	/// Operaciones para realizar con el SENASA - Trazabilidad
	/// </summary>
	public class Operaciones
	{
		
		/// <summary>
		/// ???
		/// </summary>
		public Operaciones()
		{
		}

	
#region FUNCIONAL

		
		/// <summary>
		/// Esta función consulta en el SENSASA las operaciones pendientes de aprobación.
		/// </summary>
		/// <param name="usr">Usuario</param>
		/// <param name="pass">Contraseña</param>
		/// <param name="parametrosConsulta">Una estructura que posee todos los valores para poder hacer la consulta</param>
		public static  transaccionSenasa[] ConsultarDatosSENASA (string usr, string pass, vpConsultaSENASA parametrosConsulta)
		{
			
    	   	/* Esto crea un cliente.
			* Usa los valores de USUARIO Y CONTRASEÑA POR DEFECTO
			* El cliente es la capa de transporte de datos que me permite conectarme con el WebService
			*/
        	ServiceClient client = new ServiceClient("testwservice", "testwservicepsw");
        	
        	
        	
        	//Carga en la "respuesta" los resultados de GETTRANSACCION con los parametros y el ususario y contraseñas mio
        	//Uso el ParametrosConsulta que es una estructura que le paso para poder armar esto.
        	getTransaccionesResponse respuesta = client.GetTransacciones (	usr, pass, parametrosConsulta);
        	
            
            //retorna la respuesta a la funcion
            return respuesta.@return.list ;
            
            //MUESTRA UNA RESPUESTA
            
            /* modelos de respuesta
             * MessageBox.Show(trans[0].n_lote.ToString()); //respuesta.@return.list[0].id_transaccion_global.ToString());
             * MessageBox.Show(respuesta.@return.list[0].n_serie.ToString());
             * MessageBox.Show(respuesta.@return.list.Length.ToString());
             */
            
            
		}
		
		
		
#endregion            	

#region REVISAR NO FUNCIONAL AUN
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="usr"></param>
		/// <param name="pass"></param>
		/// <param name="parametrosConfirmarDatos"></param>
		/// <returns></returns>
		public static  webServiceResult ConfirmarTransacionesSENASA (string usr, string pass, confirmacionTransaccionSenasaDTO[] parametrosConfirmarDatos)
		{
			
    	   	/* Esto crea un cliente.
			* Usa los valores de USUARIO Y CONTRASEÑA POR DEFECTO
			* El cliente es la capa de transporte de datos que me permite conectarme con el WebService
			*/
        	ServiceClient client = new ServiceClient("testwservice", "testwservicepsw");
        	
        	
       	
        	
        	
        	//Carga en la "respuesta" los resultados de SENDCONFIRMATRANSACCION con los parametros y el ususario y contraseñas mio
        	//Uso el ParametrosConsulta que es una estructura que le paso para poder armar esto.
        	sendConfirmaTransaccResponse respuesta = client.SendConfirmaTransac(usr, pass, parametrosConfirmarDatos);
        	
            //MUESTRA UNA RESPUESTA
           
            
            return respuesta.@return;
            
            /* modelos de respuesta
            
            MessageBox.Show(trans[0].n_lote.ToString()); //respuesta.@return.list[0].id_transaccion_global.ToString());
            
            MessageBox.Show(respuesta.@return.list[0].n_serie.ToString());
            
            MessageBox.Show(respuesta.@return.list.Length.ToString());*/
            
            
		}


		
	


		/// <summary>
		/// Envia los datos al SENASA para que pueda aprobarse una operacion.
		/// </summary>
		/// <param name="usr">Usuario</param>
		/// <param name="pass">Contraseña</param>
		/// <param name="parametros">Esto junta todos los datos del parametros para enviar al SENASA</param>
        public static void EnviarDatosSENASA(string usr, string pass, transaccionSenasaDTO[] parametros)
        {
          
        	       	
        	
        	
            
        	//Esto crea un cliente. Usa los valores de USUARIO Y CONTRASEÑA POR DEFECTO
        	ServiceClient client = new ServiceClient("testwservice", "testwservicepsw");
        	
        	
        	
        	
        	//Carga en la respuesta los resultados de SENDTRANSACCION con los parametros y el ususario y contraseñas mio
            
        	saveTransaccionesResponse respuesta = client.SendTransaccion(parametros, usr, pass);
            
            //MUESTRA UNA RESPUESTA
            
            MostrarRespuesta(respuesta.@return);

        }

 
		///<summary>
		///Esta funcion cumple con armar un array con los parametros para pasarlos al SENASA en un SendTransaccion.
		///</summary>
		/// <param name="datosOperacion">Variable propia que trae todos los datos de una operacion</param>
        public static transaccionSenasaDTO[] ObtenerParametros( vpTransaccionSENASADTO datosOperacion)
        {
			
            
        	
        	
            transaccionSenasaDTO tran = new transaccionSenasaDTO();

            //Fecha de la operacion
            tran.f_operacion = datosOperacion.f_operacion;
            //Id del evento que lo saco despues de obtener el valor del combo y pasarlo por la funcion que lo transforma en numero
            tran.id_evento = datosOperacion.id_evento;
            //Especifico si tiene ID del evento
            tran.id_eventoSpecified = true;
            //Cantidad de mercaderia igual
            
            
            
            //PRODUCTO
            tran.n_cantidad = datosOperacion.n_cantidad;
            //Especifico si se agrega la cantidad
            tran.n_cantidadSpecified = true;
            //Especifico el Lote            
            tran.n_lote = datosOperacion.n_lote;
            //Especifico la Serie
            tran.n_serie = datosOperacion.n_serie;
            //Fecha de Elaboracion
            tran.f_elaboracion = datosOperacion.f_elaboracion ;
            //Fecha de Vencimiento
            tran.f_vto = datosOperacion.f_vto ;
            //Codigo de producto GTIN del producto
            tran.cod_producto = datosOperacion.cod_producto;

            //GLN de origen
         	tran.gln_origen = datosOperacion.gln_origen;
         	//GLN de destino
        	tran.gln_destino = datosOperacion.gln_destino ;           
           

            transaccionSenasaDTO[] transacciones = new transaccionSenasaDTO[1];

            transacciones[0] = tran;
            return transacciones;
        }

        

        
		///<summary>
		///Esto convierte los nombres de las condiciones en su homologo numerico
		///</summary>
        public static int valorCombo(string condicion)
        {
            
        	        	
        	
        	
        	if (condicion == "IMPORTACION")
            {
                return 1;
            }
            if (condicion == "LIBERACION DE ZONA FRANCA")
            {
                return 2;
            }
            if (condicion == "EXPORTACION")
            {
                return 3;
            }
            if (condicion == "SINTESIS DE PRINCIPIO ACTIVO")
            {
                return 4;
            }
            if (condicion == "USO PARA PRODUCCION DE PRODUCTO")
            {
                return 5;
            }
            if (condicion == "PRODUCCION DE PRODUCTOS")
            {
                return 6;
            }
            if (condicion == "USO PARA FRACCIONAMIENTO")
            {
                return 7;
            }
            if (condicion == "RESULTADO DE FRACCIONAMIENTO")
            {
                return 8;
            }
            if (condicion == "DESTRUCCION / MERMA")
            {
                return 9;
            }
            if (condicion == "ROBO / HURTO")
            {
                return 10;
            }
            if (condicion == "VENTA / ENVIO")
            {
                return 11;
            }
            if (condicion == "RECEPCIÓN DE COMPRA")
            {
                return 12;
            }
            if (condicion == "VENTA MINORISTA")
            {
                return 13;
            }
            if (condicion == "DEVOLUCION")
            {
                return 14;
            }
            if (condicion == "RECEPCION POR DEVOLUCION MINORISTA")
            {
                return 16;
            }
            if (condicion == "PRODUCCION CON MATERIA PRIMA NO TRAZADA")
            {
                return 17;
            }
            if (condicion == "USO PARA AUTOCONSUMO")
            {
                return 18;
            }
            if (condicion == "IMPORTACION A ZONA FRANCA")
            {
                return 19;
            }
            if (condicion == "EXPORTACION DESDE ZONA FRANCA")
            {
                return 20;
            }
            if (condicion == "ENVIO A COMERCIANTE NO INSCRIPTO EN EL SISTEMA")
            {
                return 21;
            }







	
            
            return 0;
        }

        
#endregion

#region Resultados

        /// <summary>
        /// Muestra el resultado de la operacion
        /// </summary>
        /// <param name="wsResult">Un resultado Existoso de consumir el WS</param>
        public static void MostrarRespuesta(webServiceResult wsResult)
        {
        	MessageBox.Show( wsResult.resultado.ToString());
            if (!string.IsNullOrEmpty(wsResult.codigoTransaccion))
            {
            	MessageBox.Show(wsResult.codigoTransaccion);
            	MessageBox.Show( "¡Transacción Exitosa!" + "\r\n" + "Codigo de Transacción:" + wsResult.codigoTransaccion);

            }
            else
            {
                MostrarErrores(wsResult);
            }
        }

        
        /// <summary>
        /// Muestra los codigos de Error en un mensaje al Usuario
        /// </summary>
        /// <param name="wsResult">Un resultado erroneo de consumir el WS</param>
        public static void MostrarErrores(webServiceResult wsResult)
        {
            if (wsResult.errores != null)
            {
                foreach (var error in wsResult.errores)
                {
                    if (error.c_error != null)
                    {
                    	MessageBox.Show( error.c_error + " - " + error.d_error + "\r\n");
                    }
                    else
                    {
                    	MessageBox.Show( error.d_error + "\r\n");
                    }
                }
            }
        }

#endregion        
        
#region Estructuras para el manejo de Trazabilidad
		
		public struct vpConsultaSENASA
   	 	{
    		
    		public string IdTransaccion; //long
    		public string IdEvento; //long
    		public string GLNOrigen; //long
    		public DateTime fechaTransDesde; //DateTime
    		public DateTime fechaTransHasta; //DateTime
    		public DateTime fechaOpeDesde; //DateTime
    		public DateTime  fechaOpeHasta; //DateTime
    		public string GLNInformador; //long
    		public string IdTipoTransaccion;//long
    		public string GTINElemento; //long
    		public string NroLote;
    		public string NroSerie;
    		public string NroRemitoFC;
    		public string estadoTransaccion;
            	
    	}
	    	
		public struct vpTransaccionSENASADTO 
   	 	{	    	
	    	
	    	public string gln_origen;
	        public string gln_destino;
	        public string f_operacion;
	        public string f_elaboracion; /// <summary> Fecha de elaboracion</summary>
	        public string f_vto;
	        public long id_evento;
	        public bool id_eventoSpecified;
	        public string cod_producto;
	        public long n_cantidad;
	        public bool n_cantidadSpecified;
	        public string c_tipo_unidad;
	        public string n_serie;
	        public string n_lote;
	        public string n_cai;
	        public string n_cae;
	        public long id_motivo_destruccion;
	        public bool id_motivo_destruccionSpecified;
	        public string n_manifiesto;
	        public string en_transporte;
	        public string n_remito;
	        public string motivo_devolucion;
	        public string observaciones;
	        public string n_vale_compra;
	        public string apellidoNombres;
	        public string direccion;
	        public long numero;
	        public bool numeroSpecified;
	        public long localidad;
	        public bool localidadSpecified;
	        public long provincia;
	        public bool provinciaSpecified;
	        public string n_postal;
	        public string cuit;
        
    }
		
		public struct vpConfirmacionTransaccionSENASA
   	 	{
    		
    		public string p_ids_transac; 
    		public string f_operacion; //DateTime (dd/mm/AAAA)
    		public string n_cantidad;
    			
    	}
    	
#endregion
        
        
    	
    	
    	

	}
    	
  	
    
}
       

        


        

        
        
        
        

		
		
		
	

