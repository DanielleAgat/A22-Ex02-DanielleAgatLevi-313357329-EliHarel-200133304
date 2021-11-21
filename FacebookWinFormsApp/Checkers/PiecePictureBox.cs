using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CheckersLogic;

namespace CheckersUIWindows
{
    public partial class PiecePictureBox : PictureBox
    {
        private const int k_SizeDifferenceButtonPicture = 5;
        private static readonly Color sr_TopColor = Color.Red;
        private static readonly Color sr_BottomColor = Color.Black;
        private readonly int r_ButtonPictureSizeDifference;
        private readonly FormBoard r_FormBoard;
        private readonly Piece r_CorrespondingPieceInLogic;
        private readonly GameEngine.eSide r_Side;
        private readonly LinkedList<Point> r_NextButtonLocationList;
        private Point m_NextButtonLocation;
        private bool m_SignedToAnimation;

        public PiecePictureBox(Piece i_Piece, FormBoard i_FormBoard)
        {
            r_NextButtonLocationList = new LinkedList<Point>();
            r_CorrespondingPieceInLogic = i_Piece;
            r_FormBoard = i_FormBoard;
            r_Side = i_Piece.Side;
            i_Piece.ChangedCapturedState += piece_ChangedCapturedState;
            i_Piece.Moved += piece_Moved;
            i_Piece.ResetPiece += i_Piece_ResetPiece;
            int pictureBoxSize = BoardButton.ButtonSize - k_SizeDifferenceButtonPicture;

            Size = new Size(pictureBoxSize, pictureBoxSize);
            SizeMode = PictureBoxSizeMode.StretchImage;
            int buttonSize = BoardButton.ButtonSize;

            if (pictureBoxSize <= buttonSize)
            {
                r_ButtonPictureSizeDifference = (buttonSize - pictureBoxSize) / 2;
            }

            setPicture(i_Piece);
            Visible = true;
            Enabled = false;
            makeIntoCircle();
        }

        private void makeIntoCircle()
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            gp.AddEllipse(0, 0, Width - 3, Height - 3);
            Region rg = new Region(gp);

            Region = rg;
        }

        public static Color TopColor
        {
            get
            {
                return sr_TopColor;
            }
        }

        public static Color BottomColor
        {
            get
            {
                return sr_BottomColor;
            }
        }

        public GameEngine.eSide Side
        {
            get
            {
                return r_Side;
            }
        }

        private void setPicture(Piece i_Piece)
        {
            if (i_Piece != null)
            {
                if (i_Piece.Side == GameEngine.eSide.Top)
                {
                    if (i_Piece.Type == Piece.eType.Man)
                    {
                        Image = BasicFacebookFeatures.Properties.Resources.RedMan;

                    }
                    else
                    {
                        Image = BasicFacebookFeatures.Properties.Resources.RedKing;
                    }
                }
                else
                {
                    if (i_Piece.Type == Piece.eType.Man)
                    {
                        Image = BasicFacebookFeatures.Properties.Resources.BlackMan;
                    }
                    else
                    {
                        Image = BasicFacebookFeatures.Properties.Resources.BlackKing;
                    }
                }
            }
        }

        private void i_Piece_ResetPiece(Piece i_Piece)
        {
            if (i_Piece.Location != null)
            {
                int row = i_Piece.Location.Value.Row;
                int col = i_Piece.Location.Value.Col;
                Point locationOfNewButton = r_FormBoard.ButtonMatrix[row, col].Location;

                locationOfNewButton.X += r_ButtonPictureSizeDifference;
                locationOfNewButton.Y += r_ButtonPictureSizeDifference;
                Location = locationOfNewButton;
            }

            BringToFront();
            Visible = true;
            setPicture(i_Piece);
        }

        private void piece_Moved(Piece i_Piece)
        {
            if (i_Piece.Location.HasValue == false)
            {
                Visible = false;
            }
            else
            {
                addNewLocationToList(i_Piece);
                if (!m_SignedToAnimation)
                {
                    m_SignedToAnimation = true;
                    if (r_Side == GameEngine.eSide.Top)
                    {
                        r_FormBoard.TopAnimation += turnTimeOn;
                    }
                    else
                    {
                        r_FormBoard.BotAnimation += turnTimeOn;
                    }
                }
            }
        }

