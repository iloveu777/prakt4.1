using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            BackgroundColor = ConsoleColor.White;
            ForegroundColor = ConsoleColor.Black;
            WindowHeight = 60;
            WindowWidth = 25;
            Title = "Тема #4, КП # 1. Ривилис Евгений";
            Write("Как Вас зовут? ");
            string name = ReadLine();
            WriteLine($"Здравствуйте {name}!");
            WriteLine(CapsLock);
            WriteLine(NumberLock);

            ReadKey();

        }
    }
}
