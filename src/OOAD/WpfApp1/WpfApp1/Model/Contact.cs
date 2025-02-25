namespace View.Model
{
    /// <summary>
    /// Класс, представляющий контакт человка.
    /// </summary>
    public class Contact
    {

        /// <summary>
        /// Получает или задает имя человека.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Получает или задает номер телефона человека.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Получает или задает электронную почту человека.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Contact"/>
        /// </summary>
        /// <param name="name">Имя человека.</param>
        /// <param name="number">Номер телефона человека.</param>
        /// <param name="email">Электронная почта человека.</param>
        public Contact(string name, string number, string email)
        {
            Name = name;
            Number = number;
            Email = email;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Contact"/>
        /// </summary>
        public Contact() { }
    }
}