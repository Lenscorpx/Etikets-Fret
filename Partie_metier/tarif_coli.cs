using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_metier
{
    public class tarif_coli
    {
        private int id_tarif;
        private decimal prix;
        private string devise;

        public int Id_tarif
        {
            get
            {
                return id_tarif;
            }

            set
            {
                id_tarif = value;
            }
        }

        public decimal Prix
        {
            get
            {
                return prix;
            }

            set
            {
                verifier_valeur.verifier_decimal_fild(value);
                prix = value;
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

        public void Enregistrer_tarif_coli()
        {
            if (string.IsNullOrEmpty(Prix.ToString()))
                throw new Exception("Le prix n'est doit pas être vide");
                DAO_tarif_colis.Enregistrer_tarif(this);
        }
        public void Supprimer_tarif_colis()
        {
            DAO_tarif_colis.Supprimer_tarif(this);
        }
        
    }
}
