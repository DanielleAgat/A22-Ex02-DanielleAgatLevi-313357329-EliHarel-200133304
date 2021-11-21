using System;
using System.Collections.Generic;

namespace CheckersLogic
{
    public class AI
    {
        private readonly GameEngine r_GameEngine;

        public AI(GameEngine i_GameEngine)
        {
            r_GameEngine = i_GameEngine;
        }

        /// <summary>
        /// How the algorithm works:
        /// Created linked list of best moves.
        /// For each piece:
        ///     Create list of possible moves
        ///     Choose best move of list
        ///     Add best move to list of best moves
        ///
        /// Once linked list of best moves is complete:
        ///     Choose best move of list
        ///
        /// The parameters for choosing the best move are concentrated in the method "bestOfTwoMoves".
        /// It receives two moves and chooses the best one between them based on various parameters.
        /// For example, if it's a capture move, if it leads to being captured, length of move. 
        /// </summary>
        public LinkedList<MoveParameters> GetBestTurn(Player i_Player)
        {
            LinkedList<LinkedList<MoveParameters>> bestTurnOfEachPiece = new LinkedList<LinkedList<MoveParameters>>();

            foreach (Piece piece in i_Player.Pieces)
            {
                LinkedList<LinkedList<MoveParameters>> pieceTurns = GetAllPossibleTurns(piece);
                LinkedList<MoveParameters> pieceBestTurn = findBestTurn(pieceTurns);

                if (pieceBestTurn != null)
                {
                    bestTurnOfEachPiece.AddLast(pieceBestTurn);
                }
            }

            return findBestTurn(bestTurnOfEachPiece);
        }

        public LinkedList<LinkedList<MoveParameters>> GetAllPossibleTurns(Piece i_Piece)
        {
            LinkedList<LinkedList<MoveParameters>> allMoves = null;

            if (i_Piece != null && i_Piece.Captured == false)
            {
                if (r_GameEngine.PieceCanValidCaptureMoveByRules(i_Piece))
                {
                    allMoves = new LinkedList<LinkedList<MoveParameters>>();
                    LinkedList<MoveParameters> moveSoFar = new LinkedList<MoveParameters>();

                    getAllCaptureMoves(i_Piece, moveSoFar, allMoves);
                }
                else if (r_GameEngine.CanPieceMoveRegular(i_Piece) && !r_GameEngine.CanPlayerMoveCapture(i_Piece.Player))
                {
                    allMoves = getAllRegularMoves(i_Piece);
                }
            }

            return allMoves;
        }

        private LinkedList<LinkedList<MoveParameters>> getAllRegularMoves(Piece i_Piece)
        {
            LinkedList<LinkedList<MoveParameters>> allRegularMoves = null;

            if (i_Piece?.Location != null)
            {
                bool canMoveUpLeft = r_GameEngine.CanPieceMoveRegularDirection(i_Piece, eDirection.Up, eDirection.Left);
                bool canMoveUpRight = r_GameEngine.CanPieceMoveRegularDirection(i_Piece, eDirection.Up, eDirection.Right);
                bool canMoveDownLeft = r_GameEngine.CanPieceMoveRegularDirection(i_Piece, eDirection.Down, eDirection.Left);
                bool canMoveDownRight = r_GameEngine.CanPieceMoveRegularDirection(i_Piece, eDirection.Down, eDirection.Right);

                if (canMoveUpLeft)
                {
                    addRegularTurnToList(i_Piece, ref allRegularMoves, eDirection.Up, eDirection.Left);
                }

                if (canMoveUpRight)
                {
                    addRegularTurnToList(i_Piece, ref allRegularMoves, eDirection.Up, eDirection.Right);
                }

                if (canMoveDownLeft)
                {
                    addRegularTurnToList(i_Piece, ref allRegularMoves, eDirection.Down, eDirection.Left);
                }

                if (canMoveDownRight)
                {
                    addRegularTurnToList(i_Piece, ref allRegularMoves, eDirection.Down, eDirection.Right);
                }
            }

            return allRegularMoves;
        }

