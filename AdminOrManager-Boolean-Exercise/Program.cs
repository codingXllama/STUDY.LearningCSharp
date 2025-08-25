namespace AdminOrManager_Boolean_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //string userPermissions = "Admin|Manager";
            Random roll = new Random();

            string userPermissions = roll.Next(1, 3) == 1 ? "Admin" : "Manager";
            //int level = 55;
            int randomLevel = roll.Next(100);

            if (userPermissions.Contains("Admin"))
            {
                if (randomLevel > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user");
                }
                //else if (randomLevel <= 55)
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }

            }

            else if (userPermissions.Contains("Manager"))
            {
                if (randomLevel >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                //else if (randomLevel < 20)
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }



        }
    }
}
