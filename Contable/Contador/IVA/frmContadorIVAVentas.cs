/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 24/05/2019
 * Hora: 06:47 p.m.
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

using VariablesPropias;
using ConexionDB; 
using System.Configuration;
using Contable.Modulos;
using Contable.ConversorNumALetra;


using ImprimirEjemplo;





namespace Contable
{
	internal partial class frmContadorIVAVentas : System.Windows.Forms.Form
	{
		void TsRefrescarClick(object sender, EventArgs e)
		{
			dtGridFacturas.DataSource = OperacionesComunes.FuenteObtenerFacturasImputadas(CalFechaInicio.SelectionStart , CalFechaFin.SelectionStart);
			
			
			decimal Subtotal = 0;
			decimal IVA = 0;
			decimal Total = 0;
			
		for (int i = 0; i < dtGridFacturas.Rows.Count -1; i++) {
				
				Total += Convert.ToDecimal( dtGridFacturas["ImporteFinal", i].Value);
				IVA += Convert.ToDecimal( dtGridFacturas["Iva", i].Value);
				Subtotal += Convert.ToDecimal( dtGridFacturas["SubTotal", i].Value);
				
				
				
		}
			
			
			lblSubTotal.Text = Subtotal.ToString("C"); //"C" formato Currency
			lblIVA.Text = IVA.ToString("C");
			lblTotal.Text = Total.ToString("C");
			
			
			
		}
			
			
			
			
		}
	}

