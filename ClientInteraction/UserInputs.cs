using FlowControl.ConsoleMessages;

namespace FlowControl.ClientInteraction;

public static class UserInputs
{
    public static int GetUserInput()
    {
        bool input = Int32.TryParse(Console.ReadLine(), out int anotherChance);
        if (input)
        {
            return anotherChance;
        }

        ErrorMessages.ErrorMessageInvalidUsrInput();
        return GetUserInput();
    }
}