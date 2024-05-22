using FlowControl.ConsoleMessages;

namespace FlowControl.ClientInteraction;

public static class UserInputs
{
    public static int GetUserChoice()
    {
        bool input = Int32.TryParse(Console.ReadLine(), out int anotherChance);
        if (input)
        {
            return anotherChance;
        }

        ErrorMessages.ErrorMessageInvalidUsrInput();
        return GetUserChoice();
    }

    public static string GetUserInput()
    {
        string input = Console.ReadLine() ?? string.Empty;
        return input;
    }
}