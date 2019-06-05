/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 09/05/2014
 * Hora: 05:33 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;


using VariablesPropias;


namespace ImprimirEjemplo
{
/// <summary>
/// Este modulo permite imprimir todos los documentos del programa.
/// Se espera que cada uno arme un documento y lo imprima
/// </summary>
	public class Imprimir
	{
				
		public Imprimir()
		{
		}
		
			
			
///<example>
///Para llamar a la impresion hacemos esto
///private void btnImprimir_Click(object sender, EventArgs e)
///{
/////Llamamos el método que creamos dentro de nuestro formulario y listo.
///Imprimir_Solicitud();
///En el botón que incluimos en nuestro pequeño formulario damos doble clic
///e invocamos nuestro método Imprimir_Solicitud()
///
///</example>
		//A continuacion se agregara el siguiente método
		public static void Imprimir_Solicitud()
		{
			//Este método contiene dos componentes muy importantes los cuales son:
			//PrintDocument y printDialog estos métodos definen las propiedades de impresión
			//como son: numero de copias, numero de paginas y seleccionar tipo de impresora
			//estas son las variables donde almacenaremos los datos del cliente
	
			
			
			PrintDocument formulario = new PrintDocument();
			
			formulario.PrintPage += new PrintPageEventHandler(Datos_Cliente);// Datos Cliente es el lienzo
			
			//Este es el Print Dialog -- El formulario de impresion ;)
			PrintDialog printDialog1 = new PrintDialog();
			printDialog1.Document = formulario;
			DialogResult result = printDialog1.ShowDialog();
		
			if (result == DialogResult.OK)
			{
			formulario.Print();
			}
		}
		
		
		
///<summary>
/// En esta función se define los datos a imprimir en este caso
/// los datos de nuestros clientes y la posición de los mismos en el documento
/// </summary>
		private static void Datos_Cliente(object obj, PrintPageEventArgs evs)
		{
			
			 string Nombre;
			 string Direccion;
			 string Telefono;
		
			//la siguiente variable define el estilo de fuente y tamaño a usar
			//en este caso se utilizo Arial,12
	
			 Font fuente = new Font("Arial", 12);
			
			
			float pos_x = 10;
			float pos_y = 20;
			
			
			
			Nombre = "Juanqui";
			Direccion = "Casa";
			Telefono = "4654897";
			
			//Lo que vamos a imprimir
			//
			/*
			 *ev es el encargado de dibujar en el lienzo lo que vamos a imprir 
			 * Drawingstring es el encargado de dibujar el texto con un determinado formato y ponienodolo en las
			 * direcciones de X e Y
			 * Esto es TEXTO, FUENTE, X, Y para ver donde lo deja
			*/
			
			//De esta manera se pasa de Twips a Milimetros un bardo encontrarlo pero funca.
			evs.Graphics.PageUnit = GraphicsUnit.Millimeter;
			
			evs.Graphics.DrawString("Nombre:"+Nombre, fuente, Brushes.Black, 0, 15, new StringFormat());
			evs.Graphics.DrawString("Direccion:"+Direccion, fuente, Brushes.Black, pos_x, pos_y + 15, new StringFormat());
			evs.Graphics.DrawString("Telefono:"+Telefono , fuente, Brushes.Black, pos_x, pos_y + 30, new StringFormat());
			
			
		}
		


#region REMITO



	static VariablesPropias.VariablesPropias.vpRemito ObtenerRemito = new VariablesPropias.VariablesPropias.vpRemito();	
		
///<summary>
///Imprime un remito.
///</summary>
		public static  void Imprimir_Remito(VariablesPropias.VariablesPropias.vpRemito remi)
		{
			//Este método contiene dos componentes muy importantes los cuales son:
			//PrintDocument y printDialog estos métodos definen las propiedades de impresión
			//como son: numero de copias, numero de paginas y seleccionar tipo de impresora
			//estas son las variables donde almacenaremos los datos del cliente
	
			
			
			
			//Esto pasa los datos que recibo a la variable estatica general de aca.
			//de esa manera puedo pasar los datos en el 
			ObtenerRemito  = remi; 
			
			
			
			
			PrintDocument formulario = new PrintDocument();
					
			
			formulario.PrintPage += new PrintPageEventHandler(Datos_Remito);// Datos Cliente es el lienzo
			
			
			//Este es el Print Dialog -- El formulario de impresion ;)
			PrintDialog printDialog1 = new PrintDialog();
			printDialog1.Document = formulario;
			printDialog1.PrinterSettings.Copies = 4;// marca que son cuatro copias si no hace nada
			DialogResult result = printDialog1.ShowDialog();
		
			if (result == DialogResult.OK)
			{
			formulario.Print();
			}
		}

		
///<summary>
/// En este metodo se define los datos a imprimir. En este caso un remito
/// </summary>	
		//private static void Datos_Remito(VariablesPropias.VariablesPropias.vpRemito remit, object obj, PrintPageEventArgs ev)
		private static void Datos_Remito(object obj, PrintPageEventArgs ev)
		
		
		{
			
			VariablesPropias.VariablesPropias.vpRemito vpRemito = new VariablesPropias.VariablesPropias.vpRemito();
			VariablesPropias.VariablesPropias.vpMargenesRemito vpMargRemito = new VariablesPropias.VariablesPropias.vpMargenesRemito();
			

			
			//Asi cargo los datos de la variable general en la que voy a usar aca..
			vpRemito = ObtenerRemito;
			
			
			
			
			
#region Margenes


			//Tener en cuenta que hay 5mm de altura demas (a restar)			
			
			//Id del remito
			vpMargRemito.sngNumeroRemiX = 130;
			vpMargRemito.sngNumeroRemiY = 18;

			//Fecha
			vpMargRemito.sngFechaX = 155;
			vpMargRemito.sngFechaY = 30;
			
			
			//Cliente
			
			vpMargRemito.sngRazonSocX = 25;
			vpMargRemito.sngRazonSocY = 58;
			
			vpMargRemito.sngDomicilioX = 25;
			vpMargRemito.sngDomicilioY = 62;
			
			vpMargRemito.sngLocalidadX = 100;
			vpMargRemito.sngLocalidadY = 62;
			
			vpMargRemito.sngProvinciaX = 25;
			vpMargRemito.sngProvinciaY = 67;
			
			vpMargRemito.sngCUITX = 31;
			vpMargRemito.sngCUITY = 80;
			
			vpMargRemito.sngPosIVAX = 125;
			vpMargRemito.sngPosIVAY = 70;
			
			
			//Transporte
			
			vpMargRemito.sngTranspNombreX = 35;
			vpMargRemito.sngTranspNombreY = 85;
						
			vpMargRemito.sngTranspDireccionX = 35;
			vpMargRemito.sngTranspDireccionY = 93;
			
			
			//Pedido
			
			vpMargRemito.sngPedidoNroX = 165;  
			vpMargRemito.sngPedidoNroY = 75;
			
			//Mercaderia
			vpMargRemito.sngCantX = 20;
			vpMargRemito.sngCantY = 115;
			
			vpMargRemito.sngDetalleX = 40;
			vpMargRemito.sngDetalleY = 115;
			
			vpMargRemito.sngPrecUnitX = 150;
			vpMargRemito.sngPrecUnitY = 115;
			
			vpMargRemito.sngImporteX = 170;
			vpMargRemito.sngImporteY = 115;
			
			vpMargRemito.sngTrazaX = 20;
			vpMargRemito.sngTrazaY =120;
			
			//Bultos
			vpMargRemito.sngBultosX = 60;
			vpMargRemito.sngBultosY = 215;
			
			
			//Chofer
			
			vpMargRemito.sngChoferX = 15;
			vpMargRemito.sngChoferY = 245;
			
			//Valor declarado
			
			vpMargRemito.sngValorDeclaradoX = 160;
			vpMargRemito.sngValorDeclaradoY = 250;
			
			
			//Nota
			vpMargRemito.sngNotaX = 20;
			vpMargRemito.sngNotaY = 245;
			
			//AFIP
			vpMargRemito.sngCodBarrasX = 65;
			vpMargRemito.sngCodBarrasY = 255;
			
			vpMargRemito.sngCAIX = 160;
			vpMargRemito.sngCAIY = 255;
			
			vpMargRemito.sngFechaVtoX = 160;
			vpMargRemito.sngFechaVtoY = 275;
			
			vpMargRemito.sngFechaImprX = 15;
			vpMargRemito.sngFechaImprY = 267; 
	
			
	#endregion		
			
				
			
#region FUENTES			
		
			//la siguiente variable define el estilo de fuente y tamaño a usar
			//en este caso se utilizo Arial,12
	
			Font Arial12 = new Font("Arial", 12);
			Font Arial10 = new Font("Arial", 10);
			Font Arial08 = new Font("Arial", 8);
			
#endregion
			
			
			
			
			//De esta manera se pasa de Twips a Milimetros un bardo encontrarlo pero funca.
			ev.Graphics.PageUnit = GraphicsUnit.Millimeter;
			
			
			//ev.Graphics.DrawString(
			ev.Graphics.DrawString(vpRemito.IDRemito , Arial12 , Brushes.Black , vpMargRemito.sngNumeroRemiX,vpMargRemito.sngNumeroRemiY);
			ev.Graphics.DrawString(vpRemito.dtFecha.ToShortDateString(), Arial10, Brushes.Black , vpMargRemito.sngFechaX,vpMargRemito.sngFechaY);
			ev.Graphics.DrawString(vpRemito.Cliente.strNombre , Arial12 , Brushes.Black, vpMargRemito.sngRazonSocX ,vpMargRemito.sngRazonSocY);
			ev.Graphics.DrawString(vpRemito.Cliente.strDireccion, Arial12 , Brushes.Black, vpMargRemito.sngDomicilioX, vpMargRemito.sngDomicilioY);
			ev.Graphics.DrawString(vpRemito.Cliente.strLocalidad, Arial12 , Brushes.Black, vpMargRemito.sngLocalidadX, vpMargRemito.sngLocalidadY);
			ev.Graphics.DrawString(vpRemito.Cliente.strProvincia, Arial12 , Brushes.Black, vpMargRemito.sngProvinciaX, vpMargRemito.sngProvinciaY);
			ev.Graphics.DrawString(vpRemito.Cliente.dblCUIT.ToString() , Arial12 , Brushes.Black, vpMargRemito.sngCUITX, vpMargRemito.sngCUITY);
			ev.Graphics.DrawString(vpRemito.Cliente.strPosIVA , Arial12 , Brushes.Black, vpMargRemito.sngPosIVAX, vpMargRemito.sngPosIVAY);
			
		
			//Transporte
			
			ev.Graphics.DrawString(vpRemito.Transporte.strNombre, Arial12 , Brushes.Black, vpMargRemito.sngTranspNombreX, vpMargRemito.sngTranspNombreY);
			ev.Graphics.DrawString(vpRemito.Transporte.strDireccion, Arial12 , Brushes.Black, vpMargRemito.sngTranspDireccionX, vpMargRemito.sngTranspDireccionY);
			
			
			//Pedido
			ev.Graphics.DrawString(vpRemito.strPedido, Arial12 , Brushes.Black, vpMargRemito.sngPedidoNroX, vpMargRemito.sngPedidoNroY);
			
			//Mercaderia
			
			// TODO: Aca va poner un for para que recorra el array de los productos. Hoy lo dejo como en 5 pero hay que mejorarlo
			
			//Producto1
			ev.Graphics.DrawString(vpRemito.Producto1.intCantidad.ToString(), Arial12 , Brushes.Black, 
			                       vpMargRemito.sngCantX, vpMargRemito.sngCantY);
			ev.Graphics.DrawString(vpRemito.Producto1.strDescripcion , Arial12 , Brushes.Black, 
			                       vpMargRemito.sngDetalleX, vpMargRemito.sngDetalleY);
			ev.Graphics.DrawString(vpRemito.Producto1.curPrecioNeto.ToString(), Arial12 , Brushes.Black, 
			                       vpMargRemito.sngPrecUnitX, vpMargRemito.sngPrecUnitY);
			ev.Graphics.DrawString(vpRemito.Producto1.curPrecioTotal.ToString() , Arial12 , Brushes.Black, 
			                       vpMargRemito.sngImporteX, vpMargRemito.sngImporteY);
			ev.Graphics.DrawString(vpRemito.Producto1.Trazabilidad.strNumPartida + " - " + 
								   vpRemito.Producto1.Trazabilidad.strVolumen + " - " + 	
								   vpRemito.Producto1.Trazabilidad.strEmbalajes  + " - ",			                       								   
			                       Arial12 , Brushes.Black, vpMargRemito.sngTrazaX,	vpMargRemito.sngTrazaY);
			
			
			
			if (vpRemito.Producto2.intCantidad != 0)
			{
				//Producto2
			ev.Graphics.DrawString(vpRemito.Producto2.intCantidad.ToString() , Arial12 , Brushes.Black, 
				                   vpMargRemito.sngCantX , vpMargRemito.sngCantY +10);
			ev.Graphics.DrawString(vpRemito.Producto2.strDescripcion , Arial12 , Brushes.Black, 
				                   vpMargRemito.sngDetalleX, vpMargRemito.sngDetalleY+10);
			ev.Graphics.DrawString(vpRemito.Producto2.curPrecioNeto.ToString(), Arial12 , Brushes.Black, 
				                  vpMargRemito.sngPrecUnitX, vpMargRemito.sngPrecUnitY+10);
			ev.Graphics.DrawString(vpRemito.Producto2.curPrecioTotal.ToString() , Arial12 , Brushes.Black, 
				                   vpMargRemito.sngImporteX, vpMargRemito.sngImporteY+10);
			ev.Graphics.DrawString(vpRemito.Producto2.Trazabilidad.strNumPartida + " - " + 
								   vpRemito.Producto2.Trazabilidad.strVolumen + " - " + 	
								   vpRemito.Producto2.Trazabilidad.strEmbalajes  + " - ",			                       								   
			                       Arial12 , Brushes.Black, vpMargRemito.sngTrazaX,	vpMargRemito.sngTrazaY+10);

			}
			//Producto3
			
			if (vpRemito.Producto3.intCantidad != 0)
			{
			ev.Graphics.DrawString(vpRemito.Producto3.intCantidad.ToString() , Arial12 , Brushes.Black, 
				                       vpMargRemito.sngCantX, vpMargRemito.sngCantY +20);
			ev.Graphics.DrawString(vpRemito.Producto3.strDescripcion , Arial12 , Brushes.Black, 
				                       vpMargRemito.sngDetalleX, vpMargRemito.sngDetalleY+20);
			ev.Graphics.DrawString(vpRemito.Producto3.curPrecioNeto.ToString(), Arial12 , Brushes.Black, 
				                       vpMargRemito.sngPrecUnitX, vpMargRemito.sngPrecUnitY+20);
			ev.Graphics.DrawString(vpRemito.Producto3.curPrecioTotal.ToString() , Arial12 , Brushes.Black, 
				                       vpMargRemito.sngImporteX, vpMargRemito.sngImporteY+20);
			ev.Graphics.DrawString(vpRemito.Producto3.Trazabilidad.strNumPartida + " - " + 
								   vpRemito.Producto3.Trazabilidad.strVolumen + " - " + 	
								   vpRemito.Producto3.Trazabilidad.strEmbalajes  + " - ",			                       								   
			                       Arial12 , Brushes.Black, vpMargRemito.sngTrazaX,	vpMargRemito.sngTrazaY+20);
			}
			
			
			//Producto4
			
			if (vpRemito.Producto4.intCantidad != 0)
			{
			ev.Graphics.DrawString(vpRemito.Producto4.intCantidad.ToString() , Arial12 , Brushes.Black, 
				                       vpMargRemito.sngCantX, vpMargRemito.sngCantY +30);
			ev.Graphics.DrawString(vpRemito.Producto4.strDescripcion , Arial12 , Brushes.Black, 
								   vpMargRemito.sngDetalleX, vpMargRemito.sngDetalleY+30);
			ev.Graphics.DrawString(vpRemito.Producto4.curPrecioNeto.ToString(), Arial12 , Brushes.Black, 
				                   vpMargRemito.sngPrecUnitX, vpMargRemito.sngPrecUnitY+30);
			ev.Graphics.DrawString(vpRemito.Producto4.curPrecioTotal.ToString() , Arial12 , Brushes.Black, 
				                   vpMargRemito.sngImporteX, vpMargRemito.sngImporteY+30);
			ev.Graphics.DrawString(vpRemito.Producto4.Trazabilidad.strNumPartida + " - " + 
								   vpRemito.Producto4.Trazabilidad.strVolumen + " - " + 	
								   vpRemito.Producto4.Trazabilidad.strEmbalajes  + " - ",			                       								   
			                       Arial12 , Brushes.Black, vpMargRemito.sngTrazaX,	vpMargRemito.sngTrazaY+30);

			}
			
			//Producto5
			
			if (vpRemito.Producto5.intCantidad != 0)
			{
			ev.Graphics.DrawString(vpRemito.Producto5.intCantidad.ToString() , Arial12 , Brushes.Black, 
				                   vpMargRemito.sngCantX, vpMargRemito.sngCantY +40);
			ev.Graphics.DrawString(vpRemito.Producto5.strDescripcion , Arial12 , Brushes.Black, 
				                   vpMargRemito.sngDetalleX, vpMargRemito.sngDetalleY+40);
			ev.Graphics.DrawString(vpRemito.Producto5.curPrecioNeto.ToString(), Arial12 , Brushes.Black, 
				                   vpMargRemito.sngPrecUnitX, vpMargRemito.sngPrecUnitY+40);
			ev.Graphics.DrawString(vpRemito.Producto5.curPrecioTotal.ToString() , Arial12 , Brushes.Black, 
				                   vpMargRemito.sngImporteX, vpMargRemito.sngImporteY+40);
			ev.Graphics.DrawString(vpRemito.Producto5.Trazabilidad.strNumPartida + " - " + 
								   vpRemito.Producto5.Trazabilidad.strVolumen + " - " + 	
								   vpRemito.Producto5.Trazabilidad.strEmbalajes  + " - ",			                       								   
			                       Arial12 , Brushes.Black, vpMargRemito.sngTrazaX,	vpMargRemito.sngTrazaY+40);
			
			}
			
			//Bultos
			ev.Graphics.DrawString(vpRemito.strBultos, Arial12 , Brushes.Black, vpMargRemito.sngBultosX, vpMargRemito.sngBultosY);
			
			
			
			//Chofer
			ev.Graphics.DrawString(vpRemito.strChofer, Arial12 , Brushes.Black, vpMargRemito.sngChoferX, vpMargRemito.sngChoferY);
			
			//Valor declarado
			ev.Graphics.DrawString(vpRemito.curTotal.ToString(), Arial12 , Brushes.Black, vpMargRemito.sngValorDeclaradoX, vpMargRemito.sngValorDeclaradoY);
			
			
			//Nota
			ev.Graphics.DrawString(vpRemito.strNota, Arial12 , Brushes.Black, vpMargRemito.sngNotaX, vpMargRemito.sngNotaY);
			
			//AFIP
			ev.Graphics.DrawImage(vpRemito.picCodBarras.Image, vpMargRemito.sngCodBarrasX, vpMargRemito.sngCodBarrasY);
			ev.Graphics.DrawString(vpRemito.strCAI, Arial08 , Brushes.Black, vpMargRemito.sngCAIX, vpMargRemito.sngCAIY);
			ev.Graphics.DrawString(vpRemito.strFechaVto, Arial08 , Brushes.Black, vpMargRemito.sngFechaVtoX, vpMargRemito.sngFechaVtoY);
			//ev.Graphics.DrawString(vpRemito.strCodBarrasNum  
			ev.Graphics.DrawString(vpRemito.strFechaImpresion, Arial08 , Brushes.Black, vpMargRemito.sngFechaImprX, vpMargRemito.sngFechaImprY);
			
			
			
			
			//Lo que vamos a imprimir
			//
			/*
			 *ev es el encargado de dibujar en el lienzo lo que vamos a imprir 
			 * Drawingstring es el encargado de dibujar el texto con un determinado formato y ponienodolo en las
			 * direcciones de X e Y
			 * Esto es TEXTO, FUENTE, X, Y para ver donde lo deja
			*/
			
			
			
			
		}
		
#endregion		


#region RECIBO



