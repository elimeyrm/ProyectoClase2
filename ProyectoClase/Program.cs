using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Uso de un procedimiento";
            int num;
            Console.WriteLine("Digitar un numero entero positivo:");
            num = int.Parse(Console.ReadLine());
            Par(num);
            Console.WriteLine("\n");
            Console.WriteLine("-->Fin del programa");
            Console.ReadKey();
        }

        static void Par(int a)
        {
            int x;
            x = (a % 2);
            if (x == 0)
            {
                Console.WriteLine("\nEs par");
            }
            else
            {
                Console.WriteLine("\nEs impar");
            }
        }

    }
}
