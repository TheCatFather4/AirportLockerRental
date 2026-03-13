using AirportLockerRental.UI.DTOs;

namespace AirportLockerRental.UI.Actions
{
    /// <summary>
    /// Prints information to the console.
    /// </summary>
    public static class Printer
    {
        /// <summary>
        /// Prints a locker's information.
        /// </summary>
        /// <param name="lockerNumber"></param>
        /// <param name="locker"></param>
        public static void PrintLocker(int lockerNumber, Locker locker)
        {
            Console.WriteLine($"Locker {lockerNumber}");
            Console.WriteLine($"Renter: {locker.RenterName}");
            Console.WriteLine($"Contents: {locker.Contents}");
            Console.WriteLine("====================================");
        }

        /// <summary>
        /// Prints the main menu.
        /// </summary>
        public static void PrintMenu()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("| Airport Locker Rental |");
            Console.WriteLine("=========================");
            Console.WriteLine("| 1. View a Locker");
            Console.WriteLine("| 2. Rent a Locker");
            Console.WriteLine("| 3. End Locker Rental");
            Console.WriteLine("| 4. List Locker Contents");
            Console.WriteLine("| 5. Exit");
            Console.WriteLine("=========================");
        }
    }
}