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

//using Trazabilidad.Prueba;

namespace Contable
{
	internal partial class frmRemitos : System.Windows.Forms.Form
	{
		
		public VariablesPropias.VariablesPropias.vpClientes clie;
		public VariablesPropias.VariablesPropias.vpTransporte transp;

		
		
		void FrmRemitosLoad(object sender, EventArgs e)
		{
		//Carga el numero de remito 				
		txtNumRemito.Text = Convert.ToString (OperacionesComunes.ObtenerUltimoRemito());
 		
		//Carga los clientes
        CargarClientesCombo();
        
        //Carga la Fecha Actual
        dtpFecha.Value = DateTime.Today;
            
        //Esto arma una nueva variable propia
        VariablesPropias.VariablesPropias.vpCAIRemito CAIRemito = new VariablesPropias.VariablesPropias.vpCAIRemito();
        
        //Esto carga los datos en la variable propia
        CAIRemito = OperacionesComunes.CargarElCAI(txtNumRemito.Text);
            
        //Estas asignaciones le dan los valores para tener todo lo necesario para cargar el CAI del Remito
    	lblCAI.Text = CAIRemito.strCAI;
    	lblFechaVto.Text = CAIRemito.strFechaVenc;
    	lblCodBarras.Text = CAIRemito.strCodigoACargar;
    	
		//Esto carga la impagen de un codigo de barras interlineado de 2 de 5
    	pictureBox1.Image = CodigoDeBarras.CodigoBarras.Print2of5Interleaved (CAIRemito.strCodigoACargar);
        
		}

		
		
		
		
#region Combo Cliente

/// <summary>
/// Muestra los clientes al operador 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		void CmbRazonSocialDropDown(object sender, EventArgs e)
		{
           //Solo muestra la columna de NOMBRE
			cmbRazonSocial.DisplayMember = "Nombre"; 
		}

/// <summary>
/// Cuando cambia el Combo
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		void CmbRazonSocialSelectedIndexChanged(object sender, EventArgs e)
		{
			//Carga los datos del Cliente
			CargarClientesRemito();
			
			
		}

#endregion		
		
		void FrClienteEnter(object sender, EventArgs e)
		{
			
		}
		



		
#region Controles de la barra superior
	
///<summary>
/// Esta funcion limpia todo el formulario y agrega un numero al valor de los remitos
/// </summary>
		void TlbNuevoClick(object sender, EventArgs e)
		{
		
			//Limpia el formulario
			LimpiarRemito();
			
			//Agrega un numero a los remitos
			txtNumRemito.Text = (Convert.ToInt32(txtNumRemito.Text) + 1).ToString();
			
			//Permite hacer remitos.
				tlbImprimir.Enabled = false;
				tlbGuardar.Enabled = true;
				cmbRazonSocial.Enabled = true;
		}	
	
		void TlbGuardarClick(object sender, EventArgs e)
		{
					
						
			VariablesPropias.VariablesPropias.vpRemito vpRemi = new VariablesPropias.VariablesPropias.vpRemito();
			
			vpRemi = CargarRemito();
			
			OperacionesComunes.Guardar(vpRemi);
			
			//Permite imprimir.
				tlbImprimir.Enabled = true;
				tlbGuardar.Enabled = false;
				cmbRazonSocial.Enabled = false;
                        
		}	
		
		void TlbImprimirClick(object sender, EventArgs e)
		{
			Imprimir.Imprimir_Remito(CargarRemito());
		}
		
		void TlbAnularClick(object sender, EventArgs e)
		{
			
			
			
		}
		

#endregion
		
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		

		
		void GridDatosCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void GridDatosCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
		if (gridDatos.CurrentCell.EditType == typeof(DataGridViewComboBoxEditingControl))
            {
			//gridDatos.CurrentCell.			

			MessageBox.Show ("Caca");
			}	
		}


#region Valor Declarado

