using System;
using System.Windows.Forms;
using InterfaceTask2.Controller;
using InterfaceTask2.Model;
using InterfaceTask2.Model.Interfaces;

namespace InterfaceTask2.View
{
    public partial class Main : Form
    {
        private PersonManager _manager = new PersonManager();
        public Main()
        {
            InitializeComponent();
        }

        private void BtnSort_Click(object sender, System.EventArgs e)
        {
            LsbPersons.Items.Clear();
            LsbPersons.Items.AddRange(_manager.GetSortedPersonsAsListBoxItemObjects());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            IPerson[] persons = {new Person("Gabriel", "Weibel", DateTime.Parse("29.06.1995")), new Person("Markus", "Weibel", DateTime.Parse("30.04.1956")), new Person("Esther", "Weibel", DateTime.Parse("30.04.1969")), new Person("Markus", "Weibel", DateTime.Parse("30.04.1957")), new Person("Roland", "Aeschlimann", DateTime.Parse("30.04.1957")) };
            _manager.AddPersons(persons);
            LsbPersons.Items.Clear();
            LsbPersons.Items.AddRange(_manager.GetPersonsAsListBoxItemObjects());
        }
    }
}
