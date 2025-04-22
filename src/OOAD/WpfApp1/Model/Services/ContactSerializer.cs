using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows;
using System.CodeDom;
using System.Security.Cryptography;

namespace Model.Services
{
    /// <summary>
    /// Класс, отвечающий за сериализацию и десериализацию контактов.
    /// </summary>
    public class ContactSerializer
    {

        /// <summary>
        /// Путь по умолчанию для хранения файла контактов.
        /// </summary>
        private static readonly string DefaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts", "contacts.json");

        /// <summary>
        /// Путь к файлу контактов, который используется в текущем экземпляре.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Конструктор, инициализирующий путь к файлу и создающий необходимые директории.
        /// </summary>
        public ContactSerializer()
        {
            FilePath = DefaultPath;
            CreateDirectoryIfNotExist();

        }

        /// <summary>
        /// Проверяет существование директории, если её нет – создаёт.
        /// </summary>
        private void CreateDirectoryIfNotExist()
        {
            string directory = Path.GetDirectoryName(FilePath);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        /// <summary>
        /// Сохраняет список контактов в файл JSON.
        /// </summary>
        /// <param name="contact">Контакт для сохранения.</param>
        public void SaveContacts(List<Contact> contacts)
        {
            try
            {
                if (contacts == null)
                {     
                    contacts = new List<Contact>();
                }
                string json = JsonConvert.SerializeObject(contacts, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при сохранении контакта", ex);
            }
        }

        /// <summary>
        /// Загружает контактов из файла JSON.
        /// </summary>
        /// <returns>Загруженный контакт или новый экземпляр, если файл отсутствует.</returns>
        public List<Contact> LoadContact()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    return new List<Contact>();
                }  
                string json = File.ReadAllText(FilePath);

                if (json.TrimStart().StartsWith("{"))
                {  
                    Contact singleContact = JsonConvert.DeserializeObject<Contact>(json);
                    return new List<Contact> { singleContact };
                }

                return JsonConvert.DeserializeObject<List<Contact>>(json) ?? new List<Contact>();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при загрузке контакта", ex); 
            }
        }

    }
}
