using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Partie_metier
{
    public class recuperation_fret
    {
        private int id_fret;
        private DateTime date_recuperation;
        private string nom_recuperateur;
        private string nun_carte;
        private string telephoene;
        private string observation;

        public int Id_fret
        {
            get
            {
                return id_fret;
            }

            set
            {
                id_fret = value;
            }
        }

        public DateTime Date_recuperation
        {
            get
            {
                return date_recuperation;
            }

            set
            {
                verifier_valeur.verifier_ate(value);
                date_recuperation = value;
            }
        }

        public string Nom_recuperateur
        {
            get
            {
                return nom_recuperateur;
            }

            set
            {
                verifier_valeur.Verifier_text_fild(value);
                nom_recuperateur = value;
            }
        }

        public string Nun_carte
        {
            get
            {
                return nun_carte;
            }

            set
            {
                nun_carte = value;
            }
        }

        public string Telephoene
        {
            get
            {
                return telephoene;
            }

            set
            {
                verifier_valeur.verifier_umero_telephone(value);
                telephoene = value;
            }
        }

        public string Observation
        {
            get
            {
                return observation;
            }

            set
            {
                verifier_valeur.Verifier_text_fild(value);
                observation = value;
            }
        }

        public void Enregistrer_recuepration_fret()
        {
            if (string.IsNullOrEmpty(Nom_recuperateur) || string.IsNullOrEmpty(Nun_carte) || string.IsNullOrEmpty(Observation))
                MessageBox.Show("Le nom ou le numéro de la carte ou l'observation ne doivent pas être vide. Veuillez completer les champs vides");
            else
            DAO_recuperation_fret.enregistrer_recuperation_fret(this);
        }
        public void Supprimer_recuperaion_fret()
        {
            DAO_recuperation_fret.Supprimer_recuperation_fret(this);
        }
    }
}
