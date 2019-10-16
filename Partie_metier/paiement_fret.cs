using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_metier
{
    public class paiement_fret
    {
        private string transaction_id;
        private DateTime date_paiement;
        private string type_paiement;
        private decimal montant;
        private string devise;

        public string Transaction_id
        {
            get
            {
                return transaction_id;
            }

            set
            {
                transaction_id = value;
            }
        }

        public DateTime Date_paiement
        {
            get
            {  
                return date_paiement;
            }

            set
            {
                verifier_valeur.verifier_ate(value);
                date_paiement = value;
            }
        }

        public string Type_paiement
        {
            get
            {
                return type_paiement;
            }

            set
            {
                verifier_valeur.Verifier_text_fild(value);
                type_paiement = value;
            }
        }

        public decimal Montant
        {
            get
            {
                return montant;
            }

            set
            {
                verifier_valeur.verifier_decimal_fild(value);
                montant = value;
            }
        }

        public string Devise
        {
            get
            {
                return devise;
            }

            set
            {
                devise = value;
            }
        }

        public void Enregistrer_paiement_fret()
        {
            DAO_paiement_fret.enregistrer_paiement_fret(this);
        }
        public void Supprimer_fret()
        {
            DAO_paiement_fret.Supprimer_paiement_fret(this);
        }
    }
}
