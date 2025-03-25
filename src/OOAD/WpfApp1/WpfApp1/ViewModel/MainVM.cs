using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using View.Model;
using System.Windows.Input;
using View.Model.Services;
using System.Collections.ObjectModel;
using WpfApp1.ViewModel;

namespace View.ViewModel
{
    /// <summary>
    /// Главная ViewModel для управления контактными данными.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        private Contact _selectedContact;
        private bool _isEditing;
        private bool _isAddingNewContact;
        private string _tempName;
        private string _tempPhoneNumber;
        private string _tempEmail;
        private ContactSerializer _serializer;

        /// <summary>
        /// Получает или задает видимость кнопки "Применить".
        /// </summary>
        public bool IsApplyButtonVisible { get; set; }

        /// <summary>
        /// Получает или задает коллекцию контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; set; }

        /// <summary>
        /// Получает команду добавления нового контакта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Получает команду применения изменений при добавлении или редактировании контакта.
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Получает команду редактирования выбранного контакта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Получает команду удаления выбранного контакта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Событие, уведомляющее об изменении свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Получает или задает временное имя для редактирования или добавления.
        /// </summary>
        public string TempName
        {
            get { return _tempName; }
            set
            {
                _tempName = value;
                OnPropertyChanged(nameof(TempName));
            }
        }

        /// <summary>
        /// Получает или задает временный номер телефона для редактирования или добавления.
        /// </summary>
        public string TempPhoneNumber
        {
            get { return _tempPhoneNumber; }
            set
            {
                _tempPhoneNumber = value;
                OnPropertyChanged(nameof(TempPhoneNumber));
            }
        }

        /// <summary>
        /// Получает или задает временную электронную почту для редактирования или добавления.
        /// </summary>
        public string TempEmail
        {
            get { return _tempEmail; }
            set
            {
                _tempEmail = value;
                OnPropertyChanged(nameof(TempEmail));
            }
        }

        /// <summary>
        /// Получает или задает выбранный контакт.
        /// </summary>
        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                if (_isAddingNewContact || _isEditing)
                {
                    _isAddingNewContact = false;
                    _isEditing = false;
                    ResetFields();
                    IsApplyButtonVisible = false;
                    OnPropertyChanged(nameof(IsApplyButtonVisible));
                    OnPropertyChanged(nameof(IsReadOnly));
                    OnPropertyChanged(nameof(CanEditOrRemove));
                    OnPropertyChanged(nameof(CanAdd));
                }