	static VariablesPropias.VariablesPropias.vpRecibo ObtenerRecibo = new VariablesPropias.VariablesPropias.vpRecibo();	
		
///<summary>
///Imprime un remito.
///</summary>
		public static  void Imprimir_Recibo(VariablesPropias.VariablesPropias.vpRecibo reci)
		{
			//Este método contiene dos componentes muy importantes los cuales son:
			//PrintDocument y printDialog estos métodos definen las propiedades de impresión
			//como son: numero de copias, numero de paginas y seleccionar tipo de impresora
			//estas son las variables donde almacenaremos los datos del cliente
	
			
			
			
			//Esto pasa los datos que recibo a la variable estatica general de aca.
			//de esa manera puedo pasar los datos en el 
			ObtenerRecibo  = reci; 
			
			
			
			
			PrintDocument formulario = new PrintDocument();
					
			
			formulario.PrintPage += new PrintPageEventHandler(Datos_Recibo);// Datos Cliente es el lienzo
			
			
			//Este es el Print Dialog -- El formulario de impresion ;)
			PrintDialog printDialog1 = new PrintDialog();
			printDialog1.Document = formulario;
			printDialog1.PrinterSettings.Copies = 3;// marca que son cuatro copias si no hace nada
			printDialog1.PrinterSettings.DefaultPageSettings.Landscape = false; //hoja apaizada
			DialogResult result = printDialog1.ShowDialog();
		
			if (result == DialogResult.OK)
			{
			formulario.Print();
			}
		}

		
///<summary>
/// En este metodo se define los datos a imprimir. En este caso un recibo
/// </summary>	
		//private static void Datos_Remito(VariablesPropias.VariablesPropias.vpRemito remit, object obj, PrintPageEventArgs ev)
		private static void Datos_Recibo_Apaizado(object obj, PrintPageEventArgs ev)
		
		
		{
			
			VariablesPropias.VariablesPropias.vpRecibo vpRecibo = new VariablesPropias.VariablesPropias.vpRecibo();
			VariablesPropias.VariablesPropias.vpMargenesRecibo vpMargRecibo = new VariablesPropias.VariablesPropias.vpMargenesRecibo();
			

			
			//Asi cargo los datos de la variable general en la que voy a usar aca..
			vpRecibo = ObtenerRecibo;
			
			//El numero de renglon
			int y = 0;
			int intRenglonFacturas = 0;
			
			
			
#region Margenes


			//Tener en cuenta que hay 5mm de altura demas (a restar)			
			//Tener en cuenta que hay 4mm de largo demas
			
			Single correccionX = 4;
			Single correccionY = 5;

#region Cabecera			
			//Id del remito
			vpMargRecibo.sngNumeroReciX = 130;
			vpMargRecibo.sngNumeroReciY = 18;

			//Fecha
			vpMargRecibo.sngFechaX = 17-correccionX;
			vpMargRecibo.sngFechaY = 45-correccionY;
			
			
			//Cliente
			
			vpMargRecibo.sngRazonSocX = 30-correccionX;
			vpMargRecibo.sngRazonSocY = 50-correccionY;
			
			vpMargRecibo.sngDomicilioX = 26-correccionX;
			vpMargRecibo.sngDomicilioY = 57-correccionY;
			
			vpMargRecibo.sngLocalidadX = 80-correccionX;
			vpMargRecibo.sngLocalidadY = 57-correccionY;
			
			vpMargRecibo.sngProvinciaX = 95-correccionX;
			vpMargRecibo.sngProvinciaY = 57-correccionY;
			
			//La suma de
			vpMargRecibo.sngLaSumaDeX = 25-correccionX;
			vpMargRecibo.sngLaSumaDeY = 62-correccionY;
#endregion 
		
		
		
#region Cheques / NC / Interdep

			//ID
			vpMargRecibo.sngNumCheqX = 10-correccionX;
			vpMargRecibo.sngNumCheqY = 87-correccionY;
			//Banco
			vpMargRecibo.sngBancoX = 32-correccionX;
			//Fecha de Emision
			vpMargRecibo.sngFechEmisionX = 57-correccionX;
			//Fecha de Pago
			vpMargRecibo.sngFechPagoX = 90-correccionX;
			//Importe
			vpMargRecibo.sngCHImporteX = 105-correccionX;



#endregion
			
			
			
			
			//EFECTIVO
			vpMargRecibo.sngEfectivoX = 87-correccionX;
			vpMargRecibo.sngEfectivoY = 139-correccionY;
			
			
			
			//TOTAL COBRANZA
			vpMargRecibo.sngTotalValoresX = 87-correccionX;
			vpMargRecibo.sngTotalValoresY = 145-correccionY;
			
			
			
			//Facturas /  ND 
			//ID
			vpMargRecibo.sngFactX = 116-correccionX;
			vpMargRecibo.sngFactY = 43-correccionY;
			//Fecha
			vpMargRecibo.sngFactFechaX = 152-correccionX;
			//Importe
			vpMargRecibo.sngFactImpoteX = 172-correccionX;
			
			
			//OTROS
			//Subtotal
			vpMargRecibo.sngSubtotalX = 172-correccionX;
			vpMargRecibo.sngSubtotalY = 106-correccionY;
			//Descuento
			vpMargRecibo.sngDescuentoX = 172-correccionX;
			vpMargRecibo.sngDescuentoY = 112-correccionY;
			//Retenciones
			vpMargRecibo.sngRetencionesX = 172-correccionX;
			vpMargRecibo.sngRetencionesY = 116-correccionY;
			//N/O			
			vpMargRecibo.sngNOX = 172-correccionX;
			vpMargRecibo.sngNOY = 12-correccionY;
			//Varios
			vpMargRecibo.sngVariosX = 172-correccionX;
			vpMargRecibo.sngVariosY = 126-correccionY;
			//Total
			vpMargRecibo.sngTotalCobranzaX = 172-correccionX;
			vpMargRecibo.sngTotalCobranzaY = 135-correccionY;
			
			
	#endregion		
			
				
			
#region FUENTES			
		
			//la siguiente variable define el estilo de fuente y tamaño a usar
			//en este caso se utilizo Arial,12
	
			Font Arial12 = new Font("Arial", 12);
			Font Arial10 = new Font("Arial", 10);
			Font Arial08 = new Font("Arial", 8);
			Font Arial06 = new Font("Arial", 6);
			Font Arial04 = new Font("Arial", 4);
#endregion
			
			
#region INFO

			
			//De esta manera se pasa de Twips a Milimetros un bardo encontrarlo pero funca.
			ev.Graphics.PageUnit = GraphicsUnit.Millimeter;
			
			/*
			 * Esto es para controlar el 
			 */
			ev.Graphics.DrawString(".", Arial08, Brushes.Black, 0,0);
#endregion			
			
			
#region	CABECERA

			//numero de recibo
			//POR AHORA NO
			//ev.Graphics.DrawString(vpRecibo.dblNumReci.ToString() , Arial12 , Brushes.Black , vpMargRecibo.sngNumeroReciX,vpMargRecibo.sngNumeroReciY  );
			//Fecha
			ev.Graphics.DrawString(vpRecibo.dtFecha.ToShortDateString(), Arial10, Brushes.Black, 
			                       vpMargRecibo.sngFechaX,vpMargRecibo.sngFechaY);
			
			//Cliente
			
			//Nombre
			ev.Graphics.DrawString(vpRecibo.Cliente.strNombre , Arial10 , Brushes.Black, 
			                       vpMargRecibo.sngRazonSocX ,vpMargRecibo.sngRazonSocY);
			
			//Direccion
			ev.Graphics.DrawString(vpRecibo.Cliente.strDireccion, Arial08 , Brushes.Black, 
			                       vpMargRecibo.sngDomicilioX, vpMargRecibo.sngDomicilioY);
			ev.Graphics.DrawString(vpRecibo.Cliente.strLocalidad, Arial08 , Brushes.Black, 
			                       vpMargRecibo.sngLocalidadX, vpMargRecibo.sngLocalidadY);
			ev.Graphics.DrawString(vpRecibo.Cliente.strProvincia, Arial08 , Brushes.Black, 
			                       vpMargRecibo.sngProvinciaX, vpMargRecibo.sngProvinciaY);

#endregion
			
			//La suma de
			ev.Graphics.DrawString(vpRecibo.strEnLetras  , Arial12 , Brushes.Black, 
			                       vpMargRecibo.sngLaSumaDeX , vpMargRecibo.sngLaSumaDeY);
			
			//Esto recorre el array y le carga los datos al lienzo
			
#region Cheques Interdep Nc.

		//CHEQUES
			
			
			if (vpRecibo.Cheques != null ) //Corrobora que no sea null 
			{
				
				for (int n = 0; n < vpRecibo.Cheques.Length ; n++) {
				//ID
				ev.Graphics.DrawString(vpRecibo.Cheques[n].dblNumCheque.ToString(), Arial08, Brushes.Black,
				                       vpMargRecibo.sngNumCheqX , vpMargRecibo.sngNumCheqY +(n*5) );
				//Banco
				ev.Graphics.DrawString(vpRecibo.Cheques[n].strBanco, Arial04, Brushes.Black, 
				                       vpMargRecibo.sngBancoX, vpMargRecibo.sngNumCheqY +(n*5) );
				//Fecha de Emision
				ev.Graphics.DrawString(vpRecibo.Cheques[n].dtFechaEmision.ToShortDateString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngFechEmisionX, vpMargRecibo.sngNumCheqY +(n*5) );
				//Fecha de Pago
				ev.Graphics.DrawString(vpRecibo.Cheques[n].dtFechaPago.ToShortDateString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngFechPagoX, vpMargRecibo.sngNumCheqY +(n*5) );
				//Importe
				ev.Graphics.DrawString(vpRecibo.Cheques[n].curImporte.ToString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngCHImporteX, vpMargRecibo.sngNumCheqY +(n*5) );
				
				//y+=n;
			}
			}
			
			
			
			//INTERDEPOSITOS
			if (vpRecibo.Interdepositos != null ) //Corrobora que no sea null 
			{
			
			for (int n = 0; n < vpRecibo.Interdepositos.Length ; n++) {
				//ID
				ev.Graphics.DrawString(vpRecibo.Interdepositos[n].dblIDInterdeposito.ToString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngNumCheqX , vpMargRecibo.sngNumCheqY +(y*5) );
				//Banco
				ev.Graphics.DrawString(vpRecibo.Interdepositos[n].strBanco, Arial04, Brushes.Black, 
				                       vpMargRecibo.sngBancoX, vpMargRecibo.sngNumCheqY +(y*5) );
				//Fecha de Emision
				ev.Graphics.DrawString(vpRecibo.Interdepositos[n].dtFechaEmision.ToShortDateString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngFechEmisionX, vpMargRecibo.sngNumCheqY +(y*5) );
				//Fecha de Pago
				ev.Graphics.DrawString(vpRecibo.Interdepositos[n].dtFechaPago.ToShortDateString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngFechPagoX, vpMargRecibo.sngNumCheqY +(y*5) );
				//Importe
				ev.Graphics.DrawString(vpRecibo.Interdepositos[n].curImporte.ToString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngCHImporteX, vpMargRecibo.sngNumCheqY +(y*5) );
				
				y+=n;
			}
			}
			
			
			//NCs
			if (vpRecibo.NCs != null ) //Corrobora que no sea null 
			{
			
			
			for (int n = 0; n <  vpRecibo.NCs.Length ; n++) {
				//ID
				ev.Graphics.DrawString(vpRecibo.NCs[n].dblNumFact.ToString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngNumCheqX , vpMargRecibo.sngNumCheqY +(y*5) );
				//Banco
				//ev.Graphics.DrawString(vpRecibo.NCs[n].strBanco, Arial06, Brushes.Black, vpMargRecibo.sngBancoX, vpMargRecibo.sngNumCheqY +(y*5) );
				//Fecha de Emision
				ev.Graphics.DrawString(vpRecibo.NCs[n].dtFecha.ToShortDateString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngFechEmisionX, vpMargRecibo.sngNumCheqY +(y*5) );
				//Fecha de Pago
				ev.Graphics.DrawString(vpRecibo.NCs[n].dtFecha.ToShortDateString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngFechPagoX, vpMargRecibo.sngNumCheqY +(y*5) );
				//Importe
				ev.Graphics.DrawString(vpRecibo.NCs[n].curTotal.ToString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngCHImporteX, vpMargRecibo.sngNumCheqY +(y*5) );
				
			y+=n;
			}
			}
#endregion
			
	
			
			//EFECTIVO
			ev.Graphics.DrawString(vpRecibo.curEfectivo.ToString() , Arial08, Brushes.Black,
			                       vpMargRecibo.sngEfectivoX, vpMargRecibo.sngEfectivoY );
			
			//TOTAL COBRANZA
			
			
			
			//Facturas
			
if (vpRecibo.Facturas  != null ) //Corrobora que no sea null 
			{
				
				for (int n = 0; n < vpRecibo.Facturas.Length ; n++) 
				{
				//ID
				ev.Graphics.DrawString(vpRecibo.Facturas[n].strComprobante, Arial08, Brushes.Black,
				                       vpMargRecibo.sngFactX , vpMargRecibo.sngFactY +(n*5) );
				
				//Fecha 
				ev.Graphics.DrawString(vpRecibo.Facturas[n].dtFecha.ToShortDateString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngFactFechaX, vpMargRecibo.sngFactY +(n*5) );
				
				//Importe
				ev.Graphics.DrawString(vpRecibo.Facturas[n].curTotal.ToString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngFactImpoteX, vpMargRecibo.sngFactY +(n*5) );
				
				intRenglonFacturas += n;
				}
			}			
			
if (vpRecibo.FacturasB  != null ) //Corrobora que no sea null 
			{
				
				for (int n = 0; n < vpRecibo.FacturasB.Length ; n++) 
				{
				//ID
				ev.Graphics.DrawString(vpRecibo.FacturasB[n].strComprobante, Arial08, Brushes.Black,
				                       vpMargRecibo.sngFactX , vpMargRecibo.sngFactY +(n*5) );
				
				//Fecha 
				ev.Graphics.DrawString(vpRecibo.FacturasB[n].dtFecha.ToShortDateString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngFactFechaX, vpMargRecibo.sngFactY +(n*5) );
				
				//Importe
				ev.Graphics.DrawString(vpRecibo.FacturasB[n].curTotal.ToString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngFactImpoteX, vpMargRecibo.sngFactY +(n*5) );
				
				intRenglonFacturas += n;
				}
			}				
			
			// ND 

if (vpRecibo.NDs  != null ) //Corrobora que no sea null 
			{
				
				for (int n = 0; n < vpRecibo.NDs.Length ; n++) 
				{
				//ID
				ev.Graphics.DrawString(vpRecibo.NDs[n].strComprobante, Arial08, Brushes.Black,
				                       vpMargRecibo.sngFactX , vpMargRecibo.sngFactY +(intRenglonFacturas*5) );
				
				//Fecha 
				ev.Graphics.DrawString(vpRecibo.NDs[n].dtFecha.ToShortDateString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngFactFechaX, vpMargRecibo.sngFactY +(intRenglonFacturas*5) );
				
				//Importe
				ev.Graphics.DrawString(vpRecibo.NDs[n].curTotal.ToString(), Arial08, Brushes.Black, 
				                       vpMargRecibo.sngFactImpoteX, vpMargRecibo.sngFactY +(intRenglonFacturas*5) );
				
				intRenglonFacturas += n;
				}
			}

		
			//OTROS
			//Subtotal
			ev.Graphics.DrawString(vpRecibo.curSubTotal.ToString(), Arial08, Brushes.Black, 
			                       vpMargRecibo.sngSubtotalX, vpMargRecibo.sngSubtotalY) ;
			
			
			//Descuento
			ev.Graphics.DrawString(vpRecibo.curDescuento.ToString(), Arial08, Brushes.Black, 
			                       vpMargRecibo.sngDescuentoX, vpMargRecibo.sngDescuentoY) ;
			
			//Retenciones
			ev.Graphics.DrawString(vpRecibo.curRetenciones.ToString(), Arial08, Brushes.Black, 
			                       vpMargRecibo.sngRetencionesX, vpMargRecibo.sngRetencionesY) ;
			//N/O
			ev.Graphics.DrawString(vpRecibo.curNO.ToString(), Arial08, Brushes.Black, 
			                       vpMargRecibo.sngNOX, vpMargRecibo.sngNOY) ;
			//Varios
			ev.Graphics.DrawString(vpRecibo.curVarios.ToString(), Arial08, Brushes.Black, 
			                       vpMargRecibo.sngVariosX, vpMargRecibo.sngVariosY) ;
			//Total
			ev.Graphics.DrawString(vpRecibo.curCobranzaNeta.ToString(), Arial08, Brushes.Black, 
			                       vpMargRecibo.sngTotalCobranzaX, vpMargRecibo.sngTotalCobranzaY) ;
			
			//ev.Graphics.DrawString(
			/*ev.Graphics.DrawString(vpRemito.IDRemito , Arial12 , Brushes.Black , vpMargRemito.sngNumeroRemiX,vpMargRemito.sngNumeroRemiY);
			
			
			
			
			
			//Lo que vamos a imprimir
			//
			/*
			 *ev es el encargado de dibujar en el lienzo lo que vamos a imprir 
			 * Drawingstring es el encargado de dibujar el texto con un determinado formato y ponienodolo en las
			 * direcciones de X e Y
			 * Esto es TEXTO, FUENTE, X, Y para ver donde lo deja
			*/
			
			
			
			
		}
		

///<summary>
/// En este metodo se define los datos a imprimir. En este caso un recibo
/// </summary>	
		//private static void Datos_Remito(VariablesPropias.VariablesPropias.vpRemito remit, object obj, PrintPageEventArgs ev)
		private static void Datos_Recibo(object obj, PrintPageEventArgs ev)
		
		
		{
			
			VariablesPropias.VariablesPropias.vpRecibo vpRecibo = new VariablesPropias.VariablesPropias.vpRecibo();
			VariablesPropias.VariablesPropias.vpMargenesRecibo vpMargRecibo = new VariablesPropias.VariablesPropias.vpMargenesRecibo();
			

			
			//Asi cargo los datos de la variable general en la que voy a usar aca..
			vpRecibo = ObtenerRecibo;
			
			//El numero de renglon
			int y = 0;
			//int intRenglonFacturas = 0;
			
			
			
#region Margenes
			//TODO sacar toda esta informacion de un XML	

			//Tener en cuenta que hay 5mm de altura demas (a restar)			
			//Tener en cuenta que hay 4mm de largo demas
			
			Single correccionX = 4;
			Single correccionY = 5;

#region Cabecera			
			//Id del remito
			vpMargRecibo.sngNumeroReciX = 140;
			vpMargRecibo.sngNumeroReciY = 18;

			//Fecha
			vpMargRecibo.sngFechaX = 140 -correccionX;
			vpMargRecibo.sngFechaY = 30 -correccionY;
			
			
			//Cliente
			
			vpMargRecibo.sngRazonSocX = 10-correccionX;
			vpMargRecibo.sngRazonSocY = 50-correccionY;
			
			vpMargRecibo.sngDomicilioX = 10-correccionX;
			vpMargRecibo.sngDomicilioY = 57-correccionY;
			
			vpMargRecibo.sngLocalidadX = 100-correccionX;
			vpMargRecibo.sngLocalidadY = 57-correccionY;
			
			vpMargRecibo.sngProvinciaX = 160-correccionX;
			vpMargRecibo.sngProvinciaY = 57-correccionY;
			
			//La suma de
			vpMargRecibo.sngLaSumaDeX = 25-correccionX;
			vpMargRecibo.sngLaSumaDeY = 62-correccionY;
#endregion 
		
		
		
#region Cheques / NC / Interdep

			//ID
			vpMargRecibo.sngNumCheqX = 10-correccionX;
			vpMargRecibo.sngNumCheqY = 80-correccionY;
			//Banco
			vpMargRecibo.sngBancoX = 35-correccionX;
			//Fecha de Emision
			vpMargRecibo.sngFechEmisionX = 60-correccionX;
			//Fecha de Pago
			vpMargRecibo.sngFechPagoX = 90-correccionX;
			//Importe
			vpMargRecibo.sngCHImporteX = 120-correccionX;



#endregion
			
			
			
			
			//EFECTIVO
			vpMargRecibo.sngEfectivoX = 80-correccionX;
			vpMargRecibo.sngEfectivoY = 150-correccionY;//podria variar
			
			
			
			//TOTAL COBRANZA
			vpMargRecibo.sngTotalValoresX = 100-correccionX;
			vpMargRecibo.sngTotalValoresY = 160-correccionY;//podria variar
			
#region FC/ND

//Facturas /  ND 
			//ID
			vpMargRecibo.sngFactX = 10-correccionX;
			//vpMargRecibo.sngFactY = 43-correccionY;  //Paso el valor de Y de los cheques
			//Fecha
			vpMargRecibo.sngFactFechaX = 50-correccionX;
			//Importe
			vpMargRecibo.sngFactImpoteX = 80-correccionX;
			vpMargRecibo.sngFactImpoteUSDX = 120-correccionX;

#endregion
			
			
			
			//OTROS
			//Subtotal
			vpMargRecibo.sngSubtotalX = 150-correccionX;
			vpMargRecibo.sngSubtotalY = 80-correccionY;
			//Descuento
			vpMargRecibo.sngDescuentoX = 150-correccionX;
			vpMargRecibo.sngDescuentoY = 90-correccionY;
			//Retenciones
			vpMargRecibo.sngRetencionesX = 150-correccionX;
			vpMargRecibo.sngRetencionesY = 100-correccionY;
			//N/O			
			vpMargRecibo.sngNOX = 150-correccionX;
			vpMargRecibo.sngNOY = 110-correccionY;
			//Varios
			vpMargRecibo.sngVariosX = 150-correccionX;
			vpMargRecibo.sngVariosY = 120-correccionY;
			//Total
			vpMargRecibo.sngTotalCobranzaX = 150-correccionX;
			vpMargRecibo.sngTotalCobranzaY = 130-correccionY;
			
			
	#endregion		
			
#region FUENTES			
		
			//la siguiente variable define el estilo de fuente y tamaño a usar
			//en este caso se utilizo Arial,12
	
			Font Arial12 = new Font("Arial", 12);
			Font Arial10 = new Font("Arial", 10);
			Font Arial08 = new Font("Arial", 8);
			Font Arial06 = new Font("Arial", 6);
			Font Arial04 = new Font("Arial", 4);
			
#endregion
			
#region INFO

			
			//De esta manera se pasa de Twips a Milimetros un bardo encontrarlo pero funca.
			ev.Graphics.PageUnit = GraphicsUnit.Millimeter;
			
			/*
			 * Esto es para controlar el 
			 */
			ev.Graphics.DrawString(".", Arial08, Brushes.Black, 0,0);
#endregion			
			
#region	CABECERA


//Cabecera General
				ev.Graphics.DrawString("ALFREDO FERRERO SRL" + Environment.NewLine + "		Agroquimicos", Arial12, Brushes.Blue,
				                       10 , 0 );
//Cabecera de direccion nuestra				   	                    

				ev.Graphics.DrawString(Environment.NewLine + 
                       					"Barcelona 1263 Haedo CP 1706 Prov. Bs As." + Environment.NewLine +
                      	 			   	"Tel 4489-0783 / 4629-0616 " + Environment.NewLine +
                      	 			   	"e-mail: info@alfredoferrerosrl.com.ar Web: www.alfredoferrerosrl.com.ar" + Environment.NewLine +
                      	 			   "IVA RESPONSABLE INSCRIPTO",
                       Arial10, Brushes.Black, 10 , 10 );
//SEPARADOR
ev.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------"
                       , Arial12 , Brushes.Black , 0 , 40 );



