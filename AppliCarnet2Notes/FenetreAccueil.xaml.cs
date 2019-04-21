using CarnetDeNotes;
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

namespace AppliCarnet2Notes
{
    /// <summary>
    /// Logique d'interaction pour FenetreAccueil.xaml
    /// </summary>
    public partial class FenetreAccueil : Window
    {
        private Carnet carnet;
        private CollectionCarnet col;
        public Carnet Carnet
        {
            get { return carnet; }
        }
        public FenetreAccueil(CollectionCarnet col)
        {
            InitializeComponent();
            this.col = col;
           
            
        }

        private void Click_CréerCarnet(object sender, RoutedEventArgs e)
        {
            if (txtNom.Text !="" && txtPrénom.Text != "")
            {
                if (this.col.GetCarnet(txtNom.Text, txtPrénom.Text) != null)
                {
                    MessageBox.Show("cet Etudiant existe déjà", "Nouveau Carnet");
                }else
                {
                    Etudiant etd = new Etudiant(txtNom.Text, txtPrénom.Text);
                    this.carnet = new Carnet(etd);
                    this.col.AjouterCarnet(this.carnet);
                    DialogResult = true;
                }
            }
                
            else
            {
                MessageBox.Show("Vous avez un ou plusieurs champs vide","saisie incorrecte");
            }
            
            

        }

        private void ClickAccéderCarnet(object sender, RoutedEventArgs e)
        {
            this.carnet = this.col.GetCarnet(txtNom.Text,txtPrénom.Text);
            if (this.carnet == null)
            {
                DialogResult = false;
            }
            else
            {
                DialogResult = true;
            }
          
        }

        
    }
}
