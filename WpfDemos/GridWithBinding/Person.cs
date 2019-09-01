using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GridWithBinding.Annotations;

namespace GridWithBinding
{
    public class Person : INotifyPropertyChanged, IDataErrorInfo
    {
        private Guid _id;
        private string _firstName;
        private string _lastName;
        private string _fullName;
        private int _age;
        public Guid PersonId
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(PersonId));
            }
        }
        public string FirstName
        {
            get => _firstName;
            set { _firstName = value; OnPropertyChanged(nameof(FirstName)); }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }
        public string FullName
        {
            get => _fullName;
            private set { _fullName = value; OnPropertyChanged(nameof(FullName)); }
        }

        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
        public ObservableCollection<Address> Addresses { get; set; }
        public Person()
        {
            PersonId = Guid.NewGuid();
            Error = null;
            Addresses = new ObservableCollection<Address>();
        }
        private static Person _instance;
        public static Person Instance => _instance ?? (_instance = new Person());
        public event PropertyChangedEventHandler PropertyChanged;
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName == nameof(FirstName) || propertyName == nameof(LastName))
                FullName = FirstName + " " + LastName;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string this[string columnName]
        {
            get
            {
                if (columnName != nameof(Age)) return null;
                if (Age < 0 || Age > 150)
                    return "Age must not be less than 0 or greater than 150.";
                return null;
            }
        }

        public string Error { get; }
    }
}
