using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Contable.servicios.pami.org.ar;

namespace Contable.SENASA
{
    public partial class Form1 : Form
    {
        private string WsUser = "testwservice";
        private string WsPass = "testwservicepsw";

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //showSplashScreen();
            comboBox1.SelectedIndex = 0;
        }

       
        }
        
        private void btnEnviarDatos_Click(object sender, EventArgs e)
        {
            string usser = txtUser.Text;
            string pass = txtPass.Text;
            string cufe = txtCufe.Text;

            if(validarDatos(usser, pass, cufe))
            {
                EnviarDatos(usser, pass);
            }
        }

        private static bool validarDatos(string usser, string pass, string cufe)
        {
            if(usser == "")
            {
                MessageBox.Show("El campo usuario es obligatorio \nDebe ingresar un usario valido","Error WebService Sedronar",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return false;
            }
            if (pass == "")
            {
                MessageBox.Show("El campo contraseña es obligatorio \nDebe ingresar una contraseña valida","Error WebService Sedronar",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return false;
            }
            if(cufe == "")
            {
                MessageBox.Show("El campo Cufe es obligatorio \nDebe ingresar un Cufe valido","Error WebService Sedronar",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return false;  
            }
            return true;

        }

        private void EnviarDatos(string usr, string pass)
        {
            
        	//Esto junta todos loos datos del parametros para enviar al SENASA
        	transaccionSenasaDTO[] parametros = ObtenerParametros();
            
        	//Esto crea un cliente. Usa los valores de USUARIO Y CONTRASEÑA POR DEFECTO
        	ServiceClient client = new ServiceClient(WsUser, WsPass);
        	
        	//Carga en la respuesta los resultados de SENDTRANSACCION con los parametros y el ususario y contraseñas mio
            saveTransaccionesResponse respuesta = client.SendTransaccion(parametros, usr, pass);
            
            //MUESTRA UNA RESPUESTA
            MostrarRespuesta(respuesta.@return);

        }

        public transaccionSenasaDTO[] ObtenerParametros()
        {
            int valEvento = valorCombo();
            transaccionSenasaDTO tran = new transaccionSenasaDTO();

            tran.f_operacion = DateTime.Now.ToString("dd/MM/yyyy");
            tran.id_evento = valEvento;
            tran.id_eventoSpecified = true;
            tran.n_cantidad = 1;
            tran.n_cantidadSpecified = true;
            tran.n_lote = "12";
            tran.n_serie = "123";
            tran.f_elaboracion = "25/08/2013";
            tran.f_vto = "25/08/2014";
            tran.cod_producto = "88900000000001";

            if (valEvento == 11)
            {
                tran.gln_origen = txtCufe.Text;
                tran.gln_destino = "7798198980008";
                
            }
            else
            {
                if (valEvento == 12)
                {
                    tran.gln_origen = "3692581473693";
                    tran.gln_destino = txtCufe.Text;
                }
            }

            transaccionSenasaDTO[] transacciones = new transaccionSenasaDTO[1];

            transacciones[0] = tran;
            return transacciones;
        }

        private int valorCombo()
        {
            if (comboBox1.Text == "VENTA")
            {
                return 11;
            }

            if (comboBox1.Text == "RECEPCIÓN DE COMPRA")
            {
                return 12;
            }
            return 0;
        }

        private void MostrarRespuesta(webServiceResult wsResult)
        {
            txtResultado.Text = wsResult.resultado.ToString();
            if (!string.IsNullOrEmpty(wsResult.codigoTransaccion))
            {
                txtTransaccion.Text = wsResult.codigoTransaccion;
                txtErrores.Text = "¡Transacción Exitosa!" + "\r\n" + "Codigo de Transacción:" + wsResult.codigoTransaccion;

            }
            else
            {
                mostrarErrores(wsResult);
            }
        }

        private void mostrarErrores(webServiceResult wsResult)
        {
            if (wsResult.errores != null)
            {
                foreach (var error in wsResult.errores)
                {
                    if (error.c_error != null)
                    {
                        txtErrores.Text += error.c_error + " - " + error.d_error + "\r\n";
                    }
                    else
                    {
                        txtErrores.Text += error.d_error + "\r\n";
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            txtCufe.Text = "";
            txtErrores.Text = "";
            txtResultado.Text = "";
            txtTransaccion.Text = "";
        }
     
       
        private void txtUser_Leave(object sender, EventArgs e)
        {
            //SendKeys.Send("{TAB}");
            txtPass.Focus();
            txtCufe.Text = txtUser.Text;
        }

       

        


        

        
        
        
        
    }
}
