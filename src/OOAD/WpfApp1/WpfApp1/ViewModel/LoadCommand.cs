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
    internal class LoadCommand : ICommand
    {
        private readonly ContactSerializer _serializer;
        private readonly MainVM _viewModel;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public LoadCommand(MainVM viewModel)
        {
            _viewModel = viewModel;
            _serializer = new ContactSerializer();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var loadedContact = _serializer.LoadContact();

            if (_viewModel != null && loadedContact != null)
            {
                _viewModel.Name = loadedContact.Name;
                _viewModel.PhoneNumber = loadedContact.Number;
                _viewModel.Email = loadedContact.Email;

            }
  
        }
    }
}
