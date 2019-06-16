/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 17/09/2014
 * Hora: 09:28 a.m.
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


namespace Contable.Modulos
	
	
{
	/// <summary>
	/// Operaciones generales.
	/// </summary>
	public class OperacionesComunes
	{
		public OperacionesComunes()
		{
		}
		
		
		
		

/// <summary>
/// Obtiene los cheques en cartera para la base nueva
/// </summary>
/// <returns>Un source de cheques en cartera</returns>
		public static BindingSource FuenteChequesEnCarteraNew()
		{
		//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseCheques"].ToString());
			
			//Hace la consulta segun criterio
			//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
			ConexionAccess2007.Consultar("Cheque", 
			                             "IDCheque, FechaEmision, FechaPago, FechaIngreso, Importe, IDCliente ", 
			                             "FechaDeposito IS NULL",
			                             "FechaIngreso");
	 
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
				//Cargo los datos en el grid
			return  ConexionAccess2007.Source;
		}
/// <summary>
/// Obtiene los cheques en cartera para la base nueva
/// </summary>
/// <returns>Tabla de cheques en caretera</returns>
		public static DataTable TablaChequesEnCarteraNew()
		{
		//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseCheques"].ToString());
			
			//Hace la consulta segun criterio
			//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
			ConexionAccess2007.Consultar("Cheque", 
			                             //"FechaEmision, FechaPago, NumCheque, Banco, Sucursal, " +
			                             //"Importe, Cliente, Terceros",
			                             "*",
			                             "FechaDeposito IS NULL",
			                             "FechaIngreso");

			
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
				//Cargo los datos en el grid
			return  ConexionAccess2007.Table;
		}
		

		
		
		public static BindingSource FuenteObtenerEfectivo(DateTime dtFechaInicio, DateTime dtFechaFinal)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta segun criterio
			//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
			ConexionAccess2007.Consultar("Recibo", 
			                             "*", 
			                             "Fecha >= #" + dtFechaInicio.ToString("MM/dd/yyyy")  + "# AND Fecha <= #" + dtFechaFinal.ToString("MM/dd/yyyy")  +"# AND Efectivo <> '0'",
			                             "NumRecibo");


			
			 
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			//Cargo los datos en el grid
			return ConexionAccess2007.Source;
			
			}
		
		public static BindingSource FuenteObtenerChequesRecibidos(DateTime dtFechaInicio, DateTime dtFechaFinal)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta segun criterio
			//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
			ConexionAccess2007.Consultar("Cheque", 
			                             "*", 
			                             "FechaIngreso >= #" + dtFechaInicio.ToString("MM/dd/yyyy")  + "# AND FechaIngreso <= #" + dtFechaFinal.ToString("MM/dd/yyyy")  +"#",
			                             "FechaIngreso");

			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			//Cargo los datos en el grid
			return ConexionAccess2007.Source;
			
		}

		
		public static BindingSource FuenteObtenerFacturasHechas(DateTime dtFechaInicio, DateTime dtFechaFinal)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta segun criterio
			//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
			ConexionAccess2007.Consultar("Facturas", 
			                             "Documento, Fecha, ImporteFinal, ImporteFinalUSS", 
			                             "Fecha >= #" + dtFechaInicio.ToString("MM/dd/yyyy")  + "# AND Fecha <= #" + dtFechaFinal.ToString("MM/dd/yyyy")  +"#",
			                             "Documento");

			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			//Retorno los datos
			return ConexionAccess2007.Source ;
			
			
					
		}
		
		
		
		
		/// <summary>
		/// Obtiene las facturas que se encuentran impagas.
		/// </summary>
		/// <param name="dtFechaInicio"></param>
		/// <returns></returns>
		public static BindingSource FuenteObtenerFacturasImpagas(DateTime dtFechaInicio)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta segun criterio
			//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
			ConexionAccess2007.Consultar("Facturas", 
			                             "Documento, Fecha,Nombre, ImporteFinal, ImporteFinalUSS, Saldo", 
			                             "Saldo <> '0' AND Fecha >= #1/1/" + (dtFechaInicio.Year -1) +"#" ,
			                             "Documento");

			
			
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();

			//Cargo los datos en la funcion
			return  ConexionAccess2007.Source ;
		}

		public static BindingSource FuenteObtenerInterdepositosRecibidos(DateTime dtFechaInicio, DateTime dtFechaFinal)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta segun criterio
			//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
			ConexionAccess2007.Consultar("Interdepositos", 
			                             "*", 
			                             "FechaPago >= #" + dtFechaInicio.ToString("MM/dd/yyyy")  + "# AND FechaPago <= #" + dtFechaFinal.ToString("MM/dd/yyyy")  +"#",
			                             "Cliente");
						 
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			//Cargo los datos en la funcion
			return  ConexionAccess2007.Source;
		}
				
		public static BindingSource FuenteObtenerChequesDepositados(DateTime dtFechaInicio, DateTime dtFechaFinal)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta segun criterio
			//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
			ConexionAccess2007.Consultar("Cheque", 
			                             "*", 
			                             "FechaDeposito >= #" + dtFechaInicio.ToString("MM/dd/yyyy")  + "# AND FechaDeposito <= #" + dtFechaFinal.ToString("MM/dd/yyyy")  +"#",
			                             "FechaDeposito");

			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			//Cargo los datos en la funcion
			return  ConexionAccess2007.Source ;		
		}
		
		public static BindingSource FuenteObtenerClientes()
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("Clientes", "Nombre", "Nombre","Activo = TRUE");
			
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			//Cargo los datos en la funcion
			return  ConexionAccess2007.Source ;		
			
		}
		
		
		
		
		
		public static BindingSource FuenteObtenerRecibosHechos(DateTime dtFechaInicio, DateTime dtFechaFinal)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta segun criterio
			//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
			ConexionAccess2007.Consultar("Recibo", 
			                             "*", 
			                             "Fecha >= #" + dtFechaInicio.ToString("MM/dd/yyyy")  + "# AND Fecha <= #" + dtFechaFinal.ToString("MM/dd/yyyy")  +"#",
			                             "NumRecibo");

			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			//Cargo los datos en el grid
			return  ConexionAccess2007.Source;
			 
			
		}

#region VENTASANUALES


		
		public static BindingSource FuenteObtenerVentasAnuales(int intFechaInicio)
		{
		
		/*
		  * Hacer una funcion que recorra los productos y cargue cuanto se vendio por año
		  * Al empezar tendria que sacar los datos de cada una de las FC hechas
		  * pero despues voy a implementar que cada item de cada factura se guarde en una base de datos
		  * de esta manera es mas rapido este proceso y ademas liberaria y flexibilizaria mucho la tabla
		  * de FACTURAS
		  * Por ahora seran for´s para hacerlo
		  */
		
		 
		  System.Data.DataTable TablaFacturas;
		  System.Data.DataTable TablaMercaderia;
		 
		  BindingSource fuente = new BindingSource();
		 
		 //CONEXION
		 
			 //FACTURAS
			 
			 /*
			   * Primero busco las facturas del año en cuenstion
			   * y las guardo en una tabla
			   * 
			   * */
			
				//Conecta a la Base de datos segun ruta guardada
				ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
				
				//Hace la consulta segun criterio
				//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
				ConexionAccess2007.Consultar("Facturas", 
				                             "*", 
				                             "Fecha >= #1/1/" + (intFechaInicio) +"# AND Fecha<= #31/12/" + (intFechaInicio) +"#" ,
				                             "Documento");
	
				TablaFacturas = ConexionAccess2007.Table;  
				
				//Desconecto para no tener problemas
				ConexionAccess2007.Desconectar ();
	
			
			
			//MERCADERIA
			
			/*
			  * Luego busco la mercadería y tambien la guardo en una tabla
			  * 
			  * */
			
		
				//Conecta a la Base de datos segun ruta guardada
				ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseTrazabilidad"].ToString());
				
				//Hace la consulta segun criterio
				//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
				ConexionAccess2007.Consultar("Mercaderia", 
				                             "Nombre", 
				                             "Nombre");
	
				TablaMercaderia = ConexionAccess2007.Table; 
				
				
				
				//Desconecto para no tener problemas
				ConexionAccess2007.Desconectar ();
	
		
		
				
		//ARRAY
				
				/*
				  * Creo un array bidimensional que coloque la mercaderia en el primer item y que cuente en la tabla de facturas cuantas hay.
				  * Despues paso a la segunda y asi sucesivamente
				  * 
				  * 
				  * 
				  * 
				  * 
				  * */
				 
				 //Array multidimensional [Fila, Columna]
				 
				 string[,] ventas;
				 
				 
				 //Dimensiono el array como de dos columnas y la cantidad de datos que tenga la tabla de Mercaderia
				 ventas = new string[TablaMercaderia.Rows.Count-1,2];

				
			
				 
				 
				 
				//Recorro los items de la tabla de mercaderia 
				 for (int i = 0; i < TablaMercaderia.Rows.Count-1; i++)
				{
					
				 	//Asigno a la primera columna, la mercaderia
				 	ventas[i,0] = TablaMercaderia.Rows[i].ItemArray[0].ToString();
					
				 int ventasanuales = 0;	
					 
				 
				 //TODO: Cuando cambie la BD hay que mejorar esto
				//Detalle1
				DataRow[] respuesta =  TablaFacturas.Select("Detalle1 = '" + TablaMercaderia.Rows[i].ItemArray[0].ToString()+ "'") ;
				
				
				for (int j = 0; j < respuesta.Length -1; j++) {
					//Esto carga las cantidades del producto en la variable
					ventasanuales += Convert.ToInt16 (respuesta[j]["Cant1"].ToString());
				}
				
				//Detalle2
				respuesta =  TablaFacturas.Select("Detalle2 = '" + TablaMercaderia.Rows[i].ItemArray[0].ToString()+ "'") ;
				
				
				for (int j = 0; j < respuesta.Length -1; j++) {
					//Esto carga las cantidades del producto en la variable
					ventasanuales += Convert.ToInt16 (respuesta[j]["Cant2"].ToString());
				}
				
				//Detalle3
				respuesta =  TablaFacturas.Select("Detalle3 = '" + TablaMercaderia.Rows[i].ItemArray[0].ToString()+ "'") ;
				
				
				for (int j = 0; j < respuesta.Length -1; j++) {
					//Esto carga las cantidades del producto en la variable
					ventasanuales += Convert.ToInt16 (respuesta[j]["Cant3"].ToString());
				}
				
				
				//Detalle4
				respuesta =  TablaFacturas.Select("Detalle4 = '" + TablaMercaderia.Rows[i].ItemArray[0].ToString()+ "'") ;
				
				
				for (int j = 0; j < respuesta.Length -1; j++) {
					//Esto carga las cantidades del producto en la variable
					ventasanuales += Convert.ToInt16 (respuesta[j]["Cant4"].ToString());
				}
				
				//Detalle5
				respuesta =  TablaFacturas.Select("Detalle5 = '" + TablaMercaderia.Rows[i].ItemArray[0].ToString()+ "'") ;
				
				
				for (int j = 0; j < respuesta.Length -1; j++) {
					//Esto carga las cantidades del producto en la variable
					ventasanuales += Convert.ToInt16 (respuesta[j]["Cant5"].ToString());
				}
				
				
				//Usando la mercaderia recorro la tabla de facturas hechas para ver cuanto se vendio de eso y lo retorno como un valor numerico
				 	ventas[i,1] = ventasanuales.ToString();
			
				}				 
				 
		//CARGAR EL ARRAY EN UN GRID
		
				/*
				  * Buscar la manera de que el array creado se pase a un grid
				  * 
				  * */
				
				 //ventas[1,1] = "Juanqui";


				 
			
            
            fuente.DataSource = TablaConvertirArrayEnTabla(ventas);

            return  fuente; 
				

				
		}
		
	/*	public static int CuantoVendimos(string mercaderia, DataTable tbFacturas)
		{
		
			
			
			             
		}*/
			
	
	
		
		
		
		
		
		public static DataTable TablaConvertirArrayEnTabla(string[,] MiArray)
		{
		/*
		  * Codigo cedido por "scalt"
		  * extraido de http://www.dreamincode.net/forums/topic/85368-c%23-convert-object-array-into-datatable/
		  * Mejorado por Juanqui
		  * */
			
			
			System.Data.DataTable dt = new DataTable("Ventas");

            //assume yourArray is in row,col format
            //generate a column for each 'column' in your array
           for (int i = 0; i < MiArray.GetLength(1); i++) //antes tenia valor 1
            {
                //create a new column whose name is its index, and of type 'string'
                dt.Columns.Add(i.ToString(), typeof(String)); // Type.GetType("System.object"));
            }

            //for each 'row' in your array
            for (int j = 0; j < MiArray.GetUpperBound(0); j++)
            {
                object[] row = new object[MiArray.GetLength(1)]; //MiArray.GetUpperBound(1)];

                //get the value for each column in that row and write it into a 1-d array
                for (int k = 0; k < row.Length; k++)
                {
                    row[k] = MiArray[j, k];
                }

                //write that array into your datatable
                dt.Rows.Add(row);
            }
				
            
            return dt;
            
		}
		
