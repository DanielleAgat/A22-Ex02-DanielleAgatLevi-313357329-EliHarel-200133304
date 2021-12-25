using System;
using System.Collections.Generic;
using Logic.BoardGameBuilder;

namespace CheckersLogic
{
    public class GameEngine
    {
        private readonly AI r_Ai;
        private readonly Player r_BottomPlayer;
        private readonly Player r_TopPlayer;
        private readonly Board r_Board;
        private readonly eGameMode r_GameMode;
        private uint m_Turn;
        private eGameState m_GameState;
        private Player m_PlayerPerformingCapture;
        private Player m_Winner;
        private Player m_Loser;

        public event Action AdvancedTurn;

        public event Action GameStateChanged;

        public event Action PlayerScoreChanged;

        public enum eGameState
        {
            Ongoing,
            Victory,
            Tie,
            Forfeit
        }

        public enum eNumberOfPieces
        {
            SixPieces = 6,
            TwelvePieces = 12,
            TwentyPieces = 20
        }

        public enum eGameMode
        {
            SinglePlayer = 1,
            MultiPlayer = 2
        }

        public enum eTurn
        {
            TopPlayerTurn,
            BottomPlayerTurn
        }

        public enum eSide
        {
            Bot,
            Top
        }

        // TODO - delete after builder pattern is implemented and working
        //public GameEngine(
        //    string i_Player1Name,
        //    string i_Player2Name,
        //    eGameMode i_GameMode,
        //    Board.eBoardSize i_BoardSize)
        //{
        //    const bool v_Human = true;
        //    ushort numOfPieces = GetNumOfPiecesByBoardSize(i_BoardSize);

        //    r_Board = new Board(i_BoardSize);
        //    m_Winner = null;
        //    m_Loser = null;
        //    m_Turn = 1;
        //    GameState = eGameState.Ongoing;
        //    m_PlayerPerformingCapture = null;
        //    r_BottomPlayer = new Player(i_Player1Name, eSide.Bot, numOfPieces, v_Human);
        //    r_GameMode = i_GameMode;
        //    r_Ai = new AI(this);
        //    if (i_GameMode == eGameMode.SinglePlayer)
        //    {
        //        r_TopPlayer = new Player(i_Player2Name, eSide.Top, numOfPieces, !v_Human);
        //    }
        //    else
        //    {
        //        r_TopPlayer = new Player(i_Player2Name, eSide.Top, numOfPieces, v_Human);
        //    }
        //}

        internal GameEngine(IBoardGameBuilder i_BoardGameBuilder)
        {
            // r_Board = new Board(i_BoardSize);
            r_Board = i_BoardGameBuilder.GetBoard();



            m_Winner = null;
            m_Loser = null;
            m_Turn = 1;
            GameState = eGameState.Ongoing;
            m_PlayerPerformingCapture = null;

            // r_BottomPlayer = new Player(i_Player1Name, eSide.Bot, numOfPieces, v_Human);
            r_BottomPlayer = i_BoardGameBuilder.GetPlayerOne();

            //r_GameMode = i_GameMode;
            r_GameMode = i_BoardGameBuilder.GetGameMode();

            r_Ai = new AI(this);



            //if (i_GameMode == eGameMode.SinglePlayer)
            //{
            //    r_TopPlayer = new Player(i_Player2Name, eSide.Top, numOfPieces, !v_Human);
            //}
            //else
            //{
            //    r_TopPlayer = new Player(i_Player2Name, eSide.Top, numOfPieces, v_Human);
            //}

            r_TopPlayer = i_BoardGameBuilder.GetPlayerTwo();
        }

        public eGameState GameState
        {
            get
            {
                return m_GameState;
            }

            set
            {
                m_GameState = value;
                OnGameStateChanged();
            }
        }

        public eTurn Turn
        {
            get
            {
                eTurn turn = m_Turn % 2 == 1 ? eTurn.BottomPlayerTurn : eTurn.TopPlayerTurn;

                return turn;
            }
        }

