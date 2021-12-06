using System;
using Boards;
using Chess;

namespace Chess_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChessMatch match = new ChessMatch();

                while (!match.Finished)
                {
                    Console.Clear();
                    Screen.PrintBoard(match.Board);

                    Console.Write("Origin: ");
                    Position origin = Screen.ReadChessPosition().ToPosition();

                    Console.Write("Destination: ");
                    Position destination = Screen.ReadChessPosition().ToPosition();

                    match.ExecuteMoviment(origin, destination);
                }

                Console.WriteLine();
                
            }
            catch (BoardException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
