/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 21/05/2014
 * Hora: 06:58 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms; 
using System.Drawing;
//using System.Diagnostics;
using System.Drawing.Printing;

namespace CodigoDeBarras
{
	/// <summary>
	/// Este modulo genera los distitos tipos de codigos de barras.
	/// </summary>
	public class CodigoBarras
	{
		public CodigoBarras()
		{
		}
	
	#region Codigo viejo-Revisar
	
		/*
		
		private static string EAN2Bin(string strEANCode)
		{
			//Author: Zunnair 

			int K = 0;
			string strAux = null;
			string strExit = null;
			string strCode = "";
			strEANCode = Strings.Trim(strEANCode);
			strAux = strEANCode;
			if ((strAux.Length != 13) & (strAux.Length != 8)) {
				Err().Raise(5, "EAN2Bin", "Invalid EAN Code");
			}
			for (K = 0; K <= strEANCode.Length - 1; K++) {
				switch ((strAux[K].ToString())) {
					case  // ERROR: Case labels with binary operators are unsupported : LessThan
"0":
					case  // ERROR: Case labels with binary operators are unsupported : GreaterThan
"9":
						Err().Raise(5, "EAN2Bin", "Invalid char on EAN Code");
						break;
				}
			}
			if ((strAux.Length == 13)) {
				strAux = Strings.Mid(strAux, 2);
				switch (Convert.ToInt32(Strings.Left(strEANCode, 1))) {
					case 0:
						strCode = "000000";
						break;
					case 1:
						strCode = "001011";
						break;
					case 2:
						strCode = "001101";
						break;
					case 3:
						strCode = "001110";
						break;
					case 4:
						strCode = "010011";
						break;
					case 5:
						strCode = "011001";
						break;
					case 6:
						strCode = "011100";
						break;
					case 7:
						strCode = "010101";
						break;
					case 8:
						strCode = "010110";
						break;
					case 9:
						strCode = "011010";
						break;
				}
			} else {
				strCode = "0000";
			}
			//* The EAN BarCode starts with a "guardian"
			strExit = "000101";
			//* First half of the code
			for (K = 1; K <= Strings.Len(strAux) / 2; K++) {
				switch (Convert.ToInt32(Strings.Mid(strAux, K, 1))) {
					case 0:
						strExit += (Strings.Mid(strCode, K, 1) == "0" ? "0001101" : "0100111");
						break;
					case 1:
						strExit += (Strings.Mid(strCode, K, 1) == "0" ? "0011001" : "0110011");
						break;
					case 2:
						strExit += (Strings.Mid(strCode, K, 1) == "0" ? "0010011" : "0011011");
						break;
					case 3:
						strExit += (Strings.Mid(strCode, K, 1) == "0" ? "0111101" : "0100001");
						break;
					case 4:
						strExit += (Strings.Mid(strCode, K, 1) == "0" ? "0100011" : "0011101");
						break;
					case 5:
						strExit += (Strings.Mid(strCode, K, 1) == "0" ? "0110001" : "0111001");
						break;
					case 6:
						strExit += (Strings.Mid(strCode, K, 1) == "0" ? "0101111" : "0000101");
						break;
					case 7:
						strExit += (Strings.Mid(strCode, K, 1) == "0" ? "0111011" : "0010001");
						break;
					case 8:
						strExit += (Strings.Mid(strCode, K, 1) == "0" ? "0110111" : "0001001");
						break;
					case 9:
						strExit += (Strings.Mid(strCode, K, 1) == "0" ? "0001011" : "0010111");
						break;
				}
			}
			//* Middle "guardian" separator
			strExit += "01010";
			//* Second half of the code
			for (K = Strings.Len(strAux) / 2 + 1; K <= Strings.Len(strAux); K++) {
				switch (Convert.ToInt32(Strings.Mid(strAux, K, 1))) {
					case 0:
						strExit += "1110010";
						break;
					case 1:
						strExit += "1100110";
						break;
					case 2:
						strExit += "1101100";
						break;
					case 3:
						strExit += "1000010";
						break;
					case 4:
						strExit += "1011100";
						break;
					case 5:
						strExit += "1001110";
						break;
					case 6:
						strExit += "1010000";
						break;
					case 7:
						strExit += "1000100";
						break;
					case 8:
						strExit += "1001000";
						break;
					case 9:
						strExit += "1110100";
						break;
				}
			}
			strExit += "101000";
			return strExit;
		}
		//Codigo EAN2

		private static string I20F5Bin(string strI20F5Code)
		{
			//Author: Zunnair 

			int K = 0;
			string strAux = null;
			//Auxiliar
			string strExit = null;
			//Codigo de salida en binario
			string strCode = "";
			//Codigo original
			//Esto quita los espacios finales e iniciales
			strI20F5Code = Strings.Trim(strI20F5Code);

			strAux = strI20F5Code;

			for (K = 0; K <= strI20F5Code.Length - 1; K++) {
				//Este case controla que solo sean numeros
				switch ((strAux[K].ToString())) {
					case  // ERROR: Case labels with binary operators are unsupported : LessThan
"0":
					case  // ERROR: Case labels with binary operators are unsupported : GreaterThan
"9":
						Err().Raise(5, "EAN2Bin", "Invalid char on EAN Code");
						break;
				}
			}



			strExit = "1010";

			//Divide al nuemro a la mitad para tratar de a dos unidades
			for (K = 1; K <= Strings.Len(strAux) / 2; K++) {

				switch (Convert.ToString(Strings.Mid(strAux, K, 2))) {
					case "00":
						//NnNnWwWwNn
						strExit += "10101100110010";
						break;
					case "01":
						//NwNnWnWnNw
						strExit += "10010110110100";

						break;
					case "02":
						//NnNwWnWnNw
						strExit += "10100110110100";
						break;
					case "03":
						//NwNwWnWnNn
						strExit += "10010011011010";
						break;
					case "04":
						//NnNnWwWnNw
						strExit += "10101100110100";
						break;
					case "05":
						//NwNnWwWnNn
						strExit += "10010110011010";
						break;
					case "06":
						//NnNwWwWnNn
						strExit += "10100110011010";
						break;
					case "07":
						//NnNnWnWwNw
						strExit += "10101101100100";
						break;
					case "08":
						//NwNnWnWwNn
						strExit += "10010110110010";
						break;
					case "09":
						//NnNwWnWwNn
						strExit += "10100110110010";

						break;



					case "10":
						//WnNnNwNwWn
						strExit += "11010100100110";
						break;
					case "11":
						//WwNnNnNnWw
						strExit += "11001010101100";
						break;
					case "12":
						//WnNwNnNnWw
						strExit += "11010010101100";
						break;
					case "13":
						//WwNwNnNnWn
						strExit += "11001001010110";
						break;
					case "14":
						//WnNnNwNnWw
						strExit += "11010100101100";
						break;
					case "15":
						//WwNnNwNnWn
						strExit += "11001010010110";
						break;
					case "16":
						//WnNwNwNnWn
						strExit += "11010010010110";
						break;
					case "17":
						//WnNnNnNwWw
						strExit += "11010101001100";
						break;
					case "18":
						//WwNnNnNwWn
						strExit += "11001010100110";
						break;
					case "19":
						//WnNwNnNwWn
						strExit += "11010010100110";

						break;

					case "20":
						//NnWnNwNwWn
						strExit += "10110100100110";
						break;
					case "21":
						//NwWnNnNnWw
						strExit += "10011010101100";
						break;
					case "22":
						//NnWwNnNnWw
						strExit += "10110010101100";
						break;
					case "23":
						//NwWwNnNnWn
						strExit += "10011001010110";
						break;
					case "24":
						//NnWnNwNnWw
						strExit += "10110100101100";
						break;
					case "25":
						//NwWnNwNnWn
						strExit += "10011010010110";
						break;
					case "26":
						//NnWwNwNnWn
						strExit += "10110010010110";
						break;
					case "27":
						//NnWnNnNwWw
						strExit += "10110101001100";
						break;
					case "28":
						//NwWnNnNwWn
						strExit += "10011010100110";
						break;
					case "29":
						//NnWwNnNwWn
						strExit += "10110010100110";

						break;


					case "30":
						//WnWnNwNwNn
						strExit += "11011010010010";
						break;
					case "31":
						//WwWnNnNnNw
						strExit += "11001101010100";
						break;
					case "32":
						//WnWwNnNnNw
						strExit += "11011001010100";
						break;
					case "33":
						//WwWwNnNnNn
						strExit += "11001100101010";
						break;
					case "34":
						//WnWnNwNnNw
						strExit += "11011010010100";
						break;
					case "35":
						//WwWnNwNnNn
						strExit += "11001101001010";
						break;
					case "36":
						//WnWwNwNnNn
						strExit += "11011001001010";
						break;
					case "37":
						//WnWnNnNwNw
						strExit += "11011010100100";
						break;
					case "38":
						//WwWnNnNwNn
						strExit += "11001101010010";
						break;
					case "39":
						//WnWwNnNwNn
						strExit += "11011001010010";

						break;


					case "40":
						//NnNnWwNwWn
						strExit += "10101100100110";
						break;
					case "41":
						//NwNnWnNnWw
						strExit += "10010110101100";
						break;
					case "42":
						//NnNwWnNnWw
						strExit += "10100110101100";
						break;
					case "43":
						//NwNwWnNnWn
						strExit += "10010011010110";
						break;
					case "44":
						//NnNnWwNnWw
						strExit += "10101100101100";
						break;
					case "45":
						//NwNnWwNnWn
						strExit += "10010110010110";
						break;
					case "46":
						//NnNwWwNnWn
						strExit += "10100110010110";
						break;
					case "47":
						//NnNnWnNwWw
						strExit += "10101101001100";
						break;
					case "48":
						//NwNnWnNwWn
						strExit += "10010110100110";
						break;
					case "49":
						//NnNwWnNwWn
						strExit += "10100110100110";

						break;


					case "50":
						//WnNnWwNwNn
						strExit += "11010110010010";
						break;
					case "51":
						//WwNnWnNnNw
						strExit += "11001011010100";
						break;
					case "52":
						//WnNwWnNnNw
						strExit += "11010011010100";
						break;
					case "53":
						//WwNwWnNnNn
						strExit += "11001001101010";
						break;
					case "54":
						//WnNnWwNnNw
						strExit += "11010110010100";
						break;
					case "55":
						//WwNnWwNnNn
						strExit += "11001011001010";
						break;
					case "56":
						//WnNwWwNnNn
						strExit += "11010011001010";
						break;
					case "57":
						//WnNnWnNwNw
						strExit += "11010110100100";
						break;
					case "58":
						//WwNnWnNwNn
						strExit += "11001011010010";
						break;
					case "59":
						//WnNwWnNwNn
						strExit += "11010011010010";

						break;


					case "60":
						//NnWnWwNwNn
						strExit += "10110110010010";
						break;
					case "61":
						//NwWnWnNnNw
						strExit += "10011011010100";
						break;
					case "62":
						//NnWwWnNnNw
						strExit += "10110011010100";
						break;
					case "63":
						//NwWwWnNnNn
						strExit += "10011001101010";
						break;
					case "64":
						//NnWnWwNnNw
						strExit += "10110110010100";
						break;
					case "65":
						//NwWnWwNnNn
						strExit += "10011011001010";
						break;
					case "66":
						//NnWwWwNnNn
						strExit += "10110011001010";
						break;
					case "67":
						//NnWnWnNwNw
						strExit += "10110110100100";
						break;
					case "68":
						//NwWnWnNwNn
						strExit += "10011011010010";
						break;
					case "69":
						//NnWwWnNwNn
						strExit += "10110011010010";

						break;


					case "70":
						//NnNnNwWwWn
						strExit += "10101001100110";
						break;
					case "71":
						//NwNnNnWnWw
						strExit += "10010101101100";
						break;
					case "72":
						//NnNwNnWnWw
						strExit += "10100101101100";
						break;
					case "73":
						//NwNwNnWnWn
						strExit += "10010010110110";
						break;
					case "74":
						//NnNnNwWnWw
						strExit += "10101001101100";
						break;
					case "75":
						//NwNnNwWnWn
						strExit += "10010100110110";
						break;
					case "76":
						//NnNwNwWnWn
						strExit += "10100100110110";
						break;
					case "77":
						//NnNnNnWwWw
						strExit += "10101011001100";
						break;
					case "78":
						//NwNnNnWwWn
						strExit += "10010101100110";
						break;
					case "79":
						//NnNwNnWwWn
						strExit += "10100101100110";

						break;


					case "80":
						//WnNnNwWwNn
						strExit += "11010100110010";
						break;
					case "81":
						//WwNnNnWnNw
						strExit += "11001010110100";
						break;
					case "82":
						//WnNwNnWnNw
						strExit += "11010010110100";
						break;
					case "83":
						//WwNwNnWnNn
						strExit += "11001001011010";
						break;
					case "84":
						//WnNnNwWnNw
						strExit += "11010100110100";
						break;
					case "85":
						//WwNnNwWnNn
						strExit += "11001010011010";
						break;
					case "86":
						//WnNwNwWnNn
						strExit += "11010010011010";
						break;
					case "87":
						//WnNnNnWwNw
						strExit += "11010101100100";
						break;
					case "88":
						//WwNnNnWwNn
						strExit += "11001010110010";
						break;
					case "89":
						//WnNwNnWwNn
						strExit += "11010010110010";

						break;

					case "90":
						//NnWnNwWwNn
						strExit += "10110100110010";
						break;
					case "91":
						//NwWnNnWnNw
						strExit += "10011010110100";
						break;
					case "92":
						//NnWwNnWnNw
						strExit += "10110010110100";
						break;
					case "93":
						//NwWwNnWnNn
						strExit += "10011001011010";
						break;
					case "94":
						//NnWnNwWnNw
						strExit += "10110100110100";
						break;
					case "95":
						//NwWnNwWnNn
						strExit += "10011010011010";
						break;
					case "96":
						//NnWwNwWnNn
						strExit += "10110010011010";
						break;
					case "97":
						//NnWnNnWwNw
						strExit += "10110101100100";
						break;
					case "98":
						//NwWnNnWwNn
						strExit += "10011010110010";
						break;
					case "99":
						//NnWwNnWwNn
						strExit += "10110010110010";

						break;
				}

			}



			strExit += "1101";

			return strExit;

			//Empieza con Negros
			//Number     Pattern
			//0          NNWWN
			//1          WNNNW
			//2          NWNNW
			//3          WWNNN
			//4          NNWNW
			//5          WNWNN
			//6          NWWNN
			//7          NNNWW
			//8          WNNWN
			//9          NWNWN



		}
		//Codigo Interleaved 2 Of 5


		//As System.IO.MemoryStream
		public static void PrintBarCode(string strCode, PictureBox objPicBox, float sngX1 = (-1), float sngY1 = (-1), float sngX2 = (-1), float sngY2 = (-1), float sngScaleX = 1, string strType = "I20F5", Font FontForText = null)
		{

			//Codigo inicial: Zunnair 
			//Correcciones: Sandman

			float K = 0;
			float sngPosX = 0;
			float sngPosY = 0;

			string strBin = "";
			StringFormat strFormat = new StringFormat();

			//Este Case es para ir agregando todas las codificaciones de codigos de barras
			//La idea es que las barras gruesas se formen por barras finas
			//0 representa barra blanca, 1 barra negra
			switch (strType) {

				case "EAN2":
					strBin = EAN2Bin(strCode);
					break;
				case "I20F5":
					//Interleaved 2 of 5
					strBin = I20F5Bin(strCode);

					break;
			}

			if ((FontForText == null)) {
				FontForText = new Font("Courier New", 10);
			}
			if (sngX1 == (-1))
				sngX1 = 0;
			if (sngY1 == (-1))
				sngY1 = 0;
			if (sngX2 == (-1))
				sngX2 = objPicBox.Width;
			if (sngY2 == (-1))
				sngY2 = objPicBox.Height;
			sngPosX = sngX1;
			sngPosY = sngY2 - Convert.ToSingle(1.5 * FontForText.Height);

			//objPicBox.CreateGraphics.FillRectangle(New System.Drawing.SolidBrush(objPicBox.BackColor.White), sngX1, sngY1, sngX2 - sngX1, sngY2 - sngY1) ' VIEJO
			objPicBox.CreateGraphics().FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), sngX1, sngY1, sngX2 - sngX1, sngY2 - sngY1);
			for (K = 1; K <= Strings.Len(strBin); K++) {
				if (Strings.Mid(strBin, K, 1) == "1") {
					//objPicBox.CreateGraphics.FillRectangle(New System.Drawing.SolidBrush(objPicBox.ForeColor.Black), sngPosX, sngY1, sngScaleX, sngPosY) 'VIEJO
					objPicBox.CreateGraphics().FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), sngPosX, sngY1, sngScaleX, sngPosY);
				}
				sngPosX = sngX1 + (K * sngScaleX);
			}
			strFormat.Alignment = StringAlignment.Center;
			strFormat.FormatFlags = StringFormatFlags.NoWrap;

			//objPicBox.CreateGraphics.DrawString(strCode, FontForText, New System.Drawing.SolidBrush(objPicBox.ForeColor.Red), CSng((sngX2 - sngX1) / 2), CSng(sngY2 - FontForText.Height), strFormat)'VIEJO
			objPicBox.CreateGraphics().DrawString(strCode, FontForText, new System.Drawing.SolidBrush(System.Drawing.Color.Black), Convert.ToSingle((sngX2 - sngX1) / 2), Convert.ToSingle(sngY2 - FontForText.Height), strFormat);



			//Dim buffermemoria As New System.IO.MemoryStream
			//Dim formato As System.Drawing.Imaging.ImageFormat


			//        formato = New System.Drawing.Imaging.ImageFormat(System.Guid.NewGuid)

			//Return objPicBox.Image.

			//       Return objPicBox.Image.Save(buffermemoria, formato.Jpeg)
			//Return New System.IO.MemoryStream(objPicBox)
		}
		//Funcion publica para imprimir un bar code basandose en 0 y 1 (lineas chicas)

		//As System.IO.MemoryStream
		public static void PrintBarCode2(string strCode, PictureBox objPicBox, float sngX1 = (-1), float sngY1 = (-1), float sngX2 = (-1), float sngY2 = (-1), float sngScaleX = 1, string strType = "I20F5", Font FontForText = null)
		{

			//Codigo inicial: Zunnair 
			//Correcciones: Sandman

			float K = 0;
			float sngPosX = 0;
			float sngPosY = 0;

			string strBin = "";
			StringFormat strFormat = new StringFormat();

			//Este Case es para ir agregando todas las codificaciones de codigos de barras
			//La idea es que las barras gruesas se formen por barras finas
			//0 representa barra blanca, 1 barra negra
			switch (strType) {

				case "EAN2":
					strBin = EAN2Bin(strCode);
					break;
				case "I20F5":
					//Interleaved 2 of 5
					strBin = I20F5Bin(strCode);

					break;
			}

			if ((FontForText == null)) {
				FontForText = new Font("Courier New", 10);
			}
			if (sngX1 == (-1))
				sngX1 = 0;
			if (sngY1 == (-1))
				sngY1 = 0;
			if (sngX2 == (-1))
				sngX2 = objPicBox.Width;
			if (sngY2 == (-1))
				sngY2 = objPicBox.Height;
			sngPosX = sngX1;
			sngPosY = sngY2 - Convert.ToSingle(1.5 * FontForText.Height);

			//objPicBox.CreateGraphics.FillRectangle(New System.Drawing.SolidBrush(objPicBox.BackColor.White), sngX1, sngY1, sngX2 - sngX1, sngY2 - sngY1) ' VIEJO
			objPicBox.CreateGraphics().FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), sngX1, sngY1, sngX2 - sngX1, sngY2 - sngY1);
			for (K = 1; K <= Strings.Len(strBin); K++) {
				if (Strings.Mid(strBin, K, 1) == "1") {
					//objPicBox.CreateGraphics.FillRectangle(New System.Drawing.SolidBrush(objPicBox.ForeColor.Black), sngPosX, sngY1, sngScaleX, sngPosY) 'VIEJO
					objPicBox.CreateGraphics().FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), sngPosX, sngY1, sngScaleX, sngPosY);
				}
				sngPosX = sngX1 + (K * sngScaleX);
			}
			strFormat.Alignment = StringAlignment.Center;
			strFormat.FormatFlags = StringFormatFlags.NoWrap;

			//objPicBox.CreateGraphics.DrawString(strCode, FontForText, New System.Drawing.SolidBrush(objPicBox.ForeColor.Red), CSng((sngX2 - sngX1) / 2), CSng(sngY2 - FontForText.Height), strFormat)'VIEJO
			objPicBox.CreateGraphics().DrawString(strCode, FontForText, new System.Drawing.SolidBrush(System.Drawing.Color.Black), Convert.ToSingle((sngX2 - sngX1) / 2), Convert.ToSingle(sngY2 - FontForText.Height), strFormat);




			//Dim buffermemoria As New System.IO.MemoryStream
			//Dim formato As System.Drawing.Imaging.ImageFormat


			//        formato = New System.Drawing.Imaging.ImageFormat(System.Guid.NewGuid)

			//Return objPicBox.Image.

			//       Return objPicBox.Image.Save(buffermemoria, formato.Jpeg)
			//Return New System.IO.MemoryStream(objPicBox)
		}


		//'Esta zona funciona correcto
*/

#endregion



