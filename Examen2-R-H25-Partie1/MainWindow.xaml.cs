using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Examen2_R_H25_Partie1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Employe> les_employes;

        public MainWindow()
        {
            InitializeComponent();
            les_employes = new List<Employe>() {
                new Employe("12345", "Smith", "Bob", "819-555-5555", "2222", "bob.smith@cegep.com", (float)45.50),
                new Employe("12346", "Tremblay", "Ginette", "819-555-5555", "1122", "ginette.tremblay@cegep.com", 60)
            };
            // TODO : Afficher la liste d'employés
            // Source exercice Contacts
            foreach (Employe employe in les_employes) 
            {
                lstEmp.Items.Add(employe);
            }
        }
        // TODO : Gérer le bouton Ajouter pour qu'il ajoute un employé dans la liste.
        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                string numEmploye = txtNoEmploye.Text;
                string nom = txtNom.Text;
                string prenom = txtPrenom.Text;
                string numTel = "819-555-5555"; // Comme tous les employés sont dans le même entreprise, le numéro de téléphon est toujours le même.
                string numPoste = txtNumPoste.Text;
                string email = txtCourriel.Text;
                float tauxHoraire = float.Parse(txtTauxHoraire.Text, CultureInfo.InvariantCulture);
                // public Employe(string noEmploye, string nom, string prenom, string noTelephone, string noPoste, string courriel, float tauxHoraire)
                Employe employe = new Employe(numEmploye, nom, prenom, numTel, numPoste,email, tauxHoraire);
                // Si tout est valide, le nouvel employé doit aussi s'afficher dans la ListBox sur l'interface.
                lstEmp.Items.Add(employe);
            }
            catch(Exception ex) 
            {
                // Si les données ne sont pas valides, afficher le message d'erreur obtenu dans un Label ou un MessageBox.
                lblErreur.Foreground = Brushes.Red;
                lblErreur.Content = ex.Message;
                
            }
        }

        
        
        
        

    }
}
