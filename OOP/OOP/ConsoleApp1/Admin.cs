namespace DEMO
{
    public class Admin : Person, ISlotViewer
    {
        private int bookedSlots = 5;
        private int totalNumberOfSlots = 11;
        private int freeSlots;

        public int NumberOfSlots
        {
            get => totalNumberOfSlots;

            set => totalNumberOfSlots = value;

        }

        public int FreeSlots { get => totalNumberOfSlots - bookedSlots; set => value = 10; }


        public override string LogIn()
        {
            return "LogIn";
        }

        public string LogOut()
        {
            return "LogOut";
        }

        public int ViewSlots()
        {
            return NumberOfSlots + FreeSlots;
        }
    }
}
