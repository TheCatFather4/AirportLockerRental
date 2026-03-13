using AirportLockerRental.UI.DTOs;

namespace AirportLockerRental.UI.Actions
{
    /// <summary>
    /// Used to manage the state of all the lockers.
    /// </summary>
    public class LockerManager
    {
        public Locker[] Lockers { get; private set; }

        /// <summary>
        /// Constructs a locker manager with an array of 100 lockers.
        /// </summary>
        public LockerManager()
        {
            var lockers = new Locker[100];

            for (int i = 0; i < lockers.Length; i++)
            {
                lockers[i] = new Locker();
            }

            Lockers = lockers;
        }

        /// <summary>
        /// Ends a locker rental by removing the current values of the renter name and locker contents.
        /// </summary>
        /// <param name="lockerNumber"></param>
        public void EndLockerRental(int lockerNumber)
        {
            Lockers[lockerNumber - 1].RenterName = null;
            Lockers[lockerNumber - 1].Contents = null;
        }

        /// <summary>
        /// Checks to see if a locker is rented.
        /// </summary>
        /// <param name="lockerNumber"></param>
        /// <returns></returns>
        public bool IsRented(int lockerNumber)
        {
            if (Lockers[lockerNumber - 1].RenterName != null)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Prints all lockers that are rented.
        /// </summary>
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

        /// <summary>
        /// Rents a locker by assigning a renter name and locker contents.
        /// </summary>
        /// <param name="lockerNumber"></param>
        /// <param name="locker"></param>
        public void RentLocker(int lockerNumber, Locker locker)
        {
            Lockers[lockerNumber - 1].RenterName = locker.RenterName;
            Lockers[lockerNumber - 1].Contents = locker.Contents;
        }
    }
}