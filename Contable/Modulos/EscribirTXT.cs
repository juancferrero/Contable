/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 31/03/2016
 * Hora: 09:14 a.m.
 * 
 * La idea de este modulo es la de gestionar archivos de texto para poder informar a la AFIP todos los movimientos de 
 * la empresa.
 * 
 */
using System;

namespace Contable.Modulos
{
	/// <summary>
	/// Esta clase permite escribir en archivos TXT.
	/// Son una forma sencilla del manejo de archivos
	/// Todo lo que esta aca fue copiado del MSN como ejemplos y luego modificado por Juan C Ferrero para 
	/// manejar dichos archivos.
	/// </summary>
	public class EscribirTXT
	{
		
		public static string[] lines = { "First line", "Second line", "Third line" };
		
		public EscribirTXT()
		{			
		}
		
		/// <summary>
		/// ESP: Crea un array de tres lineas
		/// 
		/// ENG: Create a string array that consists of three lines.
		/// </summary>
		public static void EscribirUnArray()
		{
			
	        // WriteAllLines creates a file, writes a collection of strings to the file,
	        // and then closes the file.  You do NOT need to call Flush() or Close().
	        System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);
		}
		
		
		/// <summary>
		/// ESP: Escirbe un string en el archivo de texto
		/// 
		/// ENG:Write one string to a text file.
		/// </summary>
		/// <returns>
		/// Archivo con un texto
		/// </returns>
		public static void EscribirUnaLinea()
		{
		string text = "A class is the most powerful data type in C#. Like a structure, " +
                       "a class defines the data and behavior of the data type. ";
        // WriteAllText creates a file, writes the specified string to the file,
        // and then closes the file.    You do NOT need to call Flush() or Close().
        System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", text);
		}
		
		
		/// <summary>
		/// 
		/// ENG: Write only some strings in an array to a file.
        // The using statement automatically flushes AND CLOSES the stream and calls 
        // IDisposable.Dispose on the stream object.
        // NOTE: do not use FileStream for text files because it writes bytes, but StreamWriter
        // encodes the output as text.
		/// </summary>
		public static void EscribirAlgunTexto()
		{
		using (System.IO.StreamWriter file = 
            new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt"))
        	{
	            foreach (string line in lines)
	            {
	                // If the line doesn't contain the word 'Second', write the line to the file.
	                if (!line.Contains("Second"))
	                {
	                    file.WriteLine(line);
	                }
	            }
	        }
		}
		
		/// <summary>
		/// 
		/// 
		/// ENG:Append new text to an existing file.
        // The using statement automatically flushes AND CLOSES the stream and calls 
        // IDisposable.Dispose on the stream object.
		/// </summary>
		public static void EscribirAgregarTexto()
		{
		 using (System.IO.StreamWriter file = 
            new System.IO.StreamWriter(@"C:\Users\Public\TestFolder\WriteLines2.txt", true))
        {
            file.WriteLine("Fourth line");
        }
		}
	}
}


