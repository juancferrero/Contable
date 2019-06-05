//using Microsoft.VisualBasic;
//using Microsoft.VisualBasic.Compatibility;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using Contable.Modulos;

namespace Contable
{
	internal partial class frmRepVentas : System.Windows.Forms.Form
	{
		
		void TlActualizarClick(object sender, EventArgs e)
		{
			gridDatos.DataSource = OperacionesComunes.FuenteObtenerVentasAnuales(Convert.ToInt16(cmbaño.Text));
		}
		
		void CmbañoSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void CmbañoDropDownClosed(object sender, EventArgs e)
		{
			
		}
		
		void CmbañoDropDown(object sender, EventArgs e)
		{
			cmbaño.Items.Clear();
			
			for (int i = 2003; i <= DateTime.Today.Year; i++) {
				cmbaño.Items.Add(i);
			}
		}
	}
}
