namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //ArrayRunner();
            CodeChallenge();
        }


        public static void ArrayRunner()
        {
            //Attempt to use an index that is out of bounds of the array
            string[] fraudlentOrderIDs = new string[4];
            fraudlentOrderIDs[0] = "A1234";
            fraudlentOrderIDs[1] = "B456";
            fraudlentOrderIDs[2] = "C879";
            fraudlentOrderIDs[3] = "D00"; // Out of of bound

            //Retrieving values from elements of an array
            Console.WriteLine($"First: {fraudlentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudlentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudlentOrderIDs[2]}");

            //Reassigning value

            fraudlentOrderIDs[0] = "F000";
            Console.WriteLine($"Reassign First: {fraudlentOrderIDs[0]}");

            //Initializing an array
            string[] fraudulentOrderIDs = ["A123", "B456", "C789"];
            string[] playerArray = { "Adam", "Idris", "Nuh" }; // This is an older array initializtion

            Console.WriteLine($"The size of the array is {fraudlentOrderIDs.Length}");

            foreach (var item in fraudlentOrderIDs)
            {
                Console.WriteLine($"The item is {item}");
            }
        }


        public static void CodeChallenge()
        {
            string[] orderID_array = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

            foreach (var item in orderID_array)
            {
                Console.WriteLine(item);
            }
        }

    }


}
