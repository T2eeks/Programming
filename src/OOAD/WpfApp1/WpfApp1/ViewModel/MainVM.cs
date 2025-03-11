using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using View.Model;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Главная ViewModel для управления контактными данными.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Контакт, содержащий текущие данные.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Команда сохранения данных в файл.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Команда загрузки данных в файл.
        /// </summary>
        public ICommand LoadCommand { get; }

        /// <summary>
        /// Событие, уведомляющее об изменении свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Имя человека.
        /// </summary>
        public string Name
        {
            get { return _contact.Name; }
            set
            {
                if (_contact.Name != value)
                {
                    _contact.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        /// <summary>
        /// Номер телефона человека.
        /// </summary>
        public string PhoneNumber
        {
            get { return _contact.Number; }
            set
            {
                if (_contact.Number != value)
                {
                    _contact.Number = value;
                    OnPropertyChanged("PhoneNumber");
                }
            }
        }

        /// <summary>
        /// Электронная почта человека.
        /// </summary>
        public string Email
        {
            get { return _contact.Email; }
            set
            {
                if (_contact.Email != value)
                {
                    _contact.Email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        /// <summary>
        /// Объект контакта.
        /// </summary>
        public Contact Contact
        {
            get { return _contact; }
            set
            {
                if (_contact != value)
                {
                    _contact = value;
                    OnPropertyChanged("Contact");
                }
            }
        }

        /// <summary>
        /// Вызывает событие PropertyChanged для обновления привязанных данных.
        /// </summary>
        /// <param name="propertyName">Имя измененного свойства.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Создаёт новый экземпляр ViewModel и инициализирует команды.
        /// </summary>
        public MainVM()
        {
            _contact = new Contact();
            SaveCommand = new SaveCommand(this);
            LoadCommand = new LoadCommand(this);
        }
    }
}
