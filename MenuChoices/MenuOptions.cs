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
        int people = UserInputs.GetUserChoice();
        if (people == 1)
        {
            Console.WriteLine("Enter your age");
            age = UserInputs.GetUserChoice();
            ticketsTotalPrice = CalculateTicketPrice(age);
        }
        else if (people > 1)
        {
            for (int i = 0; i < people; i++)
            {
                Console.WriteLine($"Enter age for person {i + 1}: ");
                age = UserInputs.GetUserChoice();
                ticketsTotalPrice += CalculateTicketPrice(age);
            }
        }

        return ticketsTotalPrice;

        int CalculateTicketPrice(int agePerson)
        {
            int price = 0;

            if(agePerson is < 5 or > 100)
            {
                
            }
            else if (agePerson < 20)
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

    //Menyval 2: Upprepa tio gånger
    public static void RepeatTenTimes()
    {
        Console.Clear();
        Console.WriteLine("Please enter an arbitrary input");
        string input = UserInputs.GetUserInput();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}.{input} ");
        }
    }

    //Menyval 3: Det tredje ordet
    public static void GetThirdWord()
    {
        bool lessThanThree = true;
        List<string> thirdWord = new List<string>();
        Console.Clear();
        while (lessThanThree)
        {
            Console.WriteLine("Enter a sentence with at least 3 words");
            string input = UserInputs.GetUserInput();
            thirdWord = new List<string>(input.Split([]));
            if (thirdWord.Count >= 3)
            {
                lessThanThree = false;
            }
        }

        Console.WriteLine($"{thirdWord[2]}");
    }
}