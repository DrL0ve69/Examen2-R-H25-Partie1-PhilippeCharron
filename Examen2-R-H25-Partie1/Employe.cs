using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2_R_H25_Partie1
{
    using System;

    public class Employe
    {
        private string _noEmploye;
        private string _noPoste;
        private float _tauxHoraire;
        private string _courriel;

        // Propriétés avec validation
        public string NoEmploye
        {
            get => _noEmploye;
            set
            {
                if (value.Length != 5 || !int.TryParse(value, out _))
                    throw new ArgumentException("Le numéro d'employé doit être composé de 5 chiffres.");
                _noEmploye = value;
            }
        }

        public string Nom { get; set; }
        public string Prenom { get; set; }

        public string NoTelephone { get; }  // Lecture seule

        public string NoPoste
        {
            get => _noPoste;
            set
            {
                if (value.Length != 4 || !int.TryParse(value, out _))
                    throw new ArgumentException("Le numéro de poste doit être composé de 4 chiffres.");
                _noPoste = value;
            }
        }

        public string Courriel
        {
            get => _courriel;
            set
            {
                if (!value.Contains("@") || !value.EndsWith("@cegep.com"))
                    throw new ArgumentException("Le courriel doit être au format prenom.nom@cegep.com.");
                _courriel = value;
            }
        }

        public float TauxHoraire
        {
            get => _tauxHoraire;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Le taux horaire ne peut pas être négatif.");
                _tauxHoraire = (float)Math.Round(value, 2);
            }
        }

        // Constructeur par défaut
        public Employe()
        {

        }

        // Constructeur avec paramètres
        public Employe(string noEmploye, string nom, string prenom, string noTelephone, string noPoste, string courriel, float tauxHoraire)
        {
            NoEmploye = noEmploye;
            Nom = nom;
            Prenom = prenom;
            NoTelephone = noTelephone;
            NoPoste = noPoste;
            Courriel = courriel;
            TauxHoraire = tauxHoraire;
        }


        public override string ToString()
        {
            return $"Employé #{NoEmploye} : {Prenom} {Nom}\n" +
                   $"Téléphone : {NoTelephone}\n" +
                   $"Poste : {NoPoste}\n" +
                   $"Courriel : {Courriel}\n" +
                   $"Taux horaire : {TauxHoraire} $/h\n";
        }
    }
}