		public static Bitmap Print2of5Interleaved(string Content)
		{
			
			/// <summary>
			/// Imprime el codigo de barras en un picturebox
			/// </summary>
			/// <param name="Content">
			/// Es el contenido a dibujar
			/// </param>
			/// <returns></returns>
			
			//Bitmap
			//by RedneckProgrammer Web(Developer)
			//Mejorado por Juanqui

			//Dim Content As String = "12345678"
			string CheckSum = CalcCheckSum(Content);
			string startcode = "1010";
			string stopcode = "1101";
			int startX = 0;
			int startY = 0;
			int endY = startY + 40;
			int curX = 0;
			int sectionIndex = 0;
			int pairIndex = 0;
			int barIndex = 0;
			int spaceIndex = 0;

			Graphics g = null;
			Bitmap bmp = new Bitmap(10000, 5000);
			g = Graphics.FromImage(bmp);

			curX = startX;
			//Si le quisiera agregar el CheckSum lo haria quitando este comentario
			//Content = Content & CheckSum

			if ((Content.Length % 2) != 0) {
				//[ENG] Odd number, fill in a leading zero
				//[ESp] Numero Impar, completa aggregando un zero al inicio
				Content = "0" + Content;
			}

			//[ENG] Draw the start marker
			//[ESp] Dibujar el marcador inicial
			foreach (char digit in startcode) {
				if (digit == '1') {
					g.DrawLine(Pens.Black, curX, startY, curX, endY);
					curX += 1;
				} else {
					curX += 1;
				}
			}

			//[ENG] Draw the content
			//[ESP] Dibujarl el contenido
			for (int i = 0; i <= Content.Length - 1; i += 2) {
				string pair = Content.Substring(i, 2);
				string barPattern = Get2of5Pattern(pair.Substring(0, 1));
				string spacePattern = Get2of5Pattern(pair.Substring(1, 1));
				barIndex = 0;
				spaceIndex = 0;
				sectionIndex = 0;
				while (sectionIndex < 10) {
					if ((sectionIndex % 2) == 0) {
						//bar 0,2,4,6,8 positions
						pairIndex = 0;
						if (barPattern.Substring(barIndex, 1) == "W") {
							//draw wide bar
							while (pairIndex < 2) {
								g.DrawLine(Pens.Black, curX + pairIndex, startY, curX + pairIndex, endY);
								pairIndex += 1;
							}
							curX = curX + 2;
						} else {
							//draw narrow bar
							g.DrawLine(Pens.Black, curX + pairIndex, startY, curX + pairIndex, endY);
							curX = curX + 1;
						}
						barIndex += 1;
					} else {
						//space 1,3,5,7,8 positions
						if (spacePattern.Substring(spaceIndex, 1) == "W") {
							//simulate drawing a wide white space
							curX = curX + 2;
						} else {
							//simulate drawing a narrow white space
							curX = curX + 1;
						}
						spaceIndex += 1;
					}
					sectionIndex += 1;
				}
			}

			//[ENG] Draw the stop marker
			//[ESP] Dibujar el marcador de finalización
			foreach (char digit in stopcode) {
				if (digit == '1') {
					g.DrawLine(Pens.Black, curX, startY, curX, endY);
					curX += 1;
				} else {
					curX += 1;
				}
			}

			//[ENG] Return the Image
			//[ESP] Retornar la Imagen
			return bmp;

		}

