using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your age is {age}");

            Console.WriteLine("Hello, C# Academy!");

            Console.WriteLine("What is your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
        }
    }
}