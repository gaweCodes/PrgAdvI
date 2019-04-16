using System;
using InterfaceTask1.Model.Interfaces;

namespace InterfaceTask1.Model
{
    public class Person : IPerson
    {
        public Person(string firstName, string lastName, DateTime birthdate)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public DateTime Birthdate { get; }

        public int GetAge()
        {
            return DateTime.Now.Year - Birthdate.Year;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Birthdate.ToShortDateString()} Age: {GetAge()}";
        }
    }
}
