using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Middle_Level
{
    public class Bird
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
         
        public Bird() { }

        public void Sing()
        {
            Console.WriteLine("The lion wants to hunt...");
        }

        public void Fly()
        {
            Console.WriteLine("The lion wants to bathe");
        }
    }
}
