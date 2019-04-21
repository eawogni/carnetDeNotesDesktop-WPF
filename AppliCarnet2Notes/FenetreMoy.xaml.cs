using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CarnetDeNotes
{
    /// <summary>
    /// Logique d'interaction pour FenetreMoy.xaml
    /// </summary>
    public partial class FenetreMoy : Window
    {
        public FenetreMoy(string bulletin)
        {
            InitializeComponent();
            this.labBulletin.Content = bulletin;



        }

        private void Click_ExportPdf(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true };


            Boolean ouverture =(Boolean) sfd.ShowDialog();
            if (ouverture)
            {
                iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
                try
                {
                    PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                    doc.Open();
                    doc.Add(new iTextSharp.text.Paragraph(this.labBulletin.Content.ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButton.OK);

                }
                finally
                {
                    doc.Close();
                }
            }
        }

        private void Click_ExportCsv(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files (.csv)|.csv";
            sfd.ValidateNames = true;

            Boolean Ouverture =(Boolean) sfd.ShowDialog();
            if (Ouverture)
            {
                FileStream fichier = new FileStream(sfd.FileName, FileMode.Create);
                StreamWriter wr = new StreamWriter(fichier);
                wr.Write(this.labBulletin.Content.ToString());
                wr.Close();
                fichier.Close();
            }
        }
        
    }
}
