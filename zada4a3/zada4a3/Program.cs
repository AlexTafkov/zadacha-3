using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, result;

            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine());

            result = (x + y) / (z + z / x + z / y - x);

            Console.WriteLine("Резултат= " + result);
            Console.WriteLine("Натиснете произволен клавиш. . .");
        }
    }
}
