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
    public class MainVM : INotifyPropertyChanged
    {
        private Contact _contact;

        public ICommand SaveCommand { get; }
        public ICommand LoadCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

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

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public MainVM()
        {
            _contact = new Contact();
            SaveCommand = new SaveCommand(this);
            LoadCommand = new LoadCommand(this);
        }
    }
}
