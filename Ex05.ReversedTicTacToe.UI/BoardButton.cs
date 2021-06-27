using System.Drawing;
using System.Windows.Forms;

namespace Ex05.ReversedTicTacToe.UI
{
    internal class BoardButton : Button
    {
        private Point r_LocationInBoard;

        public BoardButton(int i_PointX, int i_PointY) : base()
        {
            r_LocationInBoard = new Point(i_PointX, i_PointY);
        }

        public int X
        {
            get
            {
                return r_LocationInBoard.X;
            }
        }

        public int Y
        {
            get
            {
                return r_LocationInBoard.Y;
            }
        }

        public Point LocationInBoard
        {
            get
            {
                return r_LocationInBoard;
            }
        }

        public void SetButton()
        {
            Enabled = true;
            Text = string.Empty;
            BackColor = Color.CornflowerBlue;
            Font = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Bold);
        }
    }
}