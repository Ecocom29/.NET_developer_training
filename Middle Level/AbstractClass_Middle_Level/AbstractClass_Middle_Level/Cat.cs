using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Middle_Level
{
    public class Cat: Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Breed { get; set; }

        public Cat() { }
    
        public void Maulla()
        {
            Console.WriteLine("The cat wants to meow");
        }

        public void Jump()
        {
            Console.WriteLine("The cat wants to jumps");
        }
    }
}
