using System;
using InterfaceTask3.Model.Interfaces;

namespace InterfaceTask3.Model
{
    public class Person : IPerson
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime Birthdate { get; }
        public Person(string firstName, string lastName, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
        }
        public int GetAge()
        {
            return DateTime.Now.Year - Birthdate.Year;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, Age: {GetAge()}";
        }

        public int CompareTo(object obj)
        {
            var person = (Person)obj;
            int result;
            if (person == null)
                return 1;

            if (string.Compare(LastName, person.LastName, StringComparison.InvariantCultureIgnoreCase) != 0)
                result = string.Compare(LastName, person.LastName, StringComparison.InvariantCultureIgnoreCase);
            else if (string.Compare(FirstName, person.FirstName, StringComparison.InvariantCultureIgnoreCase) != 0)
                result = string.Compare(FirstName, person.FirstName, StringComparison.InvariantCultureIgnoreCase);
            else if (GetAge() > person.GetAge())
                result = 1;
            else if (GetAge() < person.GetAge())
                result = -1;
            else
                result = 0;
            return result;
        }
    }
}
