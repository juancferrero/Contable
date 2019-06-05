using Microsoft.VisualBasic;
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
using System.Text; 
 
namespace Contable.ConversorNumALetra
{
	static class Conversor
	{

//Escrito por Juan C Ferrero
//Licencia libre



		public static string ConversorPrincipal(double dblNumero)
		{
			

			string caca = null;
			string Boludo = null;
			int n = 0;
			int x = 0;

			string strDecenas = "";
			string strUnidades = "";
			string strcentenas = "";
			string strDecenasDeMil = "";
			string strUnidadesDeMil = "";
			string strCentenasDeMil = "";
			string strDecenasDeMillon = "";
			string strUnidadesDeMillon = "";
			string strCentenasDeMillon = "";

			string strTexto = "";

			
			if (dblNumero == 0)
			{ 
				return " " ;
			};
			
			
			//Esto determina el la extension del numero
			//El Abs le quita los decimales
			n = Math.Truncate(dblNumero).ToString().Length;


			Boludo = Math.Abs(dblNumero).ToString() ;

			//Esto coloca los valores en cada una de las diferentes unidades
			for (x = 1; x <= n; x++) {
				if (x == 1) {
					strUnidades = Boludo.Substring(n-1, 1);

				} else if (x == 2) {
					strDecenas = Boludo.Substring(n-2, 1);

				} else if (x == 3) {
					strcentenas = Boludo.Substring(n-3, 1);

				} else if (x == 4) {
					strUnidadesDeMil = Boludo.Substring(n-4, 1);

				} else if (x == 5) {
					strDecenasDeMil = Boludo.Substring(n-5, 1);

				} else if (x == 6) {
					strCentenasDeMil = Boludo.Substring(n-6, 1);
					
				} else if (x == 7) {
					strUnidadesDeMillon = Boludo.Substring(n-7, 1);

				} else if (x == 8) {
					strDecenasDeMillon = Boludo.Substring(n-8, 1);

				} else if (x == 9) {
					strCentenasDeMillon = Boludo.Substring(n-9, 1);

				}



			}


			//Esto corrobora que haya allgo en las Centenas de Millon
			if (!string.IsNullOrEmpty(strCentenasDeMillon)) {
				//Esto se fija si son 100 millones
				if (strCentenasDeMillon == "1" & strDecenasDeMillon == "0" & strUnidadesDeMillon == "0") {
					strCentenasDeMillon = "100";
				}
				strTexto = CentenasDeMillon(ref strCentenasDeMillon);
			}

			//Esto corrobora que haya allgo en las Decenas de Millon
			if (!string.IsNullOrEmpty(strDecenasDeMillon)) {
				if (strDecenasDeMillon == "1" & strUnidadesDeMillon == "0") {
					strDecenasDeMillon = "10";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "1" & strUnidadesDeMillon == "1") {
					strDecenasDeMillon = "11";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "1" & strUnidadesDeMillon == "2") {
					strDecenasDeMillon = "12";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "1" & strUnidadesDeMillon == "3") {
					strDecenasDeMillon = "13";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "1" & strUnidadesDeMillon == "4") {
					strDecenasDeMillon = "14";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "1" & strUnidadesDeMillon == "5") {
					strDecenasDeMillon = "15";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "2" & strUnidadesDeMillon == "0") {
					strDecenasDeMillon = "20";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "2" & strUnidadesDeMillon == "1") {
					strDecenasDeMillon = "21";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "2" & strUnidadesDeMillon == "2") {
					strDecenasDeMillon = "22";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "2" & strUnidadesDeMillon == "3") {
					strDecenasDeMillon = "23";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "2" & strUnidadesDeMillon == "4") {
					strDecenasDeMillon = "24";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "2" & strUnidadesDeMillon == "5") {
					strDecenasDeMillon = "25";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "2" & strUnidadesDeMillon == "6") {
					strDecenasDeMillon = "26";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "2" & strUnidadesDeMillon == "7") {
					strDecenasDeMillon = "27";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "2" & strUnidadesDeMillon == "8") {
					strDecenasDeMillon = "28";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "2" & strUnidadesDeMillon == "9") {
					strDecenasDeMillon = "29";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "3" & strUnidadesDeMillon == "0") {
					strDecenasDeMillon = "30";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "4" & strUnidadesDeMillon == "0") {
					strDecenasDeMillon = "40";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "5" & strUnidadesDeMillon == "0") {
					strDecenasDeMillon = "50";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "6" & strUnidadesDeMillon == "0") {
					strDecenasDeMillon = "60";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "7" & strUnidadesDeMillon == "0") {
					strDecenasDeMillon = "70";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "8" & strUnidadesDeMillon == "0") {
					strDecenasDeMillon = "80";
					strUnidadesDeMillon = "";

				} else if (strDecenasDeMillon == "9" & strUnidadesDeMillon == "0") {
					strDecenasDeMillon = "90";
					strUnidadesDeMillon = "";

				}


				strTexto = strTexto + DecenasDeMillon(ref strDecenasDeMillon);
			}

			//Esto corrobora que haya allgo en las Unidades de Millon

			if (!string.IsNullOrEmpty(strUnidadesDeMillon)) {
				caca = strTexto = strTexto + UnidadesDeMillon(ref strUnidadesDeMillon);

			}

			//Esto corrobora que haya allgo en las Centenas de Mil
			if (!string.IsNullOrEmpty(strCentenasDeMil)) {
				//Esto se fija si son 100 millones
				if (strCentenasDeMil == "1" & strDecenasDeMil == "0" & strUnidadesDeMil == "0") {
					strCentenasDeMil = "100";
				}
				strTexto = strTexto + CentenasDeMil(ref strCentenasDeMil);
			}

			//Esto corrobora que haya allgo en las Decenas de Mil
			if (!string.IsNullOrEmpty(strDecenasDeMil)) {
				if (strDecenasDeMil == "1" & strUnidadesDeMil == "0") {
					strDecenasDeMil = "10";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "1" & strUnidadesDeMil == "1") {
					strDecenasDeMil = "11";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "1" & strUnidadesDeMil == "2") {
					strDecenasDeMil = "12";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "1" & strUnidadesDeMil == "3") {
					strDecenasDeMil = "13";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "1" & strUnidadesDeMil == "4") {
					strDecenasDeMil = "14";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "1" & strUnidadesDeMil == "5") {
					strDecenasDeMil = "15";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "2" & strUnidadesDeMil == "0") {
					strDecenasDeMil = "20";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "2" & strUnidadesDeMil == "1") {
					strDecenasDeMil = "21";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "2" & strUnidadesDeMil == "2") {
					strDecenasDeMil = "22";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "2" & strUnidadesDeMil == "3") {
					strDecenasDeMil = "23";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "2" & strUnidadesDeMil == "4") {
					strDecenasDeMil = "24";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "2" & strUnidadesDeMil == "5") {
					strDecenasDeMil = "25";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "2" & strUnidadesDeMil == "6") {
					strDecenasDeMil = "26";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "2" & strUnidadesDeMil == "7") {
					strDecenasDeMil = "27";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "2" & strUnidadesDeMil == "8") {
					strDecenasDeMil = "28";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "2" & strUnidadesDeMil == "9") {
					strDecenasDeMil = "29";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "3" & strUnidadesDeMil == "0") {
					strDecenasDeMil = "30";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "4" & strUnidadesDeMil == "0") {
					strDecenasDeMil = "40";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "5" & strUnidadesDeMil == "0") {
					strDecenasDeMil = "50";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "6" & strUnidadesDeMil == "0") {
					strDecenasDeMil = "60";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "7" & strUnidadesDeMil == "0") {
					strDecenasDeMil = "70";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "8" & strUnidadesDeMil == "0") {
					strDecenasDeMil = "80";
					strUnidadesDeMil = "";

				} else if (strDecenasDeMil == "9" & strUnidadesDeMil == "0") {
					strDecenasDeMil = "90";
					strUnidadesDeMil = "";

				}

				strTexto = strTexto + DecenasDeMil(ref strDecenasDeMil);
			}

			//Esto corrobora que haya allgo en las Unidades de Mil
			if (!string.IsNullOrEmpty(strUnidadesDeMil)) {
				strTexto = strTexto + UnidadesDeMil(ref strUnidadesDeMil);
			}

			//Esto corrobora que haya allgo en las Centenas
			if (!string.IsNullOrEmpty(strcentenas)) {
				//Esto se fija si son 100
				if (strcentenas == "1" & strDecenas == "0" & strUnidades == "0") {
					strcentenas = "100";
				}

				strTexto = strTexto + Centenas(ref strcentenas);
			}

			//Esto corrobora que haya allgo en las Decenas
			if (!string.IsNullOrEmpty(strDecenas)) {
				if (strDecenas == "1" & strUnidades == "0") {
					strDecenas = "10";
					strUnidades = "";

				} else if (strDecenas == "1" & strUnidades == "1") {
					strDecenas = "11";
					strUnidades = "";

				} else if (strDecenas == "1" & strUnidades == "2") {
					strDecenas = "12";
					strUnidades = "";

				} else if (strDecenas == "1" & strUnidades == "3") {
					strDecenas = "13";
					strUnidades = "";

				} else if (strDecenas == "1" & strUnidades == "4") {
					strDecenas = "14";
					strUnidades = "";

				} else if (strDecenas == "1" & strUnidades == "5") {
					strDecenas = "15";
					strUnidades = "";

				} else if (strDecenas == "2" & strUnidades == "0") {
					strDecenas = "20";
					strUnidades = "";

				} else if (strDecenas == "2" & strUnidades == "1") {
					strDecenas = "21";
					strUnidades = "";

				} else if (strDecenas == "2" & strUnidades == "2") {
					strDecenas = "22";
					strUnidades = "";

				} else if (strDecenas == "2" & strUnidades == "3") {
					strDecenas = "23";
					strUnidades = "";

				} else if (strDecenas == "2" & strUnidades == "4") {
					strDecenas = "24";
					strUnidades = "";

				} else if (strDecenas == "2" & strUnidades == "5") {
					strDecenas = "25";
					strUnidades = "";

				} else if (strDecenas == "2" & strUnidades == "6") {
					strDecenas = "26";
					strUnidades = "";

				} else if (strDecenas == "2" & strUnidades == "7") {
					strDecenas = "27";
					strUnidades = "";

				} else if (strDecenas == "2" & strUnidades == "8") {
					strDecenas = "28";
					strUnidades = "";

				} else if (strDecenas == "2" & strUnidades == "9") {
					strDecenas = "29";
					strUnidades = "";

				} else if (strDecenas == "3" & strUnidades == "0") {
					strDecenas = "30";
					strUnidades = "";

				} else if (strDecenas == "4" & strUnidades == "0") {
					strDecenas = "40";
					strUnidades = "";

				} else if (strDecenas == "5" & strUnidades == "0") {
					strDecenas = "50";
					strUnidades = "";

				} else if (strDecenas == "6" & strUnidades == "0") {
					strDecenas = "60";
					strUnidades = "";

				} else if (strDecenas == "7" & strUnidades == "0") {
					strDecenas = "70";
					strUnidades = "";

				} else if (strDecenas == "8" & strUnidades == "0") {
					strDecenas = "80";
					strUnidades = "";

				} else if (strDecenas == "9" & strUnidades == "0") {
					strDecenas = "90";
					strUnidades = "";

				}

				strTexto = strTexto + Decenas(ref strDecenas);
			}

			//Esto corrobora que haya allgo en las Unidades

			if (!string.IsNullOrEmpty(strUnidades)) {
				strTexto = strTexto + Unidades(ref strUnidades);

			}


			
			strTexto = strTexto + Decimales(Convert.ToString(dblNumero).Remove(1, n+1));


			return strTexto;


		}


