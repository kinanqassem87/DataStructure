using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //App1
            /*
            Queue<char> inputs = new Queue<char>();
            inputs.Enqueue('A');
            inputs.Enqueue('%');
            inputs.Enqueue('5');
            inputs.Enqueue('B');
            inputs.Enqueue('&');
            inputs.Enqueue('C');
            inputs.Enqueue('7');
            inputs.Enqueue('9');

            Queue<char> letters = new Queue<char>();
            Queue<char> numbers = new Queue<char>();
            Queue<char> symbol = new Queue<char>();
            while (inputs.Count > 0)
            {
                //use peek becuase I have several conditions so Dequeue will remove item 
                if (inputs.Peek() >= '0' && inputs.Peek() <= '9')
                {
                    numbers.Enqueue(inputs.Dequeue());
                }
                else if (inputs.Peek() >= 'A' && inputs.Peek() <= 'Z')
                {
                    letters.Enqueue(inputs.Dequeue());
                }
                else
                {
                    symbol.Enqueue(inputs.Dequeue());
                }
            }
            Console.WriteLine("------Letters-------");
            foreach (char letter in letters)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine("------Numbers-------");
            foreach (char num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("------Symbol-------");
            foreach (char symbol1 in symbol)
            {
                Console.WriteLine(symbol1);
            }

            Console.WriteLine("************************\n************************");
            */
            //App2  som of odd numbers and sum of even numbers
            /*
            Queue<int> elements = new Queue<int>();
            Console.WriteLine("Please input the numbers of element ");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Please inter the number");
                elements.Enqueue(int.Parse(Console.ReadLine()));
            }
            int sumeven = 0;
            int sumodd = 0;
            while (elements.Count > 0)
            {
                if (elements.Peek() % 2 == 0) { sumeven += elements.Dequeue(); }
                else { sumodd += elements.Dequeue(); }
            }

            Console.WriteLine("sum even = " + sumeven);
            Console.WriteLine("sum odd = " + sumodd);
            */

            Console.WriteLine("************************\n************************");
            //App3

            Queue<string> letters = new Queue<string>();
            //Add letters capital and small like Aa,Bb....
            for (char i = 'A'; i <= 'Z'; i++)
            {
                letters.Enqueue(i + " " +char.ToLower(i));
            }
            foreach (string item in letters)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
