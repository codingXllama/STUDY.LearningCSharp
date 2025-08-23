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
           
           // write a loop to check if items in the input is a string or int
           foreach (int item in age)
            {

            }

           
        }
    }
}
