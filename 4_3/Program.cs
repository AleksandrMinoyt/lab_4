using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону A");
            int sideA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону B");
            int sideB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону C");
            int sideC = Convert.ToInt32(Console.ReadLine());

            int countSquare=0;           

            while (sideA>=0&& sideA>=sideC)
            {
                sideA -= sideC;
                int sideBTemp = sideB;
                while (sideBTemp >= 0 && sideBTemp >= sideC)
                {
                    sideBTemp -= sideC;
                    countSquare++;
                   
                }
            }
                       
            Console.WriteLine("Количество квадратов {0}", countSquare.ToString());
            Console.ReadKey();
        }
    }
}
