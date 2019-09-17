using System.Windows.Controls;

namespace MvvmDemo.Customers
{
    public partial class CustomerListView : UserControl
    {
        public CustomerListView()
        {
            InitializeComponent();
            DataContext = new CustomerListViewModel();
        }
    }
}