#endregion		
		
#region PEDIDOS
		
		public static BindingSource FuenteObtenerPedidosPendientes()
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("Pedidos", "NumPedido, Fecha, Nombre","Cancelado = FALSE", "NumPedido");
			
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			//Cargo los datos en la funcion
			return  ConexionAccess2007.Source ;		
			
		}
		
		public static BindingSource FuenteObtenerDatosPedidos(int NumPedido)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("Pedidos", 
			                             "Cant1, Partida1, Detalle1, " +
			                             "Cant2, Partida2, Detalle2, " + 
			                             "Cant3, Partida3, Detalle3, " + 
			                             "Cant4, Partida4, Detalle4, " + 
			                             "Cant5, Partida5, Detalle5",
			                             "Numpedido = " + NumPedido , "NumPedido");
	
/*
NumPedido
Fecha
Nombre
Cant1
Partida1
Detalle1
Cant2
Partida2
Detalle2
Cant3
Partida3
Detalle3
Cant4
Partida4
Detalle4
Cant5
Partida5
Detalle5
Cant6
Partida6
Detalle6
HechoPor
Cancelado
FechaEntrega
Notas
*/
			
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			//Cargo los datos en la funcion
			return  ConexionAccess2007.Source ;		
			
		}
#endregion
		
#region REMITOS


		/// <summary>
		/// Funcion sobrecargada de guardar con una estructura de remito
		/// </summary>
		/// <param name="vpRemi"></param>
		public static void Guardar(VariablesPropias.VariablesPropias.vpRemito vpRemi)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			



			try
			 {
							//Guardo los datos dentro de la tabla
			ConexionAccess2007.InsertarFila("Remitos", 
			                                "NumRemito, Fecha, " + 
			                                "IDCliente, Nombre, Direccion, CUIT, " +
		                                	"SucFactura, NumFactura, " + 
			                                "TranspNombre, TranspDireccion, " + 
				                             //"IVARespIns, IVARespNoIns, IVARegMono, IVANoResp, IVAExento, IVAConsFinal,"	+
											"IDProdu1, Cant1, Deatalle1, Precio1, " + 
											"IDProdu2, Cant2, Deatalle2, Precio2, " + 
											"IDProdu3, Cant3, Deatalle3, Precio3, " + 	
											"IDProdu4, Cant4, Deatalle4, Precio4, " + 
											"IDProdu5, Cant5, Deatalle5, Precio5, " + 
											"ValorDeclarado, Notas" , +


											//CLIENTE
											vpRemi.dblNumRemi + ", "+ 
											"'" + vpRemi.dtFecha.ToShortDateString() + "', " +
											"'" + vpRemi.Cliente.strid + "', " +
											"'" + vpRemi.Cliente.strNombre + "', " +
											"'" + vpRemi.Cliente.strDireccion + "', " +
											vpRemi.Cliente.dblCUIT + ", " +
											
											//Factura
											"0, " + //Sucursal de la factura
											"0, " + //Numero de la factura
											
											//TRANSPOTE
											"'" + vpRemi.Transporte.strNombre + "', '" +
											vpRemi.Transporte.strDireccion + "', '" +
											
											
											//PRODUCTOS
											vpRemi.Producto1.strid + "', " +
											vpRemi.Producto1.intCantidad + ", '" + 
											vpRemi.Producto1.strDescripcion+ "', " +
											vpRemi.Producto1.curPrecioNeto.ToString().Replace(",",".") + ", '" +
											
											vpRemi.Producto2.strid + "', " +
											vpRemi.Producto2.intCantidad + ", '" + 
											vpRemi.Producto2.strDescripcion + "', " +
											vpRemi.Producto2.curPrecioNeto.ToString().Replace(",",".") + ", '" +
											
											vpRemi.Producto3.strid + "', " +
											vpRemi.Producto3.intCantidad + ", '" + 
											vpRemi.Producto3.strDescripcion + "', " +
											vpRemi.Producto3.curPrecioNeto.ToString().Replace(",",".") + ", '" +
											
											vpRemi.Producto4.strid + "', " +
											vpRemi.Producto4.intCantidad + ", '" + 
											vpRemi.Producto4.strDescripcion + "', " +
											vpRemi.Producto4.curPrecioNeto.ToString().Replace(",",".") + ", '" +
											
											vpRemi.Producto5.strid + "', " +
											vpRemi.Producto5.intCantidad + ", '" + 
											vpRemi.Producto5.strDescripcion + "', " +
											vpRemi.Producto5.curPrecioNeto.ToString().Replace(",",".") + ", " +
											
											
											//OTROS VALORES
												
											vpRemi.curTotal.ToString().Replace(",",".") + ", '" +
											vpRemi.strNota + "'");

							
				MessageBox.Show ("Registro guardado", "Guardado");
				
				
			}
			catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
			
			//Cerrar la conexion
            ConexionAccess2007.Desconectar();
            
		}
		
		///<summary>
		/// Obtiene el precio de la mercaderia
		/// </summary>
		/// <param>
		/// IDMercaderia es el identificador de la mercaderia
		/// </param>
		public static string  ObtenerPrecioMercaderia (string IDMercaderia)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta de un ID del stock especificamente.
			//TODO REVISAR POR QUE NO DA BIEN
			ConexionAccess2007.Consultar("Stock", "ID, Precio","ID = '" + IDMercaderia + "'", "ID" );
			
			
			try {
				//Desconecto para no tener problemas
				ConexionAccess2007.Desconectar ();
				
				//Cargo los datos en la funcion
				return  ConexionAccess2007.Table.Rows[0].ItemArray[1].ToString();
				
			} catch (Exception e) {
				MessageBox.Show(e.Message);
				
				//Desconecto para no tener problemas
				ConexionAccess2007.Desconectar ();
				
				return "0";
				//throw;
			}
			
			
		}
		
/// <summary>
/// Esta funcion obtiene todos los parametros del CAI dado un numero de remito
/// </summary>
/// <param name="NumRemito"> El numero del remito para obtenr un CAI</param>
		public static VariablesPropias.VariablesPropias.vpCAIRemito CargarElCAI(string NumRemito)
		{
		
			//Esto arma una nueva variable propia
            VariablesPropias.VariablesPropias.vpCAIRemito CAIRemito = new VariablesPropias.VariablesPropias.vpCAIRemito();
			
			//Conecta a la base de datos
            ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseCAI"].ToString());

			//Consulta
            ConexionAccess2007.Consultar("CAIRemitos", "*", "Desde");
			
            //Nueva Tabla
            DataTable Remito = new DataTable();
 			//Cargo la tabla con los datos de la Base de Datos
            Remito = ConexionAccess2007.Table;

			
            
            for (int i = 0; i < Remito.Rows.Count ; i++)
            {
            	//Acá recorre toda la tabla hasta que encuentra el valor que concuerda
            	
            	if (Convert.ToInt32 (Remito.Rows[i]["Desde"].ToString()) <= Convert.ToInt32 (NumRemito) ) 
            	{
            		//Aca se filta por "DESDE"
            		
            		if (Convert.ToInt32 (Remito.Rows[i]["Hasta"].ToString()) >= Convert.ToInt32 (NumRemito) ) 
            		{
            			
            			//Aqui ya esta completamente filtrado y sabemos que registro es
            			
            			
            			//Cargo los datos en cada una de las variables de la estructura
            			
			        	CAIRemito.strCAI  = Remito.Rows[i]["CAI"].ToString();
			        	CAIRemito.strFechaVenc  = Remito.Rows[i]["FechaVto"].ToString();
			        	CAIRemito.strFechaImpresion = Remito.Rows[i]["FechaImpresion"].ToString();
			        
			
						//Desde aca para abajo todo es hecho con los datos del 
			        	
			        	DateTime dtFechaVto = Convert.ToDateTime(CAIRemito.strFechaVenc);
			        	
			        	string strCodigoCargar = "30708466200" + "91" + "0001" + CAIRemito.strCAI + dtFechaVto.ToString("yyyy")
			        							+ dtFechaVto.ToString("MM") + dtFechaVto.ToString("dd");
			        		
			    		strCodigoCargar = strCodigoCargar + CodigoBarras.CalcCheckSum(strCodigoCargar);
			        		
			        	CAIRemito.strCodigoACargar = strCodigoCargar;
			        			
            		}
            		
            	}	


                                            	
            }
            
            
		
			 //Cerrar la conexion
            ConexionAccess2007.Desconectar();
            
            
            return CAIRemito; 
		}
		
		
