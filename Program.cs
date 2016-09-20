using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This game city");
            bool ch = true;
            List<string> allCities = new List<string>();

            while (ch)
            {
                Console.WriteLine("Enter the city name: ");
                string answ = Console.ReadLine();

                /*Do check the city is on the list, adding if it is empty.
                 * check whether there is a list of the city that introduced
                 */

                if (allCities.Count == 0)
                {
                    allCities.Add(answ);
                }

                else
                {
                    string s1 = allCities.Last();
                    if (s1[s1.Length - 1] != answ[0])
                    {
                        Console.WriteLine("You have entered the wrong city");
                        Console.ReadLine();
                        break;
                       // ch = false;
                    }
                    int counter = 0;
                    foreach (var item in allCities)
                    {
                        
                        if (item == answ)
                        {                            
                            Console.WriteLine("There has already been a city");
                            Console.ReadLine();
                            counter++;
                            ch = true;                                                        
                        }                        
                    }
                    if (ch == true && counter == 0 )
                    {
                        allCities.Add(answ);
                    }
                }                
                Console.Clear();
            }

            //if (allCities.Contains(answ)) Console.WriteLine("There has already been a city");
            //allCities.Add(answ);
        }
        // while (Console.ReadKey().Key != ConsoleKey.Escape); 
    }
}

