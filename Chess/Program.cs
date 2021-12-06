using System;
using Boards;
using Chess;
using Chess;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            board.PutPiece(new King(board, Color.Black), new Position(1, 1));
            board.PutPiece(new Tower(board, Color.White), new Position(5, 4));

            Screen.PrintBoard(board);

        }
    }
}
