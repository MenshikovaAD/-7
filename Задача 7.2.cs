using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Метод определяет площадь и объем куба по длине ребра, площадь и объем считаются с помощью другого метода 
            Console.WriteLine("Ввведите длину ребра куба в см: ");
            int x = Convert.ToInt32(Console.ReadLine());
            double S, V;
            GetParam(x, out S, out V);
            Console.ReadKey();
        }
        static void GetParam(int x, out double S, out double V)
        {
            S = 6* Math.Pow(x, 2);
            V = Math.Pow(x, 3);
            Console.WriteLine("Площадь поверхности куба со стороной {0} равна - {1} см2", x, S);
            Console.WriteLine("Объем куба со стороной {0} равна - {1} см3", x, V);
                
        }
    }
}
