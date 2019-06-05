/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 24/11/2016
 * Hora: 06:47 p.m.
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

using VariablesPropias;
using ConexionDB; 
using System.Configuration;
using Contable.Modulos;
using Contable.ConversorNumALetra;

using ImprimirEjemplo;


namespace Contable.Contador.Balance
{
	/// <summary>
	/// Description of frmContadorBalance.
	/// </summary>
	public partial class frmContadorBalance : Form
	{
/// <summary>
/// Arma el Balance de la empresa de forma provisoria
/// </summary>
		public frmContadorBalance()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmContadorBalanceLoad(object sender, EventArgs e)
		{

		
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//Conectar a la base de datos		
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseBalance"]));
	
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("PlanCuentas", "CODIGO, DESCRIPCION", "CODIGO"); 
			
			
			gridBalance.DataSource = ConexionAccess2007.Source;
			
			//Cerrar la conexion
		    ConexionAccess2007.Desconectar();	
		
		    
			
			
			
		}

/// <summary>
/// Consulta el Plan de Cuentas	
/// </summary>
/// <returns>Retorna un DataTable</returns>
		public DataTable ConsultaPlanDeCuentas()
		{
		
			//Conectar a la base de datos		
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseBalance"]));
	
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("PlanCuentas", "*", "CODIGO"); 
			
			//Cerrar la conexion
		    ConexionAccess2007.Desconectar();	
		
		    return ConexionAccess2007.Table;
		}
		void Button2Click(object sender, EventArgs e)
		{
			DataTable Juancito = ConsultaPlanDeCuentas();
			
			gridBalance.Columns.Add("","");
			
			
			
			
			MessageBox.Show( Juancito.Rows[1].ItemArray[1].ToString());
		}
	}
}
