// https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/access-modifiers
namespace AccessModifiers_Middle_Level
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class Client

            var cliente = Client.AddClient();

            Console.WriteLine(cliente);
        }
    }
}
