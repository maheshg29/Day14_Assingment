using System;
using System.Collections.Generic;

namespace Day14_Assingment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Day 14 Assingment");

               
                LinkedList<int> my_list = new LinkedList<int>();
   
                my_list.AddFirst(70);
                my_list.AddFirst(30);
                my_list.AddFirst(56);
            

                
                foreach (int data in my_list)
                {
                    Console.WriteLine(data);
                }

            }
    }
}
