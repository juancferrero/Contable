/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 22/09/2016
 * Hora: 11:00 a.m.
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
using System.Text.RegularExpressions;
	
using System.Configuration;
using ImprimirEjemplo;

using ConexionDB;
using VariablesPropias;
using CodigoDeBarras;

using Contable.Modulos;

using Contable.InputBox;
using Contable.Facturas;





namespace Contable.Facturas
{
	/// <summary>
	/// Description of frmDocumentoFiscal.
	/// </summary>
	internal partial class frmDocumentoFiscal : System.Windows.Forms.Form // La teneia como public
	{
		
		public VariablesPropias.VariablesPropias.vpFactura miFactura;
		//internal VariablesPropias.VariablesPropias.vpMargenesFact miMargenes;

		//internal VariablesPropias.VariablesPropias.vpRemito miRemito;
		public  VariablesPropias.VariablesPropias.vpClientes clie;
		
		//internal  AFIP.AFIP.vpAFIPTicket miTicket;
		public  AFIP.AFIP.vpAFIPTicket miTicket;
		
		
/// <summary>
/// 
/// </summary>
		public frmDocumentoFiscal()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
				
			
		}
		

		
		void FrmDocumentoFiscalLoad(object sender, EventArgs e)
		{
			//Coloca la Fecha
			dtFecha.Value = DateTime.Today;
				
			
			//Carga los clientes
			CargarClientesCombo();

			
			/*if (cmbRazonSocial.Text == "") {
			//Genera un datasource para pasarlo al combo
            cmbRazonSocial.DataSource = OperacionesComunes.FuenteObtenerClientes();
            //cmbRazonSocial.DisplayMember = "Nombre";
				
			}*/
			
			
#region CONEXION A LA AFIP
			
			//Si esta habilitado para facturar a la AFIP busca el ticket
			if (Convert.ToBoolean (ConfigurationManager.AppSettings["FacturarAFIP"]))
			{
				miTicket = AFIP.AFIP.TicketAccesoAFIP();
			
				lblSign.Text = miTicket.vpAFIPTicketSign;
				lblToken.Text = miTicket.vpAFIPTicketToken;
			}
			
			
			//Carga el numero de Factura 
			//Si esta habilitado para facturar a la AFIP Informa de la factura
			if (Convert.ToBoolean (ConfigurationManager.AppSettings["FacturarAFIP"]))
			{
				txtNumFact.Text = AFIP.AFIP.UltimoComprobante (lblToken.Text, lblSign.Text, 3, Convert.ToInt32 (lblCod_cbe.Text)).ToString();
			}else 
			{
				txtNumFact.Text = Convert.ToString (OperacionesComunes.ObtenerUltimaFactura(3, Convert.ToInt32 (lblCod_cbe.Text)));
			}
			
#endregion
			

/*
			//Carga los datos de mercaderia en la columna de productos
			DataGridViewComboBoxColumn comboboxColumn =new  DataGridViewComboBoxColumn();
			comboboxColumn = gridDatos.Columns["Producto"];
			comboboxColumn.DataSource = OperacionesComunes.FuenteObtenerMercaderia();
    		comboboxColumn.DisplayMember = "Nombre";
    		comboboxColumn.ValueMember = "Nombre";
			*/
			
			
#region DOLAR

			//Obtiene el valor del dolar
			lblDolar.Text = OperacionesComunes.ObtenerDolar();
#endregion		
			
			
			
			
			
		}		
		
		
	
#region Combo de Razon Social

		
		void CmbRazonSocialDropDown(object sender, EventArgs e)
		{
			//Solo muestra la columna de NOMBRE
			cmbRazonSocial.DisplayMember = "Nombre"; 
		}
		
		void CmbRazonSocialSelectedIndexChanged(object sender, EventArgs e)
		{
			//Carga los clientes
			CargarClientes();
			
		}		
		
		void CmbRazonSocialLeave(object sender, EventArgs e)
		{


		//Carga los remitos activos
		//cmbRemito1.DataSource = OperacionesComunes.ObtenerRemitosActivos(lblIDCliente.Text);
		cmbRemito1.Text = "0";
		cmbRemito2.DataSource = OperacionesComunes.ObtenerRemitosActivos(lblIDCliente.Text);
		cmbRemito2.Text = "0";
		cmbRemito3.DataSource = OperacionesComunes.ObtenerRemitosActivos(lblIDCliente.Text);
		cmbRemito3.Text = "0";
		cmbRemito4.DataSource = OperacionesComunes.ObtenerRemitosActivos(lblIDCliente.Text);
		cmbRemito4.Text = "0";
		}

#endregion
		
		
		


