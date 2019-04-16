using System.Windows.Forms;
using InterfaceTask3.Controller;
using InterfaceTask3.Model;

namespace InterfaceTask3.View
{
    public partial class Main : Form
    {
        private readonly PersonManager _manager = new PersonManager();
        public Main()
        {
            InitializeComponent();
        }

        private void BtnCreatePerson_Click(object sender, System.EventArgs e)
        {
            var person = new Person(TxtFirstName.Text, TxtLastName.Text, DtpBirthdate.Value);
            _manager.AddPerson(person);
            LsbPersons.Items.Clear();
            LsbPersons.Items.AddRange(_manager.GetSortedPersonsAsListBoxItemObjects());
        }

        private void BtnGetOldestPerson_Click(object sender, System.EventArgs e)
        {
            LblOldestPerson.Text = $"{_manager.GetOldestPersonAsString()} years old!";
        }
    }
}
