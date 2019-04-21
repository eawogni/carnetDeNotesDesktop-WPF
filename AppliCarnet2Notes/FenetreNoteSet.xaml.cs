using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour FenetreNoteSet.xaml
    /// </summary>
    public partial class FenetreNoteSet : Window
    {
        private Note note;
        public FenetreNoteSet(Note n)
        {
            InitializeComponent();
            DataContext = n;
            this.note = n;
        }

       

        private void Click_Valider(object sender, RoutedEventArgs e)
        {
            this.note.Absent = (bool)this.CheckAbsence.IsChecked ;
            this.DialogResult = true;
        }
    }
}
