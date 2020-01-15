using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using System.Configuration;

using Contable.Modulos;


using ConexionDB; //Conexion con la Base de Datos

namespace Contable
{
	internal partial class frmPedidosNuevos : System.Windows.Forms.Form
	{

		
		void CmbRazonSocialSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void CmbRazonSocialDropDown(object sender, EventArgs e)
		{
			
            
            //Genera un datasource para pasarlo al combo
            //cmbRazonSocial.DataSource = ConexionAccess2007.Source;
            cmbRazonSocial.DataSource = OperacionesComunes.FuenteObtenerClientes();
            
            //Solo muestra la columna de NOMBRE
			cmbRazonSocial.DisplayMember = "Nombre"; 

            
		}
		
		void FrmPedidosNuevosLoad(object sender, EventArgs e)
		{
			ConexionAccess2007.Conectar(Convert.ToString (ConfigurationManager.AppSettings["BaseDeDatos"]));
			
			//Hace la consulta asumiendo que el cliente esta activo
			ConexionAccess2007.Consultar("Pedidos", "NumPedido", "NumPedido");
			
			//Cargo el valor del ultimo pedido y le agrego 1
			lblNumPedido.Text =  Convert.ToString(Convert.ToInt32 (ConexionAccess2007.Table.Rows[ConexionAccess2007.Table.Rows.Count-1].ItemArray[0]) + 1);
		
			
			//Cerrar la conexion
            ConexionAccess2007.Desconectar();	
            
            
            
            dgwMercaderia.DataSource = OperacionesComunes.FuenteObtenerMercaderia();
            dgwMercaderia.AutoResizeColumns();
		}
		
		
		
		
/// <summary>
/// Es para crear un nuevo pedido
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		void TbNuevoClick(object sender, EventArgs e)
		{
			
			if  (lblNumPedido.Text != "")
			{
				//Aumenta en uno el numero del pedido
				lblNumPedido.Text = Convert.ToString(Convert.ToInt32 (lblNumPedido.Text) + 1);
				cmbRazonSocial.Text ="";
			}
		}
		
		
		void DgwMercaderiaRowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			
			
			InputBox.InputBoxResult resultado = new InputBox.InputBoxResult();
			
			resultado = InputBox.InputBox.Show("Escriba la cantidad deseada","Cantidad","1");
			
			//MessageBox.Show("Usted ha seleccionado la fila", resultado.Text.ToString());
			
