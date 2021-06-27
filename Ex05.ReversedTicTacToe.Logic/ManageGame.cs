namespace Ex05.ReversedTicTacToe.Logic
{
    public class ManageGame
    {
        private GameBoard m_GameBoard;
        private Player m_PlayerOne;
        private Player m_PlayerTwo;
        private Player m_CurrentPlayer;
        private ComputerAI m_Computer;
        private int m_CountMoves;

        public enum eGameMode
        {
            AgainstPlayer,
            AgainstComputer
        }

        public ManageGame(Player i_PlayerOne, Player i_PlayerTwo)
        {
            m_CountMoves = 0;
            m_CurrentPlayer = null;
            m_PlayerOne = i_PlayerOne;
            m_PlayerTwo = i_PlayerTwo;
            m_Computer = new ComputerAI();
        }

        public Player PlayerOne
        {
            get
            {
                return m_PlayerOne;
            }
        }

        public Player PlayerTwo
        {
            get
            {
                return m_PlayerTwo;
            }
        }

        public Player CurrentPlayer
        {
            get
            {
                return m_CurrentPlayer;
            }

            set
            {
                m_CurrentPlayer = value;
            }
        }

        public void PlayerMakesMove(Player i_CurrentPlayer)
        {
            m_CountMoves++;
            m_CurrentPlayer = i_CurrentPlayer;
        }

        public void ComputerMakesMove(out int o_Row, out int o_Col)
        {
            m_CountMoves++;
            m_CurrentPlayer = m_PlayerTwo;
            m_Computer.MakeSmartMove(ref m_GameBoard, GameBoard.eSymbols.SymbolO, out o_Row, out o_Col);
        }

        public bool IsGameOver(out string o_Result)
        {
            o_Result = string.Empty;
            bool isOver = false;

            if (m_CurrentPlayer != null)
            {
                GameBoard.eSymbols playerSymbol = m_CurrentPlayer.PlayerSymbol;

                if (m_GameBoard.IsFoundSeries(playerSymbol))
                {
                    o_Result = "A Win!";

                    if (m_CurrentPlayer == m_PlayerOne)
                    {
                        m_PlayerTwo.PlayerScore++;
                    }
                    else
                    {
                        m_PlayerOne.PlayerScore++;
                    }

                    isOver = true;
                }
            }

            if (!isOver && m_GameBoard.IsBoardFull(m_CountMoves))
            {
                isOver = true;
                o_Result = "A Tie!";
            }

            return isOver;
        }

        public void NewRound()
        {
            m_CountMoves = 0;
            SetNewBoard(m_GameBoard.Rows, m_GameBoard.Columns);
        }

        public void UpdateCell(int i_Row, int i_Col, GameBoard.eSymbols i_Symbol)
        {
            m_GameBoard.SetCellToSymbol(i_Row, i_Col, i_Symbol);
        }

        public void SetNewBoard(int i_Rows, int i_Columns)
        {
            m_GameBoard = new GameBoard(i_Rows, i_Columns);
        }
    }
}