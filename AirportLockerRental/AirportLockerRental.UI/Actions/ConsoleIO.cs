using AirportLockerRental.DTOS;

namespace AirportLockerRental.Actions
{
    public static class ConsoleIO
    {
        public static void PrintMenu()
        {
            Console.WriteLine("Airport Locker Rental Menu");
            Console.WriteLine("=============================");
            Console.WriteLine("1. View a locker");
            Console.WriteLine("2. Rent a locker");
            Console.WriteLine("3. End a locker rental");
            Console.WriteLine("4. List all locker contents");
            Console.WriteLine("5. Quit\n");
        }

        public static void PrintLockerContents(int number, LockerContents dto)
        {
            Console.WriteLine("============================================");
            Console.WriteLine($"Locker Number: {number}");
            Console.WriteLine($"Renter: {dto.RenterName}");
            Console.WriteLine($"Contents: {dto.Description}");
            Console.WriteLine("============================================");
        }

        public static void AnyKey()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static string GetRequiredString(string prompt)
        {
            string? input;

            do
            {
                Console.Write(prompt);
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("This field is required.");
                }
                else
                {
                    break;
                }
            }
            while (true);

            return input;
        }

        public static int GetLockerNumber()
        {
            int number;

            do
            {
                Console.Write("Enter locker number: ");
                if (int.TryParse(Console.ReadLine(), out number) && number >= 1 && number <= 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You must enter a number from 1 to 100");
                }
            }
            while (true);

            return number;
        }

        public static int GetMenuChoice()
        {
            int choice;

            do
            {
                Console.Write("Enter your choice (1-5): ");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("You must enter a number from 1 to 5.");
                }
            } while (true);

            return choice;
        }
    }
}
