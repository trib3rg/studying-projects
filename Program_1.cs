using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdkStudying_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double result;
            string variables;
            Console.WriteLine("Программа предназначена для нахождения среднего арифметического трёх чисел.\nВведите три переменные через пробел:");
            variables = Console.ReadLine();
            string[] numbers = variables.Split(' ');
            result = (Double.Parse(numbers[0]) + Double.Parse(numbers[1]) + Double.Parse(numbers[2])) / 3;
            Console.WriteLine("\nРезультат = " + result);
        }
    }
}
