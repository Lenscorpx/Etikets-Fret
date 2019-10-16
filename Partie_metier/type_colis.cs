using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_metier
{
   public class type_colis
    {
        private string code_type_colis;
        private string description;
        private string unite;
        private int id_tarif;

        public string Code_type_colis
        {
            get
            {
                return code_type_colis;
            }

            set
            {
                code_type_colis = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                verifier_valeur.Verifier_text_fild(value);
                description = value;
            }
        }

        public string Unite
        {
            get
            {
                return unite;
            }

            set
            {
                verifier_valeur.Verifier_text_fild(value);
                unite = value;
            }
        }

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

        public void Enregistrer_type_colis()
        {
            if (string.IsNullOrEmpty(Description))
                throw new Exception("La description n'est doit pas être vide");
            DAO_type_colis.enregistrer_type_colis(this);
        }
        public void Supprimer_type_colis()
        {
            DAO_type_colis.suppromer_type_colis(this);
        }
    }
}
