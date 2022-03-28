using System;

namespace ConsoleApp2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stopWord = "exit";
            string userInput;

            while(true)
            {
                Console.WriteLine("Введите стоп слово");
                userInput = Console.ReadLine();
                
                if (   userInput == stopWord)
                {
                    Console.WriteLine("Программа окончена");
                    break;
                }
                else
                {
                    Console.WriteLine("Программа продолжается");
                }
            }                           
        }
    }
}