        public Player Winner
        {
            get
            {
                return m_Winner;
            }

            set
            {
                m_Winner = value;
            }
        }

        public Player Loser
        {
            get
            {
                return m_Loser;
            }

            set
            {
                m_Loser = value;
            }
        }

        public Board Board
        {
            get
            {
                return r_Board;
            }
        }

        public Player BottomPlayer
        {
            get
            {
                return r_BottomPlayer;
            }
        }

        public Player TopPlayer
        {
            get
            {
                return r_TopPlayer;
            }
        }

        public AI AI
        {
            get
            {
                return r_Ai;
            }
        }

        public eGameMode GameMode
        {
            get
            {
                return r_GameMode;
            }
        }

        /// <summary>
        /// Returns true for a valid move.
        /// </summary>
        public bool TryMove(MoveParameters i_Move)
        {
            bool validMove = isValidMove(CurrentTurnPlayer(), i_Move);

            if (validMove)
            {
                performMove(CurrentTurnPlayer(), i_Move);
                endTurn();
                if (ComputerTurn() && GameState == eGameState.Ongoing)
                {
                    performComputerMove(CurrentTurnPlayer());
                }
            }

            return validMove;
        }

        private void performComputerMove(Player io_Player)
        {
            LinkedList<MoveParameters> bestTurn = r_Ai.GetBestTurn(io_Player);

            foreach (MoveParameters move in bestTurn)
            {
                performMove(io_Player, move);
            }

            io_Player.LastTurn = bestTurn;
            endTurn();
        }

        private bool isValidMove(Player i_Player, MoveParameters i_Move)
        {
            bool validMove;
            Piece chosenPiece = r_Board.GetPiece(i_Move.FromPoint);
            bool fromTileInBoundary = r_Board.IsInBoundary(i_Move.FromPoint);
            bool playerPiece = doesPieceInLocationBelongToPlayer(i_Player, i_Move.FromPoint);
            bool toTileInBoundary = r_Board.IsInBoundary(i_Move.ToPoint);
            bool isToTileOccupied = r_Board.IsOccupiedTile(i_Move.ToPoint);
            bool validDirection = isValidMoveParameters(i_Player, i_Move);

            if (MoveParameters.AreCaptureMoveParameters(i_Move.FromPoint, i_Move.ToPoint))
            {
                eDirection verticalDirection = i_Move.FromPoint.Row < i_Move.ToPoint.Row ? eDirection.Down : eDirection.Up;
                eDirection horizontalDirection = i_Move.FromPoint.Col < i_Move.ToPoint.Col ? eDirection.Right : eDirection.Left;

                validMove = CanPieceMoveCaptureDirection(chosenPiece, verticalDirection, horizontalDirection);
                if (i_Player.PerformingOngoingCapture && chosenPiece != null)
                {
                    validMove = chosenPiece.PerformingMultipleCapture && validMove;
                }
            }
            else
            {
                validMove = !i_Player.PerformingOngoingCapture && !canPlayerCapture(i_Player);
            }

            validMove = validMove && fromTileInBoundary && playerPiece && toTileInBoundary && !isToTileOccupied
                        && validDirection;

            return validMove;
        }

        /// <summary>
        /// This method should be called after all checks on a move are done.
        /// </summary>
        private void performMove(Player io_Player, MoveParameters i_Move)
        {
            Piece chosenPiece = r_Board.GetPiece(i_Move.FromPoint);

            r_Board.UpdateBoard(i_Move);
            io_Player.LastMove = i_Move;
            if (isLastRowForPlayer(io_Player, i_Move.ToPoint))
            {
                chosenPiece.Type = Piece.eType.King;
            }

            if (MoveParameters.AreCaptureMoveParameters(i_Move.FromPoint, i_Move.ToPoint))
            {
                if (CanPieceMoveCapture(chosenPiece))
                {
                    io_Player.PerformingOngoingCapture = true;
                    chosenPiece.PerformingMultipleCapture = true;
                    m_PlayerPerformingCapture = io_Player;
                }
                else
                {
                    io_Player.PerformingOngoingCapture = false;
                    chosenPiece.PerformingMultipleCapture = false;
                    m_PlayerPerformingCapture = null;
                }
            }

            chosenPiece.PerformedMove();
        }

