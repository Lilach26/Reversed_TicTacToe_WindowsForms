namespace Ex05.ReversedTicTacToe.UI
{
    public partial class GameBoardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerOneScoreLabel = new System.Windows.Forms.Label();
            this.playerTwoScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerOneScoreLabel
            // 
            this.playerOneScoreLabel.AutoSize = true;
            this.playerOneScoreLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneScoreLabel.Location = new System.Drawing.Point(128, 456);
            this.playerOneScoreLabel.Name = "playerOneScoreLabel";
            this.playerOneScoreLabel.Size = new System.Drawing.Size(70, 18);
            this.playerOneScoreLabel.TabIndex = 0;
            this.playerOneScoreLabel.Text = "Score 1:";
            // 
            // playerTwoScoreLabel
            // 
            this.playerTwoScoreLabel.AutoSize = true;
            this.playerTwoScoreLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoScoreLabel.Location = new System.Drawing.Point(387, 456);
            this.playerTwoScoreLabel.Name = "playerTwoScoreLabel";
            this.playerTwoScoreLabel.Size = new System.Drawing.Size(70, 18);
            this.playerTwoScoreLabel.TabIndex = 1;
            this.playerTwoScoreLabel.Text = "Score 2:";
            // 
            // GameBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 485);
            this.Controls.Add(this.playerTwoScoreLabel);
            this.Controls.Add(this.playerOneScoreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GameBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reversed Tic Tac Toe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gameBoardForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerOneScoreLabel;
        private System.Windows.Forms.Label playerTwoScoreLabel;
    }
}