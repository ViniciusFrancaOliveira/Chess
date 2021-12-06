using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boards;
using Chess;

namespace Chess_Program
{
    public class Screen
    {
        public static void PrintBoard(Board board)
        {
            for (int i = 0; i < board.Row; i++)
            {
                Console.Write(board.Row - i + " ");
                for (int j = 0; j < board.Column; j++)
                {
                    if (board.Piece(i, j) == null)
                    { 
                        Console.Write("- ");
                    }
                    else 
                    {
                        PrintPiece(board.Piece(i, j));
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static ChessPosition ReadChessPosition()
        {
            string stringPosition = Console.ReadLine();
            char column = stringPosition[0];
            int row = int.Parse(stringPosition[1] + "");

            return new ChessPosition(column, row);
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece.Color == Color.White)
            {
                Console.Write(piece);
            }
            else
            {
                ConsoleColor colorConsole = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(piece);
                Console.ForegroundColor = colorConsole;
            }
        }
    }
}