			//numero de recibo
			//POR AHORA NO
			ev.Graphics.DrawString("Número de Recibo: "+vpRecibo.dblNumReci.ToString() , Arial12 , Brushes.Black , 
									vpMargRecibo.sngNumeroReciX,vpMargRecibo.sngNumeroReciY  );
			//Fecha
			ev.Graphics.DrawString("Fecha: "+ vpRecibo.dtFecha.ToShortDateString(), Arial10, Brushes.Black, 
			                       vpMargRecibo.sngFechaX,vpMargRecibo.sngFechaY);
			
			//Cliente
			
			//Nombre
			ev.Graphics.DrawString("Recibimos de: " + vpRecibo.Cliente.strNombre , Arial10 , Brushes.Black, 
			                       vpMargRecibo.sngRazonSocX ,vpMargRecibo.sngRazonSocY);
			
			//Direccion
			ev.Graphics.DrawString("Dirección: " + vpRecibo.Cliente.strDireccion, Arial08 , Brushes.Black, 
			                       vpMargRecibo.sngDomicilioX, vpMargRecibo.sngDomicilioY);
			ev.Graphics.DrawString("Localidad: " + vpRecibo.Cliente.strLocalidad, Arial08 , Brushes.Black, 
			                       vpMargRecibo.sngLocalidadX, vpMargRecibo.sngLocalidadY);
			ev.Graphics.DrawString("Provincia:" + vpRecibo.Cliente.strProvincia, Arial08 , Brushes.Black, 
			                       vpMargRecibo.sngProvinciaX, vpMargRecibo.sngProvinciaY);

#endregion
			
			
			/* Sacamos esto porque no tiene sentido colocarlo en letras
			//La suma de
			//ev.Graphics.DrawString("La suma de: " + vpRecibo.strEnLetras  , Arial12 , Brushes.Black, 
			                       vpMargRecibo.sngLaSumaDeX , vpMargRecibo.sngLaSumaDeY);
			*/




//SEPARADOR
ev.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------------------------"
                       , Arial12 , Brushes.Black , 0 , 57);



			
			//Esto recorre el array y le carga los datos al lienzo
			
#region Cheques Interdep Nc.

