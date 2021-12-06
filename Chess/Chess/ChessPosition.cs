﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boards;

namespace Chess
{
    public class ChessPosition
    {
        public int Row { get; set; }
        public char Column { get; set; }

        public ChessPosition(char column, int row)
        {
            Row = row;
            Column = column;
        }

        public Position ToPosition()
        {
            return new Position(8 - Row, Column - 'a');
        }

        public override string ToString()
        {
            return "" + Column + Row;
        }
    }
}
