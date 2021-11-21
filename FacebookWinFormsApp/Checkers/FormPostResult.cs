using CheckersUIWindows;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Checkers
{
    public enum eGameResult
    {
        Victory,
        Tie,
        Defeat
    }

    public partial class FormPostResult : Form
    {
        private eGameResult m_GameResult;
        FormBoard m_CheckersBoard;
        int m_ScorePlayer1;
        int m_ScorePlayer2;
        string m_NamePlayer1;
        string m_NamePlayer2;

        public FormPostResult(FormBoard i_CheckersBoard)
        {
            InitializeComponent();
            m_CheckersBoard = i_CheckersBoard;
            m_ScorePlayer1 = m_CheckersBoard.getPlayer1Score();
            m_NamePlayer1 = m_CheckersBoard.getPlayer1Name();
            m_ScorePlayer2 = m_CheckersBoard.getPlayer2Score();
            m_NamePlayer2 = m_CheckersBoard.getPlayer2Name();
            labelResult.Text = getResultText();
            textBoxResultToPost.Text = getResultToPostMessage();
            setTopBarText();
        }

        private void setTopBarText()
        {
            switch (m_GameResult)
            {
                case eGameResult.Victory:
                    {
                        Text = "Victory! :D";
                        break;
                    }
                case eGameResult.Tie:
                    {
                        Text = "Tie >:|";
                        break;
                    }
                case eGameResult.Defeat:
                    {
                        Text = "Defeat :(";
                        break;
                    }
                default:
                    {
                        Text = "Match over!";
                        break;
                    }
            }
        }

        private string getResultText()
        {
            string resultMessage;

            if (m_ScorePlayer1 > m_ScorePlayer2)
            {
                resultMessage = "Congratulations on your glorious victory!";
                m_GameResult = eGameResult.Victory;
            }
            else if (m_ScorePlayer1 < m_ScorePlayer2)
            {
                resultMessage = "What a terrible defeat!";
                m_GameResult = eGameResult.Defeat;
            }
            else
            {
                resultMessage = "Such a suspenseful tie!";
                m_GameResult = eGameResult.Tie;
            }

            return resultMessage;
        }

        private string getResultToPostMessage()
        {
            string resultToPostMsg;

            switch(m_GameResult)
            {
                case eGameResult.Victory:
                    {
                        resultToPostMsg = $"I have just vanquished {m_NamePlayer2} in a bloody game of CHECKERS, with a score of {m_ScorePlayer1} to {m_ScorePlayer2}.{Environment.NewLine}{Environment.NewLine}Fear me!";
                        break;
                    }
                case eGameResult.Defeat:
                    {
                        resultToPostMsg = $"{m_NamePlayer2} has destroyed me in CHECKERS, with a score of {m_ScorePlayer2} to {m_ScorePlayer1}.{Environment.NewLine}{Environment.NewLine}I would have won if the sun wasn't in my eye.";
                        break;
                    }
                case eGameResult.Tie:
                    {
                        resultToPostMsg = $"{m_NamePlayer2} and I have battled to a stalemate, with a score of {m_ScorePlayer1}-{m_ScorePlayer2}.{Environment.NewLine}{Environment.NewLine}Perfectly balanced, as all things should be.";
                        break;
                    }
                default:
                    {
                        resultToPostMsg = $"I just played a wonderful match of CHECKERS.{Environment.NewLine}This is not a sponsored message.";
                        break;
                    }
            }

            return resultToPostMsg;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.No;
        }

        public string getMessageToPost()
        {
            return textBoxResultToPost.Text;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Yes;
        }
    }
}