			//CHEQUES
			if (vpRecibo.Cheques != null  ) //Corrobora que no sea null 
			{
				if (vpRecibo.Cheques[0].dblNumCheque.ToString() != "0") 
				{
					ev.Graphics.DrawString("CHEQUES", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY -10);
					//Divisioria
					ev.Graphics.DrawString("-------------------------------------------------", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY -5);
					
					//y++;
				
#region Subtitulo
					//ID
					ev.Graphics.DrawString("Nro de Cheque", Arial10, Brushes.Black,
					                       vpMargRecibo.sngNumCheqX , vpMargRecibo.sngNumCheqY +(y*5) );
					//Banco
					ev.Graphics.DrawString("Banco", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngBancoX, vpMargRecibo.sngNumCheqY +(y*5) );
					//Fecha de Emision
					ev.Graphics.DrawString("Fecha Emision", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngFechEmisionX, vpMargRecibo.sngNumCheqY +(y*5) );
					//Fecha de Pago
					ev.Graphics.DrawString("Fecha Pago", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngFechPagoX, vpMargRecibo.sngNumCheqY +(y*5) );
					//Importe
					ev.Graphics.DrawString("Importe", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngCHImporteX, vpMargRecibo.sngNumCheqY +(y*5) );	
#endregion
				
					y++;
				
					for (int n = 0; n < vpRecibo.Cheques.Length ; n++) 
					{
						//Esto confirma que sea un cheque válido
						if (vpRecibo.Cheques[n].dblNumCheque.ToString() != "0") {
	
							//y+=n;
							y++;
								//ID
							ev.Graphics.DrawString(vpRecibo.Cheques[n].dblNumCheque.ToString(), Arial10, Brushes.Black,
							                       vpMargRecibo.sngNumCheqX , vpMargRecibo.sngNumCheqY +(y*5) );
							//Banco
							ev.Graphics.DrawString(vpRecibo.Cheques[n].strBanco, Arial10, Brushes.Black, 
							                       vpMargRecibo.sngBancoX, vpMargRecibo.sngNumCheqY +(y*5) );
							//Fecha de Emision
							ev.Graphics.DrawString(vpRecibo.Cheques[n].dtFechaEmision.ToShortDateString(), Arial10, Brushes.Black, 
							                       vpMargRecibo.sngFechEmisionX, vpMargRecibo.sngNumCheqY +(y*5) );
							//Fecha de Pago
							ev.Graphics.DrawString(vpRecibo.Cheques[n].dtFechaPago.ToShortDateString(), Arial10, Brushes.Black, 
							                       vpMargRecibo.sngFechPagoX, vpMargRecibo.sngNumCheqY +(y*5) );
							//Importe
							ev.Graphics.DrawString("$ " + vpRecibo.Cheques[n].curImporte.ToString(), Arial10, Brushes.Black, 
							                       vpMargRecibo.sngCHImporteX, vpMargRecibo.sngNumCheqY +(y*5) );	
						}
					}
				}
			}
			
			
			
			//INTERDEPOSITOS
			if (vpRecibo.Interdepositos != null ) //Corrobora que no sea null 
			{
				if (vpRecibo.Interdepositos[0].dblIDInterdeposito.ToString() != "0") {
					y = y + 2;
					
					ev.Graphics.DrawString("INTERDEPOSITOS", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5) );
					y ++;
					//Divisioria
					ev.Graphics.DrawString("-------------------------------------------------", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5) );
						
					y ++;
				
#region Subtitulos
					//ID
					ev.Graphics.DrawString("IDInterdeposito", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngNumCheqX , vpMargRecibo.sngNumCheqY +(y*5) );
					//Banco
					ev.Graphics.DrawString("Banco", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngBancoX, vpMargRecibo.sngNumCheqY +(y*5) );
					//Fecha de Emision
					ev.Graphics.DrawString("Fecha Emision", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngFechEmisionX, vpMargRecibo.sngNumCheqY +(y*5) );
					//Fecha de Pago
					ev.Graphics.DrawString("Fecha Pago", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngFechPagoX, vpMargRecibo.sngNumCheqY +(y*5) );
					//Importe
					ev.Graphics.DrawString("Importe", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngCHImporteX, vpMargRecibo.sngNumCheqY +(y*5) );
#endregion

				
					y++;
					
