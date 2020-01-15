/*
 * Creado por SharpDevelop.
 * Usuario: Juan Carlos
 * Fecha: 06/08/2019
 * Hora: 10:29 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace Contable.Pruebas
{
	/// <summary>
	/// Description of frmPruebaDeImpresion.
	/// </summary>
	public partial class frmPruebaDeImpresion : Form
	{
		//private System.ComponentModel.Container components;
    	//private System.Windows.Forms.Button printButton;
    	private Font printFont;
    	private StreamReader streamToPrint;
		
		public frmPruebaDeImpresion()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void PrintButtonClick(object sender, EventArgs e)
		{
		try
	        {
	            streamToPrint = new StreamReader
	               ("C:\\Users\\Juan Carlos\\Documents\\MyFile.txt");
	            try
	            {
	                
	            	//Create a PrintPreviewDialog object
					PrintPreviewDialog  previewDlg = new PrintPreviewDialog();
	            	
					printFont = new Font("Arial", 10);
	                PrintDocument pd = new PrintDocument();
	                pd.PrintPage += new PrintPageEventHandler
	                   (this.pd_PrintPage);
	                
	                //Set Document property of PrintPreviewDialog
					previewDlg.Document = pd;
					//Display dialog
					previewDlg.Show();
	    
					//pd.Print(); //Lo saco por ahora
	            }
	            finally
	            {
	                streamToPrint.Close();
	            }
	        }
	        catch (Exception ex)
	        {
	            MessageBox.Show(ex.Message);
			}
		}
		
		
		
		
 // The PrintPage event is raised for each page to be printed.
    	private void pd_PrintPage(object sender, PrintPageEventArgs ev)
    {
        float linesPerPage = 0;
        float yPos = 0;
        int count = 0;
        float leftMargin = ev.MarginBounds.Left;
        float topMargin = ev.MarginBounds.Top;
        string line = null;

        // Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height /
           printFont.GetHeight(ev.Graphics);

        // Print each line of the file.
        while (count < linesPerPage &&
           ((line = streamToPrint.ReadLine()) != null))
        {
            yPos = topMargin + (count *
               printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
               leftMargin, yPos, new StringFormat());
            count++;
        }

        // If more lines exist, print another page.
        if (line != null)
            ev.HasMorePages = true;
        else
            ev.HasMorePages = false;
    }
    
    
		void Button1Click(object sender, EventArgs e)
		{
		//Create a PrintPreviewDialog object
		PrintPreviewDialog  previewDlg = new PrintPreviewDialog();
		        
		//Create a PrintDocument object
		PrintDocument pd = new PrintDocument();
		
		//Add print-page event handler
		pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
		
		//Set Document property of PrintPreviewDialog
		previewDlg.Document = pd;
		//Display dialog
		previewDlg.Show();
		}


		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
            {

                Rectangle xrect = new Rectangle(20, 10, 300, 9000);
                e.Graphics.DrawString(textBox1.Text, new Font("Arial", 12), Brushes.Gray, xrect);
             
        }
		
		
	

		public void Juanito()
		{
			
		}
		
		
	}
	
	
	
	
	
	
}



