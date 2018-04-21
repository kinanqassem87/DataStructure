using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "shaza", "Rayan" };

           // string[] name = new string[10];
            ArrayList list = new ArrayList() { "kinan", "zain", "rayan","Ahmad","kinan","Ali","sara","Yara"};


            //or add by this way
            //list.Add("Kinan");
            //list.Add("Kinan");
            //list.Add("Kinan");
            //list.Add("Kinan");
            //list.Add("Kinan");

            //add array arr to list
            //list.AddRange(arr);

            //to get items
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //or use this
            //foreach (object n in list)
            //{
            //    Console.WriteLine(n.ToString());
            //}

            //Console.WriteLine(list.Capacity);
            //Console.WriteLine(list.Count);

            //to clear list
            //list.Clear();
            //Console.WriteLine(list.Capacity);
            //Console.WriteLine(list.Count);

            //can determine capacity but it must greater than count
            // list.Capacity = 6;

            //search for object return true or false and it case sensitive
            //if (list.Contains("kinan")) {Console.WriteLine("Founded"); }

            //copy items of arraylist to normal array
            //list.CopyTo(name);
            //Console.WriteLine(name[1]);

            //or copy from index 
            //let
            //name[0] = "Ahmad";
            //name[1] = "kinan";
            //list.CopyTo(name,2);
            //Console.WriteLine(name[5]);

            //or copy from index in list to array in index and determin number of item to copy
            //name[0] = "Ahmad";
            //name[1] = "kinan";
            //list.CopyTo(1,name, 2,2);
            //Console.WriteLine(name[3]);

            //make sub arraylist into from arraylist with index and count items
            //ArrayList sublist = list.GetRange(4, 4);
            //Console.WriteLine(sublist[3]);
            //ArrayList sublist2 = list.GetRange(0, 4);
            //Console.WriteLine(sublist2[3]);

            //get index of item
            //Console.WriteLine(list.IndexOf("kinan"));

            //get index of item and begin search from specific index 
            //Console.WriteLine(list.IndexOf("kinan",2));

            //or by index and count
            //Console.WriteLine(list.IndexOf("kinan", 2,3));

            //insert item
            //list.Insert(2, "Fadi");
            //Console.WriteLine(list[2]);
            //Console.ReadKey();

            //insert array in list
            //list.InsertRange(4, arr);
            //Console.WriteLine(list[5]);

            //last index of this item
            //Console.WriteLine(list.LastIndexOf("kinan"));

            //remove item by value only remove one item
            //list.Remove("kinan");
            //Console.WriteLine(list[3]);

            //remove item by index
            //list.RemoveAt(3);
            //Console.WriteLine(list[3]);

            //remove range togother
            //list.RemoveRange(2, 3);
            //Console.WriteLine(list[3]);

            //reverse array
            //foreach (object n in list)
            //{
            //    Console.WriteLine(n.ToString());
            //}
            //list.Reverse();
            //Console.WriteLine("**************");
            //foreach (object n in list)
            //{
            //    Console.WriteLine(n.ToString());
            //}

            //convert arraylist to object of array to easy use
            //object[] Oarr = list.ToArray();
            //foreach (object n in Oarr)
            //{
            //    Console.WriteLine(n.ToString());
            //}

            //sort array
            //foreach (object n in list)
            //{
            //    Console.WriteLine(n.ToString());
            //}
            //Console.WriteLine("**************");
            //list.Sort();
            //foreach (object n in list)
            //{
            //    Console.WriteLine(n.ToString());
            //}

            //convert capacity to real count num
            //list.Capacity = list.Count; this is equivalent that
            list.TrimToSize();
            Console.WriteLine(list.Capacity);
           
            
            Console.ReadKey();
        }
    }
}
