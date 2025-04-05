namespace StaticMethods_Middle_Level
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ahora podemos usar los campos estáticos de la clase
            // Calculadora y User sin crear una instancia de la clase.
            // https://www.luisllamas.es/csharp-metodos-estaticos/


            //Clase Calculadora
            int suma = Calculadora.Sumar(40, 67);
            int resta = Calculadora.Restar(56, 78);
            int Multipli = Calculadora.Multiplicar(34,7);
            int Divicion = Calculadora.Dividir(300,6);
            Console.WriteLine("Suma: {0}", suma);
            Console.WriteLine("Resta: {0}", resta);
            Console.WriteLine("Multiplicación: {0}", Multipli);
            Console.WriteLine("División: {0}", Divicion);


            // Clase User
            string Login = User.Login();
            string Logout = User.Logout();
            string ModifyUser = User.ModifyUser();
            string DeleteUser = User.DeleteUser();
            Console.WriteLine(Login);
            Console.WriteLine(Logout);
            Console.WriteLine(ModifyUser);
            Console.WriteLine(DeleteUser);

            // Class Circle
            double resultCircle = Circle.CalculateArea(30,10);
            Console.WriteLine("El área del circulo es: {0}", resultCircle);

            //Class Rectagle
            double rectagle_result = Rectagle.CalculateArea(37.78,10.23);
            Console.WriteLine("El área del rectangulo es: {0}", rectagle_result);

            //Class Triangle
            double triangle_result = Triangle.CalculateArea(65.8, 5.3);
            Console.WriteLine("El área del triangulo es: {0}", triangle_result);
        }
    }
}
