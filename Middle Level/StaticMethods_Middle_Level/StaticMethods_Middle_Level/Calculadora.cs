namespace StaticMethods_Middle_Level
{
    public class Calculadora
    {
        public static int TotalOperaciones = 0;

        //Constructor
        public Calculadora() { }

        public static int Sumar(int a, int b)
        {
            TotalOperaciones++;
            return a + b;
        }

        public static int Restar(int a, int b)
        {
            TotalOperaciones++;
            return a - b;
        }

        public static int Multiplicar(int a, int b)
        {
            TotalOperaciones++;
            return a * b;
        }

        public static int Dividir(int a, int b)
        {
            TotalOperaciones++;
            return a / b;
        }
    }
}
