namespace CodeBlocks
{
    class Program
    {
        static void Main(string[] args)
        {

            //bool flag = true;
            //int value;
            //value = 10;
            //if (flag)
            //{
            //    value = 10;
            //    Console.WriteLine($"Inside the code block {value}");
            //}

            //Console.WriteLine($"Outside the code block: {value}");

            //Console.WriteLine($"Inside the code block: {value}");
            //Console.WriteLine($"Outside the code block {value}");
            //IfStatementCodeBlock();

            Exercise();


        }


        public static void IfStatementCodeBlock()
        {
            //bool flag = true;
            //if (flag) Console.WriteLine(flag);

            string name = "steve";
            if (name == "bob") Console.WriteLine("Foun Bob");
            else if (name.Contains("steve")) Console.WriteLine("Found Steve");
            else Console.WriteLine("Found Chunk");

        }

        public static void Exercise()
        {
            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;
            foreach (int number in numbers)
            {
                total += number;
                if (number == 42)
                {
                    found = true;
                }
            }

            if (found)
            {
                Console.WriteLine("Set contains 42");
            }

            Console.WriteLine($"Total: {total}");

        }
    }
}
