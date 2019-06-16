/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 13/06/2019
 * Hora: 10:32 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Contable.Contador.Impuestos
{
	/// <summary>
	/// Este form esta pensado para cargar y modificar todos los impuestos que gravan las actividades comerciales para luego,
	/// poder usarlo en las distintas partes del programa.
	/// Es un Alta/Baja/Modificacion de los gravamenes de la Argentina.
	/// Los impuestos seran cargados en una base de datos con ID, Tipo (Nacional/Provincial/Municipal/Varios), Nombre, Alicuota 
	/// (% sobre el Neto grabado)
	/// Tambien hay que hacer una Base de datos que relacione Impuestos Vs Proveedor.
	/// </summary>
	public partial class frmImpuestos : Form
	{
		public frmImpuestos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
