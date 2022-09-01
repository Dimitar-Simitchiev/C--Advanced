using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.IO;
namespace SoftUniExercises
{

    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> list1 = new List<string>();
            
           
            using (StreamReader str=new StreamReader(@"C:\\Temp\\numbers1.txt"))
            {
                while (!str.EndOfStream)
                {
                    string text2=str.ReadLine();
                    list1.Add(text2); 
                    

                }
                
            }
            using (StreamReader str = new StreamReader(@"C:\\Temp\\numbers2.txt"))
            {
                while (!str.EndOfStream)
                {
                    string text2 = str.ReadLine();
                    list1.Add(text2);


                }

            }
            list1.Sort();
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }
            using (StreamWriter stw = new StreamWriter(@"C:\\Temp\\numbers3.txt"))
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    string s = (list1[i]);
                    stw.WriteLine(s);
                }

            }


            ///////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////
            int numbers = 0;

            using (StreamReader str = new StreamReader(@"C:\\Temp\\Countries.txt"))
            {
                using (StreamWriter stw = new StreamWriter(@"C:\\Temp\\Countries2.txt"))
                {

                    while (!str.EndOfStream)
                    {
                        var line = str.ReadLine();
                        if (numbers % 2 == 1)
                        {
                            stw.WriteLine(line);
                        }
                        numbers++;
                    }

                }
            }
            //////////////////////////////////////////////////////////////////
            byte[] number = new byte[] { 0, 1, 2 };
            using FileStream file = new FileStream(@"C:\Temp\testoutput3.txt", FileMode.OpenOrCreate);

            file.Write(number, 0, number.Length);
            //////////////////////////////////////////////////////////////////////






        }



    }




}
