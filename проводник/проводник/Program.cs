using System;
using System.IO;
using System.Linq;

class FileExplorer
{
    private static string currentDirectory;

    static void Main(string[] args)
    {
        currentDirectory = Directory.GetCurrentDirectory();
        ShowMainMenu();
    }

    static void ShowMainMenu()
    {
        Console.Clear();
        Console.WriteLine("=== Консольный проводник ===");
        Console.WriteLine("1. Работа с текущей файловой системой");
        Console.WriteLine("2. Работа с дисками");
        Console.WriteLine("3. Выход");
        Console.Write("Выберите действие: ");

        var choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                ShowFileSystemMenu();
                break;
            case "2":
                ShowDrivesMenu();
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Неверный выбор. Попробуйте снова.");
                Console.ReadKey();
                ShowMainMenu();
                break;
        }
    }

    static void ShowFileSystemMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Текущая директория: {currentDirectory}");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Просмотр содержимого каталога");
            Console.WriteLine("2. Перейти в подкаталог");
            Console.WriteLine("3. Вернуться в родительский каталог");
            Console.WriteLine("4. Открыть файл");
            Console.WriteLine("5. Создать каталог");
            Console.WriteLine("6. Создать файл");
            Console.WriteLine("7. Удалить файл или каталог");
            Console.WriteLine("8. Вернуться в главное меню");
            Console.Write("Выберите действие: ");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ShowDirectoryContents();
                    break;
                case "2":
                    EnterSubdirectory();
                    break;
                case "3":
                    GoToParentDirectory();
                    break;
                case "4":
                    OpenFile();
                    break;
                case "5":
                    CreateDirectory();
                    break;
                case "6":
                    CreateFile();
                    break;
                case "7":
                    DeleteItem();
                    break;
                case "8":
                    ShowMainMenu();
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void ShowDrivesMenu()
    {
        Console.Clear();
        Console.WriteLine("=== Доступные диски ===");
        var drives = DriveInfo.GetDrives();

        for (int i = 0; i < drives.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {drives[i].Name} ({drives[i].DriveType})");
        }

        Console.WriteLine($"{drives.Length + 1}. Вернуться в главное меню");
        Console.Write("Выберите диск или действие: ");

        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            if (choice >= 1 && choice <= drives.Length)
            {
                currentDirectory = drives[choice - 1].RootDirectory.FullName;
                ShowDriveOperationsMenu(drives[choice - 1]);
            }
            else if (choice == drives.Length + 1)
            {
                ShowMainMenu();
            }
            else
            {
                Console.WriteLine("Неверный выбор.");
                Console.ReadKey();
                ShowDrivesMenu();
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод.");
            Console.ReadKey();
            ShowDrivesMenu();
        }
    }

    static void ShowDriveOperationsMenu(DriveInfo drive)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Диск: {drive.Name}");
            Console.WriteLine($"Тип: {drive.DriveType}");
            Console.WriteLine($"Файловая система: {drive.DriveFormat}");
            Console.WriteLine($"Общий размер: {drive.TotalSize / (1024 * 1024 * 1024)} GB");
            Console.WriteLine($"Свободно: {drive.TotalFreeSpace / (1024 * 1024 * 1024)} GB");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Просмотр содержимого диска");
            Console.WriteLine("2. Создать каталог");
            Console.WriteLine("3. Создать файл");
            Console.WriteLine("4. Удалить файл или каталог");
            Console.WriteLine("5. Вернуться к списку дисков");
            Console.WriteLine("6. Вернуться в главное меню");
            Console.Write("Выберите действие: ");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ShowDirectoryContents();
                    break;
                case "2":
                    CreateDirectory();
                    break;
                case "3":
                    CreateFile();
                    break;
                case "4":
                    DeleteItem();
                    break;
                case "5":
                    ShowDrivesMenu();
                    break;
                case "6":
                    ShowMainMenu();
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void ShowDirectoryContents()
    {
        Console.Clear();
        Console.WriteLine($"Содержимое: {currentDirectory}");
        Console.WriteLine("====================================");

        try
        {
            // Показываем подкаталоги
            var directories = Directory.GetDirectories(currentDirectory);
            Console.WriteLine("Каталоги:");
            foreach (var dir in directories)
            {
                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"  [DIR]  {dirInfo.Name} ({dirInfo.CreationTime})");
            }

            // Показываем файлы
            var files = Directory.GetFiles(currentDirectory);
            Console.WriteLine("\nФайлы:");
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                Console.WriteLine($"  [FILE] {fileInfo.Name} ({fileInfo.Length} bytes, {fileInfo.CreationTime})");
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Ошибка: Нет доступа к этой директории.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Ошибка: Директория не найдена.");
        }

        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
        Console.ReadKey();
    }

    static void EnterSubdirectory()
    {
        Console.Write("Введите имя подкаталога: ");
        var subdirectory = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(subdirectory))
        {
            Console.WriteLine("Имя каталога не может быть пустым.");
            Console.ReadKey();
            return;
        }

        var newPath = Path.Combine(currentDirectory, subdirectory);
        if (Directory.Exists(newPath))
        {
            currentDirectory = newPath;
        }
        else
        {
            Console.WriteLine($"Каталог '{subdirectory}' не существует.");
            Console.ReadKey();
        }
    }

    static void GoToParentDirectory()
    {
        var parent = Directory.GetParent(currentDirectory);
        if (parent != null)
        {
            currentDirectory = parent.FullName;
        }
        else
        {
            Console.WriteLine("Вы уже в корневой директории.");
            Console.ReadKey();
        }
    }

    static void OpenFile()
    {
        Console.Write("Введите имя файла для открытия: ");
        var fileName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Имя файла не может быть пустым.");
            Console.ReadKey();
            return;
        }

        var filePath = Path.Combine(currentDirectory, fileName);
        if (File.Exists(filePath))
        {
            try
            {
                Console.Clear();
                Console.WriteLine($"Содержимое файла: {filePath}");
                Console.WriteLine("====================================");
                var content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine($"Файл '{fileName}' не существует.");
        }

        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
        Console.ReadKey();
    }

    static void CreateDirectory()
    {
        Console.Write("Введите имя нового каталога: ");
        var dirName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(dirName))
        {
            Console.WriteLine("Имя каталога не может быть пустым.");
            Console.ReadKey();
            return;
        }

        var newDirPath = Path.Combine(currentDirectory, dirName);
        try
        {
            Directory.CreateDirectory(newDirPath);
            Console.WriteLine($"Каталог '{dirName}' успешно создан.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании каталога: {ex.Message}");
        }

        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
        Console.ReadKey();
    }

    static void CreateFile()
    {
        Console.Write("Введите имя нового файла: ");
        var fileName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Имя файла не может быть пустым.");
            Console.ReadKey();
            return;
        }

        var filePath = Path.Combine(currentDirectory, fileName);
        if (File.Exists(filePath))
        {
            Console.WriteLine($"Файл '{fileName}' уже существует.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Введите содержимое файла (для завершения ввода нажмите Enter на пустой строке):");
        var contentLines = new System.Collections.Generic.List<string>();
        while (true)
        {
            var line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
                break;
            contentLines.Add(line);
        }

        try
        {
            File.WriteAllLines(filePath, contentLines);
            Console.WriteLine($"Файл '{fileName}' успешно создан.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании файла: {ex.Message}");
        }

        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
        Console.ReadKey();
    }

    static void DeleteItem()
    {
        Console.Write("Введите имя файла или каталога для удаления: ");
        var itemName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(itemName))
        {
            Console.WriteLine("Имя не может быть пустым.");
            Console.ReadKey();
            return;
        }

        var itemPath = Path.Combine(currentDirectory, itemName);
        if (File.Exists(itemPath))
        {
            Console.Write($"Вы уверены, что хотите удалить файл '{itemName}'? (y/n): ");
            var confirm = Console.ReadLine();
            if (confirm?.ToLower() == "y")
            {
                try
                {
                    File.Delete(itemPath);
                    Console.WriteLine($"Файл '{itemName}' успешно удален.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при удалении файла: {ex.Message}");
                }
            }
        }
        else if (Directory.Exists(itemPath))
        {
            Console.Write($"Вы уверены, что хотите удалить каталог '{itemName}' и все его содержимое? (y/n): ");
            var confirm = Console.ReadLine();
            if (confirm?.ToLower() == "y")
            {
                try
                {
                    Directory.Delete(itemPath, true);
                    Console.WriteLine($"Каталог '{itemName}' успешно удален.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при удалении каталога: {ex.Message}");
                }
            }
        }
        else
        {
            Console.WriteLine($"Файл или каталог '{itemName}' не существует.");
        }

        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
        Console.ReadKey();
    }
}