/// <summary>
/// Obtiene el ultimo remito hecho
/// </summary>
/// <returns>Integer con el numero del utltimo remito </returns>
		public static int ObtenerUltimoRemito()
		{
		
			//Conexion con la base de datos en Manolito
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
	
			//Consulta
	        ConexionAccess2007.Consultar("Remitos", "*", "NumRemito");
			
	        //Nueva Tabla
	        DataTable Remito = new DataTable();
			
	        //Cargo la tabla con los datos de la Base de Datos
	        Remito = ConexionAccess2007.Table;
	
			//Carga el numero de remito 				
			int i = Convert.ToInt32 ( Remito.Rows[Convert.ToInt32 (Remito.Rows.Count) - 1 ]["NumRemito"]) + 1;
		
			 //Cerrar la conexion
	        ConexionAccess2007.Desconectar();
	        
       	 	return i;
		}		
		
		
		
		
		
		#endregion
		
#region  FACTURAS
		
		/// <summary>
		/// Obtiene la ultima factura hecha
		/// </summary>
		/// <returns>Integer con el numero de la utltima factura </returns>
		public static int ObtenerUltimaFactura(int sucursal, int intTipoFc)
		{
		
			//Conexion con la base de datos en Manolito
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
	
			switch (intTipoFc) {
				case 1://FC A
					//Consulta
	        		ConexionAccess2007.Consultar("Facturas", "NumFact", "Sucursal =" + sucursal,  "NumFact");
					break;
				case 6://FC B
					//Consulta
	        		ConexionAccess2007.Consultar("FacturasB", "NumFact", "Sucursal =" + sucursal,  "NumFact");
					break;
				case 2://ND
					//Consulta
	        		ConexionAccess2007.Consultar("NotaDebito", "NumFact", "Sucursal =" + sucursal,  "NumFact");
					break;
				case 3://NC
					//Consulta
	        		ConexionAccess2007.Consultar("NotaCredito", "NumFact", "Sucursal =" + sucursal,  "NumFact");
					break;
			}
			
			
			
	        //Nueva Tabla
	        DataTable Remito = new DataTable();
			
	        //Cargo la tabla con los datos de la Base de Datos
	        Remito = ConexionAccess2007.Table;
	
			//Carga el numero de remito 				
			int i = Convert.ToInt32 ( Remito.Rows[Convert.ToInt32 (Remito.Rows.Count) - 1 ]["NumFact"]) + 1;
		
			 //Cerrar la conexion
	        ConexionAccess2007.Desconectar();
	        
       	 	return i;
		}		
		
		
		public static void Guardar( VariablesPropias.VariablesPropias.vpFactura vpfactura)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			
