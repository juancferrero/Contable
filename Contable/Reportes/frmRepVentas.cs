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
			gridDatos.DataSource = OperacionesComunes.FuenteObtenerVentasAnuales(Convert.ToInt16(cmba�o.Text));
		}
		
		void Cmba�oSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Cmba�oDropDownClosed(object sender, EventArgs e)
		{
			
		}
		
		void Cmba�oDropDown(object sender, EventArgs e)
		{
			cmba�o.Items.Clear();
			
			for (int i = 2003; i <= DateTime.Today.Year; i++) {
				cmba�o.Items.Add(i);
			}
		}
	}
}
