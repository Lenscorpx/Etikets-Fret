using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_metier
{
    public class print_manifeste
    {
        private string nom_bateau;
        private string trajet;
        private string section;
        private DateTime date_emb;

        public string Nom_bateau
        {
            get
            {
                return nom_bateau;
            }

            set
            {
                nom_bateau = value;
            }
        }

        public string Trajet
        {
            get
            {
                return trajet;
            }

            set
            {
                trajet = value;
            }
        }

        public string Section
        {
            get
            {
                return section;
            }

            set
            {
                section = value;
            }
        }

        public DateTime Date_emb
        {
            get
            {
                return date_emb;
            }

            set
            {
                date_emb = value;
            }
        }
    }
}
