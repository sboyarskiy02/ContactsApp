using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAppLogic
{
    public class Project
    {
        // Словарь для хранения контактов по их номеру телефона (или ID)
        private Dictionary<string, Contact> contacts;

        public string Number { get; set; }

        public Project(string number)
        {
            Number = number;
            contacts = new Dictionary<string, Contact>();
        }

        // Метод для добавления контакта
        public bool AddContact(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException(nameof(contact), "Contact cannot be null.");

            if (contacts.ContainsKey(contact.Phone))
            {
                Console.WriteLine("Contact with this phone number already exists.");
                return false; // Если контакт с таким номером телефона уже существует, то не добавляем
            }

            contacts[contact.Phone] = contact;
            return true;
        }

        // Метод для получения всех контактов
        public List<Contact> GetContacts()
        {
            return new List<Contact>(contacts.Values);
        }

        // Метод для поиска контакта по телефону
        public Contact FindContactByPhone(string phone)
        {
            if (contacts.TryGetValue(phone, out var contact))
            {
                return contact;
            }
            return null; // Если контакт не найден
        }

        // Метод для удаления контакта
        public bool RemoveContact(string phone)
        {
            return contacts.Remove(phone);
        }

        // Метод для вывода всех контактов
        public void DisplayContacts()
        {
            foreach (var contact in contacts.Values)
            {
                Console.WriteLine(contact);
            }
        }

        public override string ToString()
        {
            return $"Project Number: {Number}, Total Contacts: {contacts.Count}";
        }
    }
}