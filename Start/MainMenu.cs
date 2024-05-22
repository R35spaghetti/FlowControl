using FlowControl.ClientInteraction;
using FlowControl.ConsoleMessages;
using FlowControl.MenuChoices;

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
                case 1:
                    int priceOfTickets = MenuOptions.OrderMovieTickets();
                    Console.WriteLine($"Total price: {priceOfTickets}");
                    break;
                default:
                    ErrorMessages.ErrorMessageInvalidUsrInput();
                    break;
            }
        } while (Choice != 0);
    }
}