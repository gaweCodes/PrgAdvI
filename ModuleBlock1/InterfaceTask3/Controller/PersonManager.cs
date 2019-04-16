using System;
using System.Collections.Generic;
using System.Linq;
using InterfaceTask3.Model;
using InterfaceTask3.Model.Interfaces;

namespace InterfaceTask3.Controller
{
    public class PersonManager
    {
        private readonly List<IPerson> _persons;
        public PersonManager()
        {
            _persons = new List<IPerson>();
        }
        public void AddPerson(IPerson person)
        {
            if (person == null) throw new ArgumentNullException("The argument is null");
            _persons.Add(person);
        }

        private Person GetOldestPerson()
        {
            if (!_persons.Any()) return null;

            var oldestPerson = _persons.First();
            foreach (var person in _persons)
            {
                if (oldestPerson.GetAge() < person.GetAge())
                    oldestPerson = person;
            }
            return (Person)oldestPerson;
        }
        public string GetOldestPersonAsString()
        {
            return GetOldestPerson().ToString();
        }
        public object[] GetSortedPersonsAsListBoxItemObjects()
        {
            //IComparable alternative _persons.Sort();
            //IComparer alternative
            _persons.Sort(new PersonComparer());
            var count = _persons.Count;
            var personsAsString = new object[count];
            for (var i = 0; i < count; i++)
                personsAsString[i] = _persons[i].ToString();
            return personsAsString;
        }
    }
}
