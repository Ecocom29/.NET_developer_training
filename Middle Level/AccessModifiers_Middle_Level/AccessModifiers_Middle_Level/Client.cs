using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers_Middle_Level
{
    public class Client
    {
        private int Id { get; set; }
        protected static string Name { get; set; }
        private string Description { get; set; }

        protected Client(string name) 
        {
            this.Id = 0;
            Name = name;
            this.Description = string.Empty;
        }

        public static string AddClient()
        {            

            return "Add client: " + Name;
        }
    }
}
