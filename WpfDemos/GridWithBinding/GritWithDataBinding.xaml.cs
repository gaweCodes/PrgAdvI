using System.Windows;
using System.Windows.Controls;

namespace GridWithBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateAddress(object sender, RoutedEventArgs e)
        {
            Person.Instance.Addresses.Add(new Address {Street = "Säntisstrasse 2", City = "Schwarzenbach", ZipCode = "9536"});
        }

        private void SelectedAddressChanged(object sender, SelectionChangedEventArgs e)
        {
            var senderListBox = (ListBox)sender;
            AddressGrid.DataContext = senderListBox.SelectedItem;
        }
    }
}
