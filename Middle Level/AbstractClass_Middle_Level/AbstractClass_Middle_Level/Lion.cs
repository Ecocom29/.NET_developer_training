using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Middle_Level
{
    public class Lion: Animal
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public Lion() { }

        public void Hunt()
        {
            Console.WriteLine("The lion wants to hunt...");
        }

        public void Bathe()
        {
            Console.WriteLine("The lion wants to bathe");
        }
    }
}
