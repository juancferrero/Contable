using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Net.Mail;
using System.Net.Mime;
using System.Resources;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;


namespace VariablesPropias
	
{
	public class VariablesPropias
	{


		public struct vpCheque
		{
			//ID
			public string strIDCheque;
			
			//Fecha
			public System.DateTime dtFechaEmision;
			public System.DateTime dtFechaPago;
			public System.DateTime dtFechaIngreso;
			public System.DateTime dtFechaDeposito;
			
			//Importe
			public decimal curImporte;
			public decimal curImporteUSD;
			
			//Cliente
			public string strIDCliente;
			
			//Recibo
			public string strIDRecibo;
			
			//Cheque
			public string strNumCheque;
			public double dblNumCheque;
			public string strBanco;
			public string strSucursal;
			public string strTerceros;
			
			
		}

		public struct vpInterdeposito
		{
			public double dblIDInterdeposito;
			public double dblNumInterdeposito;
			public System.DateTime dtFechaEmision;
			public System.DateTime dtFechaPago;
			public string strBanco;
			public string strSucursal;
			public string strBancoDestino;
			public string strCliente;
			public string strIDCliente;
			public decimal curImporte;
		}

		public struct vpClientes
		{
			public string strid;
			public string strNombre;
			public string strDireccion;
			public string strLocalidad;
			public string strProvincia;
			public string strCodPos;
			public string strPosIVA;
			public double dblDescuento;
			public double dblCUIT;
			public int intTranspId;//como que sobra esta en el vpTransporte
			public vpTransporte Transporte;
			public string strTelefono1;
			public string strTelefono2;
			public string strTelefono3;
			public vpClieContacto[] Contactos;
			public string stremail;
			public string memoVarios;
			public string GLN;
			public string strClienteDe;
			public bool bolActivo;
			public double dlbCalidad;
			
		
		}
		
		public struct vpClieContacto
		{
			public string strid;
			public string strNombre;
			public string strDireccion;
			public string strLocalidad;
			public string strProvincia;
		}
		
		public struct vpProducto
		{
			public string strid;
			public short intCantidad;
			public string strDescripcion;
			public decimal curPrecioNeto; //Precio Unitario
			public decimal curPrecioSubTotal;
			public double dblTipoIVA;
			public decimal curIVAProdu;
			public decimal curPrecioTotal;
			public vpTrazabilidad Trazabilidad;
		}

		public struct vpFactura
		{
				//Esto es si es FACTURA, NOTA DE CREDITO, NOTA DE DEBITO
			public string strTipoDoc;
			public string strTipoFc;
			public string strCodFc;
			public short intSucursal;
			public double dblNumFact;
			public string strComprobante;
			public System.DateTime dtFecha;
			public vpClientes Cliente;
			public double dblTipoCambio;
			
			public short[] Remitos;
			
			public short intRemito1;
			public short intRemito2;
			public short intRemito3;
			public short intRemito4;
			
			public vpProducto[] Productos;
			
			public vpProducto Producto1;
			public vpProducto Producto2;
			public vpProducto Producto3;
			public vpProducto Producto4;
			public vpProducto Producto5;
			public decimal curSubTotal;
			public decimal curIVA;
			public int IdIVA;
			public decimal curTotal;
			public decimal curSubTotalUSD;
			public decimal curIVAUSD;
			public decimal curTotalUSD;
			public string strCAE;
			public string strFechVtoCAE;
			
			public Image  picCodBarras;

			public string strCodBarrasNum;
		}

		public struct vpRemito
		{
			public string IDRemito;
			public short intSucursal;
			public double dblNumRemi;
			public System.DateTime dtFecha;
			
			public vpClientes Cliente;
			
			public vpTransporte Transporte;
			
			public string strPedido;
			
			public vpProducto[] Productos;
			
			public vpProducto Producto1;
			public vpProducto Producto2;
			public vpProducto Producto3;
			public vpProducto Producto4;
			public vpProducto Producto5;
			
			public string strBultos;
			
			public string strChofer;
			
			public string strNota;
			
			
			
			public decimal curSubTotal;

			public decimal curTotal;
			
			public PictureBox picCodBarras;

			public string strCodBarrasNum;
			public string strFechaVto;
			public string strFechaImpresion;
			public string strCAI;
		}

		public struct vpRecibo
		{
			public double dblNumReci;
			public System.DateTime dtFecha;
			public vpClientes Cliente;
			//Este es un array de estructura de Cheques
			public vpCheque[] Cheques;
		

			//Esto es un array de estructura de Interdepositos
			public vpInterdeposito[] Interdepositos;
		
			public vpFactura[] NCs;
			
			
			
