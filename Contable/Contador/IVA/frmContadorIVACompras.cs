
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
using Contable;

using ConexionDB;

using ImprimirEjemplo;

namespace Contable
	
{
	internal partial class frmContadorIVACompras : System.Windows.Forms.Form
	{
		
		void FrmContadorIVAComprasLoad(object sender, EventArgs e)
		{
			cmbMes.Text = DateTime.Today.Month.ToString();
			cmbAno.Text = DateTime.Today.Year.ToString();
			
		}
		
		void CmbAnoSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
		
		void CmbAnoDropDown(object sender, EventArgs e)
		{
			cmbAno.Items.Clear();
			
			for (int i = 2003; i < DateTime.Today.Year + 1; i++) {
				cmbAno.Items.Add (i.ToString());
			};
		}
						
		void CmbMesSelectedIndexChanged(object sender, EventArgs e)
		{

		}
		
		void CmbMesDropDown(object sender, EventArgs e)
		{
			cmbMes.Items.Clear();
			
			for (int i = 1; i < 13; i++) {
				cmbMes.Items.Add (i.ToString());
			};
		}
		
		
				
		void TlbNuevoClick(object sender, EventArgs e)
		{
						
			frmContadorFactConIVA frm = new frmContadorFactConIVA();
			frm.MdiParent = this.MdiParent;
			frm.Show();
		}
		
		void TlbEditarClick(object sender, EventArgs e)
		{
			VariablesPropias.VariablesPropias.vpComprobanteGastos Gastos = new VariablesPropias.VariablesPropias.vpComprobanteGastos();
			
			
			Gastos= ObtenerFactProv();
			
			
			
			frmContadorFactConIVA frm = new frmContadorFactConIVA();
			frm.MdiParent = this.MdiParent;
			frm.CargarDesdeDatos (Gastos);
			
			frm.tlbEditar.Enabled = true;
			frm.tlbGuardar.Enabled = false;
			
			frm.Show();
		}
		
		void TlbListarClick(object sender, EventArgs e)
		{
			/*
*var now = DateTime.Now;
*var startOfMonth = new DateTime(now.Year, now.Month, 1);
*var DaysInMonth = DateTime.DaysInMonth(now.Year, now.Month);
*var lastDay = new DateTime(now.Year, now.Month, DaysInMonth);*/


/*
 * Estas variables permiten ver el primer dia y el ultimo del mes
 */


var startOfMonth = new DateTime(Convert.ToInt32(cmbAno.Text), Convert.ToInt32(cmbMes.Text), 1);
var DaysInMonth = DateTime.DaysInMonth(Convert.ToInt32(cmbAno.Text) , Convert.ToInt32(cmbMes.Text));
var lastDay = new DateTime(Convert.ToInt32(cmbAno.Text), Convert.ToInt32(cmbMes.Text), DaysInMonth);

			
//cargo los datos de la base de datos al grid			
gridDatos.DataSource = OperacionesComunes.FuenteObtenerFacturasCIVA(startOfMonth, lastDay);
		}
		
