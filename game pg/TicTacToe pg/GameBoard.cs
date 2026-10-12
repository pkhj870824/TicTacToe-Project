using System;

namespace TicTacToe_pg
{
    internal class GameBoard
    {
        private int[,] Location = new int[3, 3];
        private char[,] Board = new char[3, 3];

        public void PrintLocation()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Location[i, j] = i * 3 + j + 1;
                    Console.Write(Location[i, j]);
                    if (j < 2)
                    { 
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine();
                if (i < 2)
                    Console.WriteLine("---------");
            }
        }
        public void StartBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Board[i, j] = '.';
                }
            }
        }
        public void PrintBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Board[i, j]);
                    if (j < 2)
                    { 
                    Console.Write(" | ");
                    }
                }
                Console.WriteLine();
                if (i < 2)
                { 
                    Console.WriteLine("---------");
                }
            }
        }
        public bool SelectLocation(int select, char mark)
        {
            int row = (select - 1) / 3;
            int col = (select - 1) % 3;

            if (Board[row, col] != '.')
            {
                return false;
            }

            Board[row, col] = mark;
            return true;
        }
        public bool CheckWin(char mark)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Board[0, i] == mark && Board[1, i] == mark && Board[2, i] == mark)
                {
                    return true;
                }
                else if (Board[i, 0] == mark && Board[i, 1] == mark && Board[i, 2] == mark)
                {
                    return true;
                }
            }

            if (Board[0, 0] == mark && Board[1, 1] == mark && Board[2, 2] == mark)
            {
                return true;
            }
            else if (Board[0, 2] == mark && Board[1, 1] == mark && Board[2, 0] == mark)
            {
                return true;
            }

            return false;
        }
    }
}
