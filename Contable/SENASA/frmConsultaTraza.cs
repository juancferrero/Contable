/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 12/07/2018
 * Hora: 10:00 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;


using Contable.SENASA.Opercaciones;

using Contable.servicios.pami.org.ar;


namespace Contable.SENASA
{
	/// <summary>
	/// Description of frmConsultaTraza.
	/// </summary>
	public partial class frmConsultaTraza : Form
	{
		public frmConsultaTraza()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			Contable.SENASA.ServiceClient.UsaProxyDelSistema();
			
			Consulta();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		


		void FrmConsultaTrazaLoad(object sender, EventArgs e)
		{
			
		}
		
		transaccionSenasa  obtenerFila(int fila)
		{
			transaccionSenasa  trans = new transaccionSenasa();
			
			
			trans.id_transaccion  = Convert.ToInt64 (gridDatosGeneral[0,fila].Value);
			trans.f_transaccion = Convert.ToDateTime (gridDatosGeneral[1,fila].Value);
			trans.f_operacion = Convert.ToDateTime (gridDatosGeneral[2,fila].Value);
			trans.d_evento = gridDatosGeneral[3,fila].Value.ToString();
			trans.d_agente_informador = gridDatosGeneral[4,fila].Value.ToString();
			trans.d_agente_origen = gridDatosGeneral[5,fila].Value.ToString();
			trans.d_agente_destino = gridDatosGeneral[6,fila].Value.ToString();
			trans.d_producto = gridDatosGeneral[7,fila].Value.ToString();
			trans.cod_producto = gridDatosGeneral[8,fila].Value.ToString() ;
			trans.cantidad = Convert.ToDecimal (gridDatosGeneral[9,fila].Value);
				
			if (gridDatosGeneral[10,fila].Value != null) {trans.d_envase = gridDatosGeneral[10,fila].Value.ToString();} 
				
			trans.d_estado_transaccion = gridDatosGeneral[11,fila].Value.ToString();
			trans.d_tipo_transaccion = gridDatosGeneral[12,fila].Value.ToString();
			if (gridDatosGeneral[13,fila].Value != null) {trans.n_serie = gridDatosGeneral[13,fila].Value.ToString() ;}
			trans.n_lote = gridDatosGeneral[14,fila].Value.ToString() ;
			trans.n_remito = gridDatosGeneral[15,fila].Value.ToString() ;

			if (gridDatosGeneral[16,fila].Value != null) {trans.motivo_devolucion = gridDatosGeneral[16,fila].Value.ToString();}
				
			if (gridDatosGeneral[17,fila].Value  != null) {trans.d_motivo_destruccion = gridDatosGeneral[17,fila].Value.ToString();}
			
			trans.en_transporte = "False";
			
			return trans;
		}
		
