using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckersLogic;

namespace Logic.BoardGameBuilder
{
    public class CheckersBuilder : IBoardGameBuilder
    {
        private string m_PlayerOneName;
        private string m_PlayerTwoName;
        private Board.eBoardSize m_BoardSize;
        private Board m_Board;
        private Player m_Player1;
        private Player m_Player2;
        private GameEngine.eGameMode m_GameMode;

        public CheckersBuilder()
        {
            m_PlayerOneName = "Player 1";
            m_PlayerTwoName = "Player 2";
            m_GameMode = GameEngine.eGameMode.SinglePlayer;
            m_BoardSize = Board.eBoardSize.Normal;
        }

        public CheckersBuilder SetPlayerOneName(string i_Name)
        {
            m_PlayerOneName = i_Name;

            return this;
        }

        public CheckersBuilder SetPlayerTwoName(string i_Name)
        {
            m_PlayerTwoName = i_Name;

            return this;
        }

        public CheckersBuilder SetGameMode(GameEngine.eGameMode i_GameMode)
        {
            m_GameMode = i_GameMode;

            return this;
        }

        public GameEngine.eGameMode GetGameMode()
        {
            return m_GameMode;
        }

        public CheckersBuilder SetBoardSize(Board.eBoardSize i_BoardSize)
        {
            m_BoardSize = i_BoardSize;

            return this;    
        }

        public Board GetBoard()
        {
            return m_Board;
        }

        public Player GetPlayerOne()
        {
            return m_Player1;
        }

        public Player GetPlayerTwo()
        {
            return m_Player2;
        }

        public void BuildBoard()
        {
            m_Board = new Board(m_BoardSize);
        }

        public void BuildPlayerOne()
        {
            ushort numOfPieces = GameEngine.GetNumOfPiecesByBoardSize(m_BoardSize);
            const bool v_Human = true;

            m_Player1 = new Player(m_PlayerOneName, GameEngine.eSide.Bot, numOfPieces, v_Human);
        }

        public void BuildPlayerTwo()
        {
            ushort numOfPieces = GameEngine.GetNumOfPiecesByBoardSize(m_BoardSize);
            bool isHuman = m_GameMode == GameEngine.eGameMode.MultiPlayer;

            m_Player2 = new Player(m_PlayerTwoName, GameEngine.eSide.Top, numOfPieces, isHuman);
        }

        public GameEngine GetProduct()
        {
            return new GameEngine(this);
        }
    }
}
