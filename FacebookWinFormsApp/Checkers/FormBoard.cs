using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CheckersLogic;
using Logic.BoardGameBuilder;
using Timer = System.Windows.Forms.Timer;
using FacebookWrapper.ObjectModel;

namespace CheckersUIWindows
{
    public partial class FormBoard : Form
    {
        private const int k_TimerInterval = 3;
        private const int k_SideMargin = 180;
        private const int k_TopMargin = 20;
        private const int k_PictureBoxProfileSize = 100;
        private const int k_PictureBoxOffsetY = 20;
        private const int k_PictureBoxOffsetX = 20;
        private readonly Timer r_Timer;
        private readonly GameEngine r_GameEngine;
        private readonly GameEngine.eGameMode r_GameMode;
        private readonly LinkedList<GameEngine.eSide> r_SideToHighlight;
        private readonly LinkedList<PiecePictureBox> r_CapturedListTop;
        private readonly LinkedList<PiecePictureBox> r_CapturedListBottom;
        private readonly Board.eBoardSize r_BoardSize;
        private readonly Color r_PlayableButtonColor = Color.Tan;
        private readonly Color r_UnplayableButtonColor = Color.DarkGray;
        private readonly Color r_HighlightButtonColor = Color.Blue;
        private readonly Color r_PieceCanMoveColor = Color.Orange;
        private readonly Color r_PossibleMoveColor = Color.LightGreen;
        private bool m_ShowPossibleMovesOfPiece;
        private bool m_ShowPiecesThatCanMove;
        private LinkedList<LinkedList<MoveParameters>> m_PossiblePieceTurns;
        private LinkedList<Piece> m_PiecesThatCanMoveList;
        private PiecePictureBox[] m_TopPicturePieces;
        private PiecePictureBox[] m_BottomPicturePieces;
        private BoardButton[,] m_ButtonMatrix;
        private BoardButton m_FromButton;
        private BoardButton m_ToButton;
        private Label m_LabelPlayer1Name;
        private Label m_LabelPlayer1Score;
        private Label m_LabelPlayer2Name;
        private Label m_LabelPlayer2Score;
        private PictureBox m_PicturePlayer1Icon;
        private PictureBox m_PicturePlayer2Icon;
        private Label m_LabelPlayerTurn;
        private Button m_ButtonForfeit;
        private CheckBox m_CheckBoxShowMovesOfPiece;
        private CheckBox m_CheckBoxShowPiecesThatCanMove;
        private PictureBox m_PictureBoxPlayer1Profile;
        private PictureBox m_PictureBoxPlayer2Profile;

        public event Action TopAnimation;

        public event Action BotAnimation;

        public event Action MatchEnded;

        public FormBoard(FormGameSettings i_GameSettings, Image i_UserImage)
        {
            r_SideToHighlight = new LinkedList<GameEngine.eSide>();
            r_CapturedListTop = new LinkedList<PiecePictureBox>();
            r_CapturedListBottom = new LinkedList<PiecePictureBox>();
            m_PossiblePieceTurns = null;
            r_Timer = new Timer();
            r_Timer.Stop();
            r_Timer.Interval = k_TimerInterval;
            r_BoardSize = i_GameSettings.BoardSize;
            r_GameMode = i_GameSettings.GameMode;
            string player1Name = i_GameSettings.Player1Name;
            string player2Name = i_GameSettings.Player2Name;

            // r_GameEngine = new GameEngine(player1Name, player2Name, r_GameMode, r_BoardSize); // TODO: Delete

            CheckersBuilder checkersBuilder = new CheckersBuilder();

            // TODO: consider changing if we think Guy won't like
            checkersBuilder.SetPlayerOneName(player1Name) 
                .SetPlayerTwoName(player2Name)
                .SetGameMode(r_GameMode)
                .SetBoardSize(r_BoardSize);

            BoardGameComposer.Compose(checkersBuilder);
            r_GameEngine = checkersBuilder.GetProduct();

            generateButtonMatrix();
            generatePieces();
            r_GameEngine.ResetGame();
            r_GameEngine.GameStateChanged += m_GameEngine_GameStateChanged;
            r_GameEngine.PlayerScoreChanged += m_GameEngine_PlayerScoreChanged;
            r_GameEngine.AdvancedTurn += r_GameEngine_AdvancedTurn;
            initializeComponentManual(i_GameSettings);
            highlightNextPlayer();
            enableForfeitButton();
            generatePictureBoxes(i_GameSettings, i_UserImage);
        }

