using System;

namespace ConsoleApp2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopWord = "";                  

            while (stopWord != "exit")
            {

                Console.WriteLine("Программа продолжится пока не введете exit");

                stopWord  = Console.ReadLine();
            }                                       
        }
    }
}
