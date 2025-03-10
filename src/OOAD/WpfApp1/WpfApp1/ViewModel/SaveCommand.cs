using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда для сохранения данных котакта в файл.
    /// </summary>
    internal class SaveCommand : ICommand
    {
        /// <summary>
        /// Сериализатор контактов для сохранения данных.
        /// </summary>
        private readonly ContactSerializer _serializer;

        /// <summary>
        /// ViewModel, содержащая данные контакта.
        /// </summary>
        private readonly MainVM _viewModel;

        /// <summary>
        /// Событие, вызываемое при изменении состояния выполнения команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Создает экземпляр команды сохранения.
        /// </summary>
        /// <param name="viewModel">Экземпляр ViewModel, содержащий контактные данные.</param>
        public SaveCommand(MainVM viewModel)
        {
            _viewModel = viewModel;
            _serializer = new ContactSerializer();
        }

        /// <summary>
        /// Определяет, можно ли выполнить команду.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        /// <returns>Всегда возвращает true.</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет сохранение контакта в файл.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        public void Execute(object parameter)
        {
            _serializer.SaveContact(_viewModel.Contact);
        }
    }
}
