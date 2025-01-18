using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAppLogic
{
    public class NumberTelephone
    {
        private string number;

        public string Number
        {
            get => number;
            set
            {
                // Проверяем, что номер состоит ровно из 11 цифр и начинается с "7"
                if (string.IsNullOrWhiteSpace(value) || value.Length != 11 || !long.TryParse(value, out _) || value[0] != '7')
                {
                    throw new ArgumentException("The phone number must consist of exactly 11 digits and start with '7'.");
                }
                number = value;
            }
        }

        public override string ToString()
        {
            return $"Phone Number: {Number}";
        }
    }
}