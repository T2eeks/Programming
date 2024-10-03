using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming
{
    /// <summary>
    /// Хранит данные об Имени Фамилии и Электронной почте контакта.
    /// </summary>
    internal class Contacts
    {
        /// <summary>
        /// Имя контакта
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта
        /// </summary>
        private string _surname;

        /// <summary>
        /// Электронная почта контакта
        /// </summary>
        private string _email;

        /// <summary>
        /// Возвращает и задает Имя контакта. Должна состоять только и букв.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает Фамилию контакта. Должна состоять только и букв.
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает Электронную почту контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contacts"/>.
        /// </summary>
        /// <param name="name">Имя контакта. Должно состоять только из букв.</param>
        /// <param name="surname">Фамилия контакта. Должна состоять только из букв.</param>
        /// <param name="email">Электронный адрес контакта.</param>
        public Contacts(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
        }
        public Contacts() { }

        /// <summary>
        /// Провераяет, что строка состоит из английских букв и цифр.
        /// </summary>
        /// <param name="value">Проверяемая строка</param>
        /// <exception cref="ArgumentException">Выбрасывается, если строка содержит символы, отличные от английских букв и цифр</exception>
        private void AssertStringContainsOnlyLetters(string value)
        {
            if (!Regex.IsMatch(value, "^[a-zA-Z0-9]+$"))
            {
                throw new ArgumentException(nameof(value));
            }
        }

    }

    

}
