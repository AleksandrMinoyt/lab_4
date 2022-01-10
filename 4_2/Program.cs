using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPositive = 0;
            int countNegative = 0;
            int number = 0;

            do
            {
                Console.WriteLine("Введите число");
                number = Convert.ToInt32(Console.ReadLine());

                if (number > 0)
                {
                    countPositive++;
                }

                if (number < 0)
                {
                    countNegative++;
                }

            } while (number != 0);

            if (countNegative == countPositive)
            {
                Console.WriteLine("Положительных и отрицательных одинаковое количество");
            }
            else
            {
                Console.WriteLine("Больше " + ((countNegative > countPositive) ? "отрицательных" : "положительных"));
            }

            Console.ReadKey();
        }
    }
}
