using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using System.Configuration;

using Contable.Modulos;


using ConexionDB; //Conexion con la Base de Datos

namespace Contable
{
	internal partial class frmPedidosNuevos : System.Windows.Forms.Form
	{

		
		void CmbRazonSocialSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void CmbRazonSocialDropDown(object sender, EventArgs e)
		{
			
            
            //Genera un datasource para pasarlo al combo
            //cmbRazonSocial.DataSource = ConexionAccess2007.Source;
            cmbRazonSocial.DataSource = OperacionesComunes.FuenteObtenerClientes();
            
            //Solo muestra la columna de NOMBRE
			cmbRazonSocial.DisplayMember = "Nombre"; 

            
		}
		
		void FrmPedidosNuevosLoad(object sender, EventArgs e)
		{
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
			
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("Pedidos", "NumPedido", "NumPedido");
			
			//Cargo el valor del ultimo pedido y le agrego 1
			lblNumPedido.Text =  Convert.ToString(Convert.ToInt32 (ConexionAccess2007.Table.Rows[ConexionAccess2007.Table.Rows.Count-1].ItemArray[0]) + 1);
		
			
			//Cerrar la conexion
            ConexionAccess2007.Desconectar();	
            
            
            
            dgwMercaderia.DataSource = OperacionesComunes.FuenteObtenerMercaderia();
            dgwMercaderia.AutoResizeColumns();
		}
		
		
		
		
		
		void TbNuevoClick(object sender, EventArgs e)
		{
			if  (lblNumPedido.Text != "")
			{
				lblNumPedido.Text = Convert.ToString(Convert.ToInt32 (lblNumPedido.Text) + 1);
			cmbRazonSocial.Text ="";
			}
		}
	}
}
