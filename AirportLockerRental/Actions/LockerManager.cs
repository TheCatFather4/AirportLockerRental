using AirportLockerRental.DTOS;

namespace AirportLockerRental.Actions
{
    public class LockerManager
    {
        private LockerContents[] _lockers = new LockerContents[100];

        public void RentLocker(int number)
        {
            if (_lockers[number - 1] != null)
            {
                Console.WriteLine($"Locker number {number} is already rented.");
            }
            else
            {
                string name = ConsoleIO.GetRequiredString("Enter renter name: ");
                string item = ConsoleIO.GetRequiredString("Enter item description: ");

                _lockers[number - 1].RenterName = name;
                _lockers[number - 1].Description = item;

                Console.WriteLine($"Locker number {number} has been rented for {item} storage.");
            }
        }
    }
}