					for (int n = 0; n < vpRecibo.Interdepositos.Length ; n++) 
					{
						if (vpRecibo.Interdepositos[n].dblIDInterdeposito.ToString() != "0") 
						{
							y++;	
							
							//ID
							ev.Graphics.DrawString(vpRecibo.Interdepositos[n].dblIDInterdeposito.ToString(), Arial10, Brushes.Black, 
							                       vpMargRecibo.sngNumCheqX , vpMargRecibo.sngNumCheqY +(y*5) );
							//Banco
							ev.Graphics.DrawString(vpRecibo.Interdepositos[n].strBanco, Arial10, Brushes.Black, 
							                       vpMargRecibo.sngBancoX, vpMargRecibo.sngNumCheqY +(y*5) );
							//Fecha de Emision
							ev.Graphics.DrawString(vpRecibo.Interdepositos[n].dtFechaEmision.ToShortDateString(), Arial10, Brushes.Black, 
							                       vpMargRecibo.sngFechEmisionX, vpMargRecibo.sngNumCheqY +(y*5) );
							//Fecha de Pago
							ev.Graphics.DrawString(vpRecibo.Interdepositos[n].dtFechaPago.ToShortDateString(), Arial10, Brushes.Black, 
							                       vpMargRecibo.sngFechPagoX, vpMargRecibo.sngNumCheqY +(y*5) );
							//Importe
							ev.Graphics.DrawString("$" + vpRecibo.Interdepositos[n].curImporte.ToString(), Arial10, Brushes.Black, 
							                       vpMargRecibo.sngCHImporteX, vpMargRecibo.sngNumCheqY +(y*5) );
						}
					}
				}
			}
			
			
			//NCs
			if (vpRecibo.NCs != null ) //Corrobora que no sea null 
			{
				if (vpRecibo.NCs[0].dblNumFact.ToString() != "0")
				{
					y = y + 2;
					
					ev.Graphics.DrawString("NOTAS DE CREDITO", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5) );
					y ++;
					//Divisioria
					ev.Graphics.DrawString("-------------------------------------------------", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5) );
						
					y++;
#region Subtitulos
					ev.Graphics.DrawString("Num", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngNumCheqX , vpMargRecibo.sngNumCheqY +(y*5) );
					//Banco
					//ev.Graphics.DrawString(vpRecibo.NCs[n].strBanco, Arial10, Brushes.Black, vpMargRecibo.sngBancoX, vpMargRecibo.sngNumCheqY +(y*5) );
					//Fecha de Emision
					ev.Graphics.DrawString("Fecha Emision", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngFechEmisionX, vpMargRecibo.sngNumCheqY +(y*5) );
					//Fecha de Pago
					ev.Graphics.DrawString("Fecha Pago", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngFechPagoX, vpMargRecibo.sngNumCheqY +(y*5) );
					//Importe
					ev.Graphics.DrawString("Total", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngCHImporteX, vpMargRecibo.sngNumCheqY +(y*5) );
#endregion
				
					y++;
					
				for (int n = 0; n <  vpRecibo.NCs.Length ; n++) {
						
						
					if (vpRecibo.NCs[n].dblNumFact.ToString() != "0") {
						y++;
						//y+=n;
						
						
						//ID
						ev.Graphics.DrawString(vpRecibo.NCs[n].dblNumFact.ToString(), Arial10, Brushes.Black, 
						                       vpMargRecibo.sngNumCheqX , vpMargRecibo.sngNumCheqY +(y*5) );
						//Banco
						//ev.Graphics.DrawString(vpRecibo.NCs[n].strBanco, Arial10, Brushes.Black, vpMargRecibo.sngBancoX, vpMargRecibo.sngNumCheqY +(y*5) );
						//Fecha de Emision
						ev.Graphics.DrawString(vpRecibo.NCs[n].dtFecha.ToShortDateString(), Arial10, Brushes.Black, 
						                       vpMargRecibo.sngFechEmisionX, vpMargRecibo.sngNumCheqY +(y*5) );
						//Fecha de Pago
						ev.Graphics.DrawString(vpRecibo.NCs[n].dtFecha.ToShortDateString(), Arial10, Brushes.Black, 
						                       vpMargRecibo.sngFechPagoX, vpMargRecibo.sngNumCheqY +(y*5) );
						//Importe
						ev.Graphics.DrawString("$" + vpRecibo.NCs[n].curTotal.ToString(), Arial10, Brushes.Black, 
						                       vpMargRecibo.sngCHImporteX, vpMargRecibo.sngNumCheqY +(y*5) );
						
					}	
					
				}
				}	
			}
#endregion
			
	
			
			//EFECTIVO
			
			if (vpRecibo.curEfectivo.ToString() != "0") 
			{
				
				y++;
				ev.Graphics.DrawString("Efectivo: $ " + vpRecibo.curEfectivo.ToString() , Arial10, Brushes.Black,
			                       vpMargRecibo.sngEfectivoX, vpMargRecibo.sngNumCheqY +(y*5) );
			
			}
						
						
						
						
			//TOTAL COBRANZA
			
#region Facturas ND

			//TODO:FACTURASB
			/*Necesito que la facturas no tengan que ser A B C E o lo que sea
			 * que se carguen como una estructura y que la imprima asi
			 * En un futuro sacar el tema de la FCB
			 */



			//Facturas
			if (vpRecibo.Facturas  != null ) //Corrobora que no sea null 
			{
				if (vpRecibo.Facturas[0].dblNumFact.ToString() != "0") {
					
				
					y = y + 2;
					
					ev.Graphics.DrawString("FACTURAS", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5) );
					y ++;
					//Divisioria
					ev.Graphics.DrawString("-------------------------------------------------", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5) );
					
					y++;
					
#region Subtitulos
					//ID
					ev.Graphics.DrawString("Comprobante", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(n*5) );
					
					//Fecha 
					ev.Graphics.DrawString("Fecha", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngFactFechaX,vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(n*5) );
					
					//Importe
					ev.Graphics.DrawString("Total", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngFactImpoteX, vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(n*5) );
#endregion

					y ++;
					
					for (int n = 0; n < vpRecibo.Facturas.Length ; n++) 
				{
					if (vpRecibo.Facturas[n].dblNumFact.ToString() != "0") {
					y ++;
					
					//y+=n;//intRenglonFacturas += n;
					
					//ID
					ev.Graphics.DrawString(vpRecibo.Facturas[n].dblNumFact.ToString(), Arial10, Brushes.Black,
				                       		vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(n*5) );
				
					//Fecha 
					ev.Graphics.DrawString(vpRecibo.Facturas[n].dtFecha.ToShortDateString(), Arial10, Brushes.Black, 
					                       	vpMargRecibo.sngFactFechaX,vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(n*5) );
					
					//Importe
					ev.Graphics.DrawString("$" + vpRecibo.Facturas[n].curTotal.ToString(), Arial10, Brushes.Black, 
				                      	 	vpMargRecibo.sngFactImpoteX, vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(n*5) );
				
					}
				}
				}
			}
			
			//Facturas
			if (vpRecibo.FacturasB  != null ) //Corrobora que no sea null 
			{
				if (vpRecibo.FacturasB[0].dblNumFact.ToString() != "0") {
					
				
					y = y + 2;
					
					ev.Graphics.DrawString("FACTURAS B", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5) );
					y ++;
					//Divisioria
					ev.Graphics.DrawString("-------------------------------------------------", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5) );
					
					y++;
					
#region Subtitulos
					//ID
					ev.Graphics.DrawString("Comprobante", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(n*5) );
					
					//Fecha 
					ev.Graphics.DrawString("Fecha", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngFactFechaX,vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(n*5) );
					
					//Importe
					ev.Graphics.DrawString("Total", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngFactImpoteX, vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(n*5) );
#endregion

					y ++;
					
					for (int n = 0; n < vpRecibo.FacturasB.Length ; n++) 
				{
					if (vpRecibo.FacturasB[n].dblNumFact.ToString() != "0") {
					y ++;
					
					//y+=n;//intRenglonFacturas += n;
					
					//ID
					ev.Graphics.DrawString(vpRecibo.FacturasB[n].dblNumFact.ToString(), Arial10, Brushes.Black,
				                       		vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(n*5) );
				
					//Fecha 
					ev.Graphics.DrawString(vpRecibo.FacturasB[n].dtFecha.ToShortDateString(), Arial10, Brushes.Black, 
					                       	vpMargRecibo.sngFactFechaX,vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(n*5) );
					
					//Importe
					ev.Graphics.DrawString("$" + vpRecibo.FacturasB[n].curTotal.ToString(), Arial10, Brushes.Black, 
				                      	 	vpMargRecibo.sngFactImpoteX, vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(n*5) );
				
					}
				}
				}
			}
			
			// ND
			if (vpRecibo.NDs  != null ) //Corrobora que no sea null 
			{
				if (vpRecibo.NDs[0].dblNumFact.ToString() != "0") {
				
					y = y + 2;
					
					ev.Graphics.DrawString("NOTA DE DEBITO", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5) );
					y ++;
					//Divisioria
					ev.Graphics.DrawString("-------------------------------------------------", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5) );
		
					y ++;
#region Subtitutlos		
					//ID
					ev.Graphics.DrawString("Comprobante", Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(intRenglonFacturas*5) );
					
					//Fecha 
					ev.Graphics.DrawString("Fecha", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngFactFechaX, vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(intRenglonFacturas*5) );
					
					//Importe
					ev.Graphics.DrawString("Total", Arial10, Brushes.Black, 
					                       vpMargRecibo.sngFactImpoteX, vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(intRenglonFacturas*5) );
				
#endregion
					y ++;
					
					for (int n = 0; n < vpRecibo.NDs.Length ; n++) 
				{
					if (vpRecibo.NDs[n].dblNumFact.ToString() != "0") {
						y ++;
					//y+=n;//intRenglonFacturas += n;
					
					//ID
					ev.Graphics.DrawString(vpRecibo.NDs[n].strComprobante, Arial10, Brushes.Black,
					                       vpMargRecibo.sngFactX , vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(intRenglonFacturas*5) );
					
					//Fecha 
					ev.Graphics.DrawString(vpRecibo.NDs[n].dtFecha.ToShortDateString(), Arial10, Brushes.Black, 
					                       vpMargRecibo.sngFactFechaX, vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(intRenglonFacturas*5) );
					
					//Importe
					ev.Graphics.DrawString("$" + vpRecibo.NDs[n].curTotal.ToString(), Arial10, Brushes.Black, 
					                       vpMargRecibo.sngFactImpoteX, vpMargRecibo.sngNumCheqY +(y*5)); // vpMargRecibo.sngFactY +(intRenglonFacturas*5) );
				
					}
					
				
				}
			
				}
			}



#endregion
			
			
		
			//OTROS
			//Subtotal
			ev.Graphics.DrawString("| SubTotal: $ " + vpRecibo.curSubTotal.ToString(), Arial10, Brushes.Black, 
			                       vpMargRecibo.sngSubtotalX, vpMargRecibo.sngSubtotalY) ;
			
			
			//Descuento
			ev.Graphics.DrawString("| Descuento: $ " + vpRecibo.curDescuento.ToString(), Arial10, Brushes.Black, 
			                       vpMargRecibo.sngDescuentoX, vpMargRecibo.sngDescuentoY) ;
			
			//Retenciones
			ev.Graphics.DrawString("| Retenciones: $ " + vpRecibo.curRetenciones.ToString(), Arial10, Brushes.Black, 
			                       vpMargRecibo.sngRetencionesX, vpMargRecibo.sngRetencionesY) ;
			//N/O
			ev.Graphics.DrawString("| N/O: $ " + vpRecibo.curNO.ToString(), Arial10, Brushes.Black, 
			                       vpMargRecibo.sngNOX, vpMargRecibo.sngNOY) ;
			//Varios
			ev.Graphics.DrawString("| Varios: $ " + vpRecibo.curVarios.ToString(), Arial10, Brushes.Black, 
			                       vpMargRecibo.sngVariosX, vpMargRecibo.sngVariosY) ;
			//Total
			ev.Graphics.DrawString("| Total: $ " + vpRecibo.curCobranzaNeta.ToString(), Arial10, Brushes.Black, 
			                       vpMargRecibo.sngTotalCobranzaX, vpMargRecibo.sngTotalCobranzaY) ;