        private void addRegularTurnToList(
            Piece i_Piece,
            ref LinkedList<LinkedList<MoveParameters>> io_AllMoves,
            eDirection i_VerticalDirection,
            eDirection i_HorizontalDirection)
        {
            if (i_Piece?.Location != null)
            {
                if (io_AllMoves == null)
                {
                    io_AllMoves = new LinkedList<LinkedList<MoveParameters>>();
                }

                BoardPoint fromPoint = i_Piece.Location.Value;
                BoardPoint? toPoint = r_GameEngine.Board.GetRelativeLocation(fromPoint, i_VerticalDirection, i_HorizontalDirection);

                if (toPoint.HasValue)
                {
                    MoveParameters move = new MoveParameters(fromPoint, toPoint.Value);
                    LinkedList<MoveParameters> newTurn = new LinkedList<MoveParameters>();

                    newTurn.AddLast(move);
                    io_AllMoves.AddLast(newTurn);
                }
            }
        }

        /// <summary>
        /// Recursive method that branches to all possible capturing directions of a piece.
        /// </summary>
        private void getAllCaptureMoves(Piece i_Piece, LinkedList<MoveParameters> i_MoveSoFar, LinkedList<LinkedList<MoveParameters>> io_AllTurns)
        {
            bool canCaptureUpLeft = r_GameEngine.CanPieceMoveCaptureDirection(i_Piece, eDirection.Up, eDirection.Left);
            bool canCaptureUpRight = r_GameEngine.CanPieceMoveCaptureDirection(i_Piece, eDirection.Up, eDirection.Right);
            bool canCaptureDownLeft = r_GameEngine.CanPieceMoveCaptureDirection(i_Piece, eDirection.Down, eDirection.Left);
            bool canCaptureDownRight = r_GameEngine.CanPieceMoveCaptureDirection(i_Piece, eDirection.Down, eDirection.Right);

            if (!canCaptureUpLeft && !canCaptureUpRight && !canCaptureDownLeft && !canCaptureDownRight)
            {
                if (io_AllTurns == null)
                {
                    io_AllTurns = new LinkedList<LinkedList<MoveParameters>>();
                }

                io_AllTurns.AddLast(i_MoveSoFar);
            }
            else
            {
                performRecursiveCallsToPossibleDirections(
                    canCaptureUpLeft,
                    canCaptureUpRight,
                    canCaptureDownLeft,
                    canCaptureDownRight,
                    i_Piece,
                    i_MoveSoFar,
                    io_AllTurns);
            }
        }

        private void performRecursiveCallsToPossibleDirections(
            bool i_CanCaptureUpLeft,
            bool i_CanCaptureUpRight,
            bool i_CanCaptureDownLeft,
            bool i_CanCaptureDownRight,
            Piece i_Piece,
            LinkedList<MoveParameters> i_MoveSoFar,
            LinkedList<LinkedList<MoveParameters>> i_AllMoves)
        {
            if (i_CanCaptureUpLeft)
            {
                simulateCaptureInDirection(i_Piece, i_MoveSoFar, i_AllMoves, eDirection.Up, eDirection.Left);
            }

            if (i_CanCaptureUpRight)
            {
                simulateCaptureInDirection(i_Piece, i_MoveSoFar, i_AllMoves, eDirection.Up, eDirection.Right);
            }

            if (i_CanCaptureDownLeft)
            {
                simulateCaptureInDirection(i_Piece, i_MoveSoFar, i_AllMoves, eDirection.Down, eDirection.Left);
            }

            if (i_CanCaptureDownRight)
            {
                simulateCaptureInDirection(i_Piece, i_MoveSoFar, i_AllMoves, eDirection.Down, eDirection.Right);
            }
        }

