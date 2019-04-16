using System;
using InterfaceTask2.Model.Interfaces;

namespace InterfaceTask2.Model
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
            if (LastName.ToUpper().CompareTo(person.LastName.ToUpper()) == 0)
            {
                if (FirstName.ToUpper().CompareTo(person.FirstName.ToUpper()) == 0)
                {
                    if (person.GetAge() < GetAge())
                        return 1;
                    if (person.GetAge() > GetAge())
                        return -1;
                    return 0;
                }
                return FirstName.ToUpper().CompareTo(person.FirstName.ToUpper());
            }
            return LastName.ToUpper().CompareTo(person.LastName.ToUpper());
        }
        /*public int CompareTo(object obj)
        {
            var person = (Person) obj;
            if (person.LastName.ToUpper().CompareTo(LastName.ToUpper()) == 0)
            {
                if (person.FirstName.ToUpper().CompareTo(FirstName.ToUpper()) == 0)
                {
                    if (person.GetAge() > GetAge())
                        return 1;
                    if (person.GetAge() < GetAge())
                        return -1;
                    return 0;
                }
                return person.FirstName.ToUpper().CompareTo(FirstName.ToUpper());
            }
            return person.LastName.ToUpper().CompareTo(LastName.ToUpper());
        }*/
    }
}
