using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using System.Configuration;
using ConexionDB;
using Contable.Modulos;

//using 

namespace Contable
{
	internal partial class frmClientes : System.Windows.Forms.Form
	{
		
		
		
#region Barra de tareas
		void TlbGuardarClick(object sender, EventArgs e)	
		{
			
			//Guarda un nuevo cliente
			OperacionesComunes.Guardar(FormAVariable());
		}
		
		void TlbEditarClick(object sender, EventArgs e)
		{

			//Envia a editar un cliente
			OperacionesComunes.Editar(FormAVariable());
		}		
		
#endregion
		
	
	
#region Grid

		void GridDataCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
			MessageBox.Show (Convert.ToString(gridData.CurrentCell.Value)  , "Caca");
			
			
			
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
			
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("Clientes", "Nombre", "Nombre", txtCriterio.Text ,"Nombre");
			
			
			
			
			//Cerrar la conexion
            ConexionAccess2007.Desconectar();	
			
			
		}

		void GridDataCellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
			//Creo una variable propia 
			VariablesPropias.VariablesPropias.vpClientes vpcliente = new VariablesPropias.VariablesPropias.vpClientes ();
				
			// La lleno con los datos del cliente
			vpcliente = Modulos.OperacionesComunes.ObtenerCliente(gridData.CurrentCell.Value.ToString());
			
			
			/*
			 Cargar los datos obtenidos en la pantalla
			 */
			txtNumClie.Text = vpcliente.strid; 
			txtRazonSocial.Text = vpcliente.strNombre;
			cmbProvincia.Text = vpcliente.strProvincia;
			cmbLocalidad.Text = vpcliente.strLocalidad;
			txtDireccion.Text = vpcliente.strDireccion;
			txtCodPos.Text = vpcliente.strCodPos;
			txtCUIT.Text = vpcliente.dblCUIT.ToString();
			txtTelefono1.Text = vpcliente.strTelefono1;
			txtTelefono2.Text = vpcliente.strTelefono2;
			txtFax.Text = vpcliente.strTelefono3;
			txtDesc.Text = vpcliente.dblDescuento.ToString();
			txtEMail.Text = vpcliente.stremail;
			
			//Notas
			richNotas.Text = vpcliente.memoVarios.ToString();
			
			//Contactos TODO VER COMO USAR EL TAMAÑO DEL ARRAY
			for (int i = 0; i < 10 /*vpcliente.Contactos.GetLength*/ ; i++) {
				dataContactos.Rows.Add(vpcliente.Contactos[i].strNombre);
			}
			
			
			
			//Transporte
			txtTranspNum.Text = vpcliente.Transporte.intTranspId.ToString();
			cmbTranspNombre.Text = vpcliente.Transporte.strNombre;
			txtTranspDireccion.Text = vpcliente.Transporte.strDireccion;
			
			
			//MessageBox.Show("Seguro que es este cliente??" + vpcliente.Contactos[0].strNombre );
			
			
			//Activo el boton para editar
			tlbEditar.Enabled = true;
		}		
#endregion

	
		void TxtCriterioTextChanged(object sender, EventArgs e)
		{
			
		}
		
				
		void FrmClientesLoad(object sender, EventArgs e)
		{
			_SSTab1_TabPage0.Show();
		}
		
		
		void _Label1_15Click(object sender, EventArgs e)
		{
	
		}
		
		void TxtCriterioKeyPress(object sender, KeyPressEventArgs e)
		{
    		//Si la tecla enter es presionada
			if((int)e.KeyChar == (int)Keys.Enter)
    		{
				//Esto conecta con la base de datos	
				ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
			
#region VARIABLES
				string strcondicion = "Nombre";

#endregion
			
			
			
				/*
			 	Este if permite saber que condicion buscar. 
			 	*/
				if (optNombre.Checked)
					{
					strcondicion = "Nombre";
					}
				else if (optProvincia.Checked) 
					{
					strcondicion = "Provincia";
					}
				else if (optLocalidad.Checked) 
					{
					strcondicion = "Localidad";
					}
				
				/*Este swich hace la busqueda segun la condicion que se le ingrese*/
				switch (strcondicion)
				{
					case "Nombre":
					//Hace la consulta asumiendo que el cliente esta activo
					ConexionAccess2007.Consultar("Clientes", "Nombre", "Nombre", txtCriterio.Text ,"Nombre");
					break;
					
					case "Provincia":
					//Hace la consulta asumiendo que el cliente esta activo
					ConexionAccess2007.Consultar("Clientes", "Nombre", "Provincia", txtCriterio.Text ,"Nombre");
					break;
				
					case "Localidad":
					//Hace la consulta asumiendo que el cliente esta activo
					ConexionAccess2007.Consultar("Clientes", "Nombre", "Localidad", txtCriterio.Text ,"Nombre");
					break;
				
				}
				
				
				
				//Esto carga en el data source del grid los datos obtenidos 
				gridData.DataSource = ConexionAccess2007.Source;
				
				
				//Cerrar la conexion
		        ConexionAccess2007.Desconectar();	
    		}	

}


	
#region Modulos


public VariablesPropias.VariablesPropias.vpClientes FormAVariable ()
{
			//Creo una variable propia 
			VariablesPropias.VariablesPropias.vpClientes vpcliente = new VariablesPropias.VariablesPropias.vpClientes ();

			/*
			 Cargar los datos obtenidos en la pantalla
			 */
			vpcliente.strid = txtNumClie.Text; 
			vpcliente.strNombre = txtRazonSocial.Text;
			
			vpcliente.strProvincia = cmbProvincia.Text;
			vpcliente.strLocalidad = cmbLocalidad.Text;
			vpcliente.strDireccion = txtDireccion.Text;
			vpcliente.strCodPos = txtCodPos.Text;
			vpcliente.dblCUIT = Convert.ToDouble (txtCUIT.Text);
			vpcliente.strTelefono1 = txtTelefono1.Text;
			vpcliente.strTelefono2 = txtTelefono2.Text;
			vpcliente.strTelefono3 = txtFax.Text;
			vpcliente.dblDescuento = Convert.ToDouble(txtDesc.Text);
			vpcliente.stremail = txtEMail.Text;
			
			//Notas
			vpcliente.memoVarios = richNotas.Text;
			
			//Contactos TODO VER COMO USAR EL TAMAÑO DEL ARRAY/Y colocarlo en un array nuevamente
			/*for (int i = 0; i < 10 /*vpcliente.Contactos.GetLength*//* ; i++) {
				dataContactos.Rows.Add(vpcliente.Contactos[i].strNombre);
			}*/
			
			
			
			//Transporte
			vpcliente.Transporte.intTranspId = Convert.ToInt32(txtTranspNum.Text);
			vpcliente.Transporte.strNombre = cmbTranspNombre.Text;
			vpcliente.Transporte.strDireccion = txtTranspDireccion.Text;	

			vpcliente.GLN = txtGLN.Text;
			vpcliente.strClienteDe= cmbClienteDe.Text;
			
			if (OptAct.Checked) {
				vpcliente.bolActivo = true;
			}
				else
			{
				vpcliente.bolActivo = false;
			}
			
				
			
			//vpcliente.dlbCalidad;

			
			
			return vpcliente;
}




#endregion

		
		
	}
}
