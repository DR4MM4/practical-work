using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первый член арифметической прогрессии (a):");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите шаг арифметической прогрессии (d):");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество членов арифметической прогрессии (n):");
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                int currentTerm = a + d * i;
                Console.WriteLine($"Член прогрессии номер {i+1} равен {currentTerm}");
                
            }
            int sum = (2*a+(n-1)*d)/2*n;
            Console.WriteLine($"Сумма первых {n} членов равна: {sum}");
            Console.ReadKey();

        }
    }
}