switch (Convert.ToInt32 (vpfactura.strCodFc))
            {
                case 1: //Factura A
 #region FACTURA A
try
			 {
			
				//Guardo los datos dentro de la tabla
			ConexionAccess2007.InsertarFila("Facturas", 
			                                "Documento, " + 
											"Sucursal, NumFact, Fecha, " + 
											"IDCliente, Nombre, Direccion, Localidad, Provincia, " + 
											"Tipodecambio, Descuento, " + 
											"Cant1, Detalle1, PrecioUnitario1, PrecioFinal1, " + 
											"Cant2, Detalle2, PrecioUnitario2, PrecioFinal2, " + 
											"Cant3, Detalle3, PrecioUnitario3, PrecioFinal3, " + 
											"Cant4, Detalle4, PrecioUnitario4, PrecioFinal4, " + 
											"Cant5, Detalle5, PrecioUnitario5, PrecioFinal5, " + 
											//"Cant6, Detalle6, PrecioUnitario6, PrecioFinal6, " + 
											"SubTotal, IVA, ImporteFinal, " + 
											"Recibo1, Recibo2, Recibo3, Recibo4, Recibo5, " + 
											//"ClienteDe, " + 
											"Remito1, Remito2, Remito3, Remito4, Remito5, " + 
											//"Observaciones, " + 
											"SubTotalUSS, IVAUSS, ImporteFinalUSS, EnDolar, Saldo, SaldoUSS, " + 
											//"Pagado, Dólar, Peso, Promocion, " + 
											"CAE, FechaVencCAE",  


											"'"+ vpfactura.strComprobante + "',"	+
											vpfactura.intSucursal.ToString()  + ", " + vpfactura.dblNumFact + "," +
											"'" + vpfactura.dtFecha.ToShortDateString() + "'," +
											
											//CLIENTE
											//"IDCliente, Nombre, Direccion, Localidad, Provincia, " + 	
											"'" + vpfactura.Cliente.strid  + "', "+ 
											"'" + vpfactura.Cliente.strNombre  + "', "+
											"'" + vpfactura.Cliente.strDireccion  + "', "+
											"'" + vpfactura.Cliente.strLocalidad  + "', "+
											"'" + vpfactura.Cliente.strProvincia  + "', "+
												
											//"Tipodecambio, Descuento, " +
																							
											vpfactura.dblTipoCambio.ToString().Replace(",",".")  + ", "+	
											vpfactura.Cliente.dblDescuento  + ", "+
												
												
											/*
											"Cant1, Detalle1, PrecioUnitario1, PrecioFinal1, " + 
											"Cant2, Detalle2, PrecioUnitario2, PrecioFinal2, " + 
											"Cant3, Detalle3, PrecioUnitario3, PrecioFinal3, " + 
											"Cant4, Detalle4, PrecioUnitario4, PrecioFinal4, " + 
											"Cant5, Detalle5, PrecioUnitario5, PrecioFinal5, " + 
											"Cant6, Detalle6, PrecioUnitario6, PrecioFinal6, " + 
											*/
//TODO hacer esto en un array  y pasarlo para despues cuando ya haya guardado la FC basica												
											vpfactura.Productos[0].intCantidad + ", "+
											"'" + vpfactura.Productos[0].strDescripcion + "', "+
											vpfactura.Productos[0].curPrecioNeto.ToString().Replace(",",".") + ", "+
											vpfactura.Productos[0].curPrecioTotal.ToString().Replace(",",".") + ", "+
												
											
											vpfactura.Productos[1].intCantidad + ", "+
											"'" + vpfactura.Productos[1].strDescripcion + "', "+
											vpfactura.Productos[1].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[1].curPrecioTotal.ToString().Replace(",",".") + ", "+	
																							
											

											vpfactura.Productos[2].intCantidad + ", "+	
											"'" + vpfactura.Productos[2].strDescripcion + "', "+
											vpfactura.Productos[2].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[2].curPrecioTotal.ToString().Replace(",",".") + ", "+													

											vpfactura.Productos[3].intCantidad + ", "+	
											"'" + vpfactura.Productos[3].strDescripcion + "', "+
											vpfactura.Productos[3].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[3].curPrecioTotal.ToString().Replace(",",".") + ", "+													

											vpfactura.Productos[4].intCantidad + ", "+	
											"'" + vpfactura.Productos[4].strDescripcion + "', "+
											vpfactura.Productos[4].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[4].curPrecioTotal.ToString().Replace(",",".") + ", "+													
																					
											//"SubTotal, IVA, ImporteFinal, " + 

											vpfactura.curSubTotal.ToString().Replace(",",".") + ", " +	
											vpfactura.curIVA.ToString().Replace(",",".") + ", " +													
											vpfactura.curTotal.ToString().Replace(",",".") + ", " +	
												
											
											//"Recibo1, Recibo2, Recibo3, Recibo4, Recibo5, " +
											"0, 0, 0, 0, 0, "+
											
											//"ClienteDe, " + 
											
											//"'" + vpfactura.Cliente. + ", "+

//TODO Esto tambien va a un array
											
											//"Remito1, Remito2, Remito3, Remito4, Remito5, " + 
											vpfactura.intRemito1 + ", " +	
											vpfactura.intRemito2 + ", " +	
											vpfactura.intRemito3 + ", " +	
											vpfactura.intRemito4 + ", " +
											"0"	+ ", " +										
		
											
											//"Observaciones, " +
											//vpfactura.
											
											//"SubTotalUSS, IVAUSS, ImporteFinalUSS, EnDolar, Saldo, SaldoUSS, " + 
											vpfactura.curSubTotalUSD.ToString().Replace(",",".") + ", " +
											vpfactura.curIVAUSD.ToString().Replace(",",".")  + ", " +
											vpfactura.curTotalUSD.ToString().Replace(",",".")  + ", " +
											vpfactura.curTotalUSD.ToString().Replace(",",".")  + ", " +
											vpfactura.curTotal.ToString().Replace(",",".") + ", " +
											vpfactura.curTotalUSD.ToString().Replace(",",".") + ", " +
											
											
											//"CAE, FechaVencCAE", + 
											"'" + vpfactura.strCAE + "', " +
											"'" + vpfactura.strFechVtoCAE + "'" 
											
											);

							
						MessageBox.Show ("Registro guardado", "Guardado");

		
			}
			catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
#endregion                   
                    break;
                case 6: //Factura B
 #region FACTURA B
try
			 {
			
				//Guardo los datos dentro de la tabla
			ConexionAccess2007.InsertarFila("FacturasB", 
			                                "Documento, " + 
											"Sucursal, NumFact, Fecha, " + 
											"IDCliente, Nombre, Direccion, Localidad, Provincia, " + 
											"Tipodecambio, Descuento, " + 
											"Cant1, Detalle1, PrecioUnitario1, PrecioFinal1, " + 
											"Cant2, Detalle2, PrecioUnitario2, PrecioFinal2, " + 
											"Cant3, Detalle3, PrecioUnitario3, PrecioFinal3, " + 
											"Cant4, Detalle4, PrecioUnitario4, PrecioFinal4, " + 
											"Cant5, Detalle5, PrecioUnitario5, PrecioFinal5, " + 
											//"Cant6, Detalle6, PrecioUnitario6, PrecioFinal6, " + 
											"SubTotal, IVA, ImporteFinal, " + 
											"Recibo1, Recibo2, Recibo3, Recibo4, Recibo5, " + 
											//"ClienteDe, " + 
											"Remito1, Remito2, Remito3, Remito4, Remito5, " + 
											//"Observaciones, " + 
											"SubTotalUSS, IVAUSS, ImporteFinalUSS, EnDolar, Saldo, SaldoUSS, " + 
											//"Pagado, Dólar, Peso, Promocion, " + 
											"CAE, FechaVencCAE",  


											"'"+ vpfactura.strComprobante + "',"	+
											vpfactura.intSucursal.ToString()  + ", " + vpfactura.dblNumFact + "," +
											"'" + vpfactura.dtFecha.ToShortDateString() + "'," +
											
											//CLIENTE
											//"IDCliente, Nombre, Direccion, Localidad, Provincia, " + 	
											"'" + vpfactura.Cliente.strid  + "', "+ 
											"'" + vpfactura.Cliente.strNombre  + "', "+
											"'" + vpfactura.Cliente.strDireccion  + "', "+
											"'" + vpfactura.Cliente.strLocalidad  + "', "+
											"'" + vpfactura.Cliente.strProvincia  + "', "+
												
											//"Tipodecambio, Descuento, " +
																							
											vpfactura.dblTipoCambio.ToString().Replace(",",".")  + ", "+	
											vpfactura.Cliente.dblDescuento  + ", "+
												
												
											/*
											"Cant1, Detalle1, PrecioUnitario1, PrecioFinal1, " + 
											"Cant2, Detalle2, PrecioUnitario2, PrecioFinal2, " + 
											"Cant3, Detalle3, PrecioUnitario3, PrecioFinal3, " + 
											"Cant4, Detalle4, PrecioUnitario4, PrecioFinal4, " + 
											"Cant5, Detalle5, PrecioUnitario5, PrecioFinal5, " + 
											"Cant6, Detalle6, PrecioUnitario6, PrecioFinal6, " + 
											*/
//TODO hacer esto en un array  y pasarlo para despues cuando ya haya guardado la FC basica												
											vpfactura.Productos[0].intCantidad + ", "+
											"'" + vpfactura.Productos[0].strDescripcion + "', "+
											vpfactura.Productos[0].curPrecioNeto.ToString().Replace(",",".") + ", "+
											vpfactura.Productos[0].curPrecioTotal.ToString().Replace(",",".") + ", "+
												
											
											vpfactura.Productos[1].intCantidad + ", "+
											"'" + vpfactura.Productos[1].strDescripcion + "', "+
											vpfactura.Productos[1].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[1].curPrecioTotal.ToString().Replace(",",".") + ", "+	
																							
											

											vpfactura.Productos[2].intCantidad + ", "+	
											"'" + vpfactura.Productos[2].strDescripcion + "', "+
											vpfactura.Productos[2].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[2].curPrecioTotal.ToString().Replace(",",".") + ", "+													

											vpfactura.Productos[3].intCantidad + ", "+	
											"'" + vpfactura.Productos[3].strDescripcion + "', "+
											vpfactura.Productos[3].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[3].curPrecioTotal.ToString().Replace(",",".") + ", "+													

											vpfactura.Productos[4].intCantidad + ", "+	
											"'" + vpfactura.Productos[4].strDescripcion + "', "+
											vpfactura.Productos[4].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[4].curPrecioTotal.ToString().Replace(",",".") + ", "+													
																					
											//"SubTotal, IVA, ImporteFinal, " + 

											vpfactura.curSubTotal.ToString().Replace(",",".") + ", " +	
											vpfactura.curIVA.ToString().Replace(",",".") + ", " +													
											vpfactura.curTotal.ToString().Replace(",",".") + ", " +	
												
											
											//"Recibo1, Recibo2, Recibo3, Recibo4, Recibo5, " +
											"0, 0, 0, 0, 0, "+
											
											//"ClienteDe, " + 
											
											//"'" + vpfactura.Cliente. + ", "+

//TODO Esto tambien va a un array
											
											//"Remito1, Remito2, Remito3, Remito4, Remito5, " + 
											vpfactura.intRemito1 + ", " +	
											vpfactura.intRemito2 + ", " +	
											vpfactura.intRemito3 + ", " +	
											vpfactura.intRemito4 + ", " +
											"0"	+ ", " +										
		
											
											//"Observaciones, " +
											//vpfactura.
											
											//"SubTotalUSS, IVAUSS, ImporteFinalUSS, EnDolar, Saldo, SaldoUSS, " + 
											vpfactura.curSubTotalUSD.ToString().Replace(",",".") + ", " +
											vpfactura.curIVAUSD.ToString().Replace(",",".")  + ", " +
											vpfactura.curTotalUSD.ToString().Replace(",",".")  + ", " +
											vpfactura.curTotalUSD.ToString().Replace(",",".")  + ", " +
											vpfactura.curTotal.ToString().Replace(",",".") + ", " +
											vpfactura.curTotalUSD.ToString().Replace(",",".") + ", " +
											
											
											//"CAE, FechaVencCAE", + 
											"'" + vpfactura.strCAE + "', " +
											"'" + vpfactura.strFechVtoCAE + "'" 
											
											);

							
						MessageBox.Show ("Registro guardado", "Guardado");

		
			}
			catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
#endregion                   
                    break;
                    
                case 3: //NC
#region NC
try
			 {
			
				//Guardo los datos dentro de la tabla
			ConexionAccess2007.InsertarFila("NotaCredito", 
			                                "Documento, " + 
											"Sucursal, NumFact, Fecha, " + 
											"IDCliente, Nombre, Direccion, Localidad, Provincia, " + 
											"Tipodecambio, Descuento, " + 
											"Cant1, Detalle1, PrecioUnitario1, PrecioFinal1, " + 
											"Cant2, Detalle2, PrecioUnitario2, PrecioFinal2, " + 
											"Cant3, Detalle3, PrecioUnitario3, PrecioFinal3, " + 
											"Cant4, Detalle4, PrecioUnitario4, PrecioFinal4, " + 
											"Cant5, Detalle5, PrecioUnitario5, PrecioFinal5, " + 
											//"Cant6, Detalle6, PrecioUnitario6, PrecioFinal6, " + 
											"SubTotal, IVA, ImporteFinal, " + 
											"Recibo1, Recibo2, Recibo3, Recibo4, Recibo5, " + 
											//"ClienteDe, " + 
											"Remito1, Remito2, Remito3, Remito4, Remito5, " + 
											//"Observaciones, " + 
											"SubTotalUSS, IVAUSS, ImporteFinalUSS, EnDolar, Saldo, SaldoUSS, " + 
											//"Pagado, Dólar, Peso, Promocion, " + 
											"CAE, FechaVencCAE",  


											"'"+ vpfactura.strComprobante + "',"	+
											vpfactura.intSucursal.ToString()  + ", " + vpfactura.dblNumFact + "," +
											"'" + vpfactura.dtFecha.ToShortDateString() + "'," +
											
											//CLIENTE
											//"IDCliente, Nombre, Direccion, Localidad, Provincia, " + 	
											"'" + vpfactura.Cliente.strid  + "', "+ 
											"'" + vpfactura.Cliente.strNombre  + "', "+
											"'" + vpfactura.Cliente.strDireccion  + "', "+
											"'" + vpfactura.Cliente.strLocalidad  + "', "+
											"'" + vpfactura.Cliente.strProvincia  + "', "+
												
											//"Tipodecambio, Descuento, " +
																							
											vpfactura.dblTipoCambio.ToString().Replace(",",".")  + ", "+	
											vpfactura.Cliente.dblDescuento  + ", "+
												
												
											/*
											"Cant1, Detalle1, PrecioUnitario1, PrecioFinal1, " + 
											"Cant2, Detalle2, PrecioUnitario2, PrecioFinal2, " + 
											"Cant3, Detalle3, PrecioUnitario3, PrecioFinal3, " + 
											"Cant4, Detalle4, PrecioUnitario4, PrecioFinal4, " + 
											"Cant5, Detalle5, PrecioUnitario5, PrecioFinal5, " + 
											"Cant6, Detalle6, PrecioUnitario6, PrecioFinal6, " + 
											*/
//TODO hacer esto en un array  y pasarlo para despues cuando ya haya guardado la FC basica												
											vpfactura.Productos[0].intCantidad + ", "+
											"'" + vpfactura.Productos[0].strDescripcion + "', "+
											vpfactura.Productos[0].curPrecioNeto.ToString().Replace(",",".") + ", "+
											vpfactura.Productos[0].curPrecioTotal.ToString().Replace(",",".") + ", "+
												
											
											vpfactura.Productos[1].intCantidad + ", "+
											"'" + vpfactura.Productos[1].strDescripcion + "', "+
											vpfactura.Productos[1].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[1].curPrecioTotal.ToString().Replace(",",".") + ", "+	
																							
											

											vpfactura.Productos[2].intCantidad + ", "+	
											"'" + vpfactura.Productos[2].strDescripcion + "', "+
											vpfactura.Productos[2].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[2].curPrecioTotal.ToString().Replace(",",".") + ", "+													

											vpfactura.Productos[3].intCantidad + ", "+	
											"'" + vpfactura.Productos[3].strDescripcion + "', "+
											vpfactura.Productos[3].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[3].curPrecioTotal.ToString().Replace(",",".") + ", "+													

											vpfactura.Productos[4].intCantidad + ", "+	
											"'" + vpfactura.Productos[4].strDescripcion + "', "+
											vpfactura.Productos[4].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[4].curPrecioTotal.ToString().Replace(",",".") + ", "+													
																					
											//"SubTotal, IVA, ImporteFinal, " + 

											vpfactura.curSubTotal.ToString().Replace(",",".") + ", " +	
											vpfactura.curIVA.ToString().Replace(",",".") + ", " +													
											vpfactura.curTotal.ToString().Replace(",",".") + ", " +	
												
											
											//"Recibo1, Recibo2, Recibo3, Recibo4, Recibo5, " +
											"0, 0, 0, 0, 0, "+
											
											//"ClienteDe, " + 
											
											//"'" + vpfactura.Cliente. + ", "+

//TODO Esto tambien va a un array
											
											//"Remito1, Remito2, Remito3, Remito4, Remito5, " + 
											vpfactura.intRemito1 + ", " +	
											vpfactura.intRemito2 + ", " +	
											vpfactura.intRemito3 + ", " +	
											vpfactura.intRemito4 + ", " +
											"0"	+ ", " +										
		
											
											//"Observaciones, " +
											//vpfactura.
											
											//"SubTotalUSS, IVAUSS, ImporteFinalUSS, EnDolar, Saldo, SaldoUSS, " + 
											vpfactura.curSubTotalUSD.ToString().Replace(",",".") + ", " +
											vpfactura.curIVAUSD.ToString().Replace(",",".")  + ", " +
											vpfactura.curTotalUSD.ToString().Replace(",",".")  + ", " +
											vpfactura.curTotalUSD.ToString().Replace(",",".")  + ", " +
											vpfactura.curTotal.ToString().Replace(",",".") + ", " +
											vpfactura.curTotalUSD.ToString().Replace(",",".") + ", " +
											
											
											//"CAE, FechaVencCAE", + 
											"'" + vpfactura.strCAE + "', " +
											"'" + vpfactura.strFechVtoCAE + "'" 
											
											);

							
						MessageBox.Show ("Registro guardado", "Guardado");

		
			}
			catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
#endregion                    
                    break;

				case 2: //ND
 #region  ND
try
			 {
			
				//Guardo los datos dentro de la tabla
			ConexionAccess2007.InsertarFila("NotaDebito", 
			                                "Documento, " + 
											"Sucursal, NumFact, Fecha, " + 
											"IDCliente, Nombre, Direccion, Localidad, Provincia, " + 
											"Tipodecambio, Descuento, " + 
											"Cant1, Detalle1, PrecioUnitario1, PrecioFinal1, " + 
											"Cant2, Detalle2, PrecioUnitario2, PrecioFinal2, " + 
											"Cant3, Detalle3, PrecioUnitario3, PrecioFinal3, " + 
											"Cant4, Detalle4, PrecioUnitario4, PrecioFinal4, " + 
											"Cant5, Detalle5, PrecioUnitario5, PrecioFinal5, " + 
											//"Cant6, Detalle6, PrecioUnitario6, PrecioFinal6, " + 
											"SubTotal, IVA, ImporteFinal, " + 
											"Recibo1, Recibo2, Recibo3, Recibo4, Recibo5, " + 
											//"ClienteDe, " + 
											"Remito1, Remito2, Remito3, Remito4, Remito5, " + 
											//"Observaciones, " + 
											"SubTotalUSS, IVAUSS, ImporteFinalUSS, EnDolar, Saldo, SaldoUSS, " + 
											//"Pagado, Dólar, Peso, Promocion, " + 
											"CAE, FechaVencCAE",  


											"'"+ vpfactura.strComprobante + "',"	+
											vpfactura.intSucursal.ToString()  + ", " + vpfactura.dblNumFact + "," +
											"'" + vpfactura.dtFecha.ToShortDateString() + "'," +
											
											//CLIENTE
											//"IDCliente, Nombre, Direccion, Localidad, Provincia, " + 	
											"'" + vpfactura.Cliente.strid  + "', "+ 
											"'" + vpfactura.Cliente.strNombre  + "', "+
											"'" + vpfactura.Cliente.strDireccion  + "', "+
											"'" + vpfactura.Cliente.strLocalidad  + "', "+
											"'" + vpfactura.Cliente.strProvincia  + "', "+
												
											//"Tipodecambio, Descuento, " +
																							
											vpfactura.dblTipoCambio.ToString().Replace(",",".")  + ", "+	
											vpfactura.Cliente.dblDescuento  + ", "+
												
												
											/*
											"Cant1, Detalle1, PrecioUnitario1, PrecioFinal1, " + 
											"Cant2, Detalle2, PrecioUnitario2, PrecioFinal2, " + 
											"Cant3, Detalle3, PrecioUnitario3, PrecioFinal3, " + 
											"Cant4, Detalle4, PrecioUnitario4, PrecioFinal4, " + 
											"Cant5, Detalle5, PrecioUnitario5, PrecioFinal5, " + 
											"Cant6, Detalle6, PrecioUnitario6, PrecioFinal6, " + 
											*/
//TODO hacer esto en un array  y pasarlo para despues cuando ya haya guardado la FC basica												
											vpfactura.Productos[0].intCantidad + ", "+
											"'" + vpfactura.Productos[0].strDescripcion + "', "+
											vpfactura.Productos[0].curPrecioNeto.ToString().Replace(",",".") + ", "+
											vpfactura.Productos[0].curPrecioTotal.ToString().Replace(",",".") + ", "+
												
											
											vpfactura.Productos[1].intCantidad + ", "+
											"'" + vpfactura.Productos[1].strDescripcion + "', "+
											vpfactura.Productos[1].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[1].curPrecioTotal.ToString().Replace(",",".") + ", "+	
																							
											

											vpfactura.Productos[2].intCantidad + ", "+	
											"'" + vpfactura.Productos[2].strDescripcion + "', "+
											vpfactura.Productos[2].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[2].curPrecioTotal.ToString().Replace(",",".") + ", "+													

											vpfactura.Productos[3].intCantidad + ", "+	
											"'" + vpfactura.Productos[3].strDescripcion + "', "+
											vpfactura.Productos[3].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[3].curPrecioTotal.ToString().Replace(",",".") + ", "+													

											vpfactura.Productos[4].intCantidad + ", "+	
											"'" + vpfactura.Productos[4].strDescripcion + "', "+
											vpfactura.Productos[4].curPrecioNeto.ToString().Replace(",",".") + ", "+	
											vpfactura.Productos[4].curPrecioTotal.ToString().Replace(",",".") + ", "+													
																					
											//"SubTotal, IVA, ImporteFinal, " + 

											vpfactura.curSubTotal.ToString().Replace(",",".") + ", " +	
											vpfactura.curIVA.ToString().Replace(",",".") + ", " +													
											vpfactura.curTotal.ToString().Replace(",",".") + ", " +	
												
											
											//"Recibo1, Recibo2, Recibo3, Recibo4, Recibo5, " +
											"0, 0, 0, 0, 0, "+
											
											//"ClienteDe, " + 
											
											//"'" + vpfactura.Cliente. + ", "+

//TODO Esto tambien va a un array
											
											//"Remito1, Remito2, Remito3, Remito4, Remito5, " + 
											vpfactura.intRemito1 + ", " +	
											vpfactura.intRemito2 + ", " +	
											vpfactura.intRemito3 + ", " +	
											vpfactura.intRemito4 + ", " +
											"0"	+ ", " +										
		
											
											//"Observaciones, " +
											//vpfactura.
											
											//"SubTotalUSS, IVAUSS, ImporteFinalUSS, EnDolar, Saldo, SaldoUSS, " + 
											vpfactura.curSubTotalUSD.ToString().Replace(",",".") + ", " +
											vpfactura.curIVAUSD.ToString().Replace(",",".")  + ", " +
											vpfactura.curTotalUSD.ToString().Replace(",",".")  + ", " +
											vpfactura.curTotalUSD.ToString().Replace(",",".")  + ", " +
											vpfactura.curTotal.ToString().Replace(",",".") + ", " +
											vpfactura.curTotalUSD.ToString().Replace(",",".") + ", " +
											
											
											//"CAE, FechaVencCAE", + 
											"'" + vpfactura.strCAE + "', " +
											"'" + vpfactura.strFechVtoCAE + "'" 
											
											);

							
						MessageBox.Show ("Registro guardado", "Guardado");

		
			}
			catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
#endregion                   
                    break;                    
                    
                    
                    
                //default:
                //	lblCod_cbe.Text
				//	break;
		}
			

			
			
			//Cerrar la conexion
            ConexionAccess2007.Desconectar();
            
		}
		
		
		
		/// <summary>
