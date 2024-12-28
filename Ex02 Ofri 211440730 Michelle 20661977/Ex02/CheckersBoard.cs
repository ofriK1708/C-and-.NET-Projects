
using System;
using System.Collections.Generic;

namespace Ex02
{
    internal class CheckersBoard
    {
        internal eCheckersBoardSize Size { get; private set; }
        internal eCheckersBoardPiece[,] Board { get; private set; }

        private List<BoardPosition> m_Player1PiecePositions = new List<BoardPosition>();

        private List<BoardPosition> m_Player2PiecePositions = new List<BoardPosition>();

        internal CheckersBoard(eCheckersBoardSize i_size)
        {
            Size = i_size;
            Board = new eCheckersBoardPiece[(int)Size, (int)Size];
            resetBoard((int)Size);
        }
        
        internal void resetBoard(int i_BoardSize)
        {
            for (uint i = 0; i < i_BoardSize; i++)
            {
                for (uint j = 0; j < i_BoardSize; j++)
                {
                    if ((i + j) % 2 == 1) 
                    {
                        if (j < (i_BoardSize - 2) / 2)
                        {
                            Board[i, j] = eCheckersBoardPiece.OPiece;
                            m_Player2PiecePositions.Add(new BoardPosition(i, j));
                        }
                        else if (j > i_BoardSize / 2)
                        {
                            Board[i, j] = eCheckersBoardPiece.XPiece;
                            m_Player1PiecePositions.Add(new BoardPosition(i,j));
                        }
                        else
                        {
                            Board[i, j] = eCheckersBoardPiece.EmptyPlace;
                        }
                    }
                    else
                    {
                        Board[i, j] = eCheckersBoardPiece.EmptyPlace;
                    }
                }
            }
        }

        internal bool isCellEmpty(int i_Row, int i_Col)
        {
            return Board[i_Row, i_Col] == eCheckersBoardPiece.EmptyPlace;
        }

        internal bool isCellInRange(int i_Row,int i_Col)
        {
            return ((i_Row >= 0) && (i_Row < (int)Size)) && ((i_Col >= 0) && (i_Col < (int)Size));
        }


        internal List<CheckersBoardMove> getAllValidMoves(Player i_ActivePlayer)
        {
            List<CheckersBoardMove> validBoardPositions = new List<CheckersBoardMove>();


            return validBoardPositions;
        }

        internal bool playMove(CheckersBoardMove validMove)
        {
            BoardPosition from = validMove.From;
            BoardPosition to = validMove.To;

            eCheckersBoardPiece boardPiece = Board[from.Row, from.Column];
            Board[to.Row, to.Column] = boardPiece;
            Board[from.Row, from.Column] = eCheckersBoardPiece.EmptyPlace;

            switch (boardPiece)
            {
                case eCheckersBoardPiece.XPiece:
                    m_XPositions.Remove(from);
                    m_XPositions.Add(to);
                    break;
                case eCheckersBoardPiece.OPiece:
                    m_OPositions.Remove(from);
                    m_OPositions.Add(to);
                    break;
            }

            return false;
        }

        internal List<CheckersBoardMove> getValidMovesToEatFromPostions(BoardPosition position)
        {
            //implement
           return new List<CheckersBoardMove>();
        }
    }
}
