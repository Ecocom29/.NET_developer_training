namespace ValueTypeConversions_Basic_Level
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Convert string to integer
            string describe_number = "1500";
            int number_value = 0;

            number_value = Convert.ToInt32(describe_number);
            Console.WriteLine("Convert string to integer: " + number_value);

            // Convert int to string
            int number_of_product = 4500;
            string products_description = "";
            products_description = Convert.ToString(number_of_product);
            Console.WriteLine("Convert int to string: " + products_description);

            //Convert bool to int
            bool true_value = true;
            int product_active = 0;
            product_active = Convert.ToInt32(true_value);
            Console.WriteLine("Convert bool to int: " + product_active);


            // Conversión boxing y unboxing
            int number = 350;
            object number_object = number; // boxing

            number_object = 7980;
            number = (int)number_object; //unboxing

            int item = 423;
            object item_two = (object)item;

            int numero = 500;
            object objNumber = number; //Boxing
            int suma = numero + (int)objNumber; //Boxing

            Console.WriteLine("Sum of numbers: {0}" , suma);
        }
    }
}
