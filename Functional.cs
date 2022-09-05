using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.IO;
namespace SoftUniExercises
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).OrderBy(x => x).ToList<int>();
            List<int> numbers2 = numbers.Where(x => x % 2 == 0).ToList<int>();

            Console.WriteLine(String.Join(", ", numbers2));
            ///////////////////////////////////////////////////////


            List<int> numbers4 = Console.ReadLine().Split(", ").Select(int.Parse).OrderBy(x => x).ToList<int>();
            Console.WriteLine(numbers4.Count);
            Console.WriteLine(numbers4.Sum());




            ////////////////////////////////////////////////////////
            List<string> words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> final = words.Where(x => char.IsUpper(x[0])).ToList();
            foreach (var item in final)
            {
                Console.WriteLine(item);
            }
            ///////////////////////////////////////////////////////
            List<double> word2s = Console.ReadLine().Split(", ").Select(double.Parse).ToList<double>();
            var words5 = word2s.Select(x => x * 1.2);
            foreach (var word3 in words5)
            {
                Console.WriteLine($"{word3:f2}");
            }
            /////////////////////////////////////////////////////

            List<Person> list = new List<Person>();

            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                Person person = new Person();
                string[] people = Console.ReadLine().Split(", ");
                person.Name = people[0];
                person.Age = int.Parse(people[1]);
                list.Add(person);




                n--;

            }

            string condition = Console.ReadLine();
            int numberolder = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> funk = p => true;
            if (condition == "younger")
            {
                funk = p => p.Age < numberolder;
            }
            else if (condition == "older")
            {
                funk = p => p.Age >= numberolder;
            }

            var filterpeople = list.Where(funk);
            Func<Person, string> persofuk = p => p.Name + " " + p.Age;

            if (format=="name age")
            {
                persofuk = p => p.Name + " - " + p.Age;
            }
            if (format == "name")
            {
                persofuk = p => p.Name;
            }
            if (format == "age")
            {
                persofuk = p => p.Age.ToString();
            }
            var result =filterpeople.Select(persofuk);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        } 
    }
}