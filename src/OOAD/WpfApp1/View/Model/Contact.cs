using System.ComponentModel;

namespace View.Model
{
    /// <summary>
    /// Класс, представляющий контакт человка.
    /// </summary>
    public class Contact : INotifyPropertyChanged
    {

        /// <summary>
        /// Событие, которое вызывается при изменении свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Имя человека.
        /// </summary>
        private string _name;
        
        /// <summary>
        /// Номер телефона человека.
        /// </summary>
        private string _number;

        /// <summary>
        /// Электронная почта человека.
        /// </summary>
        private string _email;

        /// <summary>
        /// Получает или задает имя человека.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if(_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Получает или задает номер телефона человека.
        /// </summary>
        public string Number
        {
            get { return _number; }
            set
            {
                if(_number != value)
                {
                    _number = value;
                    OnPropertyChanged(nameof(Number));
                }
            }
        }

        /// <summary>
        /// Получает или задает электронную почту человека.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/> для указанного свойства.
        /// </summary>
        /// <param name="propertyName">Имя изменившегося свойства.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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