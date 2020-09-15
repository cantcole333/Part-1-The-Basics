using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_The_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(" CCC     CCC ");
            //Console.WriteLine("C   C   C   C");
            //Console.WriteLine("C       C    ");
            //Console.WriteLine("C       C    ");
            //Console.WriteLine("C       C    ");
            //Console.WriteLine("C   C   C   C");
            //Console.WriteLine(" CCC     CCC ");

            string firstName = "Cole";
            string favMovie = "The Matrix";
            Console.WriteLine($"Hello there {firstName} I hope you enjoy watching {favMovie}".ToLower());
            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);
            Console.WriteLine(favMovie.Contains("THE"));

            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine(favMovie);
            Console.ReadLine();
        }
    }
}
