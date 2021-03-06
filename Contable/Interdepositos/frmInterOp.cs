﻿/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 05/09/2017
 * Hora: 06:54 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using  Contable.Modulos;

using VariablesPropias;

namespace Contable.Interdepositos
{
	/// <summary>
	/// Description of frmInterOp.
	/// </summary>
	public partial class frmInterOp : Form
	{

#region Variables

		/// <summary>
		/// Variable Publica que Arma un Cliente
		/// </summary>
		public VariablesPropias.VariablesPropias.vpClientes clie;
		
		/// <summary>
		/// Variable Publica para los Interdepositos 
		/// </summary>
		public VariablesPropias.VariablesPropias.vpInterdeposito Interdep;
#endregion		
		
		/// <summary>
		/// Formulario de operaciones con interdepositos
		/// </summary>
		public frmInterOp()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			
		}

#region Clientes
		
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
#endregion

#region Interdepositos

/// <summary>
/// Carga los datos del form en una variable del tipo Intedeposito
/// </summary>
/// <returns>Una variable del tipo Interdeposito</returns>
		public VariablesPropias.VariablesPropias.vpInterdeposito IDepositos ()
		{
		//TODO: INTERDEPOSITO: Evitar que haya campos en blanco
			Interdep.dblIDInterdeposito = 	Convert.ToDouble(lblIDCliente.Text + dtFecha.Value.Year + dtFecha.Value.Month + dtFecha.Value.Day);
			Interdep.dtFechaEmision = dtFechaIngreso.Value;
			Interdep.dtFechaPago = dtFecha.Value;
			Interdep.strBanco= txtBanco.Text;
			Interdep.strSucursal = txtSucursal.Text;
			Interdep.strBancoDestino = txtBcoDestino.Text;
			Interdep.strIDCliente = lblIDCliente.Text; 
			Interdep.curImporte = Convert.ToDecimal ( txtImporte.Text);
			Interdep.strCliente = cmbRazonSocial.Text;
			
			return Interdep; 
		}

#endregion

		
		/*void TabPage1Click(object sender, EventArgs e)
		{
			
			
		}*/
		
		void FrmInterOpLoad(object sender, EventArgs e)
		{
			//Coloca la Fecha
			dtFecha.Value = DateTime.Today;
				
			
			
			
			
			//Genera un datasource para pasarlo al combo
            cmbRazonSocial.DataSource = OperacionesComunes.FuenteObtenerClientes();
            cmbRazonSocial.DisplayMember = "Nombre";
		}
		
		void CmbRazonSocialSelectedIndexChanged(object sender, EventArgs e)
		{
			CargarClientes();
		}	

		

		
		
		
		void TlbGuardarClick(object sender, EventArgs e)
		{
			//Carga los datos del interdeposito en las bases de datos
			
			Interdep = IDepositos();
			
			//Guarda el interdeposito en la base vieja
			OperacionesComunes.Guardar(Interdep, 1);
			//Guarda el interdepostio en la base nueva
			OperacionesComunes.Guardar(Interdep, 2);
		}
		
		
		
		 
		
		
		
	}
}