        public void Forfeit()
        {
            CurrentTurnPlayer().Forfeited = true;
            endTurn();
        }

        private void endTurn()
        {
            tryAdvanceTurn();
            updateGameState();
        }

        private void tryAdvanceTurn()
        {
            if (m_PlayerPerformingCapture == null || CurrentTurnPlayer().Forfeited)
            {
                m_Turn++;
                OnAdvancedTurn();
            }
        }

        protected virtual void OnAdvancedTurn()
        {
            AdvancedTurn?.Invoke();
        }

        private void updateGameState()
        {
            if (r_TopPlayer.Forfeited || r_BottomPlayer.Forfeited)
            {
                m_Winner = r_TopPlayer.Forfeited ? r_BottomPlayer : r_TopPlayer;
                m_Loser = r_TopPlayer.Forfeited ? r_TopPlayer : r_BottomPlayer;
                GameState = eGameState.Forfeit;
                updateScores();
            }
            else
            {
                checkNonForfeitState();
            }
        }

        private void checkNonForfeitState()
        {
            bool topPlayerEliminated = !r_TopPlayer.AreActivePiecesLeft();
            bool botPlayerEliminated = !r_BottomPlayer.AreActivePiecesLeft();
            bool topPlayerStuck = !CanPlayerMoveGeneral(r_TopPlayer);
            bool botPlayerStuck = !CanPlayerMoveGeneral(r_BottomPlayer);

            if (!topPlayerEliminated && !botPlayerEliminated && !topPlayerStuck && !botPlayerStuck)
            {
                GameState = eGameState.Ongoing;
            }
            else if (topPlayerStuck && botPlayerStuck)
            {
                GameState = eGameState.Tie;
                m_Winner = null;
                m_Loser = null;
            }
            else
            {
                checkVictor(
                    topPlayerEliminated,
                    botPlayerEliminated,
                    topPlayerStuck,
                    botPlayerStuck);
            }
        }

        private void checkVictor(bool i_TopPlayerEliminated, bool i_BotPlayerEliminated, bool i_TopPlayerStuck, bool i_BotPlayerStuck)
        {
            if (i_TopPlayerEliminated || i_BotPlayerEliminated)
            {
                m_Winner = i_TopPlayerEliminated ? r_BottomPlayer : r_TopPlayer;
                m_Loser = i_TopPlayerEliminated ? r_TopPlayer : r_BottomPlayer;
                updateScores();
                GameState = eGameState.Victory;
            }
            else if (i_TopPlayerStuck)
            {
                checkIfStuckPlayerCanBeCaptured(TopPlayer, BottomPlayer);
            }
            else if (i_BotPlayerStuck)
            {
                checkIfStuckPlayerCanBeCaptured(BottomPlayer, TopPlayer);
            }
        }

        private void checkIfStuckPlayerCanBeCaptured(Player i_StuckPlayer, Player i_NextPlayer)
        {
            // If next player can capture, match doesn't end yet.
            // The game advances to the next turn, where the player can capture
            // and finish the game by eliminating the stuck player.
            if (CurrentTurnPlayer().Side == i_StuckPlayer.Side || !CanPlayerMoveCapture(i_NextPlayer))
            {
                m_Winner = i_NextPlayer;
                m_Loser = i_StuckPlayer;
                updateScores();
                GameState = eGameState.Victory;
            }
        }

        private void updateScores()
        {
            if (GameState != eGameState.Tie)
            {
                ushort winnerPieceValue = m_Winner.GetActivePiecesValue();
                ushort loserPieceValue = m_Loser.GetActivePiecesValue();
                int pointDifference = winnerPieceValue - loserPieceValue;

                if (GameState == eGameState.Forfeit)
                {
                    pointDifference = winnerPieceValue;
                }

                m_Winner.MatchScore = pointDifference;
                m_Winner.TotalScore += pointDifference;
                m_Loser.MatchScore = 0;
                OnPlayerScoreChanged();
            }
        }

