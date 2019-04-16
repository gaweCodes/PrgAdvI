using System;

namespace InterfaceTask3.Model.Interfaces
{
    public interface IPerson //Alternative way to sort : IComparable
    {
        string FirstName { get; }
        string LastName { get; }
        DateTime Birthdate { get; }
        int GetAge();
    }
}
