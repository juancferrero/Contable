
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using System.Configuration;
using ConexionDB;
using Contable.Modulos;
using System.Globalization;

namespace Contable.Cheques 
{
	internal partial class frmCheqListado : System.Windows.Forms.Form
	{

		void FrmCheqListadoLoad(object sender, EventArgs e)
		{
			
		}		
		
		void TsRefrescarClick(object sender, EventArgs e)
		{
			//Dimensiono la variable cliente de donde sacaré el nombre para trabajar
			VariablesPropias.VariablesPropias.vpClientes Cliente = new VariablesPropias.VariablesPropias.vpClientes();
			
			
			//Cargo el Grid con los datos
			gridDatos.DataSource = OperacionesComunes.FuenteChequesEnCarteraNew();
			//gridDatos.DataSource = OperacionesComunes.FuenteChequesEnCartera();
		
						
			
			//Formateo de columnas
			gridDatos.Columns["Importe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			gridDatos.Columns["IDCheque"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			gridDatos.Columns["IDCliente"].HeaderText = "Cliente";
			gridDatos.Columns["IDCheque"].HeaderText = "Nro Cheque";
			
			
			
			
			//Este FOR es para remplazar cosas en el grid
			for (int i = 0; i < gridDatos.Rows.Count - 1; i++) {
				//Cargo el cliente en la variable
				Cliente = OperacionesComunes.ObtenerCliente (Convert.ToInt32(gridDatos["IDCliente",i].Value.ToString()));
				
				//Reemplazo el valor del IDCliente por su nombre
				gridDatos["IDCliente",i].Value = Cliente.strNombre;
				
				//Recorta para dejar solo el Nro de cheques
				gridDatos["IDCheque",i].Value = gridDatos["IDCheque",i].Value.ToString().Substring(10,8);
			
				//Convierto el Valor de un Importe en Decimal
				//decimal Importe = Convert.ToDecimal (gridDatos["Importe",i].Value.ToString());
				//Convierto el decimal en un string
				//string strImporte = Importe.ToString("C");
				
				//Modifico el importe para que quede como un Currency
				//gridDatos["Importe",i].Value = strImporte;// .ToString("C"); //Importe;
				
				
			
			}
			
			//AutoResize
			gridDatos.AutoResizeColumns();
			
			
		}

		void TsImprimirClick(object sender, EventArgs e)
		{
		
			//DataTable Tabla = dtGridWtoDataTable.CambiarADatatable(gridDatos);
			
			//Funcion para imprimir un listado de cheques
			//ImprimirEjemplo.Imprimir.Imprimir_ListadoDeCheques( OperacionesComunes.TablaChequesEnCarteraNew());
			ImprimirEjemplo.Imprimir.Imprimir_ListadoDeCheques(dtGridWtoDataTable.CambiarADatatable(gridDatos));
		}
		
		
		
		
	}
}
