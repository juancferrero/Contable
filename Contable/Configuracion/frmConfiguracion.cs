/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 07/07/2014
 * Hora: 08:00 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration; 

namespace Contable.Configuracion
{
	/// <summary>
	/// Description of frmConfiguracion.
	/// </summary>
	public partial class frmConfiguracion : Form
	{
		public frmConfiguracion()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
		}
		
		void FrmConfiguracionLoad(object sender, EventArgs e)
		{
			txtBaseDeDatos.Text = Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]);
			txtBasePruebas.Text = Convert.ToString (ConfigurationManager.AppSettings["BasePruebas"]);
			txtBaseProduccion.Text = Convert.ToString (ConfigurationManager.AppSettings["BaseProduccion"]);

#region Trazabilidad
txtBDTrazabilidad.Text = Convert.ToString (ConfigurationManager.AppSettings["BaseTrazabilidad"]);

#endregion

#region CAI
			txtNroCAI.Text = Convert.ToString (ConfigurationManager.AppSettings["BaseCAI"]);
#endregion

#region AFIP

			checkFacturarAFIP.Checked = Convert.ToBoolean (ConfigurationManager.AppSettings["FacturarAFIP"]);
#endregion
			
			
#region Cheques

			textBaseCheques.Text = Convert.ToString (ConfigurationManager.AppSettings["BaseCheques"]);
			textBaseChequesPrueba.Text = Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]);
			textBaseChequesProduccion.Text = Convert.ToString (ConfigurationManager.AppSettings["BaseChequesProduccion"]);

#endregion
			
			
			
			
			
			
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		
		
		void TsGuardarClick(object sender, EventArgs e)
		{
		
		try
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			
			config.AppSettings.Settings["BaseDeDatos"].Value  = Convert.ToString (txtBaseDeDatos.Text);
			config.AppSettings.Settings["BasePruebas"].Value = Convert.ToString (txtBasePruebas.Text);
			config.AppSettings.Settings["BaseProduccion"].Value= Convert.ToString (txtBaseProduccion.Text );
			config.AppSettings.Settings["BaseTrazabilidad"].Value = Convert.ToString (txtBDTrazabilidad.Text);
			config.AppSettings.Settings["BaseCAI"].Value = Convert.ToString (txtNroCAI.Text); 
			
			//TODO: Para despues
			//config.AppSettings.Settings ["CertificadosKey"].Value = "AF";
			//config.AppSettings.Settings ["CertificadosClaveKey"].Value = "AF";
			//config.AppSettings.Settings ["CertificadosCert"].Value = "AF";
			
			config.AppSettings.Settings["FacturarAFIP"].Value= checkFacturarAFIP.Checked.ToString();
			
			config.AppSettings.Settings["BaseCheques"].Value = Convert.ToString (textBaseCheques.Text);
			
			config.Save(ConfigurationSaveMode.Modified);
			
			
			
		}
		catch (Exception err)
			{
				MessageBox.Show ( err.Message , "Error");
			} 

}
	}
}
