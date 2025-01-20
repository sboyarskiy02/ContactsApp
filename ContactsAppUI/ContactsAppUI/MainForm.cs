using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "ContactsApp";
            this.Size = new Size(400, 250);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        // Обработчик для кнопки "Добавить контакт"
        {
            var addEditForm = new WindowsAddEditContactForm();
            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                contacts.Add(addEditForm.Contact);
                UpdateContactList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_edit_click_Click(object sender, EventArgs e)
        {

        }
    }
}


