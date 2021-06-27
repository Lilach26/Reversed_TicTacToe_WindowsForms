namespace Ex05.ReversedTicTacToe.UI
{
    public partial class GameSettingsForm
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
            this.playersLabel = new System.Windows.Forms.Label();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.playerOneTextBox = new System.Windows.Forms.TextBox();
            this.playerTwoTextBox = new System.Windows.Forms.TextBox();
            this.playerTwoCheckBox = new System.Windows.Forms.CheckBox();
            this.boardSizeLabel = new System.Windows.Forms.Label();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.colsLabel = new System.Windows.Forms.Label();
            this.rowsNumeric = new System.Windows.Forms.NumericUpDown();
            this.colsNumeric = new System.Windows.Forms.NumericUpDown();
            this.startGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // playersLabel
            // 
            this.playersLabel.AutoSize = true;
            this.playersLabel.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.playersLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.playersLabel.Location = new System.Drawing.Point(11, 31);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(136, 36);
            this.playersLabel.TabIndex = 0;
            this.playersLabel.Text = "Players:";
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.playerOneLabel.Location = new System.Drawing.Point(60, 101);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(119, 29);
            this.playerOneLabel.TabIndex = 1;
            this.playerOneLabel.Text = "Player 1:";
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.playerTwoLabel.Location = new System.Drawing.Point(60, 149);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(119, 29);
            this.playerTwoLabel.TabIndex = 2;
            this.playerTwoLabel.Text = "Player 2:";
            // 
            // playerOneTextBox
            // 
            this.playerOneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneTextBox.Location = new System.Drawing.Point(189, 102);
            this.playerOneTextBox.Name = "playerOneTextBox";
            this.playerOneTextBox.Size = new System.Drawing.Size(199, 27);
            this.playerOneTextBox.TabIndex = 3;
            // 
            // playerTwoTextBox
            // 
            this.playerTwoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoTextBox.Location = new System.Drawing.Point(189, 149);
            this.playerTwoTextBox.Name = "playerTwoTextBox";
            this.playerTwoTextBox.Size = new System.Drawing.Size(199, 27);
            this.playerTwoTextBox.TabIndex = 4;
            // 
            // playerTwoCheckBox
            // 
            this.playerTwoCheckBox.AutoSize = true;
            this.playerTwoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoCheckBox.Location = new System.Drawing.Point(36, 155);
            this.playerTwoCheckBox.Name = "playerTwoCheckBox";
            this.playerTwoCheckBox.Size = new System.Drawing.Size(18, 17);
            this.playerTwoCheckBox.TabIndex = 5;
            this.playerTwoCheckBox.UseVisualStyleBackColor = true;
            this.playerTwoCheckBox.CheckedChanged += new System.EventHandler(this.playerTwoCheckBox_CheckedChanged);
            // 
            // boardSizeLabel
            // 
            this.boardSizeLabel.AutoSize = true;
            this.boardSizeLabel.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boardSizeLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.boardSizeLabel.Location = new System.Drawing.Point(12, 241);
            this.boardSizeLabel.Name = "boardSizeLabel";
            this.boardSizeLabel.Size = new System.Drawing.Size(148, 29);
            this.boardSizeLabel.TabIndex = 6;
            this.boardSizeLabel.Text = "Board Size:";
            // 
            // rowsLabel
            // 
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rowsLabel.Location = new System.Drawing.Point(61, 296);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(72, 24);
            this.rowsLabel.TabIndex = 7;
            this.rowsLabel.Text = "Rows:";
            // 
            // colsLabel
            // 
            this.colsLabel.AutoSize = true;
            this.colsLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colsLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.colsLabel.Location = new System.Drawing.Point(223, 294);
            this.colsLabel.Name = "colsLabel";
            this.colsLabel.Size = new System.Drawing.Size(103, 24);
            this.colsLabel.TabIndex = 8;
            this.colsLabel.Text = "Columns:";
            // 
            // rowsNumeric
            // 
            this.rowsNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowsNumeric.Location = new System.Drawing.Point(150, 293);
            this.rowsNumeric.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.rowsNumeric.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.rowsNumeric.Name = "rowsNumeric";
            this.rowsNumeric.Size = new System.Drawing.Size(55, 27);
            this.rowsNumeric.TabIndex = 9;
            this.rowsNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.rowsNumeric.ValueChanged += new System.EventHandler(this.rowsNumeric_ValueChanged);
            // 
            // colsNumeric
            // 
            this.colsNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colsNumeric.Location = new System.Drawing.Point(341, 293);
            this.colsNumeric.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.colsNumeric.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.colsNumeric.Name = "colsNumeric";
            this.colsNumeric.Size = new System.Drawing.Size(57, 27);
            this.colsNumeric.TabIndex = 10;
            this.colsNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.colsNumeric.ValueChanged += new System.EventHandler(this.colsNumeric_ValueChanged);
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.startGameButton.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startGameButton.Location = new System.Drawing.Point(127, 356);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(209, 70);
            this.startGameButton.TabIndex = 11;
            this.startGameButton.Text = "Start!";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // GameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(450, 452);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.colsNumeric);
            this.Controls.Add(this.rowsNumeric);
            this.Controls.Add(this.colsLabel);
            this.Controls.Add(this.rowsLabel);
            this.Controls.Add(this.boardSizeLabel);
            this.Controls.Add(this.playerTwoCheckBox);
            this.Controls.Add(this.playerTwoTextBox);
            this.Controls.Add(this.playerOneTextBox);
            this.Controls.Add(this.playerTwoLabel);
            this.Controls.Add(this.playerOneLabel);
            this.Controls.Add(this.playersLabel);
            this.Name = "GameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reversed Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playersLabel;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.TextBox playerOneTextBox;
        private System.Windows.Forms.TextBox playerTwoTextBox;
        private System.Windows.Forms.CheckBox playerTwoCheckBox;
        private System.Windows.Forms.Label boardSizeLabel;
        private System.Windows.Forms.Label rowsLabel;
        private System.Windows.Forms.Label colsLabel;
        private System.Windows.Forms.NumericUpDown rowsNumeric;
        private System.Windows.Forms.NumericUpDown colsNumeric;
        private System.Windows.Forms.Button startGameButton;
    }
}