using System.Windows.Forms;
using CheckersLogic;

namespace CheckersUIWindows
{
    public partial class BoardButton : Button
    {
        private static readonly int sr_ButtonSize = 55;
        private readonly int r_Row;
        private readonly int r_Col;

        public BoardButton(int i_Row, int i_Col)
        {
            Size = new System.Drawing.Size(sr_ButtonSize, sr_ButtonSize);
            r_Row = i_Row;
            r_Col = i_Col;
            TabStop = false;
        }

        public static int ButtonSize
        {
            get
            {
                return sr_ButtonSize;
            }
        }

        public int Row
        {
            get
            {
                return r_Row;
            }
        }

        public int Col
        {
            get
            {
                return r_Col;
            }
        }

        public BoardPoint BoardPoint
        {
            get
            {
                return new BoardPoint(r_Col, r_Row);
            }
        }
    }
}