/// Obtiene los remitos disponibles de un cliente
/// </summary>
/// <returns>Tabla con los Remitos disponibles de un cliente </returns>
		public static BindingSource ObtenerRemitosActivos(string IdCliente)
		{
		
			//Conexion con la base de datos en Manolito
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
	
			//Consulta
	        ConexionAccess2007.Consultar("Remitos", "*", "IDCliente ='"+ IdCliente + "' AND NumFactura = 0" , "NumRemito");
			
	        //Nueva Tabla
	        BindingSource Remito = new BindingSource();
			
	        //Cargo la tabla con los datos de la Base de Datos
	        Remito = ConexionAccess2007.Source;
	
					
			 //Cerrar la conexion
	        ConexionAccess2007.Desconectar();
	        
       	 	return Remito;
		}		
		
		
		
		
		
		
		
		
		
		
		#endregion
		
#region CLIENTES


/*
ID
Nombre
Direccion
Localidad
Provincia
Telefono1
Telefono2
Fax
Email
Contacto1
Contacto2
Contacto3
CodPos
CUIT
Desc
TranspId
ClienteDe
Activo
NroGIS
Calidad
Info
GLN

 */



		/// <summary>
		/// 
		/// </summary>
		/// <param name="IDCliente"></param>
		/// <returns></returns>
		public static string  ObtenerClieDescuento (string IDCliente)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("Clientes", "ID, Desc", "ID =" + IDCliente  ,"ID" );
			
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			//Cargo los datos en la funcion
			return  ConexionAccess2007.Table.Rows[0].ItemArray[1].ToString();
				
			
		}
		
/// <summary>
		/// Funcion sobrecargada depende de la variable que se le entrega es lo que hace.
		/// </summary>
		///<param name = "DatosInsertar"> Guarda un nuevo cliente</param>		
		public static void  Guardar (VariablesPropias.VariablesPropias.vpClientes  DatosInsertar)
		{
		
			//Esta funcion conecta con la base de datos a trabajar
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseCheques"].ToString());
			
			
			//Comando para ingresar los datos
			ConexionAccess2007.InsertarFila("Clientes",
			"ID, Nombre, Direccion, Localidad, Provincia, " +
			"Telefono1, Telefono2, Fax, " +
			"Email, Contacto1, Contacto2, Contacto3, " +
			"CodPos, CUIT, Desc, TranspId, ClienteDe, " +
			"Activo, NroGIS, Calidad, Info, GLN",
			"'" + DatosInsertar.strid.Trim() + "', " +
			"'" + DatosInsertar.strNombre.Trim() + "', " +
			"'" + DatosInsertar.strDireccion.Trim() + "', " +
			"'" + DatosInsertar.strLocalidad.Trim() + "', " +
			"'" + DatosInsertar.strProvincia.Trim() + "', " +
			"'" + DatosInsertar.strTelefono1.Trim() + "', " +
			"'" + DatosInsertar.strTelefono2.Trim() + "', " +
			"'" + DatosInsertar.strTelefono3.Trim() + "', " +
			"'" + DatosInsertar.stremail.Trim() + "', " +
			"'" + DatosInsertar.Contactos[0].strNombre.Trim() + "', " +
			"'" + DatosInsertar.Contactos[1].strNombre.Trim() + "', " +
			"'" + DatosInsertar.Contactos[3].strNombre.Trim() + "', " +
			"'" + DatosInsertar.strCodPos.Trim() + "', " +
			"" + DatosInsertar.dblCUIT + ", " +
			"" + DatosInsertar.dblDescuento + ", " +
			"" + DatosInsertar.Transporte.intTranspId + ", " +
			"'" + DatosInsertar.strClienteDe.Trim() + "', " +
			"'" + DatosInsertar.bolActivo + "', " +
			
			"'" + DatosInsertar..Trim() + "', " +
			"'" + DatosInsertar.memoVarios.Trim() + "', " +
			"'" + DatosInsertar.GLN.Trim() + "'");
						
									
			//Desconectar la base de datos
			ConexionAccess2007.Desconectar();
		
		}
		
		
		#endregion
		
