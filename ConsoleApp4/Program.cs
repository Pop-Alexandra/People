using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    public class Program
    {
       public static List<Person> list = new List<Person>();//intializare lista si declarare de tip pesoana 
        static void Main(string[] args)
        {
            int x = -1;
            do
            {
                Console.WriteLine("Daca doriti sa introduceti persoane introduceti 1 sau\n\t 0 daca doriti sa iesiti sau\n\t 2 daca doriti sa stergeti \n\t 3 editare persoana \n\t 4 afisarea persoanelor in functie de ore \n\t 5 afisarea persoanelor in functie de minute");
                bool b;
                do
                {
                    b = true;
                    try
                    {
                        x = int.Parse(Console.ReadLine());

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Reintroduceti");
                        b = false;


                    }
                } while (b == false);
                if (x == 0)
                    break;
                if (x == 1)
                {
                    Person p = new Person();
                    p.Intoducere();
                }
                if (x == 2)
                {
                    Console.WriteLine("Introduceti cnp");
                    string cnp = Console.ReadLine();
                    foreach (Person i in list)
                    {
                        if (i.cnp == cnp)
                        {
                            list.Remove(i);
                            break;
                        }
                    }
                }
                if (x == 3)
                {
                    Console.WriteLine("Introduceti cnp");
                    string cnp = Console.ReadLine();
                    foreach (Person i in list)
                    {
                        if (i.cnp == cnp)
                        {
                            Console.WriteLine("nume: " + i.last_name);
                            Console.Write("nume nou: ");
                            string nume = Console.ReadLine();
                            if (!(nume == " " || nume == ""))
                                i.last_name = nume;
                            Console.WriteLine("prenume: " + i.first_name);
                            Console.Write("prenume nou: ");
                            string prenume = Console.ReadLine();
                            if (!(prenume == " " || prenume == ""))
                                i.first_name = prenume;
                            break;
                        }
                    }
                }
              /*  if (x == 4)
                {
                    string hour;
                    Console.Write("ora: ");
                    hour = Console.ReadLine();
                    int y = Int32.Parse(hour);
                    if ((y > 9))
                    {
                        foreach (Person i in list)
                        {
                            if ((i.date_entry[11] == hour[0]) && (i.date_entry[12] == hour[1]))
                                Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        foreach (Person i in list)
                        {
                            if ((i.date_entry[12] == hour[0]))
                                Console.WriteLine(i);
                        }
                    }
                }
                if(x==5)
                {
                    string minutes;
                    Console.WriteLine("minute: ");
                    minutes = Console.ReadLine();
                    foreach(Person i in list)
                    {
                        if ((i.date_entry[14]==minutes[0]) &&(i.date_entry[15]==minutes[1]))
                            Console.WriteLine(i);
                    }*/
                
                if(x==5)
                {
                    int minutes;
                    Console.Write("minute: ");
                    minutes = int.Parse(Console.ReadLine());
                    foreach(Person p in list)
                    {
                        if(p.date_entry.Minute==minutes)
                            Console.WriteLine(p);
                    }
                }
                ///p
                } while (x != 0) ;
                foreach (Person p in list)
                    Console.WriteLine(p);
            
        }
    }
}
