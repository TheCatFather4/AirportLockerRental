using AirportLockerRental.UI.DTOs;

namespace AirportLockerRental.UI.Actions
{
    /// <summary>
    /// Used to manage the state of all lockers.
    /// </summary>
    public class LockerManager
    {
        /// <summary>
        /// Represents the array of lockers.
        /// </summary>
        public Locker[] Lockers { get; private set; }

        /// <summary>
        /// Initializes a LockerManager with an array of 100 lockers.
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
        /// Ends a locker rental by setting the member values of the locker to null.
        /// </summary>
        /// <param name="lockerNumber">The locker number of the rental to end.</param>
        public void EndLockerRental(int lockerNumber)
        {
            Lockers[lockerNumber - 1].RenterName = null;
            Lockers[lockerNumber - 1].Contents = null;
        }

        /// <summary>
        /// Checks to see if a locker is rented. Returns true if rented, false if empty.
        /// </summary>
        /// <param name="lockerNumber">The locker number to check.</param>
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
        /// Prints all rented lockers to the console.
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
        /// Rents a locker by assigning values to a locker's members.
        /// </summary>
        /// <param name="lockerNumber">The number of the locker to rent.</param>
        /// <param name="locker">A locker object that contains the renter's name and locker contents to be assigned.</param>
        public void RentLocker(int lockerNumber, Locker locker)
        {
            Lockers[lockerNumber - 1].RenterName = locker.RenterName;
            Lockers[lockerNumber - 1].Contents = locker.Contents;
        }
    }
}