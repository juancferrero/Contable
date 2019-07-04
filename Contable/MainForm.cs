/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 21/02/2017
 * Hora: 10:38 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Contable.Configuracion;
//using Contable.SENASA; 
//using Contable.Facturas;
using Contable.Cheques;
using Contable.Modulos;
using Contable.Reportes;
using Contable.Contador.Balance;
using Contable.Pruebas;
using Contable.Facturas;
using Contable.Interdepositos;
using Contable.SENASA;
using Contable.Contador.Impuestos;

namespace Contable
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
				void MnuClientesClick(object sender, EventArgs e)
		{
			frmClientes frm = new frmClientes();
			frm.MdiParent= this;
			frm.Show();
				
		}
		
		void MnuClieRepComprasClick(object sender, EventArgs e)
		{
			frmClieReporte frm = new frmClieReporte();
			frm.MdiParent = this;
			
			frm.Show();
			
				
		}
		
		void MnuClieRepDeudaClick(object sender, EventArgs e)
		{
			frmClieReporteDeduda frm = new frmClieReporteDeduda ();
			frm.MdiParent = this;
			frm.Show();
		}
		
		void MnuPedidosGestorClick(object sender, EventArgs e)
		{
			frmPedidosGeneral frm = new frmPedidosGeneral();
			frm.MdiParent = this;
			frm.Show();
		}
		
		void MnuNuevoClick(object sender, EventArgs e)
		{
			frmPedidosNuevos frm = new frmPedidosNuevos();
			frm.MdiParent = this;
			frm.Show();
			
		}
		
		void MnuCartelesClick(object sender, EventArgs e)
		{
			frmCarteles frm = new frmCarteles();
			frm.MdiParent = this;
			frm.Show();
			
		}
		
		void RemitosToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmRemitos frm = new frmRemitos();
			frm.MdiParent = this;
			frm.Show();
		}
		
		void MnuTransportistaClick(object sender, EventArgs e)
		{
			frmTransporte frm = new frmTransporte();
			frm.MdiParent = this;
			frm.Show();
		}
		
		void MnuMercaderiaClick(object sender, EventArgs e)
		{
			frmMercaderia frm = new frmMercaderia();
			frm.MdiParent = this;
			frm.Show();
		}
		
		void MnuContadorProveedoresClick(object sender, EventArgs e)
		{
			
			frmProveedores frm = new frmProveedores();
			frm.MdiParent = this;
			frm.Show();
		}
		
		void MnuActBancosClick(object sender, EventArgs e)
		{
			
			frmBancos frm = new frmBancos();
			frm.MdiParent = this;
			frm.Show();
		}
				
		void MnuAccionesChequesAgregarClick(object sender, EventArgs e)
		{
			frmCheques frm = new frmCheques();
			frm.MdiParent = this;
			frm.Show();
		}
		
		void MnuContadorIVAComprasClick(object sender, EventArgs e)
		{
			frmContadorIVACompras frm = new frmContadorIVACompras();
			frm.MdiParent = this;
			frm.Show();
		}
		
		void MnuContadorIVAVentasClick(object sender, EventArgs e)
		{
			
			frmContadorIVAVentas frm = new frmContadorIVAVentas();
			frm.MdiParent = this;
			frm.Show();
		}
		
		void MnuEgresosBancariosChequesClick(object sender, EventArgs e)
		{
			frmContadorChequeEmitido frm = new frmContadorChequeEmitido();
			frm.MdiParent = this;
			frm.Show();
		}
		
		void MnuContadorListFactCompraClick(object sender, EventArgs e)
		{
			frmContadorFactConIVA frm = new frmContadorFactConIVA();
			frm.MdiParent = this;
			frm.Show();
		}
		
		void MnuConfiguracionClick(object sender, EventArgs e)
		{
			frmConfiguracion frm = new frmConfiguracion();
			frm.MdiParent = this;
			frm.Show();
		}
		
		void RecibosToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmReciboAltas  frm = new frmReciboAltas();
			frm.MdiParent = this;
			frm.Show();
		}
		
		void MnuInformeSemanaClick(object sender, EventArgs e)
		{
			frmContadorInformeSemanal  frm = new frmContadorInformeSemanal();
			frm.MdiParent = this;
			frm.Show();	
		}
		
		/*void BaseDeDatosToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmBaseDatosTraza  frm = new frmBaseDatosTraza();
			frm.MdiParent = this;
			frm.Show();	
		}*/
		
		void OperatoriaToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmCheqOp  frm = new frmCheqOp();
			frm.MdiParent = this;
			frm.Show();	
		}
		
		void MnuAccionesChequesListadoClick(object sender, EventArgs e)
		{
			frmCheqListado frm = new frmCheqListado();
			frm.MdiParent = this;
			frm.Show();	
		}
		
		void MnuRepoFactImpagasClick(object sender, EventArgs e)
		{
			frmFactImpagas frm = new frmFactImpagas();
			frm.MdiParent = this;
			frm.Show();	
		}
		
		void MnuVentasAnualesClick(object sender, EventArgs e)
		{
			frmRepVentas  frm = new frmRepVentas();
			frm.MdiParent = this;
			frm.Show();	
		}
		
		/*void InformacionToolStripMenuItemClick(object sender, EventArgs e)
		{
			SENASA.Trazabilidad   frm = new SENASA.Trazabilidad();
			frm.MdiParent = this;
			frm.Show();
		}*/

		void MainFormLoad(object sender, EventArgs e)
		{
		

					
		//Cargo el dolar en el panel de abajo 
		//	_StatusBar_PanelDolar.Text = OperacionesComunes.ObtenerDolar();
		
		
		
		}
		
		
		/// <summary>
		/// Informar trazabilidad de SENASA
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/*void MnuSENASATrazaInformarClick(object sender, EventArgs e)
		{
			SENASA.frmInformarTraza   frm = new SENASA.frmInformarTraza();
			frm.MdiParent = this;
			frm.Show();
		}
		
		*/
		
		void ViajesToolStripMenuItemClick(object sender, EventArgs e)
		{
		frmRepViajes frm = new frmRepViajes();
			frm.MdiParent = this;
			frm.Show();	
		}
		
		void MnuBalanceClick(object sender, EventArgs e)
		{
		frmContadorBalance  frm = new frmContadorBalance();
			frm.MdiParent = this;
			frm.Show();	
		}
		
		void MnupruebasClick(object sender, EventArgs e)
		{
			frmPruebas  frm = new frmPruebas();
			frm.MdiParent = this;
			frm.Show();
		}
		void MnuAcercaClick(object sender, EventArgs e)
		{
	
		}
		void FacturaAToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmDocumentoFiscal frm = new frmDocumentoFiscal();
			
			frm.lblCod_cbe.Text = "01";
			frm.lblTipoFC.Text= "A";
			
			frm.MdiParent = this;
			frm.Show();	
		}
		void MnuSalirClick(object sender, EventArgs e)
		{
	
		}
		void MnuContadorCheqOrdenPagoClick(object sender, EventArgs e)
		{
	
		}
		void MnuEgresosBancariosClick(object sender, EventArgs e)
		{
	
		}
		void MnuContadorListRecibosClick(object sender, EventArgs e)
		{
	
		}
		void MnuStockIngresoClick(object sender, EventArgs e)
		{
	
		}
		void MnuStockRevisarGeneralClick(object sender, EventArgs e)
		{
	
		}
		void MnuStockRevisarConsignacionClick(object sender, EventArgs e)
		{
	
		}
		
		void MnuFactBNuevoClick(object sender, EventArgs e)
		{
			frmDocumentoFiscal frm = new frmDocumentoFiscal();
			
			frm.lblCod_cbe.Text = "06";
			frm.lblTipoFC.Text= "B";
			
			frm.MdiParent = this;
			frm.Show();	
		}
		void NotaDeDebitoToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmDocumentoFiscal frm = new frmDocumentoFiscal();
			
			frm.lblCod_cbe.Text = "02";
			frm.lblTipoFC.Text= "ND";
			
			frm.MdiParent = this;
			frm.Show();	
		}
		void NotaDeCréditoToolStripMenuItemClick(object sender, EventArgs e)
		{
	frmDocumentoFiscal frm = new frmDocumentoFiscal();
			
			frm.lblCod_cbe.Text = "03";
			frm.lblTipoFC.Text= "NC";
			
			frm.MdiParent = this;
			frm.Show();	
		}
		void InterdepositosToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmInterOp  frm = new frmInterOp();
			frm.MdiParent = this;
			frm.Show();
		}
		
