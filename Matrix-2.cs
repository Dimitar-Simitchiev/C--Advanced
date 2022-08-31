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
            int[][] jugg = new int[n][];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                string[] splitline = line.Split(" ");
                jugg[i] = new int[splitline.Length];

                for (int j = 0; j < splitline.Length; j++)
                {
                    jugg[i][j] = int.Parse(splitline[j]);
                }
            }
            while (true)
            {
                var command = Console.ReadLine();
                string[] scommand = command.Split(" ");

                if (command == "END")
                {
                    break;
                }
                var elemindex = int.Parse(scommand[1]);
                var elemelem = int.Parse(scommand[2]);
                var valie = int.Parse(scommand[3]);

                if (scommand[0] == "Add")
                {
                    if (elemindex >= 0 && elemindex < n && elemelem >= 0 && elemelem < n)
                    {
                        jugg[elemindex][elemelem] += valie;

                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");

                    }

                }
                else if (scommand[0] == "Subtract")
                {
                    if (elemindex >= 0 && elemindex < n && elemelem >= 0 && elemelem < n)
                    {

                        jugg[elemindex][elemelem] -= valie;

                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");

                    }
                }
            }
            for (int i = 0; i < jugg.Length; i++)
            {
                for (int j = 0; j < jugg[i].Length; j++)
                {
                    Console.Write(jugg[i][j] + " ");
                }
                Console.WriteLine();
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int n = int.Parse(Console.ReadLine());
            int[][]jugg=new int [n][];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                string[] splitline = line.Split(" ");
                jugg[i] = new int[splitline.Length];

                for (int j = 0; j < splitline.Length; j++)
                {
                    jugg[i][j] = int.Parse(splitline[j]);
                }
            }
            while (true)
            {
                var command = Console.ReadLine();
                string[] scommand = command.Split(" ");

                if (command=="END")
                {
                    break;
                }
                var elemindex = int.Parse(scommand[1]);
                var elemelem = int.Parse(scommand[2]);
                var valie= int.Parse(scommand[3]);
               
                if (scommand[0] == "Add")
                {
                    if (elemindex >= 0 && elemindex < n && elemelem >= 0 && elemelem < n)
                    {
                        jugg[elemindex][elemelem] += valie;

                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");

                    }
                   
                }
                else if (scommand[0] == "Subtract")
                {
                    if(elemindex >= 0 && elemindex < n && elemelem >= 0 && elemelem < n)
                    {
                       
                        jugg[elemindex][elemelem] -= valie;

                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");

                    }
                }
            }
            for (int i = 0; i < jugg.Length; i++)
            {
                for (int j = 0; j < jugg[i].Length; j++)
                {
                    Console.Write(jugg[i][j]+" ");
                }
                Console.WriteLine();
            }




        }




    }




}
