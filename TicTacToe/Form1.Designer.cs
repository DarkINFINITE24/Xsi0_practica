
namespace TicTacToe
{
    partial class mainForm
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
            this.resetGameButton = new System.Windows.Forms.Button();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.gameSplitContainer = new System.Windows.Forms.SplitContainer();
            this.gameOptionsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.player2TextBox = new System.Windows.Forms.TextBox();
            this.player1TextBox = new System.Windows.Forms.TextBox();
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.resetHistoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameSplitContainer)).BeginInit();
            this.gameSplitContainer.Panel1.SuspendLayout();
            this.gameSplitContainer.Panel2.SuspendLayout();
            this.gameSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameOptionsSplitContainer)).BeginInit();
            this.gameOptionsSplitContainer.Panel1.SuspendLayout();
            this.gameOptionsSplitContainer.Panel2.SuspendLayout();
            this.gameOptionsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resetGameButton
            // 
            this.resetGameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetGameButton.Location = new System.Drawing.Point(7, 6);
            this.resetGameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetGameButton.Name = "resetGameButton";
            this.resetGameButton.Size = new System.Drawing.Size(843, 55);
            this.resetGameButton.TabIndex = 0;
            this.resetGameButton.Text = "Restart";
            this.resetGameButton.UseVisualStyleBackColor = true;
            this.resetGameButton.Click += new System.EventHandler(this.resetGameButton_Click);
            this.resetGameButton.MouseEnter += new System.EventHandler(this.resetGameButton_MouseEnter);
            this.resetGameButton.MouseLeave += new System.EventHandler(this.resetGameButton_MouseLeave);
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gamePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gamePanel.Location = new System.Drawing.Point(198, 40);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(267, 246);
            this.gamePanel.TabIndex = 2;
            this.gamePanel.SizeChanged += new System.EventHandler(this.gamePanel_SizeChanged);
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // gameSplitContainer
            // 
            this.gameSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.gameSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.gameSplitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameSplitContainer.Name = "gameSplitContainer";
            this.gameSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // gameSplitContainer.Panel1
            // 
            this.gameSplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gameSplitContainer.Panel1.Controls.Add(this.gameOptionsSplitContainer);
            // 
            // gameSplitContainer.Panel2
            // 
            this.gameSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gameSplitContainer.Panel2.Controls.Add(this.resetGameButton);
            this.gameSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gameSplitContainer.Size = new System.Drawing.Size(857, 679);
            this.gameSplitContainer.SplitterDistance = 610;
            this.gameSplitContainer.SplitterWidth = 2;
            this.gameSplitContainer.TabIndex = 3;
            // 
            // gameOptionsSplitContainer
            // 
            this.gameOptionsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOptionsSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.gameOptionsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.gameOptionsSplitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameOptionsSplitContainer.Name = "gameOptionsSplitContainer";
            // 
            // gameOptionsSplitContainer.Panel1
            // 
            this.gameOptionsSplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gameOptionsSplitContainer.Panel1.Controls.Add(this.resetHistoryButton);
            this.gameOptionsSplitContainer.Panel1.Controls.Add(this.resultsDataGridView);
            this.gameOptionsSplitContainer.Panel1.Controls.Add(this.player2TextBox);
            this.gameOptionsSplitContainer.Panel1.Controls.Add(this.player1TextBox);
            this.gameOptionsSplitContainer.Panel1.Controls.Add(this.player2Label);
            this.gameOptionsSplitContainer.Panel1.Controls.Add(this.player1Label);
            // 
            // gameOptionsSplitContainer.Panel2
            // 
            this.gameOptionsSplitContainer.Panel2.Controls.Add(this.gamePanel);
            this.gameOptionsSplitContainer.Panel2.Resize += new System.EventHandler(this.gameOptionsSplitContainer_Panel2_Resize);
            this.gameOptionsSplitContainer.Size = new System.Drawing.Size(857, 610);
            this.gameOptionsSplitContainer.SplitterDistance = 200;
            this.gameOptionsSplitContainer.SplitterWidth = 3;
            this.gameOptionsSplitContainer.TabIndex = 0;
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.AllowUserToAddRows = false;
            this.resultsDataGridView.AllowUserToDeleteRows = false;
            this.resultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Location = new System.Drawing.Point(7, 175);
            this.resultsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.ReadOnly = true;
            this.resultsDataGridView.RowHeadersWidth = 51;
            this.resultsDataGridView.Size = new System.Drawing.Size(256, 402);
            this.resultsDataGridView.TabIndex = 4;
            // 
            // player2TextBox
            // 
            this.player2TextBox.Location = new System.Drawing.Point(85, 95);
            this.player2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player2TextBox.Name = "player2TextBox";
            this.player2TextBox.Size = new System.Drawing.Size(132, 22);
            this.player2TextBox.TabIndex = 3;
            this.player2TextBox.Text = "Dorel";
            // 
            // player1TextBox
            // 
            this.player1TextBox.Location = new System.Drawing.Point(85, 38);
            this.player1TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player1TextBox.Name = "player1TextBox";
            this.player1TextBox.Size = new System.Drawing.Size(132, 22);
            this.player1TextBox.TabIndex = 2;
            this.player1TextBox.Text = "Toni";
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Location = new System.Drawing.Point(17, 98);
            this.player2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(60, 17);
            this.player2Label.TabIndex = 1;
            this.player2Label.Text = "Player 2";
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Location = new System.Drawing.Point(17, 42);
            this.player1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(60, 17);
            this.player1Label.TabIndex = 0;
            this.player1Label.Text = "Player 1";
            // 
            // resetHistoryButton
            // 
            this.resetHistoryButton.Location = new System.Drawing.Point(3, 577);
            this.resetHistoryButton.Name = "resetHistoryButton";
            this.resetHistoryButton.Size = new System.Drawing.Size(214, 30);
            this.resetHistoryButton.TabIndex = 5;
            this.resetHistoryButton.Text = "Reset History";
            this.resetHistoryButton.UseVisualStyleBackColor = true;
            this.resetHistoryButton.Click += new System.EventHandler(this.resetHistoryButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 679);
            this.Controls.Add(this.gameSplitContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(527, 481);
            this.Name = "mainForm";
            this.Text = "TIC TAC TOE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.mainForm_ResizeEnd);
            this.gameSplitContainer.Panel1.ResumeLayout(false);
            this.gameSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameSplitContainer)).EndInit();
            this.gameSplitContainer.ResumeLayout(false);
            this.gameOptionsSplitContainer.Panel1.ResumeLayout(false);
            this.gameOptionsSplitContainer.Panel1.PerformLayout();
            this.gameOptionsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameOptionsSplitContainer)).EndInit();
            this.gameOptionsSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resetGameButton;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.SplitContainer gameSplitContainer;
        private System.Windows.Forms.SplitContainer gameOptionsSplitContainer;
        private System.Windows.Forms.TextBox player2TextBox;
        private System.Windows.Forms.TextBox player1TextBox;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.Button resetHistoryButton;
    }
}

