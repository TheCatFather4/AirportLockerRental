using AirportLockerRental.UI.Actions;
using AirportLockerRental.UI.DTOs;

namespace AirportLockerRental.UI.Workflows
{
    public class App
    {
        public void Run()
        {
            int menuChoice;
            int lockerChoice;
            var mgr = new LockerManager();

            do
            {
                Printer.PrintMenu();

                menuChoice = Prompter.GetMenuChoice();

                switch (menuChoice)
                {
                    case 1:
                        Console.WriteLine("\n====================================");
                        lockerChoice = Prompter.GetLockerNumber("Which locker would you like to view?");

                        if (mgr.IsRented(lockerChoice))
                        {
                            Console.WriteLine("====================================");
                            Printer.PrintLocker(lockerChoice, mgr.Lockers[lockerChoice - 1]);
                        }
                        else
                        {
                            Console.WriteLine($"Locker {lockerChoice} is currently empty.\n");
                        }

                        Prompter.AnyKey();
                        break;
                    case 2:
                        Console.WriteLine("\n====================================");
                        lockerChoice = Prompter.GetLockerNumber("Which locker would you like to rent?");

                        if (mgr.IsRented(lockerChoice))
                        {
                            Console.WriteLine($"Locker {lockerChoice} is already rented. Please select another locker.\n");
                        }
                        else
                        {
                            Locker locker = new Locker();
                            locker.RenterName = Prompter.GetRequiredString("Enter your name: ");
                            locker.Contents = Prompter.GetRequiredString("Enter locker contents: ");

                            mgr.RentLocker(lockerChoice, locker);
                            Console.WriteLine($"\nLocker {lockerChoice} has been rented for {mgr.Lockers[lockerChoice - 1].Contents} storage.");
                        }

                        Prompter.AnyKey();
                        break;
                    case 3:
                        Console.WriteLine("\n====================================");
                        lockerChoice = Prompter.GetLockerNumber("Which locker would you like to end rental?");

                        if (mgr.IsRented(lockerChoice))
                        {
                            string? name = mgr.Lockers[lockerChoice - 1].RenterName;
                            string? item = mgr.Lockers[lockerChoice - 1].Contents;

                            mgr.EndLockerRental(lockerChoice);
                            Console.WriteLine($"\nLocker {lockerChoice} rental successfully ended. \nThank you for using our rental service, {name}. Please remember to take your {item}!");
                        }
                        else
                        {
                            Console.WriteLine($"\nLocker {lockerChoice} is currently not rented.");
                        }

                        Prompter.AnyKey();
                        break;
                    case 4:
                        Console.WriteLine("\n====================================");
                        mgr.PrintAllLockers();
                        Prompter.AnyKey();
                        break;
                    case 5:
                        break;
                }

                Console.Clear();
            }
            while (menuChoice != 5);

            Console.WriteLine("\nThank you for using the Airport Locker Rental!");
        }
    }
}