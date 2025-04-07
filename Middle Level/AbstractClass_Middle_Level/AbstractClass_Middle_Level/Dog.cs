using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Middle_Level
{
    public class Dog: Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Dog() { }

        public void Bark()
        {
            Console.WriteLine("The dog wants to bark...");
        }
        public void Grunt()
        {
            Console.WriteLine("The dog wants to grunt...");
        }

        public void Bite()
        {
            Console.WriteLine("The dog wants to bite...");
        }
    }
}
