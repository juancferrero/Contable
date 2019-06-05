/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 29/06/2017
 * Hora: 11:04 a.m.
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
using Contable.Modulos;

using CodigoDeBarras;


namespace Contable.Modulos
{
	/// <summary>
	/// Description of Documentos_Fiscales.
	/// </summary>
	public class Documentos_Fiscales
	{
		public Documentos_Fiscales()
		{
		}
		

/// <summary>
/// 
/// </summary>
/// <param name="intNumeroFactura"></param>
/// <returns></returns>
		public static VariablesPropias.VariablesPropias.vpFactura CargarFCA(int intNumeroFactura)
{

#region Cultura
			CultureInfo cultura = new CultureInfo("es-AR");
			CultureInfo culture = new CultureInfo("en-US");
#endregion

#region Variables
		 VariablesPropias.VariablesPropias.vpFactura Fact= new VariablesPropias.VariablesPropias.vpFactura();

#endregion

#region DB

ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());

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
		
		Fact.strComprobante = Factura.Rows[0]["Documento"].ToString();

		
		//Cliente
		Fact.Cliente = OperacionesComunes.ObtenerCliente(Factura.Rows[0]["Nombre"].ToString());
			
		//Remitos
		Fact.intRemito1 = Convert.ToInt16(Factura.Rows[0]["Remito1"].ToString());
		Fact.intRemito2 = Convert.ToInt16(Factura.Rows[0]["Remito2"].ToString());
		Fact.intRemito3 = Convert.ToInt16(Factura.Rows[0]["Remito3"].ToString());
		Fact.intRemito4 = Convert.ToInt16(Factura.Rows[0]["Remito4"].ToString());
		
		
		//Crea el array de los productos directamente segun la cantidad de lineas del grid
		Fact.Productos = new VariablesPropias.VariablesPropias.vpProducto[10];
		
	
		
		//Producto
		//Productos 1
		
		Fact.Productos[0].intCantidad = Convert.ToInt16(Factura.Rows[0]["Cant1"].ToString());
		Fact.Productos[0].strDescripcion = Factura.Rows[0]["Detalle1"].ToString();
		Fact.Productos[0].curPrecioNeto = Convert.ToDecimal(Factura.Rows[0]["PrecioUnitario1"].ToString());
		Fact.Productos[0].curPrecioSubTotal=  Convert.ToDecimal(Convert.ToDouble(Factura.Rows[0]["PrecioUnitario1"].ToString()) * 
		                                                        Convert.ToInt16(Factura.Rows[0]["Cant1"].ToString()));
		Fact.Productos[0].dblTipoIVA = Convert.ToDouble("21");
		Fact.Productos[0].curIVAProdu = Convert.ToDecimal (Convert.ToDouble(Factura.Rows[0]["PrecioFinal1"].ToString()) * 0.21);
		Fact.Productos[0].curPrecioTotal =Convert.ToDecimal(Factura.Rows[0]["PrecioFinal1"].ToString());

		//Productos 2
		if (Factura.Rows[0]["Detalle2"].ToString() != "")
		{
		Fact.Productos[1].intCantidad = Convert.ToInt16(Factura.Rows[0]["Cant2"].ToString());
		Fact.Productos[1].strDescripcion = Factura.Rows[0]["Detalle2"].ToString();
		Fact.Productos[1].curPrecioNeto = Convert.ToDecimal(Factura.Rows[0]["PrecioUnitario2"].ToString());
		Fact.Productos[1].curPrecioSubTotal= Convert.ToDecimal(Convert.ToDouble(Factura.Rows[0]["PrecioUnitario2"].ToString()) * 
		                                                       Convert.ToInt16(Factura.Rows[0]["Cant2"].ToString()) );
		Fact.Productos[1].dblTipoIVA = Convert.ToDouble("21");
		Fact.Productos[1].curIVAProdu = Convert.ToDecimal (Convert.ToDouble(Factura.Rows[0]["PrecioFinal2"].ToString()) * 0.21);
		Fact.Productos[1].curPrecioTotal =Convert.ToDecimal(Convert.ToDouble(Factura.Rows[0]["PrecioFinal2"].ToString()) );
		}
		
