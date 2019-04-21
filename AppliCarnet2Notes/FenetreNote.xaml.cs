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
using System.Runtime.Serialization;

namespace CarnetDeNotes
{
    /// <summary>
    /// Logique d'interaction pour FenetreNote.xaml
    /// </summary>
    public partial class FenetreNote : Window
    {
        private Note note;
        public FenetreNote(Note n)
        {
            InitializeComponent();
            DataContext = n;
            note = n;
        }

      

        private void Click_Valider(object sender, RoutedEventArgs e)
        {
            this.note.Absent = (bool)this.CheckAbsense.IsChecked;
            this.DialogResult = true;
        }
    }
}
