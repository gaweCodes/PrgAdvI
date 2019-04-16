using System;

namespace InterfaceTask1.Model.Interfaces
{
    public interface IPerson
    {
        string FirstName { get; }
        string LastName { get; }
        DateTime Birthdate { get; }
        int GetAge();
    }
}
