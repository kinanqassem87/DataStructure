using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string website = "www.google.com";
        static void menu()
        {
            Console.Clear();
            Console.WriteLine("------------------------------"+ website + "-------------------------------");
            Console.WriteLine("1-   new website");
            Console.WriteLine("2-   Back");
            Console.WriteLine("3-   Forward");
            Console.WriteLine("0-   Exit");
            Console.WriteLine("Enter the choice : ");
        }

        static void Main(string[] args)
        {
            Stack<string> back = new Stack<string>();
            Stack<string> forward = new Stack<string>();

            while (true)
            {
                menu();
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        back.Push(website);
                        website = Console.ReadLine();
                        forward.Clear();
                        break;
                    case "2":
                        if (back.Count != 0)
                        {
                            forward.Push(website);
                            website = back.Pop();
                        }
                        Console.WriteLine(website);
                        break;
                    case "3":
                        if (forward.Count != 0)
                        {
                            back.Push(website);
                            website = forward.Pop();
                        }
                        Console.WriteLine(website);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
