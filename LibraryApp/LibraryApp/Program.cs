using LibraryApp.Controllers;
using ServiceLayer.Helpers;

LibraryControllers controllers= new();

while (true)
{
    ConsoleColor.DarkYellow.WriteConsole("Select one option");
    ConsoleColor.DarkYellow.WriteConsole("Library option: 1.Create, 2.Get By Id, 3.Delete");

    SelectOption:  string option = Console.ReadLine();

    int selectedOption;

    bool isParseOption = int.TryParse(option, out selectedOption);

    if (isParseOption)
    {
        switch(selectedOption)
        {
            case 1:
                controllers.Create();
                break;
            case 2:
                controllers.GetById();
                break;
            case 3:
                Console.WriteLine("Delete");
                break;
            default:
                Console.WriteLine("Select again true option");
                goto SelectOption;
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Please select true option");
        goto SelectOption;
    }
}