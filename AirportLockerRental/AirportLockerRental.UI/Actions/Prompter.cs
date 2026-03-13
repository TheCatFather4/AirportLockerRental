namespace AirportLockerRental.UI.Actions
{
    /// <summary>
    /// Used to prompt the user.
    /// </summary>
    public static class Prompter
    {
        /// <summary>
        /// Prompts the user to press any key.
        /// </summary>
        public static void AnyKey()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prompts the user to select a locker number.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public static int GetLockerNumber(string prompt)
        {
            Console.WriteLine(prompt);
            Console.WriteLine("Locker numbers range from 1 to 100.\n");

            do
            {
                Console.Write("Enter your choice: ");

                string? lockerInput = Console.ReadLine();

                if (!int.TryParse(lockerInput, out int lockerChoice) || lockerChoice < 1 || lockerChoice > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 100.\n");
                }
                else
                {
                    return lockerChoice;
                }
            } while (true);
        }

        /// <summary>
        /// Prompts the user to select a menu choice from 1 to 5.
        /// </summary>
        /// <returns></returns>
        public static int GetMenuChoice()
        {
            do
            {
                Console.Write("\nEnter your choice: ");
                string? input = Console.ReadLine();

                if (!int.TryParse(input, out int choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 5.");
                }
                else
                {
                    return choice;
                }
            }
            while (true);
        }

        /// <summary>
        /// Prompts the user for string input.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        public static string GetRequiredString(string prompt)
        {
            do
            {
                Console.Write($"\n{prompt}");
                string? name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("This field is required for rental.");
                }
                else
                {
                    return name;
                }
            }
            while (true);
        }
    }
}