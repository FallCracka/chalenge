using System;

class Program
{
    static char[,] field;
    static int turns;
    static char player;
    static bool vsBot;
    static Random rand = new Random();

    static void Main()
    {
        while (true)
        {
            InitGame();

            while (true)
            {
                Console.Clear();
                ShowField();

                if (vsBot && player == 'O')
                {
                    BotMove();
                }
                else
                {
                    Console.Write($"Ход игрока {player}: выбери клетку (1-9) > ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int cell) || cell < 1 || cell > 9)
                    {
                        Console.WriteLine("Не тупи, брат, введи число от 1 до 9!");
                        Console.ReadKey();
                        continue;
                    }

                    int row = (cell - 1) / 3;
                    int col = (cell - 1) % 3;

                    if (field[row, col] == 'X' || field[row, col] == 'O')
                    {
                        Console.WriteLine("Клетка занята, братюня!");
                        Console.ReadKey();
                        continue;
                    }

                    field[row, col] = player;
                }

                turns++;

                if (CheckWin())
                {
                    Console.Clear();
                    ShowField();
                    Console.WriteLine($"Игрок {player} победил! Уважуха!");
                    break;
                }
                else if (turns == 9)
                {
                    Console.Clear();
                    ShowField();
                    Console.WriteLine("Ничья, брат! Никто не проиграл, никто не выиграл.");
                    break;
                }

                player = (player == 'X') ? 'O' : 'X';
            }

            Console.WriteLine("Хочешь реванш, брат? (y/n): ");
            string answer = Console.ReadLine().ToLower();
            if (answer != "y") break;
        }

        Console.WriteLine("Ну всё, бывай, кент. Жми любую кнопку чтоб свалить...");
        Console.ReadKey();
    }

    static void InitGame()
    {
        field = new char[3, 3]
        {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };
        turns = 0;
        player = 'X';

        Console.Clear();
        Console.WriteLine("Выбери режим игры, брат:");
        Console.WriteLine("1 - Игрок против Игрока");
        Console.WriteLine("2 - Игрок против Бота");

        string choice = Console.ReadLine();
        vsBot = choice == "2";
    }

    static void BotMove()
    {
        Console.WriteLine("Бот думает...");
        int row, col;
        do
        {
            int move = rand.Next(1, 10);
            row = (move - 1) / 3;
            col = (move - 1) % 3;
        } while (field[row, col] == 'X' || field[row, col] == 'O');

        field[row, col] = player;
        System.Threading.Thread.Sleep(500);
    }

    static void ShowField()
    {
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                char c = field[i, j];

                if (c == 'X')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (c == 'O')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ResetColor();
                }

                Console.Write($" {c} ");
                Console.ResetColor();

                if (j < 2)
                    Console.Write("|");
            }

            Console.WriteLine();
            if (i < 2)
                Console.WriteLine("---+---+---");
        }
        Console.WriteLine();
    }



    static bool CheckWin()
    {
        for (int i = 0; i < 3; i++)
        {
            if (field[i, 0] == field[i, 1] && field[i, 1] == field[i, 2]) return true;
            if (field[0, i] == field[1, i] && field[1, i] == field[2, i]) return true;
        }

        if (field[0, 0] == field[1, 1] && field[1, 1] == field[2, 2]) return true;
        if (field[0, 2] == field[1, 1] && field[1, 1] == field[2, 0]) return true;

        return false;
    }
}
