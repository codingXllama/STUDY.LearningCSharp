namespace RandomDiceRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //🆕Overloading a method

            //int number = 7;
            //string text="seven";

            //Console.WriteLine(number);
            //Console.WriteLine();
            //Console.WriteLine(text);

            Random myDice = new Random();
            int roll1 = myDice.Next();
            int roll2 = myDice.Next(100);
            int roll3 = myDice.Next(50,100);

            Console.WriteLine($"The First Role: {roll1}");
            Console.WriteLine($"The Second Role: {roll2}");
            Console.WriteLine($"The Third Role: {roll3}");

            //Finding the max of 2 rolls

            int largerValue = Math.Max(roll1,roll2);
            Console.WriteLine($"The larger value is: {largerValue}");







        }
    }
}
