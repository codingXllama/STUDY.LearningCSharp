using DEMO;

namespace OOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            Admin firstAdmin = new Admin();
            Console.WriteLine(firstAdmin.LogOut());

            Console.WriteLine($"The total number of slots: {firstAdmin.NumberOfSlots=20}");
            Console.WriteLine($"The total number of free slots: {firstAdmin.FreeSlots}");

            Operator firstOperator = new Operator();
            Console.WriteLine($"The total number of free slots: {firstOperator.FreeSlots}");
        }

    }
}



