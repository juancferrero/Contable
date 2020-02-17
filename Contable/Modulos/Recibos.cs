/*
* Creado por SharpDevelop.
* Usuario: Juan Carlos
* Fecha: 03/02/2017
* Hora: 10:57 a.m.
*
* Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
*/
using System;
using ConexionDB;
using System.Configuration;
//using System.Data.OleDb;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Contable.Modulos
{
/// <summary>
/// Description of Recibos.
/// </summary>
public class Recibos
{
public Recibos()
{
}

/// <summary>
/// Obtiene el ultimo Recibo hecho
/// </summary>
/// <returns>Int con el numero del recibo</returns>
public static int ObtenerUltimoRecibo()
{

ConexionAccess2007 Conexion = new ConexionAccess2007();

//Conexion con la base de datos en Manolito
ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());

//Consulta
ConexionAccess2007.Consultar("Recibo", "*", "NumRecibo");

//Nueva Tabla
DataTable Remito = new DataTable();
//Cargo la tabla con los datos de la Base de Datos
Remito = ConexionAccess2007.Table;

//Carga el numero de remito

int i = Convert.ToInt32 ( Remito.Rows[Convert.ToInt32 (Remito.Rows.Count) - 1 ]["NumRecibo"]) + 1;

//Cerrar la conexion
ConexionAccess2007.Desconectar();

return i;
}




/// <summary>
/// Sobrecarga de la funcion CargarRecibo. Con esta lo hacemos desde la base de datos en vez de desde el form.
/// </summary>
/// <param name="intNumeroRecibo">
/// Es el numero del recibo. Deberia ser el ID del recibo y ser un string.
/// Veremos como lo arreglamos en el futuro.
/// </param>
public static VariablesPropias.VariablesPropias.vpRecibo CargarRecibo(int intNumeroRecibo)
{

#region Cultura
			CultureInfo cultura = new CultureInfo("es-AR");
			CultureInfo culture = new CultureInfo("en-US");
#endregion

#region Variables
VariablesPropias.VariablesPropias.vpRecibo reci = new VariablesPropias.VariablesPropias.vpRecibo();
#endregion

#region DB

ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());

//tener en cuenta que primero va la condicion y luego el Order by
ConexionAccess2007.Consultar("Recibo", "*", "NumRecibo = " + intNumeroRecibo , "NumRecibo" );

//Nueva Tabla
DataTable Remito = new DataTable();
//Cargo la tabla con los datos de la Base de Datos
Remito = ConexionAccess2007.Table;


#endregion

//Cargo los datos en una vp (Variable propia) para despues pasarlo a cada parte
//lo hago asi para que luego si cambio algo no se joda todo.

#region ENCABEZADO
reci.dtFecha = Convert.ToDateTime (Remito.Rows[0]["Fecha"].ToString());
reci.dblNumReci = Convert.ToDouble (Remito.Rows[0]["NumRecibo"].ToString());
#endregion

#region CLIENTE
/*
*IDCliente
*Nombre
*Direccion
*/
reci.Cliente = OperacionesComunes.ObtenerCliente(Remito.Rows[0]["Nombre"].ToString());
#endregion

#region CHEQUES

//TODO: Revisar esto para poner los cheques que estan en la tabla de cheques
//Crea el array de los cheques
reci.Cheques  = new VariablesPropias.VariablesPropias.vpCheque [10];

int chequeNro = 0;


/*
ChequeNro1
Banco1
FechaEmision1
FechaPago1
ChImporte1
*/



if (Remito.Rows[0]["ChequeNro1"].ToString() != "0")
{
	if (Remito.Rows[0]["ChequeNro1"].ToString() != "Interdeposito") 
	{
		if (Remito.Rows[0]["ChequeNro1"].ToString().Substring(0 , 2) != "NC")
		{
			reci.Cheques[chequeNro].dblNumCheque = Convert.ToDouble (Remito.Rows[0]["ChequeNro1"].ToString());
			reci.Cheques[chequeNro].strBanco = Remito.Rows[0]["Banco1"].ToString();
			reci.Cheques[chequeNro].dtFechaEmision = Convert.ToDateTime(Remito.Rows[0]["FechaEmision1"].ToString());
			reci.Cheques[chequeNro].dtFechaPago = Convert.ToDateTime(Remito.Rows[0]["FechaPago1"].ToString());
			//reci.Cheques[chequeNro].curImporte = Remito.Rows[0]["ChImporte1"].ToString();
			reci.Cheques[chequeNro].curImporte = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte1"].ToString().Replace("$", "")), cultura);
			
			chequeNro ++;
		}
	}
	
	
}


/*
ChequeNro2
Banco2
FechaEmision2
FechaPago2
ChImporte2
*/
if (Remito.Rows[0]["ChequeNro2"].ToString() != "0") 
{
	if (Remito.Rows[0]["ChequeNro2"].ToString() != "Interdeposito") 
		{
			if (Remito.Rows[0]["ChequeNro2"].ToString().Substring(0 , 2) != "NC")
			{
				reci.Cheques[chequeNro].dblNumCheque = Convert.ToDouble (Remito.Rows[0]["ChequeNro2"].ToString());
				reci.Cheques[chequeNro].strBanco = Remito.Rows[0]["Banco2"].ToString();
				reci.Cheques[chequeNro].dtFechaEmision = Convert.ToDateTime(Remito.Rows[0]["FechaEmision2"].ToString());
				reci.Cheques[chequeNro].dtFechaPago = Convert.ToDateTime(Remito.Rows[0]["FechaPago2"].ToString());
				//reci.Cheques[chequeNro].curImporte = Convert.ToDecimal(Remito.Rows[0]["ChImporte2"].ToString());
				reci.Cheques[chequeNro].curImporte = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte2"].ToString().Replace("$", "")), cultura);
				
				chequeNro ++;
				
				
			}
		}	
}

/*
ChequeNro3
Banco3
FechaEmision3
FechaPago3
ChImporte3
*/
if (Remito.Rows[0]["ChequeNro3"].ToString() != "0") 
{
	if (Remito.Rows[0]["ChequeNro3"].ToString() != "Interdeposito") 
		{
			if (Remito.Rows[0]["ChequeNro3"].ToString().Substring(0 , 2) != "NC")
			{
				reci.Cheques[chequeNro].dblNumCheque = Convert.ToDouble (Remito.Rows[0]["ChequeNro3"].ToString());
				reci.Cheques[chequeNro].strBanco = Remito.Rows[0]["Banco3"].ToString();
				reci.Cheques[chequeNro].dtFechaEmision = Convert.ToDateTime(Remito.Rows[0]["FechaEmision3"].ToString());
				reci.Cheques[chequeNro].dtFechaPago = Convert.ToDateTime(Remito.Rows[0]["FechaPago3"].ToString());
				//reci.Cheques[chequeNro].curImporte = Convert.ToDecimal(Remito.Rows[0]["ChImporte3"].ToString());
				reci.Cheques[chequeNro].curImporte = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte3"].ToString().Replace("$", "")), cultura);
				
				chequeNro ++;
			}
		}	
}

/*
ChequeNro4
Banco4
FechaEmision4
FechaPago4
ChImporte4
*/
if (Remito.Rows[0]["ChequeNro4"].ToString() != "0") 
{
	if (Remito.Rows[0]["ChequeNro4"].ToString() != "Interdeposito") 
	{
		if (Remito.Rows[0]["ChequeNro4"].ToString().Substring(0 , 2) != "NC")
		{
			reci.Cheques[chequeNro].dblNumCheque = Convert.ToDouble (Remito.Rows[0]["ChequeNro4"].ToString());
			reci.Cheques[chequeNro].strBanco = Remito.Rows[0]["Banco4"].ToString();
			reci.Cheques[chequeNro].dtFechaEmision = Convert.ToDateTime(Remito.Rows[0]["FechaEmision4"].ToString());
			reci.Cheques[chequeNro].dtFechaPago = Convert.ToDateTime(Remito.Rows[0]["FechaPago4"].ToString());
			//reci.Cheques[chequeNro].curImporte = Convert.ToDecimal(Remito.Rows[0]["ChImporte4"].ToString());
			reci.Cheques[chequeNro].curImporte = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte4"].ToString().Replace("$", "")), cultura);
			
			chequeNro ++;
		}
	}
}

/*
ChequeNro5
Banco5
FechaEmision5
FechaPago5
ChImporte5
*/
if (Remito.Rows[0]["ChequeNro5"].ToString() != "0") 
{
	if (Remito.Rows[0]["ChequeNro5"].ToString() != "Interdeposito") 
	{
		if (Remito.Rows[0]["ChequeNro5"].ToString().Substring(0 , 2) != "NC")
		{
			reci.Cheques[chequeNro].dblNumCheque = Convert.ToDouble (Remito.Rows[0]["ChequeNro5"].ToString());
			reci.Cheques[chequeNro].strBanco = Remito.Rows[0]["Banco5"].ToString();
			reci.Cheques[chequeNro].dtFechaEmision = Convert.ToDateTime(Remito.Rows[0]["FechaEmision5"].ToString());
			reci.Cheques[chequeNro].dtFechaPago = Convert.ToDateTime(Remito.Rows[0]["FechaPago5"].ToString());
			//reci.Cheques[chequeNro].curImporte = Convert.ToDecimal(Remito.Rows[0]["ChImporte5"].ToString());
			reci.Cheques[chequeNro].curImporte = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte5"].ToString().Replace("$", "")), cultura);
			
			chequeNro ++;
		}
	}
}

/*
ChequeNro6
Banco6
FechaEmision6
FechaPago6
ChImporte6
*/
if (Remito.Rows[0]["ChequeNro6"].ToString() != "0") 
{
	if (Remito.Rows[0]["ChequeNro6"].ToString() != "Interdeposito") 
	{
		if (Remito.Rows[0]["ChequeNro6"].ToString().Substring(0 , 2) != "NC")
		{
			reci.Cheques[chequeNro].dblNumCheque = Convert.ToDouble (Remito.Rows[0]["ChequeNro6"].ToString());
			reci.Cheques[chequeNro].strBanco = Remito.Rows[0]["Banco6"].ToString();
			reci.Cheques[chequeNro].dtFechaEmision = Convert.ToDateTime(Remito.Rows[0]["FechaEmision6"].ToString());
			reci.Cheques[chequeNro].dtFechaPago = Convert.ToDateTime(Remito.Rows[0]["FechaPago6"].ToString());
			//reci.Cheques[chequeNro].curImporte = Convert.ToDecimal(Remito.Rows[0]["ChImporte6"].ToString());
			reci.Cheques[chequeNro].curImporte = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte5"].ToString().Replace("$", "")), cultura);
			
			chequeNro ++;
			
		}
	}
}
#endregion

#region INTERDEPOSITOS
//TODO: Revisar esto para poner los cheques que estan en la tabla de cheques
//Crea el array de los cheques
reci.Interdepositos   = new VariablesPropias.VariablesPropias.vpInterdeposito [10];
int interdepositoNro = 0;


if (Remito.Rows[0]["ChequeNro1"].ToString() == "Interdeposito")
{
	reci.Interdepositos[interdepositoNro].dblIDInterdeposito = 1;
	reci.Interdepositos[interdepositoNro].strBanco = Remito.Rows[0]["Banco1"].ToString();
	reci.Interdepositos[interdepositoNro].dtFechaEmision = Convert.ToDateTime(Remito.Rows[0]["FechaEmision1"].ToString());
	reci.Interdepositos[interdepositoNro].dtFechaPago = Convert.ToDateTime(Remito.Rows[0]["FechaPago1"].ToString());
	//reci.Cheques[1].curImporte = Convert.ToDecimal(Remito.Rows[0]["ChImporte2"].ToString());
	reci.Interdepositos[interdepositoNro].curImporte = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte1"].ToString().Replace("$", "")), cultura);
	
	interdepositoNro ++ ;
}

if (Remito.Rows[0]["ChequeNro2"].ToString() == "Interdeposito")
{
	reci.Interdepositos[interdepositoNro].dblIDInterdeposito = 1;
	reci.Interdepositos[interdepositoNro].strBanco = Remito.Rows[0]["Banco2"].ToString();
	reci.Interdepositos[interdepositoNro].dtFechaEmision = Convert.ToDateTime(Remito.Rows[0]["FechaEmision2"].ToString());
	reci.Interdepositos[interdepositoNro].dtFechaPago = Convert.ToDateTime(Remito.Rows[0]["FechaPago2"].ToString());
	//reci.Cheques[1].curImporte = Convert.ToDecimal(Remito.Rows[0]["ChImporte2"].ToString());
	reci.Interdepositos[interdepositoNro].curImporte = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte2"].ToString().Replace("$", "")), cultura);
	
	interdepositoNro ++ ;
}

if (Remito.Rows[0]["ChequeNro3"].ToString() == "Interdeposito")
{
	reci.Interdepositos[interdepositoNro].dblIDInterdeposito = 1;
	reci.Interdepositos[interdepositoNro].strBanco = Remito.Rows[0]["Banco3"].ToString();
	reci.Interdepositos[interdepositoNro].dtFechaEmision = Convert.ToDateTime(Remito.Rows[0]["FechaEmision3"].ToString());
	reci.Interdepositos[interdepositoNro].dtFechaPago = Convert.ToDateTime(Remito.Rows[0]["FechaPago3"].ToString());
	//reci.Cheques[2].curImporte = Convert.ToDecimal(Remito.Rows[0]["ChImporte2"].ToString());
	reci.Interdepositos[interdepositoNro].curImporte = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte3"].ToString().Replace("$", "")), cultura);
	
	interdepositoNro ++ ;
}

if (Remito.Rows[0]["ChequeNro4"].ToString() == "Interdeposito")
{
	reci.Interdepositos[interdepositoNro].dblIDInterdeposito = 1;
	reci.Interdepositos[interdepositoNro].strBanco = Remito.Rows[0]["Banco4"].ToString();
	reci.Interdepositos[interdepositoNro].dtFechaEmision = Convert.ToDateTime(Remito.Rows[0]["FechaEmision4"].ToString());
	reci.Interdepositos[interdepositoNro].dtFechaPago = Convert.ToDateTime(Remito.Rows[0]["FechaPago4"].ToString());
	//reci.Cheques[3].curImporte = Convert.ToDecimal(Remito.Rows[0]["ChImporte2"].ToString());
	reci.Interdepositos[interdepositoNro].curImporte = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte4"].ToString().Replace("$", "")), cultura);
	
	interdepositoNro ++ ;
}

if (Remito.Rows[0]["ChequeNro5"].ToString() == "Interdeposito")
{
	reci.Interdepositos[interdepositoNro].dblIDInterdeposito = 1;
	reci.Interdepositos[interdepositoNro].strBanco = Remito.Rows[0]["Banco5"].ToString();
	reci.Interdepositos[interdepositoNro].dtFechaEmision = Convert.ToDateTime(Remito.Rows[0]["FechaEmision5"].ToString());
	reci.Interdepositos[interdepositoNro].dtFechaPago = Convert.ToDateTime(Remito.Rows[0]["FechaPago5"].ToString());
	//reci.Cheques[4].curImporte = Convert.ToDecimal(Remito.Rows[0]["ChImporte2"].ToString());
	reci.Interdepositos[interdepositoNro].curImporte = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte5"].ToString().Replace("$", "")), cultura);
	
	interdepositoNro ++ ;
}

if (Remito.Rows[0]["ChequeNro6"].ToString() == "Interdeposito")
{
	reci.Interdepositos[interdepositoNro].dblIDInterdeposito = 1;
	reci.Interdepositos[interdepositoNro].strBanco = Remito.Rows[0]["Banco6"].ToString();
	reci.Interdepositos[interdepositoNro].dtFechaEmision = Convert.ToDateTime(Remito.Rows[0]["FechaEmision6"].ToString());
	reci.Interdepositos[interdepositoNro].dtFechaPago = Convert.ToDateTime(Remito.Rows[0]["FechaPago6"].ToString());
	//reci.Cheques[1].curImporte = Convert.ToDecimal(Remito.Rows[0]["ChImporte2"].ToString());
	reci.Interdepositos[interdepositoNro].curImporte = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte6"].ToString().Replace("$", "")), cultura);
	
	interdepositoNro ++ ;
}

#endregion

#region NOTAS DE CREDITO
//TODO: Revisar esto para poner los cheques que estan en la tabla de cheques
//Crea el array de los cheques
reci.NCs   = new VariablesPropias.VariablesPropias.vpFactura [10];

if (Remito.Rows[0]["ChequeNro1"].ToString().Length >= 3) {
	if (Remito.Rows[0]["ChequeNro1"].ToString().Substring(0 , 2) == "NC" )
	{
		reci.NCs[0].intSucursal = 1;
		reci.NCs[0].dblNumFact = Convert.ToDouble (Remito.Rows[0]["ChequeNro1"].ToString().Substring(3));
		reci.NCs[0].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FechaEmision1"].ToString());
		reci.NCs[0].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte1"].ToString().Replace("$", "")), cultura);
	}
}

if (Remito.Rows[0]["ChequeNro2"].ToString().Length >= 3) {
	if (Remito.Rows[0]["ChequeNro2"].ToString().Substring(0 , 2) == "NC" )
	{
		reci.NCs[1].intSucursal = 1;
		reci.NCs[1].dblNumFact = Convert.ToDouble (Remito.Rows[0]["ChequeNro2"].ToString().Substring(3));
		reci.NCs[1].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FechaEmision2"].ToString());
		reci.NCs[1].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte2"].ToString().Replace("$", "")), cultura);
	}
}

if (Remito.Rows[0]["ChequeNro3"].ToString().Length >= 3) {
	if (Remito.Rows[0]["ChequeNro3"].ToString().Substring(0 , 2) == "NC" )
	{
		reci.NCs[2].intSucursal = 3;
		reci.NCs[2].dblNumFact = Convert.ToDouble (Remito.Rows[0]["ChequeNro3"].ToString().Substring(3));
		reci.NCs[2].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FechaEmision3"].ToString());
		reci.NCs[2].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte3"].ToString().Replace("$", "")), cultura);
	}
}

if (Remito.Rows[0]["ChequeNro4"].ToString().Length >= 3) {
	if (Remito.Rows[0]["ChequeNro4"].ToString().Substring(0 , 2) == "NC" )
	{
		reci.NCs[3].intSucursal = 1;
		reci.NCs[3].dblNumFact = Convert.ToDouble (Remito.Rows[0]["ChequeNro4"].ToString().Substring(3));
		reci.NCs[3].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FechaEmision4"].ToString());
		reci.NCs[3].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte4"].ToString().Replace("$", "")), cultura);
	}
}

if (Remito.Rows[0]["ChequeNro5"].ToString().Length >= 3) {
	if (Remito.Rows[0]["ChequeNro5"].ToString().Substring(0 , 2) == "NC" )
	{
		reci.NCs[4].intSucursal = 5;
		reci.NCs[4].dblNumFact = Convert.ToDouble (Remito.Rows[0]["ChequeNro5"].ToString().Substring(3));
		reci.NCs[4].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FechaEmision5"].ToString());
		reci.NCs[4].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte5"].ToString().Replace("$", "")), cultura);
	}
}

if (Remito.Rows[0]["ChequeNro6"].ToString().Length >= 3) {
	if (Remito.Rows[0]["ChequeNro6"].ToString().Substring(0 , 2) == "NC" )
	{
		reci.NCs[5].intSucursal = 6;
		reci.NCs[5].dblNumFact = Convert.ToDouble (Remito.Rows[0]["ChequeNro6"].ToString().Substring(3));
		reci.NCs[5].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FechaEmision6"].ToString());
		reci.NCs[5].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte6"].ToString().Replace("$", "")), cultura);
	}
}




#endregion

#region FACTURAS
//TODO: Revisar esto para poner las facturas que estan en la tabla de facturas

//Crea el array de las Facturas
reci.Facturas  = new VariablesPropias.VariablesPropias.vpFactura [10];

/*
SucFactNum1
FactNum1
FactFecha1
Importe1
*/
if (Remito.Rows[0]["FactNum1"].ToString() != "0") {
reci.Facturas[0].intSucursal = Convert.ToInt16 (Remito.Rows[0]["SucFactNum1"].ToString());
reci.Facturas[0].dblNumFact = Convert.ToDouble (Remito.Rows[0]["FactNum1"].ToString());
reci.Facturas[0].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FactFecha1"].ToString());
//reci.Facturas[0].curTotal  = Convert.ToDecimal (Remito.Rows[0]["Importe1"].ToString());
reci.Facturas[0].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Importe1"].ToString().Replace("$", "")), cultura);
}
/*
SucFactNum2
FactNum2
FactFecha2
Importe2
*/
if (Remito.Rows[0]["FactNum2"].ToString() != "0") {
reci.Facturas[1].intSucursal = Convert.ToInt16 (Remito.Rows[0]["SucFactNum2"].ToString());
reci.Facturas[1].dblNumFact = Convert.ToDouble (Remito.Rows[0]["FactNum2"].ToString());
reci.Facturas[1].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FactFecha2"].ToString());
//reci.Facturas[1].curTotal  = Convert.ToDecimal (Remito.Rows[0]["Importe1"].ToString());
reci.Facturas[1].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Importe2"].ToString().Replace("$", "")), cultura);
}

/*
SucFactNum3
FactNum3
FactFecha3
Importe3
*/
if (Remito.Rows[0]["FactNum3"].ToString() != "0") {
reci.Facturas[2].intSucursal = Convert.ToInt16 (Remito.Rows[0]["SucFactNum3"].ToString());
reci.Facturas[2].dblNumFact = Convert.ToDouble (Remito.Rows[0]["FactNum3"].ToString());
reci.Facturas[2].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FactFecha3"].ToString());
//reci.Facturas[2].curTotal  = Convert.ToDecimal (Remito.Rows[0]["Importe3"].ToString());
reci.Facturas[2].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Importe3"].ToString().Replace("$", "")), cultura);
}

/*
SucFactNum4
FactNum4
FactFecha4
Importe4
*/
if (Remito.Rows[0]["FactNum4"].ToString() != "0") {
reci.Facturas[3].intSucursal = Convert.ToInt16 (Remito.Rows[0]["SucFactNum4"].ToString());
reci.Facturas[3].dblNumFact = Convert.ToDouble (Remito.Rows[0]["FactNum4"].ToString());
reci.Facturas[3].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FactFecha4"].ToString());
//reci.Facturas[3].curTotal  = Convert.ToDecimal (Remito.Rows[0]["Importe4"].ToString());
reci.Facturas[3].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Importe4"].ToString().Replace("$", "")), cultura);
}

/*
SucFactNum5
FactNum5
FactFecha5
Importe5
*/
if (Remito.Rows[0]["FactNum5"].ToString() != "0") {
reci.Facturas[4].intSucursal = Convert.ToInt16 (Remito.Rows[0]["SucFactNum5"].ToString());
reci.Facturas[4].dblNumFact = Convert.ToDouble (Remito.Rows[0]["FactNum5"].ToString());
reci.Facturas[4].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FactFecha5"].ToString());
//reci.Facturas[4].curTotal  = Convert.ToDecimal (Remito.Rows[0]["Importe5"].ToString());
reci.Facturas[4].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Importe5"].ToString().Replace("$", "")), cultura);
}

/*
SucFactNum6
FactNum6
FactFecha6
Importe6
*/
if (Remito.Rows[0]["FactNum6"].ToString() != "0") {
reci.Facturas[5].intSucursal = Convert.ToInt16 (Remito.Rows[0]["SucFactNum6"].ToString());
reci.Facturas[5].dblNumFact = Convert.ToDouble (Remito.Rows[0]["FactNum6"].ToString());
reci.Facturas[5].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FactFecha6"].ToString());
//reci.Facturas[5].curTotal  = Convert.ToDecimal (Remito.Rows[0]["Importe6"].ToString());
reci.Facturas[5].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Importe6"].ToString().Replace("$", "")), cultura);
}

#endregion

#region NOTAS DE DEBITO
//TODO: Revisar esto para poner los cheques que estan en la tabla de cheques
//Crea el array de los cheques
reci.NDs  = new VariablesPropias.VariablesPropias.vpFactura [10];
#endregion

/*
IDRecibo
NumRecibo
Fecha

LaSumaDe

*/

/*
Efectivo
TotValores
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

reci.curEfectivo = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Efectivo"].ToString().Replace("$", "")), cultura);

#region TotalValores

//Cheques
for (int i = 0; i < reci.Cheques.Length; i++) {
	reci.curTotalValores += reci.Cheques[i].curImporte;
}

//Interdepositos
for (int i = 0; i < reci.Interdepositos.Length; i++) {
	reci.curTotalValores += reci.Interdepositos[i].curImporte;
}


//Notas de credito

for (int i = 0; i < reci.NCs.Length; i++) {
	reci.curTotalValores += reci.NCs[i].curTotal;
}

//Efectivo
reci.curTotalValores += reci.curEfectivo;

#endregion



#region Subtotal (total de las FCs)
//Facturas
for (int i = 0; i < reci.Facturas.Length; i++) {
	reci.curSubTotal += reci.Facturas[i].curTotal;

}

//Nds
for (int i = 0; i < reci.NDs.Length; i++) {
	reci.curSubTotal += reci.NDs[i].curTotal;
}

#endregion

	
reci.curDescuento = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Descuento"].ToString().Replace("$", "")), cultura);

reci.curRetenciones = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Retenciones"].ToString().Replace("$", "")), cultura);
reci.curIngBrutos = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["RetenIIB"].ToString().Replace("$", "")), cultura);
reci.curIVA = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["RetenIVA"].ToString().Replace("$", "")), cultura);
reci.curGanancias = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["RetenGanancias"].ToString().Replace("$", "")), cultura);
reci.curCargasSoc = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["RetenCargasSoc"].ToString().Replace("$", "")), cultura);

if (Remito.Rows[0]["NO"].ToString() != "") {
reci.curNO = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["NO"].ToString().Replace("$", "")), cultura);	
}

reci.curVarios = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Varios"].ToString().Replace("$", "")), cultura);
reci.curCobranzaNeta = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["CobranzaNeta"].ToString().Replace("$", "")), cultura);

return reci;
}



/// <summary>
/// Sobrecarga de la funcion CargarRecibo. Con esta lo hacemos desde la base de datos en vez de desde el form.
/// </summary>
/// <param name="strNumeroRecibo">
/// Es el numero del recibo. Deberia ser el ID del recibo .
/// Veremos como lo arreglamos en el futuro.
/// </param>
public static VariablesPropias.VariablesPropias.vpRecibo CargarReciboNvo(string strNumeroRecibo)
{

#region Cultura
			CultureInfo cultura = new CultureInfo("es-AR");
			CultureInfo culture = new CultureInfo("en-US");
#endregion

#region Variables
VariablesPropias.VariablesPropias.vpRecibo reci = new VariablesPropias.VariablesPropias.vpRecibo();
#endregion

#region DB

ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseRecibos"].ToString());

//tener en cuenta que primero va la condicion y luego el Order by
ConexionAccess2007.Consultar("Recibo", "*", "NumRecibo = '" + strNumeroRecibo +"'", "NumRecibo" );

//Nueva Tabla
DataTable Remito = new DataTable();
//Cargo la tabla con los datos de la Base de Datos
Remito = ConexionAccess2007.Table;


#endregion

//Cargo los datos en una vp (Variable propia) para despues pasarlo a cada parte
//lo hago asi para que luego si cambio algo no se joda todo.

#region ENCABEZADO
reci.dtFecha = Convert.ToDateTime (Remito.Rows[0]["Fecha"].ToString());
reci.dblNumReci = Convert.ToDouble (Remito.Rows[0]["NumRecibo"].ToString());
#endregion

#region CLIENTE

reci.Cliente = OperacionesComunes.ObtenerCliente(Convert.ToInt32(Remito.Rows[0]["IDCliente"].ToString()));
#endregion

#region CHEQUES

//Crea el array de los cheques
reci.Cheques  = OperacionesComunes.ObtenerCheque(Remito.Rows[0]["IDRecibo"].ToString() );

#endregion

#region INTERDEPOSITOS

//Crea el array de los Interdepositos
reci.Interdepositos   = OperacionesComunes.ObtenerInterdeposito(Remito.Rows[0]["IDRecibo"].ToString() );

#endregion


/*
 * En esta area se tomas los datos de la base de datos de Clientes MEJORAR
 */



reci.NDs = OperacionesComunes.ObtenerNotaDebito (strNumeroRecibo);

/*
#region NOTAS DE CREDITO

//TODO: Revisar esto para poner los cheques que estan en la tabla de cheques
//Crea el array de los cheques
reci.NCs   = new VariablesPropias.VariablesPropias.vpFactura [10];

if (Remito.Rows[0]["ChequeNro1"].ToString().Length >= 3) {
	if (Remito.Rows[0]["ChequeNro1"].ToString().Substring(0 , 2) == "NC" )
	{
		reci.NCs[0].intSucursal = 1;
		reci.NCs[0].dblNumFact = Convert.ToDouble (Remito.Rows[0]["ChequeNro1"].ToString().Substring(3));
		reci.NCs[0].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FechaEmision1"].ToString());
		reci.NCs[0].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte1"].ToString().Replace("$", "")), cultura);
	}
}

if (Remito.Rows[0]["ChequeNro2"].ToString().Length >= 3) {
	if (Remito.Rows[0]["ChequeNro2"].ToString().Substring(0 , 2) == "NC" )
	{
		reci.NCs[1].intSucursal = 1;
		reci.NCs[1].dblNumFact = Convert.ToDouble (Remito.Rows[0]["ChequeNro2"].ToString().Substring(3));
		reci.NCs[1].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FechaEmision2"].ToString());
		reci.NCs[1].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte2"].ToString().Replace("$", "")), cultura);
	}
}

if (Remito.Rows[0]["ChequeNro3"].ToString().Length >= 3) {
	if (Remito.Rows[0]["ChequeNro3"].ToString().Substring(0 , 2) == "NC" )
	{
		reci.NCs[2].intSucursal = 3;
		reci.NCs[2].dblNumFact = Convert.ToDouble (Remito.Rows[0]["ChequeNro3"].ToString().Substring(3));
		reci.NCs[2].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FechaEmision3"].ToString());
		reci.NCs[2].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte3"].ToString().Replace("$", "")), cultura);
	}
}

if (Remito.Rows[0]["ChequeNro4"].ToString().Length >= 3) {
	if (Remito.Rows[0]["ChequeNro4"].ToString().Substring(0 , 2) == "NC" )
	{
		reci.NCs[3].intSucursal = 1;
		reci.NCs[3].dblNumFact = Convert.ToDouble (Remito.Rows[0]["ChequeNro4"].ToString().Substring(3));
		reci.NCs[3].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FechaEmision4"].ToString());
		reci.NCs[3].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte4"].ToString().Replace("$", "")), cultura);
	}
}

if (Remito.Rows[0]["ChequeNro5"].ToString().Length >= 3) {
	if (Remito.Rows[0]["ChequeNro5"].ToString().Substring(0 , 2) == "NC" )
	{
		reci.NCs[4].intSucursal = 5;
		reci.NCs[4].dblNumFact = Convert.ToDouble (Remito.Rows[0]["ChequeNro5"].ToString().Substring(3));
		reci.NCs[4].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FechaEmision5"].ToString());
		reci.NCs[4].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte5"].ToString().Replace("$", "")), cultura);
	}
}

if (Remito.Rows[0]["ChequeNro6"].ToString().Length >= 3) {
	if (Remito.Rows[0]["ChequeNro6"].ToString().Substring(0 , 2) == "NC" )
	{
		reci.NCs[5].intSucursal = 6;
		reci.NCs[5].dblNumFact = Convert.ToDouble (Remito.Rows[0]["ChequeNro6"].ToString().Substring(3));
		reci.NCs[5].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FechaEmision6"].ToString());
		reci.NCs[5].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["ChImporte6"].ToString().Replace("$", "")), cultura);
	}
}




#endregion

#region FACTURAS
//TODO: Revisar esto para poner las facturas que estan en la tabla de facturas

//Crea el array de las Facturas
reci.Facturas  = new VariablesPropias.VariablesPropias.vpFactura [10];

/*
SucFactNum1
FactNum1
FactFecha1
Importe1
*
if (Remito.Rows[0]["FactNum1"].ToString() != "0") {
reci.Facturas[0].intSucursal = Convert.ToInt16 (Remito.Rows[0]["SucFactNum1"].ToString());
reci.Facturas[0].dblNumFact = Convert.ToDouble (Remito.Rows[0]["FactNum1"].ToString());
reci.Facturas[0].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FactFecha1"].ToString());
//reci.Facturas[0].curTotal  = Convert.ToDecimal (Remito.Rows[0]["Importe1"].ToString());
reci.Facturas[0].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Importe1"].ToString().Replace("$", "")), cultura);
}
/*
SucFactNum2
FactNum2
FactFecha2
Importe2
*
if (Remito.Rows[0]["FactNum2"].ToString() != "0") {
reci.Facturas[1].intSucursal = Convert.ToInt16 (Remito.Rows[0]["SucFactNum2"].ToString());
reci.Facturas[1].dblNumFact = Convert.ToDouble (Remito.Rows[0]["FactNum2"].ToString());
reci.Facturas[1].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FactFecha2"].ToString());
//reci.Facturas[1].curTotal  = Convert.ToDecimal (Remito.Rows[0]["Importe1"].ToString());
reci.Facturas[1].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Importe2"].ToString().Replace("$", "")), cultura);
}

/*
SucFactNum3
FactNum3
FactFecha3
Importe3
*
if (Remito.Rows[0]["FactNum3"].ToString() != "0") {
reci.Facturas[2].intSucursal = Convert.ToInt16 (Remito.Rows[0]["SucFactNum3"].ToString());
reci.Facturas[2].dblNumFact = Convert.ToDouble (Remito.Rows[0]["FactNum3"].ToString());
reci.Facturas[2].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FactFecha3"].ToString());
//reci.Facturas[2].curTotal  = Convert.ToDecimal (Remito.Rows[0]["Importe3"].ToString());
reci.Facturas[2].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Importe3"].ToString().Replace("$", "")), cultura);
}

/*
SucFactNum4
FactNum4
FactFecha4
Importe4
*
if (Remito.Rows[0]["FactNum4"].ToString() != "0") {
reci.Facturas[3].intSucursal = Convert.ToInt16 (Remito.Rows[0]["SucFactNum4"].ToString());
reci.Facturas[3].dblNumFact = Convert.ToDouble (Remito.Rows[0]["FactNum4"].ToString());
reci.Facturas[3].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FactFecha4"].ToString());
//reci.Facturas[3].curTotal  = Convert.ToDecimal (Remito.Rows[0]["Importe4"].ToString());
reci.Facturas[3].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Importe4"].ToString().Replace("$", "")), cultura);
}

/*
SucFactNum5
FactNum5
FactFecha5
Importe5
*
if (Remito.Rows[0]["FactNum5"].ToString() != "0") {
reci.Facturas[4].intSucursal = Convert.ToInt16 (Remito.Rows[0]["SucFactNum5"].ToString());
reci.Facturas[4].dblNumFact = Convert.ToDouble (Remito.Rows[0]["FactNum5"].ToString());
reci.Facturas[4].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FactFecha5"].ToString());
//reci.Facturas[4].curTotal  = Convert.ToDecimal (Remito.Rows[0]["Importe5"].ToString());
reci.Facturas[4].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Importe5"].ToString().Replace("$", "")), cultura);
}

/*
SucFactNum6
FactNum6
FactFecha6
Importe6
*
if (Remito.Rows[0]["FactNum6"].ToString() != "0") {
reci.Facturas[5].intSucursal = Convert.ToInt16 (Remito.Rows[0]["SucFactNum6"].ToString());
reci.Facturas[5].dblNumFact = Convert.ToDouble (Remito.Rows[0]["FactNum6"].ToString());
reci.Facturas[5].dtFecha = Convert.ToDateTime (Remito.Rows[0]["FactFecha6"].ToString());
//reci.Facturas[5].curTotal  = Convert.ToDecimal (Remito.Rows[0]["Importe6"].ToString());
reci.Facturas[5].curTotal = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Importe6"].ToString().Replace("$", "")), cultura);
}

#endregion

#region NOTAS DE DEBITO
//TODO: Revisar esto para poner los cheques que estan en la tabla de cheques
//Crea el array de los cheques
reci.NDs  = new VariablesPropias.VariablesPropias.vpFactura [10];
#endregion

/*
IDRecibo
NumRecibo
Fecha

LaSumaDe

*/


#region Efectivo
//reci.curEfectivo = Remito.Rows[0]["IDRecibo"].ToString();
#endregion

#region TotValores



#endregion


#region CobranzaNeta

reci.curCobranzaNeta =Convert.ToDecimal (Remito.Rows[0]["Total"].ToString());
#endregion

/*


SubTotal
Descuento
Retenciones
RetenIIB
RetenIVA
RetenGanancias
RetenCargasSoc
NO
Varios

HechoPor


*

reci.curEfectivo = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Efectivo"].ToString().Replace("$", "")), cultura);

#region TotalValores

//Cheques
for (int i = 0; i < reci.Cheques.Length; i++) {
	reci.curTotalValores += reci.Cheques[i].curImporte;
}

//Interdepositos
for (int i = 0; i < reci.Interdepositos.Length; i++) {
	reci.curTotalValores += reci.Interdepositos[i].curImporte;
}


//Notas de credito

for (int i = 0; i < reci.NCs.Length; i++) {
	reci.curTotalValores += reci.NCs[i].curTotal;
}

//Efectivo
reci.curTotalValores += reci.curEfectivo;

#endregion



#region Subtotal (total de las FCs)
//Facturas
for (int i = 0; i < reci.Facturas.Length; i++) {
	reci.curSubTotal += reci.Facturas[i].curTotal;

}

//Nds
for (int i = 0; i < reci.NDs.Length; i++) {
	reci.curSubTotal += reci.NDs[i].curTotal;
}

#endregion

	
reci.curDescuento = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Descuento"].ToString().Replace("$", "")), cultura);

reci.curRetenciones = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Retenciones"].ToString().Replace("$", "")), cultura);
reci.curIngBrutos = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["RetenIIB"].ToString().Replace("$", "")), cultura);
reci.curIVA = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["RetenIVA"].ToString().Replace("$", "")), cultura);
reci.curGanancias = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["RetenGanancias"].ToString().Replace("$", "")), cultura);
reci.curCargasSoc = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["RetenCargasSoc"].ToString().Replace("$", "")), cultura);

if (Remito.Rows[0]["NO"].ToString() != "") {
reci.curNO = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["NO"].ToString().Replace("$", "")), cultura);	
}

reci.curVarios = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["Varios"].ToString().Replace("$", "")), cultura);
reci.curCobranzaNeta = Convert.ToDecimal(Convert.ToDecimal (Remito.Rows[0]["CobranzaNeta"].ToString().Replace("$", "")), cultura);
*/


return reci;
}




}
}
