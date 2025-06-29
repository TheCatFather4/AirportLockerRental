using AirportLockerRental.Actions;
using AirportLockerRental.DTOS;

namespace AirportLockerRental.Workflow
{
    public static class App
    {
        public static void Run()
        {
            LockerManager mgr = new LockerManager();

            do
            {
                ConsoleIO.PrintMenu();
                int choice = ConsoleIO.GetMenuChoice();

                if (choice < 4)
                {
                    int number = ConsoleIO.GetLockerNumber();

                    if (choice == 1)
                    {
                        if (!mgr.IsAvailable(number))
                        {
                            LockerContents contents = mgr.GetLockerContents(number);
                            ConsoleIO.PrintLockerContents(number, contents);
                        }
                        else
                        {
                            Console.WriteLine($"Locker number {number} is currently empty.");
                        }
                    }
                    else if (choice == 2)
                    {
                        if (mgr.IsAvailable(number))
                        {
                            LockerContents contents = mgr.RentLocker(number);
                            Console.WriteLine($"Locker number {number} has been rented for {contents.Description} storage.");
                        }
                        else
                        {
                            Console.WriteLine($"Locker number {number} is already rented.");
                        }
                    }
                    else
                    {
                        if (!mgr.IsAvailable(number))
                        {
                            LockerContents c1 = mgr.GetLockerContents(number);
                            string item = c1.Description;
                            LockerContents c2 = mgr.ReturnLocker(number);
                            Console.WriteLine($"Locker number {number} rental has ended. Please take your {item}.");
                        }
                        else
                        {
                            Console.WriteLine($"Locker number {number} is already empty.");
                        }
                    }
                }
                else if (choice == 4)
                {
                    mgr.ViewAllLockers();
                }
                else
                {
                    break;
                }

                ConsoleIO.AnyKey();
                Console.Clear();
            }
            while (true);
        }
    }
}
