using System;
using System.Collections.Generic;
using InterfaceTask2.Model.Interfaces;

namespace InterfaceTask2.Controller
{
    internal class PersonComparer : IComparer<IPerson>
    {
        public int Compare(IPerson person1, IPerson person2)
        {
            int result;
            if (person1 == null || person2 == null)
            {
                switch (person1)
                {
                    case null when person2 == null:
                        result = 0;
                        break;
                    case null:
                        result = -1;
                        break;
                    default:
                        result = 1;
                        break;
                }
                return result;
            }

            if (string.Compare(person1.LastName, person2.LastName, StringComparison.InvariantCultureIgnoreCase) != 0)
                result = string.Compare(person1.LastName, person2.LastName, StringComparison.InvariantCultureIgnoreCase);
            else if (string.Compare(person1.FirstName, person2.FirstName, StringComparison.InvariantCultureIgnoreCase) != 0)
                result = string.Compare(person1.FirstName, person2.FirstName, StringComparison.InvariantCultureIgnoreCase);
            else if (person1.GetAge() > person2.GetAge())
                result = 1;
            else if (person1.GetAge() < person2.GetAge())
                result = -1;
            else
                result = 0;
            return result;
        }
    }
}
