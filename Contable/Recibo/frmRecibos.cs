
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
	internal partial class frmReciboAltas : System.Windows.Forms.Form
	{
		/*
		 * Esta variable se usa para manejar los clientes
		 */
		public VariablesPropias.VariablesPropias.vpClientes clie;
		
			
		
///<summary>Cuando inicia el Form</summary>
		void FrmReciboAltasLoad(object sender, EventArgs e)
		{
			
			//Coloca la Fecha
			dtFecha.Value = DateTime.Today;
				
			
			//Obtiene el último recibo hecho y le suma uno.
			txtNumRecibo.Text = Modulos.Recibos.ObtenerUltimoRecibo().ToString();
			
			
			//Genera un datasource para pasarlo al combo
            cmbRazonSocial.DataSource = OperacionesComunes.FuenteObtenerClientes();
            cmbRazonSocial.DisplayMember = "Nombre";
		}


		
		void CmbRazonSocialDropDown(object sender, EventArgs e)
		{
			
            //Solo muestra la columna de NOMBRE
			cmbRazonSocial.DisplayMember = "Nombre"; 

            
		}
		
		void CmbRazonSocialSelectedIndexChanged(object sender, EventArgs e)
		{
			//Carga los clientes
			CargarClientes();
			
			//Esta condicion asegura de que no se cargue con valor ""
			if (cmbRazonSocial.Text != "") {
			
				ObtenerFacturasPendientes(cmbRazonSocial.Text);
				
				ObtenerNDPendientes(cmbRazonSocial.Text);	
				
				ObtenerNCPendientes(cmbRazonSocial.Text);	
				
				ObtenerInterdepPendientes(cmbRazonSocial.Text);	//TODO: Hacer esto por el ID del cliente
				
					
				ObtenerChequesPendientes(lblIDCliente.Text);
				
				
			
				//Utilizo una funcion para cargar los importes
				lblCobranzaTotal.Text = ObtenerCredito().ToString();
				
				
				//Utilizo una funcion para cargar los importes
				lblSubTotal.Text = ObtenerDeuda().ToString();
				}
			
		}

/// <summary>
/// Esta funcion coloca los datos en cada uno de los items del recibo
/// </summary>		
		public void CargarClientes()
		{
		
		
			//Cargo el cliente a la variable publica
			clie =  OperacionesComunes.ObtenerCliente(cmbRazonSocial.Text);
		
			lblIDCliente.Text = clie.strid;
			lblCUIT.Text = Convert.ToString (clie.dblCUIT);
			lblDireccion.Text  = clie.strDireccion;
			lblLocalidad.Text = clie.strLocalidad;				
			lblProvincia.Text = clie.strProvincia; 
		
		}	
		
//TODO: La busqueda debe ser por IDCliente
///<summary>
///Obtiene las facturas pendientes del cliente
///</summary>
/// <param name="NombreCliente">El nombre del cliente</param>
public void ObtenerFacturasPendientes(string NombreCliente)
{
	//Conectar a la base de datos		
	ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
			
	//Hace la consulta asumiendo que el cliente esta activo FC A
	ConexionAccess2007.Consultar("Facturas", "Documento, Fecha, Saldo, ImporteFinal, ImporteFinalUSS", "Nombre ='"+ NombreCliente +"' AND Saldo <> '0'" ,"NumFact");
			
	gridFact.DataSource = ConexionAccess2007.Source;
	
	//Cerrar la conexion
    ConexionAccess2007.Desconectar();
    
	//Hace la consulta asumiendo que el cliente esta activo FC B
	ConexionAccess2007.Consultar("FacturasB", "Documento, Fecha, Saldo, ImporteFinal, ImporteFinalUSS", "Nombre ='"+ NombreCliente +"' AND Saldo <> '0'" ,"NumFact");
			
	gridFactB.DataSource = ConexionAccess2007.Source;
	
	//Cerrar la conexion
    ConexionAccess2007.Desconectar();	
}


//TODO: La busqueda debe ser por IDCliente
/// <summary>
/// Obtiene las Notas de debito pendientes de un cliente.
/// </summary>
/// <param name="NombreCliente">El nombre del cliente</param>
public void ObtenerNDPendientes(string NombreCliente)
{
	//Conectar a la base de datos		
	ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
			
	//Hace la consulta asumiendo que el cliente esta activo
	ConexionAccess2007.Consultar("NotaDebito", "Documento, Fecha, Saldo, ImporteFinal, ImporteFinalUSS", "Nombre ='"+ NombreCliente +"' AND Saldo <> '0'" ,"NumFact");
			
	gridND.DataSource = ConexionAccess2007.Source;
	
	
	//Cerrar la conexion
    ConexionAccess2007.Desconectar();	
}


//TODO: La busqueda debe ser por IDCliente
/// <summary>
/// Obtiene las Notas de Credito pendientes de un cliente.
/// </summary>
/// <param name="NombreCliente"></param>
public void ObtenerNCPendientes(string NombreCliente)
{
	//Conectar a la base de datos		
	ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
			
	//Hace la consulta asumiendo que el cliente esta activo
	ConexionAccess2007.Consultar("NotaCredito", "Documento, Fecha, Saldo, ImporteFinal, ImporteFinalUSS", "Nombre ='"+ NombreCliente +"' AND Saldo <> '0'" ,"NumFact");
			
	gridNC.DataSource = ConexionAccess2007.Source;
	
	
	//Cerrar la conexion
    ConexionAccess2007.Desconectar();	
}


//TODO: La busqueda debe ser por IDCliente
/// <summary>
/// Obtiene las Notas de debito pendientes de un cliente.
/// </summary>
/// <param name="NombreCliente">El nombre del cliente</param>
public void ObtenerInterdepPendientes(string NombreCliente)
{
	//Conectar a la base de datos		
	ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
			
	//Hace la consulta asumiendo que el cliente esta activo
	ConexionAccess2007.Consultar("Interdepositos", "*", "Cliente ='"+ NombreCliente +"'" ,"FechaPago");
			
	gridInterdeposito.DataSource = ConexionAccess2007.Source;
	
	
	//Cerrar la conexion
    ConexionAccess2007.Desconectar();	
}


///<summary>
///Obtiene los cheques pendientes del cliente
///</summary>
/// <param name="IDCliente">El nombre del cliente</param>
public void ObtenerChequesPendientes(string IDCliente)
{
	//Conectar a la base de datos		
	ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseCheques"]));
	
	//MessageBox.Show(Convert.ToString (ConfigurationManager.AppSettings["BaseCheques"]));
	
	//Hace la consulta asumiendo que el cliente esta activo
	ConexionAccess2007.Consultar("Cheque", "IDCheque, FechaEmision, FechaPago, FechaIngreso, Importe, ImporteUSD", "IDCliente ='"+ IDCliente +"' AND FechaDeposito IS NULL AND IDRecibo IS NULL","FechaPago"); //AND FechaDeposito = ## 
			
	gridCheque.DataSource = ConexionAccess2007.Source;

	


	
	//Cerrar la conexion
    ConexionAccess2007.Desconectar();	
}

/// <summary>
/// Obtiene el valor final de la deuda del cliente
/// </summary>
/// <returns>decimal con la deuda</returns>
public decimal ObtenerDeuda()
{
	//Control de deuda
	decimal  deuda = 0;
	
	int filafinal = 0;
	
#region Facturas 

	//Para las Facturas
	filafinal = Convert.ToInt32(gridFact.Rows.Count);
	
	for (int i = 0; i < filafinal; i++) {
		//Carga la deuda a la variable
		deuda += Convert.ToDecimal(gridFact["ImporteFinal",i].Value);
		}
	
	//Para las FacturasB
	filafinal = Convert.ToInt32(gridFactB.Rows.Count);
	
	for (int i = 0; i < filafinal; i++) {
		//Carga la deuda a la variable
		deuda += Convert.ToDecimal(gridFactB["ImporteFinal",i].Value);
		}
	
	
#endregion	


#region ND
	//Para las Notas de Debito
	filafinal = Convert.ToInt32(gridND.Rows.Count);
	
	for (int i = 0; i < filafinal; i++)
	{
		
	deuda += Convert.ToDecimal(gridND["ImporteFinal",i].Value);
	}
	
#endregion	
	
	return deuda;

}


/// <summary>
/// Obtiene los documentos a favor del cliente
/// </summary>
/// <returns>decimal con el credito</returns>
public  decimal ObtenerCredito()
{

	//Control de deuda
	decimal  credito = 0;
	
	int filafinal = 0;
	
#region Cheques 

	//Para los Cheques
	filafinal = Convert.ToInt32(gridCheque.Rows.Count);
	
	for (int i = 0; i < filafinal; i++) {
		
		credito += Convert.ToDecimal(gridCheque["Importe",i].Value);
		
	}
#endregion	


#region NC
	//Para las Notas de Credito
	filafinal = Convert.ToInt32(gridNC.Rows.Count);
	
	for (int i = 0; i < filafinal; i++)
	{
	
	if (gridNC["Saldo",i].Value != null ) {
	credito += Convert.ToDecimal(gridNC["Saldo",i].Value);	
	}		
	
	}
	
#endregion	
	
#region Intedep
	
	//Para las Transferencias
	filafinal = Convert.ToInt32(gridInterdeposito.Rows.Count);
	
	for (int i = 0; i < filafinal; i++)
	{
		
	credito += Convert.ToDecimal(gridInterdeposito["Importe",i].Value);
	}
	
#endregion	

	
	
//lblLaSumaDe.Text = Conversor.ConversorPrincipal(Convert.ToDouble(credito));
	return credito;
	
}



#region FilasQuitadas
		void GridFactRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			//Recalcula los valores de deuda
			lblSubTotal.Text= ObtenerDeuda().ToString();
			lblDiferenciaTotal.Text = (ObtenerCredito()-ObtenerDeuda()).ToString();
		}
		void GridNDRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			//Recalcula los valores de deuda
			lblSubTotal.Text= ObtenerDeuda().ToString();
			lblDiferenciaTotal.Text = (ObtenerCredito()-ObtenerDeuda()).ToString();
		}
		void GridChequeRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			//Recalcula los valores de credito
			lblCobranzaTotal.Text= ObtenerCredito().ToString();
			lblDiferenciaTotal.Text = (ObtenerCredito()-ObtenerDeuda()).ToString();
		}
		void GridInterdepositoRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			//Recalcula los valores de credito
			lblCobranzaTotal.Text= ObtenerCredito().ToString();
			lblDiferenciaTotal.Text = (ObtenerCredito()-ObtenerDeuda()).ToString();
		}
		void GridNCRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			//Recalcula los valores de credito
			lblCobranzaTotal.Text= ObtenerCredito().ToString();
			lblDiferenciaTotal.Text = (ObtenerCredito()-ObtenerDeuda()).ToString();
		}