        public bool CanPlayerMoveGeneral(Player i_Player)
        {
            bool playerCanMove = false;

            foreach (Piece piece in i_Player.Pieces)
            {
                if (CanPieceMoveGeneral(piece))
                {
                    playerCanMove = true;
                    break;
                }
            }

            return playerCanMove;
        }

        public bool CanPlayerMoveCapture(Player i_Player)
        {
            bool playerCanCapture = false;

            foreach (Piece piece in i_Player.Pieces)
            {
                if (CanPieceMoveCapture(piece))
                {
                    playerCanCapture = true;
                    break;
                }
            }

            return playerCanCapture;
        }

        public bool CanPieceMoveGeneral(Piece i_Piece)
        {
            bool regularMove = CanPieceMoveRegular(i_Piece);
            bool captureMove = CanPieceMoveCapture(i_Piece);

            return regularMove || captureMove;
        }

        public bool CanPieceMoveRegular(Piece i_Piece)
        {
            bool regularUpLeft = CanPieceMoveRegularDirection(i_Piece, eDirection.Up, eDirection.Left);
            bool regularUpRight = CanPieceMoveRegularDirection(i_Piece, eDirection.Up, eDirection.Right);
            bool regularDownLeft = CanPieceMoveRegularDirection(i_Piece, eDirection.Down, eDirection.Left);
            bool regularDownRight = CanPieceMoveRegularDirection(i_Piece, eDirection.Down, eDirection.Right);

            return regularUpLeft || regularUpRight || regularDownLeft || regularDownRight;
        }

        public bool CanPieceMoveRegularDirection(Piece i_Piece, eDirection i_VerticalDirection, eDirection i_HorizontalDirection)
        {
            bool validMove = false;

            if (i_Piece?.Location != null)
            {
                int toCol = i_Piece.Location.Value.Col + (int)i_HorizontalDirection;
                int toRow = i_Piece.Location.Value.Row + (int)i_VerticalDirection;
                BoardPoint toLocation = new BoardPoint(toCol, toRow);
                bool validVerticalDirection = isValidVerticalDirectionForPiece(i_Piece, i_VerticalDirection);
                bool inBoundary = r_Board.IsInBoundary(toLocation);
                bool destinationUnoccupied = !r_Board.IsOccupiedTile(toLocation);

                validMove = inBoundary && destinationUnoccupied && validVerticalDirection;
            }

            return validMove;
        }

        public bool CanPieceMoveCapture(Piece i_Piece)
        {
            bool canCapture = false;

            if (i_Piece != null)
            {
                bool captureUpLeft = CanPieceMoveCaptureDirection(i_Piece, eDirection.Up, eDirection.Left);
                bool captureUpRight = CanPieceMoveCaptureDirection(i_Piece, eDirection.Up, eDirection.Right);
                bool captureDownLeft = CanPieceMoveCaptureDirection(i_Piece, eDirection.Down, eDirection.Left);
                bool captureDownRight = CanPieceMoveCaptureDirection(i_Piece, eDirection.Down, eDirection.Right);

                canCapture = captureUpLeft || captureUpRight || captureDownLeft || captureDownRight;
            }

            return canCapture;
        }