		private static string Decimales(string caca)
		{

			return "con " + caca + "/100.";

		}


		private static string Unidades(ref string caca)
		{

			if (caca == "1") {
				return "Uno ";
			} else if (caca == "2") {
				return "Dos ";
			} else if (caca == "3") {
				return "Tres ";
			} else if (caca == "4") {
				return "Cuatro ";
			} else if (caca == "5") {
				return "Cinco ";
			} else if (caca == "6") {
				return "Seis ";
			} else if (caca == "7") {
				return "Siete ";
			} else if (caca == "8") {
				return "Ocho ";
			} else if (caca == "9") {
				return "Nueve ";

			} else {
				return "";
			}

		}

		private static string Decenas(ref string caca)
		{

			if (caca == "10") {
				return "Diez ";
			} else if (caca == "20") {
				return "Veinte ";
			} else if (caca == "30") {
				return "Treinta ";
			} else if (caca == "40") {
				return "Cuarenta ";
			} else if (caca == "50") {
				return "Cincuenta ";
			} else if (caca == "60") {
				return "Sesenta ";
			} else if (caca == "70") {
				return "Setenta ";
			} else if (caca == "80") {
				return "Ochenta ";
			} else if (caca == "90") {
				return "Noventa ";

			} else if (caca == "11") {
				return "Once ";
			} else if (caca == "12") {
				return "Doce ";
			} else if (caca == "13") {
				return "Trece ";
			} else if (caca == "14") {
				return "Catorce ";
			} else if (caca == "15") {
				return "Quince ";
			} else if (caca == "1") {
				return "Diez y ";

			} else if (caca == "21") {
				return "Veintiuno ";
			} else if (caca == "22") {
				return "Veintidos ";
			} else if (caca == "23") {
				return "Veintitres ";
			} else if (caca == "24") {
				return "Veinticuatro ";
			} else if (caca == "25") {
				return "Veinticinco ";
			} else if (caca == "26") {
				return "Veintiseis ";
			} else if (caca == "27") {
				return "Veintisiete ";
			} else if (caca == "28") {
				return "Veintiocho ";
			} else if (caca == "29") {
				return "Veintinueve ";

			} else if (caca == "3") {
				return "Treinta y ";

			} else if (caca == "4") {
				return "Cuarenta y ";

			} else if (caca == "5") {
				return "Cincuenta y ";

			} else if (caca == "6") {
				return "Sesenta y ";

			} else if (caca == "7") {
				return "Setenta y ";

			} else if (caca == "8") {
				return "Ochenta y ";

			} else if (caca == "9") {
				return "Noventa y ";

			} else {
				return "";
			}

		}

