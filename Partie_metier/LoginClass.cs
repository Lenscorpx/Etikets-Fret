using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_metier
{
   public class LoginClass
    {
        private string user_name;
        private string pass_word;

        public string User_name
        {
            get
            {
                return user_name;
            }

            set
            {
                user_name = value;
            }
        }

        public string Pass_word
        {
            get
            {
                return pass_word;
            }

            set
            {
                pass_word = value;
            }
        }
    }
}
