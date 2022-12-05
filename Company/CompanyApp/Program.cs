
using CompanyApp.Controllers;
using RepositoryLayer.Helpers;

DepartamentController departamentController = new();

while (true)
{
    GetMenues();

SelectOption: string option = Console.ReadLine();

    int selectedOption;

    bool isParseOption = int.TryParse(option, out selectedOption);

    if (isParseOption)
    {
        switch (selectedOption)
        {
            case 1:
                departamentController.Create();
                break;
            //case 2:
              //  departamentController.Update();
                //break;
            case 3:
                departamentController.Delete();
                break;
            case 4:
                departamentController.GetById();
                break;
            case 5:
                departamentController.GetAll();
                break;
            case 6:
                departamentController.Search();
                break;
            default:
                Console.WriteLine("Select again true option:");
                goto SelectOption;
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Select again true option:");
        goto SelectOption;
    }

}


static void GetMenues()
{
    ConsoleColor.Blue.WriteConsole("Select one option:");
    ConsoleColor.Blue.WriteConsole("1.Create Department");
    ConsoleColor.Blue.WriteConsole("2.Update Department");
    ConsoleColor.Blue.WriteConsole("3.Delete Department");
    ConsoleColor.Blue.WriteConsole("4.Get department  by id");
    ConsoleColor.Blue.WriteConsole("5.Get all departments");
    ConsoleColor.Blue.WriteConsole("6.Search method for departments");
}