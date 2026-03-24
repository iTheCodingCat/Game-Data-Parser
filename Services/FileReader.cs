namespace GameDataParser.Services { }

public class FileService
{
    public string GetValidFileName()
    {
        string fileName = "";
        bool isValid = false;

        while (!isValid)
        {
            ConsoleUI ui = new ConsoleUI();
            string input = ui.GetUserInput("Enter the name of the file you want to read:");

            if (input == null)
            {
                ui.ShowError("File name cannot be null.");
                continue;
            }
            if (string.IsNullOrWhiteSpace(input))
            {
                ui.ShowError("File name cannot be empty.");
                continue;
            }
            if (!File.Exists(input))
            {
                ui.ShowError("File not found.");
                continue;
            }

            fileName = input;
            isValid = true;
        }

        return fileName;
    }
}