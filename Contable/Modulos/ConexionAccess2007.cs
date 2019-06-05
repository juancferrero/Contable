/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 08/05/2014
 * Hora: 06:07 p.m.
 * 
 * 
 */
using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms; 

using System.Configuration; 


using VariablesPropias;


namespace ConexionDB
{	
	
/// <summary>
/// Description of ConexionAccess2007.
/// Esta Clase realiza todos los movimientos con la base de datos.
/// </summary>
///<example>
///Codigo para usar esta clase:
///	ConexionAccess2007.Conectar();
///	ConexionAccess2007.Consultar("producto", "*", "id_producto");
/// dgvDatos.DataSource = ConexionAccess2007.Source;
///	ConexionAccess2007.Desconectar();
///</example>
	public class ConexionAccess2007
	{
		
		static string CadenaConexion;
        static OleDbConnection Conex;
        static OleDbDataAdapter Adaptador;
        static OleDbCommandBuilder Constructor;
        static DataTable Tabla;
        static BindingSource Fuente;
		
		
		public ConexionAccess2007()
		{
		}
	
		
/// <summary>
/// Esta funcion conecta con la base de datos asignada en el parametro ruta
/// </summary>
///<remarks>
///Conecta con la base de datos 
///</remarks>
		public static void Conectar(string ruta)
        {
        	//Ver si la cadena de conexion es correcta
			CadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + ruta; //No es mas interesante??
			//CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + " Persist Security Info=False"; //No parece ser un proveedor muy comun
			
			//Agrego la cadena de conexion a la variable Conex
			Conex = new OleDbConnection(CadenaConexion);
			
			
			//Pruebo abrir la coneccion si da error muestra el mensaje de error
			try
			{
				Conex.Open();
			}
			catch (Exception e)
			{
				MessageBox.Show ( e.Message , "Error");
			}
			
        
		}

///<summary>
/// Esta funcion desconecta la base para que no haya problemas
///</summary>
		public static void Desconectar()
        {
		//Desconectar la Base de Datos			
		Conex.Close();
        }
	
		
#region CONSULTAR

		
/// <summary>
/// Esta funcion sobrecargada sirve para consultar la base de datos
/// </summary>
/// <param name="tabla">
/// Es la tabla a la que se pretende acceder
/// </param>
/// <param name="campos">
/// Son los campos que se pretenden ver de la tabla
/// </param>
/// <param name="orden">
/// El campo por el cual se ordenaran
///</param>
		public static void Consultar(string tabla,string campos,string orden)
        {
           
			
			
			
			string Consulta = "SELECT " + campos + " FROM " + tabla + " ORDER BY " + orden + ";";	
			
			
            
			//Arma el adapatador OLEDB. Toma como variables la conexion abierta y la consulta SQL
			Adaptador = new OleDbDataAdapter(Consulta, Conex);
            
			//Arma un Comando OLEDB
			Constructor = new OleDbCommandBuilder(Adaptador);
            
			//Arma la tabla del DATATABLE
			Tabla = new DataTable(tabla);
            
			//Llena la tabla con el adaptador ya creado
			Adaptador.Fill(Tabla);
			
			//Fuente es un BindingSource. Sirve para llenar directamente los DataGridView con los datos de la tabla aramada
			//por el comando SQL que le mande originalemente
            Fuente = new BindingSource();
            Fuente.DataSource = Tabla;
        }


		
/// <summary>
/// Es una funcion sobrecargada. Mejor asi
/// </summary>
/// <param name="tabla">
/// Tabla que se quiere abrir
///</param>
/// <param name="campos">
/// Campos a ver. Si no se especifica asignar "*"
///</param>
/// <param name="condicion">
/// Es la condicion que debe cumplirse en la apertura de la tabla
///</param>
/// <param name="orden">
/// Con que criterio se ordenan (que campo es el criterio de orden)
///</param>
///<remarks>
///Los campos fecha van entre # # si quiero que sean literales si acepto la configuracion regional van entre ''
///</remarks>
		public static void Consultar(string tabla,string campos,string condicion,string orden)
        {
        
		
          //Tener en cuenta que para SQL primero viene la condicion y luego el ordenamiento.
          //Si pongo el ORDER BY antes que el WHERE da error.
          
          
          //string para armar la consulta
			string Consulta = "SELECT " + campos + " FROM " + tabla  + 
				" WHERE " + condicion + " ORDER BY " + orden +";";
					
            
			//Arma el adapatador OLEDB. Toma como variables la conexion abierta y la consulta SQL
			Adaptador = new OleDbDataAdapter(Consulta, Conex);
            
			//Arma un Comando OLEDB
			Constructor = new OleDbCommandBuilder(Adaptador);
            
			//Arma la tabla del DATATABLE
			Tabla = new DataTable(tabla);
            
			//Llena la tabla con el adaptador ya creado
			Adaptador.Fill(Tabla);
			
			//Fuente es un BindingSource. Sirve para llenar directamente los DataGridView con los datos de la tabla aramada
			//por el comando SQL que le mande originalemente
            Fuente = new BindingSource();
            Fuente.DataSource = Tabla;
        }
		
/// <summary>
/// Es una funcion sobrecargada. Mejor asi
/// </summary>
/// <param name="tabla">
/// Tabla que se quiere abrir
///</param>
/// <param name="campos">
/// Campos a ver. Si no se especifica asignar "*"
///</param>
/// <param name="CampoBuscar">
/// En que campo busca
///</param>
/// <param name="DatoBuscado">
/// Indica que buscar
/// </param>
/// <param name="orden">
/// Con que criterio se ordenan (que campo es el criterio de orden)
///</param>
///<returns>
/// Retorna una Tabla (Datatable); Una Fuente (BindingSource)
///</returns>
		public static void Consultar(string tabla,string campos,string CampoBuscar ,string DatoBuscado, string orden )
        {
          //Tener en cuenta que para SQL primero viene la condicion y luego el ordenamiento.
          //Si pongo el ORDER BY antes que el WHERE da error.
          //Los campos fecha van entre # # si quiero que sean literales si acepto la configuracion regional van entre ''
          
          /*
           	* SELECT select_list
		   	*[ INTO new_table_name ]
			*FROM table_list
			*[ WHERE search_conditions ]
			*o puede ser  WHERE CONTAINS(Description, @SearchWord)
			*[ GROUP BY group_by_list ]
			*[ HAVING search_conditions ]
			*[ ORDER BY order_list [ ASC | DESC ] ]
           */
          
          //string para armar la consulta
			string Consulta = "SELECT " + campos + " FROM " + tabla  + 
					" WHERE " +  CampoBuscar + " LIKE '%" +  DatoBuscado + "%' ORDER BY " + orden +";";
					
            
			//Arma el adapatador OLEDB. Toma como variables la conexion abierta y la consulta SQL
			Adaptador = new OleDbDataAdapter(Consulta, Conex);
            
			//Arma un Comando OLEDB
			Constructor = new OleDbCommandBuilder(Adaptador);
            
			//Arma la tabla del DATATABLE
			Tabla = new DataTable(tabla);
            
			//Llena la tabla con el adaptador ya creado
			Adaptador.Fill(Tabla);
			
			//Fuente es un BindingSource. Sirve para llenar directamente los DataGridView con los datos de la tabla aramada
			//por el comando SQL que le mande originalemente
            Fuente = new BindingSource();
            Fuente.DataSource = Tabla;
        }

#endregion

		
/// <summary>
/// Esta propiedad arma un Binding Source para directamente colocar los datos obtenidos en un
/// datagridwiev
/// </summary>
		public static BindingSource Source
        {
			
			get
            {
                return Fuente;
            }
        }
	
/// <summary>
/// Esta propiedad devuelve una tabla
/// </summary>
		public static DataTable Table
        {
			get
            {
                return Tabla;
            }
        }
		
///<summary>
///Esta funcion inserta una fila en la base de datos. Usando comandos SQL
///</summary>
		public static void InsertarFila (string tabla, string campos, string datosinsertar, bool Mensaje = true)
		{
			
			//La variable Insertar arma el comando SQL para poder insertar los datos
			string Insertar = "INSERT INTO " + tabla +"(" + campos + ") VALUES ( " + datosinsertar  + " );" ;
            
			try
			{
			
	    		//Objeto para ejecutar ordenes SQL
				OleDbCommand Orden;
				
				//Le asigna la orden al objeto Orden basandose en la conexion Conex 
				Orden = new OleDbCommand(Insertar, Conex);
				
				//ExecuteNonQuery() hace que se ejecute el comando y guarde la informacion en la base de datos	
		    	Orden.ExecuteNonQuery();
		    	
		    	//Mensaje que avisa que todo esta bien
		    	if (Mensaje) {MessageBox.Show("Registro Grabado Exitosamente");}
	    	
			}
			catch (Exception e)
			{
				MessageBox.Show ( e.Message , "Error");
			}
			
        
			
				
		
			
			
		}



		
///<summary>
///Esta funcion modifica una fila en la base de datos. Usando comandos SQL
/// Recordar que no se usa AND, en el SET, para varias modificaciones sino que se separa con ", "
///</summary>
		public static void ModificarFila (string tabla, string camposYdatosAmodificar, string condicion)
		{
			
			//La variable modificar arma el comando SQL para poder modificar los datos
			string modificar = "UPDATE " + tabla +" SET " + camposYdatosAmodificar + " WHERE " + condicion  + ";" ;
            
			try
			{
	    		//Objeto para ejecutar ordenes SQL
				OleDbCommand Orden;
	
				//Le asigna la orden al objeto Orden basandose en la conexion Conex 
				Orden = new OleDbCommand(modificar, Conex);
				
				//ExecuteNonQuery() hace que se ejecute el comando y guarde la informacion en la base de datos	
			    Orden.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				MessageBox.Show ( e.Message , "Error");
			}
        
			//Mensaje que avisa que todo esta bien
            //MessageBox.Show("Registro Modificado Exitosamente");
				
		
			
			
		}
	
///<summary>
///Esta funcion elimina una fila en la base de datos. Usando comandos SQL
///</summary>
		public static void EliminarFila (string tabla, string condicion, bool Mensaje = true)
		{
			
			//La variable Borrar arma el comando SQL para poder borrar los datos
			string Borrar = "DELETE FROM " + tabla  + 
					" WHERE " + condicion + ";";
            
				
    		//Objeto para ejecutar ordenes SQL
			OleDbCommand Orden;

			//Le asigna la orden al objeto Orden basandose en la conexion Conex 
			Orden = new OleDbCommand(Borrar, Conex);
			
			//ExecuteNonQuery() hace que se ejecute el comando y guarde la informacion en la base de datos	
		    Orden.ExecuteNonQuery();

        
			//Mensaje que avisa que todo esta bien
			if (Mensaje) {MessageBox.Show("Registro Eliminado Exitosamente");}
				
		
			
			
		}
	
	
	}
	
/// <summary>
/// Clase para manejar la trazabilidad
/// </summary>
	public class OperacionesTrazabilidad
	{
/// <summary>
/// Operaciones de trazabilidad
/// </summary>
		public OperacionesTrazabilidad()
		{
		}
		
///<summary>
///Esta funcion tiene por objeto modificar la base de datos de trazabilidad y colocarle el nro de caja a cada una de las unidades
/// de una partida.
///</summary>
///<param name"descripcion">
/// Es el parametro del nombbre del producto
/// </param>
///<param name"cantxcaja">
/// Es el parametro indica la cantidad de unidades por caja
/// </param>
///<param name"lote">
/// Es el parametro del nombbre del Lote. De esta manera es imposible escribir en otro lado que no sea donde queremos
/// </param>
		public static void ModificarCajas(string descripcion, int cantxcaja, string lote)
		{
			
			
			//usa los datos guardados de donde esta la base de datos para no tener que copiar siempre lo mismo
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseTrazabilidad"]));
			
			//Esta es una consulta sencilla de la tabla y el producto identificado por su lote, de aca sacamos cuantas unidades hay
			ConexionAccess2007.Consultar("Traza2014", "Descripcion","Lote = '"+ lote + "' AND Descripcion = '"+ descripcion + "'","Descripcion");
	        
			//Este for es el que pone el numero de caja contando cuantas habria al dividir la cantidad de registros con el valor por caja.			
			for(int caja = 1; caja <= (ConexionAccess2007.Table.Rows.Count)/cantxcaja; caja++)
	        {
				//Este for recorre cada unidad y modifica el valor del campo CajaNro con el valor de caja impuesto por la variable caja.
				//Parece complicado pero aca recorre todas las unidades y las modifica
				for (int i = 1; i <= cantxcaja; i++)
	    		{	
			     	//Esto recorre cada una de las series y le asigna el valor de la caja
			     	if(caja == 1)
			     	{
						ConexionAccess2007.ModificarFila ("Traza2014", "CajaNro ='" + caja +"'", "Lote = '"+ lote + "' AND Descripcion = '"+ descripcion + "' AND Serie ='" +  i + "'");
			     	} 
			     	else
			     	{
			     		//Supe tener problemas con la segunda unidad asique modifique con este if el tema de que a la segunda en adelante las modifique de esta manera.
			     		//No es lo mas elegante pero es lo que mejor funciona.
			     		ConexionAccess2007.ModificarFila ("Traza2014", "CajaNro ='" + caja +"'", "Lote = '"+ lote + "' AND Descripcion = '"+ descripcion + "' AND Serie ='" + (caja*cantxcaja - cantxcaja + i) + "'");
			     	}
	         	}
	         		
	 		}
	         	
         
			
			//Siempre hay que desconectar para no tener problemas futuros
			ConexionAccess2007.Desconectar();
			}
	}
	
	
	
	
	
	
	
}

        