#region DOLAR	
		
		/// <summary>
		/// Obtiene el Valor del dolar
		/// </summary>
		/// <returns>String con el dolar</returns>
		public static string  ObtenerDolar ()
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("Dolar", "Dia, Precio", "Dia = #" + DateTime.Today.ToString("MM/dd/yyyy")  +"#" ,"Dia" );
			
			
			
			try {
				//Desconecto para no tener problemas
				ConexionAccess2007.Desconectar ();
				
				//Cargo los datos en la funcion
				return  ConexionAccess2007.Table.Rows[0].ItemArray[1].ToString();
			
			} catch (Exception e) {
				MessageBox.Show(e.Message.ToString());
				
				//Inputbox esta creado para emular esta funcion que no esta en C#
				InputBox.InputBoxResult text = InputBox.InputBox.Show("Ingrese Dolar");
				
				//Convierto a dolar el valor entregado.
				decimal nuevodolar = Convert.ToDecimal(text.Text);
				
				//Guardo el dolar para que quede en la BD
				GuardarDolar(nuevodolar);
			
				
				//Desconecto para no tener problemas
				ConexionAccess2007.Desconectar ();
				
				return text.Text;
				
				//throw;
			}
			
			
			
			
			
			
		}

		/// <summary>
		/// Sobrecarga que obtiene el Valor del dolar de una fecha determinada.  
		/// </summary>
		///<param name = "FechaDolar">
		///La fecha del dola que se quiere obtener. Usar fecha Latina dd/MM/yyyy
		///</param>
		/// <returns>String con el dolar</returns>
		public static string  ObtenerDolar (DateTime FechaDolar)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("Dolar", "Dia, Precio", "Dia = #" + FechaDolar.ToString("MM/dd/yyyy")  +"#" ,"Dia" );
			
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			try {
			
			//Cargo los datos en la funcion
			return  ConexionAccess2007.Table.Rows[0].ItemArray[1].ToString();
			
			} catch (Exception e) {
				MessageBox.Show(e.Message.ToString());
				
				//Inputbox esta creado para emular esta funcion que no esta en C#
				InputBox.InputBoxResult text = InputBox.InputBox.Show("Ingrese Dolar");
				
				//Convierto a dolar el valor entregado.
				decimal nuevodolar = Convert.ToDecimal(text.Text);
				
				//Guardo el dolar para que quede en la BD
				GuardarDolar(nuevodolar);
			return text.Text; 
				
				//throw;
			}
			
		}		
		
		
		

		/// <summary>
		/// Guarda el Valor del dolar
		/// </summary>
		/// <param name="dcDolar">Dolar en decimal</param>
		public static void  GuardarDolar (decimal dcDolar)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.InsertarFila("Dolar", "Dia, Precio", "'" + DateTime.Today.ToShortDateString() + "', " + dcDolar.ToString().Replace("," , "."));			                                ;
			
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
					
			
		}
		#endregion
		
#region RECIBOS

		/// <summary>
		/// Funcion sobrecargada depende de la variable que se le entrega es lo que hace.
		/// </summary>
		///<param name = "vpReci"> Guarda un recibo</param>
		public static void  Guardar (VariablesPropias.VariablesPropias.vpRecibo vpReci)
		{
			
			
/*
IDRecibo, " +
NumRecibo, " +
Fecha, " +
IDCliente, " +
Nombre, " +
Direccion, " +
LaSumaDe, " +
ChequeNro1, " +
Banco1, " +
FechaEmision1, " +
FechaPago1, " +
ChImporte1, " +
SucFactNum1, " +
FactNum1, " +
FactFecha1, " +
Importe1, " +
ChequeNro2, " +
Banco2, " +
FechaEmision2, " +
FechaPago2, " +
ChImporte2, " +
SucFactNum2, " +
FactNum2, " +
FactFecha2, " +
Importe2, " +
ChequeNro3, " +
Banco3, " +
FechaEmision3, " +
FechaPago3, " +
ChImporte3, " +
SucFactNum3, " +
FactNum3, " +
FactFecha3, " +
Importe3, " +
ChequeNro4, " +
Banco4, " +
FechaEmision4, " +
FechaPago4, " +
ChImporte4, " +
SucFactNum4, " +
FactNum4, " +
FactFecha4, " +
Importe4, " +
ChequeNro5, " +
Banco5, " +
FechaEmision5, " +
FechaPago5, " +
ChImporte5, " +
SucFactNum5, " +
FactNum5, " +
FactFecha5, " +
Importe5, " +
ChequeNro6, " +
Banco6, " +
FechaEmision6, " +
FechaPago6, " +
ChImporte6, " +
SucFactNum6, " +
FactNum6, " +
FactFecha6, " +
Importe6, " +
Efectivo, " +
TotValores, " +
SubTotal
Descuento
Retenciones
RetenIIB
RetenIVA
RetenGanancias
RetenCargasSoc
NO
Varios
CobranzaNeta
HechoPor



 */



#region RECIBO
//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseRecibos"].ToString());
			
			try //Editar la DB de Recibos
			 {

#region Cuerpo del Recibo

				//Guardo los datos dentro de la tabla
			ConexionAccess2007.InsertarFila("Recibo", 
			                                //CAMPOS
				                            "IDRecibo" + ", " +  
				                            "NumRecibo" + ", " +
											"Fecha"+ ", " +
											"IDCliente" + ", " +
											"Total",
										

											//DATOS A CARGAR
											"'" + "0001X" + vpReci.dblNumReci.ToString("00000000") + "', " +
											"'" + vpReci.dblNumReci + "', " +
 											"'" + vpReci.dtFecha.ToString("dd/MM/yyyy") + "', " +
 											"'" + vpReci.Cliente.strid + "', " +
 											vpReci.curCobranzaNeta);
				


#endregion

#region EFECTIVO


//Guardo el Efectivo cobrado											
			ConexionAccess2007.InsertarFila("Efectivo",	
											//CAMPOS
											"IDRecibo" + ", " +
											"Importe",	
											//DATOS A CARGAR
											"'" + "0001X" + vpReci.dblNumReci.ToString("00000000") + "', " +
											vpReci.curEfectivo.ToString().Replace(",","."));
			
			
#endregion
											
#region Varios
			ConexionAccess2007.InsertarFila("Varios",	
											//CAMPOS
											"IDRecibo" + ", " +
											"Descuento" + ", " +
											"Retenciones" + ", " +
											"Varios" + ", " +
											"NoObservado",
											//DATOS A CARGAR
											"'" + "0001X" + vpReci.dblNumReci.ToString("00000000") + "', " +
											vpReci.curDescuento.ToString().Replace(",",".") + ", " +
											vpReci.curRetenciones.ToString().Replace(",",".") + ", " +
											vpReci.curVarios.ToString().Replace(",",".") + ", " +
											vpReci.curNO.ToString().Replace(",",".") 
								);
								
#endregion	


#region Retenciones

//TODO: HACER AYER
/*
 * Estoy hay que arreglarlo para que vaya directamente en un array de retenciones que deben cargarse antes
 */
if (vpReci.curCargasSoc != 0) {
	ConexionAccess2007.InsertarFila("Retenciones",	
											//CAMPOS
											"IDRecibo" + ", " +
											"Descripcion" + ", " +
											//"Alicuota" + ", " +
											"Importe",
											//DATOS A CARGAR
											"'" + "0001X" + vpReci.dblNumReci.ToString("00000000") + "', " +
											"'" + "Cargas Sociales" + "', " + 
											vpReci.curCargasSoc.ToString().Replace(",",".")
										);
}
			
if (vpReci.curGanancias != 0) {
	ConexionAccess2007.InsertarFila("Retenciones",	
											//CAMPOS
											"IDRecibo" + ", " +
											"Descripcion" + ", " +
											//"Alicuota" + ", " +
											"Importe",
											//DATOS A CARGAR
											"'" + "0001X" + vpReci.dblNumReci.ToString("00000000") + "', " +
											"'" + "Ganancias" + "', " + 											
											vpReci.curGanancias.ToString().Replace(",",".")
										);
}

if (vpReci.curIngBrutos != 0) {
	ConexionAccess2007.InsertarFila("Retenciones",	
											//CAMPOS
											"IDRecibo" + ", " +
											"Descripcion" + ", " +
											//"Alicuota" + ", " +
											"Importe",
											//DATOS A CARGAR
											"'" + "0001X" + vpReci.dblNumReci.ToString("00000000") + "', " +
											"'" + "Ingresos Brutos" + "', " + 
											vpReci.curIngBrutos.ToString().Replace(",",".")
										);
}

if (vpReci.curIVA != 0) {
	ConexionAccess2007.InsertarFila("Retenciones",	
											//CAMPOS
											"IDRecibo" + ", " +
											"Descripcion" + ", " +
											//"Alicuota" + ", " +
											"Importe",
											//DATOS A CARGAR
											"'" + "0001X" + vpReci.dblNumReci.ToString("00000000") + "', " +
											"'" + "IVA" + "', " + 
											vpReci.curIVA.ToString().Replace(",",".") 
								);
}
								
#endregion	





			}

			catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
			
			//Cerrar la conexion
			ConexionAccess2007.Desconectar();
#endregion 	

            
#region Modifico la tabla de CHEQUES


if (vpReci.Cheques != null) 
{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseCheques"].ToString());										
			
			try // para obtener errores posibles
			 {
			//Edito la tabla de los cheques
			for (int i = 0; i < vpReci.Cheques.Length ; i++) 
			{
				//Coloco el numero del recibo en el cheque (para identificarlo)
				ConexionAccess2007.ModificarFila("cheque",
												"IDRecibo = '" + "0001X" + vpReci.dblNumReci.ToString("00000000") + "'",
												"IDCheque = '" + vpReci.Cheques[i].strIDCheque.Trim() + "'");
			}

			
				
				
			}
            catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
			
			//Cerrar la conexion
            ConexionAccess2007.Desconectar();
}
			
#endregion



#region Modifico la tabla de interdepositos
if (vpReci.Interdepositos != null)
{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseInterdepositos"].ToString());										

			
			try // para obtener errores posibles
			 {
			//Edito la tabla de los cheques
			for (int i = 0; i < vpReci.Interdepositos.Length ; i++) 
			{
				ConexionAccess2007.ModificarFila("Interdepositos",
												"IDRecibo = '" + "0001X" + vpReci.dblNumReci.ToString("00000000") + "'", 
												"ID = " + vpReci.Interdepositos[i].dblIDInterdeposito.ToString().Trim());
			}

			
				
				
			}
            catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
			
			//Cerrar la conexion
            ConexionAccess2007.Desconectar();
	
}

#endregion


#region Modifico la tabla de Comprobantes Fiscales (Factura, ND, NC)

//TODO: CAMBIAR ESTO POR UNA BASE PROPIA Y MEJORAR MUUUUCHO
/*
 * Deberia haber una base de datos para cada uno de los comprobantes fiscales y se deberia poder mejorar mucho
* Cada producto debe decir de que pedido fue realizado, paso por que remito y que factura. A su vez deberia contenter el precio de costo
* y el precio de venta para conocer las utilidades generadas. 
 */
if (vpReci.Facturas != null)
{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());										

			
			try // para obtener errores posibles
			 {
			//Edito la tabla de los cheques
			for (int i = 0; i < vpReci.Facturas.Length ; i++) 
			{
				ConexionAccess2007.ModificarFila("Facturas",
												"Recibo1 = " + vpReci.dblNumReci + ", " + 
												"Saldo = '0'",
												"NumFact = " + vpReci.Facturas[i].dblNumFact );
			}

			
				
				
			}
            catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
			
			//Cerrar la conexion
            ConexionAccess2007.Desconectar();
	
}


