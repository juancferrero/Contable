using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Globalization;

using ConexionDB;

using VariablesPropias;

using Contable.Modulos;


namespace Contable
{
	internal partial class frmContadorFactConIVA : System.Windows.Forms.Form
	{
		
	//	ConfigurationSettings.AppSettings.Keys.

	

	#region Funciones internas

/// <summary>
/// Carga todos los datos dentro de una variable propia para manejarlos despues
/// </summary>
/// <returns>Retorna una estructura de comprobante de gastos</returns>
		VariablesPropias.VariablesPropias.vpComprobanteGastos  CargarDatos()
		{
			VariablesPropias.VariablesPropias.vpComprobanteGastos  Datos = new VariablesPropias.VariablesPropias.vpComprobanteGastos();
			/*
			 * "Entrada, Fecha, RazonSoc, Cuit, NumFact, ImpBruto, IVA105, IVA21, " +
				"IVA27, IngBrutos, PercIVA, NoGravados, ImpNeto, TipoFact, Concepto, Cuenta, SubCuenta, Items"
			*/
			
			Datos.dtEntrada = dtFechaIngreso.Value; 
			Datos.dtFecha= dtFecha.Value;
			Datos.Proveedor = ObtenerProveedor(txtCUIT.Text);
			Datos.strNumFact = txtNroFact.Text;
			Datos.curImpBruto = Convert.ToDecimal(OperacionesComunes.ConvertirAMoneda(txtImpBruto.Text),CultureInfo.InvariantCulture);
			Datos.curIva105 = Convert.ToDecimal (OperacionesComunes.ConvertirAMoneda(txtIVA105.Text),CultureInfo.InvariantCulture);
			Datos.curIva21 = Convert.ToDecimal(OperacionesComunes.ConvertirAMoneda(txtIVA21.Text),CultureInfo.InvariantCulture);
			Datos.curIva27 =Convert.ToDecimal (OperacionesComunes.ConvertirAMoneda(txtIVA27.Text),CultureInfo.InvariantCulture);
			Datos.curIngBrutos= Convert.ToDecimal (OperacionesComunes.ConvertirAMoneda(txtIngBrutos.Text),CultureInfo.InvariantCulture);
			Datos.curPercIva = Convert.ToDecimal(OperacionesComunes.ConvertirAMoneda(txtPercIva.Text),CultureInfo.InvariantCulture);
			Datos.curNoGravados = Convert.ToDecimal(OperacionesComunes.ConvertirAMoneda(txtNoGravados.Text),CultureInfo.InvariantCulture);
			Datos.curImpNeto = Convert.ToDecimal(OperacionesComunes.ConvertirAMoneda(txtImpNeto.Text),CultureInfo.InvariantCulture);
			Datos.strTipoFact = cmbTipoFC.Text;
			
			
			
			
			return Datos; 
		}

		
/// <summary>
/// Obtiene los datos del proveedor
/// </summary>
/// <param name="strCUIT">El CUIT como string</param>
/// <returns>Retorna una estructura del tipo proveedor</returns>
		public VariablesPropias.VariablesPropias.vpProveedores ObtenerProveedor (string strCUIT)
		{
			
			VariablesPropias.VariablesPropias.vpProveedores  Proveed = new VariablesPropias.VariablesPropias.vpProveedores();
				
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
			ConexionAccess2007.Consultar("Proveedores", "ID, Nombre, CUIT, Direccion, Localidad, Provincia, Concepto, Cuenta, SubCuenta, Items, CuentaCredito, CuentaDebito", "CUIT = '" + strCUIT + "'" , "Nombre");
				
			
			
			//Todo esto carga los datos del proveedor en los distintos labels
				
			
			//Fin de la carga de los proveedor
			
			Proveed.Nombre = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[1]);
			Proveed.Cuit = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[2]); //CUIT
			Proveed.Direccion = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[3]) ;//Direccion
			Proveed.Localidad = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[4]) ;//Localidad
			Proveed.Provincia = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[5]) ;//Provincia
			Proveed.Concepto = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[6]) ;//Concepto
			Proveed.Cuenta = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[7]) ;//Cuenta
			Proveed.Subcuenta = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[8]) ;//Sub Cuenta
			Proveed.Items  = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[9]) ;//Item

			//Cierro la conexion para que no quede abierta
			ConexionAccess2007.Desconectar();
			
			//Retorno el valor de la funcion.	
			return Proveed;
			
			
		}

		
/// <summary>
/// Limpia todos los controloes para iniciar otra carga
/// </summary>
		void LimpiarTodo()
		{
			
			//Datos del cliente
			txtCUIT.Text = "";
			lblRazSoc.Text ="";
			lblDireccion.Text ="";
			lblLocalidad.Text ="";
			lblProvincia.Text ="";
			lblCuenta.Text ="";
			lblConcepto.Text ="";
			lblSubCuenta.Text ="";
			lblItem.Text ="";	
		
			//Datos de la Factura
			txtNroFact.Text ="";
			
			//Datos del Importe
			txtImpBruto.Text ="0";
			txtImpNeto.Text ="0";
		
			//Percepciones	
			txtIngBrutos.Text ="0";
			txtNoGravados.Text ="0";
			txtPercIva.Text ="0";
				
			//IVA
			txtIVA105.Text ="0";
			txtIVA21.Text ="0";
			txtIVA27.Text ="0";
				
		
		}

		
