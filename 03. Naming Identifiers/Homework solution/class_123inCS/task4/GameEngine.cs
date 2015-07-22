using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class GameEngine
    {
        private const int MAX_POINTS = 35;

        public static void GameInit()
        {
            string command = string.Empty;
            char[,] gameBoard = CreateGameBoard();
            char[,] bombs = GenerateBombPositions();
            int counter = 0;
            bool isBomb = false;
            List<UserPoints> champions = new List<UserPoints>(6);
            int row = 0;
            int column = 0;
            bool isGameBegining = true;
            bool isMaxPointsReached = false;

            do
            {
                if (isGameBegining)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    InitializeGameBoard(gameBoard);
                    isGameBegining = false;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out column) && row <= gameBoard.GetLength(0) && column <= gameBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ResultRatings(champions);
                        break;
                    case "restart":
                        gameBoard = CreateGameBoard();
                        bombs = GenerateBombPositions();
                        InitializeGameBoard(gameBoard);
                        isBomb = false;
                        isGameBegining = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                PlayerTurn(gameBoard, bombs, row, column);
                                counter++;
                            }

                            if (MAX_POINTS == counter)
                            {
                                isMaxPointsReached = true;
                            }
                            else
                            {
                                InitializeGameBoard(gameBoard);
                            }
                        }
                        else
                        {
                            isBomb = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (isBomb)
                {
                    InitializeGameBoard(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. Daj si niknejm: ", counter);
                    string userName = Console.ReadLine();
                    UserPoints userPoints = new UserPoints(userName, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(userPoints);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < userPoints.Points)
                            {
                                champions.Insert(i, userPoints);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((UserPoints r1, UserPoints r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((UserPoints r1, UserPoints r2) => r2.Points.CompareTo(r1.Points));
                    ResultRatings(champions);

                    gameBoard = CreateGameBoard();
                    bombs = GenerateBombPositions();
                    counter = 0;
                    isBomb = false;
                    isGameBegining = true;
                }

                if (isMaxPointsReached)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    InitializeGameBoard(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string userName = Console.ReadLine();
                    UserPoints points = new UserPoints(userName, counter);
                    champions.Add(points);
                    ResultRatings(champions);
                    gameBoard = CreateGameBoard();
                    bombs = GenerateBombPositions();
                    counter = 0;
                    isMaxPointsReached = false;
                    isGameBegining = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void ResultRatings(List<UserPoints> points)
        {
            Console.WriteLine("\nTo4KI:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void PlayerTurn(char[,] gameBoard, char[,] bombs, int row, int column)
        {
            char bombsCount = CountPoints(bombs, row, column);
            bombs[row, column] = bombsCount;
            gameBoard[row, column] = bombsCount;
        }

        private static void InitializeGameBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameBoard()
        {
            int rows = 5;
            int columns = 10;
            char[,] board = new char[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] GenerateBombPositions()
        {
            int rows = 5;
            int columns = 10;
            char[,] gameBoard = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    gameBoard[i, j] = '-';
                }
            }

            List<int> randomNumbers = new List<int>();
            while (randomNumbers.Count < 15)
            {
                Random random = new Random();
                int nextRandom = random.Next(50);
                if (!randomNumbers.Contains(nextRandom))
                {
                    randomNumbers.Add(nextRandom);
                }
            }

            foreach (int number in randomNumbers)
            {
                int column = number / columns;
                int row = number % columns;
                if (row == 0 && number != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                gameBoard[column, row - 1] = '*';
            }

            return gameBoard;
        }

        private static void CalculatePoints(char[,] board)
        {
            int columns = board.GetLength(0);
            int rows = board.GetLength(1);

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char points = CountPoints(board, i, j);
                        board[i, j] = points;
                    }
                }
            }
        }

        private static char CountPoints(char[,] board, int row, int column)
        {
            int result = 0;
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, column] == '*')
                {
                    result++;
                }
            }

            if (row + 1 < rows)
            {
                if (board[row + 1, column] == '*')
                {
                    result++;
                }
            }

            if (column - 1 >= 0)
            {
                if (board[row, column - 1] == '*')
                {
                    result++;
                }
            }

            if (column + 1 < columns)
            {
                if (board[row, column + 1] == '*')
                {
                    result++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (board[row - 1, column - 1] == '*')
                {
                    result++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (board[row - 1, column + 1] == '*')
                {
                    result++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (board[row + 1, column - 1] == '*')
                {
                    result++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (board[row + 1, column + 1] == '*')
                {
                    result++;
                }
            }

            return char.Parse(result.ToString());
        }
    }
}