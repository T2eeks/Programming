using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows;

namespace View.Model.Services
{
    /// <summary>
    /// Класс, отвечающий за сериализацию и десериализацию контактов.
    /// </summary>
    internal class ContactSerializer
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
            EnsureDirectoryExists();

        }

        /// <summary>
        /// Проверяет существование директории, если её нет – создаёт.
        /// </summary>
        private void EnsureDirectoryExists()
        {
            string directory = Path.GetDirectoryName(FilePath);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        /// <summary>
        /// Сохраняет контакт в файл JSON.
        /// </summary>
        /// <param name="contact">Контакт для сохранения.</param>
        public void SaveContact(Contact contact)
        {
            try
            {
                string json = JsonConvert.SerializeObject(contact, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при сохранении контакта", ex);
            }
        }

        /// <summary>
        /// Загружает контакт из файла JSON.
        /// </summary>
        /// <returns>Загруженный контакт или новый экземпляр, если файл отсутствует.</returns>
        public Contact LoadContact()
        {
            try
            {
               
                if (!File.Exists(FilePath))
                {
                    MessageBox.Show("Файл не найден.");
                    return new Contact();
                }

                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<Contact>(json) ?? new Contact();
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при загрузке контакта", ex);
            }
        }

    }
}