        public bool CanPieceMoveCaptureDirection(Piece i_Piece, eDirection i_VerticalDirection, eDirection i_HorizontalDirection)
        {
            bool validCapture = false;

            if (i_Piece?.Location != null && isValidVerticalDirectionForPiece(i_Piece, i_VerticalDirection))
            {
                BoardPoint pieceLocation = (BoardPoint)i_Piece.Location;
                BoardPoint? enemyLocation = Board.GetRelativeLocation(pieceLocation, i_VerticalDirection, i_HorizontalDirection);

                if (enemyLocation.HasValue && r_Board.IsInBoundary(enemyLocation.Value))
                {
                    Piece pieceAtDirection = r_Board.GetPiece(enemyLocation.Value);

                    if (pieceAtDirection != null && pieceAtDirection.Side != i_Piece.Side)
                    {
                        BoardPoint? locationBeyondEnemy = r_Board.GetRelativeLocation(enemyLocation.Value, i_VerticalDirection, i_HorizontalDirection);

                        if (locationBeyondEnemy.HasValue && r_Board.IsInBoundary(locationBeyondEnemy.Value) && !r_Board.IsOccupiedTile(locationBeyondEnemy.Value))
                        {
                            validCapture = true;
                        }
                    }
                }
            }

            return validCapture;
        }

        private bool isValidVerticalDirectionForPiece(Piece i_Piece, eDirection i_VerticalDirection)
        {
            bool validDirection = false;

            if (i_Piece != null)
            {
                if (i_Piece.Type == Piece.eType.King)
                {
                    validDirection = true;
                }
                else
                {
                    if (i_Piece.Side == eSide.Bot)
                    {
                        validDirection = i_VerticalDirection == eDirection.Up;
                    }
                    else
                    {
                        validDirection = i_VerticalDirection == eDirection.Down;
                    }
                }
            }

            return validDirection;
        }

        private bool isLastRowForPlayer(Player i_Player, BoardPoint i_ToTile)
        {
            bool lastRow = false;
            ushort size = (ushort)r_Board.Size;

            if (i_Player.Side == eSide.Top)
            {
                if (i_ToTile.Row == (size - 1))
                {
                    lastRow = true;
                }
            }
            else
            {
                if (i_ToTile.Row == 0)
                {
                    lastRow = true;
                }
            }

            return lastRow;
        }

        private bool isValidMoveParameters(Player i_Player, MoveParameters i_Move)
        {
            bool validMove = false;

            if (r_Board.IsOccupiedTile(i_Move.FromPoint))
            {
                bool upSingle = MoveParameters.IsUpSingleMove(i_Move.FromPoint, i_Move.ToPoint);
                bool upDouble = MoveParameters.IsUpDoubleMove(i_Move.FromPoint, i_Move.ToPoint);
                bool downSingle = MoveParameters.IsDownSingleMove(i_Move.FromPoint, i_Move.ToPoint);
                bool downDouble = MoveParameters.IsDownDoubleMove(i_Move.FromPoint, i_Move.ToPoint);
                bool leftSingle = MoveParameters.IsLeftSingleMove(i_Move.FromPoint, i_Move.ToPoint);
                bool leftDouble = MoveParameters.IsLeftDoubleMove(i_Move.FromPoint, i_Move.ToPoint);
                bool rightSingle = MoveParameters.IsRightSingleMove(i_Move.FromPoint, i_Move.ToPoint);
                bool rightDouble = MoveParameters.IsRightDoubleMove(i_Move.FromPoint, i_Move.ToPoint);
                bool validUp = (upSingle && (leftSingle || rightSingle)) || (upDouble && (leftDouble || rightDouble));
                bool validDown = (downSingle && (leftSingle || rightSingle)) || (downDouble && (leftDouble || rightDouble));

                if (r_Board.GetPiece(i_Move.FromPoint).Type == Piece.eType.King)
                {
                    validMove = validUp || validDown;
                }
                else
                {
                    validMove = i_Player.Side == eSide.Bot ? validUp : validDown;
                }
            }

            return validMove;
        }

        private bool doesPieceInLocationBelongToPlayer(Player i_Player, BoardPoint i_FromTile)
        {
            bool belongsToPlayer = false;
            Piece piece = r_Board.GetPiece(i_FromTile);

            if (piece != null)
            {
                belongsToPlayer = piece.Side == i_Player.Side;
            }

            return belongsToPlayer;
        }

        private bool canPlayerCapture(Player i_Player)
        {
            bool canCapture = false;

            foreach (Piece piece in i_Player.Pieces)
            {
                if (CanPieceMoveCapture(piece))
                {
                    canCapture = true;
                    break;
                }
            }

            return canCapture;
        }

