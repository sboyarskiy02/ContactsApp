using ContactAppLogic;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContactApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик нажатия кнопки для создания контакта
        private void btnCreateContact_Click(object sender, EventArgs e)
        {
            try
            {
                // Считываем данные из текстовых полей
                string surname = txtSurname.Text;
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;
                DateTime birthday = dtpBirthday.Value; // Выбор даты
                string idVk = txtIDVk.Text;

                // Создаем новый экземпляр Contact
                Contact contact = new Contact(surname, name, phone, email, birthday, idVk);

                // Отображаем результат на экране в Label
                lblResult.Text = contact.ToString();
            }
            catch (ArgumentException ex)
            {
                // В случае ошибки отображаем сообщение
                MessageBox.Show("Error: " + ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик кнопки для клонирования контакта
        private void btnCloneContact_Click(object sender, EventArgs e)
        {
            try
            {
                // Считываем данные из текстовых полей
                string surname = txtSurname.Text;
                string name = txtName.Text;
                string phone = txtPhone.Text;
                string email = txtEmail.Text;
                DateTime birthday = dtpBirthday.Value;
                string idVk = txtIDVk.Text;

                // Создаем новый экземпляр Contact
                Contact contact1 = new Contact(surname, name, phone, email, birthday, idVk);

                // Клонируем контакт
                Contact contact2 = (Contact)contact1.Clone();

                // Отображаем результат на экране
                lblResult.Text = "Cloned contact: " + contact2.ToString();
            }
            catch (ArgumentException ex)
            {
                // В случае ошибки отображаем сообщение
                MessageBox.Show("Error: " + ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}