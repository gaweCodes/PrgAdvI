using System.Windows;
using System.Windows.Controls;
using Datasource;

namespace Testat_Wpf_Kundenverwaltung
{
    public partial class MainWindow
    {
        private Data Source { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            const int firstIndex = 0;
            Source = Data.Load();
            LstCustomers.ItemsSource = Source.Customers.CustomerList;
            LstCustomers.SelectedItem = Source.Customers.CustomerList[firstIndex];
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Source.Save();
            Close();
        }
        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var senderListBox = (ListBox)sender;
            DataContext = senderListBox.SelectedItem;
        }
        /**
         * Wird nicht mehr benötigt. Weil wir jetzt ein fancy binding haben.
         * Zusätzlich wird Vor und Zurück Button mehr gebraucht. Changed Event der Liste.
         */
        /*private void LoadCurrentCustomer()
        {
            if (CurrentIndex >= Source.Customers.CustomerList.Count)
                CurrentIndex = Source.Customers.CustomerList.Count - 1;
            else if (CurrentIndex <= 0)
                CurrentIndex = 0;

            var customer = Source.Customers.CustomerList[CurrentIndex];
            TxtCustomerId.Text = customer.CustomerID;
            TxtCompanyName.Text = customer.CompanyName;
            TxtContactName.Text = customer.ContactName;
            TxtContactTitle.Text = customer.ContactTitle;
            TxtPhone.Text = customer.Phone;
            TxtFax.Text = customer.Fax;
            DatBirthday.SelectedDate = customer.Birthday == DateTime.MinValue ? (DateTime?)null : customer.Birthday;
        }

        private void SaveCurrentCustomer()
        {
            var customer = Source.Customers.CustomerList[CurrentIndex];
            customer.CustomerID = TxtCustomerId.Text;
            customer.CompanyName = TxtCompanyName.Text;
            customer.ContactName = TxtContactName.Text;
            customer.ContactTitle = TxtContactTitle.Text;
            customer.Phone = TxtPhone.Text;
            customer.Fax = TxtFax.Text;
            customer.Birthday = DatBirthday.SelectedDate ?? DateTime.MinValue;
        }*/
    }
}