        private void generatePictureBoxes(FormGameSettings i_GameSettings, Image i_UserImage)
        {
            m_PictureBoxPlayer1Profile = new PictureBox();
            m_PictureBoxPlayer2Profile = new PictureBox();
            m_PictureBoxPlayer1Profile.Size = new Size(k_PictureBoxProfileSize, k_PictureBoxProfileSize);
            m_PictureBoxPlayer2Profile.Size = new Size(k_PictureBoxProfileSize, k_PictureBoxProfileSize);
            Point profile1Point = m_LabelPlayer1Name.Location;
            Point profile2Point = m_LabelPlayer2Name.Location;

            Controls.Add(m_PictureBoxPlayer1Profile);
            Controls.Add(m_PictureBoxPlayer2Profile);
            profile1Point.Y += k_PictureBoxOffsetY;
            profile2Point.Y -= k_PictureBoxProfileSize;
            profile2Point.Y -= k_PictureBoxOffsetY;
            setXAxisProfilePic(m_PictureBoxPlayer1Profile, m_LabelPlayer1Name);
            setXAxisProfilePic(m_PictureBoxPlayer2Profile, m_LabelPlayer2Name);
            m_PictureBoxPlayer1Profile.Image = i_UserImage;
            setPlayer2Image(i_GameSettings);
            m_PictureBoxPlayer1Profile.Location = profile1Point;
            m_PictureBoxPlayer2Profile.Location = profile2Point;
        }

        private void setPlayer2Image(FormGameSettings i_GameSettings)
        {
            m_PictureBoxPlayer2Profile.SizeMode = PictureBoxSizeMode.StretchImage;
            switch (i_GameSettings.GameMode)
            {
                case GameEngine.eGameMode.SinglePlayer:
                    {
                        m_PictureBoxPlayer2Profile.Image = BasicFacebookFeatures.Properties.Resources.Butter_Robot;
                        break;
                    }
                case GameEngine.eGameMode.MultiPlayer:
                    {
                        User selectedFriend = i_GameSettings.Friend;

                        if (selectedFriend != null)
                        {
                            m_PictureBoxPlayer2Profile.Image = selectedFriend.ImageNormal;
                        }
                        else
                        {
                            m_PictureBoxPlayer2Profile.Image = BasicFacebookFeatures.Properties.Resources.Morty;
                        }

                        break;
                    }
            }
        }

        private void setXAxisProfilePic(PictureBox i_pictureBoxProfilePic, Label i_PlayerNameLabel)
        {
            int PictureBoxSizeHalf = k_PictureBoxProfileSize / 2;
            int nameLengthMiddle = i_PlayerNameLabel.Size.Width / 2;
            int xAxisLocation = i_PlayerNameLabel.Location.X;
            Point point = new Point();

            point.X = xAxisLocation;
            point.Y = i_pictureBoxProfilePic.Location.Y;
            i_pictureBoxProfilePic.Location = point;
        }

        private void generateButtonMatrix()
        {
            m_ButtonMatrix = new BoardButton[(int)r_BoardSize, (int)r_BoardSize];
            for (int row = 0; row < (int)r_BoardSize; row++)
            {
                for (int col = 0; col < (int)r_BoardSize; col++)
                {
                    m_ButtonMatrix[row, col] = new BoardButton(row, col);
                    Controls.Add(m_ButtonMatrix[row, col]);
                    setButtonLocation(row, col);
                    if (r_GameEngine.Board.PlayableTile(row, col))
                    {
                        m_ButtonMatrix[row, col].BackColor = r_PlayableButtonColor;
                        m_ButtonMatrix[row, col].Click += BoardButton_Click;
                    }
                    else
                    {
                        m_ButtonMatrix[row, col].BackColor = r_UnplayableButtonColor;
                        m_ButtonMatrix[row, col].Enabled = false;
                    }
                }
            }
        }

