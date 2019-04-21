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
    /// Logique d'interaction pour FenetreExamen.xaml
    /// </summary>
    public partial class FenetreExamen : Window
    {
        public FenetreExamen(Examen ex)
        {
            InitializeComponent();
            DataContext = ex;
        }

        private void Click_Ajouter(object sender, RoutedEventArgs e)
        {
            
            this.DialogResult = true;

        }
    }
}
