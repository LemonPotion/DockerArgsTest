
namespace ConsoleApp1;

internal abstract class Program
{
    internal static void Main(string[] args)
    {
        Console.WriteLine("Environment variable:" + Environment.GetEnvironmentVariable("CONNECTION_STRING"));
        
        Console.WriteLine("List of args:");
        
        foreach (var arg in args)
        {
            Console.WriteLine(arg);
        }
    }
}