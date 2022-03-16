using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class user
    {
        private string _Username;
        private string _Password;
        public string Username
        {
            get
            {
                return this._Username;
            }
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                {
                    this._Username = value;
                }
            }
        }
        public string Password
        {

            get { return this._Password; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value.Length >= 8 && value.Length <= 25 && HasLower(value) && HasUpper(value) && HasDigit(value)) 
                    {
                        this.Password = value;
                    }
                }

            }
        }
        static bool HasDigit(string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                if (Char.IsDigit(txt[i]))
                {
                    return true;
                }
            }
            return false;
        }
        static bool HasUpper(string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                if (Char.IsUpper(txt[i]))
                {
                    return true;
                }
            }
            return false;
        }
        static bool HasLower(string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                if (Char.IsLower(txt[i]))
                {
                    return true;
                }
            }
            return false;
        }

    }   
}
