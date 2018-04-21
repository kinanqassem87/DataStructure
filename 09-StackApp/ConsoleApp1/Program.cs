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
            /* App 1
            //check if the input string stay the same after reserve it (palindrome)
            Console.WriteLine("Input the statment ");
            string input=Console.ReadLine();
            Stack<char> letter = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                letter.Push(input[i]);
            }
            string temp = "";
            while (letter.Count > 0)
            {
                temp+=letter.Pop();
            }
            Console.WriteLine(input.Equals(temp) ? true:false) ;
            /*if (input.Equals(temp))
            {
                Console.WriteLine("Its palindrome");
            }*/



            //App 2
            //check if the input string is balance
            //ex: {()} true
            //{{(())}} true
            // [[])  false
            // ({)}  false
           lab: Console.WriteLine("Input your string");
            string input = Console.ReadLine();
            Stack<char> close = new Stack<char>();
            bool status = false;

            if (input.Length % 2 == 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i].Equals('{'))
                        close.Push('}');
                    else if (input[i].Equals('('))
                        close.Push(')');
                    else if (input[i].Equals('['))
                        close.Push(']');

                    if (input[i].Equals('}')|| input[i].Equals(')') || input[i].Equals(']'))
                    {
                        if ((input[i].Equals('}')) && (input[i].Equals(close.Peek())))
                        {
                            status = true;
                        }
                        else if ((input[i].Equals(')')) && (input[i].Equals(close.Peek())))
                        {
                            status = true;
                        }
                        else if ((input[i].Equals(']')) && (input[i].Equals(close.Peek())))
                        {
                            status = true;
                        }
                        else { status = false;break; }
                        close.Pop();
                    }
                      
                }
            }

            Console.WriteLine(status);
            goto lab;
            
        }
    }
}