#endregion
		
		
		
///<summary>
///Carga los datos presentados en una variable propia que tiene todos los datos en forma de estructura
///</summary>
		public VariablesPropias.VariablesPropias.vpRecibo CargarRecibo()
		{

#region Variables
			VariablesPropias.VariablesPropias.vpRecibo reci = new VariablesPropias.VariablesPropias.vpRecibo();
			
			CultureInfo cultura = new CultureInfo("es-AR");
			CultureInfo culture = new CultureInfo("en-US");
			



#endregion


#region Cabecera
			
			//Numero de recibo
			reci.dblNumReci = Convert.ToDouble(txtNumRecibo.Text);
			//Fecha
			reci.dtFecha = dtFecha.Value;
			
			//Cliente
			reci.Cliente.strNombre = cmbRazonSocial.Text;
			reci.Cliente.strDireccion = lblDireccion.Text;
			reci.Cliente.strLocalidad = lblLocalidad.Text;
			reci.Cliente.strProvincia = lblProvincia.Text;
			reci.Cliente.strid = lblIDCliente.Text;
			
#endregion

#region En Letras
			//En letras
			reci.strEnLetras = lblLaSumaDe.Text;
#endregion


#region Cheques, Interdepositos, NCs


//CHEQUES
			//Condicion para saber que hay CHEQUES a cargar
			if (gridCheque.Rows.Count > 1) {
				
			//De esta manera inicializo el array de los cheques
			reci.Cheques = new VariablesPropias.VariablesPropias.vpCheque[gridCheque.Rows.Count-1];
			
			//Cargo cada uno de los Cheques en el Array de Cheques
			for (int i = 0; i < gridCheque.Rows.Count-1; i++) {
				//Uso el substring para sacar el numero del cheque
				reci.Cheques[i].strIDCheque = gridCheque["IdCheque", i].Value.ToString();
				reci.Cheques[i].dblNumCheque = Convert.ToDouble(gridCheque["IdCheque", i].Value.ToString().Substring(10,8));
				reci.Cheques[i].strBanco = OperacionesComunes.ObtenerBanco(gridCheque["IdCheque", i].Value.ToString().Substring(0,3));
				reci.Cheques[i].dtFechaEmision = Convert.ToDateTime ( gridCheque["FechaEmision", i].Value.ToString());
				reci.Cheques[i].dtFechaEmision = Convert.ToDateTime ( gridCheque["FechaPago", i].Value.ToString());
				reci.Cheques[i].curImporte = Convert.ToDecimal (gridCheque["Importe", i].Value.ToString());
				reci.Cheques[i].strIDCliente = lblIDCliente.Text; 
			}
			
			}


//INTERDEPOSITOS			
			//Condicion para saber que hay INTERDEPOSITOS a cargar
			if (gridInterdeposito.Rows.Count > 1) 
			{
				
			//De esta manera inicializo el array de los Interdepositos
			reci.Interdepositos = new VariablesPropias.VariablesPropias.vpInterdeposito[gridInterdeposito.Rows.Count-1];
			
			//Cargo cada uno de los Cheques en el Array de Interdepositos
			for (int i = 0; i < gridInterdeposito.Rows.Count-1; i++)
				{
				reci.Interdepositos[i].dblIDInterdeposito = Convert.ToDouble(gridInterdeposito["ID", i].Value);
				reci.Interdepositos[i].dblNumInterdeposito = Convert.ToDouble(gridInterdeposito["ID", i].Value);
				reci.Interdepositos[i].strBanco = gridInterdeposito["Banco", i].Value.ToString();
				//reci.Interdepositos[i].dtFechaEmision = Convert.ToDateTime(gridInterdeposito["Fecha", i].Value.ToString());
				reci.Interdepositos[i].dtFechaPago = Convert.ToDateTime(gridInterdeposito["FechaPago", i].Value.ToString());
				reci.Interdepositos[i].curImporte = Convert.ToDecimal(gridInterdeposito["Importe", i].Value.ToString());
				}
			
			
			}

			
//NCs
			//Condicion para saber que hay NC a cargar
			if (gridNC.Rows.Count > 1) 
			{
			
			//De esta manera inicializo el array de las Notas de credito
			reci.NCs = new VariablesPropias.VariablesPropias.vpFactura[gridNC.Rows.Count - 1];
			
			//Cargo cada uno de los Cheques en el Array de Notas de Credito
			for (int i = 0; i < gridNC.Rows.Count-1; i++)
				{
				reci.NCs[i].strComprobante = gridNC["Documento", i].Value.ToString();
				reci.NCs[i].dtFecha = Convert.ToDateTime(gridNC["Fecha", i].Value.ToString());
				reci.NCs[i].curTotal = Convert.ToDecimal(gridNC["ImporteFinal", i].Value.ToString());;
				}
			}
			


#endregion

			
#region Facturas y NDs

//FACTURAS
			//Condicion para saber que hay FACTURAS a cargar
			if (gridFact.Rows.Count > 1) 
			{
				
				
			//De esta manera inicializo el array de Facturas
			reci.Facturas = new VariablesPropias.VariablesPropias.vpFactura[gridFact.Rows.Count - 1];
			
			//Cargo cada uno de los Cheques en el Array de Facturas
			for (int i = 0; i < gridFact.Rows.Count-1; i++)
				{
				reci.Facturas[i].dblNumFact = Convert.ToDouble (gridFact["Documento", i].Value.ToString().Substring(10,8));
				reci.Facturas[i].strComprobante = gridFact["Documento", i].Value.ToString();
				reci.Facturas[i].dtFecha = Convert.ToDateTime(gridFact["Fecha", i].Value.ToString());
				reci.Facturas[i].curTotal = Convert.ToDecimal(gridFact["ImporteFinal", i].Value.ToString());
				//reci.Facturas[i].curTotalUSD = Convert.ToDecimal(gridFact["ImporteFinalUSS", i].Value.ToString());
				}
			}
			
			if (gridFactB.Rows.Count > 1) 
			{
				
			//De esta manera inicializo el array de Facturas B
			reci.FacturasB = new VariablesPropias.VariablesPropias.vpFactura[gridFactB.Rows.Count - 1];
			
			//Cargo cada uno de las Facturas B en el Array de Facturas B
			for (int i = 0; i < gridFactB.Rows.Count-1; i++) 
				{
				reci.FacturasB[i].dblNumFact = Convert.ToDouble (gridFactB["Documento", i].Value.ToString().Substring(10,8));
				reci.FacturasB[i].strComprobante = gridFactB["Documento", i].Value.ToString();
				reci.FacturasB[i].dtFecha = Convert.ToDateTime(gridFactB["Fecha", i].Value.ToString());
				reci.FacturasB[i].curTotal = Convert.ToDecimal(gridFactB["ImporteFinal", i].Value.ToString());
				//reci.FacturasB[i].curTotalUSD = Convert.ToDecimal(gridFactB["ImporteFinalUSS", i].Value.ToString());
				}
			}
			
//NDs			
			//Condicion para saber que hay NDs a cargar
			if (gridND.Rows.Count > 1) 
			{
				
			//De esta manera inicializo el array de Notas de Debito
			reci.NDs = new VariablesPropias.VariablesPropias.vpFactura[gridND.Rows.Count - 1];
			
			//Cargo cada uno de las Notas de Debitos en el Array de Notas de Debitos
			for (int i = 0; i < gridND.Rows.Count-1; i++) 
				{
				//reci.Facturas[i].dblNumFact = Convert.ToDouble (gridFact["Documento", i].Value.ToString());
				reci.NDs[i].strComprobante = gridND["Documento", i].Value.ToString();
				reci.NDs[i].dtFecha = Convert.ToDateTime(gridND["Fecha", i].Value.ToString());
				reci.NDs[i].curTotal = Convert.ToDecimal(gridND["ImporteFinal", i].Value.ToString());
				//reci.Facturas[i].curTotalUSD = Convert.ToDecimal(gridFact["ImporteFinalUSS", i].Value.ToString());
				}
			}
						
			
			
#endregion
			
			
#region EFECTIVO

			//carga el valor del efectivo
			reci.curEfectivo = Convert.ToDecimal(txtEfectivo.Text) ;

#endregion


#region IMPUESTOS Y VARIOS


reci.curSubTotal = Convert.ToDecimal(lblSubTotal.Text);
reci.curDescuento = Convert.ToDecimal(txtDescuento.Text);
reci.curRetenciones =  Convert.ToDecimal(txtRetenciones.Text);
reci.curNO = Convert.ToDecimal(txtNO.Text);
reci.curVarios = Convert.ToDecimal(txtVarios.Text);

//TODO: VER EL TEMA DE LAS RETENCIONES EN UN GRID
//RETENCIONES
reci.curCargasSoc = Convert.ToDecimal(txtRetenCargasSoc.Text);
reci.curGanancias = Convert.ToDecimal(txtRetenGanancias.Text);
reci.curIngBrutos = Convert.ToDecimal(txtRetenIIB.Text);
reci.curIVA = Convert.ToDecimal(txtRetenIVA.Text);


#endregion
			
			
			return reci;
		}



