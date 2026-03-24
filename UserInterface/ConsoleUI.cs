namespace GameDataParser.UserInterface{}

public class ConsoleUI
{
    public string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void ShowError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    public void WaitForUser()
    {
        Console.WriteLine("Press any key to close...");
        Console.ReadKey();
    }
}