using AirportLockerRental.UI.DTOs;

namespace AirportLockerRental.UI.Actions
{
    public class LockerManager
    {
        public Locker[] Lockers { get; private set; }

        public LockerManager()
        {
            var lockers = new Locker[100];

            for (int i = 0; i < lockers.Length; i++)
            {
                lockers[i] = new Locker();
            }

            Lockers = lockers;
        }

        public void EndLockerRental(int lockerNumber)
        {
            Lockers[lockerNumber - 1].RenterName = null;
            Lockers[lockerNumber - 1].Contents = null;
        }

        public bool IsRented(int lockerNumber)
        {
            if (Lockers[lockerNumber - 1].RenterName != null)
            {
                return true;
            }

            return false;
        }

        public void PrintAllLockers()
        {
            for (int i = 0; i < Lockers.Length; i++)
            {
                if (IsRented(i + 1))
                {
                    Printer.PrintLocker(i + 1, Lockers[i]);
                }
            }
        }

        public void RentLocker(int lockerNumber)
        {
            Lockers[lockerNumber - 1].RenterName = Prompter.GetRequiredString("Enter your name: ");
            Lockers[lockerNumber - 1].Contents = Prompter.GetRequiredString("Enter locker contents: ");
        }
    }
}