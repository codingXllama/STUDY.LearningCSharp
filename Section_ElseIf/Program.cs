namespace Section_ElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            BusinessLogic();
        }



        public static void BusinessLogic()
        {

            /**
             You've been asked to add a feature to your company's software. The feature is intended to improve the renewal rate of subscriptions to the software. Your task is to display a renewal message when a user logs into the software system and is notified their subscription will soon end. You'll need to add a couple of decision statements to properly add branching logic to the application to satisfy the requirements.
              **/

            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            /*
            if (daysUntilExpiration <= 10)
            {
                Console.WriteLine($"Days until Expiration is: {daysUntilExpiration}\nYour subscription will expire soon. Renew now! ");
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save 10%!");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!\r\nRenew now and save 20%!");
            }
            else
            {
                Console.WriteLine($"Days until Expiration is: {daysUntilExpiration}\nYour subscription has expired.");
            }
            */


            if (!(daysUntilExpiration > 10))
            {
                Console.WriteLine($"Days Until Expiration: {daysUntilExpiration}");
                if (daysUntilExpiration == 0)
                {
                    Console.WriteLine($"Days Until Expiration: {daysUntilExpiration}");
                    Console.WriteLine("Your subscription has expired.");
                }
                else if (daysUntilExpiration == 1)
                {
                    Console.WriteLine($"Days Until Expiration: {daysUntilExpiration}");
                    Console.WriteLine("Your subscription expires within a day!\r\nRenew now and save 20%!");
                }
                else if (daysUntilExpiration <= 5)
                {
                    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\r\nRenew now and save 10%!");
                }
                else if (daysUntilExpiration <= 10)
                {
                    Console.WriteLine($"Days Until Expiration: {daysUntilExpiration}");
                    Console.WriteLine("Your subscription will expire soon. Renew now!");
                }
            }
            else
            {
                Console.WriteLine($"Days Until Expiration: {daysUntilExpiration}\nNothing");
            }

        }
    }
}