		private static string Centenas(ref string caca)
		{
			if (caca == "100") {
				return "Cien ";

			} else if (caca == "1") {
				return "Ciento ";
			} else if (caca == "2") {
				return "Doscientos ";
			} else if (caca == "3") {
				return "Trescientos ";
			} else if (caca == "4") {
				return "Cuatrocientos ";
			} else if (caca == "5") {
				return "Quinientos ";
			} else if (caca == "6") {
				return "Seiscientos ";
			} else if (caca == "7") {
				return "Setecientos ";
			} else if (caca == "8") {
				return "Ochocientos ";
			} else if (caca == "9") {
				return "Novecientos ";
			} else {
				return "";
			}

		}


		private static string UnidadesDeMil(ref string caca)
		{

			if (caca == "1") {
				return "Un Mil ";
			} else if (caca == "2") {
				return "Dos Mil ";
			} else if (caca == "3") {
				return "Tres Mil ";
			} else if (caca == "4") {
				return "Cuatro Mil ";
			} else if (caca == "5") {
				return "Cinco Mil ";
			} else if (caca == "6") {
				return "Seis Mil ";
			} else if (caca == "7") {
				return "Siete Mil ";
			} else if (caca == "8") {
				return "Ocho Mil ";
			} else if (caca == "9") {
				return "Nueve Mil ";
			} else {
				return "";
			}

		}

