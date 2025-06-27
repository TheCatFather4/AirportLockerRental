using AirportLockerRental.DTOS;

namespace AirportLockerRental.Actions
{
    public class LockerManager
    {
        private LockerContents[] _lockers = new LockerContents[100];

        public void ViewLocker(int number)
        {
            if (_lockers[number - 1] != null)
            {
                ConsoleIO.PrintLockerContents(number, _lockers[number - 1]);
            }
            else
            {
                Console.WriteLine($"Locker number {number} is currently empty.");
            }
        }

        public void RentLocker(int number)
        {
            if (_lockers[number - 1] != null)
            {
                Console.WriteLine($"Locker number {number} is already rented.");
            }
            else
            {
                LockerContents contents = new LockerContents();

                string name = ConsoleIO.GetRequiredString("Enter renter name: ");
                string item = ConsoleIO.GetRequiredString("Enter item description: ");

                contents.RenterName = name;
                contents.Description = item;

                _lockers[number - 1] = contents;

                Console.WriteLine($"Locker number {number} has been rented for {item} storage.");
            }
        }

        public void ReturnLocker(int number)
        {
            if (_lockers[number -1] == null)
            {
                Console.WriteLine($"Locker number {number} is already empty.");
            }
            else
            {
                string item = _lockers[number - 1].Description;
                _lockers[number - 1] = null;
                Console.WriteLine($"Locker number {number} rental has ended. Please take your {item}.");
            }
        }

        public void ViewAllLockers()
        {
            for (int i = 0; i < _lockers.Length; i++)
            {
                if (_lockers[i] != null)
                {
                    ConsoleIO.PrintLockerContents(i + 1, _lockers[i]);
                }
            }
        }
    }
}
