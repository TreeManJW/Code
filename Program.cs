using System;

namespace Code
{

    public class Board
    {
        private char[,] _board;
        private int _boardSize;

        public Board() : this(3) { }
        public Board(int size)
        {
            _boardSize = size;
            _board = new char[_boardSize, _boardSize];
        }

        public void PlaceX(int x, int y)
        {
            if (x > _boardSize - 1 || y > _boardSize - 1)
            {
                return;
            }

            _board[x, y] = 'x';
        }

        public void PlaceO(int x, int y)
        {
            if (x > _boardSize - 1 || y > _boardSize - 1)
            {
                return;
            }
            _board[x, y] = 'o';
        }

        public void Print()
        {
            Console.Write(" ");
            for (int i = 0; i < _boardSize * 4 - 1; i++)
            {
                Console.Write("-");
            }
            Console.Write("\n");
            for (int y = 0; y < _boardSize; y++)
            {
                Console.Write("|");
                for (int x = 0; x < _boardSize; x++)
                {
                    var token = _board[x, y] == '\0' ? ' ' : _board[x, y];
                    Console.Write($" {token} |");
                }
                Console.Write("\n");
                Console.Write(" ");
                for (int i = 0; i < _boardSize * 4 - 1; i++)
                {
                    Console.Write("-");
                }
                Console.Write("\n");
            }
        }

    class Program
    {
        // public static string cordinates = "-";
        public static void Main()
        {
            var board = new Board(3);
            board.PlaceX(0, 0);
            board.PlaceO(1, 4);
            board.PlaceX(4, 0);
            board.PlaceO(0, 1);
            board.PlaceX(1, 1);
            board.PlaceO(2, 1);
            board.PlaceX(0, 2);
            board.PlaceO(1, 2);
            board.PlaceX(2, 2);
            board.Print();

        }





        // public static void ifStatements()
        // {
        //     if (cordinates == "a1")
        //     {
        //         a1 = 'x';
        //     }
        //     else if (cordinates == "a2")
        //     {
        //         a2 = 'x';
        //     }
        //     else if (cordinates == "a3")
        //     {
        //         a3 = 'x';
        //     }
        //     else if (cordinates == "b1")
        //     {
        //         b1 = 'x';
        //     }
        //     else if (cordinates == "b2")
        //     {
        //         b2 = 'x';
        //     }
        //     else if (cordinates == "b3")
        //     {
        //         b3 = 'x';
        //     }
        //     else if (cordinates == "c1")
        //     {
        //         c1 = 'x';
        //     }
        //     else if (cordinates == "c2")
        //     {
        //         c2 = 'x';
        //     }
        //     else if (cordinates == "c3")
        //     {
        //         c3 = 'x';
        //     }
        // }
    }

}
