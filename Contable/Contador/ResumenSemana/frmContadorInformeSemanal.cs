//using Microsoft.VisualBasic;
//using Microsoft.VisualBasic.Compatibility;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using System.Configuration; 

using ConexionDB;
using Contable.Modulos;


namespace Contable
{
	internal partial class frmContadorInformeSemanal : System.Windows.Forms.Form
	{
	
	public decimal decEfectivo;
	
	public decimal deChequesRecibidos;
	
	public decimal decFactImpagas;
	public decimal decFactHechas;
	public decimal decChequesEnCartera;
	
		
	
		
		void TlActualizarClick(object sender, EventArgs e)
		{
			#region EFECTIVO
			gridEfectivo.DataSource =	OperacionesComunes.FuenteObtenerEfectivo(calCalendario.SelectionStart.Date,calCalendario.SelectionEnd.Date);
			
			//Cuento cuanto hay
			for (int i = 0; i < gridEfectivo.RowCount ; i++) {
				
				decEfectivo += Convert.ToDecimal ( gridEfectivo["Efectivo", i].Value);
			}
			
			txtEfectivo.Text =  string.Format("{0:N2}", decEfectivo);
			decEfectivo = 0;
			
			#endregion
			
			//CHEQUES RECIBIDOS
			gridChequesRecibidos.DataSource = OperacionesComunes.FuenteObtenerChequesRecibidos (calCalendario.SelectionStart.Date,calCalendario.SelectionEnd.Date); 
			//Cuento cuanto hay
			for (int i = 0; i < gridEfectivo.RowCount ; i++) {
				
				deChequesRecibidos += Convert.ToDecimal ( gridChequesRecibidos["Importe", i].Value);
			}
			
			txtChequesRecibidos.Text =  string.Format("{0:N2}", deChequesRecibidos);
			deChequesRecibidos = 0;
			
			
			//INTERDEPOSITOS RECIBIDOS
			gridInterdepositosRecibidos.DataSource = OperacionesComunes.FuenteObtenerInterdepositosRecibidos(calCalendario.SelectionStart.Date,calCalendario.SelectionEnd.Date);
			
			
			
			
			//Cheques Depositados
			gridChequesDepEnFecha.DataSource = OperacionesComunes.FuenteObtenerChequesDepositados (calCalendario.SelectionStart.Date,calCalendario.SelectionEnd.Date);
			
			 
			
			
			//Busco que facturas se hicieron
			gridFactHechas.DataSource = OperacionesComunes.FuenteObtenerFacturasHechas(calCalendario.SelectionStart.Date,calCalendario.SelectionEnd.Date);
			
			//Cuento cuanto hay
			for (int i = 0; i < gridFactHechas.RowCount ; i++) {
				
				decFactHechas += Convert.ToDecimal ( gridFactHechas["ImporteFinal", i].Value);
			}
			
			txtFactHechas.Text =  string.Format("{0:N2}", decFactHechas);
			decFactHechas = 0; //Esto hace que no se acumulen los valores
			
			
			//Busco las facturas impagas
			gridFactImpagas.DataSource = OperacionesComunes.FuenteObtenerFacturasImpagas (calCalendario.SelectionStart.Date);
			
			//Cuento cuanto hay
			for (int i = 0; i < gridFactImpagas.RowCount ; i++) {
				decFactImpagas += Convert.ToDecimal ( gridFactImpagas["ImporteFinal", i].Value);
			}
			
			txtFactImpagas.Text =  string.Format("{0:N2}", decFactImpagas);
			decFactImpagas = 0; //Esto hace que no se acumulen los valores
			
			
			
			
			gridRecibos.DataSource = OperacionesComunes.FuenteObtenerRecibosHechos (calCalendario.SelectionStart.Date,calCalendario.SelectionEnd.Date);
			
			
			
			#region Cheques en Cartera
			gridChequesXCobrar.DataSource = OperacionesComunes.FuenteChequesEnCarteraNew();
			
			//Cuento cuanto hay
			for (int i = 0; i < gridChequesXCobrar.RowCount ; i++) {
				
				decChequesEnCartera += Convert.ToDecimal ( gridChequesXCobrar["Importe", i].Value);
			}
			txtChequesCartera.Text ="";
			txtChequesCartera.Text =  string.Format("{0:N2}", decChequesEnCartera);
			decChequesEnCartera = 0; //Esto hace que no se acumulen los valores
			
			
			#endregion
			
			
			MessageBox.Show (Convert.ToString (calCalendario.SelectionStart.Date) , "Fecha Inicio");
			MessageBox.Show (Convert.ToString(calCalendario.SelectionEnd.Date), "Fecha de Fin");
		}
		
		void FrmContadorInformeSemanalLoad(object sender, EventArgs e)
		{
			/*
			 * De esta manera es como logro que abra directamente en el Tab 9
			 */
			SSTab1.SelectedIndex = 9;
		}
		
	}
}
