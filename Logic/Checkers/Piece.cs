using System;

namespace CheckersLogic
{
    public class Piece
    {
        private readonly Player r_Player;
        private readonly GameEngine.eSide r_Side;
        private eType m_Type;
        private bool m_PerformingMultipleCapture;
        private bool m_Captured;
        private BoardPoint? m_Location;
        public event Action<Piece> Moved;
        public event Action<Piece> ResetPiece;
        public event Action<Piece> ChangedLocation;
        public event Action<Piece> ChangedCapturedState;

        public enum eType
        {
            Man,
            King
        }

        public enum eValue
        {
            Man = 1,
            King = 4
        }

        public Piece(Player i_Player)
        {
            r_Side = i_Player.Side;
            r_Player = i_Player;
            Reset();
        }

        public Player Player
        {
            get
            {
                return r_Player;
            }
        }

        public GameEngine.eSide Side
        {
            get
            {
                return r_Side;
            }
        }

        public eType Type
        {
            get
            {
                return m_Type;
            }

            set
            {
                m_Type = value;
            }
        }

        public bool PerformingMultipleCapture
        {
            get
            {
                return m_PerformingMultipleCapture;
            }

            set
            {
                m_PerformingMultipleCapture = value;
            }
        }

        public bool Captured
        {
            get
            {
                return m_Captured;
            }

            set
            {
                m_Captured = value;
                OnChangedCapturedState();
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
                OnChangedLocation();
            }
        }

        public void Reset()
        {
            Type = eType.Man;
            PerformingMultipleCapture = false;
            Captured = false;
            Location = null;
            OnReset();
        }

        protected virtual void OnChangedLocation()
        {
            ChangedLocation?.Invoke(this);
        }

        protected virtual void OnChangedCapturedState()
        {
            ChangedCapturedState?.Invoke(this);
        }

        public void PerformedMove()
        {
            OnMoved();
        }

        protected virtual void OnMoved()
        {
            Moved?.Invoke(this);
        }

        public void ResetOnBoard()
        {
            OnReset();
        }

        protected virtual void OnReset()
        {
            ResetPiece?.Invoke(this);
        }
    }
}