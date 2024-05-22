using FlowControl.ClientInteraction;

namespace FlowControl.MenuChoices;

public static class MenuOptions
{
    //Menyval 1: Ungdom eller pensionär
    public static int OrderMovieTickets()
    {
        Console.Clear();
        int ticketsTotalPrice = 0, age;
        Console.WriteLine("How many people are going?");
        int people = UserInputs.GetUserInput();
        if (people == 1)
        {
            Console.WriteLine("Enter your age");
            age = UserInputs.GetUserInput();
            ticketsTotalPrice = CalculateTicketPrice(age);
        }
        else if (people > 1)
        {
            for (int i = 0; i < people; i++)
            {
                Console.WriteLine($"Enter age for person {i + 1}: ");
                age = UserInputs.GetUserInput();
                ticketsTotalPrice += CalculateTicketPrice(age);
            }
        }

        return ticketsTotalPrice;

        int CalculateTicketPrice(int agePerson)
        {
            int price = 0;

            if (agePerson < 20)
            {
                price += 80;
            }
            else if (agePerson > 64)
            {
                price += 90;
            }
            else
            {
                price += 120;
            }


            return price;
        }
    }
}