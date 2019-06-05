//using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Net.Mail;
using System.Net.Mime;
using System.Resources;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

namespace WindowsApplication1
{
	public partial class frmConsFactHabil
	{

		private void cmdConsultar_Click(System.Object sender, System.EventArgs e)
		{
			//ESP Dimensiono un nuevo objeto que cumple con las caracteristicas de ar.gov.afip.servicios1.FECompConsultaResponse
			ar.gov.afip.servicios1.FECompConsultaResponse objFERecuperarCbtesResp = new ar.gov.afip.servicios1.FECompConsultaResponse();

			//ESP Esto carga mediante la funcion que tengo en un modulo (AFIP.vb) los datos de la respuesta obtenida de la AFIP
			objFERecuperarCbtesResp = AFIP.ComprobantesAutorizados(MDIPrincipal.ClaseAFIP.ptAFIPTicketToken, MDIPrincipal.ClaseAFIP.ptAFIPTicketSign, Convert.ToInt64(txtNumFact.Text));

			//ESP Inserta la respuesta en el Label
			lblRespuesta.Text = objFERecuperarCbtesResp.ResultGet.Resultado.ToString();

			//ESP Inserta la respuesta de Numero de Autorizacion de la factura (CAE)
			lblCAE.Text = objFERecuperarCbtesResp.ResultGet.CodAutorizacion.ToString();

			//ESP Inserta la respuesta del Valor Final
			lblValorFinal.Text = objFERecuperarCbtesResp.ResultGet.ImpTotal.ToString();

			//ESP Inserta la respuesta del IVA
			lblIVA.Text = objFERecuperarCbtesResp.ResultGet.ImpIVA.ToString();

			//ESP Inserta la respuesta del Valor Neto
			lblNeto.Text = objFERecuperarCbtesResp.ResultGet.ImpNeto.ToString();





		}
		public frmConsFactHabil()
		{
			InitializeComponent();
		}
	}
}
