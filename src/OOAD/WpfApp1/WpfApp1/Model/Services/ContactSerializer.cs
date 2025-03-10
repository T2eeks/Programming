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
    internal class ContactSerializer
    {
        private static readonly string DefaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts", "contacts.json");

        public string FilePath { get; set; }

        public ContactSerializer()
        {
            FilePath = DefaultPath;
            EnsureDirectoryExists();

        }

        private void EnsureDirectoryExists()
        {
            string directory = Path.GetDirectoryName(FilePath);

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

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
