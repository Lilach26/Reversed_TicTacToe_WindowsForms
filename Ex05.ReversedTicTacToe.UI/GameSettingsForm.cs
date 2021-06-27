using System;
using System.Windows.Forms;

namespace Ex05.ReversedTicTacToe.UI
{
    public partial class GameSettingsForm : Form
    {
        private string m_PlayerOneName = string.Empty;
        private string m_PlayerTwoName = "Computer";
        private bool m_IsPlayerTwo = false;
        private int m_NumOfRows;
        private int m_NumOfCols;

        public GameSettingsForm()
        {         
            InitializeComponent();
            playerTwoTextBox.Enabled = false;
            playerTwoTextBox.Text = "Computer";
        }

        public string PlayerOneName
        {
            get
            {
                return m_PlayerOneName;
            }
        }

        public string PlayerTwoName
        {
            get
            {
                return m_PlayerTwoName;
            }
        }

        public bool IsPlayerTwo
        {
            get
            {
                return m_IsPlayerTwo;
            }
        }

        public int NumOfRows
        {
            get
            {
                return m_NumOfRows;
            }
        }

        public int NumOfCols
        {
            get
            {
                return m_NumOfCols;
            }
        }

        private void playerTwoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = playerTwoCheckBox.Checked;

            if (isChecked)
            {
                m_IsPlayerTwo = true;
                playerTwoTextBox.Enabled = true;
                playerTwoTextBox.Text = string.Empty;
            }
            else
            {
                m_IsPlayerTwo = false;
                playerTwoTextBox.Enabled = false;
                playerTwoTextBox.Text = "Computer";
            }
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (playerOneTextBox.Text != string.Empty && playerTwoTextBox.Text != string.Empty)
            {
                m_NumOfRows = (int)rowsNumeric.Value;
                m_NumOfCols = (int)colsNumeric.Value;
                m_PlayerOneName = playerOneTextBox.Text;
                m_IsPlayerTwo = playerTwoCheckBox.Checked;

                if (m_IsPlayerTwo)
                {
                    m_PlayerTwoName = playerTwoTextBox.Text;
                }

                DialogResult = DialogResult.OK;
            }
            else
            {
                if (playerOneTextBox.Text == string.Empty)
                {
                    MessageBox.Show("Please enter Player 1 name!");
                }
                else
                {
                    MessageBox.Show("Please enter player 2 name!");
                }
            }
        }

        private void rowsNumeric_ValueChanged(object sender, EventArgs e)
        {
            colsNumeric.Value = rowsNumeric.Value;
        }

        private void colsNumeric_ValueChanged(object sender, EventArgs e)
        {
            rowsNumeric.Value = colsNumeric.Value;
        }
    }
}