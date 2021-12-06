using System;
using Boards;
using Chess;
using Xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessPosition position = new ChessPosition('c', 8);
            Console.WriteLine(position);

            Console.WriteLine(position.ToPosition());

        }
    }
}
