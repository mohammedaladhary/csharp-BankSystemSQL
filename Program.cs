namespace csharp_BankSystemSQL;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("      Welcome To    ");
        Console.WriteLine("    Banking System      \n");
        Console.ResetColor();
        Console.WriteLine("\n\n\n\n\n\nPress any key to start.....");
        Console.ReadLine();
        HomePage homePage = new HomePage();
        homePage.mainMenu();
    }

}

