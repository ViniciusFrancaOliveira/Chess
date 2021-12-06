using System;
using Boards;
using Chess;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board1 = new Board(8, 8);

            board1.PutPiece(new Tower(board1, Color.Preta), new Position(0, 0));
            board1.PutPiece(new Tower(board1, Color.Preta), new Position(5, 3));
            board1.PutPiece(new King(board1, Color.Preta), new Position(7, 1));

            Screen.PrintBoard(board1);
        }
    }
}
