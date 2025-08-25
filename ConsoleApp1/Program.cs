using System.Security.Cryptography;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Please enter your age: ");
           int age = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine($"Your age is {age}");
     
           Console.WriteLine("Hello, C# Academy!");

           
        }
    }
}
