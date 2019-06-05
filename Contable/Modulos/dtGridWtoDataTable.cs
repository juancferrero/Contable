/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 31/05/2019
 * Hora: 11:14 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;


using System.Configuration;

using ConexionDB;
using Contable;
using VariablesPropias;

namespace Contable.Modulos
{
	/// <summary>
	/// Description of dtGridWtoDataTable.
	/// </summary>
	public class dtGridWtoDataTable
	{
		public dtGridWtoDataTable()
		{
		}
		
		
		public static DataTable CambiarADatatable (DataGridView dataGridView2)
		{
			//Crea un DataTable
			DataTable dt = new DataTable();
		
			//For para recorrer las columnas
			for (int i = 0; i < dataGridView2.Columns.Count; i++) 
			{
				
				//Creo la columna en el DataTable
				dt.Columns.Add(dataGridView2.Columns[i].HeaderText , dataGridView2.Columns[i].CellType);
			
				//For de cada fila
				foreach (DataGridViewRow rowGrid in dataGridView2.Rows)
				{
			   		DataRow row = dt.NewRow();
			   		row[i] = rowGrid.Cells[0]; 
			   
			   		dt.Rows.Add(row);
				}
			}
		
		 

		
		
		//Devuelve el Datatable del dtGridView
		return dt;
		}
	}
}