		void LblValDecDoubleClick(object sender, EventArgs e)
		{
			// This test that the InputBox can handle more newline than one.
    	InputBox.InputBoxResult test = InputBox.InputBox.Show("Cargar el Valor"); 

    		if( test.ReturnCode == DialogResult.OK )
        			lblValDec.Text = test.Text;
			
			
		}
#endregion		
	


/// <summary>
/// Esta funcion espera que se presione la tecla "Enter" para hacer las cosas
/// </summary>
		void TxtNumRemitoKeyPress(object sender, KeyPressEventArgs e)
		{
			
		
			if (e.KeyChar  == Convert.ToChar(Keys.Enter))
			{
				
				int ultimoremitobtenido = OperacionesComunes.ObtenerUltimoRemito();
				int remitoactual = Convert.ToInt32(txtNumRemito.Text);
				//Esta funcion lo que hace es cargar primero un remito virtual en una Variable Propia que despues pasa como argumento
				//a la funcion de PasarARemito que es la que se encarga de colocar todos los datos en el form.
				
				
				
				//if (ultimoremitobtenido => remitoactual )
				//{
					PasarARemito(Remitos.CargarRemito(remitoactual));
				//}
				
				/*//AFIP
			//Esto arma una nueva variable propia
            VariablesPropias.VariablesPropias.vpCAIRemito CAIRemito = new VariablesPropias.VariablesPropias.vpCAIRemito();
            //Esto carga los datos en la variable propia
            CAIRemito = OperacionesComunes.CargarElCAI(txtNumRemito.Text);
			
			//TODO: HACER YA
			remi.strFechaVto = CAIRemito.strFechaVenc;
			remi.strCAI = CAIRemito.strCAI;
			remi.picCodBarras = this.pictureBox1;
			remi.strFechaImpresion = CAIRemito.strFechaImpresion;
				*/
					
					
					tlbGuardar.Enabled = false;
					tlbAnular.Enabled = true;
					tlbEditar.Enabled = true;
					tlbImprimir.Enabled = true;
			}
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
/// Esta funcion coloca los datos en cada uno de los items del remito
/// Sirve para cuando pasamos datos al remito se puedan cargar facilmente	
/// </summary>		
		public void CargarClientesRemito()
		{
		
		
			//Cargo el cliente a la variable publica
			clie =  OperacionesComunes.ObtenerCliente(cmbRazonSocial.Text);
		
			txtIdCliente.Text = clie.strid;
			lblCUIT.Text = Convert.ToString (clie.dblCUIT);
			lblDireccion.Text  = clie.strDireccion;
			lblLocalidad.Text = clie.strLocalidad;				
			lblProvincia.Text = clie.strProvincia; 
			lblDescuento.Text = Convert.ToString (clie.dblDescuento);
			
			
			//Cargo el transporte a la variable publica
			transp = OperacionesComunes.ObtenerTransporte(Convert.ToString (clie.intTranspId) );
			
			
			cmbTransNombre.Text = transp.strNombre;
			txtTransDireccion.Text = transp.strDireccion; 
			txtTransHorario.Text = transp.strHorario;
		}
		
/// <summary>
/// 
/// </summary>
		public void LimpiarRemito()
		{
			//Cliente
			
			cmbRazonSocial.Text = "";
			lblCUIT.Text = "";
			lblDireccion.Text = "";
			lblLocalidad.Text = "";
			lblProvincia.Text = "";
			lblDescuento.Text = "";
			
			
			//Transporte
			cmbTransNombre.Text = "";
			txtTransDireccion.Text = "";
			txtTransHorario.Text = "";
			
			//Otros
			lblValDec.Text = "";
			lblPesoBruto.Text = "";
			
			//Datos del remito
			gridDatos.RowCount = 1 ; 
		
		}
		
///<summary>
///Carga los datos presentados en una variable propia que tiene todos los datos en forma de estructura
///</summary>
		public VariablesPropias.VariablesPropias.vpRemito CargarRemito()
		{
			VariablesPropias.VariablesPropias.vpRemito remi = new VariablesPropias.VariablesPropias.vpRemito();
			
			CultureInfo cultura = new CultureInfo("es-AR");
			CultureInfo culture = new CultureInfo("en-US");
			
			
			remi.dblNumRemi = Convert.ToDouble(txtNumRemito.Text);
			
			remi.dtFecha = dtpFecha.Value;
			
			//Id del remito es todo el numero del remito
			//TODO: Mejorar esto porque esta mal.
			remi.IDRemito = "0001-0000"+ txtNumRemito.Text ;
			
				
				
			//CLiente
			remi.Cliente.strNombre = this.cmbRazonSocial.Text.ToString();
			remi.Cliente.strid = this.txtIdCliente.Text;
			remi.Cliente.strDireccion = this.lblDireccion.Text;
			remi.Cliente.strLocalidad = this.lblLocalidad.Text;
			remi.Cliente.strProvincia = this.lblProvincia.Text;
			remi.Cliente.dblCUIT = Convert.ToDouble (this.lblCUIT.Text);
			//remi.Cliente.strPosIVA = this
			
								
			//Transporte
			remi.Transporte.strNombre = cmbTransNombre.Text;
			remi.Transporte.strDireccion = txtTransDireccion.Text;
				
			//Producto
			
			//TODO:Aca va un for para el array de productos que tiene el vpRemito
			
				//Producto 1
			remi.Producto1.intCantidad = Convert.ToInt16  (gridDatos[0,0].Value);
			remi.Producto1.strid = gridDatos[1,0].Value.ToString();
			remi.Producto1.strDescripcion = gridDatos[2,0].Value.ToString();
			//Uso el Culture info para pasar un numero con el formato de Argentina para que lo pase como decimal (yanqui)
			//Me falta saber como sacarle directamente el "$" del string de entrada
			remi.Producto1.curPrecioNeto = Convert.ToDecimal (Convert.ToDecimal (gridDatos[3,0].Value.ToString().Replace("$", "").ToString(), cultura));
			remi.Producto2.curPrecioTotal = Convert.ToDecimal (Convert.ToDecimal (gridDatos[4,0].Value.ToString().Replace("$", "").ToString(), cultura));
			
				//Producto 2
			if 	(gridDatos.Rows.Count  > 2)
			{
			remi.Producto2.intCantidad = Convert.ToInt16  (gridDatos[0,1].Value);
			remi.Producto2.strid = gridDatos[1,1].Value.ToString();
			remi.Producto2.strDescripcion = gridDatos[2,1].Value.ToString();
			
			//Uso el Culture info para pasar un numero con el formato de Argentina para que lo pase como decimal (yanqui)
			//Me falta saber como sacarle directamente el "$" del string de entrada
			remi.Producto2.curPrecioNeto = Convert.ToDecimal (gridDatos[3,1].Value.ToString().Replace("$", "").ToString());
			                                                  
            remi.Producto2.curPrecioTotal = Convert.ToDecimal (gridDatos[4,1].Value.ToString().Replace("$", "").ToString());
			}else
			{
			remi.Producto2.intCantidad = 0;
			remi.Producto2.strDescripcion = " ";
			remi.Producto2.curPrecioNeto = 0;
			remi.Producto2.curPrecioTotal = 0;
			}
		
				//Producto 3
			if 	(gridDatos.Rows.Count  > 3)
			{
			remi.Producto3.intCantidad = Convert.ToInt16  (gridDatos[0,2].Value);
			remi.Producto3.strid = gridDatos[1,2].Value.ToString();
			remi.Producto3.strDescripcion = gridDatos[2,2].Value.ToString();
			//Uso el Culture info para pasar un numero con el formato de Argentina para que lo pase como decimal (yanqui)
			//Me falta saber como sacarle directamente el "$" del string de entrada
			remi.Producto3.curPrecioNeto = Convert.ToDecimal (gridDatos[3,2].Value.ToString().Replace("$", "").ToString().ToString(), cultura);
			remi.Producto3.curPrecioTotal = Convert.ToDecimal (gridDatos[4,2].Value.ToString().Replace("$", "").ToString().ToString(), cultura);
			
			}else
			{
			remi.Producto3.intCantidad =0;
			remi.Producto3.strDescripcion = " ";
			remi.Producto3.curPrecioNeto = 0;
			remi.Producto3.curPrecioTotal = 0;
			}

				//Producto 4
			if 	(gridDatos.Rows.Count  > 4)
			{
			remi.Producto4.intCantidad = Convert.ToInt16  (gridDatos[0,3].Value);
			remi.Producto4.strid = gridDatos[1,3].Value.ToString();
			remi.Producto4.strDescripcion = gridDatos[2,3].Value.ToString();
			//Uso el Culture info para pasar un numero con el formato de Argentina para que lo pase como decimal (yanqui)
			//Me falta saber como sacarle directamente el "$" del string de entrada
			remi.Producto4.curPrecioNeto = Convert.ToDecimal (gridDatos[3,3].Value.ToString().Replace("$", "").ToString().ToString(), cultura);
			remi.Producto4.curPrecioTotal = Convert.ToDecimal (gridDatos[4,3].Value.ToString().Replace("$", "").ToString().ToString(), cultura);
			
			}else
			{
			remi.Producto4.intCantidad = 0;
			remi.Producto4.strDescripcion = " ";
			remi.Producto4.curPrecioNeto = 0;
			remi.Producto4.curPrecioTotal = 0;
			}

				//Producto 5
			if 	(gridDatos.Rows.Count  > 5)
			{
			remi.Producto5.intCantidad = Convert.ToInt16  (gridDatos[0,4].Value);
			remi.Producto5.strid = gridDatos[1,4].Value.ToString();
			remi.Producto5.strDescripcion = gridDatos[2,4].Value.ToString();
			//Uso el Culture info para pasar un numero con el formato de Argentina para que lo pase como decimal (yanqui)
			//Me falta saber como sacarle directamente el "$" del string de entrada
			remi.Producto5.curPrecioNeto = Convert.ToDecimal (gridDatos[3,4].Value.ToString().Replace("$", "").ToString().ToString(), cultura);
			remi.Producto5.curPrecioTotal = Convert.ToDecimal (gridDatos[4,4].Value.ToString().Replace("$", "").ToString().ToString(), cultura);
			
			}else
			{
			remi.Producto5.intCantidad = 0;
			remi.Producto5.strDescripcion = " ";
			remi.Producto5.curPrecioNeto = 0;
			remi.Producto5.curPrecioTotal = 0;
			}
			

			
			
			
			
			//Chofer
			remi.strChofer = "Maximiliano Esposito DNI 37.375.313";

			//Valor Declarado
			remi.curTotal = Convert.ToDecimal(lblValDec.Text);
			
			
			
				
			//AFIP
			
			 //Esto arma una nueva variable propia
            VariablesPropias.VariablesPropias.vpCAIRemito CAIRemito = new VariablesPropias.VariablesPropias.vpCAIRemito();
            //Esto carga los datos en la variable propia
            CAIRemito = OperacionesComunes.CargarElCAI(txtNumRemito.Text);
			
			//TODO: HACER YA
			remi.strFechaVto = CAIRemito.strFechaVenc;
			remi.strCAI = CAIRemito.strCAI;
			remi.picCodBarras = this.pictureBox1;
			remi.strFechaImpresion = CAIRemito.strFechaImpresion;
	
			return remi;
			
		}


/// <summary>
/// 
/// </summary>
/// <param name="remi"></param>
		void PasarARemito(VariablesPropias.VariablesPropias.vpRemito remi)
		{
		 dtpFecha.Value = remi.dtFecha;
			
			//Id del remito es todo el numero del remito
			//TODO: Mejorar esto porque esta mal.
			
			//txtNumRemito.Text =  ;
			
				
				
			//CLiente
			cmbRazonSocial.Text = remi.Cliente.strNombre; 
			lblDireccion.Text = remi.Cliente.strDireccion; 
			lblLocalidad.Text = remi.Cliente.strLocalidad;
			lblProvincia.Text = remi.Cliente.strProvincia;
			lblCUIT.Text = remi.Cliente.dblCUIT.ToString();
			txtIdCliente.Text = remi.Cliente.strid;
			
			//Transporte

			cmbTransNombre.Text = remi.Transporte.strNombre;
			txtTransDireccion.Text = remi.Transporte.strDireccion;
			
			//Producto

			//TODO: hay que pasar esto a un array de productos

			gridDatos.RowCount = 1 ; 
			
			
			if  (remi.Producto1.intCantidad > 0)
			{
				
				string[] fila = new string[5]{remi.Producto1.intCantidad.ToString(), 
					remi.Producto1.Trazabilidad.strNumPartida,
					remi.Producto1.strDescripcion, 
					remi.Producto1.curPrecioNeto.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")),
					remi.Producto1.curPrecioTotal.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"))};
				gridDatos.Rows.Add(fila);
			}
			
			if  (remi.Producto2.intCantidad > 0)
			{
				
				string[] fila = new string[5]{remi.Producto2.intCantidad.ToString(), 
					remi.Producto2.Trazabilidad.strNumPartida, 
					remi.Producto2.strDescripcion,
					remi.Producto2.curPrecioNeto.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")),
                    remi.Producto2.curPrecioTotal.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"))};
				gridDatos.Rows.Add(fila);
			}
			
			
			if  (remi.Producto3.intCantidad > 0)
			{
				
				string[] fila = new string[5]{remi.Producto3.intCantidad.ToString(), 
					remi.Producto3.Trazabilidad.strNumPartida,
					remi.Producto3.strDescripcion,
					remi.Producto3.curPrecioNeto.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")),
					remi.Producto3.curPrecioTotal.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"))};
				gridDatos.Rows.Add(fila);
			}
			
			
			if  (remi.Producto4.intCantidad > 0)
			{
				
				string[] fila = new string[5]{remi.Producto4.intCantidad.ToString(), 
					remi.Producto4.Trazabilidad.strNumPartida,
					remi.Producto4.strDescripcion,
					remi.Producto4.curPrecioNeto.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")),
					remi.Producto4.curPrecioTotal.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"))};
				gridDatos.Rows.Add(fila);
			}
			
			if  (remi.Producto5.intCantidad > 0)
			{
				
				string[] fila = new string[5]{remi.Producto5.intCantidad.ToString(), 
					remi.Producto5.Trazabilidad.strNumPartida,
					remi.Producto5.strDescripcion,
					remi.Producto5.curPrecioNeto.ToString("C", CultureInfo.CreateSpecificCulture("es-AR")),
					remi.Producto5.curPrecioTotal.ToString("C", CultureInfo.CreateSpecificCulture("es-AR"))};
				gridDatos.Rows.Add(fila);
			}
			
			//Chofer
			//remi.strChofer = "Maximiliano Esposito DNI 37.375.313";
			
			//Valor Declarado
			lblValDec.Text = remi.curTotal.ToString();
			
			
			/*
			
						
				
			
				
			//AFIP
			remi.strFechaVto = lblFechaVto.Text;
			remi.strCAI = lblCAI.Text;
			remi.picCodBarras = this.pictureBox1;
			
			 */
		}
		
/// <summary>
/// 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		void TlbFacturarClick(object sender, EventArgs e)
		{

			//Crea un nuevo objeto que es el frmDocumentoFiscal
			frmDocumentoFiscal  FacturaNueva = new frmDocumentoFiscal();
			
			VariablesPropias.VariablesPropias.vpRemito Remito = new VariablesPropias.VariablesPropias.vpRemito();
			
			Remito = CargarRemito();
			
			
			FacturaNueva.cmbRazonSocial.Text = Remito.Cliente.strNombre;
			FacturaNueva.CargarClientes();
			
			//FacturaNueva.cmbRazonSocial.SelectedIndexChanged;//object sender, EventArgs e)
			
			FacturaNueva.cmbRemito1.Text = Remito.dblNumRemi.ToString();
			
			FacturaNueva.CargarRemito(Convert.ToInt32(Remito.dblNumRemi));
			
			/*
			string[] producto = new string[3]; //Esto son los productos directamente en cant, traza y Nombbre
			int a = 0; //variable de refuerzo para sacar cada uno de los productos
			double valordeclarado = 0; //Valor declarado del remito.
			
			
			//Cargo todos los datos dentro del nuevo remito
			RemitoNuevo.cmbRazonSocial.Text = gridDatos.CurrentRow.Cells[2].Value.ToString();
			RemitoNuevo.CargarClientesRemito();
			
			double descuento = Convert.ToDouble(OperacionesComunes.ObtenerClieDescuento(RemitoNuevo.txtIdCliente.Text))/100;
						
			
			
			double dblDolar = Convert.ToDouble(OperacionesComunes.ObtenerDolar());
			
			RemitoNuevo.lblDolar.Text = dblDolar.ToString();
			
			
			//Cargar todos los productos
			for (int j = 0; j < 5; j++)
			
			{
				//Datos de cada productos
				for (int i = 0; i < 3; i++)
				{
					producto[i] = gridDatosPedido[i+a, 0].Value.ToString();
				}
				if (producto[0].Length != 0 )
				{
				RemitoNuevo.gridDatos.Rows.Add(producto);
				
				
				
				//aumento en 3 porque cada producto son 3 datos
				a += 3;
				
				//Esta condicion asegura que no se pasen cadenas vacias
				if (producto[1] != "")
				{
					//Esta linea obtiene el valor de la mercaderia incluyendo el descuento.
					double precio = Convert.ToDouble (OperacionesComunes.ObtenerPrecioMercaderia (producto[1]  ));
					
					RemitoNuevo.gridDatos[3,j].Value = (precio  - 
														(precio * descuento)) *
														dblDolar;
					RemitoNuevo.gridDatos[4,j].Value = (Convert.ToDouble (RemitoNuevo.gridDatos[3,j].Value.ToString()) * 
					                                    Convert.ToDouble (RemitoNuevo.gridDatos[0,j].Value.ToString())).ToString();
				
				valordeclarado += Convert.ToDouble (RemitoNuevo.gridDatos[3,j].Value.ToString()) * Convert.ToDouble (RemitoNuevo.gridDatos[0,j].Value.ToString());
				
				}
				
				}
			}
			
			//Al terminar con todo paso el valor declarado			
			RemitoNuevo.lblValDec.Text = valordeclarado.ToString();
			
			
			*/
			//Usando this.MdiParent es como hago que cargue el form child en el general
     		FacturaNueva.MdiParent = this.MdiParent;

     
			
			
			FacturaNueva.Show();
			
				
		
		}
		
	
	}
}
