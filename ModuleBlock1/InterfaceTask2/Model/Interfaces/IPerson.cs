using System;

namespace InterfaceTask2.Model.Interfaces
{
    public interface IPerson : IComparable
    {
        string FirstName { get; }
        string LastName { get; }
        DateTime Birthdate { get; }
        int GetAge();
    }
}