		//Productos 3
		if (Factura.Rows[0]["Detalle3"].ToString() != "")
		{
		Fact.Productos[2].intCantidad = Convert.ToInt16(Factura.Rows[0]["Cant3"].ToString());
		Fact.Productos[2].strDescripcion = Factura.Rows[0]["Detalle3"].ToString();
		Fact.Productos[2].curPrecioNeto = Convert.ToDecimal(Factura.Rows[0]["PrecioUnitario3"].ToString());
		Fact.Productos[2].curPrecioSubTotal= Convert.ToDecimal(Convert.ToDouble(Factura.Rows[0]["PrecioUnitario3"].ToString()) * 
		                                                       Convert.ToInt16(Factura.Rows[0]["Cant3"].ToString()) );
		Fact.Productos[2].dblTipoIVA = Convert.ToDouble("21");
		Fact.Productos[2].curIVAProdu = Convert.ToDecimal (Convert.ToDouble(Factura.Rows[0]["PrecioFinal3"].ToString()) * 0.21);
		Fact.Productos[2].curPrecioTotal =Convert.ToDecimal(Convert.ToDouble(Factura.Rows[0]["PrecioFinal3"].ToString()) );
		}
		
		//Productos 4
		if (Factura.Rows[0]["Detalle4"].ToString() != "")
		{
		Fact.Productos[3].intCantidad = Convert.ToInt16(Factura.Rows[0]["Cant4"].ToString());
		Fact.Productos[3].strDescripcion = Factura.Rows[0]["Detalle4"].ToString();
		Fact.Productos[3].curPrecioNeto = Convert.ToDecimal(Factura.Rows[0]["PrecioUnitario4"].ToString());
		Fact.Productos[3].curPrecioSubTotal= Convert.ToDecimal(Convert.ToDouble(Factura.Rows[0]["PrecioUnitario4"].ToString()) * 
		                                                       Convert.ToInt16(Factura.Rows[0]["Cant4"].ToString()) );
		Fact.Productos[3].dblTipoIVA = Convert.ToDouble("21");
		Fact.Productos[3].curIVAProdu = Convert.ToDecimal (Convert.ToDouble(Factura.Rows[0]["PrecioFinal4"].ToString()) * 0.21);
		Fact.Productos[3].curPrecioTotal =Convert.ToDecimal(Convert.ToDouble(Factura.Rows[0]["PrecioFinal4"].ToString()) * 1.21);
		}
		
		//Impuestos

		Fact.curSubTotalUSD =Convert.ToDecimal(Math.Round(Convert.ToDouble(Factura.Rows[0]["SubTotalUSS"].ToString()),2));
		Fact.curIVAUSD = Convert.ToDecimal(Math.Round(Convert.ToDouble(Factura.Rows[0]["IVAUSS"].ToString()),2));
		Fact.curTotalUSD = Convert.ToDecimal(Math.Round(Convert.ToDouble(Factura.Rows[0]["ImporteFinalUSS"].ToString()),2));
		
		Fact.curSubTotal =Convert.ToDecimal(Math.Round(Convert.ToDouble(Factura.Rows[0]["SubTotal"].ToString()),2));
		Fact.curIVA = Convert.ToDecimal(Math.Round(Convert.ToDouble(Factura.Rows[0]["IVA"].ToString()),2));
		Fact.curTotal = Convert.ToDecimal(Math.Round(Convert.ToDouble(Factura.Rows[0]["ImporteFinal"].ToString()) , 2));
		
		//Valores
		
		Fact.strCAE = Factura.Rows[0]["CAE"].ToString();
		
		Fact.strFechVtoCAE = Factura.Rows[0]["FechaVencCAE"].ToString();

		
		
		Fact.strCodBarrasNum = "30708466200" + "01" + "03" + Fact.strCAE +	Fact.strFechVtoCAE ; 
		Fact.strCodBarrasNum += CodigoDeBarras.CodigoBarras.CodVerificador(Fact.strCodBarrasNum).ToString();
		
		Fact.picCodBarras = CodigoDeBarras.CodigoBarras.Print2of5Interleaved (Fact.strCodBarrasNum);
		
		
		
		return Fact;
		
		}
		
	}
}
