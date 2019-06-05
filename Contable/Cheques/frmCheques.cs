
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using VariablesPropias;
using ConexionDB; 
using System.Configuration;
using Contable.Modulos;

namespace Contable
{
	internal partial class frmCheques : System.Windows.Forms.Form
	{
		/*
		 * Esta variable se usa para manejar los clientes
		 */
		public VariablesPropias.VariablesPropias.vpClientes clie;
		public VariablesPropias.VariablesPropias.vpCheque cheque;
		
		void FrmChequesLoad(object sender, EventArgs e)
		{
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
			//Cargo el cliente a la variable publica
			clie =  OperacionesComunes.ObtenerCliente(cmbRazonSocial.Text);
		
			lblIDCliente.Text = clie.strid;
		}
		void TlbGuardarClick(object sender, EventArgs e)
		{
			decimal importeUSD;
			
			//Cargo los datos
			cheque.dtFechaEmision = dtFechaEmision.Value;
			cheque.dtFechaPago = dtFechaPago.Value;
			cheque.dtFechaIngreso = Convert.ToDateTime(DateTime.Today.ToShortDateString());
			cheque.curImporte = Convert.ToDecimal (txtImporte.Text);
			importeUSD =  cheque.curImporte / Convert.ToDecimal (OperacionesComunes.ObtenerDolar());
			
			//TODO Como pasara de string a decimal con "."
			cheque.curImporteUSD = importeUSD;
			
			cheque.strIDCliente = lblIDCliente.Text;
			cheque.strIDCheque = txtBanco.Text + txtSuc.Text + txtCP.Text + txtNumCheq.Text + txtCuenta.Text;
			
			//Esto guarda un vpCheque
			OperacionesComunes.Guardar(cheque);
			
		}
		
	}
}
