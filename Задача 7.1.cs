using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Урок_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Метод определяет площадь большего треугольника, площадь считается с помощью другого метода 
            Console.WriteLine("Ввведите стороны треугольника N1");
            Console.WriteLine("Сторона треугольника х1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сторона треугольника у1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сторона треугольника z1: ");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввведите стороны треугольника N2");
            Console.WriteLine("Сторона треугольника х2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сторона треугольника у2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сторона треугольника z2: ");
            int z2 = Convert.ToInt32(Console.ReadLine());
            double S1, S2, P1, P2, S3, S4;
            GetParam(x1, x2, y1, y2, z1, z2, out S1, out S2, out P1, out P2, out S3, out S4);
                      
            Console.ReadKey();
        }
        static void GetParam(int x1, int x2, int y1, int y2, int z1, int z2, out double S1, out double S2, out double P1, out double P2, out double S3, out double S4)
        {
            P1 =(x1+y1+z1);
            P2 =(x2+y2+z2);
            S1 = Math.Sqrt(P1/2*(P1/2-x1)*(P1/2-y1)*(P1/2-z1));
            S2 = Math.Sqrt(P2 / 2 * (P2 / 2 - x2) * (P2 / 2 - y2) * (P2 / 2 - z2));
            S3 = 0;
            S4 = 0;
            if (S1>S2)
            {
                S3 = S1;
                S4 = S2;
                Console.WriteLine("Площадь первого треугольника - {0}", Math.Round(S1, 2));
                Console.WriteLine("Площадь второго треугольника - {0}", Math.Round(S2, 2));
                Console.WriteLine("Площадь {0} > {1}", Math.Pow(S3, 2), Math.Round(S4, 2));
            }
            if (S2 > S1)
            {
                S3 = S2;
                S4 = S1;
                Console.WriteLine("Площадь первого треугольника - {0}", Math.Round(S1, 2));
                Console.WriteLine("Площадь второго треугольника - {0}", Math.Round(S2, 2));
                Console.WriteLine("Площадь {0} < {1}", Math.Pow(S3, 2), Math.Round(S4, 2));
            }
            else
            {
                S3 = S2;
                S4 = S1;
                Console.WriteLine("Площадь первого треугольника - {0}", Math.Round(S1, 2));
                Console.WriteLine("Площадь второго треугольника - {0}", Math.Round(S2, 2));
                Console.WriteLine("Площади равны {0} = {1}", Math.Round(S3, 2), Math.Round(S4, 2));
            }
        }
    }
}
