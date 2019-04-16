using System;
using System.Collections.Generic;
using System.Linq;
using InterfaceTask1.Model;
using InterfaceTask1.Model.Interfaces;

namespace InterfaceTask1.Controller
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
        public Person GetOldestPerson()
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
        public object[] GetPersonsAsListBoxItemObjects()
        {
            var personsAsString = new object[_persons.Count];
            for (var i = 0; i < _persons.Count; i++)
                personsAsString[i] = _persons[i].ToString();
            return personsAsString;
        }
    }
}
