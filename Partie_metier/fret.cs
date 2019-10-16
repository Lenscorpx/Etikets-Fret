using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_metier
{
   public class fret
    {
        private int id_fret;
        private DateTime date_fret;
        private string nom_proprietaire;
        private string contact_proprietaire;
        private string nom_destinataire;
        private string contact_destinataire;
        private string adresse_destinataire;
        private string designation_colis;
        private decimal poids;
        private string ref_etikets;
        private string ref_type_colis;
        private string ref_embarquement;

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

        public DateTime Date_fret
        {
            get
            {
                return date_fret;
            }

            set
            {
                verifier_valeur.verifier_ate(value);
                date_fret = value;
            }
        }

        public string Nom_proprietaire
        {
            get
            {
                return nom_proprietaire;
            }

            set
            {
                verifier_valeur.Verifier_text_fild(value);
                nom_proprietaire = value;
            }
        }

        public string Contact_proprietaire
        {
            get
            {
                return contact_proprietaire;
            }

            set
            {
                verifier_valeur.verifier_umero_telephone(value);
                contact_proprietaire = value;
            }
        }

        public string Nom_destinataire
        {
            get
            {
                return nom_destinataire;
            }

            set
            {
                verifier_valeur.Verifier_text_fild(value);
                nom_destinataire = value;
            }
        }

        public string Contact_destinataire
        {
            get
            {
                return contact_destinataire;
            }
            set
            {
                verifier_valeur.verifier_umero_telephone(value);
                contact_destinataire = value;
            }
        }

        public string Adresse_destinataire
        {
            get
            {
                return adresse_destinataire;
            }

            set
            {
                adresse_destinataire = value;
            }
        }

        public string Designation_colis
        {
            get
            {
                return designation_colis;
            }

            set
            {
                verifier_valeur.Verifier_text_fild(value);
                designation_colis = value;
            }
        }

        public decimal Poids
        {
            get
            {
                return poids;
            }

            set
            {
                verifier_valeur.verifier_decimal_fild(value);
                poids = value;
            }
        }

        public string Ref_etikets
        {
            get
            {
                return ref_etikets;
            }

            set
            {
                ref_etikets = value;
            }
        }

        public string Ref_type_colis
        {
            get
            {
                return ref_type_colis;
            }

            set
            {
                ref_type_colis = value;
            }
        }

        public string Ref_embarquement
        {
            get
            {
                return ref_embarquement;
            }

            set
            {
                ref_embarquement = value;
            }
        }

        public void Enregistrer_fret()
        {
           DAO_fret.enregistrer_fret(this);
        }
        public void Supprimer_fret()
        {
            DAO_fret.Supprimer_fret(this);
        }
    }
}
