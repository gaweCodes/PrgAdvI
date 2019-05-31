using System;
using System.Collections;

namespace _1._3_ArrayListOperationen
{
    public delegate void Action(string s);
    public delegate bool Predicate(string s);
    internal class Program
    {
        private static void Main()
        {
            var list = GetNameList();
            
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Liste aller Namen:");
            ForAll(list, Console.WriteLine);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Liste aller Namen mit 'S':");

            var listStartsWithS = Find(list, s => s.Trim().StartsWith("S"));
            ForAll(listStartsWithS, Console.WriteLine);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Liste aller Namen mit Länge >= 15:");

            var listLength15Plus = Find(list, delegate(string s) { return s.Length >= 16; });
            ForAll(listLength15Plus, delegate(string s) { Console.WriteLine(s); });

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Konkatenierter String:");

            var concatenated = string.Empty;
            ForAll(list, delegate(string s) { concatenated += s + ";"; });
            Console.WriteLine(concatenated);
            Console.ReadLine();
        }

        private static void ForAll(ArrayList list, Action action)
        {
            if (action == null) return;
            foreach (var line in list) action.Invoke((string)line);
        }
        private static ArrayList Find(ArrayList list, Predicate predicate)
        {
            var filtered = new ArrayList();
            if (predicate == null)
                return filtered;

            foreach (var line in list)
            {
                if (predicate((string) line))
                    filtered.Add(line);
            }

            return filtered;
        }
        private static ArrayList GetNameList()
        {
            return new ArrayList {
                "Shaun Byler",
                "Regenia Politte",
                "Earleen Huard",
                "Evelin Svoboda",
                "Phuong Briese",
                "Shea Sailor",
                "Kerri Seese",
                "Dulce Spalla",
                "Cedrick Bohr",
                "Pearline Abele",
                "Chas Grossi",
                "Teresa Winkelman",
                "Marilee Keaton",
                "Karisa Millender",
                "Nickie Borders",
                "Hoyt Eicher",
                "Ula Harjo",
                "Willodean Byerly",
                "Sirena Vives",
                "Johnnie Folkers"
            };
        }
    }
}
