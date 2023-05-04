using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;




class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());
        int result = Factorial(n);
        Console.WriteLine($"Факториал числа {n} равен {result}");
    }

    static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}