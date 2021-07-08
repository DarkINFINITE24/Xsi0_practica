﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class mainForm : Form
    {
        TicTacToeGame game;
        Label[,] board = new Label[Ct.BoardSize, Ct.BoardSize];
        public mainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            game.Start();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            game = new TicTacToeGame();
            InitBoard();
        }

        private void InitBoard()
        {
            for (int i = 0; i < Ct.BoardSize; i++)
            {
                for (int j = 0; j < Ct.BoardSize; j++)
                {
                    board[i, j] = new Label();

                    board[i, j].Left = Ct.LeftMargin + i * (Ct.CellSize + Ct.CellGap);
                    board[i, j].Top = Ct.TopMargin + j * (Ct.CellSize + Ct.CellGap);
                    board[i, j].Height = Ct.CellSize;
                    board[i, j].Width = Ct.CellSize;

                    board[i, j].Font = new System.Drawing.Font("Microsoft Sans Serif", (Ct.CellSize - 10) / 2,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    board[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    board[i, j].BackColor = Ct.CellColor;
                    board[i, j].Text = Ct.FreeCellText;

                    board[i, j].MouseClick += ClickOnCell;

                    Controls.Add(board[i, j]);
                }
            }
        }

        private void ClickOnCell(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                ((Label)sender).BackColor = Color.Red;
        }
    }
}
