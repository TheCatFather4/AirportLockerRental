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

                    if (choice == 1)
                    {
                        mgr.ViewLocker(number);
                    }
                    else if (choice == 2)
                    {
                        mgr.RentLocker(number);
                    }
                    else
                    {
                        mgr.ReturnLocker(number);
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
