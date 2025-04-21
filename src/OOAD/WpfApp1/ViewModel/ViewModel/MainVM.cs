using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Model;
using System.Windows.Input;
using Model.Services;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ViewModel
{
    /// <summary>
    /// Главная ViewModel для управления контактными данными.
    /// </summary>
    public class MainVM : ObservableObject, IDataErrorInfo
    {
        private Contact _selectedContact;
        private bool _isEditing;
        private bool _isAddingNewContact;
        private string _tempName;
        private string _tempPhoneNumber;
        private string _tempEmail;
        private bool _isNameTouched;
        private bool _isPhoneNumberTouched;
        private bool _isEmailTouched;
        private ContactSerializer _serializer;
        private readonly Dictionary<string, string> _errors = new Dictionary<string, string>();

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
        public RelayCommand AddCommand { get; }

        /// <summary>
        /// Получает команду применения изменений при добавлении или редактировании контакта.
        /// </summary>
        public RelayCommand ApplyCommand { get; }

        /// <summary>
        /// Получает команду редактирования выбранного контакта.
        /// </summary>
        public RelayCommand EditCommand { get; }

        /// <summary>
        /// Получает команду удаления выбранного контакта.
        /// </summary>
        public RelayCommand RemoveCommand { get; }

        /// <summary>
        /// Получает или задает временное имя для редактирования или добавления.
        /// </summary>
        public string TempName
        {
            get { return _tempName; }
            set
            {
                if (SetProperty(ref _tempName, value))
                {
                    if (!string.IsNullOrEmpty(value))
                        _isNameTouched = true;
                    ValidateProperty(nameof(TempName), value);
                    OnPropertyChanged(nameof(IsContactValid)); 
                }
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
                if (SetProperty(ref _tempPhoneNumber, value))
                {
                    if (!string.IsNullOrEmpty(value))
                        _isPhoneNumberTouched = true;
                    ValidateProperty(nameof(TempPhoneNumber), value);
                    OnPropertyChanged(nameof(IsContactValid));
                }
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
                if (SetProperty(ref _tempEmail, value))
                {
                    if (!string.IsNullOrEmpty(value))
                        _isEmailTouched = true;
                    ValidateProperty(nameof(TempEmail), value);
                    OnPropertyChanged(nameof(IsContactValid));
                }
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
                if (SetProperty(ref _selectedContact, value))
                {
                    if (_isAddingNewContact || _isEditing)
                    {
                        _isAddingNewContact = false;
                        _isEditing = false;
                        IsApplyButtonVisible = false;
                        OnPropertyChanged(nameof(IsApplyButtonVisible));
                        OnPropertyChanged(nameof(IsReadOnly));
                        OnPropertyChanged(nameof(CanEdit));
                        OnPropertyChanged(nameof(CanRemove));
                        OnPropertyChanged(nameof(CanAdd));
                    }

                    _selectedContact = value;

                    if (_selectedContact != null && !_isAddingNewContact && !_isEditing)
                    {
                        TempName = _selectedContact.Name;
                        TempPhoneNumber = _selectedContact.Number;
                        TempEmail = _selectedContact.Email;
                    }

                    else
                    {
                        ResetFields();
                    }

                    OnPropertyChanged(nameof(SelectedContact));
                    OnPropertyChanged(nameof(IsContactSelected));
                    OnPropertyChanged(nameof(CanEdit));
                    OnPropertyChanged(nameof(CanRemove));
                }
            }
        }

        /// <summary>
        /// Индексатор для валидации свойств объекта (реализация IDataErrorInfo).
        /// Возвращает сообщение об ошибке для указанного свойства, если ошибка есть.
        /// </summary>
        /// <param name="columnName">Имя свойства, для которого нужно получить сообщение об ошибке.</param>
        /// <returns>Сообщение об ошибке или null, если ошибок нет.</returns>
        public string this[string columnName]
        {
            get
            {
                _errors.TryGetValue(columnName, out var error);
                return error;
            }
        }

        /// <summary>
        /// Реализация свойства Error интерфейса IDataErrorInfo.
        /// Возвращает объединенные сообщения об ошибках для всех свойств.
        /// </summary>
        public string Error => string.Join("\n", _errors.Values);

        /// <summary>
        /// Выполняет валидацию указанного свойства и обновляет словарь ошибок.
        /// Проверяет свойства TempName, TempPhoneNumber и TempEmail на соответствие заданным правилам.
        /// </summary>
        /// <param name="propertyName">Имя свойства, которое нужно валидировать.</param>
        /// <param name="value">Значение свойства для валидации.</param>
        private void ValidateProperty(string propertyName, string value)
        {
            string error = null;

            switch (propertyName)
            {
                case nameof(TempName):
                    if (_isNameTouched)
                    {
                        if (string.IsNullOrWhiteSpace(value))
                            error = "Name is required.";
                        else if (value.Length > 100)
                            error = "Name cannot be longer than 100 characters.";
                    }
                    break;

                case nameof(TempPhoneNumber):
                    if (_isPhoneNumberTouched)
                    {
                        if (string.IsNullOrWhiteSpace(value))
                            error = "Phone number is required.";
                        else if (value.Length > 100)
                            error = "Phone number cannot be longer than 100 characters.";
                        else if (!Regex.IsMatch(value, @"^\+\d{1,3}\s\(\d{3}\)\s\d{3}-\d{2}-\d{2}$"))
                            error = "Phone number must match the format. Example: +7 (999) 111-11-11";
                    }
                    break;

                case nameof(TempEmail):
                    if (_isEmailTouched)
                    {
                        if (string.IsNullOrWhiteSpace(value))
                            error = "Email is required.";
                        else if (value.Length > 100)
                            error = "Email cannot be longer than 100 characters.";
                        else if (!Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                            error = "Invalid email format.";
                    }
                    break;
            }

            if (error != null)
                _errors[propertyName] = error;
            else
                _errors.Remove(propertyName);
        }

        /// <summary>
        /// Обновляет временные поля для редактирования.
        /// </summary>
        private void UpdateFields()
        {
            if (_isAddingNewContact)
            {
                TempName = string.Empty;
                TempPhoneNumber = string.Empty;
                TempEmail = string.Empty;
            }
            else if (_isEditing && SelectedContact != null)
            {
                TempName = SelectedContact.Name;
                TempPhoneNumber = SelectedContact.Number;
                TempEmail = SelectedContact.Email;
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
        /// Получает значение, указывающее, можно ли редактировать контакт.
        /// </summary>
        public bool CanEdit
        {
            get { return IsContactSelected && !_isEditing && !_isAddingNewContact; }
        }

        /// <summary>
        /// Получает значение, указывающее, можно ли удалить контакт.
        /// </summary>
        public bool CanRemove
        {
            get { return IsContactSelected && !_isEditing && !_isAddingNewContact; }
        }

        /// <summary>
        /// Получает значение, указывающее, видима ли кнопка "Применить".
        /// </summary>
        public bool CanApply
        {
            get { return IsApplyButtonVisible; }
        }

        /// <summary>
        /// Получает значение, указывающее, находится ли приложение в режиме редактирования.
        /// </summary>
        public bool IsEditing
        {
            get { return !IsReadOnly; }
        }

        /// <summary>
        /// Получает значение, указывающее, валидны ли данные контакта.
        /// </summary>
        public bool IsContactValid
        {
            get
            {
                return !_errors.ContainsKey(nameof(TempName)) &&
                       !_errors.ContainsKey(nameof(TempPhoneNumber)) &&
                       !_errors.ContainsKey(nameof(TempEmail));
            }
        }

        /// <summary>
        /// Сбрасывает временные поля для редактирования.
        /// </summary>
        private void ResetFields()
        {
            TempName = string.Empty;
            TempPhoneNumber = string.Empty;
            TempEmail = string.Empty;

            _isNameTouched = false;
            _isPhoneNumberTouched = false;
            _isEmailTouched = false;

            _errors.Clear();

            OnPropertyChanged(nameof(TempName));
            OnPropertyChanged(nameof(TempPhoneNumber));
            OnPropertyChanged(nameof(TempEmail));
        }

        /// <summary>
        /// Добавляет новый контакт в коллекцию.
        /// </summary>
        /// <param name="obj">Параметр команды (не используется).</param>
        private void AddContact()
        {
            _isAddingNewContact = true;
            IsApplyButtonVisible = true;

            ResetFields();

            _selectedContact = null;
            OnPropertyChanged(nameof(SelectedContact));
            OnPropertyChanged(nameof(IsContactSelected));

            OnPropertyChanged(nameof(IsApplyButtonVisible));
            OnPropertyChanged(nameof(IsReadOnly));
            OnPropertyChanged(nameof(CanAdd));
            OnPropertyChanged(nameof(CanEdit));
            OnPropertyChanged(nameof(CanRemove));
        }

        /// <summary>
        /// Разрешает редактирование выбранного контакта.
        /// </summary>
        /// <param name="obj">Параметр команды (не используется).</param>
        private void EditContact()
        {
            if (SelectedContact != null)
            {
                _isEditing = true;
                TempName = SelectedContact.Name;
                TempPhoneNumber = SelectedContact.Number;
                TempEmail = SelectedContact.Email;
                IsApplyButtonVisible = true;

                OnPropertyChanged(nameof(IsApplyButtonVisible));
                OnPropertyChanged(nameof(IsReadOnly));
                OnPropertyChanged(nameof(CanAdd));
                OnPropertyChanged(nameof(CanEdit));
                OnPropertyChanged(nameof(CanRemove));
            }
        }

        /// <summary>
        /// Применяет изменения при добавлении или редактировании контакта.
        /// </summary>
        /// <param name="obj">Параметр команды (не используется).</param>
        private void ApplyContact()
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
            OnPropertyChanged(nameof(CanEdit));
            OnPropertyChanged(nameof(CanRemove));
        }

        /// <summary>
        /// Удаляет выбранный контакт из коллекции.
        /// </summary>
        /// <param name="obj">Параметр команды (не используется).</param>
        private void RemoveContact()
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
                OnPropertyChanged(nameof(CanEdit));
                OnPropertyChanged(nameof(CanRemove));
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
        /// Инициализирует новый экземпляр класса MainVM.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
            _serializer = new ContactSerializer();

            AddCommand = new RelayCommand(AddContact, () => CanAdd);
            ApplyCommand = new RelayCommand(ApplyContact);
            EditCommand = new RelayCommand(EditContact, () => CanEdit);
            RemoveCommand = new RelayCommand(RemoveContact, () => CanRemove);

            LoadContacts();
        }
    }
}