        private void simulateCaptureInDirection(
            Piece i_Piece,
            LinkedList<MoveParameters> i_MoveSoFar,
            LinkedList<LinkedList<MoveParameters>> i_AllMoves,
            eDirection i_VerticalDirection,
            eDirection i_HorizontalDirection)
        {
            LinkedList<MoveParameters> newForkMovement = duplicateLinkedList(i_MoveSoFar);
            BoardPoint pieceOriginalLocation = i_Piece.Location.Value;
            BoardPoint? capturedPieceLocation = r_GameEngine.Board.GetRelativeLocation(i_Piece.Location.Value, i_VerticalDirection, i_HorizontalDirection);
            BoardPoint? destination = r_GameEngine.Board.GetRelativeLocation(capturedPieceLocation.Value, i_VerticalDirection, i_HorizontalDirection);
            Piece capturedPiece = r_GameEngine.Board.GetPiece(capturedPieceLocation.Value);
            bool wasPreviouslyNotKing = i_Piece.Type == Piece.eType.Man;

            r_GameEngine.Board.UpdateBoard(pieceOriginalLocation, destination.Value);
            if (r_GameEngine.Board.IsEndRow(destination.Value))
            {
                i_Piece.Type = Piece.eType.King;
            }

            // Add this current move to new list and send new list onwards to the recursion
            newForkMovement.AddLast(new MoveParameters(pieceOriginalLocation, destination.Value));
            getAllCaptureMoves(i_Piece, newForkMovement, i_AllMoves); // RECURSIVE CALL

            // Return board to previous state
            r_GameEngine.Board.UpdateBoard(destination.Value, pieceOriginalLocation);
            r_GameEngine.Board.SetPieceAtLocation(capturedPiece, capturedPieceLocation.Value);
            capturedPiece.Captured = false;
            if (wasPreviouslyNotKing)
            {
                i_Piece.Type = Piece.eType.Man;
            }
        }

        private LinkedList<MoveParameters> findBestTurn(LinkedList<LinkedList<MoveParameters>> i_PossibleTurns)
        {
            LinkedList<MoveParameters> bestMove = null;

            if (i_PossibleTurns != null)
            {
                bestMove = i_PossibleTurns.First.Value;
                foreach (LinkedList<MoveParameters> move in i_PossibleTurns)
                {
                    bestMove = bestOfTwoMoves(move, bestMove);
                }
            }

            return bestMove;
        }

        /// <summary>
        /// This method chooses based on the rule that
        /// if a player can capture, he must capture.
        /// Therefore capture moves are prioritized over regular moves.
        /// </summary>
        private LinkedList<MoveParameters> bestOfTwoMoves(LinkedList<MoveParameters> i_Turn1, LinkedList<MoveParameters> i_Turn2)
        {
            LinkedList<MoveParameters> bestMove;

            if (bothAreCaptureMoves(i_Turn1, i_Turn2))
            {
                bestMove = chooseBetweenCaptureMoves(i_Turn1, i_Turn2);
            }
            else if (bothAreRegularMoves(i_Turn1, i_Turn2))
            {
                bestMove = chooseBetweenRegularMoves(i_Turn1, i_Turn2);
            }
            else
            {
                bestMove = i_Turn1.First.Value.CaptureMove ? i_Turn1 : i_Turn2;
            }

            return bestMove;
        }

        private LinkedList<MoveParameters> chooseBetweenCaptureMoves(LinkedList<MoveParameters> i_Turn1, LinkedList<MoveParameters> i_Turn2)
        {
            LinkedList<MoveParameters> bestMove;
            const byte k_NumOfMovesParameters = 2;

            if (i_Turn1.Count > i_Turn2.Count)
            {
                bestMove = i_Turn1;
            }
            else if (i_Turn1.Count < i_Turn2.Count)
            {
                bestMove = i_Turn2;
            }
            else
            {
                bestMove = chooseWhoDoesntGetCaptured(i_Turn1, i_Turn2);
                if (bestMove == null)
                {
                    byte chosenMove = (byte)new Random().Next(k_NumOfMovesParameters);

                    bestMove = chosenMove % 2 == 0 ? i_Turn1 : i_Turn2;
                }
            }

            return bestMove;
        }

        private LinkedList<MoveParameters> chooseBetweenRegularMoves(LinkedList<MoveParameters> i_Turn1, LinkedList<MoveParameters> i_Turn2)
        {
            LinkedList<MoveParameters> bestMove;
            const bool v_CaptureMove = true;
            MoveParameters firstMove = i_Turn1.First.Value;
            MoveParameters secondMove = i_Turn2.First.Value;
            Piece piece1 = r_GameEngine.Board.GetPiece(firstMove.FromPoint);
            Piece piece2 = r_GameEngine.Board.GetPiece(secondMove.FromPoint);
            bool firstMoveLeadsToBeingCaptured = MoveLeadsToBeingCaptured(piece1, firstMove.ToPoint, !v_CaptureMove);
            bool secondMoveLeadsToBeingCaptured = MoveLeadsToBeingCaptured(piece2, secondMove.ToPoint, !v_CaptureMove);
            bool bothBad = firstMoveLeadsToBeingCaptured && secondMoveLeadsToBeingCaptured;
            bool bothGood = !firstMoveLeadsToBeingCaptured && !secondMoveLeadsToBeingCaptured;

            if (bothGood)
            {
                bestMove = choosePawnWhoEndsFarthestOnBoard(i_Turn1, i_Turn2);
            }
            else if (bothBad)
            {
                bestMove = choosePawnWhoEndsFarthestOnBoard(i_Turn1, i_Turn2);
            }
            else
            {
                bestMove = firstMoveLeadsToBeingCaptured ? i_Turn2 : i_Turn1;
            }

            return bestMove;
        }

