﻿namespace CheckersLogic
{
    public struct BoardPosition
    {
        public int Row { get; }
        public int Column { get; }

        internal BoardPosition(char i_Row, char i_Col)
        {
            this.Row = (i_Row - 'A');
            this.Column = (i_Col - 'a');
        }

        internal BoardPosition(int i_Row, int i_Col)
        {
            this.Row = i_Row;
            this.Column = i_Col;
        }
    }
}
