using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N (>0)");
            int numberN = Convert.ToInt32(Console.ReadLine());
            if (numberN > 0)
            {
                int squareNumber = 0;

                for (int i = 1; i <= numberN; i++)
                {
                    squareNumber += i * 2 - 1;
                    Console.WriteLine(squareNumber.ToString());
                }
                
                Console.WriteLine("Квадрат числа {0} равен {1}", numberN.ToString(), squareNumber.ToString());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ошибка! Число не >0");
                Console.ReadKey();

            }
        }
    }
}