			public string strEnLetras;
			public decimal curEfectivo;
			public decimal curTotalValores;
			//Esto es un array de estructura de Facturas
			public vpFactura[] Facturas;
			public vpFactura[] FacturasB;
			
			public vpFactura[] NDs;
			
			
			
				//Decimales mejor que Double para los importes
			public decimal curSubTotal;
			public decimal curDescuento;
			public decimal curRetenciones;
			public decimal curNO;
			public decimal curVarios;
			public decimal curCobranzaNeta;
			public decimal curIngBrutos;
			public decimal curIVA;
			public decimal curGanancias;
			public decimal curCargasSoc;
		
			public void initialize()
			{
				//Cheques(10) = New vpCheque
			}

		}

		public struct vpMargenesFact
		{
			//las coordenandas deben estar en Single
			public float sngTipoX;
			public float sngTipoY;

			public float sngCodFCX;
			public float sngCodFCY;

			public float sngNumeroFactX;
			public float sngNumeroFactY;

			public float sgnPtoVentaX;
			public float sgnPtoVentaY;
			
			public float sngFechaX;
			public float sngFechaY;

			public float sngRazonSocX;
			public float sngRazonSocY;

			public float sngDomicilioX;
			public float sngDomicilioY;

			public float sngLocalidadX;
			public float sngLocalidadY;

			public float sngProvinciaX;
			public float sngProvinciaY;

			public float sngCUITX;
			public float sngCUITY;

			public float sngPosIVAX;
			public float sngPosIVAY;

			public float sngTCambioX;
			public float sngTCambioY;


			//Remitos
			public float sngRemi1X;

			public float sngRemi1Y;
			public float sngRemi2X;

			public float sngRemi2Y;
			public float sngRemi3X;

			public float sngRemi3Y;
			public float sngRemi4X;

			public float sngRemi4Y;



			//Producto1
			//Personalmente creo que la variable sng*****Y podria ser reemplazada por una sola
			//Ej: sngProducto1Y y cada una de las X variara pero tambien deberian setearse como unicas.

			public float sngDetalle1X;

			public float sngDetalle1Y;
			public float sngCant1X;

			public float sngCant1Y;
			public float sngMedida1X;

			public float sngMedida1Y;
			public float sngPrecioUnit1X;

			public float sngPrecioUnit1Y;
			public float sngBonificacion1X;

			public float sngBonificacion1Y;
			public float sngSubTotal1X;

			public float sngSubTotal1Y;
			public float sngAlicuota1X;

			public float sngAlicuota1Y;
			public float sngSubTotalCIVA1X;

			public float sngSubTotalCIVA1Y;

			//Producto2
			public float sngCant2X;

			public float sngCant2Y;
			public float sngDetalle2X;

			public float sngDetalle2Y;
			public float sngMedida2X;

			public float sngMedida2Y;

			public float sngPrecioUnit2X;

			public float sngPrecioUnit2Y;
			public float sngBonificacion2X;

			public float sngBonificacion2Y;
			public float sngSubTotal2X;

			public float sngSubTotal2Y;
			public float sngAlicuota2X;

			public float sngAlicuota2Y;
			public float sngSubTotalCIVA2X;

			public float sngSubTotalCIVA2Y;
			//Producto3
			public float sngCant3X;

			public float sngCant3Y;
			public float sngDetalle3X;

			public float sngDetalle3Y;
			public float sngMedida3X;

			public float sngMedida3Y;
			public float sngPrecioUnit3X;

			public float sngPrecioUnit3Y;
			public float sngBonificacion3X;

			public float sngBonificacion3Y;
			public float sngSubTotal3X;

			public float sngSubTotal3Y;
			public float sngAlicuota3X;

			public float sngAlicuota3Y;
			public float sngSubTotalCIVA3X;

			public float sngSubTotalCIVA3Y;
			//Producto4
			public float sngCant4X;

			public float sngCant4Y;
			public float sngDetalle4X;

			public float sngDetalle4Y;
			public float sngMedida4X;

			public float sngMedida4Y;
			public float sngPrecioUnit4X;

			public float sngPrecioUnit4Y;
			public float sngBonificacion4X;

			public float sngBonificacion4Y;
			public float sngSubTotal4X;

			public float sngSubTotal4Y;
			public float sngAlicuota4X;

			public float sngAlicuota4Y;
			public float sngSubTotalCIVA4X;

			public float sngSubTotalCIVA4Y;
			//Producto5
			public float sngCant5X;

			public float sngCant5Y;
			public float sngDetalle5X;

			public float sngDetalle5Y;
			public float sngMedida5X;

