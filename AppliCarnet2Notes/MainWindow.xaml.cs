using AppliCarnet2Notes;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarnetDeNotes
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int nbreMaxi2Semestre = 4;
        private Semestre semestre=null;
        private Carnet carnet;
        private CollectionCarnet collections;
        
       
       
        public MainWindow()
        {
            InitializeComponent();
            CollectionDataXml chargeur = new CollectionDataXml("Données.xml");
            this.collections = chargeur.Charger();
            if (collections == null) { this.collections = new CollectionCarnet(); }

          
            this.GestionAccuiel();
            if (carnet !=null) {
                this.AfficherListeSemestre();
                this.labTitreCarnet.Content = "Carnet de " + this.carnet.Etudiant.Prenom + " " + this.carnet.Etudiant.Nom;
            } else { this.Close(); }


        }
        private void GestionAccuiel()
        {
            Boolean sortie = false;
            do
            {
                FenetreAccueil Accueil = new FenetreAccueil(this.collections);
                MessageBoxResult res;

                if (Accueil.ShowDialog() == true)
                {
                    this.carnet = Accueil.Carnet;
                    sortie = true;
                }
                else
                {
                    res = MessageBox.Show("vous n'existez pas dans la base , voulez vous créé un carnet?", "Gérer un Carnet", MessageBoxButton.OKCancel);
                    if (res == MessageBoxResult.Cancel)
                    {
                        sortie = true;
                       
                    }

                }


            } while (!sortie);
          

        }
        private void AfficherListeSemestre()
        {
            this.ListBoxLesSemestres.Items.Clear();
            if (this.carnet != null)
            {
                foreach (Semestre s in this.carnet.LesSemestres)
                {
                    this.ListBoxLesSemestres.Items.Add(s);

                }

            }
        }
        /**
         * permet d'afficher tous les Ue du carnet 
         */
        private void AfficherListeUE()
        {
            this.listUe.Items.Clear();
            if (this.semestre != null)
            {
                foreach (UE e in this.semestre.ListeDesUE())
                {
                    this.listUe.Items.Add(e);

                }
            }   

         }
           
            
        
        /**
         * permet d'afficher tous les modules de l'Ue sélectionné
         */
        private void AfficherListeModules()
        {
            this.listModules.Items.Clear();                  //on vide la liste
            UE ueSelected =this.listUe.SelectedItem as UE; //on recupere l'élément sélectonné
           
            if (this.semestre != null)
            {
                foreach (UE e in this.semestre.ListeDesUE())
                {

                    if (e.Equals(ueSelected))

                    {
                        Module[] listModules = e.ListeModule();
                        foreach (Module m in listModules)
                        {
                            this.listModules.Items.Add(m);
                        }
                    }
                }

            }
           

        }
        private void AfficherListeNote()
        {
            this.listNotesModule.Items.Clear();                //on vide la liste
            Module modSelected = this.listModules.SelectedItem as Module; //on recupere l'élément sélectonné
         
            foreach (Module m in this.semestre.ListeModules())
            {

                if (m.Equals(modSelected))

                {
                   
                    foreach (Note n in m.ListeNotes())
                    {
                        this.listNotesModule.Items.Add(n);
                    }
                }
            }

        }

        private void SelectionItem(object sender, SelectionChangedEventArgs e)
        {
           
            this.AfficherListeModules();
        }

        private void Click_Bt_NvoUe(object sender, RoutedEventArgs e)
        {
            if (this.semestre != null)
            {
 
                //création de l'UE a ajouteravec un nom vide(on laisse l'utilisateur saisir la valeur par la suite)
                UE ue = new UE("");

                FenetreUe fen = new FenetreUe(ue);          //on crée la fenêtre qui sert à gérer un UE

                if (fen.ShowDialog() == true)
                {


                    this.semestre.AjouterUE(ue);
                    this.AfficherListeUE();                 //mise a jour de la liste des Ue au niveau d'IHM
                    MessageBox.Show("L'ue " + ue.Nom + " à été ajoutée avec succès!", "Ajout d'une UE");


                }

            }else { MessageBox.Show("Veuillez séléctionner un semestre pour y ajouter une Ue"); }
        }

        private void Click_NvoModule(object sender, RoutedEventArgs e)
        {
           UE ueSelected = this.listUe.SelectedItem as UE ; //on recupre l'UE sélectionné
            if (ueSelected != null)
            {
                Module m = new Module("","", 0);
                FenetreModule fen = new FenetreModule(m);

                if (fen.ShowDialog() == true)
                {
                    //recherche de l'ue selectionné
                    foreach (UE ue in this.semestre.ListeDesUE())
                    {
                            if (ue.Equals(ueSelected))
                        {
                            //ajout du nvo module à l'ue selectionné
                            ue.AjouterModule(m.IdModule,m.Nom, m.Coefficient);
                            //mise à jour de l'IHM
                            this.AfficherListeUE();
                            MessageBox.Show("le module " + m.Nom + " à été ajouté avec succès !", "Ajouter un module");

                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une Ue pour y ajouter un module","Ajouter un module");
            }
           
        }

        private void DoubleClick_ItemListUE(object sender, MouseButtonEventArgs e)
        {
            UE ueSelected = this.listUe.SelectedItem as UE ;
            foreach(UE ue  in this.semestre.ListeDesUE())
            {
                if (ue.Equals(ueSelected))
                {
                    FenetreUeSet fen = new FenetreUeSet(ue);
                    if(fen.ShowDialog()==true)
                    {
                        this.AfficherListeUE();
                        MessageBox.Show("Modification éffectuée !");
                    }

                }
            }
            
        }

        private void Click_DoubleListModules(object sender, MouseButtonEventArgs e)
        {
            Module moduleSelected  = this.listModules.SelectedItem as Module;

                        FenetreModuleSet fen = new FenetreModuleSet(moduleSelected);
                        if (fen.ShowDialog() == true)
                        {
                            this.AfficherListeUE();     //pour rafraichir l'affichage
                            MessageBox.Show("Modification éffectuée !");
                           
                        }
                
        }

       

        private void SelectionModule(object sender, SelectionChangedEventArgs e)
        {
            this.AfficherListeNote();
        }

        private void Click_AjoutExam(object sender, RoutedEventArgs e)
        {
            Module moduleSelected = this.listModules.SelectedItem as Module;
            if (moduleSelected == null)
            {
                MessageBox.Show("veuiller sélectionner un module pout y ajouter un examen");
            }
            else
            {
                //saisie de la note 
                Note n = new Note(0, false);


                Examen ex = new Examen("", "", 0,n);
                FenetreExamen fen = new FenetreExamen(ex);
                if(fen.ShowDialog()==true)
                {
                    FenetreNote fen2 = new FenetreNote(n);
                    if (fen2.ShowDialog()==true)
                    {
                        ex.SetNote(n);
                        moduleSelected.AjouterExamen(ex.DateExam, ex.NomProf, ex.Ponderation, n);
                        this.AfficherListeModules();
                    }

                }
            }
        }

        private void DoubleClick_Note(object sender, MouseButtonEventArgs e)
        {
            Note noteSelected = this.listNotesModule.SelectedItem as Note;
            FenetreNoteSet fen = new FenetreNoteSet(noteSelected);
            if(fen.ShowDialog()==true)
            {
               
                this.AfficherListeUE();
            }
     
        }

        private void Click_Moyenne(object sender, RoutedEventArgs e)
        {
            if (this.semestre != null)
            {
                string Bulletin = "";

                foreach (UE ue in this.semestre.ListeDesUE())
                {
                    foreach (Module m in ue.ListeModule())
                    {
                        Bulletin += m.IdModule + " " + "(" + m.Nom + ")" + "  \t:" + m.Moyenne() + "\n" + "\n";
                    }
                    Bulletin += ue.Nom + "                  \t:" + ue.Moyenne() + "\n" + "\n" + "\n";
                }
                FenetreMoy fen = new FenetreMoy(Bulletin);

                if (fen.ShowDialog() == true) { }

            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un semestre", "Semestre");
            }
        }

       

        private void SelectionNote(object sender, SelectionChangedEventArgs e)
        {
            Note n = this.listNotesModule.SelectedItem as Note;
            Module m = this.listModules.SelectedItem as Module;
            if (n!= null)
            {
                foreach (Examen ex in m.ListeExamen())
                {
                    if (ex.GetNote().Equals(n))
                    {
                        
                        this.LabExam.Content = "Détails Examen \n"+ex.DateExam + " , " + ex.NomProf + " , " +"Pondération: "+ ex.Ponderation;
                        this.LabExam.Visibility = Visibility.Visible;
                    }
                }
            }else
            {
                this.LabExam.Visibility = Visibility.Hidden;

            }
           
        }
        public void Sauver()
        {
            CollectionDataXml chargeur = new CollectionDataXml("Données.xml");
            chargeur.Sauver(this.collections);
         

           


        }
        //A la fermeture  de la fen$etre principale
        private void Click_Close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Sauver();
        }

        private void SelectionSemestre(object sender, SelectionChangedEventArgs e)
        {
            this.semestre = this.ListBoxLesSemestres.SelectedItem as Semestre;
            this.AfficherListeUE();
        }

        private void Click_Bt_NvoSemestre(object sender, RoutedEventArgs e)
        {
            if (this.carnet.LesSemestres.Count< nbreMaxi2Semestre)
            {
                this.carnet.AjouterSemestre();
                this.AfficherListeSemestre();
            }
            else
                MessageBox.Show("Il existe au maximum 4 semestres");

        }
    }
}