        private void setButtonLocation(int i_Row, int i_Col)
        {
            // Check if first button in row
            if (i_Col == 0)
            {
                m_ButtonMatrix[i_Row, i_Col].Left = k_SideMargin;
                if (i_Row == 0)
                {
                    m_ButtonMatrix[i_Row, i_Col].Top = k_TopMargin;
                }
                else
                {
                    m_ButtonMatrix[i_Row, i_Col].Top = m_ButtonMatrix[i_Row - 1, i_Col].Bottom;
                }
            }
            else
            {
                m_ButtonMatrix[i_Row, i_Col].Left = m_ButtonMatrix[i_Row, i_Col - 1].Right;
                m_ButtonMatrix[i_Row, i_Col].Top = m_ButtonMatrix[i_Row, i_Col - 1].Top;
            }
        }

        private void generatePieces()
        {
            ushort numOfPieces = GameEngine.GetNumOfPiecesByBoardSize(r_BoardSize);
            Piece[] topPieces = r_GameEngine.TopPlayer.Pieces;
            Piece[] botPieces = r_GameEngine.BottomPlayer.Pieces;

            m_TopPicturePieces = new PiecePictureBox[numOfPieces];
            m_BottomPicturePieces = new PiecePictureBox[numOfPieces];
            for (int i = 0; i < numOfPieces; i++)
            {
                Piece topPiece = topPieces[i];
                Piece botPiece = botPieces[i];

                m_TopPicturePieces[i] = new PiecePictureBox(topPiece, this);
                m_BottomPicturePieces[i] = new PiecePictureBox(botPiece, this);
                Controls.Add(m_TopPicturePieces[i]);
                Controls.Add(m_BottomPicturePieces[i]);
            }
        }

