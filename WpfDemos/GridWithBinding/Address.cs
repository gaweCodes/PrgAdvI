using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GridWithBinding.Annotations;

namespace GridWithBinding
{
    public class Address : INotifyPropertyChanged
    {
        private Guid _id;
        private string _street;
        private string _zipCode;
        private string _city;
        public Guid AddressId
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(AddressId));
            }
        }
        public string Street
        {
            get => _street;
            set
            {
                _street = value;
                OnPropertyChanged(nameof(Street));
            }
        }
        public string ZipCode
        {
            get => _zipCode;
            set
            {
                _zipCode = value;
                OnPropertyChanged(nameof(ZipCode));
            }
        }
        public string City
        {
            get => _city;
            set
            {
                _city = value;
                OnPropertyChanged(nameof(City));
            }
        }
        public Address()
        {
            AddressId = Guid.NewGuid();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
