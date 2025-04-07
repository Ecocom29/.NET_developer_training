namespace AbstractClass_Middle_Level
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CAT class
            Cat obj_cat = new Cat();
            obj_cat.Run();  // Herencia de la clase Animal
            obj_cat.Walk(); // Herencia de la clase Animal
            obj_cat.Maulla(); // Definido en la clase Cat


            //Dog class
            Dog obj_dog = new Dog();
            obj_dog.Bark(); // Definido en la clase Dog
            obj_dog.Eat(); // Heredado de la clase Animal
            obj_dog.Grunt();
        }
    }
}