		private static string DecenasDeMil(ref string caca)
		{


			if (caca == "10") {
				return "Diez Mil ";
			} else if (caca == "20") {
				return "Veinte Mil ";
			} else if (caca == "30") {
				return "Treinta Mil ";
			} else if (caca == "40") {
				return "Cuarenta Mil ";
			} else if (caca == "50") {
				return "Cincuenta Mil ";
			} else if (caca == "60") {
				return "Sesenta Mil ";
			} else if (caca == "70") {
				return "Setenta Mil ";
			} else if (caca == "80") {
				return "Ochenta Mil ";
			} else if (caca == "90") {
				return "Noventa Mil ";

			} else if (caca == "11") {
				return "Once Mil ";
			} else if (caca == "12") {
				return "Doce Mil ";
			} else if (caca == "13") {
				return "Trece Mil ";
			} else if (caca == "14") {
				return "Catorce Mil ";
			} else if (caca == "15") {
				return "Quince Mil ";
			} else if (caca == "1") {
				return "Diez y ";

			} else if (caca == "21") {
				return "Veintiun Mil ";
			} else if (caca == "22") {
				return "Veintidos Mil ";
			} else if (caca == "23") {
				return "Veintitres Mil ";
			} else if (caca == "24") {
				return "Veinticuatro Mil ";
			} else if (caca == "25") {
				return "Veinticinco Mil ";
			} else if (caca == "26") {
				return "Veintiseis Mil ";
			} else if (caca == "27") {
				return "Veintisiete Mil ";
			} else if (caca == "28") {
				return "Veintiocho Mil ";
			} else if (caca == "29") {
				return "Veintinueve Mil ";

			} else if (caca == "3") {
				return "Treinta y ";

			} else if (caca == "4") {
				return "Cuarenta y ";

			} else if (caca == "5") {
				return "Cincuenta y ";

			} else if (caca == "6") {
				return "Sesenta y ";

			} else if (caca == "7") {
				return "Setenta y ";

			} else if (caca == "8") {
				return "Ochenta y ";

			} else if (caca == "9") {
				return "Noventa y ";
			} else {
				return "";
			}

		}

