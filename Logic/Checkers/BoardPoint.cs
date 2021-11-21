namespace CheckersLogic
{
    /// <summary>
    /// While .NET Point could work as well,
    /// we found that using the meaningful names Col and Row
    /// improved readability quite a bit.
    /// </summary>
    public struct BoardPoint
    {
        private int m_Col;
        private int m_Row;

        public BoardPoint(int i_Col, int i_Row)
        {
            m_Col = i_Col;
            m_Row = i_Row;
        }

        public int Col
        {
            get
            {
                return m_Col;
            }

            set
            {
                m_Col = value;
            }
        }

        public int Row
        {
            get
            {
                return m_Row;
            }

            set
            {
                m_Row = value;
            }
        }
    }
}