        /// <summary>
        /// Due to the amount of buttons being a variable,
        /// the board is designed manually and not through the visual designer.
        /// The code is written in such a way meant to resemble
        /// the code written by the visual designer, for familiarity.
        /// </summary>
        private void initializeComponentManual(FormGameSettings i_GameSettings)
        {
            const int k_SpaceBetweenBoardAndSideOptions = 20;
            const int k_SpaceBetweenSideOptions = 20;
            const int k_PlayerIconSize = 25;
            int rowsOccupiedByEachPlayer = ((int)r_BoardSize - 2) / 2;
            string player1Name = i_GameSettings.Player1Name;
            string player2Name = i_GameSettings.Player2Name;
            int boardSideLength = (int)r_BoardSize * BoardButton.ButtonSize;
            int width = boardSideLength + (k_SideMargin * 2);
            int height = boardSideLength + (k_TopMargin * 2);

            ClientSize = new Size(width, height);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Text = @"Checkers";

            // m_LabelPlayer1Name:
            m_LabelPlayer1Name = new Label();
            m_LabelPlayer1Name.AutoSize = true;
            m_LabelPlayer1Name.Text = $@"{player1Name}:";
            m_LabelPlayer1Name.Top = m_ButtonMatrix[rowsOccupiedByEachPlayer + 1, 0].Top
                                     + (BoardButton.ButtonSize / 2)
                                     - (m_LabelPlayer1Name.Height / 2);
            m_LabelPlayer1Name.Left = ClientRectangle.Left + (k_PlayerIconSize * 2);
            Controls.Add(m_LabelPlayer1Name);

            // m_LabelPlayer1Score:
            m_LabelPlayer1Score = new Label();
            m_LabelPlayer1Score.AutoSize = true;
            m_LabelPlayer1Score.Text = r_GameEngine.BottomPlayer.TotalScore.ToString();
            m_LabelPlayer1Score.Top = m_LabelPlayer1Name.Top;
            m_LabelPlayer1Score.Left = m_LabelPlayer1Name.Right + 5;
            Controls.Add(m_LabelPlayer1Score);

            // m_LabelPlayer2Name:
            m_LabelPlayer2Name = new Label();
            m_LabelPlayer2Name.AutoSize = true;
            m_LabelPlayer2Name.Text = $@"{player2Name}:";
            m_LabelPlayer2Name.Top = m_ButtonMatrix[rowsOccupiedByEachPlayer, 0].Top
                                     + (BoardButton.ButtonSize / 2)
                                     - (m_LabelPlayer2Name.Height / 2);
            m_LabelPlayer2Name.Left = m_LabelPlayer1Name.Left;
            Controls.Add(m_LabelPlayer2Name);

            // m_LabelPlayer2Score:
            m_LabelPlayer2Score = new Label();
            m_LabelPlayer2Score.AutoSize = true;
            m_LabelPlayer2Score.Text = r_GameEngine.TopPlayer.TotalScore.ToString();
            m_LabelPlayer2Score.Top = m_LabelPlayer2Name.Top;
            m_LabelPlayer2Score.Left = m_LabelPlayer2Name.Right + 5;
            Controls.Add(m_LabelPlayer2Score);

            // m_PicturePlayer1Icon:
            m_PicturePlayer1Icon = new PictureBox();
            m_PicturePlayer1Icon.Image = BasicFacebookFeatures.Properties.Resources.BlackMan;
            m_PicturePlayer1Icon.Size = new Size(k_PlayerIconSize, k_PlayerIconSize);
            m_PicturePlayer1Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            m_PicturePlayer1Icon.Top = m_LabelPlayer1Name.Top + (m_LabelPlayer1Name.Height / 2)
                - (m_PicturePlayer1Icon.Height / 2);
            m_PicturePlayer1Icon.Left = ClientRectangle.Left + (k_PlayerIconSize / 2);
            Controls.Add(m_PicturePlayer1Icon);

            // m_PicturePlayer2Icon:
            m_PicturePlayer2Icon = new PictureBox();
            m_PicturePlayer2Icon.Image = BasicFacebookFeatures.Properties.Resources.RedMan;
            m_PicturePlayer2Icon.Size = new Size(k_PlayerIconSize, k_PlayerIconSize);
            m_PicturePlayer2Icon.SizeMode = PictureBoxSizeMode.StretchImage;
            m_PicturePlayer2Icon.Top = m_LabelPlayer2Name.Top + (m_LabelPlayer2Name.Height / 2)
                                       - (m_PicturePlayer2Icon.Height / 2);
            m_PicturePlayer2Icon.Left = m_PicturePlayer1Icon.Left;
            Controls.Add(m_PicturePlayer2Icon);

            // m_CheckBoxShowMovesOfPiece: 
            m_CheckBoxShowMovesOfPiece = new CheckBox();
            m_CheckBoxShowMovesOfPiece.Text = $@"Show chosen piece's {Environment.NewLine}possible moves";
            m_CheckBoxShowMovesOfPiece.AutoSize = true;
            m_CheckBoxShowMovesOfPiece.Left =
                m_ButtonMatrix[0, (int)r_BoardSize - 1].Right + k_SpaceBetweenBoardAndSideOptions;
            m_CheckBoxShowMovesOfPiece.CheckedChanged += m_CheckBoxShowMovesOfPiece_CheckedChanged;
            Controls.Add(m_CheckBoxShowMovesOfPiece);

            // m_CheckBoxShowPiecesThatCanMove: 
            m_CheckBoxShowPiecesThatCanMove = new CheckBox();
            m_CheckBoxShowPiecesThatCanMove.Text = $@"Show pieces{Environment.NewLine}that can move";
            m_CheckBoxShowPiecesThatCanMove.AutoSize = true;
            m_CheckBoxShowPiecesThatCanMove.Left = m_CheckBoxShowMovesOfPiece.Left;
            m_CheckBoxShowPiecesThatCanMove.Top = m_CheckBoxShowMovesOfPiece.Bottom + k_SpaceBetweenSideOptions;
            m_CheckBoxShowPiecesThatCanMove.CheckedChanged += m_CheckBoxShowPiecesThatCanMove_CheckedChanged;
            Controls.Add(m_CheckBoxShowPiecesThatCanMove);

            // m_LabelPlayerTurn:
            m_LabelPlayerTurn = new Label();
            m_LabelPlayerTurn.Text = @"Test";
            m_LabelPlayerTurn.AutoSize = true;
            m_LabelPlayerTurn.Left = m_CheckBoxShowMovesOfPiece.Left;
            m_LabelPlayerTurn.Top = m_CheckBoxShowPiecesThatCanMove.Bottom + k_SpaceBetweenSideOptions;
            m_LabelPlayerTurn.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(m_LabelPlayerTurn);

            // m_ButtonForfeit:
            m_ButtonForfeit = new Button();
            m_ButtonForfeit.Text = @"Forfeit";
            m_ButtonForfeit.AutoSize = true;
            m_ButtonForfeit.Left = m_LabelPlayerTurn.Left;
            m_ButtonForfeit.Top = m_LabelPlayerTurn.Bottom + k_SpaceBetweenSideOptions;
            m_ButtonForfeit.Click += m_ButtonForfeit_Click;
            Controls.Add(m_ButtonForfeit);
            int startingTopForSideOptions = k_TopMargin +
                                            ((boardSideLength
                                              - m_CheckBoxShowMovesOfPiece.Height
                                              - m_CheckBoxShowPiecesThatCanMove.Height
                                              - m_LabelPlayerTurn.Height
                                              - m_ButtonForfeit.Height
                                              - (k_SpaceBetweenSideOptions * 3)
                                              - (m_CheckBoxShowMovesOfPiece.Height / 2)) / 2);

            m_CheckBoxShowMovesOfPiece.Top = startingTopForSideOptions;
            m_CheckBoxShowPiecesThatCanMove.Top = m_CheckBoxShowMovesOfPiece.Bottom + k_SpaceBetweenSideOptions;
            m_LabelPlayerTurn.Top = m_CheckBoxShowPiecesThatCanMove.Bottom + k_SpaceBetweenSideOptions;
            m_ButtonForfeit.Top = m_LabelPlayerTurn.Bottom + k_SpaceBetweenSideOptions;
        }

