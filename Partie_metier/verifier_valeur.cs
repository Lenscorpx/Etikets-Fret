using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Partie_metier
{
    public class verifier_valeur
    {
        public static void Verifier_text_fild(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                char[] caracteres = value.ToCharArray();
                //Commence par une lettre
                if (!char.IsLetter(caracteres[0]))
                     MessageBox.Show(@"Le premier caractère doit être une lettre pour les noms,les addresses et la designation du coli ou type coli. Veuillez bien vérifier ! ");
                //Vérifie si lettre, espace ou apostrophe
                for (int i = 0; i < caracteres.Length; i++)
                {
                    if (!char.IsLetter(caracteres[i]))
                    {
                        if (caracteres[i] != ' ' && caracteres[i] != '\'' && caracteres[i] != '-' && caracteres[i] != '/')
                        {
                            MessageBox.Show(@"les noms,les addresses et la designation du coli ne doivent contenir que des lettres, des espaces, des apostrophes, trait d'union et le slash. Veuillez bien vérifier !");
                        }
                    }
                }
            }
        }

        public static void verifier_ate(DateTime value)
        {
            if (DateTime.Compare(value, DateTime.Now) > 0)
                MessageBox.Show(
                      @"La date doit être inférieure ou égale à la date d'aujourd'hui. Veuillez bien vérifier!");
        }
        public static void verifier_decimal_fild(decimal value)
        {
            if (value < 0)
            {
                MessageBox.Show(@"Le poids ne doit pas être inférieur à zéro. Veuillez bien vérifier!");
            }
        }

        public static void verifier_umero_telephone(string value)
        {

            if (!string.IsNullOrEmpty(value))
            {
                char[] caracteres = value.ToCharArray();
                if (caracteres.Length < 8 || caracteres.Length > 15)
                {
                    MessageBox.Show(@"La taille du numéro de telephone doit être comprise entre 8 et 15 caractères, Veuillez bien vérifier!");
                }
                //le numero de telephone doit commencer par un signe + ou par ( ou par 0 

                if(caracteres[0] != '+' && !char.IsNumber(caracteres[0]) && caracteres[0] != '(' && caracteres[0] != '0')
                {
                    MessageBox.Show(@"Le premier caractère du numéro de télephone doit être un signe + , la paranthèse ouverte ou un chiffre 0,Veuillez bien vérifier!");
                    //Vérifier si (), espace 
                }
                {
                    for (int i = 0; i < caracteres.Length; i++)
                    {
                        if (!char.IsNumber(caracteres[i]))
                        {
                            if (caracteres[i] != ' ' && caracteres[i] != '-' && caracteres[4] != ' ' && caracteres[4] != ')')
                            {
                                MessageBox.Show(@"Le numéro de télephone ne doit contenir que des chiffres, des espaces, des paranthèses,Veuillez bien vérifier!");
                            }
                        }
                    }
                
                }
            }
        }
    }
}
