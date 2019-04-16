using System.Collections.Generic;
using InterfaceTask2.Model.Interfaces;

namespace InterfaceTask2.Controller
{
    public class PersonManager
    {
        private readonly List<IPerson> _persons;
        public PersonManager()
        {
            _persons = new List<IPerson>();
        }
        public void AddPersons(IPerson[] persons)
        {
            _persons.AddRange(persons);
        }
        public object[] GetPersonsAsListBoxItemObjects()
        {
            var personsAsString = new object[_persons.Count];
            for (var i = 0; i < _persons.Count; i++)
                personsAsString[i] = _persons[i].ToString();
            return personsAsString;
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