        public BoardButton[,] ButtonMatrix
        {
            get
            {
                return m_ButtonMatrix;
            }
        }

        public Timer Timer
        {
            get
            {
                return r_Timer;
            }
        }

        public GameEngine GameEngine
        {
            get
            {
                return r_GameEngine;
            }
        }

        public LinkedList<PiecePictureBox> CapturedListTop
        {
            get
            {
                return r_CapturedListTop;
            }
        }

        public LinkedList<PiecePictureBox> CapturedListBottom
        {
            get
            {
                return r_CapturedListBottom;
            }
        }

        public string getPlayer1Name()
        {
            return m_LabelPlayer1Name.Text;
        }

        public string getPlayer2Name()
        {
            return m_LabelPlayer2Name.Text;
        }

        public int getPlayer1Score()
        {
            return int.Parse(m_LabelPlayer1Score.Text);
        }

        public int getPlayer2Score()
        {
            return int.Parse(m_LabelPlayer2Score.Text);
        }

        private void BoardButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            if (i_Sender is BoardButton clickedButton)
            {
                if (clickedButton == m_FromButton)
                {
                    deselectFromButton();
                }
                else
                {
                    Piece pieceInButton = r_GameEngine.Board.GetPiece(clickedButton.Col, clickedButton.Row);

                    if (pieceInButton?.Player == r_GameEngine.CurrentTurnPlayer())
                    {
                        if (validButtonToMoveFrom(clickedButton))
                        {
                            updateFromButton(clickedButton);
                        }
                    }
                    else if (m_FromButton != null && pieceInButton == null)
                    {
                        if (m_ShowPossibleMovesOfPiece)
                        {
                            hidePossibleMoves();
                        }

                        m_PossiblePieceTurns = null;
                        m_ToButton = clickedButton;
                        tryMove();
                    }
                }
            }
        }

        private void deselectFromButton()
        {
            if (m_FromButton != null)
            {
                m_FromButton.BackColor = r_PlayableButtonColor;
                m_FromButton = null;
                hidePossibleMoves();
                m_PossiblePieceTurns = null;
                if (m_ShowPiecesThatCanMove)
                {
                    showPiecesThatCanMove();
                }
            }
        }

