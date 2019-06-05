//using Microsoft.VisualBasic;
//using Microsoft.VisualBasic.Compatibility;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;


using Contable.Modulos;

namespace Contable
	
{
	internal partial class frmFactImpagas : System.Windows.Forms.Form
	{

		
		void TlActualizarClick(object sender, EventArgs e)
		{
		
				decimal FactImp90Peso = 0 ;
				decimal FactImp60Peso= 0 ;
				decimal FactImp30Peso= 0 ;
				decimal FactActivaPeso= 0 ;

				decimal FactImp90Dolar = 0 ;
				decimal FactImp60Dolar = 0 ;
				decimal FactImp30Dolar = 0 ;
				decimal FactActivaDolar = 0 ;
				
				
				int cantFact90 = 0;
				int cantFact60 = 0;
				int cantFact30 = 0;
				int cantFactActiv = 0;

			gridDatos.DataSource = OperacionesComunes.FuenteObtenerFacturasImpagas(DateTime.Today );
			
			gridDatos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells ;
			gridDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells ;
			gridDatos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells ;
			
			//Documento, Fecha, Nombre, ImporteFinal, ImporteFinalUSS", 
			//Pesos
			gridDatos.Columns.Add("colValorPesos",gridDatos.Columns["ImporteFinal"].HeaderText.ToString());
			gridDatos.Columns["colValorPesos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 

			//Dolar
			gridDatos.Columns.Add("colValorDolar",gridDatos.Columns[3].HeaderText.ToString());
			gridDatos.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; 
			
			for (int i = 0; i < gridDatos.Rows.Count -1; i++)
			{
				//Esto puede ser redundate y poray se podria escribir mejor				

				decimal valorPeso= Convert.ToDecimal(gridDatos["ImporteFinal",i].Value);
				decimal valorDolar= Convert.ToDecimal(gridDatos[3,i].Value);
								
				
				
				
				
				//gridDatos[4,i].Value = valorPeso.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));
				//gridDatos[5,i].Value = valorDolar.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));
				
				
				
				
				
				
				
				
				//Esto es para sumar los que estan en cada una de las categorias
				if (Convert.ToDateTime(gridDatos[1,i].Value) <= DateTime.Today.AddDays(-90))
				{
					//Cambiar el color de la fila
					gridDatos.Rows[i].DefaultCellStyle.ForeColor = Color.Violet;
					
					//Sumar los importes de las facturas pendientes
					FactImp90Peso += Convert.ToDecimal(gridDatos["ImporteFinal",i].Value.ToString());
					FactImp90Dolar += Convert.ToDecimal(gridDatos[3,i].Value.ToString());
					
					//Cantidad
					cantFact90 += 1;
					
					
					
				} else if (Convert.ToDateTime(gridDatos[1,i].Value) <= DateTime.Today.AddDays(-60))
				{
					//Cambiar el color de la fila
					gridDatos.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
					
					//Sumar los importes de las facturas pendientes
					//FactImp60Peso += Convert.ToDecimal(gridDatos["ImporteFinal",i].Value.ToString());
					FactImp60Dolar += Convert.ToDecimal(gridDatos[3,i].Value.ToString());
					
					//Cantidad
					cantFact60 += 1;
					
					
				} else if (Convert.ToDateTime(gridDatos[1,i].Value) <= DateTime.Today.AddDays(-30))
				{
					//Cambiar el color de la fila
					gridDatos.Rows[i].DefaultCellStyle.ForeColor = Color.YellowGreen;
					
					//Sumar los importes de las facturas pendientes
					//FactImp30Peso += Convert.ToDecimal(gridDatos["ImporteFinal",i].Value.ToString());
					FactImp30Dolar += Convert.ToDecimal(gridDatos[3,i].Value.ToString());
					
					//Cantidad
					cantFact30 += 1;
					
					
				}else
				{
					//Cambiar el color de la fila
					gridDatos.Rows[i].DefaultCellStyle.ForeColor = Color.Green;

					//Sumar los importes de las facturas pendientes
					FactActivaPeso += Convert.ToDecimal(gridDatos["ImporteFinal",i].Value.ToString());
					FactActivaDolar += Convert.ToDecimal(gridDatos[3,i].Value.ToString());
					
					//Cantidad
					cantFactActiv += 1;
				}


			}
				
				
				
			
			
			gridDatos.Columns.Remove(gridDatos.Columns[6].Name);
			gridDatos.Columns.Remove(gridDatos.Columns[6].Name);//lo hago otra vez poque intento borrar la columna 3 que ahora es nuevamente la 2.
			
			//Importes en pesos
			
			lblFactVencidas90.Text =  FactImp90Peso.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));
			lblFactVencidas60.Text =  FactImp60Peso.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));
			lblFactVencidas30.Text =  FactImp30Peso.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));
			lblFactEnVigencia.Text =  FactActivaPeso.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"));
		
			//Cantidades
			lblNumv90.Text = cantFact90.ToString();
			lblNumv60.Text = cantFact60.ToString();
			lblNumv30.Text = cantFact30.ToString(); 
		}
	}
}
