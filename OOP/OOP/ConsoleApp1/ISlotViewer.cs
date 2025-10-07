namespace DEMO
{
    interface ISlotViewer
    {
         int NumberOfSlots { get;  set; }
         int FreeSlots { get;  set; }


        int ViewSlots();

    }
}