		private static string CentenasDeMil(ref string caca)
		{

			if (caca == "100") {
				return "Cien Mil ";

			} else if (caca == "1") {
				return "Ciento ";
			} else if (caca == "2") {
				return "Doscientos ";
			} else if (caca == "3") {
				return "Trescientos ";
			} else if (caca == "4") {
				return "Cuatrocientos ";
			} else if (caca == "5") {
				return "Quinientos ";
			} else if (caca == "6") {
				return "Seiscientos ";
			} else if (caca == "7") {
				return "Setecientos ";
			} else if (caca == "8") {
				return "Ochocientos ";
			} else if (caca == "9") {
				return "Novecientos ";
			} else {
				return "";
			}

		}


		private static string UnidadesDeMillon(ref string caca)
		{


			if (caca == "1") {
				return "Un Millon ";
			} else if (caca == "2") {
				return "Dos Millones ";
			} else if (caca == "3") {
				return "Tres Millones ";
			} else if (caca == "4") {
				return "Cuatro Millones ";
			} else if (caca == "5") {
				return "Cinco Millones ";
			} else if (caca == "6") {
				return "Seis Millones ";
			} else if (caca == "7") {
				return "Siete Millones ";
			} else if (caca == "8") {
				return "Ocho Millones ";
			} else if (caca == "9") {
				return "Nueve Millones ";
			} else {
				return "";
			}

		}

		private static string DecenasDeMillon(ref string caca)
		{

			if (caca == "10") {
				return "Diez Millones ";
			} else if (caca == "20") {
				return "Veinte Millones ";
			} else if (caca == "30") {
				return "Treinta Millones ";
			} else if (caca == "40") {
				return "Cuarenta Millones ";
			} else if (caca == "50") {
				return "Cincuenta Millones ";
			} else if (caca == "60") {
				return "Sesenta Millones ";
			} else if (caca == "70") {
				return "Setenta Millones ";
			} else if (caca == "80") {
				return "Ochenta Millones ";
			} else if (caca == "90") {
				return "Noventa Millones ";

			} else if (caca == "11") {
				return "Once Millones ";
			} else if (caca == "12") {
				return "Doce Millones ";
			} else if (caca == "13") {
				return "Trece Millones ";
			} else if (caca == "14") {
				return "Catorce Millones ";
			} else if (caca == "15") {
				return "Quince Millones ";
			} else if (caca == "1") {
				return "Diez y ";

			} else if (caca == "21") {
				return "Veintiun Millones ";
			} else if (caca == "22") {
				return "Veintidos Millones ";
			} else if (caca == "23") {
				return "Veintitres Millones ";
			} else if (caca == "24") {
				return "Veinticuatro Millones ";
			} else if (caca == "25") {
				return "Veinticinco Millones ";
			} else if (caca == "26") {
				return "Veintiseis Millones ";
			} else if (caca == "27") {
				return "Veintisiete Millones ";
			} else if (caca == "28") {
				return "Veintiocho Millones ";
			} else if (caca == "29") {
				return "Veintinueve Millones ";

			} else if (caca == "3") {
				return "Treinta y ";

			} else if (caca == "4") {
				return "Cuarenta y ";

			} else if (caca == "5") {
				return "Cincuenta y ";

			} else if (caca == "6") {
				return "Sesenta y ";

			} else if (caca == "7") {
				return "Setenta y ";

			} else if (caca == "8") {
				return "Ochenta y ";

			} else if (caca == "9") {
				return "Noventa y ";
			} else {
				return "";
			}

		}

		private static string CentenasDeMillon(ref string caca)
		{

			if (caca == "100") {
				return "Cien Millones ";

			} else if (caca == "1") {
				return "Ciento ";
			} else if (caca == "2") {
				return "Doscientos ";
			} else if (caca == "3") {
				return "Trescientos ";
			} else if (caca == "4") {
				return "Cuatrocientos ";
			} else if (caca == "5") {
				return "Quinientos ";
			} else if (caca == "6") {
				return "Seiscientos ";
			} else if (caca == "7") {
				return "Setecientos ";
			} else if (caca == "8") {
				return "Ochocientos ";
			} else if (caca == "9") {
				return "Novecientos ";
			} else {
				return "";
			}

		}


	}
}
