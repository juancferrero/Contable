using System;

using System.Linq;

using Contable.Modulos;

namespace Contable
{
	public partial class frmDocFiscal
	{
		internal VariablesPropias.VariablesPropias.vpFactura miFactura;
		internal VariablesPropias.VariablesPropias.vpMargenesFact miMargenes;

		internal VariablesPropias.VariablesPropias.vpRemito miRemito;
		internal  VariablesPropias.VariablesPropias.vpClientes clie;

		
		
		

		
		void FrmDocFiscal3Load(object sender, EventArgs e)
		{
		
			//Coloca la Fecha
			dtFecha.Value = DateTime.Today;
				
			
						
			
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
		


		
		
		



	}
}



