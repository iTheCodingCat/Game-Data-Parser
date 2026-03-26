using System.Text.Json;

namespace GameDataParser.Services
{

    public class FileService
    {
        private readonly ConsoleUI _ui;

        public FileService(ConsoleUI ui)
        {
            _ui = ui;
        }
        public string GetValidFileName()
        {
            string fileName = "";
            bool isValid = false;

            while (!isValid)
            {
                string input = _ui.GetUserInput("Enter the name of the file you want to read:");

                if (input == null)
                {
                    _ui.ShowError("File name cannot be null.");
                    continue;
                }
                if (string.IsNullOrWhiteSpace(input))
                {
                    _ui.ShowError("File name cannot be empty.");
                    continue;
                }
                if (!File.Exists(input))
                {
                    _ui.ShowError("File not found.");
                    continue;
                }

                fileName = input;
                isValid = true;
            }

            return fileName;
        }

        public List<Game> ReadGamesFromFile(string fileName)
        {
            try
            {
                string jsonContent = File.ReadAllText(fileName);
                List<Game> games = JsonSerializer.Deserialize<List<Game>>(jsonContent);
                if (games == null)
                {
                    return new List<Game>();
                }
                return games;
            }
            catch (JsonException ex)
            {
                string jsonContent = File.ReadAllText(fileName);
                _ui.ShowError($"JSON in the {fileName} was not in a valid format. JSON body:");
                Console.WriteLine(jsonContent);

                throw new Exception($"Invalid JSON format in file: {fileName}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error reading file: {fileName}", ex);
            }
        }
    }
}