/// <summary>
/// Carga todos los datos dentro de una variable propia para manejarlos despues
/// </summary>
/// <returns>Retorna una estructura de comprobante de gastos</returns>
		public void  CargarDesdeDatos(VariablesPropias.VariablesPropias.vpComprobanteGastos Datos)
		{
			
			/*
			 * "Entrada, Fecha, RazonSoc, Cuit, NumFact, ImpBruto, IVA105, IVA21, " +
				"IVA27, IngBrutos, PercIVA, NoGravados, ImpNeto, TipoFact, Concepto, Cuenta, SubCuenta, Items"
			*/
			
			lblID.Text = Datos.ID.ToString();
			
			//Datos del cliente
			txtCUIT.Text = Datos.Proveedor.Cuit;
			Datos.Proveedor = ObtenerProveedor(txtCUIT.Text);
			lblRazSoc.Text = Datos.Proveedor.Nombre;
			lblDireccion.Text = Datos.Proveedor.Direccion;
			lblLocalidad.Text = Datos.Proveedor.Localidad;
			lblProvincia.Text = Datos.Proveedor.Provincia;
			lblCuenta.Text = Datos.Proveedor.Cuenta;
			lblConcepto.Text = Datos.Proveedor.Concepto;
			lblSubCuenta.Text = Datos.Proveedor.Subcuenta;
			lblItem.Text = Datos.Proveedor.Items;	
		
			//Datos de la Factura
			
			dtFechaIngreso.Value = Datos.dtEntrada; 
			dtFecha.Value = Datos.dtFecha;
			
			txtNroFact.Text = Datos.strNumFact;
			cmbTipoFC.Text = Datos.strTipoFact ;
			
			
			//Datos del Importe
			txtImpBruto.Text = Datos.curImpBruto.ToString() ;
			txtImpNeto.Text = Datos.curImpNeto.ToString() ;
		
			//Percepciones	
			txtIngBrutos.Text = Datos.curIngBrutos.ToString();
			txtNoGravados.Text = Datos.curNoGravados.ToString();
			txtPercIva.Text = Datos.curPercIva.ToString();
				
			//IVA
			txtIVA105.Text = Datos.curIva105.ToString();
			txtIVA21.Text = Datos.curIva21.ToString();
			txtIVA27.Text = Datos.curIva27.ToString();
			
			
			
			
			
			
			
			
			
			
			
			
			
		}
		
		
		
		
		#endregion

	#region TAB 1 

/// <summary>
/// Esta funcion espera que se presione la tecla "Enter" para hacer las cosas
/// </summary>		
		void TxtCUITKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar  == Convert.ToChar(Keys.Enter))
			{

				//Esta funcion conecta con la base de datos a trabajar
				ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));  
				
				
				//Realizo la consulta
				ConexionAccess2007.Consultar("Proveedores", "ID, Nombre, CUIT, Direccion, Localidad, Provincia, Concepto, Cuenta, SubCuenta, Items, CuentaCredito, CuentaDebito", "CUIT = '" +txtCUIT.Text  + "'" , "Nombre");
				
								
				//Corroborar que el proveedor exista
				if (ConexionAccess2007.Table.Rows.Count == 1) {
					// Todo esto carga los datos del proveedor en los distintos labels
					lblRazSoc.Text = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[1]);
					lblDireccion.Text = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[3]) ;//Direccion
					lblLocalidad.Text = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[4]) ;//Localidad
					lblProvincia.Text = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[5]) ;//Provincia
					lblConcepto.Text = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[6]) ;//Concepto
					lblCuenta.Text = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[7]) ;//Cuenta
					lblSubCuenta.Text = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[8]) ;//Sub Cuenta
					lblItem.Text = Convert.ToString(ConexionAccess2007.Table.Rows[0].ItemArray[9]) ;//Item
					//Fin de la carga de los proveedor
				}
				
				
				//Cierro la conexion para que no quede abierta
				ConexionAccess2007.Desconectar();
			}
		}
		

#endregion

	#region Comandos del menu
	
	
	void TlbNuevoClick(object sender, EventArgs e)
		{
		//Invoca la funcion	
		LimpiarTodo();
		}

	void TlbGuardarClick(object sender, EventArgs e)
			{
		
				//Esto hace referencia a una funcion sobrecargada que toma los datos y los guarda directamente en la base de datos
				//Todas las cuestiones de guardar seran en funciones sobrecargadas de esta manera			
				Modulos.OperacionesComunes.Guardar(CargarDatos());
				
			}

	#endregion
		
	#region Resumen mensual
void CmdActualizarClick(object sender, EventArgs e)
		{
	
		}
		
		
#endregion	
	
		void FrmContadorFactConIVALoad(object sender, EventArgs e)
		{
			
			//Aca deberia informar que base de datos esta usando en la barra inferior del striptool del Main Form
			//MainForm juanqui = new MainForm();
}
		
 /*			//UNDONE:Ver aca
 TENGO QUE HACER QUE TOME EL VALOR DEL IMPORTE INICIAL PARA VER DESDE DONDE PARTE PARA SACAR LOS IMPUESTOS
* 

	*/
		void GridImpuestosRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			//Esto carga el valor del importe bruto en cada una de las nuevas filas del grid
			gridImpuestos[1, gridImpuestos.CurrentRow.Index].Value  = txtImpBruto.Text ;
		}
		void GridImpuestosCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		void GridImpuestosCellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			/*if( gridImpuestos[2,gridImpuestos.CurrentRow()].IsInEditMode )
			{
			MessageBox.Show("hola mundo");
			
			}*/
	
			if (gridImpuestos.CurrentCell.EditType == typeof(DataGridViewComboBoxEditingControl))
            {
			//gridDatos.CurrentCell.			

			MessageBox.Show ("Caca");
			}	
		}
		
	
	}
}