using System;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Ex05.ReversedTicTacToe.Logic;

namespace Ex05.ReversedTicTacToe.UI
{
    public partial class GameBoardForm : Form
    {
        private readonly GameSettingsForm r_GameSettingsForm = new GameSettingsForm();
        private readonly BoardButton[,] r_BoardButtons;
        private readonly ManageGame r_ManageGame;
        private readonly ManageGame.eGameMode r_GameMode;
        private readonly int r_Rows;
        private readonly int r_Cols;
        private Player m_CurrentPlayer;

        public GameBoardForm()
        {
            InitializeComponent();

            if (r_GameSettingsForm.ShowDialog() == DialogResult.OK)
            {
                r_Rows = r_GameSettingsForm.NumOfRows;
                r_Cols = r_GameSettingsForm.NumOfCols;
                r_BoardButtons = new BoardButton[r_Rows, r_Cols];
                r_GameMode = r_GameSettingsForm.IsPlayerTwo ? ManageGame.eGameMode.AgainstPlayer : ManageGame.eGameMode.AgainstComputer;

                Player playerOne = new Player(r_GameSettingsForm.PlayerOneName, GameBoard.eSymbols.SymbolX);
                Player playerTwo = new Player(r_GameSettingsForm.PlayerTwoName, GameBoard.eSymbols.SymbolO);
                r_ManageGame = new ManageGame(playerOne, playerTwo);

                r_ManageGame.SetNewBoard(r_Rows, r_Cols);
                createBoard();
                m_CurrentPlayer = r_ManageGame.PlayerOne;
                newRound();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void createBoard()
        {
            int buttonWidth = 70, buttonHeight = 70, width = 0, buttonsSpace = 10;
            int xSpace = buttonsSpace, ySpace = buttonsSpace, labelPlayerOneX = 0;

            for (int i = 0; i < r_Rows; i++)
            {
                for (int j = 0; j < r_Cols; j++)
                {
                    BoardButton buttonToAdd = new BoardButton(i, j);
                    buttonToAdd.Size = new Size(buttonWidth, buttonHeight);
                    buttonToAdd.Location = new Point(xSpace, ySpace);

                    r_BoardButtons[i, j] = buttonToAdd;
                    Controls.Add(buttonToAdd);
                    buttonToAdd.Click += button_Click;
                    xSpace += buttonWidth + buttonsSpace;
                }

                width = xSpace;
                ySpace += buttonHeight + buttonsSpace;
                xSpace = buttonsSpace;
            }

            Size = new Size(width + (buttonsSpace * 2), ySpace + buttonHeight + 10);
            labelPlayerOneX = r_BoardButtons[0, (r_Cols - 1) / 2].Location.X - (buttonWidth / 2);

            playerOneScoreLabel.Location = new Point(labelPlayerOneX, ClientSize.Height - playerOneScoreLabel.Height);
            playerTwoScoreLabel.Location = new Point(playerOneScoreLabel.Location.X + playerOneScoreLabel.Width + 20, ClientSize.Height - playerTwoScoreLabel.Height);
        }

        private void button_Click(object sender, EventArgs e)
        {
            BoardButton boardButton = sender as BoardButton;

            r_ManageGame.UpdateCell(boardButton.X, boardButton.Y, m_CurrentPlayer.PlayerSymbol);
            r_ManageGame.PlayerMakesMove(m_CurrentPlayer);
            boardButton.Text = convertSymbolToString(m_CurrentPlayer.PlayerSymbol);
            boardButton.Enabled = false;

            if (!isGameOver())
            {
                switchTurns();

                if (r_GameMode == ManageGame.eGameMode.AgainstComputer)
                {
                    computerMove();
                }
            }
        }

        private void newRound()
        {
            foreach (BoardButton boardButton in r_BoardButtons)
            {
                boardButton.SetButton();
            }

            playerOneScoreLabel.Text = string.Format("{0} : {1}", r_ManageGame.PlayerOne.PlayerName, r_ManageGame.PlayerOne.PlayerScore);
            playerTwoScoreLabel.Text = string.Format("{0} : {1}", r_ManageGame.PlayerTwo.PlayerName, r_ManageGame.PlayerTwo.PlayerScore);
            r_ManageGame.NewRound();
            m_CurrentPlayer = r_ManageGame.PlayerOne;
        }

        private bool isGameOver()
        {
            string result = string.Empty;
            bool isOver = false;

            if (r_ManageGame.IsGameOver(out result))
            {
                isOver = true;
                checkForAnotherRound(result);
            }

            return isOver;
        }

        private void computerMove()
        {
            int chosenRow = -1, chosenCol = -1;

            Thread.Sleep(300);
            r_ManageGame.ComputerMakesMove(out chosenRow, out chosenCol);
            
            BoardButton currentButton = r_BoardButtons[chosenRow, chosenCol];
            currentButton.Enabled = false;
            currentButton.Text = convertSymbolToString(m_CurrentPlayer.PlayerSymbol);

            if (!isGameOver())
            {
                switchTurns();
            }
        }

        private string gameResults(string i_GameResult)
        {
            StringBuilder result = new StringBuilder();

            switch (i_GameResult)
            {
                case "A Win!":
                    result.Append("The Winner is: ").AppendFormat("{0}", r_ManageGame.CurrentPlayer == r_ManageGame.PlayerOne ? r_ManageGame.PlayerTwo.PlayerName : r_ManageGame.PlayerOne.PlayerName).AppendLine();
                    break;

                case "A Tie!":
                    result.Append("It's a Tie!").AppendLine();
                    break;
            }

            return result.ToString();
        }

        private void checkForAnotherRound(string i_GameResult)
        {
            string gameResult = gameResults(i_GameResult);
            DialogResult dialogResult = MessageBox.Show(string.Format("{0}Would you like to play another round?", gameResult), i_GameResult, MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                newRound();
            }
            else
            {
                MessageBox.Show(string.Format("Hope you enjoyed!{0}Come back later! :)", Environment.NewLine), "Game Over");
                Application.Exit();
            }
        }

        private void switchTurns()
        {
            if (m_CurrentPlayer == r_ManageGame.PlayerOne)
            {
                m_CurrentPlayer = r_ManageGame.PlayerTwo;
            }
            else
            {
                m_CurrentPlayer = r_ManageGame.PlayerOne;
            }
        }

        private string convertSymbolToString(GameBoard.eSymbols i_Symbol)
        {
            string convertedSymbol = string.Empty;

            switch (i_Symbol)
            {
                case GameBoard.eSymbols.SymbolX:
                    convertedSymbol = "X";
                    break;
                case GameBoard.eSymbols.SymbolO:
                    convertedSymbol = "O";
                    break;
            }

            return convertedSymbol;
        }

        private void gameBoardForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