//Final del documento
ev.Graphics.DrawString("Firma: _______________________________________ Aclaracion:_________________________________"
                       , Arial12 , Brushes.Black , 10 , 270 );



			
			//ev.Graphics.DrawString(
			/*ev.Graphics.DrawString(vpRemito.IDRemito , Arial12 , Brushes.Black , vpMargRemito.sngNumeroRemiX,vpMargRemito.sngNumeroRemiY);
			
			
			






			
			
			//Lo que vamos a imprimir
			//
			/*
			 *ev es el encargado de dibujar en el lienzo lo que vamos a imprir 
			 * Drawingstring es el encargado de dibujar el texto con un determinado formato y ponienodolo en las
			 * direcciones de X e Y
			 * Esto es TEXTO, FUENTE, X, Y para ver donde lo deja
			*/
			
			
			
			
		}

		
		
		
#endregion
		
		
#region FACTURA

	static VariablesPropias.VariablesPropias.vpFactura ObtenerFactura = new VariablesPropias.VariablesPropias.vpFactura();	
		
///<summary>
///Imprime una Factura
///</summary>
		public static  void Imprimir_Factura(VariablesPropias.VariablesPropias.vpFactura fact)
		{
			//Este método contiene dos componentes muy importantes los cuales son:
			//PrintDocument y printDialog estos métodos definen las propiedades de impresión
			//como son: numero de copias, numero de paginas y seleccionar tipo de impresora
			//estas son las variables donde almacenaremos los datos del cliente
	
			
			
			
			//Esto pasa los datos que recibo a la variable estatica general de aca.
			//de esa manera puedo pasar los datos en el 
			ObtenerFactura  = fact; 
			
			
			
			
			PrintDocument formulario = new PrintDocument();
					
			
			formulario.PrintPage += new PrintPageEventHandler(Datos_Factura);// Datos Cliente es el lienzo
			
			
			//Este es el Print Dialog -- El formulario de impresion ;)
			PrintDialog printDialog1 = new PrintDialog();
			printDialog1.Document = formulario;
			printDialog1.PrinterSettings.Copies = 3;// marca que son cuatro copias si no hace nada
			//printDialog1.PrinterSettings.DefaultPageSettings.Landscape = false; //hoja apaizada
			DialogResult result = printDialog1.ShowDialog();
		
			if (result == DialogResult.OK)
			{
			formulario.Print();
			}
		}

		

