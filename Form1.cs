using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        { }
 
        PictureBox[,] P = new PictureBox[8, 8];
        int [,] board = new int[8, 8];

        int selectedRow = -1;
        int selectedCol = -1;

        bool isRedTurn = true;

        public Form1()
        {
            InitializeComponent();
            CreateBoard();
        }

        void CreateBoard()
        {
            int size = 60;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    P[i, j] = new PictureBox();
                    P[i , j].Width = size;
                    P[i, j].Height = size;
                    P[i, j].Left = j * size;
                    P[i, j].Top = i * size;

                    P[i, j].BackColor = (i + j) % 2 == 0 ? Color.White : Color.Black;
                    P[i, j].SizeMode = PictureBoxSizeMode.Zoom;

                    
                    this.Controls.Add(P[i, j]);
                }
            }
        }

        
    }
}

