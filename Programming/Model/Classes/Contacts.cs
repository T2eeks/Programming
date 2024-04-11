using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming
{
    internal class Contacts
    {
        private string _name;
        private string _surname;
        private string _email;

        public string Name
        {
            get { return _name; }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }
        public string Email { get; set; }


        public Contacts(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
        }
        public Contacts() { }

        private void AssertStringContainsOnlyLetters(string value)
        {
            if (!Regex.IsMatch(value, "^[a-zA-Z0-9]+$"))
            {
                throw new ArgumentException(nameof(value));
            }
        }

    }

    

}
