using System;
using System.Windows.Forms;
using InterfaceTask1.Controller;
using InterfaceTask1.Model;

namespace InterfaceTask1.View
{
    public partial class Main : Form
    {
        private readonly PersonManager _manager = new PersonManager();
        public Main()
        {
            InitializeComponent();
        }

        private void BtnCreatePerson_Click(object sender, EventArgs e)
        {
            var person = new Person(TxtFirstName.Text, TxtLastName.Text, DtpBirthdate.Value);
            _manager.AddPerson(person);
            LsbPersons.Items.Clear();
            LsbPersons.Items.AddRange(_manager.GetPersonsAsListBoxItemObjects());
        }

        private void BtnGetOldestPerson_Click(object sender, EventArgs e)
        {
            LblOldestPerson.Text = $@"{_manager.GetOldestPersonAsString()} years old!";
        }
    }
}
