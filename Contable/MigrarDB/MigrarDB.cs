/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 29/04/2016
 * Hora: 03:51 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

using System.Drawing;
using System.Windows.Forms;

using System.Data;
using System.Globalization;


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
		
		
		
		/// <summary>
		/// 
		/// </summary>
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
		
		
		
		
		
		/*
		 MIGRAR INTERDEPOSITOS


BASE VIEJA
		 
ID
FechaPago
Banco
Sucursal
Importe
Cliente
IDCliente

BASE NUEVA

ID
FechaIngreso
Fecha
BancoPagador
BancoPagadorSuc
BancoRecibidor
IDCliente
Importe
IDRecibo


Resumen:
Debe tomar los datos de la base vieja formar un vpInterdeposito, consultar el recibo que tenga ese interdeposito,
Borrar el interdeposito de los recibos viejos, y con todo esto generar un interdeposito para pasarlo a la base nueva.

Ademas debe cargar el interdeposito en la cuenta de interdepositos para los balances.
Se debe modificar la posibilidad de poner cuentas bancarias donde se imputen las entradas de interdepositos y cheques
A esas cuentas es a las que se les agrega el importe.

Una vez que acabe esto el interdeposito debe ser borrado de la base de datos vieja.
y continuar con el siguiente.
Para esto combiene copiar la tabla completa e ir recorriendola para que no haya problemas





//Asi se maneja un DataTable



//tener en cuenta que primero va la condicion y luego el Order by
ConexionAccess2007.Consultar("Facturas", "*", "NumFact = " + intNumeroFactura + "AND Sucursal = 3", "NumFact" );

//Nueva Tabla
DataTable Factura = new DataTable();
//Cargo la tabla con los datos de la Base de Datos
Factura = ConexionAccess2007.Table;


#endregion
		

			
		//Cabecera			
		Fact.strTipoFc = "01";
		Fact.strCodFc = "A";
		Fact.intSucursal = Convert.ToInt16(Factura.Rows[0]["Sucursal"].ToString());
		
		Fact.dblNumFact = Convert.ToDouble(Factura.Rows[0]["NumFact"].ToString());
		Fact.dtFecha = Convert.ToDateTime (Factura.Rows[0]["Fecha"].ToString());
		
		Fact.dblTipoCambio = Convert.ToDouble(Factura.Rows[0]["Tipodecambio"].ToString()) ;




		 */



		
		public static void MigrarInterdepositos()
		{
		
		//Conectar a la base de datos		
		ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
				
		//Hace la consulta asumiendo que el cliente esta activo
		ConexionAccess2007.ModificarFila("Recibo", "ChequeNro2 = 0", "ChequeNro2 IS NULL");
				
		
		
		//Cerrar la conexion
	    ConexionAccess2007.Desconectar();	
		
		
		}
		
		/// <summary>
		/// 
		/// </summary>
		public static void AgregarIDClienteInterdepositoViejos()
		{
		//Creo una variable Cliente para poder obtener su ID
			VariablesPropias.VariablesPropias.vpClientes Cliente = new VariablesPropias.VariablesPropias.vpClientes();
			
		//Conectar a la base de datos		
		ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
		

		//tener en cuenta que primero va la condicion y luego el Order by
		ConexionAccess2007.Consultar("Interdepositos", "*", "Cliente");

		//Nueva Tabla
		DataTable Interdepostio = new DataTable();
		
		//Cargo la tabla con los datos de la Base de Datos
		Interdepostio = ConexionAccess2007.Table;
		
		//Recorro la base de datos
		for (int i = 0; i < Interdepostio.Rows.Count -1; i++) {
		
		/*
		 * La idea es que obtener el cliente de la base de datos y luego modificar la linea con el valor del ID correspondiente 
		 */
		
		
		
		//esta condicion elvalua si es necesario agregar el ID
		if (Interdepostio.Rows[i]["IDCliente"].ToString() == "") {
		
			//Cargo el Cliente
		Cliente = OperacionesComunes.ObtenerCliente(Interdepostio.Rows[i]["Cliente"].ToString());
			
		//Conectar a la base de datos
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
		
		//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.ModificarFila("Interdepositos",  
		                                 "IDCliente = " + Convert.ToInt64(Cliente.strid), 
		                                 "Cliente = '" + Cliente.strNombre + "'" );
		}
		
		
		
		}
		
		
		
		
		
				
		
		
		//Cerrar la conexion
	    ConexionAccess2007.Desconectar();	
		
		
		}
		
		
		
		/// <summary>
		/// 
		/// </summary>
		public static void AgregarIDClienteChequeViejos()
		{
		//Creo una variable Cliente para poder obtener su ID
			VariablesPropias.VariablesPropias.vpClientes Cliente = new VariablesPropias.VariablesPropias.vpClientes();
			
		//Conectar a la base de datos		
		ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
		

		//tener en cuenta que primero va la condicion y luego el Order by
		ConexionAccess2007.Consultar("Cheque", "*", "Cliente");

		//Nueva Tabla
		DataTable Interdepostio = new DataTable();
		
		//Cargo la tabla con los datos de la Base de Datos
		Interdepostio = ConexionAccess2007.Table;
		
		//Recorro la base de datos
		for (int i = 0; i < Interdepostio.Rows.Count -1; i++) {
		
		/*
		 * La idea es que obtener el cliente de la base de datos y luego modificar la linea con el valor del ID correspondiente 
		 */
		
		
		
		//esta condicion elvalua si es necesario agregar el ID
		if (Interdepostio.Rows[i]["IDCliente"].ToString() == "") {
		
			//Cargo el Cliente
		Cliente = OperacionesComunes.ObtenerCliente(Interdepostio.Rows[i]["Cliente"].ToString());
			
		//Conectar a la base de datos
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
		
		//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.ModificarFila("Cheque",  
		                                 "IDCliente = " + Convert.ToInt64(Cliente.strid), 
		                                 "Cliente = '" + Cliente.strNombre + "'" );
		}
		
		
		
		}
		
		
		
		
		
				
		
		
		//Cerrar la conexion
	    ConexionAccess2007.Desconectar();	
		
		
		}
		
		
				/// <summary>
		/// 
		/// </summary>
		public static void AgregarIDClienteReciboViejos()
		{
		//Creo una variable Cliente para poder obtener su ID
		VariablesPropias.VariablesPropias.vpClientes Cliente = new VariablesPropias.VariablesPropias.vpClientes();
			
		//Conectar a la base de datos		
		ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
		

		//tener en cuenta que primero va la condicion y luego el Order by
		ConexionAccess2007.Consultar("Recibo", "*", "Nombre");

		//Nueva Tabla
		DataTable Interdepostio = new DataTable();
		
		//Cargo la tabla con los datos de la Base de Datos
		Interdepostio = ConexionAccess2007.Table;
		
		//Recorro la base de datos
		for (int i = 0; i < Interdepostio.Rows.Count -1; i++) {
		
		/*
		 * La idea es que obtener el cliente de la base de datos y luego modificar la linea con el valor del ID correspondiente 
		 */
		
		
		
		//esta condicion elvalua si es necesario agregar el ID
		if (Interdepostio.Rows[i]["IDCliente"].ToString() == "") {
		
			//Cargo el Cliente
		Cliente = OperacionesComunes.ObtenerCliente(Interdepostio.Rows[i]["Nombre"].ToString());
			
		//Conectar a la base de datos
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
		
		//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.ModificarFila("Recibo",  
		                                 "IDCliente = " + Convert.ToInt64(Cliente.strid), 
		                                 "Nombre = '" + Cliente.strNombre + "'" );
		}
		
		
		
		}
		
		
		
		
		
				
		
		
		//Cerrar la conexion
	    ConexionAccess2007.Desconectar();	
		
		
		}
		
		
		public static void MigrarFacturasCIva()
		{
		//cadena.indexOf() te da la posicion de una caracter dentro de la cadena
		
		string CadenaNumFact = "";
		string NumeroFactura = "";
		string NumeroSucursal = "";
		
		
		//Creo una variable Cliente para poder obtener su ID
		VariablesPropias.VariablesPropias.vpComprobanteGastos CompGastos = new VariablesPropias.VariablesPropias.vpComprobanteGastos();
		
		//VariablesPropias.VariablesPropias.vpProveedores  Proveedor = new VariablesPropias.VariablesPropias.vpProveedores();
		
		
		//Conectar a la base de datos		
		ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
		

		//tener en cuenta que primero va la condicion y luego el Order by
		ConexionAccess2007.Consultar("FactConIva", "*", "ID");

		//Nueva Tabla
		DataTable Gastos = new DataTable();
		
		//Cargo la tabla con los datos de la Base de Datos
		Gastos = ConexionAccess2007.Table;
		
		//Recorro la base de datos
		for (int i = 0; i < Gastos.Rows.Count -1; i++) {
		
		/*
		 * La idea es crear el comprobante de gastos y luego pasarlo a 
		 */
		
		
		
		//Cargo el Proveedor
		try {
		 	CompGastos.Proveedor = OperacionesComunes.ObtenerProveedor(Gastos.Rows[i]["RazonSoc"].ToString());
		} catch (Exception) {
			MessageBox.Show (Gastos.Rows[i]["RazonSoc"].ToString(), "Error");
			
			//throw;
		}
		
		
		CompGastos.ID =Convert.ToInt32(Gastos.Rows[i]["ID"].ToString());
		
		CompGastos.dtEntrada = Convert.ToDateTime (Gastos.Rows[i]["Entrada"].ToString());
		CompGastos.dtFecha = Convert.ToDateTime (Gastos.Rows[i]["Fecha"].ToString());
		 
		CadenaNumFact = Gastos.Rows[i]["NumFact"].ToString();

		if (CadenaNumFact.IndexOf("-") != 0)
		{
			MessageBox.Show( "Tiene separador en: " + CadenaNumFact.IndexOf("-").ToString() );
			
			//NumeroFactura;
			NumeroSucursal = CadenaNumFact.Substring(0 , CadenaNumFact.IndexOf("-"));
			MessageBox.Show( "Sucursal: " + NumeroSucursal);
			
			NumeroFactura = CadenaNumFact.Substring(CadenaNumFact.IndexOf("-") + 1 , CadenaNumFact.Length - (CadenaNumFact.IndexOf("-") + 1)   );
			MessageBox.Show( "Factura: " + NumeroFactura);
		}



		CompGastos.strNumFact =  NumeroFactura;
		CompGastos.strSucursal =  NumeroSucursal;

		if (Gastos.Rows[i]["ImpBruto"] == null )
		{	
			CompGastos.curImpBruto = 0;
		}
		else
		{
			CompGastos.curImpBruto = Convert.ToDecimal (Gastos.Rows[i]["ImpBruto"].ToString());
		}
		
		if (Gastos.Rows[i]["IVA105"] == null )
		{	
			CompGastos.curIva105 = 0;
		}
		else
		{
			CompGastos.curIva105 = Convert.ToDecimal (Gastos.Rows[i]["IVA105"].ToString());
		}
		
		if (Gastos.Rows[i]["IVA21"] == null )
		{	
			CompGastos.curIva21 = 0;
		}
		else
		{
			CompGastos.curIva21 = Convert.ToDecimal (Gastos.Rows[i]["IVA21"].ToString());
		}
		
		if (Gastos.Rows[i]["IVA27"] == null )
		{	
			CompGastos.curIva27 = 0;
		}
		else
		{
			CompGastos.curIva27 = Convert.ToDecimal (Gastos.Rows[i]["IVA27"].ToString());
		}
		
		
		if (Gastos.Rows[i]["IngBrutos"] == null )
		{	
			CompGastos.curIngBrutos = 0;
		}
		else
		{
			CompGastos.curIngBrutos = Convert.ToDecimal (Gastos.Rows[i]["IngBrutos"].ToString());
		}
		
		
		if (Gastos.Rows[i]["PercIVA"] == null )
		{	
			CompGastos.curPercIva = 0;
		}
		else
		{
			CompGastos.curPercIva = Convert.ToDecimal (Gastos.Rows[i]["PercIVA"].ToString());
		}
		
		if (Gastos.Rows[i]["ImpNeto"] == null )
		{	
			CompGastos.curNoGravados = 0;
		}
		else
		{
			CompGastos.curNoGravados = Convert.ToDecimal (Gastos.Rows[i]["ImpNeto"].ToString());
		}
		
		if (Gastos.Rows[i]["ImpNeto"] == null )
		{	
			CompGastos.curImpNeto = 0;
		}
		else
		{
			CompGastos.curImpNeto = Convert.ToDecimal (Gastos.Rows[i]["ImpNeto"].ToString());
		}
		
		
		CompGastos.strTipoFact = Gastos.Rows[i]["TipoFact"].ToString();


			 



/*
		
		//Conectar a la base de datos
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
		
		//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.ModificarFila("Recibo",  
		                                 "IDCliente = " + Convert.ToInt64(Cliente.strid), 
		                                 "Nombre = '" + Cliente.strNombre + "'" );
		
		
		*/
		
		}
		
		
		
		
		
				
		
		
		//Cerrar la conexion
	    ConexionAccess2007.Desconectar();	
		
		
		}
		
		
		/// <summary>
		/// Esta funcion migra los valores de las alicuotas de cada uno de los impuestos para pasarlos a la base correspondiente.
		/// </summary>
		public static void MigrarCOMPRASALICUOTA()
		{
		
			//cadena.indexOf() te da la posicion de una caracter dentro de la cadena
		
		string CadenaNumFact = "";
		string NumeroFactura = "";
		string NumeroSucursal = "";
		
		
		//Creo una variable Cliente para poder obtener su ID
		VariablesPropias.VariablesPropias.vpComprobanteGastos CompGastos = new VariablesPropias.VariablesPropias.vpComprobanteGastos();
		
		//VariablesPropias.VariablesPropias.vpProveedores  Proveedor = new VariablesPropias.VariablesPropias.vpProveedores();
		
		
		//Conectar a la base de datos		
		ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
		

		//tener en cuenta que primero va la condicion y luego el Order by
		ConexionAccess2007.Consultar("FactConIva", "*", "ID");

		//Nueva Tabla
		DataTable Gastos = new DataTable();
		
		//Cargo la tabla con los datos de la Base de Datos
		Gastos = ConexionAccess2007.Table;
		
		//Recorro la base de datos
		for (int i = 0; i < Gastos.Rows.Count -1; i++) {
		
		/*
		 * La idea es crear el comprobante de gastos y luego pasarlo a 
		 */
		
		
		
		//Cargo el Proveedor
		try {
		 	CompGastos.Proveedor = OperacionesComunes.ObtenerProveedor(Gastos.Rows[i]["RazonSoc"].ToString());
		} catch (Exception) {
			MessageBox.Show (Gastos.Rows[i]["RazonSoc"].ToString(), "Error");
			
			//throw;
		}
		
		
		CompGastos.ID =Convert.ToInt32(Gastos.Rows[i]["ID"].ToString());
		
		CompGastos.dtEntrada = Convert.ToDateTime (Gastos.Rows[i]["Entrada"].ToString());
		CompGastos.dtFecha = Convert.ToDateTime (Gastos.Rows[i]["Fecha"].ToString());
		 
		CadenaNumFact = Gastos.Rows[i]["NumFact"].ToString();

		if (CadenaNumFact.IndexOf("-") != 0)
		{
			MessageBox.Show( "Tiene separador en: " + CadenaNumFact.IndexOf("-").ToString() );
			
			//NumeroFactura;
			NumeroSucursal = CadenaNumFact.Substring(0 , CadenaNumFact.IndexOf("-"));
			MessageBox.Show( "Sucursal: " + NumeroSucursal);
			
			NumeroFactura = CadenaNumFact.Substring(CadenaNumFact.IndexOf("-") + 1 , CadenaNumFact.Length - (CadenaNumFact.IndexOf("-") + 1)   );
			MessageBox.Show( "Factura: " + NumeroFactura);
		}



		CompGastos.strNumFact =  NumeroFactura;
		CompGastos.strSucursal =  NumeroSucursal;

		if (Gastos.Rows[i]["ImpBruto"] == null )
		{	
			CompGastos.curImpBruto = 0;
		}
		else
		{
			CompGastos.curImpBruto = Convert.ToDecimal (Gastos.Rows[i]["ImpBruto"].ToString());
		}
		
		if (Gastos.Rows[i]["IVA105"] == null )
		{	
			CompGastos.curIva105 = 0;
		}
		else
		{
			CompGastos.curIva105 = Convert.ToDecimal (Gastos.Rows[i]["IVA105"].ToString());
		}
		
		if (Gastos.Rows[i]["IVA21"] == null )
		{	
			CompGastos.curIva21 = 0;
		}
		else
		{
			CompGastos.curIva21 = Convert.ToDecimal (Gastos.Rows[i]["IVA21"].ToString());
		}
		
		if (Gastos.Rows[i]["IVA27"] == null )
		{	
			CompGastos.curIva27 = 0;
		}
		else
		{
			CompGastos.curIva27 = Convert.ToDecimal (Gastos.Rows[i]["IVA27"].ToString());
		}
		
		
		if (Gastos.Rows[i]["IngBrutos"] == null )
		{	
			CompGastos.curIngBrutos = 0;
		}
		else
		{
			CompGastos.curIngBrutos = Convert.ToDecimal (Gastos.Rows[i]["IngBrutos"].ToString());
		}
		
		
		if (Gastos.Rows[i]["PercIVA"] == null )
		{	
			CompGastos.curPercIva = 0;
		}
		else
		{
			CompGastos.curPercIva = Convert.ToDecimal (Gastos.Rows[i]["PercIVA"].ToString());
		}
		
		if (Gastos.Rows[i]["ImpNeto"] == null )
		{	
			CompGastos.curNoGravados = 0;
		}
		else
		{
			CompGastos.curNoGravados = Convert.ToDecimal (Gastos.Rows[i]["ImpNeto"].ToString());
		}
		
		if (Gastos.Rows[i]["ImpNeto"] == null )
		{	
			CompGastos.curImpNeto = 0;
		}
		else
		{
			CompGastos.curImpNeto = Convert.ToDecimal (Gastos.Rows[i]["ImpNeto"].ToString());
		}
		
		
		CompGastos.strTipoFact = Gastos.Rows[i]["TipoFact"].ToString();


			 



/*
		
		//Conectar a la base de datos
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
		
		//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.ModificarFila("Recibo",  
		                                 "IDCliente = " + Convert.ToInt64(Cliente.strid), 
		                                 "Nombre = '" + Cliente.strNombre + "'" );
		
		
		*/
		
		}
		
		
		
		
		
				
		
		
		//Cerrar la conexion
	    ConexionAccess2007.Desconectar();	
		
		
		}
		
	}
	
}
