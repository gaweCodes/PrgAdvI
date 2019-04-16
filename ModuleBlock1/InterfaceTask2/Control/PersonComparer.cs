using System.Collections.Generic;
using InterfaceTask2.Model.Interfaces;

namespace InterfaceTask2.Control
{
    internal class PersonComparer : IComparer<IPerson>
    {
        public int Compare(IPerson x, IPerson y)
        {
            // In einzelnen Schritten

            // Zuerst Argumente zurück in Person Objekte casten
            // Person one = (Person)x;
            // Person two = (Person)y;

            // Nachnamen der ersten Person beschaffen und in Grossbuchstaben umwandeln
            // string lastnameOne = one.Lastname.ToUpper();

            // Nachname der zweiten Person beschaffen und in Grossbuchstaben umwandeln
            // string lastnameTwo = two.Lastname.ToUpper();

            // Strings mittels der String-Klasse miteinander vergleichen lassen
            // Liefert grösser als 0, wenn lastnameOne grösser (lexikalische Prüfung)
            // Liefert 0, wenn beide identisch
            // Liefert kleiner als 0, wenn lastnameOne kleiner (lexikalische Prüfung)
            // int result = lastnameOne.CompareTo(lastnameTwo); 

            // Ergebnis zurückgeben an Aufrufstelle (also Sort)
            // return result

            // Alles in einer Zeile zusammengefasst 
            // Wenn die Nachnamen zweier Person identisch, dann vergleiche die Vornamen
            if (x.LastName.ToUpper().CompareTo(y.LastName.ToUpper()) == 0)
            {
                // Wenn die Vornamen zweier Person identisch, dann vergleiche die Nachnamen
                if (x.FirstName.ToUpper().CompareTo(y.FirstName.ToUpper()) == 0)
                {
                    if (x.GetAge() > y.GetAge())
                        return 1;
                    if (x.GetAge() < y.GetAge())
                        return -1;
                    return 0;
                }

                return x.FirstName.ToUpper().CompareTo(y.FirstName.ToUpper());
            }

            return x.LastName.ToUpper().CompareTo(y.LastName.ToUpper());
        }
    }
}
