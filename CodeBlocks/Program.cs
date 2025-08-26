namespace CodeBlocks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            int value;
            if (flag)
            {
                value = 10;
                Console.WriteLine($"Inside the code block {value}");
            }

            Console.WriteLine($"Outside the code block: {value}");
        }
    }
}