		void TlbGuardarClick(object sender, EventArgs e)
		{
			miFactura = CargarFactura();
		
			//Si esta habilitado para facturar a la AFIP Informa de la factura
			if (Convert.ToBoolean (ConfigurationManager.AppSettings["FacturarAFIP"]))
			{
			
			//Crea el objeto de respuesta de la factura
			servicios1.afip.gov.ar.FECAEResponse objFECAEResponse = new servicios1.afip.gov.ar.FECAEResponse();
			objFECAEResponse = AFIP.AFIP.EnviarFacturaAFIP(miFactura, lblToken.Text, lblSign.Text);
			
			lblCAE.Text= objFECAEResponse.FeDetResp[0].CAE;
			lblFechVtoCAE.Text = objFECAEResponse.FeDetResp[0].CAEFchVto;
			
									
			miFactura.strCAE = lblCAE.Text;
			miFactura.strFechVtoCAE = lblFechVtoCAE.Text;
			
			
			
			//Esto asegura de que si no esta aprobado por AFIP no tome ninguna factura
			if (objFECAEResponse.FeDetResp[0].Resultado == "A")
			{OperacionesComunes.Guardar(miFactura);}
			}
			else// Esto deja guardar la FC sin Permiso de la AFIP
			{
				miFactura.strCAE = lblCAE.Text;
				miFactura.strFechVtoCAE = lblFechVtoCAE.Text;
				OperacionesComunes.Guardar(miFactura);
			}

#region Remitos

			if (cmbRemito1.Text != "0")
			{
				
				ModificarUnRemito(Convert.ToInt32(cmbRemito1.Text));
			}
			
			if (cmbRemito2.Text != "0")
			{
				
				ModificarUnRemito(Convert.ToInt32(cmbRemito2.Text));
			}
			
			if (cmbRemito3.Text != "0")
			{
				
				ModificarUnRemito(Convert.ToInt32(cmbRemito3.Text));
			}
			
			if (cmbRemito4.Text != "0")
			{
				
				ModificarUnRemito(Convert.ToInt32(cmbRemito4.Text));
			}

#endregion
			
			
			//Permite imprimir.
				tbImprimir.Enabled = true;
				tlbGuardar.Enabled = false;
				cmbRazonSocial.Enabled = false;
		}	

