namespace FlowControl.ConsoleMessages;

public static class InformationMessages
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Flow Control main menu!");
    }

    public static void PresentOptions()
    {
        Console.WriteLine("\n**Choose between 0-3**" +
                          "\n 0: Exit program" +
                          "\n 1: Order movie tickets" +
                          "\n 2: Print your input 10 times in the console" +
                          "\n 3: Print the third word in a sentence");
    }

    public static void ExitMessage()
    {
        Console.WriteLine("Exits program...");
    }
}