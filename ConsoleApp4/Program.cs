using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp4
{
    public class Program
    {
        public static List<Person> list = new List<Person>();//intializare lista si declarare de tip pesoana 
        public static List<Movie> movies = new List<Movie>();
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            m1.name = "Casa de Papel";
            m1.dateStart = new DateTime(2020, 4, 10, 17, 40, 00);
            m1.dateFinish = new DateTime(2020, 4, 10, 19, 40, 00);
            m1.freeSeats = 20;
            movies.Add(m1); 
            Movie m2 = new Movie();
            m2.name = "Vis a vis";

            // Modificat ca sa testez.
            m2.dateStart = new DateTime(2020, 4, 16, 17, 40, 00); 
            
            m2.dateFinish = new DateTime(2020, 4, 10, 19, 40, 00);
            m2.freeSeats = 20;
            movies.Add(m2);
            bool b;
            int x = -1;
            do
            {
                // Thread.Sleep da un delay acolo unde e pus
                Thread.Sleep(500);
                Console.WriteLine("Daca doriti sa cumparati bilet intruduceti 1 \n\t daca doriti sa renuntati la un bilet introduceti 2");
                do
                {
                    b = true;
                    try
                    {
                        x = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        b = false;
                        // Thread.Sleep da un delay acolo unde e pus
                        Thread.Sleep(500);
                        Console.WriteLine("Nu ati introdus corect");
                    }
                } while (b == false);
                switch (x)
                {
                    case 1:
                        // Thread.Sleep da un delay acolo unde e pus
                        Thread.Sleep(500);
                        Console.WriteLine("Numele filmului dorit");
                        string movie = Console.ReadLine();
                        //ToLower-transforma in litere mici
                        bool pp = false;
                        foreach (Movie m in movies)
                        {
                            if (m.name.ToLower() == movie.ToLower())
                            {
                                // Thread.Sleep da un delay acolo unde e pus
                                Thread.Sleep(1000);
                                Console.WriteLine("S-a gasit filmul");
                                pp = true;
                                if (m.dateStart < DateTime.Now)
                                {
                                    // Thread.Sleep da un delay acolo unde e pus
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Ati ajuns prea tarziu");
                                    // Sa nu treaca mai departe daca a gasit filmul si e deja tarziu.
                                    break;
                                }
                                else
                                {
                                    if (m.freeSeats > 0)
                                    {
                                        Person p1 = new Person();
                                        p1.movie = movie;
                                        p1.first_name = "Ale";
                                        p1.last_name = "Pop";
                                        p1.cnp = "12";
                                        p1.date_entry = m.dateStart;
                                        p1.date_output = m.dateFinish;
                                        p1.seat = m.freeSeats;

                                        // Modificat ca sa testez.
                                        // Thread.Sleep da un delay acolo unde e pus
                                        Thread.Sleep(1000);
                                        Console.WriteLine("New person created");
                                        m.freeSeats--;
                                        // Modificat ca sa testez.
                                        // Thread.Sleep da un delay acolo unde e pus
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Ticket purchased");
                                        // Modificat ca sa testez si sa vad cum merge
                                        // Thread.Sleep da un delay acolo unde e pus
                                        Thread.Sleep(1000);
                                        Console.WriteLine(m.freeSeats + " seats remaining");
                                    }
                                    else
                                    {
                                        // Thread.Sleep da un delay acolo unde e pus
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Nu sunt locuri");
                                    }
                                    break;
                                }
                            }

                        }
                        if (pp == false)
                        {
                            // Thread.Sleep da un delay acolo unde e pus
                            Thread.Sleep(1000);
                            Console.WriteLine("Nu s-a gasit filmul");
                        }
                        break;
                    case 2:
                        // Thread.Sleep da un delay acolo unde e pus
                        Thread.Sleep(1000);
                        Console.WriteLine("Introduceti filmul");
                        string s = Console.ReadLine();
                        bool p = false;
                        foreach (Movie m in movies)
                        {
                            if(m.name.ToLower() == s.ToLower())
                            {

                                // In cazul in care nu a fost vandut niciun bilet, nu trebuie sa fie returnat, nu se poate. Sau cazul in care e prea tarziu.
                                if (m.freeSeats == 20)
                                {
                                    // Thread.Sleep da un delay acolo unde e pus
                                    Thread.Sleep(1000);
                                    Console.WriteLine("There are no tickets sold or it is too late! You don't have to do this!");
                                    break;
                                }
                                m.freeSeats++;
                                p = true;
                                // Thread.Sleep da un delay acolo unde e pus
                                Thread.Sleep(1000);
                                Console.WriteLine("Number of spare seats: " + m.freeSeats);
                                break;
                            }
                        }

                        // Nu e ok cum ai cautat filmul, daca aveai 20 ce faceai? :)
                        // Nu uita de foreach

                        // if (p == false) Console.WriteLine("This movie does not exist!");
                        // if (m1.name.ToLower() == s.ToLower())
                        //     m1.freeSeats++;
                        // else
                        //     m2.freeSeats++;
                        // Console.WriteLine(m1.freeSeats);

                        break;

                }
            } while (x != 0);





            /*  int x = -1;
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
                      }

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
                  } while (x != 0) ;*/
           // foreach (Person p in list)
           //     Console.WriteLine(p);

        }
    }
}