			//Hay que pasar todo esto a un array pero no es el momento
			dgwPedido.Rows.Add ();
			dgwPedido[0,dgwPedido.Rows.Count -2 ].Value = dgwMercaderia[0,dgwMercaderia.CurrentRow.Index].Value.ToString();
			dgwPedido[1,dgwPedido.Rows.Count -2 ].Value = dgwMercaderia[1,dgwMercaderia.CurrentRow.Index].Value.ToString();
			dgwPedido[2,dgwPedido.Rows.Count -2 ].Value = resultado.Text;
			
		}
		
/// <summary>
/// Guarda el pedido en la Bade de datos
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		void TbGuardarClick(object sender, EventArgs e)
		{
			/*
			 * Esto debe ser mejorado sustancialmente para que pueda poner infinitos productos
			 * Eso se hace colocando el numero de pedido en el producto puesto en el stock
			 * Tambien debe registrar el remito donde se coloca, eso es parte de la trazabilidad interna
			*/
			
			
			/*
			 * TODO:Esto deberia pasarlo a una funcion en Opéracione comunes pero por ahora lo paso aca
			*/
			
			VariablesPropias.VariablesPropias.vpPedido  DatosInsertar = new VariablesPropias.VariablesPropias.vpPedido();
			
			//Cargo los datos a la variable
			DatosInsertar = ObtenerDatosACargar();
			
			
			//Esta funcion conecta con la base de datos a trabajar
			ConexionAccess2007.Conectar(ConfigurationManager.AppSettings["BaseDeDatos"].ToString());
			
			 
			
			
			
			
			//Comando para ingresar los datos
			ConexionAccess2007.InsertarFila("Pedidos",
			"NumPedido, Fecha, Nombre, " +
			"Cant1, Partida1, Detalle1, " +
			"Cant2, Partida2, Detalle2, " +
			"Cant3, Partida3, Detalle3, " +
			"Cant4, Partida4, Detalle4, " +
			"Cant5, Partida5, Detalle5, " +
			"Cant6, Partida6, Detalle6, " +
			"HechoPor, FechaEntrega", /*,, Notas",
			
			 Cancelado, 
			 */
			
			
			DatosInsertar.NumPedido + ", " +
			"'" + DatosInsertar.Fecha + "', " +
			"'" + DatosInsertar.Clinete.strNombre.Trim() + "', " +
			
			//Producto 1
			DatosInsertar.producto[0].intCantidad + ", " +
			"'" + DatosInsertar.producto[0].strid.Trim() + "', " +
			"'" + DatosInsertar.producto[0].strDescripcion.Trim() + "', " +
			
			//Producto 2
			DatosInsertar.producto[1].intCantidad + ", " +
			"'" + DatosInsertar.producto[1].strid.Trim() + "', " +
			"'" + DatosInsertar.producto[1].strDescripcion.Trim() + "', " +
			
			//Producto 3
			DatosInsertar.producto[2].intCantidad + ", " +
			"'" + DatosInsertar.producto[2].strid.Trim() + "', " +
			"'" + DatosInsertar.producto[2].strDescripcion.Trim() + "', " +
			
			//Producto 4
			DatosInsertar.producto[3].intCantidad + ", " +
			"'" + DatosInsertar.producto[3].strid.Trim() + "', " +
			"'" + DatosInsertar.producto[3].strDescripcion.Trim() + "', " +
			
			//Producto 5
			DatosInsertar.producto[4].intCantidad + ", " +
			"'" + DatosInsertar.producto[4].strid.Trim() + "', " +
			"'" + DatosInsertar.producto[4].strDescripcion.Trim() + "', " +
			
			
			//Producto 6
			DatosInsertar.producto[5].intCantidad + ", " +
			"'" + DatosInsertar.producto[5].strid.Trim() + "', " +
			"'" + DatosInsertar.producto[5].strDescripcion.Trim() + "', " +
			
			 
			"'SU', " +  //Hecho por lo dejamos en SU pero habria que cambiarlo
			
			
			"'" + DateTime.Today.ToShortDateString() + "'" ); //"', " + //Fecha entrega hoy TODO: arreglar para usar el canlendario
			
			/*
 * 			"'" + richNotas.Text.Trim() + "'" );//Notas
			
				"'False', " +  //Cancelado en False
			*/
									
			//Desconectar la base de datos
			ConexionAccess2007.Desconectar();
			
			


			
		}
		
		
		public VariablesPropias.VariablesPropias.vpPedido  ObtenerDatosACargar()
		{
			VariablesPropias.VariablesPropias.vpPedido  Datos = new VariablesPropias.VariablesPropias.vpPedido();
			
			Datos.NumPedido = Convert.ToDouble (lblNumPedido.Text);
			Datos.Fecha = DateTime.Today;
			Datos.Clinete.strNombre = cmbRazonSocial.Text;
			
			//Creo el array de 6 productos 
			Datos.producto = new  VariablesPropias.VariablesPropias.vpProducto [6];
			
			for (int i = 0; i < 6; i++) {
			
				if (dgwPedido.Rows.Count -1 > i ) {
					Datos.producto[i].strid = dgwPedido[0,i].Value.ToString(); //ID
					Datos.producto[i].strDescripcion = dgwPedido[1,i].Value.ToString(); //Descripcion
					Datos.producto[i].intCantidad = Convert.ToInt16(dgwPedido[2,i].Value.ToString()); //Cantidad
				}
				else
				{
					Datos.producto[i].strid = ""; //ID
					Datos.producto[i].strDescripcion = ""; //Descripcion
				}
				
			}
			return Datos;

		}
		
	}
}
