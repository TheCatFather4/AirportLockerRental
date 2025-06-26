using AirportLockerRental.Actions;

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

                    if (number == 1)
                    {
                        // view locker
                    }
                    else if (number == 2)
                    {
                        mgr.RentLocker(number);
                    }
                    else
                    {
                        // return locker
                    }
                }
                else if (choice == 4)
                {
                    // print all lockers
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