			public float sngMedida5Y;
			public float sngPrecioUnit5X;

			public float sngPrecioUnit5Y;
			public float sngBonificacion5X;

			public float sngBonificacion5Y;
			public float sngSubTotal5X;

			public float sngSubTotal5Y;
			public float sngAlicuota5X;

			public float sngAlicuota5Y;
			public float sngSubTotalCIVA5X;

			public float sngSubTotalCIVA5Y;

			//SubTotal
			public float sngSubtotalX;

			public float sngSubtotalY;
			//IVA
			public float sngIVAX;

			public float sngIVAY;
			//Total
			public float sngTotalX;

			public float sngTotalY;

			//Total En Pesos
			public float sngTotalPesosX;

			public float sngTotalPesosY;


			//CAE
			public float sngCAEX;

			public float sngCAEY;

			//FchVtoCAE
			public float sngFVtoCAEX;

			public float sngFVtoCAEY;
			//Codigo de Barras
			public float sngCodBarrasX;
			public float sngCodBarrasY;
			public float sngNumCodBarrasX;

			public float sngNumCodBarrasY;


		}

		public struct vpMargenesRemito
		{
			//las coordenandas deben estar en Single
			
			public float sngNumeroRemiX;
			public float sngNumeroRemiY;

			public float sngFechaX;
			public float sngFechaY;

			public float sngRazonSocX;
			public float sngRazonSocY;

			public float sngDomicilioX;
			public float sngDomicilioY;

			public float sngLocalidadX;
			public float sngLocalidadY;

			public float sngProvinciaX;
			public float sngProvinciaY;

			public float sngCUITX;
			public float sngCUITY;

			public float sngPosIVAX;
			public float sngPosIVAY;

			
			//Transporte
			
			public float sngTranspNombreX;
			public float sngTranspNombreY;
			
			public float sngTranspDireccionX;
			public float sngTranspDireccionY;
			
			
			//Pedido
			public float sngPedidoNroX;
			public float sngPedidoNroY;
			
			
			//Mercaderia
			public float sngCantX;
			public float sngCantY;
			
			public float sngDetalleX;
			public float sngDetalleY;
			
			public float sngPrecUnitX;
			public float sngPrecUnitY;
			
			public float sngImporteX;
			public float sngImporteY;
			
			public float sngTrazaX;
			public float sngTrazaY;
			
			
			//Bultos
			
			public float sngBultosX;
			public float sngBultosY;
			
			//Transportado por
			public float sngChoferX;
			public float sngChoferY;
			
			//Valor Declarado
			
			public float sngValorDeclaradoX;
			public float sngValorDeclaradoY;
			
			//Nota
			
			public float sngNotaX;
			public float sngNotaY;

			//AFIP
			
			public float sngCodBarrasX;
			public float sngCodBarrasY;	
			
			public float sngCAIX;
			public float sngCAIY;
			
			public float sngFechaVtoX;
			public float sngFechaVtoY;
			
			public float sngFechaImprX;
			public float sngFechaImprY;

		}
		
		public struct vpMargenesRecibo
		{
			//las coordenandas deben estar en Single
			public float sngNumeroReciX;
			public float sngNumeroReciY;
			
			public float sngFechaX;
			public float sngFechaY;

			public float sngRazonSocX;
			public float sngRazonSocY;

			public float sngDomicilioX;
			public float sngDomicilioY;

			public float sngLocalidadX;
			public float sngLocalidadY;

			public float sngProvinciaX;
			public float sngProvinciaY;
			
			
			
			public float sngLaSumaDeX;
			public float sngLaSumaDeY;

			//Facturas 
			//Se coloca la primera linea despues se saca desde ahi agregando 0,5 cm por linea al valor Y 
			public float sngFactX;
			public float sngFactY;
			
			/// <summary>
			/// Posicion de la fecha en X, para Y usar sngFactY
			/// </summary>
			public float sngFactFechaX;
			//public float sngFactFechaY; Sobra usar sngFactY
			
			public float sngFactImpoteX;
			//public float sngFactImporteY; Sobra usar sngFactY
			
			public float sngFactImpoteUSDX;
			//public float sngFactImporteUSDY; Sobra usar sngFactY

			//Cheque
			//Personalmente creo que la variable sng*****Y podria ser reemplazada por una sola
			//Ej: sngProducto1Y y cada una de las X variara pero tambien deberian setearse como unicas. 

			public float sngNumCheqX;
			public float sngNumCheqY;
			
			public float sngBancoX;
			//public float sngBancoY; Sobra usar sngNumCheqY 
			
			public float sngSucursalX;
			//public float sngSucursalY; Sobra usar sngNumCheqY 
			
