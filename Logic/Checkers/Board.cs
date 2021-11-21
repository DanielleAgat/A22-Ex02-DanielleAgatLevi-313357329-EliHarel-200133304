namespace CheckersLogic
{
    public class Board
    {
        private readonly Tile[,] r_TilesMatrix;

        public enum eBoardSize
        {
            Small = 6,
            Normal = 8,
            Big = 10
        }

        public Tile[,] Tiles
        {
            get
            {
                return r_TilesMatrix;
            }
        }

        public struct Tile
        {
            private bool m_IsOccupied;
            private Piece m_Piece;
            private BoardPoint? m_Location;

            public Piece Piece
            {
                get
                {
                    return m_Piece;
                }

                set
                {
                    m_Piece = value;
                    m_IsOccupied = m_Piece != null;
                }
            }

            public bool IsOccupied
            {
                get
                {
                    return m_IsOccupied;
                }
            }

            public BoardPoint? Location
            {
                get
                {
                    return m_Location;
                }

                set
                {
                    m_Location = value;
                }
            }
        }

        public eBoardSize Size
        {
            get
            {
                return (eBoardSize)r_TilesMatrix.GetLength(0);
            }
        }

        public Board(eBoardSize i_Size)
        {
            r_TilesMatrix = new Tile[(ushort)i_Size, (ushort)i_Size];

            for (int row = 0; row < (ushort)i_Size; row++)
            {
                for (int col = 0; col < (ushort)i_Size; col++)
                {
                    r_TilesMatrix[row, col].Location = new BoardPoint(col, row);
                }
            }
        }

        public void SetStartingBoard(Piece[] i_BotPlayerPieces, Piece[] i_TopPlayerPieces)
        {
            int rowsOccupiedByEachPlayer = (r_TilesMatrix.GetLength(0) - 2) / 2;
            int row = 0;

            setPiecesFromRow(ref row, rowsOccupiedByEachPlayer, i_TopPlayerPieces);
            for (int k = 0; k < 2; k++, row++)
            {
                for (int col = 0; col < r_TilesMatrix.GetLength(0); col++)
                {
                    r_TilesMatrix[row, col].Piece = null;
                }
            }

            setPiecesFromRow(ref row, rowsOccupiedByEachPlayer, i_BotPlayerPieces);
        }

        private void setPiecesFromRow(ref int io_Row, int i_RowsOccupiedByEachPlayer, Piece[] io_Pieces)
        {
            int ind = 0;

            for (int i = 0; i < i_RowsOccupiedByEachPlayer; i++, io_Row++)
            {
                for (int col = 0; col < r_TilesMatrix.GetLength(0); col++)
                {
                    if (PlayableTile(io_Row, col))
                    {
                        r_TilesMatrix[io_Row, col].Piece = io_Pieces[ind];
                        io_Pieces[ind].Location = r_TilesMatrix[io_Row, col].Location;
                        io_Pieces[ind].ResetOnBoard();
                        ind++;
                    }
                    else
                    {
                        r_TilesMatrix[io_Row, col].Piece = null;
                    }
                }
            }
        }

        /// <summary>
        /// Returns TRUE if tile given by parameters is playable.
        /// </summary>
        public bool PlayableTile(int i_Row, int i_Col)
        {
            bool isPlayable;

            if (i_Row % 2 == 0)
            {
                isPlayable = i_Col % 2 == 1;
            }
            else
            {
                isPlayable = i_Col % 2 == 0;
            }

            return isPlayable;
        }

        public Piece GetPiece(BoardPoint i_Point)
        {
            return GetPiece(i_Point.Col, i_Point.Row);
        }

        public Piece GetPiece(int i_Col, int i_Row)
        {
            Piece piece = null;

            if (IsInBoundary(i_Col, i_Row))
            {
                piece = r_TilesMatrix[i_Row, i_Col].Piece;
            }

            return piece;
        }

        public bool IsInBoundary(BoardPoint i_Point)
        {
            return IsInBoundary(i_Point.Col, i_Point.Row);
        }

        public bool IsInBoundary(int i_Col, int i_Row)
        {
            bool colInBoundary = i_Col >= 0 && i_Col < r_TilesMatrix.GetLength(0);
            bool rowInBoundary = i_Row >= 0 && i_Row < r_TilesMatrix.GetLength(0);

            return colInBoundary && rowInBoundary;
        }

        public bool IsOccupiedTile(BoardPoint i_Location)
        {
            return IsOccupiedTile(i_Location.Col, i_Location.Row);
        }

        public bool IsOccupiedTile(int i_Col, int i_Row)
        {
            bool occupiedTile = false;

            if (IsInBoundary(i_Col, i_Row))
            {
                occupiedTile = r_TilesMatrix[i_Row, i_Col].IsOccupied;
            }

            return occupiedTile;
        }

        public bool IsEndRow(BoardPoint i_Point)
        {
            return i_Point.Row == 0 || i_Point.Row == r_TilesMatrix.GetLength(0) - 1;
        }

        /// <summary>
        /// Method assumes parameter is valid. Checks occur outside.
        /// </summary>
        public void UpdateBoard(MoveParameters i_Move)
        {
            UpdateBoard(i_Move.FromPoint, i_Move.ToPoint);
        }

        /// <summary>
        /// Method assumes parameter is valid. Checks occur outside.
        /// </summary>
        public void UpdateBoard(BoardPoint i_FromPoint, BoardPoint i_ToPoint)
        {
            Piece movingPiece = r_TilesMatrix[i_FromPoint.Row, i_FromPoint.Col].Piece;

            if (movingPiece != null)
            {
                r_TilesMatrix[i_ToPoint.Row, i_ToPoint.Col].Piece = movingPiece;
                movingPiece.Location = i_ToPoint;
                r_TilesMatrix[i_FromPoint.Row, i_FromPoint.Col].Piece = null;
                if (MoveParameters.AreCaptureMoveParameters(i_FromPoint, i_ToPoint))
                {
                    BoardPoint inbetweenPoint = GetPointBetween(i_FromPoint, i_ToPoint);
                    Piece capturedPiece = r_TilesMatrix[inbetweenPoint.Row, inbetweenPoint.Col].Piece;

                    if (capturedPiece != null)
                    {
                        capturedPiece.Captured = true;
                        capturedPiece.Location = null;
                    }

                    r_TilesMatrix[inbetweenPoint.Row, inbetweenPoint.Col].Piece = null;
                }
            }
        }

        public BoardPoint GetPointBetween(BoardPoint i_FromTile, BoardPoint i_ToTile)
        {
            int col;
            int row;

            if (i_FromTile.Col < i_ToTile.Col)
            {
                col = i_FromTile.Col + 1;
            }
            else
            {
                col = i_FromTile.Col - 1;
            }

            if (i_FromTile.Row < i_ToTile.Row)
            {
                row = i_FromTile.Row + 1;
            }
            else
            {
                row = i_FromTile.Row - 1;
            }

            return new BoardPoint(col, row);
        }

        public bool SetPieceAtLocation(Piece io_Piece, BoardPoint i_NewLocation)
        {
            bool successfulAssignment = false;

            if (IsInBoundary(i_NewLocation))
            {
                if (IsOccupiedTile(i_NewLocation) == false)
                {
                    if (io_Piece != null)
                    {
                        if (io_Piece.Location.HasValue)
                        {
                            BoardPoint oldLocation = io_Piece.Location.Value;
                            r_TilesMatrix[oldLocation.Row, oldLocation.Col].Piece = null;
                        }

                        io_Piece.Location = i_NewLocation;
                        r_TilesMatrix[i_NewLocation.Row, i_NewLocation.Col].Piece = io_Piece;
                        successfulAssignment = true;
                    }
                }
            }

            return successfulAssignment;
        }

        public BoardPoint? GetRelativeLocation(BoardPoint i_SourcePoint, eDirection i_VerticalDirection, eDirection i_HorizontalDirection)
        {
            BoardPoint? relativeLocation;
            int toRow = i_SourcePoint.Row + (int)i_VerticalDirection;
            int toCol = i_SourcePoint.Col + (int)i_HorizontalDirection;
            BoardPoint toPoint = new BoardPoint(toCol, toRow);

            if (IsInBoundary(toPoint))
            {
                relativeLocation = toPoint;
            }
            else
            {
                relativeLocation = null;
            }

            return relativeLocation;
        }
    }
}