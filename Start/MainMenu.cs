using FlowControl.ClientInteraction;
using FlowControl.ConsoleMessages;

namespace FlowControl.Start;

public class MainMenu
{
    private int Choice { get; set; }

    public MainMenu(int choice)
    {
        Choice = choice;
    }


    public void PresentMainMenu()
    {
        do
        {
            InformationMessages.PresentOptions();
            Choice = UserInputs.GetUserInput();

            switch (Choice)
            {
                case 0:
                    InformationMessages.ExitMessage();
                    break;
                default:
                    ErrorMessages.ErrorMessageInvalidUsrInput();
                    break;
            }
        } while (Choice != 0);
    }
}