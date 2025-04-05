using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods_Middle_Level
{
    public class User
    {

        /// Atributos       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }

        //Constructor
        public User() 
        { 

        }

        //Métodos
        public static string Login()
        {
            return "Login";
        }

        public static string Logout() 
        {
            return "Logout";
        }

        public static string GetListUser()
        {
            return "Obtain user list";
        }

        public static string AddUser()
        {
            return "Add user";
        }

        public static string ModifyUser()
        {
            return "Modify user";
        }

        public static string DeleteUser()
        {
            return "Delete user";
        }                    
    }
}
