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
	internal partial class frmPedidosGeneral : System.Windows.Forms.Form
	{
		
		void FrmPedidosGeneralLoad(object sender, EventArgs e)
		{
			
			RefrescarGrid();
		}
		
		void GridDatosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			//MessageBox.Show("Probando", gridDatos[0,gridDatos.CurrentRow.Index].Value.ToString() );
			if (Convert.ToInt32 (gridDatos[0,gridDatos.CurrentRow.Index].Value.ToString()) >0) 
			{
				gridDatosPedido.DataSource= OperacionesComunes.FuenteObtenerDatosPedidos(
					Convert.ToInt32 (gridDatos[0,gridDatos.CurrentRow.Index].Value.ToString()));
			}
		}
		
		void TbPasarARemitoClick(object sender, EventArgs e)
		{
			//Crea un nuevo objeto que es el frmRemitos
			frmRemitos RemitoNuevo = new frmRemitos();
			
			
			string[] producto = new string[3]; //Esto son los productos directamente en cant, traza y Nombbre
			int a = 0; //variable de refuerzo para sacar cada uno de los productos
			double valordeclarado = 0; //Valor declarado del remito.
			
			
			//Cargo todos los datos dentro del nuevo remito
			RemitoNuevo.cmbRazonSocial.Text = gridDatos.CurrentRow.Cells[2].Value.ToString();
			RemitoNuevo.CargarClientesRemito();
			
			double descuento = Convert.ToDouble(OperacionesComunes.ObtenerClieDescuento(RemitoNuevo.txtIdCliente.Text))/100;
						
			
			
			double dblDolar = Convert.ToDouble(OperacionesComunes.ObtenerDolar());
			
			RemitoNuevo.lblDolar.Text = dblDolar.ToString();
			
			
			//Cargar todos los productos
			for (int j = 0; j < 5; j++)
			
			{
				//Datos de cada productos
				for (int i = 0; i < 3; i++)
				{
					producto[i] = gridDatosPedido[i+a, 0].Value.ToString();
				}
				if (producto[0].Length != 0 )
				{
				RemitoNuevo.gridDatos.Rows.Add(producto);
				
				
				
				//aumento en 3 porque cada producto son 3 datos
				a += 3;
				
				//Esta condicion asegura que no se pasen cadenas vacias
				if (producto[1] != "")
				{
					//Esta linea obtiene el valor de la mercaderia incluyendo el descuento.
					double precio = Convert.ToDouble (OperacionesComunes.ObtenerPrecioMercaderia (producto[1]  ));
					
					RemitoNuevo.gridDatos[3,j].Value = (precio  - 
														(precio * descuento)) *
														dblDolar;
					RemitoNuevo.gridDatos[4,j].Value = (Convert.ToDouble (RemitoNuevo.gridDatos[3,j].Value.ToString()) * 
					                                    Convert.ToDouble (RemitoNuevo.gridDatos[0,j].Value.ToString())).ToString();
				
				valordeclarado += Convert.ToDouble (RemitoNuevo.gridDatos[3,j].Value.ToString()) * Convert.ToDouble (RemitoNuevo.gridDatos[0,j].Value.ToString());
				
				}
				
				}
			}
			
			//Al terminar con todo paso el valor declarado			
			RemitoNuevo.lblValDec.Text = valordeclarado.ToString();
			
			//Usando this.MdiParent es como hago que cargue el form child en el general
     		RemitoNuevo.MdiParent = this.MdiParent;

     
			
			
			RemitoNuevo.Show();
			
				
		}

/// <summary>
/// Actualiza los grids 
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		void TbActualizarClick(object sender, EventArgs e)
		{
			RefrescarGrid();
		}

/// <summary>
/// Crea un nuevo pedido
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		void TbNuevoClick(object sender, EventArgs e)
		{
			frmPedidosNuevos frm = new frmPedidosNuevos();
			frm.MdiParent = this.MdiParent;
			frm.Show();
		}
		
		
		
#region Funciones
/// <summary>
/// Funcion para refrescar el grid
/// </summary>
		void RefrescarGrid()
		{
			//Cargo los datos en el grid segun la funcion que entrega un bindingsource
			gridDatos.DataSource = OperacionesComunes.FuenteObtenerPedidosPendientes();
			
			for (int i = 0; i < gridDatos.Columns.Count - 1 ; i++) 
			{
				gridDatos.Columns[i].Resizable = DataGridViewTriState.True  ;
				gridDatos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			}
		}

		
/// <summary>
/// Borra una fila
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
		void TbAnularClick(object sender, EventArgs e)
		{			VariablesPropias.VariablesPropias.vpPedido Pedido = new VariablesPropias.VariablesPropias.vpPedido();
			
			//Cargar los datos del pedido
			Pedido.NumPedido = Convert.ToInt32 ( gridDatos[0, gridDatos.CurrentRow.Index].Value.ToString());
			Pedido.Clinete.strNombre = gridDatos[2, gridDatos.CurrentRow.Index].Value.ToString();
			Pedido.Fecha = Convert.ToDateTime ( gridDatos[1, gridDatos.CurrentRow.Index].Value.ToString());
			
			Pedido.producto = new  VariablesPropias.VariablesPropias.vpProducto [6];
			
			//Cargar todos los productos
			for (int j = 0; j < 5; j++)
			
			{
				
				Pedido.producto[j].intCantidad = Convert.ToInt16 (gridDatosPedido[0+(j*3), 0].Value.ToString());
				Pedido.producto[j].strid = gridDatosPedido[1+(j*3), 0].Value.ToString();
				Pedido.producto[j].strDescripcion = gridDatosPedido[2+(j*3), 0].Value.ToString();
			}
			
			Pedido.Cancelado = true; 
			Pedido.HechoPor= "SU";
			
			
			//Borra la fila	
			gridDatos.Rows.RemoveAt(gridDatos.CurrentRow.Index);
			
			
			//Edita la Base de datos 
			OperacionesComunes.Editar(Pedido);
		}

#endregion
		
		
		
	}
}