        private void updateFromButton(BoardButton io_NewFromButton)
        {
            if (m_FromButton != null)
            {
                deselectFromButton();
            }

            m_FromButton = io_NewFromButton;
            io_NewFromButton.BackColor = r_HighlightButtonColor;
            m_PossiblePieceTurns = r_GameEngine.AI.GetAllPossibleTurns(pieceAtButton(io_NewFromButton));
            if (m_ShowPossibleMovesOfPiece)
            {
                showPossibleMovesOfPiece();
            }
        }

        private bool validButtonToMoveFrom(BoardButton i_Button)
        {
            Piece pieceAtButton = r_GameEngine.Board.GetPiece(i_Button.Col, i_Button.Row);

            return r_GameEngine.PieceCanValidMoveByRules(pieceAtButton);
        }

        private void showPossibleMovesOfPiece()
        {
            if (m_PossiblePieceTurns != null)
            {
                foreach (LinkedList<MoveParameters> turn in m_PossiblePieceTurns)
                {
                    MoveParameters firstMove = turn.First.Value;
                    BoardButton toButton = m_ButtonMatrix[firstMove.ToPoint.Row, firstMove.ToPoint.Col];
                    toButton.BackColor = r_PossibleMoveColor;
                }
            }
        }

        private void hidePossibleMoves()
        {
            if (m_PossiblePieceTurns != null)
            {
                foreach (LinkedList<MoveParameters> turn in m_PossiblePieceTurns)
                {
                    MoveParameters firstMove = turn.First.Value;
                    BoardButton toButton = m_ButtonMatrix[firstMove.ToPoint.Row, firstMove.ToPoint.Col];
                    toButton.BackColor = r_PlayableButtonColor;
                }
            }
        }

        private void tryMove()
        {
            MoveParameters humanMove = new MoveParameters(m_FromButton.BoardPoint, m_ToButton.BoardPoint);

            m_FromButton.BackColor = r_PlayableButtonColor;
            m_FromButton = null;
            m_ToButton = null;
            hidePiecesThatCanMove();
            m_PiecesThatCanMoveList = null;
            if (r_GameEngine.TryMove(humanMove) == false)
            {
                showInvalidMoveMessage();
                if (m_ShowPiecesThatCanMove)
                {
                    showPiecesThatCanMove();
                }
            }
            else
            {
                disableForfeitButton();
                if (BotAnimation != null)
                {
                    BotAnimation.Invoke();
                }
                else
                {
                    // Top might be computer - check for its potential moves.
                    TopAnimation?.Invoke();
                }
            }
        }

        private void m_ButtonForfeit_Click(object i_Sender, EventArgs i_EventArgs)
        {
            const string k_ForfeitMsg = "Are you sure you want to forfeit? Like some craven?";
            DialogResult dialogResult = MessageBox.Show(k_ForfeitMsg, @"Forfeit", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                disableForfeitButton();
                GameEngine.Forfeit();
                MatchEnded?.Invoke();
            }
        }

        private void m_GameEngine_PlayerScoreChanged()
        {
            m_LabelPlayer1Score.Text = r_GameEngine.BottomPlayer.TotalScore.ToString();
            m_LabelPlayer2Score.Text = r_GameEngine.TopPlayer.TotalScore.ToString();
        }

        private void m_GameEngine_GameStateChanged()
        {
            if (r_GameEngine.GameState != GameEngine.eGameState.Ongoing)
            {
                MatchEnded += matchEndMessage;
            }
        }

        private void r_GameEngine_AdvancedTurn()
        {
            if (GameEngine.CurrentTurnPlayer().Side == GameEngine.eSide.Top)
            {
                r_SideToHighlight.AddLast(GameEngine.eSide.Top);
            }
            else
            {
                r_SideToHighlight.AddLast(GameEngine.eSide.Bot);
            }
        }