		public static string CalcCheckSum(string CheckNum)
		{
			/// <summary>
			/// Es el CheckSum para el Interleaved 2 5
			/// </summary>
			/// <param name="CheckNum">
			/// Es el numero que ingresa para sacar el checksum
			/// </param>
			/// <returns>
			/// Devuelve el el CheckSum de Interleaved
			/// </returns>
			
			//by RedneckProgrammer Web(Developer)
			//Comentado por SandMan (2014)

			//Variables
			int i = 0;
			int j = 0;
			int checkval = 0;

			j = 3;
			//[ESP] Obtiene el largo (menos uno) de la variable
			i = CheckNum.Length - 1;

			while (i > 0) {
				checkval += Convert.ToInt32(CheckNum.Substring(i, 1)) * j;
				j = j ^ 2;
				i -= 1;
			}
			checkval = (10 - (checkval % 10)) % 10;
			return checkval.ToString();
		}
		
		public static string Get2of5Pattern(string letter)
		{
		///<summary>
		///Obtiene el codigo a esquematizar
		///</summary>

			//by RedneckProgrammer Web(Developer)
			//Mejorado por Sandman (2014)

			string tmpPattern = "";
			switch (letter) {
				case "0":
					tmpPattern = "NNWWN";
					break;
				case "1":
					tmpPattern = "WNNNW";
					break;
				case "2":
					tmpPattern = "NWNNW";
					break;
				case "3":
					tmpPattern = "WWNNN";
					break;
				case "4":
					tmpPattern = "NNWNW";
					break;
				case "5":
					tmpPattern = "WNWNN";
					break;
				case "6":
					tmpPattern = "NWWNN";
					break;
				case "7":
					tmpPattern = "NNNWW";
					break;
				case "8":
					tmpPattern = "WNNWN";
					break;
				case "9":
					tmpPattern = "NWNWN";
					break;
			}
			return tmpPattern;
		}
	
/// <summary>
/// Esta funcion genera un digito verificador
/// En este programa se usa para armar el codigo de barras de los documentos fiscales
/// Se coloca al final de numero general para la formacion del codigo de barras
/// </summary>
/// <param name="Cod_Barras">String con el valor de lo que hay que poner el codigo verificador</param>
/// <returns></returns>
		public static int CodVerificador(string Cod_Barras)
		{
/*
RUTINA PARA EL CALCULO DEL DIGITO VERIFICADOR
Se considera para efectuar el cálculo el siguiente ejemplo:
01234567890

Etapa 1: Comenzar desde la izquierda, sumar todos los caracteres ubicados en las posiciones impares.
0 + 2 + 4 + 6 + 8 + 0 = 20
Etapa 2: Multiplicar la suma obtenida en la etapa 1 por el número 3.
20 x 3 = 60
Etapa 3: Comenzar desde la izquierda, sumar todos los caracteres que están ubicados en las posiciones pares.
1 + 3 + 5+ 7 + 9 = 25
Etapa 4: Sumar los resultados obtenidos en las etapas 2 y 3.
60 + 25 = 85
Etapa 5: Buscar el menor número que sumado al resultado obtenido en la etapa 4 dé un número múltiplo de 10. 
Este será el valor del dígito verificador del módulo 10.
85 + 5 = 90
De esta manera se llega a que el número 5 es el dígito verificador módulo 10 para el código 01234567890
Siendo el resultado final:
012345678905
*/

#region Variables

			int functionReturnValue = 0;
			int n = 0;
			Int16 impares = 0;
			Int16 pares = 0;
			
			int valortotal;
#endregion





			//Toma el total del valor de la cadena que entra y hace lo sigiente:
			for (n = 1; n <= Cod_Barras.Length; n++) {

//Etapa 1 y 3
				//Pares
				if (n % 2 == 0) {
					pares += Convert.ToInt16(Cod_Barras.Substring(n - 1, 1));
				//Impares
				} else {
					impares += Convert.ToInt16(Cod_Barras.Substring(n - 1, 1));
				}
			}
//Etapa 2
			//Multiplico por 3 el valor de los impares
			impares *= 3;

//Etapa 4
			//Sumo en la variable de la funcion los valores Pares e Impares
			functionReturnValue = pares + impares;

			valortotal = functionReturnValue;
			
//Etapa 5
			for (n = 1; n <= Convert.ToUInt32(valortotal / 10) + 2; n++) {
				if (functionReturnValue > 0) {
					functionReturnValue = functionReturnValue - 10;
				} else {
					//System.Math.Abs devuelve el valor absoluto de numero que se coloque
					functionReturnValue = System.Math.Abs(functionReturnValue);//ver si esta bien
					
				}
			}
			return functionReturnValue;




		}
	
	
	}
}