                _selectedContact = value;
                UpdateFields();
                OnPropertyChanged(nameof(SelectedContact));
                OnPropertyChanged(nameof(IsContactSelected));
            }
        }

        /// <summary>
        /// Получает значение, указывающее, выбран ли контакт.
        /// </summary>
        public bool IsContactSelected
        {
            get { return SelectedContact != null; }
        }

        /// <summary>
        /// Получает значение, указывающее, доступны ли поля для редактирования.
        /// </summary>
        public bool IsReadOnly
        {
            get { return !_isEditing && !_isAddingNewContact; }
        }

        /// <summary>
        /// Получает значение, указывающее, можно ли добавить новый контакт.
        /// </summary>
        public bool CanAdd
        {
            get { return !_isEditing && !_isAddingNewContact; }
        }

        /// <summary>
        /// Получает значение, указывающее, можно ли редактировать или удалить контакт.
        /// </summary>
        public bool CanEditOrRemove
        {
            get { return IsContactSelected && !_isEditing && !_isAddingNewContact; }
        }

        /// <summary>
        /// Сбрасывает временные поля для редактирования.
        /// </summary>
        private void ResetFields()
        {
            TempName = string.Empty;
            TempPhoneNumber = string.Empty;
            TempEmail = string.Empty;

            OnPropertyChanged(nameof(TempName));
            OnPropertyChanged(nameof(TempPhoneNumber));
            OnPropertyChanged(nameof(TempEmail));
        }

        /// <summary>
        /// Обновляет временные поля в зависимости от состояния.
        /// </summary>
        private void UpdateFields()
        {
            if (_isAddingNewContact)
            {
                TempName = string.Empty;
                TempPhoneNumber = string.Empty;
                TempEmail = string.Empty;
            }
            else if (SelectedContact != null)
            {
                TempName = SelectedContact.Name;
                TempPhoneNumber = SelectedContact.Number;
                TempEmail = SelectedContact.Email;
            }
            else
            {
                ResetFields();
            }
        }

        /// <summary>
        /// Добавляет новый контакт в коллекцию.
        /// </summary>
        /// <param name="obj">Параметр команды (не используется).</param>
        private void AddContact(object obj)
        {
            _isAddingNewContact = true;
            SelectedContact = null;
            IsApplyButtonVisible = true;

            OnPropertyChanged(nameof(IsApplyButtonVisible));
            OnPropertyChanged(nameof(IsReadOnly));
            OnPropertyChanged(nameof(CanAdd));
            OnPropertyChanged(nameof(CanEditOrRemove)); 

            ResetFields();
        }

        /// <summary>
        /// Разрешает редактирование выбранного контакта.
        /// </summary>
        /// <param name="obj">Параметр команды (не используется).</param>
        private void EditContact(object obj)
        {
            if (SelectedContact != null)
            {
                _isEditing = true;
                UpdateFields();
                IsApplyButtonVisible = true;

                OnPropertyChanged(nameof(IsApplyButtonVisible));
                OnPropertyChanged(nameof(IsReadOnly));
                OnPropertyChanged(nameof(CanAdd));
                OnPropertyChanged(nameof(CanEditOrRemove));
            }
        }

        /// <summary>
        /// Применяет изменения при добавлении или редактировании контакта.
        /// </summary>
        /// <param name="obj">Параметр команды (не используется).</param>
        private void ApplyContact(object obj)
        {
            if (string.IsNullOrWhiteSpace(TempName) || string.IsNullOrWhiteSpace(TempPhoneNumber) || string.IsNullOrWhiteSpace(TempEmail))
                return;

            if (_isAddingNewContact)
            {
                Contact newContact = new Contact(TempName, TempPhoneNumber, TempEmail);
                Contacts.Add(newContact);
                SelectedContact = newContact;
            }
            else if (_isEditing && SelectedContact != null)
            {
                SelectedContact.Name = TempName;
                SelectedContact.Number = TempPhoneNumber;
                SelectedContact.Email = TempEmail;
            }

            _isAddingNewContact = false;
            _isEditing = false;
            IsApplyButtonVisible = false;

            SaveContacts();

            OnPropertyChanged(nameof(IsApplyButtonVisible));
            OnPropertyChanged(nameof(IsReadOnly));
            OnPropertyChanged(nameof(CanAdd));
            OnPropertyChanged(nameof(CanEditOrRemove));
        }

        /// <summary>
        /// Удаляет выбранный контакт из коллекции.
        /// </summary>
        /// <param name="obj">Параметр команды (не используется).</param>
        private void RemoveContact(object obj)
        {
            if (SelectedContact != null)
            {
                int index = Contacts.IndexOf(SelectedContact);
                Contacts.Remove(SelectedContact);

                if (Contacts.Count > 0)
                {
                    if (index >= Contacts.Count)
                    {
                        SelectedContact = Contacts[Contacts.Count - 1];
                    }
                    else
                    {
                        SelectedContact = Contacts[index];
                    }
                }
                else
                {
                    SelectedContact = null;
                    ResetFields();
                }

                SaveContacts();

                OnPropertyChanged(nameof(IsContactSelected));
            }
        }

        /// <summary>
        /// Загружает контакты из файла.
        /// </summary>
        private void LoadContacts()
        {
            var contacts = _serializer.LoadContact();
            Contacts.Clear();
            foreach (var contact in contacts)
            {
                Contacts.Add(contact);
            }

            if (Contacts.Count > 0)
            {
                SelectedContact = Contacts[0];
            }
        }

        /// <summary>
        /// Сохраняет контакты в файл.
        /// </summary>
        private void SaveContacts()
        {
            _serializer.SaveContacts(new List<Contact>(Contacts));
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
        /// Инициализирует новый экземпляр класса MainVM.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
            _serializer = new ContactSerializer();

            AddCommand = new BaseCommand(AddContact, (obj) => CanAdd);
            ApplyCommand = new BaseCommand(ApplyContact);
            EditCommand = new BaseCommand(EditContact, (obj) => CanEditOrRemove);
            RemoveCommand = new BaseCommand(RemoveContact, (obj) => CanEditOrRemove);

            LoadContacts();
        }
    }
}