        private void resetGame()
        {
            disableForfeitButton();
            r_CapturedListTop.Clear();
            r_CapturedListBottom.Clear();
            TopAnimation = null;
            BotAnimation = null;
            MatchEnded = null;
            hidePossibleMoves();
            hidePiecesThatCanMove();
            m_PossiblePieceTurns = null;
            if (m_FromButton != null)
            {
                m_FromButton.BackColor = r_PlayableButtonColor;
                m_FromButton = null;
            }

            highlightNextPlayer();
            r_GameEngine.ResetGame();
            enableForfeitButton();
            if (GameEngine.GameMode == GameEngine.eGameMode.SinglePlayer)
            {
                // Top player might be the computer - check if performed any moves.
                if (TopAnimation != null)
                {
                    disableForfeitButton();
                    TopAnimation?.Invoke();
                }
            }

            if (m_CheckBoxShowPiecesThatCanMove.Checked)
            {
                showPiecesThatCanMove();
            }
        }

        private void m_CheckBoxShowMovesOfPiece_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
        {
            m_ShowPossibleMovesOfPiece = m_CheckBoxShowMovesOfPiece.Checked;
            if (m_ShowPossibleMovesOfPiece)
            {
                showPossibleMovesOfPiece();
            }
            else
            {
                hidePossibleMoves();
            }
        }

        private void m_CheckBoxShowPiecesThatCanMove_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
        {
            m_ShowPiecesThatCanMove = m_CheckBoxShowPiecesThatCanMove.Checked;
            if (m_ShowPiecesThatCanMove)
            {
                showPiecesThatCanMove();
            }
            else
            {
                hidePiecesThatCanMove();
            }
        }

        private void showPiecesThatCanMove()
        {
            m_PiecesThatCanMoveList = r_GameEngine.PlayablePieces(r_GameEngine.CurrentTurnPlayer());
            if (m_PiecesThatCanMoveList != null)
            {
                foreach (Piece piece in m_PiecesThatCanMoveList)
                {
                    if (piece.Location != null)
                    {
                        BoardPoint piecePoint = new BoardPoint(piece.Location.Value.Col, piece.Location.Value.Row);

                        m_ButtonMatrix[piecePoint.Row, piecePoint.Col].BackColor = r_PieceCanMoveColor;
                    }
                }
            }

            if (m_FromButton != null)
            {
                m_FromButton.BackColor = r_HighlightButtonColor;
            }
        }

        private void hidePiecesThatCanMove()
        {
            if (m_PiecesThatCanMoveList != null)
            {
                foreach (Piece piece in m_PiecesThatCanMoveList)
                {
                    if (piece.Location != null)
                    {
                        BoardPoint piecePoint = new BoardPoint(piece.Location.Value.Col, piece.Location.Value.Row);

                        m_ButtonMatrix[piecePoint.Row, piecePoint.Col].BackColor = r_PlayableButtonColor;
                    }
                }

                if (m_FromButton != null)
                {
                    m_FromButton.BackColor = r_HighlightButtonColor;
                }
            }
        }

        private void matchEndMessage()
        {
            MatchEnded -= matchEndMessage;
            StringBuilder message = new StringBuilder();

            if (r_GameEngine.GameState == GameEngine.eGameState.Tie)
            {
                message.Append("Tie!");
            }
            else
            {
                message.Append($"{r_GameEngine.Winner.Name} has won!");
                if (r_GameEngine.GameState == GameEngine.eGameState.Forfeit)
                {
                    message.Append($"{Environment.NewLine}{r_GameEngine.Loser.Name} has forfeit the match out of cowardice.");
                }
            }

            message.Append($"{Environment.NewLine}Another round?");
            DialogResult result = MessageBox.Show(message.ToString(), @"Match Over", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                resetGame();
            }
            else
            {
                // Optional goodbye message here, if it's not too much. As part of another program, it's unnecessary.
                Close();
            }
        }

        private void showInvalidMoveMessage()
        {
            Player player = r_GameEngine.CurrentTurnPlayer();
            string errorMessage;

            if (r_GameEngine.IsOngoingCapture())
            {
                errorMessage = "Multiple capture! Player must continue capturing.";
            }
            else if (r_GameEngine.CanPlayerMoveCapture(player))
            {
                errorMessage = "Player can capture - must perform a capture move.";
            }
            else
            {
                errorMessage = "Invalid move, fool!";
            }

            MessageBox.Show(errorMessage);
        }

