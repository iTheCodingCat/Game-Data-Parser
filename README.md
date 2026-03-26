# Video Game Data Loader (C#) 🎮

A C# Console Application designed to read and parse video game data from JSON files. This project was developed as part of the "Ultimate C# Masterclass" to practice robust error handling, File I/O operations, and JSON serialization.

## 🚀 Features

- **Robust Error Handling**: Gracefully handles empty inputs, missing files, and malformed JSON data.
- **File I/O**: Dynamically reads data from external files.
- **JSON Parsing**: Deserializes JSON strings into strongly-typed C# objects.

## ⚠️ Error Handling

The application is designed to handle the following scenarios:

| Scenario | Application Behavior |
|----------|----------------------|
| Empty file name | Displays: "File name cannot be empty." |
| File not found | Displays: "File not found." |
| Invalid JSON content | Displays a red error message showing the invalid content. |
| Other exceptions | Logged to the console with a user-friendly message. |

## 📋 Sample JSON Input

To test the application, create a file named `games.json` with the following content:

```json
[
    { "Title": "Stardew Valley", "ReleaseYear": 2016, "Rating": 4.9 },
    { "Title": "Frostpunk", "ReleaseYear": 2017, "Rating": 4.7 },
    { "Title": "Oxygen Not Included", "ReleaseYear": 2017, "Rating": 4.8 },
    { "Title": "Red Dead Redemption II", "ReleaseYear": 2018, "Rating": 4.8 },
    { "Title": "Portal 2", "ReleaseYear": 2011, "Rating": 4.8 }
]
```

## 💻 How to Use

1. Run the application.
2. When prompted, enter the JSON file name (e.g., `games.json`).
3. The program will display the loaded data as follows:

**Expected Output:**

```
Loaded games are:
Stardew Valley, released in 2016, rating: 4.9
Frostpunk, released in 2017, rating: 4.7
Oxygen Not Included, released in 2017, rating: 4.8
Red Dead Redemption II, released in 2018, rating: 4.8
Portal 2, released in 2011, rating: 4.8
```

## 🎓 Educational Context

This project is a practical assignment from the Ultimate C# Masterclass, focusing on building resilient applications that can handle unexpected user behavior and data issues.