        private void addNewLocationToList(Piece i_Piece)
        {
            if (i_Piece?.Location != null)
            {
                int newLocationRow = i_Piece.Location.Value.Row;
                int newLocationCol = i_Piece.Location.Value.Col;
                Point nextButtonLocation = r_FormBoard.ButtonMatrix[newLocationRow, newLocationCol].Location;

                nextButtonLocation.X += r_ButtonPictureSizeDifference;
                nextButtonLocation.Y += r_ButtonPictureSizeDifference;
                r_NextButtonLocationList.AddLast(nextButtonLocation);
            }
        }

        private void turnTimeOn()
        {
            BringToFront();
            m_NextButtonLocation = r_NextButtonLocationList.First();
            r_NextButtonLocationList.RemoveFirst();
            r_FormBoard.Timer.Tick += m_Timer_Tick;
            r_FormBoard.Timer.Start();
        }

        private void m_Timer_Tick(object i_Sender, EventArgs i_EventArgs)
        {
            if (Location == m_NextButtonLocation)
            {
                r_FormBoard.Timer.Stop();
                if (r_FormBoard.PieceInLastRow(this))
                {
                    setPicture(r_CorrespondingPieceInLogic);
                }

                r_FormBoard.FinishedPartMove(this);
                if (r_NextButtonLocationList.Count > 0)
                {
                    m_NextButtonLocation = r_NextButtonLocationList.First();
                    r_NextButtonLocationList.RemoveFirst();
                    r_FormBoard.Timer.Start();
                }
                else
                {
                    r_FormBoard.Timer.Tick -= m_Timer_Tick;
                    if (r_Side == GameEngine.eSide.Top)
                    {
                        r_FormBoard.TopAnimation -= turnTimeOn;
                    }
                    else
                    {
                        r_FormBoard.BotAnimation -= turnTimeOn;
                    }

                    m_SignedToAnimation = false;
                    r_FormBoard.FinishedMoveAnimation(this);
                }
            }
            else
            {
                bringLocationCloserToDestination();
            }
        }

        private void bringLocationCloserToDestination()
        {
            const int k_AnimationPixelJump = 3;
            int newXOrYValue;
            int pixelDifference;

            if (Location.X < m_NextButtonLocation.X)
            {
                if (Location.X + k_AnimationPixelJump <= m_NextButtonLocation.X)
                {
                    newXOrYValue = Location.X + k_AnimationPixelJump;
                }
                else
                {
                    pixelDifference = m_NextButtonLocation.X - Location.X;
                    newXOrYValue = Location.X + pixelDifference;
                }

                Location = new Point(newXOrYValue, Location.Y);
            }

            if (Location.X > m_NextButtonLocation.X)
            {
                if (Location.X - k_AnimationPixelJump >= m_NextButtonLocation.X)
                {
                    newXOrYValue = Location.X - k_AnimationPixelJump;
                }
                else
                {
                    pixelDifference = Location.X - m_NextButtonLocation.X;
                    newXOrYValue = Location.X - pixelDifference;
                }

                Location = new Point(newXOrYValue, Location.Y);
            }

            if (Location.Y < m_NextButtonLocation.Y)
            {
                if (Location.Y + k_AnimationPixelJump <= m_NextButtonLocation.Y)
                {
                    newXOrYValue = Location.Y + k_AnimationPixelJump;
                }
                else
                {
                    pixelDifference = m_NextButtonLocation.Y - Location.Y;
                    newXOrYValue = Location.Y + pixelDifference;
                }

                Location = new Point(Location.X, newXOrYValue);
            }

            if (Location.Y > m_NextButtonLocation.Y)
            {
                if (Location.Y - k_AnimationPixelJump >= m_NextButtonLocation.Y)
                {
                    newXOrYValue = Location.Y - k_AnimationPixelJump;
                }
                else
                {
                    pixelDifference = Location.Y - m_NextButtonLocation.Y;
                    newXOrYValue = Location.Y - pixelDifference;
                }

                Location = new Point(Location.X, newXOrYValue);
            }
        }

        private void piece_ChangedCapturedState(Piece i_Piece)
        {
            if (i_Piece.Captured)
            {
                if (Side == GameEngine.eSide.Top)
                {
                    r_FormBoard.CapturedListTop.AddLast(this);
                }
                else
                {
                    r_FormBoard.CapturedListBottom.AddLast(this);
                }
            }
            else
            {
                Visible = true;
                if (Side == GameEngine.eSide.Top)
                {
                    r_FormBoard.CapturedListTop.Remove(this);
                }
                else
                {
                    r_FormBoard.CapturedListBottom.Remove(this);
                }
            }
        }
    }
}