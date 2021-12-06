﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boards
{
    public class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int AmountOfMoviments { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Position position, Color color, int amountOfMoviments)
        {
            Position = position;
            Color = color;
            AmountOfMoviments = amountOfMoviments;
        }
    }
}
