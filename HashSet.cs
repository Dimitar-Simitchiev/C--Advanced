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


            int n = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                names.Add(name);
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }



            /////////////////////////////////////////////////
            HashSet<string> cars = new HashSet<string>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                string[] lineSPLIT = line.Split(",");
                if (lineSPLIT[0] == "IN")
                {
                    cars.Add(lineSPLIT[1]);
                }
                else
                {
                    cars.Remove(lineSPLIT[1]);
                }

            }
            if (cars.Count > 0)
            {
                foreach (var item in cars)
                {
                    Console.WriteLine(item);
                }

            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            ///////////////////////////////////////////////////////

            HashSet<string> vip = new HashSet<string>();
            HashSet<string> reg = new HashSet<string>();
           
          
            while (true)
            {
                string line = Console.ReadLine();
                if (line=="PARTY")
                {
                    break;
                }
                if (char.IsDigit(line[0]))
                {
                    vip.Add(line);
                }
                else
                {
                    reg.Add(line);
                }
                
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                {

                    break;
                }
                if (char.IsDigit(line[0]))
                {
                    vip.Remove(line);
                }
                else
                {
                    reg.Remove(line);
                }
            }

            Console.WriteLine(reg.Count+vip.Count);

            foreach (var item in vip)
            {
                Console.WriteLine(item);
                
            }
            foreach (var item in reg)
            {
                Console.WriteLine(item);
                
            }
           

        }



    }




}
