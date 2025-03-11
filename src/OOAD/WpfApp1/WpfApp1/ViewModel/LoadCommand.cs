using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Serialization;
using View.Model.Services;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// Команда для загрузки контакта из файла.
    /// </summary>
    internal class LoadCommand : ICommand
    {
        /// <summary>
        /// Сериализатор контактов.
        /// </summary>
        private readonly ContactSerializer _serializer;

        /// <summary>
        /// Вью-модель, в которую загружаются данные.
        /// </summary>
        private readonly MainVM _viewModel;

        /// <summary>
        /// Событие, вызываемое при изменении возможности выполнения команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Создаёт экземпляр команды загрузки.
        /// </summary>
        /// <param name="viewModel">Вью-модель, с которой будет работать команда.</param>
        public LoadCommand(MainVM viewModel)
        {
            _viewModel = viewModel;
            _serializer = new ContactSerializer();
        }

        /// <summary>
        /// Определяет, можно ли выполнить команду.
        /// </summary>
        /// <param name="parameter">Не используется.</param>
        /// <returns>Всегда true.</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет загрузку контакта из файла и обновляет данные вью-модели.
        /// </summary>
        /// <param name="parameter">Не используется.</param>
        public void Execute(object parameter)
        {
            ContactSerializer serializer = new ContactSerializer();
            List<Contact> contacts = serializer.LoadContact();
            
            Contact loadedContact = contacts.FirstOrDefault();

            if (_viewModel != null && loadedContact != null)
            {
                _viewModel.Name = loadedContact.Name;
                _viewModel.PhoneNumber = loadedContact.Number;
                _viewModel.Email = loadedContact.Email;
            }
            else if (_viewModel != null)
            {
                _viewModel.Name = string.Empty;
                _viewModel.PhoneNumber = string.Empty;
                 _viewModel.Email = string.Empty;
            }    
        }
    }
}
