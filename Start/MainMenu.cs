using FlowControl.ClientInteraction;
using FlowControl.ConsoleMessages;
using FlowControl.MenuChoices;

namespace FlowControl.Start;

public class MainMenu
{
    private int _choice { get; set; }

    public MainMenu(int choice)
    {
        _choice = choice;
    }


    public void PresentMainMenu()
    {
        do
        {
            InformationMessages.PresentOptions();
            _choice = UserInputs.GetUserChoice();

            switch (_choice)
            {
                case 0:
                    InformationMessages.ExitMessage();
                    break;
                case 1:
                    int priceOfTickets = MenuOptions.OrderMovieTickets();
                    Console.WriteLine($"Total price: {priceOfTickets}");
                    break;
                case 2:
                    MenuOptions.RepeatTenTimes();
                    break;
                case 3:
                    MenuOptions.GetThirdWord();
                    break;
                default:
                    ErrorMessages.ErrorMessageInvalidUsrInput();
                    break;
            }
        } while (_choice != 0);
    }
}