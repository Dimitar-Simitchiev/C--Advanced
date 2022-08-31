using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrichniIgri
{
    internal class Program
    {


        static void Main(string[] args)
        {
            labirint lab=new labirint();
            Morskishah mor = new Morskishah();
            Registaciq reg = new Registaciq();


            Console.WriteLine("Wellcome chose game from 1 to 3");
            Console.WriteLine("1-Labirnit");
            Console.WriteLine("2-Dama");
            Console.WriteLine("3-Registraciq");
            Console.WriteLine("4-Find path of Labirnit");
           
            string name = Console.ReadLine();
            if(name=="1")

            {
                Console.Clear();
                lab.Bourd();

            }
            if (name=="2")
            {
                Console.Clear();
                mor.Morskishahstart();
            }
            if (name=="3")
            {
                Console.Clear();
                reg.Registration(); 

            }
            if (name=="4")
            {
                Console.Clear();
                lab.Finpath();
            }
             





        }





    } }

        
    

