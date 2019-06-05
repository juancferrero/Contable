/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 02/07/2014
 * Hora: 01:56 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using System.Configuration;
using ConexionDB;
using Contable.Modulos;

using Contable.SENASA.Opercaciones;

namespace Contable.SENASA
{
	/// <summary>
	/// Description of BaseDatosTraza.
	/// </summary>
	public partial class frmBaseDatosTraza : System.Windows.Forms.Form
	{
		public frmBaseDatosTraza()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
		}
		
		void BaseDatosTrazaLoad(object sender, EventArgs e)
		{
			
		}
		
		
		
		
		
		
		
		
		
		void CmbDescripcionDropDown(object sender, EventArgs e)
		{
			//usa los datos guardados de donde esta la base de datos para no tener que copiar siempre lo mismo
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseTrazabilidad"]));
			
			//Esta es una consulta sencilla de la tabla y el producto identificado por su lote, de aca sacamos cuantas unidades hay
			ConexionAccess2007.Consultar("Mercaderia", "Nombre","Activo = TRUE" , "Nombre");
			
			cmbDescripcion.DataSource  = ConexionAccess2007.Source;
			
			cmbDescripcion.DisplayMember = "Nombre";
			
			ConexionAccess2007.Desconectar();
		}
		
		
		
		
		
		void CmbClienteDropDown(object sender, EventArgs e)
		{
			//usa los datos guardados de donde esta la base de datos para no tener que copiar siempre lo mismo
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
			
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("Clientes", "Nombre","Activo = TRUE", "Nombre");
			
			cmbCliente.DataSource  = ConexionAccess2007.Source;
			
			cmbCliente.DisplayMember = "Nombre";
			
			ConexionAccess2007.Desconectar();
		}
		
		void CmbClienteDropDownClosed(object sender, EventArgs e)
		{
			//usa los datos guardados de donde esta la base de datos para no tener que copiar siempre lo mismo
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
			
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("Clientes", "Nombre, ID, CUIT, GLN" ,"Nombre = '" + cmbCliente.Text +"'", "Nombre");
			
			lblCUIT.Text = Convert.ToString (ConexionAccess2007.Table.Rows[0].ItemArray[2]);
			lblIDCliente.Text = Convert.ToString (ConexionAccess2007.Table.Rows[0].ItemArray[1]);
			txtGLNDestino.Text = Convert.ToString (ConexionAccess2007.Table.Rows[0].ItemArray[3]);
			ConexionAccess2007.Desconectar();	
		}
		
		
		
		void TlNuevosClick(object sender, EventArgs e)
		{
			
		}
		
		void ToolStripButton2Click(object sender, EventArgs e)
		{
			//usa los datos guardados de donde esta la base de datos para no tener que copiar siempre lo mismo
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseTrazabilidad"]));
			
			
			//Esta es una consulta sencilla de la tabla y el producto identificado por su lote, de aca sacamos cuantas unidades hay
			ConexionDB.OperacionesTrazabilidad.ModificarCajas (cmbDescripcion.Text, Convert.ToInt32(txtCantxcaja.Text), txtLote.Text );
			
			
			ConexionAccess2007.Desconectar();
		}
		

		
		void TlAgregarMercaderiaClick(object sender, EventArgs e)
		{
			
		}
		
		void CmbClienteSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		
		
		
		
		void TlEditarClick(object sender, EventArgs e)
		{
			//usa los datos guardados de donde esta la base de datos para no tener que copiar siempre lo mismo
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseTrazabilidad"]));
			
			
			
			//Este for recorre todos los numeros de serie para que modifique la tabla de trazabilidad
			for (int n = Convert.ToInt32 (txtSerieInicio.Text); n <= Convert.ToInt32 (txtSerieFinal.Text ); n++)
			{
			
				//Esta es una consulta sencilla de la tabla y el producto identificado por su lote, de aca sacamos cuantas unidades hay
				ConexionAccess2007.ModificarFila ("Traza2014",
				                                  "FechaEgreso = '" + dtFechaEgreso.Value.ToShortDateString() + "'" + 
				                                  ", IDCliente = '" +  lblIDCliente.Text + "'" +
				                                  ", CUIT = '" +  lblCUIT.Text + "'" +
				                                  ", GLNDestino ='" + txtGLNDestino.Text  + "'" + 
				                                  ", Remito ='" + txtNroRemito.Text + "'" +
				                                  ", Factura ='" + txtNroFactura.Text  + "'", 
				                                  "Descripcion = '"+ cmbDescripcion.Text  + "' AND Serie = '" +  n + "'AND Lote = '"+ txtLote.Text  + "'");
			
			}
			
			MessageBox.Show ("Mase de datos modificada", "Edicion");
			
			//Desconectar de la base de datos
			ConexionAccess2007.Desconectar();
		}
		void DtFechaEgresoValueChanged(object sender, EventArgs e)
		{
	
		}
		void BtnConsultarClick(object sender, EventArgs e)
		{
			
			gridStock.DataSource = Contable.Modulos.OperacionesTrazabilidad.FuenteObtenerStockTrazabilidad();
			
			
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			//usa los datos guardados de donde esta la base de datos para no tener que copiar siempre lo mismo
			//ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseTrazabilidad"]));
			
			
			
			for (int i = 0; i < gridStock.Rows.Count ; i++) {
			
				
				//MessageBox.Show (gridStock[1,i].Value.ToString());
				if (gridStock[1,i].Value == DBNull.Value  )  
				{
				
					//MessageBox.Show ("Hola");
					Modulos.OperacionesTrazabilidad.ModificarStockTrazabilidad(gridStock[41,i].Value.ToString());
				}
			}

			 
			//Desconecto para no tener problemas
			ConexionAccess2007.Desconectar ();
			
			
		}
		void BtnQuitarDuplicadoClick(object sender, EventArgs e)
		{
	
			for (int i = 0; i < gridStock.Rows.Count -1 ; i++) {
			
			//MessageBox.Show (gridStock[1,i].Value.ToString());
			if (gridStock[1,i].Value.ToString() == gridStock[1,i+1].Value.ToString()  )
				{
				
					//MessageBox.Show (gridStock[1,i].Value.ToString());
					Modulos.OperacionesTrazabilidad.Eliminar(gridStock[41,i+1].Value.ToString());
				}
			
			}
		}
	}
}
