using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_Middle_Level
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsAvailable { get; set; }

        public Product() { }

        private protected string GetListProduct()
        {
            return "";
        }

        public string AddProduct()
        {
            GetListProduct();
            return "";
        }
    }
}