        private bool bothAreRegularMoves(LinkedList<MoveParameters> i_Turn1, LinkedList<MoveParameters> i_Turn2)
        {
            bool bothAreRegular = false;

            if (i_Turn1 != null && i_Turn2 != null)
            {
                bool move1Regular = i_Turn1.First.Value.CaptureMove == false;
                bool move2Regular = i_Turn2.First.Value.CaptureMove == false;

                bothAreRegular = move1Regular && move2Regular;
            }

            return bothAreRegular;
        }

        private bool bothAreCaptureMoves(LinkedList<MoveParameters> i_Turn1, LinkedList<MoveParameters> i_Turn2)
        {
            bool bothAreCapture = false;

            if (i_Turn1 != null && i_Turn2 != null)
            {
                bool move1Capture = i_Turn1.First.Value.CaptureMove;
                bool move2Capture = i_Turn2.First.Value.CaptureMove;

                bothAreCapture = move1Capture && move2Capture;
            }

            return bothAreCapture;
        }

        /// <summary>
        /// Since capture turns can be long and consist of many moves, this method takes the last move,
        /// simulates the piece being in the "From" position of the last move
        /// and checks if moving in the "ToPoint" direction results in capture.
        /// It then returns the piece to the original position.
        /// </summary>
        private LinkedList<MoveParameters> chooseWhoDoesntGetCaptured(LinkedList<MoveParameters> i_Turn1, LinkedList<MoveParameters> i_Turn2)
        {
            LinkedList<MoveParameters> bestMove = null;
            MoveParameters lastMove1 = i_Turn1.Last.Value;
            MoveParameters lastMove2 = i_Turn2.Last.Value;
            Piece piece1 = r_GameEngine.Board.GetPiece(i_Turn1.First.Value.FromPoint);
            Piece piece2 = r_GameEngine.Board.GetPiece(i_Turn2.First.Value.FromPoint);
            BoardPoint piece1OriginalLocation = piece1.Location.Value;
            BoardPoint piece2OriginalLocation = piece2.Location.Value;
            r_GameEngine.Board.SetPieceAtLocation(piece1, lastMove1.FromPoint);
            r_GameEngine.Board.SetPieceAtLocation(piece2, lastMove2.FromPoint);
            bool move1Captured = MoveLeadsToBeingCaptured(piece1, lastMove1.ToPoint, lastMove1.CaptureMove);
            bool move2Captured = MoveLeadsToBeingCaptured(piece2, lastMove2.ToPoint, lastMove2.CaptureMove);

            if (move1Captured ^ move2Captured)
            {
                bestMove = move1Captured ? i_Turn2 : i_Turn1;
            }

            r_GameEngine.Board.SetPieceAtLocation(piece1, piece1OriginalLocation);
            r_GameEngine.Board.SetPieceAtLocation(piece2, piece2OriginalLocation);

            return bestMove;
        }

        /// <summary>
        /// If both moves are pawn moves, method returns move that lands farthest on the board.
        /// If not both moves are pawn moves, method chooses randomly between moves.
        /// </summary>
        private LinkedList<MoveParameters> choosePawnWhoEndsFarthestOnBoard(LinkedList<MoveParameters> i_Turn1, LinkedList<MoveParameters> i_Turn2)
        {
            const byte k_NumOfMoveParameters = 2;
            LinkedList<MoveParameters> bestMove;
            Piece piece1 = r_GameEngine.Board.GetPiece(i_Turn1.First.Value.FromPoint);
            Piece piece2 = r_GameEngine.Board.GetPiece(i_Turn2.First.Value.FromPoint);
            GameEngine.eSide playerSide = piece1.Side;

            if (piece1.Type != Piece.eType.King && piece2.Type != Piece.eType.King)
            {
                bestMove = getFarthestMovementForPlayer(playerSide, i_Turn1, i_Turn2);
            }
            else
            {
                byte randomNumber = (byte)new Random().Next(k_NumOfMoveParameters);

                bestMove = randomNumber % 2 == 0 ? i_Turn1 : i_Turn2;
            }

            return bestMove;
        }