		public void Consulta()
		{
						
#region Datos para la Consulta

			/*Armo una estructura con los datos para cosutar
			 */
			Operaciones.vpConsultaSENASA  datosConsulta = new Operaciones.vpConsultaSENASA();
			
			
			//Cargo los datos
			datosConsulta.IdTransaccion= txtIdTransaccion.Text; //Deberia ser un LONG pero lo paso como string por si tiene un 0 adelante 
    		datosConsulta.IdEvento= txtIdEvento.Text; //Deberia ser un LONG pero lo paso como string por si tiene un 0 adelante
    		datosConsulta.GLNOrigen= txtGLNOrigen.Text; //7798181710001"; //Deberia ser un LONG pero lo paso como string por si tiene un 0 adelante
    		datosConsulta.fechaTransDesde = Convert.ToDateTime("01/01/1900") ; //DateTime
    		datosConsulta.fechaTransHasta = DateTime.Today; //DateTime
    		datosConsulta.fechaOpeDesde = Convert.ToDateTime("01/01/1900") ; //DateTime
    		datosConsulta.fechaOpeHasta= DateTime.Today; //DateTime
    		datosConsulta.GLNInformador= txtGLNInformador.Text; //Deberia ser un LONG pero lo paso como string por si tiene un 0 adelante
    		datosConsulta.IdTipoTransaccion= txtIdTipoTransaccion.Text;  //Deberia ser un LONG pero lo paso como string por si tiene un 0 adelante
    		datosConsulta.GTINElemento = "";//07798181710551";
    		datosConsulta.NroLote="";
    		datosConsulta.NroSerie="";
    		datosConsulta.NroRemitoFC="";
    		datosConsulta.estadoTransaccion ="";
			


#endregion
			
			 
			//Envia una operacion de consulta al SENASA
			transaccionSenasa[] trans = Contable.SENASA.Opercaciones.Operaciones.ConsultarDatosSENASA("7798195770008", "Ferrero9", datosConsulta );
			
			//Debe borrar todas las filas para que no se sigan agregando
			gridDatosGeneral.Rows.Clear(); //no estoy convencido de que esta sea la mejor funcion
			
			//Agrega al grid la cantidad de filas del array
			gridDatosGeneral.Rows.Add(trans.Length + 1);
			
			label10.Text = trans.Length.ToString();
			
			
			/*
			 * Armo un bucle para que cargue los datos de los productos para aceptar en el grid
			 */

			
			for (int i = 0; i < trans.Length -1 ; i++) {
				
				//Agrego una fila al grid con el array de lo obtenido en la consulta
				
				gridDatosGeneral[0,i].Value = trans[i].id_transaccion.ToString();
				gridDatosGeneral[1,i].Value = trans[i].f_transaccion.ToString("dd/MM/yyy");
				gridDatosGeneral[2,i].Value = trans[i].f_operacion.ToString("dd/MM/yyy");
				gridDatosGeneral[3,i].Value = trans[i].d_evento.ToString();
				gridDatosGeneral[4,i].Value = trans[i].d_agente_informador.ToString();
				gridDatosGeneral[5,i].Value = trans[i].d_agente_origen.ToString();
				gridDatosGeneral[6,i].Value = trans[i].d_agente_destino.ToString();
				gridDatosGeneral[7,i].Value = trans[i].d_producto.ToString();
				gridDatosGeneral[8,i].Value = trans[i].cod_producto.ToString();
				gridDatosGeneral[9,i].Value = trans[i].cantidad.ToString();
				
				if (trans[i].d_envase != null ) {gridDatosGeneral[10,i].Value = trans[i].d_envase.ToString();}//no carga bien las cosas
				
				gridDatosGeneral[11,i].Value = trans[i].d_estado_transaccion.ToString();
				gridDatosGeneral[12,i].Value = trans[i].d_tipo_transaccion.ToString();
				if (trans[i].n_serie !=null) {gridDatosGeneral[13,i].Value = trans[i].n_serie.ToString();}
				gridDatosGeneral[14,i].Value = trans[i].n_lote.ToString();
				gridDatosGeneral[15,i].Value = trans[i].n_remito.ToString();

				
				if (trans[i].motivo_devolucion !=null) {gridDatosGeneral[16,i].Value = trans[i].motivo_devolucion.ToString();}
				
				if (trans[i].d_motivo_destruccion !=null) {gridDatosGeneral[17,i].Value = trans[i].d_motivo_destruccion.ToString();}
				
				
				
			}
		}
		
		
		void TlbConsultarClick(object sender, EventArgs e)
		{
			Consulta();
			
		}
		
		void TlbInformarClick(object sender, EventArgs e)
		{
		
#region Obtener datos


			//Cargo cuantos registros voy a aceptar
			int cantRegistros = gridDatosGeneral.SelectedRows.Count;
			
			//Armo un array de los registroas a aceptar
			confirmacionTransaccionSenasaDTO[] datospasar = new confirmacionTransaccionSenasaDTO[cantRegistros];
			
			
			//Carga la fila donde inician
			int filainicial = gridDatosGeneral.CurrentRow.Index - gridDatosGeneral.SelectedRows.Count +1;
			
			int fila = filainicial;
			
			//Funcion para cargar cada registro de los seleccionados
			for (int i = 0; i < gridDatosGeneral.SelectedRows.Count; i++) {
				
				//inicializo cada registro
				datospasar[i] = new confirmacionTransaccionSenasaDTO();
			
				//Aca se cargan todos los datos como un array
				datospasar[i].f_operacion = DateTime.Today.ToShortDateString() ;
				datospasar[i].n_cantidadSpecified = true;
				datospasar[i].n_cantidad = Convert.ToDecimal(gridDatosGeneral[9,fila].Value);
				datospasar[i].p_ids_transacSpecified = true; 
				datospasar[i].p_ids_transac = Convert.ToInt64(gridDatosGeneral[0,fila].Value);
				
				
				//Guarda cada fila en la base de datos
				Contable.Modulos.OperacionesTrazabilidad.Guardar(obtenerFila(fila));
				
				fila ++ ;
				
			}

#endregion
		
		
		
		
		//Esto pasa los datos al SENASA
		
		webServiceResult respuesta = Contable.SENASA.Opercaciones.Operaciones.ConfirmarTransacionesSENASA("7798195770008", "Ferrero9", datospasar);

		MessageBox.Show("Codigo: " + respuesta.codigoTransaccion.ToString() + " Respuesta: " + respuesta.resultado.ToString(), "Respuesta");


			//MessageBox.Show(datospasar[0].p_ids_transac.ToString());
			
			Consulta();
			
		}
	}
}
