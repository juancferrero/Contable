/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 22/05/2015
 * Hora: 10:41 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using System.Collections;

using ConexionDB;
using System.Configuration; 

//SENASA
using Contable.SENASA.Opercaciones;
using Contable.servicios.pami.org.ar;


using Contable.InputBox;



using VariablesPropias;
using Contable.Modulos;

namespace Contable.SENASA
{
	/// <summary>
	/// Description of frmInformarTraza.
	/// </summary>
	public partial class frmInformarTraza : Form
	{
		
		public VariablesPropias.VariablesPropias.vpClientes clie;
		
		public frmInformarTraza()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// Añadir un constructor luego de la llamada del InitializeComponent()
			//j
		}
		

		void FrmInformarTrazaLoad(object sender, EventArgs e)
		{
		
			//Carga el Stock total en el grid para elegir que enviar
			gridStock.DataSource = Contable.Modulos.OperacionesTrazabilidad.FuenteObtenerStockTrazabilidad();
			
			
			//Esto copia los cabezales en la de enviar
			for (int i = 0; i < gridStock.Columns.Count ; i++) 
			{
				gridInformar.Columns.Add(gridStock.Columns[i].HeaderText,gridStock.Columns[i].HeaderText);
			}
			
		}
		
#region Cliente

		void CmbRazonSocialDropDown(object sender, EventArgs e)
		{
		//usa los datos guardados de donde esta la base de datos para no tener que copiar siempre lo mismo
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
			
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("Clientes", "Nombre","Activo = TRUE", "Nombre");
			
			cmbRazonSocial.DataSource  = ConexionAccess2007.Source;
			
			cmbRazonSocial.DisplayMember = "Nombre";
			
			ConexionAccess2007.Desconectar();
		}
		
		void CmbRazonSocialSelectedIndexChanged(object sender, EventArgs e)
		{
			CargarDatosClientes();
		}
#endregion

		
		
		
		void TlbGuardarClick(object sender, EventArgs e)
		{
			
		
			
			//Operaciones.vpTransaccionSENASA datosOperacion = new Operaciones.vpTransaccionSENASA();
			
			transaccionSenasaDTO[] parametros = new transaccionSenasaDTO[100];
			
			string[] filaimportar = new string[gridInformar.Columns.Count];
				
			for (int i = 0; i < gridInformar.Rows.Count; i++) 
			{ 
				//carga los datos en la 
				for (int b = 0; b < gridInformar.Columns.Count; b++) 
				{
					filaimportar[b] = gridInformar.Rows[i].Cells[b].Value.ToString();
				}
				
				parametros[i].cod_producto = filaimportar[9].ToString();
			}
			
			
			
			
/*

	
 			//Esto carga los datos de la operacion al array de transacciones de SENASA.
			//Para formar un array completo con mas de una operacion lo que hacemos es ponerlo en un For que cuente los productos que vamos a enviar
			//De esa manera le agregamos un Integer con el numero del producto a agregar. Con esto igualamos el valor al del FOR y estamos listos
			for (int i = 0; i < 5; i++) 
			{
				//Informacion inicial
				int valEvento = Operaciones.valorCombo(cmbEvento.Text);
				
				datosOperacion.id_evento  = valEvento ;
				datosOperacion.n_remito = "0001-00007949"; //txtNumFact.Text;
				datosOperacion.f_operacion = "08/10/2014"; //dtFecha.Text; //.ToString("dd/MM/yyyy");
				
				//PRODUCTO
				datosOperacion.n_cantidad = 1;
				datosOperacion.cod_producto = "7798195770015"; //GTIN debe de venir de un text
				datosOperacion.f_elaboracion = "04/08/2014"; //Reemplazar por un text
				datosOperacion.f_vto = "04/08/2016"; //Reemplazar por un text
				datosOperacion.n_lote = "5001407002"; //Reemplazar por el lote de un text
					
		
				datosOperacion.gln_origen = "7798195770008"; //Sacarlo de la informacion del programa
	            datosOperacion.gln_destino = "7798198590009";  //NC
				
				

/*				if (valEvento == 11) //VENTA ENVIO
	            {
	            	datosOperacion.gln_origen = "7798195770008";
	                datosOperacion.gln_destino = "3692581473693";  
	            }
	            else
	            {
	                if (valEvento == 12) //RECEPCIÓN DE COMPRA
	                {
	                    datosOperacion.gln_origen = "3692581473693";
	                    datosOperacion.gln_destino = "7798195770008";
	                }
	            }
*/				
	
	
//				parametros[i] = Operaciones.ObtenerParametros(datosOperacion)[0];
			//}
			
			
			
		//	Operaciones.EnviarDatosSENASA("7798195770008", "Ferrero9", parametros);
		}

		
		
		void TlbImprimirClick(object sender, EventArgs e)
		{
			
		
			
			
		}
		
		
	
		
		
		/// <summary>
/// Esta funcion coloca los datos en cada uno de los items del remito
/// Sirve para cuando pasamos datos al remito se puedan cargar facilmente	
/// </summary>		
		public void CargarDatosClientes()
		{
		
		
			///Cargo el cliente a la variable publica
			clie =  OperacionesComunes.ObtenerCliente(cmbRazonSocial.Text);
		
			txtIdCliente.Text = clie.strid;
			lblCUIT.Text = Convert.ToString (clie.dblCUIT);
			lblDireccion.Text  = clie.strDireccion;
			lblLocalidad.Text = clie.strLocalidad;				
			lblProvincia.Text = clie.strProvincia; 
			lblDescuento.Text = Convert.ToString (clie.dblDescuento);
			
			lblGLN.Text = clie.GLN;
			
			
		}
		
		void GridInformarCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		
		
		void CmdFiltrarClick(object sender, EventArgs e)
		{
			if (txtFiltroGTIN.Text != "") //Filtro del GTIN 
			{
				MessageBox.Show("filtado");
			}
		}
		
		void CmdPasarClick(object sender, EventArgs e)
		{
			//Crea una variable DataGridViewRow 
			DataGridViewRow fila = new DataGridViewRow();
			
			string[] filaimportar = new string[gridStock.Columns.Count];
			
			
			
			for (int i = 0; i < gridStock.SelectedRows.Count; i++) 
			{ 
				/*string intCantidad = gridStock[7,gridStock.SelectedRows[i].Index].Value.ToString();
				
				if ( intCantidad == "1")
				{
					fila = gridStock.Rows[gridStock.SelectedRows[i].Index];	
				} else 
				{
					fila = gridStock.Rows[gridStock.SelectedRows[i].Index];	
					MessageBox.Show ( fila.Cells[7].Value.ToString());
				}*/
				
				fila = gridStock.Rows[gridStock.SelectedRows[i].Index];	
				
				for (int b = 0; b < gridStock.Columns.Count; b++) {
					filaimportar[b] = gridStock.Rows[gridStock.SelectedRows[i].Index].Cells[b].Value.ToString();
				}
				
				gridInformar.Rows.Add(  filaimportar );
			}
			
		}
		
		
		
		
		}
	}

