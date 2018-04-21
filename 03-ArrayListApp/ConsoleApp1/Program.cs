using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class student
    {
        int sid;
        string sname;
        double sgpa;
        public student() { }
        public student(int sid, string sname, double sgpa)
        {
            this.sid = sid;
            this.sname = sname;
            this.sgpa = sgpa;
        }
        public void print()
        {
            Console.WriteLine("Student id : {0}\nStudent name : {1}\nStudent GPA: {2}",sid,sname,sgpa);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //First App
            
            //declare array
            int[] arr = { 2, 3, 4, 1, 0 };
            ArrayList arrlist = new ArrayList();
            //copy array to arraylist with duplicate each item with its number
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i]; j++)
                {
                    arrlist.Add(arr[i]);
                }
            }
            //show the arraylist
            foreach (object item in arrlist)
            {
                Console.WriteLine(item);
            }
            //sum the element of arraylist
            int sum = 0;
            for (int k = 0; k < arrlist.Count; k++)
            {
                sum += (int)arrlist[k];
                //or 
               // sum += Convert.ToInt32(arrlist[k]);
               //don't use parse becuase it used to convert string only not object
            }
            Console.WriteLine("sum = " + sum);
           //or this
           // Console.WriteLine("sum =  {0}" , sum);

            //reverse arraylist
            arrlist.Reverse();
            Console.WriteLine("After reverse ***********");
            foreach (object item in arrlist)
            {
                Console.WriteLine(item);
            }
            //End App1
            */

            //********************************

            //App2

            ArrayList Studentlist = new ArrayList();
            Console.WriteLine("How many students do you want to inter them?");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < input; i++)
            {
                Console.Write("id = ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nname = ");
                string name = Console.ReadLine();
                Console.Write("\nGPA = ");
                double gpa = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                //student s = new student(id, name, gpa);
                //Studentlist.Add(s);
                //or
                Studentlist.Add(new student(id, name, gpa));

            }
            student st = new student(1234, "unknown", 0.0);
            Studentlist.Insert(1,st);
            //or
            // Studentlist.Insert(1, new student(1234, "unknown", 0.0));
            foreach (student item in Studentlist)
            {
                item.print();
                Console.WriteLine("*********");
            }
            //or
            //for (int i = 0; i < Studentlist.Count; i++)
            //{
            //    ((student)Studentlist[i]).print();
            //}


            //End App2

            Console.ReadKey();

        }
    }
}