		void TlbAnularClick(object sender, EventArgs e)
		{
			VariablesPropias.VariablesPropias.vpComprobanteGastos FactProv = new VariablesPropias.VariablesPropias.vpComprobanteGastos();
			FactProv = ObtenerFactProv();
			
			if (FactProv.ID != 0) {
				
				DialogResult Respuesta = MessageBox.Show("Desea eliminarla?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				
				if (Respuesta == DialogResult.Yes)//Si la respuesta es SI
				{
				//Esto borra el registro
				//Si bien mando el registro completo, es lo mas facil porque tengo ya la funcion para cargarlo.
				OperacionesComunes.Eliminar(FactProv);
				}
			}
			
		}
		
		void TlbImprimirClick(object sender, EventArgs e)
		{
	
			var startOfMonth = new DateTime(Convert.ToInt32(cmbAno.Text), Convert.ToInt32(cmbMes.Text), 1);
			var DaysInMonth = DateTime.DaysInMonth(Convert.ToInt32(cmbAno.Text) , Convert.ToInt32(cmbMes.Text));
			var lastDay = new DateTime(Convert.ToInt32(cmbAno.Text), Convert.ToInt32(cmbMes.Text), DaysInMonth);

			
			
			DataTable TFactCIva = OperacionesComunes.TablaChequesFacturasCIVA(startOfMonth, lastDay);
			
			Imprimir.Imprimir_ListadoDeFactCIva (TFactCIva);
		}
		
		void GridDatosRowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
		{
			//MessageBox.Show(gridDatos[gridDatos.CurrentCell.ColumnIndex ,gridDatos.CurrentCell.RowIndex].Value.ToString());
			//MessageBox.Show("Hola");
			
		}
		
		void GridDatosRowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			
			VariablesPropias.VariablesPropias.vpComprobanteGastos FactProv = new VariablesPropias.VariablesPropias.vpComprobanteGastos();
			
			
			FactProv = ObtenerFactProv();
			
			MessageBox.Show("Ud eligio la FC: " + FactProv.strNumFact);
			
			
	
		}
		
		public VariablesPropias.VariablesPropias.vpComprobanteGastos ObtenerFactProv()
		{
			VariablesPropias.VariablesPropias.vpComprobanteGastos FactProv = new VariablesPropias.VariablesPropias.vpComprobanteGastos();
			
			
			//Esto es para las facturas de proveedores
			FactProv.ID = Convert.ToInt32( gridDatos[0, gridDatos.CurrentRow.Index].Value);
			FactProv.dtEntrada = Convert.ToDateTime(gridDatos[1, gridDatos.CurrentRow.Index].Value);
			FactProv.dtFecha = Convert.ToDateTime(gridDatos[2, gridDatos.CurrentRow.Index].Value);
			FactProv.Proveedor.Nombre = gridDatos[3, gridDatos.CurrentRow.Index].Value.ToString();
			FactProv.Proveedor.Cuit = gridDatos[4, gridDatos.CurrentRow.Index].Value.ToString();
			FactProv.strNumFact = gridDatos[5, gridDatos.CurrentRow.Index].Value.ToString();
			
			FactProv.curImpBruto = Convert.ToDecimal (gridDatos[6, gridDatos.CurrentRow.Index].Value);
			FactProv.curIva105 = Convert.ToDecimal (gridDatos[7, gridDatos.CurrentRow.Index].Value);
			FactProv.curIva21 = Convert.ToDecimal (gridDatos[8, gridDatos.CurrentRow.Index].Value);
			FactProv.curIva27 = Convert.ToDecimal (gridDatos[9, gridDatos.CurrentRow.Index].Value);
			FactProv.curIngBrutos = Convert.ToDecimal (gridDatos[10, gridDatos.CurrentRow.Index].Value);
			FactProv.curPercIva = Convert.ToDecimal (gridDatos[11, gridDatos.CurrentRow.Index].Value);
			FactProv.curNoGravados = Convert.ToDecimal (gridDatos[12, gridDatos.CurrentRow.Index].Value);
			FactProv.curImpNeto = Convert.ToDecimal (gridDatos[13, gridDatos.CurrentRow.Index].Value);
			FactProv.strTipoFact = gridDatos[14, gridDatos.CurrentRow.Index].Value.ToString();
			FactProv.strConcepto = gridDatos[15, gridDatos.CurrentRow.Index].Value.ToString();
			FactProv.strCuenta = gridDatos[16, gridDatos.CurrentRow.Index].Value.ToString();
			FactProv.strSubCuenta = gridDatos[17, gridDatos.CurrentRow.Index].Value.ToString();
			FactProv.strItems = gridDatos[18, gridDatos.CurrentRow.Index].Value.ToString();
			
			return FactProv; 
		}
		
		
		
	}
}
