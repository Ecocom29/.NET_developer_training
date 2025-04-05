namespace StaticMethods_Middle_Level
{
    //Calculate area of circle
    public class Circle
    {
        public double x { get; set; } = 12.04D;
        public double y { get; set; } = 30.86D;

        public Circle(double a, double b)
        {
            this.x = a;
            this.y = b;
        }

        public static double CalculateArea(double area, double radio)
        {
            double result = Math.PI * area * radio;
            return result;
        }
    }
}
