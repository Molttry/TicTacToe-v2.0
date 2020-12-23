using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int turns = 9;
            char player = 'X';
            char[,] board = new char[3, 3];
            int row, col;
            char choice = ' ';
        Start:
            BoardEx(board);
            Console.WriteLine("__-Welcome to TIC-TAC-TOE-__");
            Console.WriteLine("Press the button to use menu!");
            Console.WriteLine("Start the game! (s)");
            Console.WriteLine("About the author (a)");
            Console.WriteLine("Exit the game (e)");
            choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case 's':
                    while (true)
                    {
                        Console.Clear();
                        Print(board);
                        Console.WriteLine("Player '" + player + "' is playing!");
                        do
                        {
                            Console.WriteLine("Select the row");
                            row = Convert.ToInt32(Console.ReadLine()) - 1;
                            Console.WriteLine("Select column");
                            col = Convert.ToInt32(Console.ReadLine()) - 1;
                            Console.WriteLine("Try one more time!");
                        } while (board[row, col] == 'X' || board[row, col] == 'O');
                        board[row, col] = player;
                        turns--;
                        if (turns == 0)
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("We have a draw here 'X' and 'O' pretty good at this game");
                            break;
                        }
                        if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Very cool! Player '" + player + "' won!");
                            break;
                        }
                        else if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Very cool! Player '" + player + "' won!");
                            break;
                        }
                        else if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Very cool! Player '" + player + "' won!");
                            break;
                        }
                        else if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Very cool! Player '" + player + "' won!");
                            break;
                        }
                        else if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Very cool! Player '" + player + "' won!");
                            break;
                        }
                        else if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Very cool! Player '" + player + "' won!");
                            break;
                        }
                        else if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Very cool! Player '" + player + "' won!");
                            break;
                        }
                        else if (player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Very cool! Player '" + player + "' won!");
                            break;
                        }
                        if (player == 'X')
                        {
                            player = 'O';
                        }
                        else
                        {
                            player = 'X';
                        }

                    }
                    Console.WriteLine("To go to menu press the key!");
                    Console.ReadKey();
                    Console.Clear();
                    goto Start;
                case 'a':
                    Console.WriteLine("Author of this game is Anton Berdiuhin. Who made this game not knowing anything about c# ://");
                    Console.WriteLine("Press any botton");
                    Console.ReadKey();
                    Console.Clear();
                    goto Start;
                case 'e':
                    Console.WriteLine("Do you really want to exit? (y/n)");
                    choice = Convert.ToChar(Console.ReadLine());
                    switch (choice)
                    {
                        case 'y':
                            Console.WriteLine("Thanks for attention");
                            break;
                        case 'n':
                            Console.Clear();
                            goto Start;
                    }
                    break;

            }




        }
        static void BoardEx(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                    board[row, col] = ' ';
            }
        }
        static void Print(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {

                Console.Write(row + 1 + "| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("   1   2   3   ");
        }
    }
}
