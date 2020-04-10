using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Person
    {
        public string cnp;
        public string last_name;
        public string first_name;
        public DateTime date_entry;
        public DateTime date_output;
        public void Intoducere ()
        {
            Person p = new Person();//crearea unui oviect
            Console.Write("CNP: ");
            p.cnp = Console.ReadLine();
            Console.Write("nume:");
            p.last_name = Console.ReadLine();
            Console.Write("prenume:");
            p.first_name = Console.ReadLine();
            p.date_entry = DateTime.Now;
            Console.WriteLine($"data de intrare {p.date_entry}");
            p.date_output = DateTime.Now;
            Console.WriteLine($"data de iesire {p.date_output}");
            Program.list.Add(p); //introduc in lista obiectul de tip persoana
        }
        public override string ToString()
        {
           return string.Format($" {cnp} {last_name} {first_name} {date_entry} {date_output}");
        }
    }
}
