using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks
using System.Text.RegularExpressions;

namespace ContactAppLogic
{
    public class Contact : ICloneable
    {
        private string surname;
        private string name;
        private string email;
        private string idVk;
        private DateTime birthday;

        public string Surname
        {
            get => surname;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 50)
                    throw new ArgumentException("Surname must be non-empty and no more than 50 characters long.");
                surname = char.ToUpper(value[0]) + value.Substring(1);
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 50)
                    throw new ArgumentException("Name must be non-empty and no more than 50 characters long.");
                name = char.ToUpper(value[0]) + value.Substring(1);
            }
        }

        public string Phone { get; set; }

        public string Email
        {
            get => email;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 50 || !Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                    throw new ArgumentException("Invalid email format or exceeds 50 characters.");
                email = value;
            }
        }

        public DateTime Birthday
        {
            get => birthday;
            set
            {
                if (value < new DateTime(1900, 1, 1) || value > DateTime.Now)
                    throw new ArgumentException("Birthday must be between 1900 and the current date.");
                birthday = value;
            }
        }

        public string ID_vk
        {
            get => idVk;
            set
            {
                if (value.Length > 15)
                    throw new ArgumentException("ID_vk must not exceed 15 characters.");
                idVk = value;
            }
        }

        public object Clone()
        {
            return new Contact
            {
                Surname = this.Surname,
                Name = this.Name,
                Phone = this.Phone,
                Email = this.Email,
                Birthday = this.Birthday,
                ID_vk = this.ID_vk
            };
        }

        public override string ToString()
        {
            return $"Surname: {Surname}, Name: {Name}, Phone: {Phone}, Email: {Email}, Birthday: {Birthday:yyyy-MM-dd}, ID_vk: {ID_vk}";
        }
    }
}