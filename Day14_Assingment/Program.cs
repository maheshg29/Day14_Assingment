using System;
using System.Collections.Generic;

namespace Day14_Assingment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Day 14 Assingment");
            //UC1
                LinkedList<int> my_list = new LinkedList<int>();
                my_list.AddFirst(70);
                my_list.AddFirst(30);
                my_list.AddFirst(56);

                foreach (int data in my_list)
                {
                    Console.WriteLine(data);
                }

            Console.WriteLine("Remove Data");
            Console.WriteLine(my_list.ElementAt(0));
            my_list.RemoveFirst();

            foreach (int data in my_list)
            {
                Console.WriteLine("after removing");
                Console.WriteLine(data);
            }
            Console.WriteLine(my_list.ElementAt(0));
            my_list.RemoveFirst();

            foreach (int data in my_list)
            {
                Console.WriteLine("after removing");
                Console.WriteLine(data);
            }
            Console.WriteLine(my_list.ElementAt(0));
            my_list.RemoveFirst();
            foreach (int data in my_list)
            {
                Console.WriteLine("after removing");
                Console.WriteLine(data);
            }
            my_list.Clear();

            linklist1 linklist1 = new linklist1();
            linklist1.Enqueue(56);
            linklist1.Enqueue(30);
            linklist1.Enqueue(70);
           

        }
    }
}