if (vpReci.FacturasB != null)
{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());										

			
			try // para obtener errores posibles
			 {
			//Edito la tabla de los cheques
			for (int i = 0; i < vpReci.FacturasB.Length ; i++) 
			{
				ConexionAccess2007.ModificarFila("FacturasB",
												"Recibo1 = " + vpReci.dblNumReci + ", " + 
												"Saldo = '0'",
												"NumFact = " + vpReci.FacturasB[i].dblNumFact );
			}

			
				
				
			}
            catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
			
			//Cerrar la conexion
            ConexionAccess2007.Desconectar();
	
}

if (vpReci.NCs != null)
{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());										

			
			try // para obtener errores posibles
			 {
			//Edito la tabla de los cheques
			for (int i = 0; i < vpReci.NCs.Length ; i++) 
			{
				ConexionAccess2007.ModificarFila("NotaCredito",
												"Recibo1 = " + vpReci.dblNumReci + ", " + 
												"Saldo = '0'",
												"NumFact = " + vpReci.NCs[i].dblNumFact );
			}

			
				
				
			}
            catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
			
			//Cerrar la conexion
            ConexionAccess2007.Desconectar();
	
}


if (vpReci.NDs != null)
{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());										

			
			try // para obtener errores posibles
			 {
			//Edito la tabla de los cheques
			for (int i = 0; i < vpReci.NDs.Length ; i++) 
			{
				ConexionAccess2007.ModificarFila("NotaDebito",
												"Recibo1 = " + vpReci.dblNumReci + ", " + 
												"Saldo = '0'",
												"NumFact = " + vpReci.NDs[i].dblNumFact );
			}

			
				
				
			}
            catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
			
			//Cerrar la conexion
            ConexionAccess2007.Desconectar();
	
}

#endregion

#region Modifico la tabla de Impuestos
/*
 *Aca van los impuestos via retenciones que nos cobran
 */
#endregion

#region Modifico la tabla de Balance 
/*
 * Aqui debo colocar los importes en las distintas cuentas para que luego me "cierre" el balance
 */
#endregion





//
			MessageBox.Show ("Registro guardado", "Guardado");

/*
 Aca falta colocar lo que va a pasar con los distintos comprobantes. Esto es con las FC que se cancelan, las ND NC y cheques que se colocan en el recibo.
 La idea es armar funciones que hagan de edicion de distintas cosas, las FC, ND,NC,Ch y los impuestos que se cobran.
 
 */
				
			
							
				
			
		}

		#endregion

#region CONTADOR.FACTURAS CON IVA


		public static BindingSource FuenteObtenerFacturasCIVA(DateTime dtFechaInicio, DateTime dtFechaFinal)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta segun criterio
			//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
			ConexionAccess2007.Consultar("FactConIVA", 
			                             "*", 
			                             "Fecha >= #" + dtFechaInicio.ToString("MM/dd/yyyy")  + "# AND Fecha <= #" + dtFechaFinal.ToString("MM/dd/yyyy")  +"# ",
			                             "Fecha");


			
			 
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			//Cargo los datos en el grid
			return ConexionAccess2007.Source;
			
			}

/// <summary>
/// Obtiene los cheques en cartera para la base nueva
/// </summary>
/// <returns>Tabla de cheques en caretera</returns>
		public static DataTable TablaChequesFacturasCIVA(DateTime dtFechaInicio, DateTime dtFechaFinal)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta segun criterio
			//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
			ConexionAccess2007.Consultar("FactConIVA", 
			                             "Fecha, RazonSoc, Cuit, NumFact, " +
										 "ImpBruto, IVA105, IVA21, IVA27, " +
										 "IngBrutos, PercIVA, NoGravados, " +
										 "ImpNeto, TipoFact, " +
										 "Concepto, Cuenta, SubCuenta, Items", 
			                             "Fecha >= #" + dtFechaInicio.ToString("MM/dd/yyyy")  + "# AND Fecha <= #" + dtFechaFinal.ToString("MM/dd/yyyy")  +"# ",
			                             "Fecha");

	



			
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
				//Cargo los datos en el grid
			return  ConexionAccess2007.Table;
		}














#endregion
	

#region CONTRADOR.GASTOS

		/// <summary>
		/// Funcion sobrecargada depende de la variable que se le entrega es lo que hace.
		/// </summary>
		///<param name = "DatosInsertar"> Guarda un comprobante de gastos</param>		
		public static void  Guardar (VariablesPropias.VariablesPropias.vpComprobanteGastos  DatosInsertar)
		{
		
			//Esta funcion conecta con la base de datos a trabajar
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			
			//Comando para ingresar los datos
			ConexionAccess2007.InsertarFila("FactConIva",
								"Entrada, Fecha, RazonSoc, Cuit, NumFact, ImpBruto, IVA105, IVA21, " +
								"IVA27, IngBrutos, PercIVA, NoGravados, ImpNeto, TipoFact, Concepto, Cuenta, SubCuenta, Items" , 
								"'" + DatosInsertar.dtEntrada.ToString("dd/MM/yyyy") + "', " +
								"'" + DatosInsertar.dtFecha.ToString("dd/MM/yyyy") + "', '" + 
								DatosInsertar.Proveedor.Nombre + "', '" +
								DatosInsertar.Proveedor.Cuit + "', '" +
								DatosInsertar.strNumFact+ "', '" +
								DatosInsertar.curImpBruto + "', '" +
								DatosInsertar.curIva105 + "', '" +
								DatosInsertar.curIva21 + "', '" +
								DatosInsertar.curIva27 + "', '" +
								DatosInsertar.curIngBrutos + "', '" +
								DatosInsertar.curPercIva + "', '" +
								DatosInsertar.curNoGravados + "', '" +
								DatosInsertar.curImpNeto + "', '" +
								DatosInsertar.strTipoFact + "', '" +
								DatosInsertar.Proveedor.Concepto + "', '" +
								DatosInsertar.Proveedor.Cuenta + "', '" +
								DatosInsertar.Proveedor.Subcuenta + "', '" +
								DatosInsertar.Proveedor.Items + "'");
						
									
			//Desconectar la base de datos
			ConexionAccess2007.Desconectar();
		
		}
		

		/// <summary>
		/// Elimina un comprobante de gastos duplicado
		/// </summary>
		/// <param name="FactProv"></param>
		public static void Eliminar (VariablesPropias.VariablesPropias.vpComprobanteGastos FactProv)
		{
			//Esta funcion conecta con la base de datos a trabajar
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			ConexionAccess2007.EliminarFila("FactConIVA", "ID="+FactProv.ID.ToString());
				
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
		}	
		
		
		
		

#endregion


#region CONTADOR.LISTA FACTURAS HECHAS

/// <summary>
/// Obtiene una lista de las facturas hechas en determinado tiempo
/// </summary>
/// <param name="dtFechaInicio">Fecha Inicial</param>
/// <param name="dtFechaFinal">Fecha Final</param>
/// <returns></returns>
public static BindingSource FuenteObtenerFacturasImputadas(DateTime dtFechaInicio, DateTime dtFechaFinal)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta segun criterio
			//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
			ConexionAccess2007.Consultar("Facturas", 
			                             "Documento, Fecha, Nombre, Direccion, Localidad, Provincia, " +
			                             "SubTotal, Iva, ImporteFinal",
			                             "Fecha >= #" + dtFechaInicio.ToString("MM/dd/yyyy")  + "# AND Fecha <= #" + dtFechaFinal.ToString("MM/dd/yyyy")  +"#",
			                             "Documento");
						 
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			//Cargo los datos en la funcion
			return  ConexionAccess2007.Source;
		}




#endregion






		/// <summary>
		/// 
		/// </summary>
		/// <param name="entrada"></param>
		/// <returns></returns>
		public static string ConvertirAMoneda(string entrada)
		{
		
			//Esto realiza la conversion	
			return entrada.Replace(".","").Replace(",",".");
		}

		
/// <summary>
/// Obtiene el Transporte y lo vuelca en una estructura vpTransporte
/// </summary>
/// <param name="strId"></param>
/// <returns></returns>
		public static VariablesPropias.VariablesPropias.vpTransporte ObtenerTransporte(string strId)
		{
			
			//Creo una variable del mismo tipo que la "funcion" para que despues la descarge con un return
			VariablesPropias.VariablesPropias.vpTransporte Transp = new VariablesPropias.VariablesPropias.vpTransporte();
			
			
			

			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//tener en cuenta que primero va la condicion y luego el Order by
            ConexionAccess2007.Consultar("Transporte", "*", "TranspId = " + strId , "TranspNombre" );
			
            //Nueva Tabla
            DataTable Remito = new DataTable();
 			//Cargo la tabla con los datos de la Base de Datos
            Remito = ConexionAccess2007.Table;

			//Cargo los datos en una vp (Variable propia) para despues pasarlo a cada parte
			//lo hago asi para que luego si cambio algo no se joda todo.
			Transp.strNombre  = Remito.Rows[0]["TranspNombre"].ToString();
			Transp.strDireccion = Remito.Rows [0]["TranspDireccion"].ToString();
			Transp.strHorario = Remito.Rows[0]["Horario"].ToString();
			
			 //Cerrar la conexion
            ConexionAccess2007.Desconectar();
			
			
		return Transp;	
		}		
		
	
		
		public static BindingSource FuenteObtenerMercaderia()
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta segun criterio
			//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
			ConexionAccess2007.Consultar("Stock", 
			                             "ID, Nombre, Precio, Stock", 
			                             "Stock > 0 ",
			                             "ID");

