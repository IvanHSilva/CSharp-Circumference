using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Circumference {
    internal class Program {

        // constant declaration
        static double PI = 3.14;
        
        static void Main(string[] args) {

            // radius data inserction
            Console.Write("Digite o valor do raio: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            // calculate circumference and volume
            double circle = Circumference(radius);
            Console.WriteLine($"Circunferência: {circle.ToString("F2", CultureInfo.InvariantCulture)}");
            double volume = Volume(radius);
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {PI.ToString("F2", CultureInfo.InvariantCulture)}");

        }

        static double Circumference(double radius) {
            return 2.0 * PI * radius;
        }

        static double Volume(double radius) {
            return 4.0 / 3.0 * PI * Math.Pow(radius, 3);
        }
    }
}
