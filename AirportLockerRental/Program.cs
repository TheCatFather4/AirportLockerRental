int choice;
string[] lockers = new string[100];
int lockerNumber;

do
{
    Console.WriteLine("Airport Locker Rental Menu");
    Console.WriteLine("=============================");
    Console.WriteLine("1. View a locker");
    Console.WriteLine("2. Rent a locker");
    Console.WriteLine("3. End a locker rental");
    Console.WriteLine("4. List all locker contents");
    Console.WriteLine("5. Quit\n");

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

    Console.WriteLine();

    if (choice < 4)
    {
        do
        {
            Console.Write("Enter locker number: ");
            if (int.TryParse(Console.ReadLine(), out lockerNumber) && lockerNumber >= 1 && lockerNumber <= 100)
            {
                break;
            }
            else
            {
                Console.WriteLine("Locker numbers are only from 1 to 100. Please try another number.");
            }
        } while (true);

        if (choice == 1)
        {
            if (lockers[lockerNumber - 1] == null)
            {
                Console.WriteLine($"Locker {lockerNumber} is currently empty.");
            }
            else
            {
                Console.WriteLine($"Locker {lockerNumber} contents: {lockers[lockerNumber - 1]}");
            }
        }
        else if (choice == 2)
        {
            if (lockers[lockerNumber - 1] != null)
            {
                Console.WriteLine($"Locker {lockerNumber} is already rented. Please try another locker.");
            }
            else
            {
                do
                {
                    Console.Write("Enter the item you want to store in the locker: ");
                    string item = Console.ReadLine();
                    if (string.IsNullOrEmpty(item))
                    {
                        Console.WriteLine("This field is required.");
                    }
                    else
                    {
                        lockers[lockerNumber - 1] = item;
                        Console.WriteLine($"Locker {lockerNumber} has been rented for {lockers[lockerNumber - 1]} storage.");
                        break;
                    }
                } while (true);
            }
        }
        else
        {
            if (lockers[lockerNumber - 1] == null)
            {
                Console.WriteLine($"Locker {lockerNumber} is not currently rented.");
            }
            else
            {
                string item = lockers[lockerNumber - 1];
                lockers[lockerNumber - 1] = null;
                Console.WriteLine($"Locker {lockerNumber} rental has ended, please take your {item}");
            }
        }
    }
    else if (choice == 4)
    {
        for (int i = 0; i < lockers.Length; i++)
        {
            if (lockers[i] != null)
            {
                Console.WriteLine($"Locker {i + 1}: {lockers[i]}");
            }
        }
    }
    else
    {
        break;
    }
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
    Console.Clear();
} while (true);
