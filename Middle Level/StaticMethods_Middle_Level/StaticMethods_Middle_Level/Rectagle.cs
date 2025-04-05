using System.Runtime.CompilerServices;

namespace StaticMethods_Middle_Level
{
    public class Rectagle
    {
        public double x {  get; set; }
        public double y { get; set; }

        public Rectagle() { }

        public static double CalculateArea(double base_number, double altura_number)
        {
            double result = 0.0D;
            result = base_number * altura_number;
            return result;
        }
    }
}
