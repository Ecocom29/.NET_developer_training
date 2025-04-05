### Explain the basic structure of a C# program.

**Answer:** A basic C# program consists of the following elements:

- **Namespace declaration:** A way to organize code and control the scope of classes and methods in larger projects.
- **Class declaration:** Defines a new type with data members (fields, properties) and function members (methods, constructors).
- **Main method:** The entry point for the program where execution begins and ends.
- **Statements and expressions:** Perform actions with variables, calling methods, looping through collections, etc.

```csharp
namespace StructureProgram_Basic_Level
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add code to run program
            Console.WriteLine("Hello, World!" + "["+ args + "]");
        }
    }
}
```