		void TxtCodBarNumTextChanged(object sender, EventArgs e)
		{
			
			
			
			
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



/// <summary>
/// Carga los datos del Cliente en el ComboBox
/// </summary>
		void CargarClientesCombo()
		{
		//Esto conecta con la base de datos
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
            
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("Clientes", "Nombre", "Nombre","Activo = TRUE");
			            
            
            //Genera un datasource para pasarlo al combo
            cmbRazonSocial.DataSource = ConexionAccess2007.Source;
			
            //Cerrar la conexion
            ConexionAccess2007.Desconectar();
		}
		






		
/// <summary>
/// Carga una Factura desde el formulario actual
/// </summary>
/// <returns>Una Variable propia vpFactura </returns>
		public VariablesPropias.VariablesPropias.vpFactura CargarFactura ()
		{
		
#region Variables
		 VariablesPropias.VariablesPropias.vpFactura Fact= new VariablesPropias.VariablesPropias.vpFactura();

#endregion
			
		//Cabecera			
		Fact.strTipoFc = lblTipoFC.Text;
		Fact.strCodFc = lblCod_cbe.Text;
		Fact.intSucursal = Convert.ToInt16(cmbSucursal.Text);
		Fact.dblNumFact = Convert.ToDouble(txtNumFact.Text);
		Fact.dtFecha = dtFecha.Value ;
		
		Fact.dblTipoCambio = Convert.ToDouble (lblDolar.Text);
		
		switch (Convert.ToInt32 (lblCod_cbe.Text))
            {
                case 1: //Factura A
                    Fact.strComprobante = "FC " + lblTipoFC.Text + " " +cmbSucursal.Text +"-0000"+ txtNumFact.Text;
                    break;
                case 6: //Factura B
                    Fact.strComprobante = "FC " + lblTipoFC.Text + " " +cmbSucursal.Text +"-0000"+ txtNumFact.Text;
                    break;
                    
                case 2: //ND
                    Fact.strComprobante = "ND " + lblTipoFC.Text + " " +cmbSucursal.Text +"-0000"+ txtNumFact.Text;
                    break;

				case 3: //NC
                    Fact.strComprobante = "NC " + lblTipoFC.Text + " " +cmbSucursal.Text +"-0000"+ txtNumFact.Text;
                    break;                    
                    
                    
                    
                //default:
                //	lblCod_cbe.Text
				//	break;
		}
		
		//Cliente
		Fact.Cliente = OperacionesComunes.ObtenerCliente(cmbRazonSocial.Text);	
			
		//Remitos
		Fact.intRemito1 = Convert.ToInt16(cmbRemito1.Text);
		Fact.intRemito2 = Convert.ToInt16(cmbRemito2.Text);
		Fact.intRemito3 = Convert.ToInt16(cmbRemito3.Text);
		Fact.intRemito4 = Convert.ToInt16(cmbRemito4.Text);
		
		
		//Crea el array de los productos directamente segun la cantidad de lineas del grid
		Fact.Productos = new VariablesPropias.VariablesPropias.vpProducto[gridDatos.Rows.Count + 5];
		
		for (int i = 0; i < gridDatos.Rows.Count; i++) {
			 if (gridDatos[2,i].Value != null) {
				Fact.Productos[i].intCantidad = Convert.ToInt16(gridDatos[2,i].Value);
				Fact.Productos[i].strDescripcion = gridDatos[1,i].Value.ToString();
				Fact.Productos[i].curPrecioNeto = Convert.ToDecimal(gridDatos[4,i].Value);
				Fact.Productos[i].curPrecioSubTotal= Convert.ToDecimal(gridDatos[6,i].Value);
				Fact.Productos[i].dblTipoIVA = Convert.ToDouble(gridDatos[7,i].Value);
				Fact.Productos[i].curIVAProdu = Convert.ToDecimal(gridDatos[6,i].Value) 
											* Convert.ToDecimal(gridDatos[7,i].Value)/100;
				Fact.Productos[i].curPrecioTotal =Convert.ToDecimal(gridDatos[8,i].Value);
			}
		}
		
		//Producto
		/*TODO Esto se deber reemplazar con arrays de prductos
		if (gridDatos[2,0].Value != null) {
		Fact.Producto1.intCantidad = Convert.ToInt16(gridDatos[2,0].Value);
		Fact.Producto1.strDescripcion = gridDatos[1,0].Value.ToString();
		Fact.Producto1.curPrecioNeto = Convert.ToDecimal(gridDatos[4,0].Value);
		Fact.Producto1.curPrecioSubTotal= Convert.ToDecimal(gridDatos[6,0].Value);
		Fact.Producto1.dblTipoIVA = Convert.ToDouble(gridDatos[7,0].Value);
		Fact.Producto1.curIVAProdu = Convert.ToDecimal(gridDatos[6,0].Value) 
									* Convert.ToDecimal(gridDatos[7,0].Value)/100;
		Fact.Producto1.curPrecioTotal =Convert.ToDecimal(gridDatos[8,0].Value);
gridDatos[2,i].Value}
		
		if (gridDatos.Rows.Count >= 1 ) {
			if (gridDatos[2,1].Value != null) {
			Fact.Producto2.intCantidad = Convert.ToInt16(gridDatos[2,1].Value);
			Fact.Producto2.strDescripcion = gridDatos[1,1].Value.ToString();
			Fact.Producto2.curPrecioNeto = Convert.ToDecimal(gridDatos[4,1].Value);
			Fact.Producto2.curPrecioSubTotal= Convert.ToDecimal(gridDatos[6,1].Value);
			Fact.Producto2.dblTipoIVA = Convert.ToDouble(gridDatos[7,1].Value);
			Fact.Producto2.curIVAProdu = Convert.ToDecimal(gridDatos[6,1].Value) 
										* Convert.ToDecimal(gridDatos[7,1].Value)/100;
			Fact.Producto2.curPrecioTotal =Convert.ToDecimal(gridDatos[8,1].Value);
			}
		}			
		if (gridDatos.Rows.Count >= 2) {
			if (gridDatos[2,2].Value != null) {
			Fact.Producto3.intCantidad = Convert.ToInt16(gridDatos[2,2].Value);
			Fact.Producto3.strDescripcion = gridDatos[1,2].Value.ToString();
			Fact.Producto3.curPrecioNeto = Convert.ToDecimal(gridDatos[4,2].Value);
			Fact.Producto3.dblTipoIVA = Convert.ToDouble(gridDatos[7,2].Value);
			Fact.Producto3.curIVAProdu = Convert.ToDecimal(gridDatos[6,2].Value) 
										* Convert.ToDecimal(gridDatos[7,2].Value)/100;
			Fact.Producto3.curPrecioTotal =Convert.ToDecimal(gridDatos[8,2].Value);
			}
		}			
		if (gridDatos.Rows.Count >= 3) {
			if (gridDatos[2,3].Value != null) {
			Fact.Producto4.intCantidad = Convert.ToInt16(gridDatos[2,3].Value);
			Fact.Producto4.strDescripcion = gridDatos[1,3].Value.ToString();
			Fact.Producto4.curPrecioNeto = Convert.ToDecimal(gridDatos[4,3].Value);
			Fact.Producto4.dblTipoIVA = Convert.ToDouble(gridDatos[7,3].Value);
			Fact.Producto4.curIVAProdu = Convert.ToDecimal(gridDatos[6,3].Value) 
										* Convert.ToDecimal(gridDatos[7,3].Value)/100;
			Fact.Producto4.curPrecioTotal =Convert.ToDecimal(gridDatos[8,3].Value);
			}
		}			
		*/
		
		//Impuestos
		Fact.curSubTotalUSD =Convert.ToDecimal(Math.Round(Convert.ToDouble(lblSubTotalUSD.Text),2));
		Fact.curIVAUSD = Convert.ToDecimal(Math.Round(Convert.ToDouble(lblIVA21USD.Text),2));
		Fact.curTotalUSD = Convert.ToDecimal(Math.Round(Convert.ToDouble(lblTotalUSD.Text),2));
		
		Fact.curSubTotal =Convert.ToDecimal(Math.Round(Convert.ToDouble( lblSubTotal.Text),2));
		Fact.curIVA = Convert.ToDecimal(Math.Round(Convert.ToDouble( lblIVA21.Text),2));
		
		if (Fact.curIVA == 0) {
			Fact.IdIVA = 3;
		}		else
		{Fact.IdIVA = 5;}
		
		Fact.curTotal = Convert.ToDecimal(Math.Round(Convert.ToDouble( lblTotal.Text),2));
		
		//Valores
		
		Fact.strCAE = lblCAE.Text;
		
		Fact.strFechVtoCAE = lblFechVtoCAE.Text;
		
		Fact.strCodBarrasNum = txtCodBarNum.Text;
		
		Fact.picCodBarras = this.PictureBox1.Image ;
		
return Fact;
		}	

/// <summary>
/// Genera el codigo de barras
/// </summary>
		public void HacerCodigoBarras()
		{


			
			
		//Esto carga la impagen de un codigo de barras interlineado de 2 de 5
		PictureBox1.Image = CodigoDeBarras.CodigoBarras.Print2of5Interleaved (txtCodBarNum.Text);
		}
		
/// <summary>
/// Carga un remito en una variable propia
/// </summary>
/// <param name="numRemito">El numero del remito a cargar</param>
		public void CargarRemito(int numRemito)
		{
		VariablesPropias.VariablesPropias.vpRemito Remito = new VariablesPropias.VariablesPropias.vpRemito();
			
			Remito = Modulos.Remitos.CargarRemito(numRemito);
			
			
			//gridDatos.Rows.Clear();
			
			//TODO manejar los productos como arrays
			//Revisar que no se dupliquen los datos
		
			
			
			
			//Producto 1
			if (Remito.Producto1.intCantidad > 0 )
			{
				gridDatos.Rows.Add();
				gridDatos[1 ,0]. Value  = Remito.Producto1.strDescripcion;
				gridDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				gridDatos[2,0].Value = Remito.Producto1.intCantidad.ToString();
				
			}
			
			
			//Producto 2
			if (Remito.Producto2.intCantidad > 0 )
			{
				gridDatos.Rows.Add();
				gridDatos[1 ,1]. Value  = Remito.Producto2.strDescripcion;
				gridDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				gridDatos[2,1].Value = Remito.Producto2.intCantidad.ToString();
			}
			
			//Producto 3
			if (Remito.Producto3.intCantidad > 0 )
			{
				gridDatos.Rows.Add();
				gridDatos[1 ,2]. Value  = Remito.Producto3.strDescripcion;
				gridDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				gridDatos[2,2].Value = Remito.Producto3.intCantidad.ToString();
				
			}
			
			//Producto 4			
			if (Remito.Producto4.intCantidad > 0 )
			{
				gridDatos.Rows.Add();
				gridDatos[1 ,3]. Value  = Remito.Producto4.strDescripcion;
				gridDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				gridDatos[2,3].Value = Remito.Producto4.intCantidad.ToString();
			}
			
			//Producto 5
			if (Remito.Producto5.intCantidad > 0 )
			{
				gridDatos.Rows.Add();
				gridDatos[1 ,4]. Value  = Remito.Producto5.strDescripcion;
				gridDatos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
				gridDatos[2,4].Value = Remito.Producto5.intCantidad.ToString();
			}
			
			
			ObtenerTotales();
			
			
			
		
		}
				
		
		void CmbRemito1DropDown(object sender, EventArgs e)
			
		{
			cmbRemito1.DataSource = OperacionesComunes.ObtenerRemitosActivos(lblIDCliente.Text);
			
			//Solo muestra la columna de Numero de Remito
			cmbRemito1.DisplayMember = "NumRemito";
		}
		void CmbRemito2DropDown(object sender, EventArgs e)
		{
			//Solo muestra la columna de Numero de Remito
			cmbRemito2.DisplayMember = "NumRemito";
		}
		void CmbRemito3DropDown(object sender, EventArgs e)
		{	
			//Solo muestra la columna de Numero de Remito
			cmbRemito3.DisplayMember = "NumRemito";
		}
		void CmbRemito4DropDown(object sender, EventArgs e)
		{
			//Solo muestra la columna de Numero de Remito
			cmbRemito4.DisplayMember = "NumRemito";
		}
		void CmbRemito1SelectedIndexChanged(object sender, EventArgs e)
		{
			//MessageBox.Show (cmbRemito1.Text);
			
			CargarRemito (Convert.ToInt32(cmbRemito1.Text));
		}
		
		
		void TbImprimirClick(object sender, EventArgs e)
		{
			Imprimir.Imprimir_Factura(CargarFactura());
		}
		
		
		void GridDatosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void GridDatosCellLeave(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		void GridDatosCellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			
			//Si modifica la cantidad
			if (e.ColumnIndex == 2)
			{
				if (gridDatos[4, e.RowIndex].Value != null)
				{
				//Modifico el Subtotal
				gridDatos[6, e.RowIndex].Value = Convert.ToInt32 (gridDatos[2, e.RowIndex].Value) *
												Convert.ToDecimal (gridDatos[4, e.RowIndex].Value);
				}
			}
			
			
			//Modifica el valor unitario
			if (e.ColumnIndex == 4)
			{
					
				if (gridDatos[2, e.RowIndex].Value != null)
				{
					//Modifico el Subtotal
				gridDatos[6, e.RowIndex].Value = Convert.ToInt32 (gridDatos[2, e.RowIndex].Value) *
												Convert.ToDecimal (gridDatos[4, e.RowIndex].Value);
				}
			}
	
			
			if (e.ColumnIndex == 7)
			{
				if (gridDatos[6, e.RowIndex].Value != null)
				{
					//Modifico el Total
				gridDatos[8, e.RowIndex].Value =Convert.ToDecimal (gridDatos[6, e.RowIndex].Value) +  
					(Convert.ToDecimal (gridDatos[6, e.RowIndex].Value) *
					 Convert.ToDecimal (gridDatos[7, e.RowIndex].Value)/100);
				}
				
				
			}
			
			ObtenerTotales();
			
		}
		
		
		
/// <summary>
/// Suma todo para obtener los totales
/// </summary>
		public void ObtenerTotales()
		{
			lblSubTotalUSD.Text = "0";
			lblIVA21USD.Text ="0";
			lblTotalUSD.Text = "0";
			for (int i = 0; i < gridDatos.Rows.Count ; i++) {
				lblSubTotalUSD.Text = (Convert.ToDecimal (lblSubTotalUSD.Text) +
				                     (Convert.ToDecimal (gridDatos[6, i].Value))).ToString();
                lblIVA21USD.Text = (Convert.ToDecimal (lblIVA21USD.Text) +
                              		(Convert.ToDecimal (gridDatos[6, i].Value) *
                                    Convert.ToDecimal (gridDatos[7, i].Value)/100)).ToString();
             	lblTotalUSD.Text = (Convert.ToDecimal (lblTotalUSD.Text)+	
				                     	Convert.ToDecimal (gridDatos[8, i].Value)).ToString();
			}
		
		}
		
		void LblSubTotalUSDTextChanged(object sender, EventArgs e)
		{
			lblSubTotal.Text = (Convert.ToDecimal(lblSubTotalUSD.Text) * Convert.ToDecimal(lblDolar.Text.Replace(".",","))).ToString();
		}
		void LblIVA105USDTextChanged(object sender, EventArgs e)
		{
			lblIVA105.Text = (Convert.ToDecimal(lblIVA105USD.Text) * Convert.ToDecimal(lblDolar.Text.Replace(".",","))).ToString();
		}
		void LblIVA21USDTextChanged(object sender, EventArgs e)
		{
			lblIVA21.Text = (Convert.ToDecimal(lblIVA21USD.Text) * Convert.ToDecimal(lblDolar.Text.Replace(".",","))).ToString();
		}
		void LblIVA27USDTextChanged(object sender, EventArgs e)
		{
			lblIVA27.Text = (Convert.ToDecimal(lblIVA27USD.Text) * Convert.ToDecimal(lblDolar.Text.Replace(".",","))).ToString();
		}
		void LblTotalUSDTextChanged(object sender, EventArgs e)
		{
			lblTotal.Text = (Convert.ToDecimal(lblTotalUSD.Text) * Convert.ToDecimal(lblDolar.Text.Replace(".",","))).ToString();
		}
		void LblCAEDoubleClick(object sender, EventArgs e)
		{
			lblCAE.Text = InputBox.InputBox.Show("Ingrese el CAE").Text ;
		}
		void LblFechVtoCAEDoubleClick(object sender, EventArgs e)
		{
			lblFechVtoCAE.Text = InputBox.InputBox.Show("Ingrese la Fecha de Vencimiento del CAE").Text ;
		}
		void LblDolarDoubleClick(object sender, EventArgs e)
		{
			lblDolar.Text = InputBox.InputBox.Show("Ingrese el nuevo dolar").Text ;
		}
		void LblCAETextChanged(object sender, EventArgs e)
		{
			
			
			ObtenerNumCodBarras();
		}

		
/// <summary>
/// Genera el codigo de barras
/// </summary>
		public void ObtenerNumCodBarras ()
		{
			txtCodBarNum.Text = "30708466200" + lblCod_cbe.Text +cmbSucursal.Text +lblCAE.Text + lblFechVtoCAE.Text;
			txtCodBarNum.Text += CodigoDeBarras.CodigoBarras.CodVerificador(txtCodBarNum.Text).ToString();;
			HacerCodigoBarras();
		}
		
		void LblFechVtoCAETextChanged(object sender, EventArgs e)
		{
			
			
			
			ObtenerNumCodBarras();
		}
		
		
/// <summary>
/// Modifica un remito para cargarle la factura
/// </summary>
/// <param name="numRemito"></param>
		public void ModificarUnRemito(int numRemito)
		{
		//Conecta a la Base de datos segun ruta guardada
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());										

			
			try // para obtener errores posibles
			 {
			//Edito la tabla de los cheques
			
				ConexionAccess2007.ModificarFila("Remitos",
			                                 "SucFactura = " + Convert.ToInt32(cmbSucursal.Text).ToString()  + ", NumFactura = " + txtNumFact.Text,
			                                 "NumRemito = " + numRemito.ToString()) ;
			

			
				
				
			}
            catch (Exception ex)
			{
				MessageBox.Show (ex.Message , "Error");
			}
			
			//Cerrar la conexion
            ConexionAccess2007.Desconectar();
		}
		
		
		
		
		
		
		
		
		
		
	}
}
