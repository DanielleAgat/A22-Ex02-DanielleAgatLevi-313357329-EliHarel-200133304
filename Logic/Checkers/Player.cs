using System.Collections.Generic;

namespace CheckersLogic
{
    public class Player
    {
        private readonly bool r_Human;
        private readonly Piece[] r_Pieces;
        private readonly LinkedList<LinkedList<MoveParameters>> r_TurnHistory;
        private string m_Name;
        private GameEngine.eSide m_Side;
        private int m_MatchScore;
        private int m_TotalScore;
        private bool m_PerformingOngoingCapture;
        private bool m_Forfeited;

        public Player(string i_Name, GameEngine.eSide i_Side, ushort i_NumOfPieces, bool i_Human)
        {
            m_Name = i_Name;
            m_Side = i_Side;
            m_MatchScore = 0;
            m_TotalScore = 0;
            r_Human = i_Human;
            m_PerformingOngoingCapture = false;
            r_Pieces = new Piece[i_NumOfPieces];
            r_TurnHistory = new LinkedList<LinkedList<MoveParameters>>();
            m_Forfeited = false;
            for (int i = 0; i < i_NumOfPieces; i++)
            {
                r_Pieces[i] = new Piece(this);
            }
        }

        public string Name
        {
            get
            {
                return m_Name;
            }

            set
            {
                m_Name = value;
            }
        }

        public LinkedList<LinkedList<MoveParameters>> TurnHistoryList
        {
            get
            {
                return r_TurnHistory;
            }
        }

        public LinkedList<MoveParameters> LastTurn
        {
            get
            {
                return r_TurnHistory?.Last?.Value;
            }

            set
            {
                r_TurnHistory.AddLast(value);
            }
        }

        public MoveParameters LastMove
        {
            get
            {
                MoveParameters lastStep = null;

                if (r_TurnHistory.Last != null)
                {
                    if (r_TurnHistory.Last.Value.Last != null)
                    {
                        lastStep = r_TurnHistory.Last.Value.Last.Value;
                    }
                }

                return lastStep;
            }

            set
            {
                LinkedList<MoveParameters> lastMoveLst = LastTurn;

                if (lastMoveLst == null)
                {
                    lastMoveLst = new LinkedList<MoveParameters>();
                }

                if (PerformingOngoingCapture)
                {
                    lastMoveLst.AddLast(value);
                }
                else
                {
                    LinkedList<MoveParameters> newMoveLst = new LinkedList<MoveParameters>();

                    newMoveLst.AddLast(value);
                    LastTurn = newMoveLst;
                }
            }
        }

        public GameEngine.eSide Side
        {
            get
            {
                return m_Side;
            }

            set
            {
                m_Side = value;
            }
        }

        public int MatchScore
        {
            get
            {
                return m_MatchScore;
            }

            set
            {
                m_MatchScore = value;
            }
        }

        public int TotalScore
        {
            get
            {
                return m_TotalScore;
            }

            set
            {
                m_TotalScore = value;
            }
        }

        public bool IsHuman
        {
            get
            {
                return r_Human;
            }
        }

        public bool IsComputer()
        {
            return !IsHuman;
        }

        public Piece[] Pieces
        {
            get
            {
                return r_Pieces;
            }
        }

        public bool PerformingOngoingCapture
        {
            get
            {
                return m_PerformingOngoingCapture;
            }

            set
            {
                m_PerformingOngoingCapture = value;
            }
        }

        public bool Forfeited
        {
            get
            {
                return m_Forfeited;
            }

            set
            {
                m_Forfeited = value;
            }
        }

        public bool AreActivePiecesLeft()
        {
            bool hasRemainingPieces = false;

            foreach (Piece piece in r_Pieces)
            {
                if (piece.Captured == false)
                {
                    hasRemainingPieces = true;
                    break;
                }
            }

            return hasRemainingPieces;
        }

        public void EndMatch()
        {
            resetPieces();
            r_TurnHistory.Clear();
            m_PerformingOngoingCapture = false;
            m_Forfeited = false;
            m_MatchScore = 0;
        }

        private void resetPieces()
        {
            foreach (Piece piece in r_Pieces)
            {
                piece.Reset();
            }
        }

        public ushort GetActivePiecesValue()
        {
            ushort piecesValue = 0;

            foreach (Piece piece in r_Pieces)
            {
                if (piece.Captured == false)
                {
                    piecesValue += piece.Type == Piece.eType.King ? (ushort)Piece.eValue.King : (ushort)Piece.eValue.Man;
                }
            }

            return piecesValue;
        }
    }
}