### Static Classes in C#

**Static Classes:** A static class is basically the same as a non-static class, but there's one difference: a static class can't be instantiated. In other words, you can't use the new operator to create a variable of the class type. Because there's no instance variable, you access the members of a static class by using the class name itself. For example, if you have a static class that is named UtilityClass that has a public static method named MethodA, you call the method as shown in the following example:

```csharp
using System;

namespace StaticMethods_Middle_Level
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clase Calculadora
            int suma = Calculadora.Sumar(40, 67);
        }
    }
}

//Class
public class Calculadora
{
    public static int TotalOperaciones = 0;

    public static int Sumar(int a, int b)
    {
        TotalOperaciones++;
        return a + b;
    }
}

```