        private LinkedList<MoveParameters> getFarthestMovementForPlayer(
            GameEngine.eSide i_PlayerSide, LinkedList<MoveParameters> i_Turn1, LinkedList<MoveParameters> i_Turn2)
        {
            LinkedList<MoveParameters> bestMove;
            int move1EndRow = i_Turn1.Last.Value.ToPoint.Row;
            int move2EndRow = i_Turn2.Last.Value.ToPoint.Row;

            if (i_PlayerSide == GameEngine.eSide.Top)
            {
                bestMove = move1EndRow > move2EndRow ? i_Turn1 : i_Turn2;
            }
            else
            {
                bestMove = move1EndRow < move2EndRow ? i_Turn1 : i_Turn2;
            }

            return bestMove;
        }

        public bool MoveLeadsToBeingCaptured(Piece i_Piece, BoardPoint i_ToPoint, bool i_CaptureMove)
        {
            bool resultsInCaptureMove = false;

            if (i_Piece != null && i_Piece.Location.HasValue)
            {
                BoardPoint oldLocation = i_Piece.Location.Value;
                BoardPoint? capturedPieceLocation = null;
                Piece capturedPiece = null;

                if (i_CaptureMove)
                {
                    capturedPieceLocation = r_GameEngine.Board.GetPointBetween(oldLocation, i_ToPoint);
                    capturedPiece = r_GameEngine.Board.GetPiece(capturedPieceLocation.Value);
                }

                r_GameEngine.Board.UpdateBoard(oldLocation, i_ToPoint);
                resultsInCaptureMove = CanEnemyPiecesInRadiusCapture(i_ToPoint);
                r_GameEngine.Board.UpdateBoard(i_ToPoint, oldLocation);
                if (i_CaptureMove)
                {
                    r_GameEngine.Board.SetPieceAtLocation(capturedPiece, capturedPieceLocation.Value);
                    capturedPiece.Captured = false;
                }
            }

            return resultsInCaptureMove;
        }

        public bool CanEnemyPiecesInRadiusCapture(BoardPoint i_Point)
        {
            bool canCapture = false;
            Board board = r_GameEngine.Board;
            BoardPoint? locationUpLeft = board.GetRelativeLocation(i_Point, eDirection.Up, eDirection.Left);
            BoardPoint? locationUpRight = board.GetRelativeLocation(i_Point, eDirection.Up, eDirection.Right);
            BoardPoint? locationDownLeft = board.GetRelativeLocation(i_Point, eDirection.Down, eDirection.Left);
            BoardPoint? locationDownRight = board.GetRelativeLocation(i_Point, eDirection.Down, eDirection.Right);

            canCapture = canCapture || CheckIfLocationCanCapture(locationUpLeft);
            canCapture = canCapture || CheckIfLocationCanCapture(locationUpRight);
            canCapture = canCapture || CheckIfLocationCanCapture(locationDownLeft);
            canCapture = canCapture || CheckIfLocationCanCapture(locationDownRight);

            return canCapture;
        }

        public bool CheckIfLocationCanCapture(BoardPoint? i_Location)
        {
            bool canCapture = false;

            if (i_Location.HasValue)
            {
                Piece pieceAtLocation = r_GameEngine.Board.GetPiece(i_Location.Value);

                if (pieceAtLocation != null)
                {
                    canCapture = r_GameEngine.CanPieceMoveCapture(pieceAtLocation);
                }
            }

            return canCapture;
        }

        private LinkedList<MoveParameters> duplicateLinkedList(LinkedList<MoveParameters> i_SourceList)
        {
            LinkedList<MoveParameters> newList = new LinkedList<MoveParameters>();

            foreach (MoveParameters move in i_SourceList)
            {
                MoveParameters dupMove = new MoveParameters(move.FromPoint, move.ToPoint);
             
                newList.AddLast(dupMove);
            }

            return newList;
        }
    }
}