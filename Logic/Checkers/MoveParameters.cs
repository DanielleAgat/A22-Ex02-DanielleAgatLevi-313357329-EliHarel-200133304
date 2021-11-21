namespace CheckersLogic
{
    public class MoveParameters
    {
        private BoardPoint m_FromPoint;
        private BoardPoint m_ToPoint;
        private bool m_CaptureMove;

        public MoveParameters(BoardPoint i_FromPoint, BoardPoint i_ToPoint)
        {
            m_FromPoint = i_FromPoint;
            m_ToPoint = i_ToPoint;
            m_CaptureMove = AreCaptureMoveParameters(i_FromPoint, i_ToPoint);
        }

        public BoardPoint FromPoint
        {
            get
            {
                return m_FromPoint;
            }

            set
            {
                m_FromPoint = value;
                m_CaptureMove = AreCaptureMoveParameters(m_FromPoint, m_ToPoint);
            }
        }

        public BoardPoint ToPoint
        {
            get
            {
                return m_ToPoint;
            }

            set
            {
                m_ToPoint = value;
                m_CaptureMove = AreCaptureMoveParameters(m_FromPoint, m_ToPoint);
            }
        }

        public bool CaptureMove
        {
            get
            {
                return m_CaptureMove;
            }
        }

        public static bool AreCaptureMoveParameters(BoardPoint i_FromPoint, BoardPoint i_ToPoint)
        {
            bool upDouble = IsUpDoubleMove(i_FromPoint, i_ToPoint);
            bool downDouble = IsDownDoubleMove(i_FromPoint, i_ToPoint);
            bool leftDouble = IsLeftDoubleMove(i_FromPoint, i_ToPoint);
            bool rightDouble = IsRightDoubleMove(i_FromPoint, i_ToPoint);
            bool upLeftOrRight = upDouble && (leftDouble || rightDouble);
            bool downLeftOrRight = downDouble && (leftDouble || rightDouble);

            return upLeftOrRight || downLeftOrRight;
        }

        public static bool IsUpSingleMove(BoardPoint i_FromPoint, BoardPoint i_ToPoint)
        {
            return (i_FromPoint.Row + (int)eDirection.Up) == i_ToPoint.Row;
        }

        public static bool IsUpDoubleMove(BoardPoint i_FromPoint, BoardPoint i_ToPoint)
        {
            return (i_FromPoint.Row + ((int)eDirection.Up * 2)) == i_ToPoint.Row;
        }

        public static bool IsDownSingleMove(BoardPoint i_FromPoint, BoardPoint i_ToPoint)
        {
            return (i_FromPoint.Row + (int)eDirection.Down) == i_ToPoint.Row;
        }

        public static bool IsDownDoubleMove(BoardPoint i_FromPoint, BoardPoint i_ToPoint)
        {
            return (i_FromPoint.Row + ((int)eDirection.Down * 2)) == i_ToPoint.Row;
        }

        public static bool IsLeftSingleMove(BoardPoint i_FromPoint, BoardPoint i_ToPoint)
        {
            return (i_FromPoint.Col + (int)eDirection.Left) == i_ToPoint.Col;
        }

        public static bool IsLeftDoubleMove(BoardPoint i_FromPoint, BoardPoint i_ToPoint)
        {
            return (i_FromPoint.Col + ((int)eDirection.Left * 2)) == i_ToPoint.Col;
        }

        public static bool IsRightSingleMove(BoardPoint i_FromPoint, BoardPoint i_ToPoint)
        {
            return (i_FromPoint.Col + (int)eDirection.Right) == i_ToPoint.Col;
        }

        public static bool IsRightDoubleMove(BoardPoint i_FromPoint, BoardPoint i_ToPoint)
        {
            return (i_FromPoint.Col + ((int)eDirection.Right * 2)) == i_ToPoint.Col;
        }
    }
}