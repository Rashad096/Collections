using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace MayListArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[0];

            MyStringList names = new MyStringList();
            names.Add("Rashad");
            names.Add("Farid");
            names.Add("Huseyin");
            names.Add("Isa");
            names.RemoveAt(2);
           
            foreach (var item in names.Array)
            {
                Console.WriteLine(item);
            }

            var arraylist = new ArrayList();

            arraylist.Add("Hello");
            arraylist.Add(234);
            arraylist.Add(true);

            var arlist2 = new ArrayList()
                {
                    2, "Privet", " ", true, 4.5, null
                };


            arraylist.AddRange(arlist2);


            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }

            arraylist.RemoveAt(1);
            arraylist.Remove("Hello");

            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(5);
            nums.Add(7);

            var Azcities = new List<string>();
            Azcities.Add("Shemkir");
            Azcities.Add("Quba");
            Azcities.Add("Lenkeran");
            Azcities.Add("Masalli");

            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); 
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            foreach (var item in numberNames)
            {
                // Console.WriteLine(item);

                Console.WriteLine(item.Key);

                Console.WriteLine(item.Value);
            }

            Console.WriteLine(numberNames.ContainsKey(1));




            Stack<int> numbersstak = new Stack<int>();
            numbersstak.Push(1);
            numbersstak.Push(2);
            numbersstak.Push(3);
            numbersstak.Push(4);

            numbersstak.Pop();
            Console.WriteLine(numbersstak.Peek()); 
            numbersstak.Contains(2); 
            numbersstak.Contains(10);

            //foreach (var item in numbersstak)
            //    Console.Write(item + ",");



            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);

            Console.WriteLine(numbers.Dequeue());

        }



    }
}
