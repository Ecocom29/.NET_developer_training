using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_Middle_Level
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Category() { }

        public void AddCategory()
        {
            Console.WriteLine("Add new category...");
        }

        public void RemoveCategory() 
        {
            Console.WriteLine("Remove category...");
        }

        public string GetDescription() 
        {
            return "Get description...";
        }
    }
}

// https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/protected