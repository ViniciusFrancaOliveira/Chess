using System;

namespace Boards
{
    public class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int AmountOfMoviments { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Board board, Color color)
        {
            Position = null;
            Color = color;
            AmountOfMoviments = 0;
            Board = board;
        }

        public void IncrementAmountOfMovimentos()
        {
            AmountOfMoviments++;
        }
    }
}
