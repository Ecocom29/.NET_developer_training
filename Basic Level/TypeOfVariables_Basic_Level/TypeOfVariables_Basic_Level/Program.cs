using System.Diagnostics.Metrics;

namespace TypeOfVariables_Basic_Level
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ Types of Variables in C# ------ \n");


            Console.WriteLine("****** String (string) ****** \n");
            string names_of_person = "Eliezer cocom";
            string animal_description= "The animals is famous";
            string city_name = "The city name is Mérida";
            Console.WriteLine("Names of person: " + names_of_person);
            Console.WriteLine("Animal description: " + animal_description);
            Console.WriteLine("City name: " + city_name + "\n");


            Console.WriteLine("****** Char (char) ****** \n");
            char character_special = '%';
            char define_initial = 'G';
            char type_number_char = '9';
            Console.WriteLine("Character special: " + character_special);
            Console.WriteLine("Define initial character: " + define_initial);
            Console.WriteLine("Type number char: " + type_number_char + "\n");


            Console.WriteLine("****** Integer (int) ****** \n");
            int number_one = 30;
            int number_of_products = 100;
            int number_of_animal = 300;
            Console.WriteLine("Number one: " + number_one);
            Console.WriteLine("Number of products: " + number_of_products);
            Console.WriteLine("Number of animal: " + number_of_animal + "\n");
           

            Console.WriteLine("****** Double (double) ****** \n");
            double price_of_produc = 5040.70;
            double speed_of_light = 456.98;
            double speed_of_vehicle= 230.563;
            Console.WriteLine("Price of product: " + price_of_produc);
            Console.WriteLine("Speed of the light: " + speed_of_light);
            Console.WriteLine("Speed f the vehicle: " + speed_of_vehicle + "\n");


            Console.WriteLine("****** Decimal (Decimal) ****** \n");
            decimal measures_value = 56.89m;
            decimal price_ticket = 456.98m;
            decimal amount_of_heat = 30.34m;
            Console.WriteLine("Measures value: " + measures_value);
            Console.WriteLine("Price ticket: " + price_ticket);
            Console.WriteLine("Amout of heat: " + amount_of_heat + "\n");

            Console.WriteLine("****** Float (float) ****** \n");
            float temperature_value = 28.50F;
            float float_value = 56.98F;
            float amount_of_sound = 30.34F;
            Console.WriteLine("Temperature: " + temperature_value);
            Console.WriteLine("Float value: " + float_value);
            Console.WriteLine("Amout of sound: " + amount_of_sound + "\n");


            Console.WriteLine("****** Boolean (bool) ****** \n");
            bool true_value = true;
            bool false_value = false;            
            Console.WriteLine("True value: " + true_value);
            Console.WriteLine("False value: " + false_value + "\n");

            Console.WriteLine("****** Short (short) ****** \n");
            short monimum_amount = -32767;
            short maximum_amount = 32767;
            Console.WriteLine("Minimum amount: " + monimum_amount);
            Console.WriteLine("Maximum amount: " + maximum_amount + "\n");


            Console.WriteLine("****** Array (array[]) ****** \n");
            int[] numbers_list = [3,46,8,4,1,5,7,9];
            string[] letters_list = ["A", "t", "SDF", "%&"];

            foreach (int number in numbers_list)
            {
                Console.WriteLine("Number: " + number);
            }

            Console.WriteLine("\n");

            foreach (string letter in letters_list)
            {
                Console.WriteLine("Letter: " + letter);
            }


            Console.WriteLine("----------------------------------- \n");
        }
    }
}

//Complete list of variable types:
//bool:    System.Boolean
//byte:    System.Byte
//char:    System.Char
//decimal: System.Decimal
//double:  System.Double
//float:   System.Single
//int:     System.Int32
//long:    System.Int64
//nint:    System.IntPtr
//object:  System.Object
//sbyte:   System.SByte
//short:   System.Int16
//string:  System.String
//uint:    System.UInt32
//ulong:   System.UInt64
//ushort:  System.UInt16