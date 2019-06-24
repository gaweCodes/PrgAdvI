using System;
using System.Windows;
using Datasource;

namespace Testat_Wpf_Kundenverwaltung
{
    public partial class MainWindow
    {
        private Data Source { get; set; }
        private int CurrentIndex { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            SaveCurrentCustomer();
            Source.Save();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Source = Data.Load();
            CurrentIndex = 0;
            LoadCurrentCustomer();
        }
        private void LoadCurrentCustomer()
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
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            SaveCurrentCustomer();
            CurrentIndex++;
            LoadCurrentCustomer();
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            SaveCurrentCustomer();
            CurrentIndex--;
            LoadCurrentCustomer();
        }
    }
}
