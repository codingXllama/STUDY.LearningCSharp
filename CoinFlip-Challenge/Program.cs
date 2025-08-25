namespace CoinFlip_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random coinFlip = new Random();
            string HeadsOrTails = coinFlip.Next(1,3) ==1 ? "Heads" : "Tails";
            Console.WriteLine($"The face of the coin is {HeadsOrTails}");

        }

        

    }
}
