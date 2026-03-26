using GameDataParser.Services;

ConsoleUI ui = new ConsoleUI();
FileService fileService = new FileService(ui);

try
{
    string fileName = fileService.GetValidFileName();
    List<Game> games = fileService.ReadGamesFromFile(fileName);

    ui.ShowMessage($"Successfully loaded {games.Count} games from file.");
    foreach (var game in games)
    {
        Console.WriteLine($"{game.Title} - {game.Rating} - {game.ReleaseYear}");
    }
}
catch (Exception ex)
{

    ui.ShowError("Sorry! The application has experienced an unexpected error and will have to be closed.");


    ui.ShowMessage($"Error details: {ex.Message}");
}
ui.WaitForUser();