			public float sngFechEmisionX;
			//public float sngFechEmisionY; Sobra usar sngNumCheqY 
			
			public float sngFechPagoX;
			//public float sngFechPagoY; Sobra usar sngNumCheqY 
			
			public float sngCHImporteX;
			//public float sngCHImporte1Y; Sobra usar sngNumCheqY 

			

			//Total Valores
			public float sngTotalValoresX;
			public float sngTotalValoresY;


			public float sngEfectivoX;
			public float sngEfectivoY;
			
			
			//----- Facturas ----
			//SubTotal
			public float sngSubtotalX;
			public float sngSubtotalY;
			
			//Descuento
			public float sngDescuentoX;
			public float sngDescuentoY;

			//Retenciones
			public float sngRetencionesX;
			public float sngRetencionesY;
			
			//NO
			public float sngNOX;
			public float sngNOY;
			
			//Varios
			public float sngVariosX;
			public float sngVariosY;

			//Total Valores
			public float sngTotalCobranzaX;
			public float sngTotalCobranzaY;

		}

		//STOCK
		public struct vpTrazabilidad
		{
			public string strNumPartida;
			public string strVolumen;
			public string strEmbalajes;
		}


		public struct vpProveedores
		{
			/// <summary>
			/// Esta estructura es la de un proveedor
			/// </summary>
			public string Id;
			public string Nombre;
			public string Cuit;
			public string Direccion;
			public string Localidad;
			public string Provincia;
			public string Concepto;
			public string Cuenta;
			public string Subcuenta;
			public string Items;
			public string CuentaCredito;
			public string CuentaDebito;


		}

		public struct vpComprobanteGastos
		{
			//Esto es basicamente una Factura de gastos
			//Alias Factura con Iva

			public int ID;
			//La estructura de Proveedores me permite guardar los datos directamente ahi asi
			//evito duplicar variables

			public vpProveedores Proveedor;
			//Resto de las variables necesarias
			public string strNumFact;
			public System.DateTime dtEntrada;
			public System.DateTime dtFecha;
			public decimal curImpBruto;
			public decimal curIva105;
			public decimal curIva21;
			public decimal curIva27;
			public decimal curIngBrutos;
			public decimal curPercIva;
			public decimal curNoGravados;
			public decimal curImpNeto;

			public string strTipoFact;
			
			public vpImpuestos[] Impuestos;
			
			
			public string strConcepto;
			public string strCuenta;
			public string strSubCuenta;
			public string strItems;
		}


		
		public struct vpTransporte
		{
			public int intTranspId;
			public string strNombre;
			public string strDireccion;
			public string strHorario;
			
		}

/// <summary>
/// CAI Remito son todas las variables para cargar el Cod de Aut de Impresión de Remitos
/// </summary>
		public struct vpCAIRemito
		{
			public string strCAI;
			public string strFechaVenc;
			public string strCodigoACargar;
			public string strFechaImpresion;
		}


/// <summary>
/// Forma el pedido para pasarlo al remito
/// </summary>
		public struct vpPedido
		{
			public string strid;
			public vpProducto[] producto;
			
		}

#region SENASA

/// <summary>
/// Esta estructura cuenta con los datos para armar un certificado para enviar al SENASA.
/// Es mas claro 
///</summary>
		public struct vpTrazabilidadSENASA
		{
			public string strNumPartida;
			public string strVolumen;
			public string strEmbalajes;
			
			
			
			public string fecha; //= DateTime.Now.ToString("dd/MM/yyyy")
            public int id_evento;
            public bool id_eventoSpecified;
            public int n_cantidad;
            public bool n_cantidadSpecified;
            public string nro_lote;
            public string nro_serie;
            public string fecha_elaboracion;
            public string fecha_vto;
            public string cod_producto; //= "88900000000001";
            public string gln_origen;
			public string gln_destino;
            
		}


#endregion

		
		
		
		public struct vpImpuestos
		{
		
			public decimal Importe; //Importe total del imupesto
			public decimal BaseImponibe; //Desde donde se toma el poncentaje de la alicuota
			public double percAlicuota; //Alicuota porcentual del impuesto
			public string Impuesto; //Identificacion del Impuesto
			public int IDImpuesto; //Identificacion interna
			
		}
		
		
		public struct vpRetenciones
		{
		
			public decimal Importe; //Importe total del imupesto
			public decimal BaseImponibe; //Desde donde se toma el poncentaje de la alicuota
			public double percAlicuota; //Alicuota porcentual del impuesto
			public string Impuesto; //Identificacion del Impuesto
			public int IDImpuesto; //Identificacion interna
			
		}





	}
}
