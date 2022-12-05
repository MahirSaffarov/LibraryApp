using CompanyApp.Controllers;
using RepositoryLayer.Helpers;

DepartamentController departamentController = new();

while (true)
{
    GetMenues();

    SelectOption:  string option = Console.ReadLine();

    int selectedOption;

    bool isParseOption = int.TryParse(option, out selectedOption);

    if (isParseOption)
    {
        switch(selectedOption)
        {
            case 1:
                departamentController.Create();
                break;
            default:
                Console.WriteLine("Select again true option:");
                goto SelectOption;
        }
    }
}

static void GetMenues()
{
    ConsoleColor.DarkBlue.WriteConsole("Select option: ");
    ConsoleColor.Blue.WriteConsole("1.Create Department");
}