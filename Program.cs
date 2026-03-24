ConsoleUI ui = new ConsoleUI();
FileService fileService = new FileService();

string fileName = fileService.GetValidFileName();
ui.ShowMessage($"File '{fileName}' found and is valid. Moving to next step...");

ui.WaitForUser();