        public void ResetGame()
        {
            r_BottomPlayer.EndMatch();
            r_TopPlayer.EndMatch();
            r_Board.SetStartingBoard(r_BottomPlayer.Pieces, r_TopPlayer.Pieces);
            GameState = eGameState.Ongoing;
            m_PlayerPerformingCapture = null;
            m_Winner = null;
            m_Loser = null;
            if (ComputerTurn())
            {
                performComputerMove(CurrentTurnPlayer());
            }
        }

        public bool HumanTurn()
        {
            bool human = Turn == eTurn.TopPlayerTurn ? TopPlayer.IsHuman : BottomPlayer.IsHuman;

            return human;
        }

        public bool ComputerTurn()
        {
            return !HumanTurn();
        }

        public bool IsOngoingCapture()
        {
            return m_PlayerPerformingCapture != null;
        }

        public Player CurrentTurnPlayer()
        {
            Player player = Turn == eTurn.TopPlayerTurn ? r_TopPlayer : r_BottomPlayer;

            return player;
        }

        public static ushort GetNumOfPiecesByBoardSize(Board.eBoardSize i_BoardSize)
        {
            ushort numOfPieces = 0;

            switch (i_BoardSize)
            {
                case Board.eBoardSize.Small:
                    numOfPieces = (ushort)eNumberOfPieces.SixPieces;
                    break;
                case Board.eBoardSize.Normal:
                    numOfPieces = (ushort)eNumberOfPieces.TwelvePieces;
                    break;
                case Board.eBoardSize.Big:
                    numOfPieces = (ushort)eNumberOfPieces.TwentyPieces;
                    break;
            }

            return numOfPieces;
        }

        protected virtual void OnGameStateChanged()
        {
            GameStateChanged?.Invoke();
        }

        protected virtual void OnPlayerScoreChanged()
        {
            PlayerScoreChanged?.Invoke();
        }

        /// <summary>
        ///  Returns linked list of all the pieces that can currently move,
        /// of the player sent as the parameter.
        /// </summary>
        public LinkedList<Piece> PlayablePieces(Player i_Player)
        {
            LinkedList<Piece> piecesThatCanCapture = null;
            Piece[] playerPieces = i_Player.Pieces;

            foreach (Piece piece in playerPieces)
            {
                if (PieceCanValidMoveByRules(piece))
                {
                    if (piecesThatCanCapture == null)
                    {
                        piecesThatCanCapture = new LinkedList<Piece>();
                    }

                    piecesThatCanCapture.AddLast(piece);
                }
            }

            return piecesThatCanCapture;
        }

        public bool PieceCanValidCaptureMoveByRules(Piece i_Piece)
        {
            bool validCapture = false;
            Player piecePlayer = i_Piece.Side == eSide.Top ? TopPlayer : BottomPlayer;

            if (!i_Piece.Captured && i_Piece.Location.HasValue)
            {
                if (CanPieceMoveCapture(i_Piece))
                {
                    if (piecePlayer.PerformingOngoingCapture && i_Piece.PerformingMultipleCapture)
                    {
                        validCapture = true;
                    }
                    else if (!piecePlayer.PerformingOngoingCapture)
                    {
                        validCapture = true;
                    }
                }
            }

            return validCapture;
        }

        public bool PieceCanValidMoveByRules(Piece i_Piece)
        {
            bool validMove;
            Player piecePlayer = i_Piece.Side == eSide.Top ? TopPlayer : BottomPlayer;

            if (piecePlayer.PerformingOngoingCapture)
            {
                validMove = i_Piece.PerformingMultipleCapture;
            }
            else
            {
                if (CanPlayerMoveCapture(piecePlayer))
                {
                    validMove = CanPieceMoveCapture(i_Piece);
                }
                else
                {
                    validMove = CanPieceMoveGeneral(i_Piece);
                }
            }

            return validMove;
        }
    }
}