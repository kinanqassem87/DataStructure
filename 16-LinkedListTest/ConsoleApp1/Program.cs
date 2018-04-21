using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Node
    {
        public object value;
        //this link is represent object of Node so we use link with type Node
        //this is object of Node
        public Node link;
        public Node(object value)
        {
            this.value = value;
        }
        public Node() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node header = new Node("header");
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);

            //link nodes by object from object equal object
            header.link = n1;
            n1.link = n2;
            n2.link = n3;
            n3.link = n4; //don't need n4.link=null , because defualt value is null

            //I need reference variable for point to node that I want to print it, point to first node (header)
            Node n = header;


            //print header and last node value
            while (n!= null)
            {
                Console.WriteLine(n.value);
                //this mean new n equal object link that point to another node, so n point to next node
                n = n.link;
            }


            //print header without last node value
           /* while (n.link != null)
            {
                Console.WriteLine(n.value);
                //this mean new n equal object link that point to another node, so n point to next node
                n = n.link;
            }*/

            //print last value node without print header
            /*
            while (n.link != null)
            {
                //this mean new n equal object link that point to another node, so n point to next node
                n = n.link;
                Console.WriteLine(n.value);
                
            }*/
            Console.ReadKey();

        }
    }
}
