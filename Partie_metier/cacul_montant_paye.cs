using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_metier
{
   public class cacul_montant_paye
    {
        private decimal pu;
        private decimal poids;
        private decimal pt;

        public decimal Pu
        {
            get
            {
                return pu;
            }

            set
            {
                pu = value;
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
                poids = value;
            }
        }

        public decimal Pt
        {
            get
            {
                return pt;
            }

            set
            {
                pt = value;
            }
        }
        public void calcul_Prix_paye()
        {
            Pt = Poids * Pu;
        }
        public void calcul_dollar_franc()
        {
            Pt = Poids * Pu;
        }
    }
}
