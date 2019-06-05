/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 09/09/2014
 * Hora: 11:01 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using System.Configuration; 
using ConexionDB; 


namespace Contable.Cheques
{
	/// <summary>
	/// Description of frmCheqOp.
	/// </summary>
	public partial class frmCheqOp : Form
	{
		public frmCheqOp()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmCheqOpLoad(object sender, EventArgs e)
		{
			//dtpDesde.Value = DateTime.Today - DateTime.Today.Day(1);
		}
		
		void TlRefrescarClick(object sender, EventArgs e)
		{
			//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			//Hace la consulta segun criterio
			//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
			ConexionAccess2007.Consultar("Cheque", 
			                             "*", 
			                             "FechaIngreso >= #" + dtpDesde.Value.ToString("MM/dd/yyyy")  + "# AND FechaIngreso <= #" + dtpHasta.Value.ToString("MM/dd/yyyy")  +"#",
			                             "FechaIngreso");


			//Cargo los datos en el grid
			gridDatos.DataSource = ConexionAccess2007.Source;
			 
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
		}
		
		void TlEliminarClick(object sender, EventArgs e)
		{
			
			
			var result = MessageBox.Show("Realmente desea elimiar esta fila. La modificacion será permantente" , "Eliminar",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Exclamation);

		    // If the no button was pressed ...
		    if (result == DialogResult.Yes )
		    {
		     
			    //Conecta a la Base de datos segun ruta guardada
				ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
				
				//Hace la consulta segun criterio
				//Uso el ToString("MM/dd/yyyy") porque es la unica forma que tome los valores como acepta SQL
				ConexionAccess2007.EliminarFila ("Cheque", 
				                             "NumCheque = '" + gridDatos.CurrentRow.Cells[5].Value.ToString() + "' AND Cliente = '" + gridDatos.CurrentRow.Cells[10].Value.ToString()+"'");
				 
				//Desconecto para no tener problemas
				ConexionAccess2007.Desconectar ();		
		    	
		    }
					
			

			
			
			
		}
		
		void TlEditarClick(object sender, EventArgs e)
		{
			
		}
	}
}
