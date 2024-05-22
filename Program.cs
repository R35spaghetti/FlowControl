Console.WriteLine("Welcome to the Flow Control main menu!");
int choice;

do
{
    Console.Write("Make your choice between 1-3");
    choice = GetUserInput();

    switch (choice)
    {
        case 0:
            Console.WriteLine("Exits program...");
            break;
        default:
            ErrorMessageInvalidUsrInput();
            break;
    }
} while (choice != 0);


int GetUserInput()
{
    bool input = Int32.TryParse(Console.ReadLine(), out int anotherChance);
    if (input)
    {
        return anotherChance;
    }

    ErrorMessageInvalidUsrInput();
    return GetUserInput();
}

void ErrorMessageInvalidUsrInput()
{
    Console.WriteLine("Enter a number between 1-3.");
}