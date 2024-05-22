namespace FlowControl.ConsoleMessages;

public static class InformationMessages
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Flow Control main menu!");
    }

    public static void PresentOptions()
    {
        Console.Write("Make your choice between 1-3");
    }

    public static void ExitMessage()
    {
        Console.WriteLine("Exits program...");
    }
}