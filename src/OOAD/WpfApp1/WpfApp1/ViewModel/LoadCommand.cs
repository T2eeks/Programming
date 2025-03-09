using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model.Services;

namespace View.ViewModel
{
    internal class LoadCommand
    {
        private readonly ContactSerializer _serializer;
        private readonly MainVM _viewModel;

        public event EventHandler CanExecuteChanged;

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
            _viewModel.Contact = _serializer.LoadContact();
        }
    }
}
