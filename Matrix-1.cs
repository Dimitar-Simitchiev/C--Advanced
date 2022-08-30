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
            string[] input = Console.ReadLine().Split(", ");
            int row = int.Parse(input[0]);
            int col = int.Parse(input[1]);

            int[,] matrix = new int[row, col];
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] matrixsplit = Console.ReadLine().Split(", ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(matrixsplit[j]);
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }

            }
            Console.WriteLine(row);
            Console.WriteLine(col);
            Console.WriteLine(sum);
            //////////////////////////////////////////////////////////////////////////////////////







            int n = int.Parse(Console.ReadLine());
            int row2 = 0;
            int col2 = 0;    
            bool ishere=false;
            char[,]matrix2=new char[n,n];

           
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                string matrixsplit = Console.ReadLine();
                char[] matixchar = matrixsplit.ToCharArray();
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = matixchar[j];
                   
                    
                }
            }

            char intput2 =char.Parse( Console.ReadLine());
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                   
                   
                    if (matrix2[i, j] == intput2&&ishere==false)
                    {
                        row2 = i;
                        col2 = j;
                        ishere = true;
                       
                    }
                    

                }
                Console.WriteLine();
            }
            if (ishere==true)
            {
                Console.WriteLine("("+row2+", "+col2+")");

            }
            else
            { 
             Console.WriteLine($"{intput2} does not occur in the matrix");

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////

            string[] input3 = Console.ReadLine().Split(", ");
            int row3 = int.Parse(input[0]);
            int col3 = int.Parse(input[1]);

            int[,] matrix3 = new int[row, col];


            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                string[] matrixsplit2 = Console.ReadLine().Split(" ");
                for (int j = 0; j < matrix3.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(matrixsplit2[j]);
                }
            }

            for (int i = 0; i < matrix3.GetLength(1); i++)
            {
                int sum3 = 0;

                for (int j = 0; j < matrix3.GetLength(0); j++)
                {
                    sum += matrix3[j, i];
                }
                Console.WriteLine(sum3);
            }

        } 

         
    }
}