/*
 ID
Nombre
Precio
Stock
StockInicial
PesoBruto
PesoNeto
CantPorUnidad
ParteDe
NumLote
VolLote
EmbalajeLote
FechaIngreso
Activo
Costo

 */
			
			 
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			//Cargo los datos en el grid
			return ConexionAccess2007.Source;
	}	
		

		public static VariablesPropias.VariablesPropias.vpClientes ObtenerCliente(string strRazonSocial)
		{
		
			VariablesPropias.VariablesPropias.vpClientes Clie = new VariablesPropias.VariablesPropias.vpClientes();
		
			

			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//tener en cuenta que primero va la condicion y luego el Order by
            ConexionAccess2007.Consultar("Clientes", "*", "Nombre = '" + strRazonSocial + "'" , "Nombre" );
			
            //Nueva Tabla
            DataTable Remito = new DataTable();
 			//Cargo la tabla con los datos de la Base de Datos
            Remito = ConexionAccess2007.Table;

			//Cargo los datos en una vp (Variable propia) para despues pasarlo a cada parte
			//lo hago asi para que luego si cambio algo no se joda todo.
			Clie.strNombre = strRazonSocial; 
			Clie.strid =  Convert.ToString (Remito.Rows[0]["ID"] );
			Clie.dblCUIT = Convert.ToDouble (Remito.Rows[0]["CUIT"]);
			Clie.strDireccion = Convert.ToString (Remito.Rows[0]["Direccion"] );
			Clie.strLocalidad = Convert.ToString (Remito.Rows[0]["Localidad"] );
			Clie.strProvincia = Convert.ToString (Remito.Rows[0]["Provincia"] );
			Clie.dblDescuento = Convert.ToDouble (Remito.Rows[0]["Desc"] );
			Clie.strTelefono1 = Remito.Rows[0]["Telefono1"].ToString();
			Clie.strTelefono2 = Remito.Rows[0]["Telefono2"].ToString();
		
		
			Clie.strCodPos = Convert.ToString (Remito.Rows[0]["CodPos"] );
			
			//Transporte
			Clie.intTranspId = Convert.ToInt32(Remito.Rows[0]["TranspId"] );
			Clie.Transporte = OperacionesComunes.ObtenerTransporte(Clie.intTranspId.ToString());
			
			/*
			 Aca va la otra parte donde se arregla la base y se colocan los valore de la base de datos de contactos
			 */
			
			Clie.Contactos = new VariablesPropias.VariablesPropias.vpClieContacto[10];
			Clie.Contactos[0].strNombre  = Convert.ToString (Remito.Rows[0]["Contacto1"] );; 
			Clie.Contactos[1].strNombre  = Convert.ToString (Remito.Rows[0]["Contacto2"] );;
			Clie.Contactos[2].strNombre  = Convert.ToString (Remito.Rows[0]["Contacto3"] );;
			
			
			//Variable Memo con los datos de la empresa
			Clie.memoVarios = Convert.ToString (Remito.Rows[0]["Info"] );;
			
			Clie.GLN = Convert.ToString (Remito.Rows[0]["GLN"] );;
			
		
 					
            //Cerrar la conexion
            ConexionAccess2007.Desconectar();	
			
			//Retorna el valor de Clie a la "funcion"
			return Clie;
			
			
			
		}
		
		public static VariablesPropias.VariablesPropias.vpClientes ObtenerCliente(int IDCliente)
		{
		
			VariablesPropias.VariablesPropias.vpClientes Clie = new VariablesPropias.VariablesPropias.vpClientes();
		
			

			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//tener en cuenta que primero va la condicion y luego el Order by
            ConexionAccess2007.Consultar("Clientes", "*", "ID = " + IDCliente + "" , "Nombre" );
			
            //Nueva Tabla
            DataTable Remito = new DataTable();
 			//Cargo la tabla con los datos de la Base de Datos
            Remito = ConexionAccess2007.Table;

			//Cargo los datos en una vp (Variable propia) para despues pasarlo a cada parte
			//lo hago asi para que luego si cambio algo no se joda todo.
			Clie.strNombre = Convert.ToString (Remito.Rows[0]["Nombre"] ); 
			Clie.strid =  Convert.ToString (Remito.Rows[0]["ID"] );
			Clie.dblCUIT = Convert.ToDouble (Remito.Rows[0]["CUIT"]);
			Clie.strDireccion = Convert.ToString (Remito.Rows[0]["Direccion"] );
			Clie.strLocalidad = Convert.ToString (Remito.Rows[0]["Localidad"] );
			Clie.strProvincia = Convert.ToString (Remito.Rows[0]["Provincia"] );
			Clie.dblDescuento = Convert.ToDouble (Remito.Rows[0]["Desc"] );
			Clie.strTelefono1 = Remito.Rows[0]["Telefono1"].ToString();
			Clie.strTelefono2 = Remito.Rows[0]["Telefono2"].ToString();
		
		
			Clie.strCodPos = Convert.ToString (Remito.Rows[0]["CodPos"] );
			
			//Transporte
			Clie.intTranspId = Convert.ToInt32(Remito.Rows[0]["TranspId"] );
			Clie.Transporte = OperacionesComunes.ObtenerTransporte(Clie.intTranspId.ToString());
			
			/*
			 Aca va la otra parte donde se arregla la base y se colocan los valore de la base de datos de contactos
			 */
			
			Clie.Contactos = new VariablesPropias.VariablesPropias.vpClieContacto[10];
			Clie.Contactos[0].strNombre  = Convert.ToString (Remito.Rows[0]["Contacto1"] );; 
			Clie.Contactos[1].strNombre  = Convert.ToString (Remito.Rows[0]["Contacto2"] );;
			Clie.Contactos[2].strNombre  = Convert.ToString (Remito.Rows[0]["Contacto3"] );;
			
			
			//Variable Memo con los datos de la empresa
			Clie.memoVarios = Convert.ToString (Remito.Rows[0]["Info"] );;
			
			Clie.GLN = Convert.ToString (Remito.Rows[0]["GLN"] );;
			
		
 					
            //Cerrar la conexion
            ConexionAccess2007.Desconectar();	
			
			//Retorna el valor de Clie a la "funcion"
			return Clie;
			
			
			
		}

#region CHEQUES

		
		/// <summary>
		/// Funcion sobrecargada depende de la variable que se le entrega es lo que hace.
		/// </summary>
		///<param name = "DatosInsertar"> Guarda un comprobante de gastos</param>		
		public static void  Guardar (VariablesPropias.VariablesPropias.vpCheque  DatosInsertar)
		{
		
			//Esta funcion conecta con la base de datos a trabajar
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseCheques"].ToString());
			
			
			//Comando para ingresar los datos
			ConexionAccess2007.InsertarFila("Cheque",
								"IDCheque, FechaEmision, FechaPago, FechaIngreso, " +
								"Importe, ImporteUSD, IDCliente" , 
								"'" + DatosInsertar.strIDCheque.Trim() + "', " +
			                    "'" + DatosInsertar.dtFechaEmision.ToString("dd/MM/yyyy") + "', " +            
								"'" + DatosInsertar.dtFechaPago.ToString("dd/MM/yyyy") + "', " +
								"'" + DatosInsertar.dtFechaIngreso.ToString("dd/MM/yyyy") + "', " +
								"" +  DatosInsertar.curImporte.ToString().Replace(",",".") + ", " +
								"" +  DatosInsertar.curImporteUSD.ToString().Replace(",",".")  + ", " +
								"'" + DatosInsertar.strIDCliente.Trim() + "'");
						
									
			//Desconectar la base de datos
			ConexionAccess2007.Desconectar();
		
		}
	
#endregion

		public static string ObtenerBanco(string strcodBaco)
		{
			//Accedo a la base de datos
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseBancos"].ToString());
			
			//tener en cuenta que primero va la condicion y luego el Order by
            ConexionAccess2007.Consultar("Bancos", "*", "IDBco = '" + strcodBaco + "'" , "IDBco" );
			
            //Nueva Tabla
            DataTable Remito = new DataTable();
 			//Cargo la tabla con los datos de la Base de Datos
            Remito = ConexionAccess2007.Table;

			
 					
            //Cerrar la conexion
            ConexionAccess2007.Desconectar();	
			
			//Retorna el valor de Clie a la "funcion"
			return   Convert.ToString (Remito.Rows[0]["Nombre"] );
			
			
		}

#region INTERDEPOSITOS
		/// <summary>
		/// Funcion sobrecargada depende de la variable que se le entrega es lo que hace.
		/// </summary>
		///<param name = "DatosInsertar"> Guarda un interdeposito</param>
		///<param name = "BaseDatos"> Si es 1 a la base vieja si 2 a la nueva</param>
		public static void  Guardar (VariablesPropias.VariablesPropias.vpInterdeposito  DatosInsertar, int BaseDatos = 1 )
		{
			if (BaseDatos == 1)
			{ 
			
			

				
			//Esta funcion conecta con la base de datos a trabajar
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseInterdepositos"].ToString());
			
			
			//Comando para ingresar los datos
			ConexionAccess2007.InsertarFila("Interdepositos",
								"FechaPago, Banco, " +
								"Sucursal, Importe, Cliente, IDCliente" , 
								"'" + DatosInsertar.dtFechaPago.ToString("dd/MM/yyyy") + "', " +
								"'" + DatosInsertar.strBanco + "', " +
								"'" + DatosInsertar.strSucursal + "', " +
								"" +  DatosInsertar.curImporte.ToString().Replace(",",".") +",  "+
								"'" + DatosInsertar.strIDCliente.Trim() + "', " +
								"'" + DatosInsertar.strCliente.Trim() + "'") ;
						
				

			
			//Desconectar la base de datos
			ConexionAccess2007.Desconectar();
	
				
				
				
			}
			else if(BaseDatos == 2)  
			{
				//Esta funcion conecta con la base de datos a trabajar
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseInterdepositos"].ToString());
			
			
			//Comando para ingresar los datos
			ConexionAccess2007.InsertarFila("Interdepositos",
								"ID, FechaIngreso, Fecha, "+ 
								"BancoPagador, BancoPagadorSuc, BancoRecibidor, " +
								"IDCliente, Importe" , 
								"'" + DatosInsertar.dblIDInterdeposito.ToString() + "', " +
			                    "'" + DatosInsertar.dtFechaEmision.ToString("dd/MM/yyyy") + "', " +            
								"'" + DatosInsertar.dtFechaPago.ToString("dd/MM/yyyy") + "', " +
								"'" + DatosInsertar.strBanco + "', " +
								"'" + DatosInsertar.strSucursal + "', " +
								"'" + DatosInsertar.strBancoDestino + "', " +
								"'" + DatosInsertar.strIDCliente.Trim() + "', " +
								"" +  DatosInsertar.curImporte.ToString().Replace(",",".") +""
								
								
								);
						
				

			
			//Desconectar la base de datos
			ConexionAccess2007.Desconectar();
		
			}
			
			
		}

		
		
		/*
		  * ID
FechaIngreso
Fecha
BancoPagador
BancoPagadorSuc
BancoRecibidor
IDCliente
Importe
IDRecibo
*
		 
		 */
		
		
		
		
		

#endregion
	
		
	}
}
