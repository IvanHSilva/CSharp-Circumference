using System;
using System.Globalization;

namespace Circumference {
    internal class Program {

       
        static void Main(string[] args) {

            // radius data inserction
            Console.Write("Digite o valor do raio: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            // calculate circumference and volume
            double circle = Calculator.Circumference(radius);
            Console.WriteLine($"Circunferência: {circle.ToString("F2", CultureInfo.InvariantCulture)}");
            double volume = Calculator.Volume(radius);
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Calculator.PI.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