/// <summary>
/// Imprime un recibo
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		void TbImprimirClick(object sender, EventArgs e)
		{
		//Funcion que lo que hace es imprimir el objeto VpReci
			Imprimir.Imprimir_Recibo(CargarRecibo());
		}
		
	
/// <summary>
/// Guarda un Recibo
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		void TlbGuardarClick(object sender, EventArgs e)
		{
			//Funcion que lo que hace es guardar el objeto VpReci
			OperacionesComunes.Guardar(CargarRecibo());
		}
		
		
		
#region RETENCIONES

		void TxtRetenIIBTextChanged(object sender, EventArgs e)
		{
			txtRetenciones.Text = (Convert.ToDecimal(txtRetenIVA.Text) + 
			                       Convert.ToDecimal(txtRetenIIB.Text) +
			                       Convert.ToDecimal(txtRetenGanancias.Text) +
			                       Convert.ToDecimal(txtRetenCargasSoc.Text)).ToString();
			                       
		}
		void TxtRetenIVATextChanged(object sender, EventArgs e)
		{
			txtRetenciones.Text = (Convert.ToDecimal(txtRetenIVA.Text) + 
			                       Convert.ToDecimal(txtRetenIIB.Text) +
			                       Convert.ToDecimal(txtRetenGanancias.Text) +
			                       Convert.ToDecimal(txtRetenCargasSoc.Text)).ToString();
		}
		void TxtRetenGananciasTextChanged(object sender, EventArgs e)
		{
			txtRetenciones.Text = (Convert.ToDecimal(txtRetenIVA.Text) + 
			                       Convert.ToDecimal(txtRetenIIB.Text) +
			                       Convert.ToDecimal(txtRetenGanancias.Text) +
			                       Convert.ToDecimal(txtRetenCargasSoc.Text)).ToString();
		}
		void TxtRetenCargasSocTextChanged(object sender, EventArgs e)
		{
			txtRetenciones.Text = (Convert.ToDecimal(txtRetenIVA.Text) + 
			                       Convert.ToDecimal(txtRetenIIB.Text) +
			                       Convert.ToDecimal(txtRetenGanancias.Text) +
			                       Convert.ToDecimal(txtRetenCargasSoc.Text)).ToString();
		}
	
#endregion


	}
}