#region SENASA
		void MnuSENASATrazaInformarClick(object sender, EventArgs e)
		{
			frmInformarTraza  frm = new frmInformarTraza();
			frm.MdiParent = this;
			frm.Show();
		}
		void BaseDeDatosToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmBaseDatosTraza  frm = new frmBaseDatosTraza();
			frm.MdiParent = this;
			frm.Show();
		}
		void InformacionToolStripMenuItemClick(object sender, EventArgs e)
		{
			Trazabilidad   frm = new Trazabilidad();
			frm.MdiParent = this;
			frm.Show();
		}
		void ConsultarToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmConsultaTraza frm = new frmConsultaTraza();
			frm.MdiParent = this;
			frm.Show();
		}
		void TrazabilidadIconaToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmTrazabilidadIcona frm = new frmTrazabilidadIcona();
			frm.MdiParent = this;
			frm.Show();
		}
		void InformacionToolStripMenuItem1Click(object sender, EventArgs e)
		{
	
		}
		void CuentasCorrientesToolStripMenuItemClick(object sender, EventArgs e)
		{
	
		}
		
		
#region Actualizaciones

		void ImpuestosToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmImpuestos frm = new frmImpuestos();
			frm.MdiParent = this;
			frm.Show();
		}	


#endregion

		

#endregion
		
		
	}
}
