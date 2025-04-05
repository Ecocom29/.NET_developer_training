using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods_Middle_Level
{
    public class Triangle
    {
        public double x { get; set; } = 12.04D;
        public double y { get; set; } = 30.86D;

        public Triangle(double a, double b)
        {
            this.x = a;
            this.y = b;
        }

        public static double CalculateArea(double base_number, double number_altura)
        {
            double result = (base_number * number_altura) / 2;
            return result;
        }
    }
}
