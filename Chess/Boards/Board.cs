using System;

namespace Boards

{
    public class Board
    {
        public int Row { get; set; }
        public int Column { get; set; }
        private Piece[,] Pieces;

        public Board(int row, int column)
        {
            Row = row;
            Column = column;
            Pieces = new Piece[row, column];
        }

        public Piece Piece(int row, int column)
        {
            return Pieces[row, column];
        }

        public Piece Piece(Position position)
        {
            return Pieces[position.Row, position.Column];
        }

        public bool ExistPiece(Position position)
        {
            ValidatePosition(position);
            return Piece(position) != null;
        }

        public void PutPiece(Piece piece, Position position)
        {
            if (ExistPiece(position))
            {
                throw new BoardException("There is a piece in this position");
            }

            Pieces[position.Row, position.Column] = piece;
            piece.Position = position;
        }

        public Piece RemovePiece(Position position)
        {
            if (Piece(position) == null)
            {
                return null;
            }
            Piece currentPiece = Piece(position);
            currentPiece.Position = null;
            Pieces[position.Row, position.Column] = null;
            return currentPiece;
        }

        public bool ValidPosition(Position position)
        {
            if (position.Row < 0 || position.Row >= Row || position.Column < 0 || position.Column >= Column)
            {
                return false;
            }

            return true;
        }

        public void ValidatePosition(Position position)
        {
            if (!ValidPosition(position))
            {
                throw new BoardException("Invalid Position!");
            }
        }
    }
}
