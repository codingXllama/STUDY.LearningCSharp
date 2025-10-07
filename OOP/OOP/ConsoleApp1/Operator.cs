namespace DEMO
{
    class Operator : Person, ISlotViewer
    {
        int totalSlots = 30;
        int usedSlots = 10;
        public int NumberOfSlots { get => NumberOfSlots; set => value = totalSlots; }
        public int FreeSlots { get => FreeSlots; set => value = totalSlots - usedSlots; }

        public override string LogIn()
        {


            throw new NotImplementedException();
        }

        public int ViewSlots()
        {
            throw new NotImplementedException();
        }

        public int GetFreeSlots()
        {

            // return fREE
        }

        public int CalculateMoney()
        {
            throw new NotImplementedException();
        }

        public int AddProfitToDate()
        {
            throw new NotImplementedException();
        }


    }
}