///<summary>
/// En este metodo se define los datos a imprimir. En este caso una Factura
/// </summary>	
		//private static void Datos_Remito(VariablesPropias.VariablesPropias.vpRemito remit, object obj, PrintPageEventArgs ev)
		private static void Datos_Factura(object obj, PrintPageEventArgs ev)
		
		
		{
			
			/*
			 *ev es el encargado de dibujar en el lienzo lo que vamos a imprir 
			 * Drawingstring es el encargado de dibujar el texto con un determinado formato y ponienodolo en las
			 * direcciones de X e Y
			 * Esto es TEXTO, FUENTE, X, Y para ver donde lo deja
			*/
			
			
			
			
			
			VariablesPropias.VariablesPropias.vpFactura vpFactura = new VariablesPropias.VariablesPropias.vpFactura();
			VariablesPropias.VariablesPropias.vpMargenesFact vpMargFact = new VariablesPropias.VariablesPropias.vpMargenesFact();
			

			
			//Asi cargo los datos de la variable general en la que voy a usar aca..
			vpFactura = ObtenerFactura;
			
			//El numero de renglon
			//int y = 0;
			//int intRenglonFacturas = 0;
			
			
			
#region Margenes


			//Tener en cuenta que hay 5mm de altura demas (a restar)			
			//Tener en cuenta que hay 4mm de largo demas
			
			Single correccionX = 4;
			Single correccionY = 5;





			//Todos los margenes a Cero y despues los anoto
			vpMargFact.sngTipoX=105 -correccionX;
			vpMargFact.sngTipoY=22  -correccionY;

			vpMargFact.sngCodFCX=107 -correccionX;
			vpMargFact.sngCodFCY=27 -correccionY;

			vpMargFact.sngNumeroFactX= 182 -correccionX;
			vpMargFact.sngNumeroFactY= 30 -correccionY;

			vpMargFact.sgnPtoVentaX = 140 -correccionX;
			vpMargFact.sgnPtoVentaY = 30 -correccionY;
			
			vpMargFact.sngFechaX= 150 -correccionX;
			vpMargFact.sngFechaY= 40 -correccionY;

			vpMargFact.sngRazonSocX= 125 -correccionX;
			vpMargFact.sngRazonSocY= 61 -correccionY;

			vpMargFact.sngDomicilioX= 125 -correccionX;
			vpMargFact.sngDomicilioY= 69 -correccionY;

			vpMargFact.sngLocalidadX= 165 -correccionX;
			vpMargFact.sngLocalidadY= 69 -correccionY;

			vpMargFact.sngProvinciaX= 125 -correccionX;
			vpMargFact.sngProvinciaY= 72 -correccionY;

			vpMargFact.sngCUITX= 23 -correccionX;
			vpMargFact.sngCUITY= 63 -correccionY;

			vpMargFact.sngPosIVAX= 49 -correccionX;
			vpMargFact.sngPosIVAY= 68 -correccionY;

			vpMargFact.sngTCambioX= 125 -correccionX;
			vpMargFact.sngTCambioY= 217 -correccionY;


			//Remitos

			vpMargFact.sngRemi1X= 130 -correccionX;
			vpMargFact.sngRemi1Y= 76 -correccionY;
			
			vpMargFact.sngRemi2X= 140 -correccionX;
			vpMargFact.sngRemi2Y= 76 -correccionY;
			
			vpMargFact.sngRemi3X= 150 -correccionX;
			vpMargFact.sngRemi3Y= 76 -correccionY;
			
			vpMargFact.sngRemi4X= 160 -correccionX;
			vpMargFact.sngRemi4Y= 76 -correccionY;



			//Producto1
			//Personalmente creo que la variable sng*****Y podria ser reemplazada por una sola
			//Ej: sngProducto1Y y cada una de las X variara pero tambien deberian setearse como unicas.

			//TODO Esto tambien deberia ser un array
			

			vpMargFact.sngDetalle1X= 22 -correccionX;
			vpMargFact.sngDetalle1Y= 95 -correccionY;
			
			vpMargFact.sngCant1X=85 -correccionX;;
			vpMargFact.sngCant1Y= 95 -correccionY;
			
			vpMargFact.sngMedida1X= 100-correccionX;
			vpMargFact.sngMedida1Y= 95 -correccionY;
			
			vpMargFact.sngPrecioUnit1X= 115 -correccionX;
			vpMargFact.sngPrecioUnit1Y= 95 -correccionY;
			
			vpMargFact.sngBonificacion1X= 135 -correccionX;
			vpMargFact.sngBonificacion1Y= 95 -correccionY;
			
			vpMargFact.sngSubTotal1X= 150 -correccionX;
			vpMargFact.sngSubTotal1Y= 95 -correccionY;
			
			vpMargFact.sngAlicuota1X= 170 -correccionX;
			vpMargFact.sngAlicuota1Y= 95 -correccionY;
			
			vpMargFact.sngSubTotalCIVA1X= 185 -correccionX;
			vpMargFact.sngSubTotalCIVA1Y= 95 -correccionY;

			//Producto2
			vpMargFact.sngDetalle2X= 22 -correccionX;
			vpMargFact.sngDetalle2Y= 101 -correccionY;
			
			vpMargFact.sngCant2X=85 -correccionX;;
			vpMargFact.sngCant2Y= 101 -correccionY;
			
			vpMargFact.sngMedida2X= 100-correccionX;
			vpMargFact.sngMedida2Y= 101 -correccionY;
			
			vpMargFact.sngPrecioUnit2X= 115 -correccionX;
			vpMargFact.sngPrecioUnit2Y= 101 -correccionY;
			
			vpMargFact.sngBonificacion2X= 135 -correccionX;
			vpMargFact.sngBonificacion2Y= 101 -correccionY;
			
			vpMargFact.sngSubTotal2X= 150 -correccionX;
			vpMargFact.sngSubTotal2Y= 101 -correccionY;
			
			vpMargFact.sngAlicuota2X= 170 -correccionX;
			vpMargFact.sngAlicuota2Y= 101 -correccionY;
			
			vpMargFact.sngSubTotalCIVA2X= 185 -correccionX;
			vpMargFact.sngSubTotalCIVA2Y= 101 -correccionY;
			
			//Producto3
			vpMargFact.sngDetalle3X= 22 -correccionX;
			vpMargFact.sngDetalle3Y= 107 -correccionY;
			
			vpMargFact.sngCant3X=85 -correccionX;;
			vpMargFact.sngCant3Y= 107 -correccionY;
			
			vpMargFact.sngMedida3X= 100-correccionX;
			vpMargFact.sngMedida3Y= 107 -correccionY;
			
			vpMargFact.sngPrecioUnit3X= 115 -correccionX;
			vpMargFact.sngPrecioUnit3Y= 107 -correccionY;
			
			vpMargFact.sngBonificacion3X= 135 -correccionX;
			vpMargFact.sngBonificacion3Y= 107 -correccionY;
			
			vpMargFact.sngSubTotal3X= 150 -correccionX;
			vpMargFact.sngSubTotal3Y= 107 -correccionY;
			
			vpMargFact.sngAlicuota3X= 170 -correccionX;
			vpMargFact.sngAlicuota3Y= 107 -correccionY;
			
			vpMargFact.sngSubTotalCIVA3X= 185 -correccionX;
			vpMargFact.sngSubTotalCIVA3Y= 107 -correccionY;
			
			//Producto4
			vpMargFact.sngDetalle4X= 22 -correccionX;
			vpMargFact.sngDetalle4Y= 113 -correccionY;
			
			vpMargFact.sngCant4X=85 -correccionX;;
			vpMargFact.sngCant4Y= 113 -correccionY;
			
			vpMargFact.sngMedida4X= 100-correccionX;
			vpMargFact.sngMedida4Y= 113 -correccionY;
			
			vpMargFact.sngPrecioUnit4X= 115 -correccionX;
			vpMargFact.sngPrecioUnit4Y= 113 -correccionY;
			
			vpMargFact.sngBonificacion4X= 135 -correccionX;
			vpMargFact.sngBonificacion4Y= 113 -correccionY;
			
			vpMargFact.sngSubTotal4X= 150 -correccionX;
			vpMargFact.sngSubTotal4Y= 113 -correccionY;
			
			vpMargFact.sngAlicuota4X= 170 -correccionX;
			vpMargFact.sngAlicuota4Y= 113 -correccionY;
			
			vpMargFact.sngSubTotalCIVA4X= 185 -correccionX;
			vpMargFact.sngSubTotalCIVA4Y= 113 -correccionY;
			
			//Producto5
			vpMargFact.sngDetalle5X= 22 -correccionX;
			vpMargFact.sngDetalle5Y= 119 -correccionY;
			
			vpMargFact.sngCant5X=85 -correccionX;
			vpMargFact.sngCant5Y= 119 -correccionY;
			
			vpMargFact.sngMedida5X= 100-correccionX;
			vpMargFact.sngMedida5Y= 119 -correccionY;
			
			vpMargFact.sngPrecioUnit5X= 115 -correccionX;
			vpMargFact.sngPrecioUnit5Y= 119 -correccionY;
			
			vpMargFact.sngBonificacion5X= 135 -correccionX;
			vpMargFact.sngBonificacion5Y= 119 -correccionY;
			
			vpMargFact.sngSubTotal5X= 150 -correccionX;
			vpMargFact.sngSubTotal5Y= 119 -correccionY;
			
			vpMargFact.sngAlicuota5X= 170 -correccionX;
			vpMargFact.sngAlicuota5Y= 119 -correccionY;
			
			vpMargFact.sngSubTotalCIVA5X= 185 -correccionX;
			vpMargFact.sngSubTotalCIVA5Y= 119 -correccionY;

			//SubTotal
			vpMargFact.sngSubtotalX= 183 -correccionX;
			vpMargFact.sngSubtotalY= 184 -correccionY;

			//IVA
			vpMargFact.sngIVAX= 183 -correccionX;
			vpMargFact.sngIVAY= 192 -correccionY;

			//Total
			vpMargFact.sngTotalX= 183 -correccionX;
			vpMargFact.sngTotalY= 208 -correccionY;

			//Total En Pesos
			vpMargFact.sngTotalPesosX= 183 -correccionX;
			vpMargFact.sngTotalPesosY= 217 -correccionY;


			//CAE
			vpMargFact.sngCAEX= 172 -correccionX;
			vpMargFact.sngCAEY= 235 -correccionY;

			//FchVtoCAE
			vpMargFact.sngFVtoCAEX= 172 -correccionX;
			vpMargFact.sngFVtoCAEY= 240 -correccionY;

			//Codigo de Barras
			vpMargFact.sngCodBarrasX= 5 -correccionX;
			vpMargFact.sngCodBarrasY= 265 -correccionY;

			vpMargFact.sngNumCodBarrasX= 5 -correccionX;
			vpMargFact.sngNumCodBarrasY= 255 -correccionY;

#endregion
			
#region FUENTES			
		
			//la siguiente variable define el estilo de fuente y tamaño a usar
			//en este caso se utilizo Arial,12
	
			Font Arial12 = new Font("Arial", 12);
			Font Arial10 = new Font("Arial", 10);
			Font Arial08 = new Font("Arial", 8);
			Font Arial06 = new Font("Arial", 6);
			
#endregion
			
#region INFO

			
			//De esta manera se pasa de Twips a Milimetros un bardo encontrarlo pero funca.
			ev.Graphics.PageUnit = GraphicsUnit.Millimeter;
			
			/*
			 * Esto es para controlar el 
			 */
			ev.Graphics.DrawString(".", Arial08, Brushes.Black, 0,0);
#endregion			
			
#region	CABECERA
			
			//Tipo de Comprobante
			ev.Graphics.DrawString(vpFactura.strTipoFc , Arial12 , Brushes.Black , 
			                       vpMargFact.sngTipoX,vpMargFact.sngTipoY);
			//Numero de Comprobante
			ev.Graphics.DrawString(vpFactura.strCodFc , Arial12 , Brushes.Black , 
			                       vpMargFact.sngCodFCX,vpMargFact.sngCodFCY);
			
			//Punto de Venta
			ev.Graphics.DrawString(vpFactura.intSucursal .ToString() , Arial12 , Brushes.Black , 
			                       vpMargFact.sgnPtoVentaX, vpMargFact.sgnPtoVentaY);
			
			//numero de Factura
			ev.Graphics.DrawString(vpFactura.dblNumFact.ToString() , Arial12 , Brushes.Black , 
			                       vpMargFact.sngNumeroFactX, vpMargFact.sngNumeroFactY);



			//Fecha
			ev.Graphics.DrawString(vpFactura.dtFecha.ToShortDateString(), Arial10, Brushes.Black, 
			                       vpMargFact.sngFechaX,vpMargFact.sngFechaY);
			
			//Cliente
			
			//Nombre
			ev.Graphics.DrawString(vpFactura.Cliente.strNombre , Arial10 , Brushes.Black, 
			                      vpMargFact.sngRazonSocX ,vpMargFact.sngRazonSocY);
			
			//Direccion
			ev.Graphics.DrawString(vpFactura.Cliente.strDireccion, Arial08 , Brushes.Black, 
			                       vpMargFact.sngDomicilioX, vpMargFact.sngDomicilioY);
			ev.Graphics.DrawString(vpFactura.Cliente.strLocalidad, Arial08 , Brushes.Black, 
			                       vpMargFact.sngLocalidadX, vpMargFact.sngLocalidadY);
			ev.Graphics.DrawString(vpFactura.Cliente.strProvincia, Arial08 , Brushes.Black, 
			                       vpMargFact.sngProvinciaX, vpMargFact.sngProvinciaY);

			ev.Graphics.DrawString(vpFactura.Cliente.dblCUIT.ToString(), Arial08 , Brushes.Black, 
			                       vpMargFact.sngCUITX, vpMargFact.sngCUITY);
			
			ev.Graphics.DrawString("Resp. Insc" , Arial08 , Brushes.Black, 
			                       vpMargFact.sngPosIVAX, vpMargFact.sngPosIVAY);
			
			ev.Graphics.DrawString(vpFactura.dblTipoCambio.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngTCambioX, vpMargFact.sngTCambioY);
#endregion

#region Remitos

			if (vpFactura.intRemito1 != 0) {
			ev.Graphics.DrawString(vpFactura.intRemito1.ToString(), Arial08 , Brushes.Black,
			                       	vpMargFact.sngRemi1X, vpMargFact.sngRemi1Y);	
			}	
			if (vpFactura.intRemito2 != 0) {
			ev.Graphics.DrawString(vpFactura.intRemito2.ToString(), Arial08 , Brushes.Black,
			                       	vpMargFact.sngRemi2X, vpMargFact.sngRemi2Y);
			}
			if (vpFactura.intRemito3 != 0) {
			ev.Graphics.DrawString(vpFactura.intRemito3.ToString(), Arial08 , Brushes.Black,
	        	               		vpMargFact.sngRemi3X, vpMargFact.sngRemi3Y);
			}
			                       
			if (vpFactura.intRemito4 != 0) {
           	ev.Graphics.DrawString(vpFactura.intRemito4.ToString(), Arial08 , Brushes.Black,
			                       	vpMargFact.sngRemi4X, vpMargFact.sngRemi4Y);
			}
			                       

#endregion

#region Mercaderia

//Producto1
if (vpFactura.Productos[0].strDescripcion != null || vpFactura.Productos[0].strDescripcion != "") {			
	
			ev.Graphics.DrawString(vpFactura.Productos[0].strDescripcion, Arial08 , Brushes.Black,
			                       vpMargFact.sngDetalle1X, vpMargFact.sngDetalle1Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[0].intCantidad.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngCant1X, vpMargFact.sngCant1Y);
			
			ev.Graphics.DrawString("Unidades" , Arial08 , Brushes.Black,
			                       vpMargFact.sngMedida1X, vpMargFact.sngMedida1Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[0].curPrecioNeto.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngPrecioUnit1X, vpMargFact.sngPrecioUnit1Y);
			
			ev.Graphics.DrawString("", Arial08 , Brushes.Black,
			                       vpMargFact.sngBonificacion1X, vpMargFact.sngBonificacion1Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[0].curPrecioSubTotal.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngSubTotal1X, vpMargFact.sngSubTotal1Y);

			ev.Graphics.DrawString(vpFactura.Productos[0].dblTipoIVA.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngAlicuota1X, vpMargFact.sngAlicuota1Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[0].curPrecioTotal.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngSubTotalCIVA1X, vpMargFact.sngSubTotalCIVA1Y);
	
}
			
//Producto2
if (vpFactura.Productos[1].strDescripcion != null ) {						
			ev.Graphics.DrawString(vpFactura.Productos[1].strDescripcion, Arial08 , Brushes.Black,
			                       vpMargFact.sngDetalle2X, vpMargFact.sngDetalle2Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[1].intCantidad.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngCant2X, vpMargFact.sngCant2Y);
			
			ev.Graphics.DrawString("Unidades" , Arial08 , Brushes.Black,
			                       vpMargFact.sngMedida2X, vpMargFact.sngMedida2Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[1].curPrecioNeto.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngPrecioUnit2X, vpMargFact.sngPrecioUnit2Y);
			
			ev.Graphics.DrawString("", Arial08 , Brushes.Black,
			                       vpMargFact.sngBonificacion2X, vpMargFact.sngBonificacion2Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[1].curPrecioSubTotal.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngSubTotal2X, vpMargFact.sngSubTotal2Y);

			ev.Graphics.DrawString(vpFactura.Productos[1].dblTipoIVA.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngAlicuota2X, vpMargFact.sngAlicuota2Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[1].curPrecioTotal.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngSubTotalCIVA2X, vpMargFact.sngSubTotalCIVA2Y);
}

//Producto3
if (vpFactura.Productos[2].strDescripcion != null) {						
			ev.Graphics.DrawString(vpFactura.Productos[2].strDescripcion, Arial08 , Brushes.Black,
			                       vpMargFact.sngDetalle3X, vpMargFact.sngDetalle3Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[2].intCantidad.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngCant3X, vpMargFact.sngCant3Y);
			
			ev.Graphics.DrawString("Unidades" , Arial08 , Brushes.Black,
			                       vpMargFact.sngMedida3X, vpMargFact.sngMedida3Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[2].curPrecioNeto.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngPrecioUnit3X, vpMargFact.sngPrecioUnit3Y);
			
			ev.Graphics.DrawString("", Arial08 , Brushes.Black,
			                       vpMargFact.sngBonificacion3X, vpMargFact.sngBonificacion3Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[2].curPrecioSubTotal.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngSubTotal3X, vpMargFact.sngSubTotal3Y);

			ev.Graphics.DrawString(vpFactura.Productos[2].dblTipoIVA.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngAlicuota3X, vpMargFact.sngAlicuota3Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[2].curPrecioTotal.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngSubTotalCIVA3X, vpMargFact.sngSubTotalCIVA3Y);
}
			
//Producto4
if (vpFactura.Productos[3].strDescripcion != null) {			
			ev.Graphics.DrawString(vpFactura.Productos[3].strDescripcion, Arial08 , Brushes.Black,
			                       vpMargFact.sngDetalle4X, vpMargFact.sngDetalle4Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[3].intCantidad.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngCant4X, vpMargFact.sngCant4Y);
			
			ev.Graphics.DrawString("Unidades" , Arial08 , Brushes.Black,
			                       vpMargFact.sngMedida4X, vpMargFact.sngMedida4Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[3].curPrecioNeto.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngPrecioUnit4X, vpMargFact.sngPrecioUnit4Y);
			
			ev.Graphics.DrawString("", Arial08 , Brushes.Black,
			                       vpMargFact.sngBonificacion4X, vpMargFact.sngBonificacion4Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[3].curPrecioSubTotal.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngSubTotal4X, vpMargFact.sngSubTotal4Y);

			ev.Graphics.DrawString(vpFactura.Productos[3].dblTipoIVA.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngAlicuota4X, vpMargFact.sngAlicuota4Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[3].curPrecioTotal.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngSubTotalCIVA4X, vpMargFact.sngSubTotalCIVA4Y);
}

//Producto5
if (vpFactura.Productos[4].strDescripcion != null) {			
			ev.Graphics.DrawString(vpFactura.Productos[4].strDescripcion, Arial08 , Brushes.Black,
			                       vpMargFact.sngDetalle5X, vpMargFact.sngDetalle5Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[4].intCantidad.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngCant5X, vpMargFact.sngCant5Y);
			
			ev.Graphics.DrawString("Unidades" , Arial08 , Brushes.Black,
			                       vpMargFact.sngMedida5X, vpMargFact.sngMedida5Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[4].curPrecioNeto.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngPrecioUnit5X, vpMargFact.sngPrecioUnit5Y);
			
			ev.Graphics.DrawString("", Arial08 , Brushes.Black,
			                       vpMargFact.sngBonificacion5X, vpMargFact.sngBonificacion5Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[4].curPrecioSubTotal.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngSubTotal5X, vpMargFact.sngSubTotal5Y);

			ev.Graphics.DrawString(vpFactura.Productos[4].dblTipoIVA.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngAlicuota5X, vpMargFact.sngAlicuota5Y);
			
			ev.Graphics.DrawString(vpFactura.Productos[4].curPrecioTotal.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngSubTotalCIVA5X, vpMargFact.sngSubTotalCIVA5Y);
}


#endregion

#region Totales

	

			//SubTotal
			ev.Graphics.DrawString(vpFactura.curSubTotalUSD.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngSubtotalX, vpMargFact.sngSubtotalY);
			
			//IVA
			ev.Graphics.DrawString(vpFactura.curIVAUSD.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngIVAX, vpMargFact.sngIVAY);
			
			//Total
			ev.Graphics.DrawString(vpFactura.curTotalUSD.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngTotalX, vpMargFact.sngTotalY);

			//Total En Pesos
			ev.Graphics.DrawString(vpFactura.curTotal.ToString(), Arial08 , Brushes.Black,
			                       vpMargFact.sngTotalPesosX, vpMargFact.sngTotalPesosY);
		
			//CAE
			ev.Graphics.DrawString(vpFactura.strCAE, Arial08 , Brushes.Black,
			                       vpMargFact.sngCAEX, vpMargFact.sngCAEY);
			

			//FchVtoCAE
			ev.Graphics.DrawString(vpFactura.strFechVtoCAE, Arial08 , Brushes.Black,
			                       vpMargFact.sngFVtoCAEX, vpMargFact.sngFVtoCAEY);
			
		
			//Codigo de Barras
			

			
			ev.Graphics.DrawImage(vpFactura.picCodBarras, 
			                      vpMargFact.sngCodBarrasX , vpMargFact.sngCodBarrasY);
			ev.Graphics.DrawString(vpFactura.strCodBarrasNum, Arial08 , Brushes.Black, 
			                      vpMargFact.sngNumCodBarrasX, vpMargFact.sngNumCodBarrasY);
			
			
			
#endregion


	
		
		
	}
	
	
