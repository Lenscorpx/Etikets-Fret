using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_metier
{
   public  class attribution_paiement_fret
    {
        private int num_attribution;
        private int id_fret;
        private string transaction_id_fret;

        public int Num_attribution
        {
            get
            {
                return num_attribution;
            }

            set
            {
                num_attribution = value;
            }
        }

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

        public string Transaction_id_fret
        {
            get
            {
                return transaction_id_fret;
            }

            set
            {
                transaction_id_fret = value;
            }
        }

        public void Enregistrer_attribution_fret()
        {
                
         DAO_attribution_paiement.enregistrer_attribution_fret(this);
        }
        public void Supprimer_attribution_fret()
        {
            DAO_attribution_paiement.supprimer_attribution_fret(this);
        }
    }
}
