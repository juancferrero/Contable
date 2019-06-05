/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 18/09/2014
 * Hora: 06:12 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */




internal vpFactura miFactura;
		internal vpMargenesFact miMargenes;

		internal vpRemito miRemito;
		
		
		
		
		
		private void frmDocFiscal_Load(System.Object sender, System.EventArgs e)
		{
			//ParaHacer: esta línea de código carga datos en la tabla 'ClientesDataSet.Clientes' Puede moverla o quitarla según sea necesario.
			//Me.ClientesTableAdapter.Fill(Me.ClientesDataSet.Clientes)

			LlenarClientes();
			LlenarProductos();

			//Cargo la fecha del sistema en el label
			DateTime dtFecha = DateTime.Now;
			lblFecha.Text = dtFecha.ToString("dd/MM/yyyy");



			//Esto es mediante una funcion efectiva pero dudosa.
			//Estar al tanto


			//Carga el dolar del banco nacion (roguemos de que no cambien la pagina)
			if (Convert.ToBoolean(Interaction.GetSetting("Programa", "EMPRESA", "COTIZACION")) == true) {
				lblDolar.Text = ModDocFiscales.ObtenerCotizacionDelBNA();
			} else {
				lblDolar.Text = ModDocFiscales.ObtenerCotizacionDB();
			}



			//Buscar la ultima factura que se hizo.
			if (My.MyProject.Forms.MDIPrincipal.ToolStripStatusEstadoServidor.Text == "SI") {
				//Sub que busca la ultima factura que se hizo
				UltimaFacturaHecha();
			} else {
				//llama al procedimiento para obtener un ticket
				SubTicketAFIP();
				UltimaFacturaHecha();
			}

		}

		
		
		
		public void LlenarClientes()
		{
			//Llenar el Combo de los Clientes
			OleDbDataAdapter dbClientes = null;
			System.Data.DataSet dbRegistros = null;
			System.Data.DataRow fila = null;

			string NombreTabla = "tblClientes";


			dbClientes = BaseDeDatos.rstTabla("Clientes", "Nombre");
			dbRegistros = new System.Data.DataSet();

			try {
				dbClientes.Fill(dbRegistros, NombreTabla);
			} catch (Exception ex) {
				MessageBox.Show("Error en el llenado:" + Constants.vbCrLf + ex.Message);

			}

			foreach (DataRow fila_loopVariable in dbRegistros.Tables[NombreTabla].Rows) {
				fila = fila_loopVariable;
				cmbRazonSocial.Items.Add(fila[1].ToString());
			}


		}

		public void LlenarProductos()
		{
			//Llenar  los combo box con los productos

			OleDbDataAdapter dbClientes = null;
			System.Data.DataSet dbRegistros = null;
			System.Data.DataRow fila = null;

			string NombreTabla = "tblProductos";


			dbClientes = BaseDeDatos.rstTabla("Mercaderia", "Nombre", "Activo = TRUE");
			dbRegistros = new System.Data.DataSet();

			try {
				dbClientes.Fill(dbRegistros, NombreTabla);
			} catch (Exception ex) {
				MessageBox.Show("Error en el llenado:" + Constants.vbCrLf + ex.Message);

			}


			foreach (DataRow fila_loopVariable in dbRegistros.Tables[NombreTabla].Rows) {
				fila = fila_loopVariable;
				colProducto.Items.Add(fila[1].ToString());
			}
			colProducto.Width = 400;
			colCantidad.Width = 90;




		}

		public void LlenarMercaderia(string strProducto, int intfila = 99)
		{
			//Llenar  los combo box con los productos

			OleDbDataAdapter dbClientes = null;
			System.Data.DataSet dbRegistros = null;
			System.Data.DataRow fila = null;

			string NombreTabla = "tblMercaderia";


			dbClientes = BaseDeDatos.rstTabla("Stock", "Nombre", "Nombre = '" + strProducto + "' AND Stock <> 0");
			dbRegistros = new System.Data.DataSet();

			try {
				dbClientes.Fill(dbRegistros, NombreTabla);
			} catch (Exception ex) {
				MessageBox.Show("Error en el llenado:" + Constants.vbCrLf + ex.Message);

			}


			foreach (DataRow fila_loopVariable in dbRegistros.Tables[NombreTabla].Rows) {
				fila = fila_loopVariable;
				//si no le cargo el valor de la fila donde quiero que coloque los datos lo hace por defecto en la 
				//fila actual
				if (intfila == 99)
					intfila = gridDatos.CurrentCell.RowIndex;

				gridDatos[0, intfila].Value = fila[0].ToString();
				//esto carga el valor en la columna 0
				gridDatos[3, intfila].Value = "0";
				// Esto son las cantidadades
				gridDatos[4, intfila].Value = Strings.FormatCurrency(fila[2].ToString() * ((100 - Conversion.Int(lblDescuento.Text)) / 100), 2);
				//esto carga el Precio en la columna 4
				gridDatos[5, intfila].Value = "0";
				//esto es la bonificacion
				gridDatos[6, intfila].Value = "0";
				//esto es la bonificacion



			}
			colProducto.Width = 400;
			colCantidad.Width = 90;




		}

		public void LlenarRemitos(int intCombo)
		{
			//Llenar  los combo box con los remitos

			cmbRemito1.Items.Clear();
			cmbRemito2.Items.Clear();
			cmbRemito3.Items.Clear();
			cmbRemito4.Items.Clear();

			//Remitos
			OleDbDataAdapter dbRemitos = null;
			System.Data.DataSet dbRegistros = null;
			System.Data.DataRow fila = null;

			string NombreTabla = "tblRemitos";


			dbRemitos = BaseDeDatos.rstTabla("Remitos", "NumRemito", "Nombre = '" + cmbRazonSocial.Text + "' AND NumFactura = 0");
			dbRegistros = new System.Data.DataSet();

			try {
				dbRemitos.Fill(dbRegistros, NombreTabla);
			} catch (Exception ex) {
				MessageBox.Show("Error en el llenado:" + Constants.vbCrLf + ex.Message);

			}

			foreach (DataRow fila_loopVariable in dbRegistros.Tables[NombreTabla].Rows) {
				fila = fila_loopVariable;
				switch (intCombo) {
					case 1:
						cmbRemito1.Items.Add(fila[0].ToString());
						break;
					case 2:
						cmbRemito2.Items.Add(fila[0].ToString());
						break;
					case 3:
						cmbRemito3.Items.Add(fila[0].ToString());
						break;
					case 4:
						cmbRemito4.Items.Add(fila[0].ToString());
						break;
				}

			}



		}

		public void CargarRemito(int intNumRemito, int intcombo)
		{
			//Creo una variable del tipo vpRemito para usar la parte de los items
			vpRemito miRemito = new vpRemito();




			//Remitos
			OleDbDataAdapter dbRemitos = null;
			System.Data.DataSet dbRegistros = null;
			System.Data.DataRow fila = null;

			string NombreTabla = "tblRemitos";


			dbRemitos = BaseDeDatos.rstTabla("Remitos", "NumRemito", "NumRemito = " + intNumRemito);
			dbRegistros = new System.Data.DataSet();

			try {
				dbRemitos.Fill(dbRegistros, NombreTabla);
			} catch (Exception ex) {
				MessageBox.Show("Error en el llenado:" + Constants.vbCrLf + ex.Message);

			}

			foreach (DataRow fila_loopVariable in dbRegistros.Tables[NombreTabla].Rows) {
				fila = fila_loopVariable;
				//Item 1
				miRemito.Producto1.strid = fila[16];
				miRemito.Producto1.intCantidad = fila[17];
				miRemito.Producto1.strDescripcion = fila[18];
				miRemito.Producto1.curPrecioNeto = fila[19];

				//Item 2
				if (Information.IsDBNull(fila[20])) {
				} else {
					miRemito.Producto2.strid = fila[20];
				}
				miRemito.Producto2.intCantidad = fila[21];
				if (Information.IsDBNull(fila[22])) {
					miRemito.Producto2.strDescripcion = "";
				} else if (fila[22] == " ") {
					miRemito.Producto2.strDescripcion = "";
				} else {
					miRemito.Producto2.strDescripcion = fila[22];
				}

				miRemito.Producto2.curPrecioNeto = fila[23];

				//Item 3
				if (Information.IsDBNull(fila[24])) {
				} else {
					miRemito.Producto3.strid = fila[24];
				}

				miRemito.Producto3.intCantidad = fila[25];

				if (Information.IsDBNull(fila[26])) {
					miRemito.Producto3.strDescripcion = "";
				} else if (fila[26] == " ") {
					miRemito.Producto3.strDescripcion = "";
				} else {
					miRemito.Producto3.strDescripcion = fila[26];
				}
				miRemito.Producto3.curPrecioNeto = fila[27];

				//Item 4
				if (Information.IsDBNull(fila[28])) {
				} else {
					miRemito.Producto4.strid = fila[28];
				}

				miRemito.Producto4.intCantidad = fila[29];


				if (Information.IsDBNull(fila[30])) {
				} else if (fila[30] == " ") {
					miRemito.Producto4.strDescripcion = "";
				} else {
					miRemito.Producto4.strDescripcion = fila[30];
				}
				miRemito.Producto4.curPrecioNeto = fila[31];

				//Item 5
				if (Information.IsDBNull(fila[32])) {
				} else {
					miRemito.Producto5.strid = fila[32];
				}

				miRemito.Producto5.intCantidad = fila[33];

				if (Information.IsDBNull(fila[34])) {
					miRemito.Producto5.strDescripcion = "";
				} else if (fila[34] == " ") {
					miRemito.Producto5.strDescripcion = "";
				} else {
					miRemito.Producto5.strDescripcion = fila[34];
				}
				miRemito.Producto5.curPrecioNeto = fila[35];



			}





			gridDatos.RowCount = 1;
			gridDatos.RowCount = 5;
			int n = 0;
			for (n = 0; n <= gridDatos.RowCount - 1; n++) {
				switch (n) {
					case 0:
						gridDatos[1, n].Value = miRemito.Producto1.strDescripcion;
						gridDatos[2, n].Value = miRemito.Producto1.intCantidad;
						LlenarMercaderia(gridDatos[1, n].Value, n);

						//Modifica el valor de los datos del subtotal para que use los datos cargados
						gridDatos[6, n].Value = Conversion.Str(Strings.FormatNumber(Conversion.Int(gridDatos[2, n].Value) * Convert.ToDouble(gridDatos[4, n].Value), 2));
						//Remplaza la . por ,
						gridDatos[6, n].Value = Strings.Replace(gridDatos[6, n].Value, ".", ",");

						break;

					case 1:
						if (!string.IsNullOrEmpty(miRemito.Producto2.strDescripcion)) {
							gridDatos[1, n].Value = miRemito.Producto2.strDescripcion;
							gridDatos[2, n].Value = miRemito.Producto2.intCantidad;

							LlenarMercaderia(gridDatos[1, n].Value, n);

							//Modifica el valor de los datos del subtotal para que use los datos cargados
							gridDatos[6, n].Value = Conversion.Str(Strings.FormatNumber(Conversion.Int(gridDatos[2, n].Value) * Convert.ToDouble(gridDatos[4, n].Value), 2));
							//Remplaza la . por ,
							gridDatos[6, n].Value = Strings.Replace(gridDatos[6, n].Value, ".", ",");
						} else {
							gridDatos[1, n].Value = "";
							gridDatos[2, n].Value = "0";
							gridDatos[4, n].Value = "0";
							gridDatos[6, n].Value = "0";
							gridDatos[8, n].Value = "0";
						}

						break;
					case 2:
						if (!string.IsNullOrEmpty(miRemito.Producto3.strDescripcion)) {
							gridDatos[1, n].Value = miRemito.Producto3.strDescripcion;
							gridDatos[2, n].Value = miRemito.Producto3.intCantidad;

							//Rutina para llenar los datos de la mercaderia en el grid
							LlenarMercaderia(gridDatos[1, n].Value, n);

							//Modifica el valor de los datos del subtotal para que use los datos cargados
							gridDatos[6, n].Value = Conversion.Str(Strings.FormatNumber(Conversion.Int(gridDatos[2, n].Value) * Convert.ToDouble(gridDatos[4, n].Value), 2));
							//Remplaza la . por ,
							gridDatos[6, n].Value = Strings.Replace(gridDatos[6, n].Value, ".", ",");
						} else {
							gridDatos[1, n].Value = "";
							gridDatos[2, n].Value = "0";
							gridDatos[4, n].Value = "0";
							gridDatos[6, n].Value = "0";
							gridDatos[8, n].Value = "0";
						}

						break;

					case 3:
						if (!string.IsNullOrEmpty(miRemito.Producto4.strDescripcion)) {
							gridDatos[1, n].Value = miRemito.Producto4.strDescripcion;
							gridDatos[2, n].Value = miRemito.Producto4.intCantidad;

							//Rutina para llenar los datos de la mercaderia en el grid
							LlenarMercaderia(gridDatos[1, n].Value, n);

							//Modifica el valor de los datos del subtotal para que use los datos cargados
							gridDatos[6, n].Value = Conversion.Str(Strings.FormatNumber(Conversion.Int(gridDatos[2, n].Value) * Convert.ToDouble(gridDatos[4, n].Value), 2));
							//Remplaza la . por ,
							gridDatos[6, n].Value = Strings.Replace(gridDatos[6, n].Value, ".", ",");
						} else {
							gridDatos[1, n].Value = "";
							gridDatos[2, n].Value = "0";
							gridDatos[4, n].Value = "0";
							gridDatos[6, n].Value = "0";
							gridDatos[8, n].Value = "0";
						}

						break;
					case 4:
						if (!string.IsNullOrEmpty(miRemito.Producto5.strDescripcion)) {
							gridDatos[1, n].Value = miRemito.Producto5.strDescripcion;
							gridDatos[2, n].Value = miRemito.Producto5.intCantidad;

							//Rutina para llenar los datos de la mercaderia en el grid
							LlenarMercaderia(gridDatos[1, n].Value, n);

							//Modifica el valor de los datos del subtotal para que use los datos cargados
							gridDatos[6, n].Value = Conversion.Str(Strings.FormatNumber(Conversion.Int(gridDatos[2, n].Value) * Convert.ToDouble(gridDatos[4, n].Value), 2));
							//Remplaza la . por ,
							gridDatos[6, n].Value = Strings.Replace(gridDatos[6, n].Value, ".", ",");
						} else {
							gridDatos[1, n].Value = "";
							gridDatos[2, n].Value = "0";
							gridDatos[4, n].Value = "0";
							gridDatos[6, n].Value = "0";
							gridDatos[8, n].Value = "0";

						}

						break;
				}


			}



		}






		private void cmbRazonSocial_SelectedValueChanged(object sender, System.EventArgs e)
		{
			OleDbDataAdapter dbClientes = null;
			System.Data.DataSet dbRegistros = null;

			//Dim dbTabla As Data.DataTable
			System.Data.DataRow fila = null;

			string NombreTabla = "tblClientes";

			dbClientes = BaseDeDatos.rstTabla("Clientes");

			dbRegistros = new System.Data.DataSet();

			try {
				dbClientes.Fill(dbRegistros, NombreTabla);
			} catch (Exception ex) {
				MessageBox.Show("Error en el llenado:" + Constants.vbCrLf + ex.Message);

			}

			foreach (DataRow fila_loopVariable in dbRegistros.Tables[NombreTabla].Rows) {
				fila = fila_loopVariable;
				if (cmbRazonSocial.Text == fila["Nombre"].ToString()) {
					LblClieID.Text = fila["ID"].ToString();
					//Numero de ID
					lblDireccion.Text = fila["Direccion"].ToString();
					//Direccion
					lblLocalidad.Text = fila[3].ToString();
					//Localidad
					lblProvincia.Text = fila[4].ToString();
					//Provincia

					lblCUIT.Text = fila[13].ToString();
					//CUIT
					lblDescuento.Text = fila[14].ToString();
					//Descuento

				}


			}
		}

		private void lblFechVtoCAE_TextChanged(object sender, System.EventArgs e)
		{
			string Dia = null;
			string Mes = null;
			string Ano = null;

			Ano = DateAndTime.Year(Convert.ToDateTime(lblFechVtoCAE.Text));
			if (Convert.ToInt32(DateAndTime.Month(Convert.ToDateTime(lblFechVtoCAE.Text))) < 10) {
				Mes = "0" + DateAndTime.Month(Convert.ToDateTime(lblFechVtoCAE.Text));
			} else {
				Mes = DateAndTime.Month(Convert.ToDateTime(lblFechVtoCAE.Text));
			}

			if (Convert.ToInt32(DateAndTime.Day(Convert.ToDateTime(lblFechVtoCAE.Text))) < 10) {
				Dia = "0" + DateAndTime.Day(Convert.ToDateTime(lblFechVtoCAE.Text));
			} else {
				Dia = DateAndTime.Day(Convert.ToDateTime(lblFechVtoCAE.Text));
			}

			txtCodBarNum.Text = Interaction.GetSetting("Programa", "EMPRESA", "CUIT", Convert.ToString(1)) + lblCod_cbe.Text + cmbSucursal.Text + lblCAE.Text + Ano + Mes + Dia + Cod_Verificador.CodVerificador(ref Interaction.GetSetting("Programa", "EMPRESA", "CUIT", Convert.ToString(1)) + lblCod_cbe.Text + cmbSucursal.Text + lblCAE.Text + Ano + Mes + Dia);
		}



		private void lblCAE_DoubleClick(object sender, System.EventArgs e)
		{
			lblCAE.Text = Interaction.InputBox("Ingrese en Numero de CAE");
		}


		public void gridDatos_CellEndEdit(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{


			if (Information.IsNumeric(gridDatos.CurrentCell.Value)) {
				switch (gridDatos.CurrentCell.ColumnIndex) {
					//Selecciona en funcion del index de cada columna

					case 2:
						//modifican la cantidad
						gridDatos[6, gridDatos.CurrentCell.RowIndex].Value = Conversion.Str(Strings.FormatCurrency(Conversion.Int(gridDatos[2, gridDatos.CurrentCell.RowIndex].Value) * Convert.ToDouble(gridDatos[4, gridDatos.CurrentCell.RowIndex].Value), 2));

						gridDatos[6, gridDatos.CurrentCell.RowIndex].Value = Strings.Replace(gridDatos[6, gridDatos.CurrentCell.RowIndex].Value, ".", ",");

						break;
					case 7:
						//modifica el IVA
						gridDatos[8, gridDatos.CurrentCell.RowIndex].Value = Strings.FormatCurrency(Convert.ToDecimal(gridDatos[6, gridDatos.CurrentCell.RowIndex].Value) * (1 + (Convert.ToDouble(gridDatos[7, gridDatos.CurrentCell.RowIndex].Value) / 100)), 2);

						break;
				}
				//MsgBox("hola Mundo")
				// MsgBox("mi fila es:" & gridDatos.CurrentCell.RowIndex)
				// MsgBox("mi columna es:" & gridDatos.CurrentCell.ColumnIndex)

				//Esto es para que siempre sea 0 el inicio de las cuentas
				//USD
				lblSubtotalUSD.Text = "0";
				lblTotalUSD.Text = "0";
				lblIvaUSD.Text = "0";
				//$
				lblSubtotal.Text = "0";
				lblTotal.Text = "0";
				lblIva.Text = "0";

				//Carga los datos en los lbl de cada uno de los SubTotal, IVA y Total
				int i = 0;
				for (i = 0; i <= gridDatos.Rows.Count - 2; i++) {
					//USD
					lblSubtotalUSD.Text = Strings.FormatCurrency(Convert.ToDecimal(lblSubtotalUSD.Text) + Convert.ToDecimal(gridDatos[6, i].Value), 2);
					lblIvaUSD.Text = Strings.FormatCurrency(Convert.ToDecimal(lblIvaUSD.Text) + (Convert.ToDecimal(gridDatos[6, i].Value) * (Convert.ToDouble(gridDatos[7, i].Value) / 100)), 2);
					lblTotalUSD.Text = Strings.FormatCurrency(Convert.ToDecimal(lblSubtotalUSD.Text) + Convert.ToDecimal(lblIvaUSD.Text), 2);


					//$
					lblSubtotal.Text = Strings.FormatCurrency(Convert.ToDecimal(lblSubtotalUSD.Text) * Convert.ToDecimal(lblDolar.Text), 2);
					//Hacer: Error con decimales
					//Ver como modificarlo bien porque no sale    


					if (Convert.ToDecimal(lblIva.Text) != Convert.ToDecimal(lblTotalUSD.Text) * 0.21) {
						lblIva.Text = Strings.FormatCurrency(Convert.ToDecimal(lblSubtotal.Text) * 0.21, 2);
						lblTotal.Text = Strings.FormatCurrency(Convert.ToDecimal(lblSubtotal.Text) + Convert.ToDecimal(lblIva.Text), 2);
					} else {
						lblIva.Text = Strings.FormatCurrency(Convert.ToDecimal(lblIvaUSD.Text) * Convert.ToDecimal(lblDolar.Text), 2);
						lblTotal.Text = Strings.FormatCurrency(Convert.ToDecimal(lblTotalUSD.Text) * Convert.ToDecimal(lblDolar.Text), 2);
					}




				}


			//si no es numerico
			} else {
				switch (gridDatos.CurrentCell.ColumnIndex) {

					case 1:
						//modifican los datos
						//MsgBox("hola todos")
						LlenarMercaderia(gridDatos[gridDatos.CurrentCell.ColumnIndex, gridDatos.CurrentCell.RowIndex].Value);

						break;
				}

			}

		}

		private void lblFechVtoCAE_Click(System.Object sender, System.EventArgs e)
		{
			Calendario.Visible = true;
			Calendario.Tag = "2";
		}

		private void lblFecha_Click(System.Object sender, System.EventArgs e)
		{
			Calendario.Show();
			Calendario.Tag = "1";
		}

		private void Calendario_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
		{
			// fecha de la factura
			if (Calendario.Tag == "1") {
				lblFecha.Text = Calendario.SelectionStart;

			//Fecha de vencimiento del CAE
			} else if (Calendario.Tag == "2") {
				lblFechVtoCAE.Text = Calendario.SelectionStart;


			}

			Calendario.Visible = false;

		}






		private void _Toolbar1_Nuevo_Click(System.Object sender, System.EventArgs e)
		{
			//Esta linea aumenta en uno el numero de Factura
			txtNumFact.Text = Conversion.Int(txtNumFact.Text) + 1;

			//Limpia los datos del cliente
			cmbRazonSocial.Text = "";
			lblDireccion.Text = "";
			lblLocalidad.Text = "";
			lblProvincia.Text = "";
			lblCUIT.Text = "";
			lblDescuento.Text = "";

			//Limpia los datos de la Factura
			gridDatos.Rows.Clear();

			//En Pesos
			lblSubtotal.Text = "0";
			lblIva.Text = "0";
			lblTotal.Text = "0";
			//En USD
			lblSubtotalUSD.Text = "0";
			lblIvaUSD.Text = "0";
			lblTotalUSD.Text = "0";

			//Limpia los remitos
			cmbRemito1.Text = "0";
			cmbRemito2.Text = "0";
			cmbRemito3.Text = "0";
			cmbRemito4.Text = "0";


			//Datos de Fc Electronica
			lblCAE.Text = "";
			lblFechVtoCAE.Text = System.DateTime.Today;

			//Esto permite que se pueda Guardar
			_Toolbar1_Guardar.Enabled = true;

			//Esto impide que se vuelva a Imprimir
			_Toolbar1_Imprimir.Enabled = false;

		}


		private void _Toolbar1_Guardar_Click(System.Object sender, System.EventArgs e)
		{
			OleDbDataAdapter dbClientes = new OleDbDataAdapter();

			System.Data.DataSet dbRegistros = null;
			System.Data.DataRow fila = null;

			string NombreTabla = "tblFactura";



			//Antes de cargar nada fijamos si puede guardarlo en la AFIP sino no sigue con el guardado de la factura
			//ESP La funcion EnviarFacturaAFIP esta en el modulo de AFIP.
			bool bolFactEnAFIP = AFIP.EnviarFacturaAFIP(Imprimir.CargarFactura(gridDatos.Rows.Count - 1), lblToken.Text, lblSign.Text);

			if (bolFactEnAFIP != true) {
				Interaction.MsgBox("NO se pudo cargar la factura en AFIP. Intentelo nuevamente", MsgBoxStyle.Information);
				return;
			}



			//Cargo la tabla en la base
			//Facturas A
			if (lblCod_cbe.Text == "01") {
				dbClientes = BaseDeDatos.rstTabla("Facturas", "Fecha", "");
			//Facturas B
			} else if (lblCod_cbe.Text == "06") {
				dbClientes = BaseDeDatos.rstTabla("FacturasB", "Fecha", "");
			//Notas de Credito
			} else if (lblCod_cbe.Text == "03") {
				dbClientes = BaseDeDatos.rstTabla("NotaCredito", "Fecha", "");
			//Notas de Debito
			} else if (lblCod_cbe.Text == "02") {
				dbClientes = BaseDeDatos.rstTabla("NotaDebito", "Fecha", "");
			}


			//Asigno un nuevo Data Set
			dbRegistros = new System.Data.DataSet();

			try {
				dbClientes.Fill(dbRegistros, NombreTabla);
			} catch (Exception ex) {
				MessageBox.Show("Error en el llenado:" + Constants.vbCrLf + ex.Message);

			}







			OleDbCommandBuilder cb = new OleDbCommandBuilder(dbClientes);







			miFactura = Imprimir.CargarFactura(gridDatos.Rows.Count - 1);




			fila = dbRegistros.Tables[NombreTabla].NewRow();
			fila.BeginEdit();


			//Cargo el valor del "DOCUMENTO"
			//Facturas A
			if (lblCod_cbe.Text == "01") {
				fila["Documento"] = "FC A " + Strings.Format(miFactura.intSucursal, "0000") + "-" + Strings.Format(miFactura.dblNumFact, "00000000");
			//Facturas B
			} else if (lblCod_cbe.Text == "06") {
				fila["Documento"] = "FC B " + Strings.Format(miFactura.intSucursal, "0000") + "-" + Strings.Format(miFactura.dblNumFact, "00000000");
			//Notas de Credito
			} else if (lblCod_cbe.Text == "03") {
				fila["Documento"] = "NC " + Strings.Format(miFactura.intSucursal, "0000") + "-" + Strings.Format(miFactura.dblNumFact, "00000000");
			//Notas de Debito
			} else if (lblCod_cbe.Text == "02") {
				fila["Documento"] = "ND " + Strings.Format(miFactura.intSucursal, "0000") + "-" + Strings.Format(miFactura.dblNumFact, "00000000");
			}

			fila["Sucursal"] = miFactura.intSucursal;
			fila["NumFact"] = miFactura.dblNumFact;
			fila["Fecha"] = miFactura.dtFecha;
			//
			fila["IDCliente"] = miFactura.Cliente.strid;
			fila["Nombre"] = miFactura.Cliente.strNombre;
			fila["Direccion"] = miFactura.Cliente.strDireccion;
			fila["Localidad"] = miFactura.Cliente.strLocalidad;
			fila["Provincia"] = miFactura.Cliente.strProvincia;
			fila["Tipodecambio"] = miFactura.dblTipoCambio;
			fila["Descuento"] = Conversion.Str(miFactura.Cliente.dblDescuento);

			fila["Cant1"] = miFactura.Producto1.intCantidad;
			fila["Detalle1"] = miFactura.Producto1.strDescripcion;
			fila["PrecioUnitario1"] = miFactura.Producto1.curPrecioNeto;
			fila["PrecioFinal1"] = miFactura.Producto1.curPrecioTotal;

			fila["Cant2"] = miFactura.Producto2.intCantidad;
			fila["Detalle2"] = miFactura.Producto2.strDescripcion;
			fila["PrecioUnitario2"] = miFactura.Producto2.curPrecioNeto;
			fila["PrecioFinal2"] = miFactura.Producto2.curPrecioTotal;

			fila["Cant3"] = miFactura.Producto3.intCantidad;
			fila["Detalle3"] = miFactura.Producto3.strDescripcion;
			fila["PrecioUnitario3"] = miFactura.Producto3.curPrecioNeto;
			fila["PrecioFinal3"] = miFactura.Producto3.curPrecioTotal;

			fila["Cant4"] = miFactura.Producto4.intCantidad;
			fila["Detalle4"] = miFactura.Producto4.strDescripcion;
			fila["PrecioUnitario4"] = miFactura.Producto4.curPrecioNeto;
			fila["PrecioFinal4"] = miFactura.Producto4.curPrecioTotal;

			fila["Cant5"] = miFactura.Producto5.intCantidad;
			//Cantidad 5
			fila["Detalle5"] = miFactura.Producto5.strDescripcion;
			//Detalle5
			fila["PrecioUnitario5"] = miFactura.Producto5.curPrecioNeto;
			//Precio Unitario 5
			fila["PrecioFinal5"] = miFactura.Producto5.curPrecioTotal;
			//Precio Final 5

			fila["Cant6"] = 0;
			//Cantidad 6
			fila["Detalle6"] = " ";
			//Detalle6
			fila["PrecioUnitario6"] = 0;
			//Precio Unitario 6
			fila["PrecioFinal6"] = 0;
			//Precio Final 6

			fila["SubTotal"] = miFactura.curSubTotal;
			//Sub Total $
			fila["IVA"] = miFactura.curIVA;
			//IVA $
			fila["ImporteFinal"] = miFactura.curTotal;
			//Importe Final $

			fila["Recibo1"] = 0;
			fila["Recibo2"] = 0;
			//Recibo2
			fila["Recibo3"] = 0;
			//Recibo3
			fila["Recibo4"] = 0;
			//Recibo4
			fila["Recibo5"] = 0;
			//Recibo5

			fila["ClienteDe"] = " ";
			//Cliente De

			fila["Remito1"] = miFactura.intRemito1;
			//
			fila["Remito2"] = miFactura.intRemito2;
			//Remito2
			fila["Remito3"] = miFactura.intRemito3;
			//Remito3
			fila["Remito4"] = miFactura.intRemito4;
			//Remito4
			fila["Remito5"] = 0;
			//Remito5

			fila["Observaciones"] = " ";
			//Observaciones

			fila["SubTotalUSS"] = miFactura.curSubTotalUSD;
			//Sub Total USS
			fila["IVAUSS"] = miFactura.curIVAUSD;
			//IVA USS
			fila["ImporteFinalUSS"] = miFactura.curTotalUSD;
			//Importe Final USS

			fila["EnDolar"] = 0.0;
			//En Dolar

			fila["Saldo"] = Strings.Replace(Conversion.Str(miFactura.curTotal), ".", ",");
			//Saldo
			fila["SaldoUSS"] = miFactura.curTotalUSD;
			//SaldoUSS

			fila["Pagado"] = false;

			fila["Dólar"] = true;
			fila["Peso"] = false;


			fila["Promocion"] = 0;

			fila["CAE"] = miFactura.strCAE;
			fila["FechaVencCAE"] = miFactura.strFechVtoCAE;


			//Finaliza la edicion
			fila.EndEdit();

			//Añade la fila a la tabla
			dbRegistros.Tables[NombreTabla].Rows.Add(fila);




			//Actualiza la base de datos
			dbClientes.Update(dbRegistros, NombreTabla);


			//acepta los cambios
			dbRegistros.AcceptChanges();




			//MsgBox(miFactura.strTipoFc)
			//MsgBox(miFactura.intSucursal)
			//MsgBox(miFactura.dtFecha)
			Interaction.MsgBox("Factura Cargada");

			//Este modulo edita la tabla de remitos y asigna el valor de la factura y su respectiva 
			//sucursal al remito en cuestion
			//eso lo saca de los desplegables de remitos
			ModDocFiscales.EditarRemitos((cmbSucursal.Text), Convert.ToDouble(txtNumFact.Text), Convert.ToDouble(cmbRemito1.Text));
			Interaction.MsgBox("Remito: " + cmbRemito1.Text + ". Modificado");


			//Esto permite que se pueda imprimir
			_Toolbar1_Imprimir.Enabled = true;

			//Esto impide que se vuelva a guardar
			_Toolbar1_Guardar.Enabled = false;



		}

		private void _Toolbar1_Imprimir_Click(System.Object sender, System.EventArgs e)
		{
			//ENG Create the print dialog object and set options
			//ESP Crear el dialogo de impresion y setear opciones
			PrintDialog pDialog = new PrintDialog();

			//ESP Seteo previamente para que la cantidad de copias sea 3
			pDialog.PrinterSettings.Copies = 3;

			int copias = 1;

			//ENG Display the dialog. This returns true if the user presses the Print button.
			//ESP Mostrar el dialogo. Esto retorna Verdadero si el usuario presiona Imprimir
			bool bolImprimir = pDialog.ShowDialog();
			//ESP Si presiono el boton entonces
			if (bolImprimir == true) {
				//Cantidad de copias estipulado por el usuario
				for (copias = 1; copias <= Convert.ToInt32(pDialog.PrinterSettings.Copies.ToString()); copias++) {
					// ejemplo simple para imprimir en .NET
					// Usamos una clase del tipo PrintDocument
					PrintDocument printDoc = new PrintDocument();

					// asignamos el método de evento para cada página a imprimir
					printDoc.PrintPage += Imprimir.print_Factura;
					//Esto envia el formato de la factura a imprimir
					// indicamos que queremos imprimir
					printDoc.Print();
				}
			}

		}

		private void lblDolar_DoubleClick(object sender, System.EventArgs e)
		{
			lblDolar.Text = Interaction.InputBox("Ingresar valor del Dolar usando *,* en vez de *.* ");
		}







		private void txtCodBarNum_TextChanged(System.Object sender, System.EventArgs e)
		{
			PictureBox1.Image = null;


			//Dim i As Integer = MsgBox("¿Desea generar el codigo de barras?", MsgBoxStyle.OkCancel, "Codigo de Barras")

			//If i = 1 Then

			//USANDO UN WEBSERVICE

			//Dimensiono las variables
			//Creo una imagen
			//Carga En la variable img la imagen del stream que saca de Web Service
			//La funcion BI2OF5 es la encargada de crear el estream a partir de los 
			//numeros que se le pasen como texto


			//Dim img As Image = Image.FromStream(BI2OF5(txtCodBarNum.Text))

			//USANDO UNA FUNCION LOCAL
			Image img = ModuleBarcode.Print2of5Interleaved(txtCodBarNum.Text);


			//Paso la imagen
			PictureBox1.Image = img;


			//End If
		}


		public void SubTicketAFIP()
		{
			//Dimensiono una variable propia (todas las vp... lo son)
			vpAFIPTicket TicketAccAFIP = default(vpAFIPTicket);


			//Esta Function Obtiene un ticket de acceso a la AFIP
			TicketAccAFIP = AFIP.TicketAccesoAFIP();

			//Aqui lo que se hace es pasar los datos del token y el sign para dos txt que estan en el formulario
			//La idea es sacar estas lineas pronto porque son obsoletas
			//30/5/13
			lblToken.Text = TicketAccAFIP.vpAFIPTicketToken;
			lblSign.Text = TicketAccAFIP.vpAFIPTicketSign;




			//Cargo los datos del Ticket en una clase publica que esta en el MDI
			//de esta manera lo que hago es que este disponible para todo el proyecto
			//Cada vez que se use en una factura corroborará el ticket y de esta manera no hay que 
			//cerrar la ventana para hacer otra factura.
			//El ticket es algo importante por eso pienso que debe estar en el MDI para que sea de acceso
			//publico.
			//30/5/13
			MDIPrincipal.ClaseAFIP.ptAFIPTicketToken = TicketAccAFIP.vpAFIPTicketToken;
			MDIPrincipal.ClaseAFIP.ptAFIPTicketSign = TicketAccAFIP.vpAFIPTicketSign;
			MDIPrincipal.ClaseAFIP.ptAFIPTicketGenerationTime = TicketAccAFIP.vpAFIPTicketGenerationTime;
			MDIPrincipal.ClaseAFIP.ptAFIPTicketExpirationTime = TicketAccAFIP.vpAFIPTicketExpirationTime;
			MDIPrincipal.ClaseAFIP.ptAFIPTicketService = TicketAccAFIP.vpAFIPTicketService;
			MDIPrincipal.ClaseAFIP.ptAFIPTicketUniqueID = TicketAccAFIP.vpAFIPTicketUniqueID;

			My.MyProject.Forms.MDIPrincipal.ToolStripStatusEstadoServidor.Text = "SI";

		}














		//REMITO 1


		private void cmbRemito1_DropDown(object sender, System.EventArgs e)
		{
			LlenarRemitos(1);
		}

		private void cmbRemito1_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			CargarRemito(cmbRemito1.Text, 1);
		}

		//REMITO 2

		private void cmbRemito2_DropDown(object sender, System.EventArgs e)
		{
			LlenarRemitos(2);
		}

		private void cmbRemito2_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			CargarRemito(cmbRemito2.Text, 2);
		}

		//REMITO 3

		private void cmbRemito3_DropDown(object sender, System.EventArgs e)
		{
			LlenarRemitos(3);
		}

		private void cmbRemito3_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			CargarRemito(cmbRemito3.Text, 3);
		}

		//REMITO 4

		private void cmbRemito4_DropDown(object sender, System.EventArgs e)
		{
			LlenarRemitos(4);
		}

		private void cmbRemito4_SelectedIndexChanged(System.Object sender, System.EventArgs e)
		{
			CargarRemito(cmbRemito4.Text, 4);
		}







		private void UltimaFacturaHecha()
		{
			//Invoco al método FECompUltimoAutorizado y de esta manera le paso el valor de la ultima factura
			//al textbox del comprobante fiscal
			txtNumFact.Text = AFIP.UltimoComprobante(MDIPrincipal.ClaseAFIP.ptAFIPTicketToken, MDIPrincipal.ClaseAFIP.ptAFIPTicketSign);


		}
		public frmDocFiscal3()
		{
			Load += frmDocFiscal_Load;
			InitializeComponent();
		}



