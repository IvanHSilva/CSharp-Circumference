using System;

namespace Circumference {
    public class Calculator {

        // attributes
        public static double PI = 3.14;

        // methods
        public static double Circumference(double radius) {
            return 2.0 * PI * radius;
        }

        public static double Volume(double radius) {
            return 4.0 / 3.0 * PI * Math.Pow(radius, 3);
        }

    }
}
