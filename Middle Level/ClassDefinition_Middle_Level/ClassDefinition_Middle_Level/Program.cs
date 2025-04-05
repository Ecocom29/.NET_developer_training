using System.Collections.Concurrent;
using System.Xml.Schema;

namespace ClassDefinition_Middle_Level
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Class definition
            Person obj_person = new Person(1, "Eliezer Sashary", "Cocom Cruz", "11/10/1989", true);
            obj_person.Brincar();


            Car obj_car = new Car(2, "Z3", "BMW", "Red", 2025, true);
            obj_car.ShowDescription();
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string? FirtsName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Active { get; set; }

        public Person(int id, string firsName, string lastName, string dateOfBirth, bool active)
        {
            this.Id = id;
            this.FirtsName = firsName;
            this.LastName = lastName;
            this.DateOfBirth = Convert.ToDateTime( dateOfBirth);
            this.Active = active;
        }
        
        public void Avanzar()
        {
            Console.WriteLine("El objeto persona tiene los datos: {0}, {1}, {2}, {3}, {4}", this.Id, this.FirtsName, this.LastName, this.DateOfBirth, this.Active);
        }

        public void Brincar()
        {
            Console.WriteLine("El objeto persona {0}  {1} esta brincando", this.FirtsName, this.LastName);
        }

        public void CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - this.DateOfBirth.Year;

            Console.WriteLine("La edad de {0} es: {1}",this.FirtsName, edad);
        }
    }

    public class Car
    {
        // Atributos o miembros de clase
        public int Id { get; set; }
        public string? ModelName { get; set; }
        public string? Brand { get; set; }
        public string? Color { get; set; }
        public int? year { get; set; }
        public bool Active { get; set; }

        //Contructor
        public Car(int id, string modelName, string brand, string color, int year, bool active)
        {
            this.Id = id;
            this.ModelName = modelName;
            this.Brand = brand;
            this.Color = color;
            this.year = year;
            this.Active = active;

            ShowDescription();
        }

        //Funciones o métodos
        protected internal void ShowDescription()
        {
            Console.WriteLine("Los datos del auto son: [ {0} - {1} - {2} - {3} - {4} ]", this.Id, this.ModelName, this.Brand, this.Color, this.year);
        }

        public void Avanzar()
        {
            Console.WriteLine("El auto {0} esta avanzando. ", this.ModelName);
        }

        public void StartCar()
        {
            ShowDescription();
            Console.WriteLine("El auto {0} se esta encendiendo.", this.ModelName);
        }        
    }
}