#endregion	


#region Listado de cheques
static DataTable   ObtenerListadoDeCheques = new DataTable();	
		
///<summary>
///Imprime el listado de los cheques
///</summary>
		public static  void Imprimir_ListadoDeCheques(DataTable ListadoDeCheques)
		{
			//Este método contiene dos componentes muy importantes los cuales son:
			//PrintDocument y printDialog estos métodos definen las propiedades de impresión
			//como son: numero de copias, numero de paginas y seleccionar tipo de impresora
			//estas son las variables donde almacenaremos los datos del cliente
	
			
			
			
			//Esto pasa los datos que recibo a la variable estatica general de aca.
			//de esa manera puedo pasar los datos en el 
			ObtenerListadoDeCheques  = ListadoDeCheques; 
			
			
			
			
			PrintDocument formulario = new PrintDocument();
					
			
			formulario.PrintPage += new PrintPageEventHandler(Datos_ListadoDeCheques);// Datos Cliente es el lienzo
			
			
			//Este es el Print Dialog -- El formulario de impresion ;)
			PrintDialog printDialog1 = new PrintDialog();
			printDialog1.Document = formulario;
			printDialog1.PrinterSettings.Copies = 1;// marca que son cuatro copias si no hace nada
			printDialog1.PrinterSettings.DefaultPageSettings.Landscape = true; //hoja apaizada
			DialogResult result = printDialog1.ShowDialog();
		
			if (result == DialogResult.OK)
			{
			formulario.Print();
			}
		}

		

///<summary>
/// En este metodo se define los datos a imprimir. En este caso una Factura
/// </summary>	
		//private static void Datos_Remito(VariablesPropias.VariablesPropias.vpRemito remit, object obj, PrintPageEventArgs ev)
		private static void Datos_ListadoDeCheques(object obj, PrintPageEventArgs ev)
		
		
		{
			
			/*
			 *ev es el encargado de dibujar en el lienzo lo que vamos a imprir 
			 * Drawingstring es el encargado de dibujar el texto con un determinado formato y ponienodolo en las
			 * direcciones de X e Y
			 * Esto es TEXTO, FUENTE, X, Y para ver donde lo deja
			*/
			
#region FUENTES			
		
			//la siguiente variable define el estilo de fuente y tamaño a usar
			//en este caso se utilizo Arial,12
	
			Font Arial24 = new Font("Arial", 24);
			Font Arial12 = new Font("Arial", 12);
			Font Arial10 = new Font("Arial", 10);
			Font Arial08 = new Font("Arial", 8);
			Font Arial06 = new Font("Arial", 6);
			
#endregion			
			
		
#region INFO

			
			//De esta manera se pasa de Twips a Milimetros un bardo encontrarlo pero funca.
			ev.Graphics.PageUnit = GraphicsUnit.Millimeter;
			
			/*
			 * Esto es para controlar el margen superior
			 */
			ev.Graphics.DrawString(".", Arial08, Brushes.Black, 0,0);
#endregion	


			//Tabla para manejar los datos
			DataTable  Listado = new DataTable ();
			

			
			//Asi cargo los datos de la variable general en la que voy a usar aca..
			Listado = ObtenerListadoDeCheques;
			
			//El numero de renglon
			//int y = 0;
			//int intRenglonFacturas = 0;
			
			Single ejeX = 0;
			Single ejeY = 0;

			//MessageBox.Show (Listado.Rows.Count.ToString());
			
#region Margenes


			//Tener en cuenta que hay 5mm de altura demas (a restar)			
			//Tener en cuenta que hay 4mm de largo demas
			
			Single correccionX = 1;
			Single correccionY = 6;

#endregion

nuevahoja:
			
#region	CABECERA
			
			//Tipo de Comprobante
			ev.Graphics.DrawString("LISTADO DE CHEQUES EN CARTELERA" , Arial12 , Brushes.Black , 
			                       10 -correccionX, 6 -correccionY) ;


			//Fecha
			ev.Graphics.DrawString(DateTime.Today.ToShortDateString(), Arial10, Brushes.Black, 
			                         150 -correccionX, 6 -correccionY) ;

			
			//Linea
			ev.Graphics.DrawLine(Pens.Black,
			                     0 -correccionX, 12 -correccionY,  //inicio  
			                     200 -correccionX, 12 -correccionY); //final ;
			
			
			ejeX = 10;
			ejeY = 20;
			
			// armo el encabezado
			foreach (DataColumn col in Listado.Columns) 
				{
			     //MessageBox.Show (col.Ordinal.ToString());    
				
			     
				ev.Graphics.DrawString(col.ColumnName, Arial08, Brushes.Black,
			                           ejeX -correccionX, ejeY -correccionY) ;
			     
			    
					ejeX += Convert.ToSingle (col.ColumnName.Length*2); //Agrega el tamaño de la columna a definir
				}
			
#endregion			
			

		for (int i = 0; i < Listado.Rows.Count-1; i++) {
	
    	ejeY = 20;
     
	  	foreach (DataRow row in Listado.Rows) 
	      {
	         	
	      	foreach (DataColumn col in Listado.Columns) 
	      	{
	      		//consulta cada fila para ver que es.
	         	if (col.DataType.Equals(typeof(DateTime)))
	         	 	{
				
					ev.Graphics.DrawString(row[col].ToString(), Arial10, Brushes.Black,
	                           ejeX -correccionX, ejeY -correccionY) ;
				 	}
	         	
	         	if (col.DataType.Equals(typeof(Decimal)))
	            	{
	            		
	        		ev.Graphics.DrawString(row[col].ToString(), Arial10, Brushes.Black,
	                           ejeX -correccionX, ejeY -correccionY) ;
	            	}
	         	
	         	else
	            	{
	            		
	        		ev.Graphics.DrawString(row[col].ToString(), Arial10, Brushes.Black,
	                           ejeX -correccionX, ejeY -correccionY) ;
	            	}
	         	
				//Agrega el tamaño de la columna al eje X
     			ejeX += Convert.ToSingle (col.ColumnName.Length*2); //Agrega el tamaño de la columna a definir 	
	         	
	         	
	      	}
	         
			if (ejeY < 90) {
	         		ejeY += 5;	
	         	}
	         	else
	         	{
	         		//goto nuevahoja;
	         		
	         		ev.HasMorePages = true; 
	         		ejeX = 10;
					ejeY = 20;
	         	}
	      	
	       
	      }
	     
		}



ev.HasMorePages = false ; 


/*

      foreach (DataRow row in Listado.Rows) 
      {
         //foreach (DataColumn columna in Listado.Columns) 
         //{
         	if (col.DataType.Equals(typeof(DateTime)))
         	 {
			//MessageBox.Show (row[col].ToString() );
			ev.Graphics.DrawString(row[col].ToString(), Arial10, Brushes.Black,
                           ejeX -correccionX, ejeY -correccionY) ;
			 }
            	
        	else if (col.DataType.Equals(typeof(Decimal)))
            	{
            		
            		//MessageBox.Show (row[col].ToString() );
            		
            		ev.Graphics.DrawString(row[col].ToString(), Arial10, Brushes.Black,
                           ejeX -correccionX, ejeY -correccionY) ;
            	}
        	else
            	{
            	
            		//MessageBox.Show (row[col].ToString() );
            		
            		ev.Graphics.DrawString(row[col].ToString(), Arial10, Brushes.Black,
                           ejeX -correccionX, ejeY -correccionY) ;
            		
            	}
            	
        	ejeY += 5;
         //}
          ejeX +=  Convert.ToSingle(col.ColumnName.Length) + 10;
    }
  
      }*/



			
			




	
		
		
	}


#endregion


#region FacturasCIva

static DataTable   ObtenerListadoDeFactCIva = new DataTable();	
		
///<summary>
///Imprime el listado de los cheques
///</summary>
		public static  void Imprimir_ListadoDeFactCIva(DataTable ListadoDeFactCIva)
		{
			//Este método contiene dos componentes muy importantes los cuales son:
			//PrintDocument y printDialog estos métodos definen las propiedades de impresión
			//como son: numero de copias, numero de paginas y seleccionar tipo de impresora
			//estas son las variables donde almacenaremos los datos del cliente
	
			
			
			
			//Esto pasa los datos que recibo a la variable estatica general de aca.
			//de esa manera puedo pasar los datos en el 
			ObtenerListadoDeFactCIva  = ListadoDeFactCIva; 
			
			
			
			
			PrintDocument formulario = new PrintDocument();
					
			
			formulario.PrintPage += new PrintPageEventHandler(Datos_ListadoDeFactCIva);// Datos Cliente es el lienzo
			
			
			//Este es el Print Dialog -- El formulario de impresion ;)
			PrintDialog printDialog1 = new PrintDialog();
			printDialog1.Document = formulario;
			printDialog1.PrinterSettings.Copies = 3;// marca que son cuatro copias si no hace nada
			//printDialog1.PrinterSettings.DefaultPageSettings.Landscape = false; //hoja apaizada
			DialogResult result = printDialog1.ShowDialog();
		
			if (result == DialogResult.OK)
			{
			formulario.Print();
			}
		}

		

///<summary>
/// En este metodo se define los datos a imprimir. En este caso una Factura
/// </summary>	
		//private static void Datos_Remito(VariablesPropias.VariablesPropias.vpRemito remit, object obj, PrintPageEventArgs ev)
		private static void Datos_ListadoDeFactCIva(object obj, PrintPageEventArgs ev)
		
		
		{
			
			/*
			 *ev es el encargado de dibujar en el lienzo lo que vamos a imprir 
			 * Drawingstring es el encargado de dibujar el texto con un determinado formato y ponienodolo en las
			 * direcciones de X e Y
			 * Esto es TEXTO, FUENTE, X, Y para ver donde lo deja
			*/
			
#region FUENTES			
		
			//la siguiente variable define el estilo de fuente y tamaño a usar
			//en este caso se utilizo Arial,12
	
			Font Arial24 = new Font("Arial", 24);
			Font Arial12 = new Font("Arial", 12);
			Font Arial10 = new Font("Arial", 10);
			Font Arial08 = new Font("Arial", 8);
			Font Arial06 = new Font("Arial", 6);
			
#endregion			
			
		
#region INFO

			
			//De esta manera se pasa de Twips a Milimetros un bardo encontrarlo pero funca.
			ev.Graphics.PageUnit = GraphicsUnit.Millimeter;
			
			/*
			 * Esto es para controlar el 
			 */
			ev.Graphics.DrawString(".", Arial08, Brushes.Black, 0,0);
#endregion	


			
			DataTable  Listado = new DataTable ();
			

			
			//Asi cargo los datos de la variable general en la que voy a usar aca..
			Listado = ObtenerListadoDeFactCIva ;
			
			//El numero de renglon
			//int y = 0;
			//int intRenglonFacturas = 0;
			
			MessageBox.Show (Listado.Rows.Count.ToString());
			
#region Margenes


			//Tener en cuenta que hay 5mm de altura demas (a restar)			
			//Tener en cuenta que hay 4mm de largo demas
			
			Single correccionX = 4;
			Single correccionY = 5;

#endregion


			

			

				
			
#region	CABECERA
			
			//Tipo de Comprobante
			ev.Graphics.DrawString("LISTADO DE FACTURAS COMPRAS" , Arial12 , Brushes.Black , 
			                       10 -correccionX, 10 -correccionX) ;


			//Fecha
			ev.Graphics.DrawString(DateTime.Today.ToShortDateString(), Arial10, Brushes.Black, 
			                         100 -correccionX, 0 -correccionY) ;
			
			
			
			//Linea
			
			ev.Graphics.DrawLine(Pens.Black,
			                     0 -correccionX, 10 -correccionY,  //inicio  
			                     100 -correccionX, 10 -correccionY); //final ;
#endregion			
			



foreach (DataColumn col in Listado.Columns) 
	{
     //MessageBox.Show (col.Ordinal.ToString());    
	
	ev.Graphics.DrawString(col.ColumnName, Arial10, Brushes.Black,
                            (col.Ordinal * 10) -correccionX, 150 -correccionY) ;
    }
  

      foreach (DataRow row in Listado.Rows) 
      {
         foreach (DataColumn col in Listado.Columns) 
         {
            if (col.DataType.Equals(typeof(DateTime)))
            	MessageBox.Show (row[col].ToString() );
            else if (col.DataType.Equals(typeof(Decimal)))
            	MessageBox.Show (row[col].ToString() );
            else
            	MessageBox.Show (row[col].ToString() );
         }
      }



			
			




	
		
		
	}



#endregion





	}
}