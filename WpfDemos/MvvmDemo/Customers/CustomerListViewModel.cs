using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using MvvmDemo.Data;
using MvvmDemo.Services;

namespace MvvmDemo.Customers
{
    public class CustomerListViewModel
    {
        private readonly ICustomersRepository _repository = new CustomersRepository();
        public CustomerListViewModel()
        {
            if (DesignerProperties.GetIsInDesignMode(new DependencyObject())) return;
            Customers = new ObservableCollection<Customer>(_repository.GetCustomersAsync().Result);
            // Man kann auch eine Entsprechende Funktion schreiben
            // DeleteCommand = new RelayCommand(OnDelete, CanDelete);
            DeleteCommand = new RelayCommand(() => Customers.Remove(SelectedCustomer), () => SelectedCustomer != null);
        }
        public RelayCommand DeleteCommand { get; }
        public ObservableCollection<Customer> Customers { get; set; }
        private Customer _selectedCustomer;
        public Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }
        private void OnDelete() => Customers.Remove(SelectedCustomer);
        private bool CanDelete() => SelectedCustomer != null;
    }
}