        public void FinishedPartMove(PiecePictureBox i_Piece)
        {
            LinkedList<PiecePictureBox> capturedList =
                i_Piece.Side == GameEngine.eSide.Top ? r_CapturedListBottom : r_CapturedListTop;

            removeNextCapturedPieceInList(capturedList, i_Piece);
            if (m_ShowPiecesThatCanMove && r_GameMode == GameEngine.eGameMode.MultiPlayer)
            {
                showPiecesThatCanMove();
            }
        }

        public void FinishedMoveAnimation(PiecePictureBox i_Piece)
        {
            disableForfeitButton();
            Action animationToCheck = i_Piece.Side == GameEngine.eSide.Top ? BotAnimation : TopAnimation;

            if (animationToCheck != null)
            {
                highlightNextPlayer();
                animationToCheck.Invoke();
            }
            else if (MatchEnded != null)
            {
                MatchEnded.Invoke();
            }
            else
            {
                enableForfeitButton();
                highlightNextPlayer();
                if (m_CheckBoxShowPiecesThatCanMove.Checked)
                {
                    showPiecesThatCanMove();
                }
            }
        }

        private void highlightNextPlayer()
        {
            if (r_SideToHighlight.Count > 0)
            {
                GameEngine.eSide sideToHighlight = r_SideToHighlight.First();

                r_SideToHighlight.RemoveFirst();
                if (sideToHighlight == GameEngine.eSide.Top)
                {
                    highlightTopPlayerLabel();
                }
                else
                {
                    highlightBottomPlayerLabel();
                }
            }
            else
            {
                if (r_GameEngine.CurrentTurnPlayer().Side == GameEngine.eSide.Top)
                {
                    highlightTopPlayerLabel();
                }
                else
                {
                    highlightBottomPlayerLabel();
                }
            }
        }

        private void highlightTopPlayerLabel()
        {
            m_LabelPlayerTurn.Text = $@"{r_GameEngine.TopPlayer.Name}'s turn";
            m_LabelPlayerTurn.BackColor = PiecePictureBox.TopColor;
            m_LabelPlayerTurn.ForeColor = DefaultForeColor;
        }

        private void highlightBottomPlayerLabel()
        {
            m_LabelPlayerTurn.Text = $@"{r_GameEngine.BottomPlayer.Name}'s turn";
            m_LabelPlayerTurn.BackColor = PiecePictureBox.BottomColor;
            m_LabelPlayerTurn.ForeColor = Color.White;
        }

        private void disableForfeitButton()
        {
            m_ButtonForfeit.Enabled = false;
            m_ButtonForfeit.BackColor = Color.DarkGray;
        }

        private void enableForfeitButton()
        {
            m_ButtonForfeit.Enabled = true;
            m_ButtonForfeit.BackColor = DefaultBackColor;
        }

        private void removeNextCapturedPieceInList(LinkedList<PiecePictureBox> io_CapturedList, PiecePictureBox i_Piece)
        {
            if (io_CapturedList.Count > 0)
            {
                PiecePictureBox capturedPiece = io_CapturedList.First();

                if (capturedPiece != i_Piece)
                {
                    capturedPiece.Visible = false;
                    do
                    {
                        io_CapturedList.Remove(capturedPiece);
                    }
                    while (io_CapturedList.Contains(capturedPiece));
                }
            }
        }

        public bool PieceInLastRow(PiecePictureBox i_PiecePictureBox)
        {
            bool lastRow;
            Button lastRowButton;

            if (i_PiecePictureBox.Side == GameEngine.eSide.Top)
            {
                lastRowButton = m_ButtonMatrix[(int)r_BoardSize - 1, 0];
                lastRow = lastRowButton.Location.Y <= i_PiecePictureBox.Location.Y;
            }
            else
            {
                lastRowButton = m_ButtonMatrix[0, 0];
                Button beforeLastRowButton = m_ButtonMatrix[1, 0];

                lastRow = lastRowButton.Location.Y <= i_PiecePictureBox.Location.Y
                    && beforeLastRowButton.Location.Y > i_PiecePictureBox.Location.Y;
            }

            return lastRow;
        }

        private Piece pieceAtButton(BoardButton i_Button)
        {
            return r_GameEngine.Board.GetPiece(i_Button.Col, i_Button.Row);
        }
    }
}