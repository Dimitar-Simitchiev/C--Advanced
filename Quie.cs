using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text.RegularExpressions;
namespace SoftUniExercises
{

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arrinput = input.Split(" ");
            Queue<int> even = new Queue<int>();
            for (int i = 0; i < arrinput.Length; i++)
            {
                int number = int.Parse(arrinput[i]);
                if (number % 2 == 0)
                {
                    even.Enqueue(number);
                }
            }
            while (even.Count > 1)
            {
                Console.Write(even.Dequeue() + ", ");
            }
            if (even.Count == 1)
            {
                Console.Write(even.Dequeue());
            }
            ////////////////////////////////////////////
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                if (input == "Paid")
                {
                    foreach (var item in queue)
                    {
                        Console.WriteLine(item);
                    }
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(input);



                }
            }
            Console.WriteLine(queue.Count + " people remaining.");


            ////////////////////////////////////////////////
            string[] names = Console.ReadLine().Split(" ");
            int number = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();

            foreach (var name in names)
            {
                queue.Enqueue(name);
            }
            while (queue.Count > 1)
            {
                for (int i = 0; i < number - 1; i++)
                {
                    var kid = queue.Dequeue();
                    queue.Enqueue(kid);
                }
                var kidremuve = queue.Dequeue();
                Console.WriteLine("Removed " + kidremuve);
            }

            Console.WriteLine("Last is " + queue.Dequeue());



            /////////////////////////////////////////////////
            int numberOfcars = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int n = 0;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                if (line == "green")
                {

                    for (int i = 0; i < numberOfcars; i++)
                    {
                        if (queue.Count > 0)
                        {
                            var car = queue.Dequeue();
                            Console.WriteLine(car + " passed!");
                            n++;
                        }
                    }


                }
                else
                {
                    queue.Enqueue(line);
                }
            }

            Console.WriteLine(n + " cars passed the crossroads.");



























        }
    }
}