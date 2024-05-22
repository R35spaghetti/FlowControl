using FlowControl.ConsoleMessages;
using FlowControl.Start;

int choice = 0;
InformationMessages.WelcomeMessage();
MainMenu mainMenu = new MainMenu(choice);
mainMenu.PresentMainMenu();