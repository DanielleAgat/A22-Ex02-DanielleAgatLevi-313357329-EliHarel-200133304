namespace Logic.BoardGameBuilder
{
    public class BoardGameDirector
    {
        BoardGameBuilder m_BoardGameBuilder;

        public BoardGameDirector(BoardGameBuilder i_BoardGameBuilder)
        {
            m_BoardGameBuilder = i_BoardGameBuilder;
        }

        public void SetBoardGameBuilder(BoardGameBuilder i_BoardGameBuilder)
        {
            m_BoardGameBuilder = i_BoardGameBuilder;
        }

        public void Construct()
        {
            if (m_BoardGameBuilder != null)
            {
                m_BoardGameBuilder.BuildBoard();
                m_BoardGameBuilder.BuildPlayerOne();
                m_BoardGameBuilder.BuildPlayerTwo();
            }
        }
    }
}
