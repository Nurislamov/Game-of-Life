using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life
{
    public partial class Form1 : Form
    {

        private Graphics graphics;
        private bool[,] sphere;
        private int cols;
        private int rows;
        private int screenResolution;
        public Form1()
        {
            InitializeComponent();
        }

        private void CellColorButton_Click(object sender, EventArgs e)
        {

            if (ColorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            CellColorButton.ForeColor = ColorDialog.Color;
            CellColorButton.BackColor = splitContainer1.Panel2.BackColor;

            if (CellColorButton.BackColor == Color.White && CellColorButton.ForeColor == Color.White)
            {
                CellColorButton.ForeColor = Color.WhiteSmoke;
            }
            else if (CellColorButton.BackColor == Color.Black && CellColorButton.ForeColor == Color.Black)
            {
                CellColorButton.ForeColor = Color.DimGray;
            }
        }
        private void BackgroundColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            splitContainer1.Panel2.BackColor = ColorDialog.Color;
            BackgroundColorButton.BackColor = ColorDialog.Color;

            if (BackgroundColorButton.BackColor == Color.White)
            {
                BackgroundColorButton.ForeColor = Color.Black;
            }
            else
            {
                BackgroundColorButton.ForeColor = Color.White;
            }

            CellColorButton.BackColor = splitContainer1.Panel2.BackColor;
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            StopGame();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            LifeGeneration();
        }
        private void StartGame()
        {
            if (Timer1.Enabled)
                return;

            PlayingFieldPicBox.Size = new Size(splitContainer1.Panel2.Width, splitContainer1.Panel2.Height);

            nudCellDensity.Enabled = false;
            nudScreenResolution.Enabled = false;
            BackgroundColorButton.Enabled = false;
            CellColorButton.Enabled = false;

            screenResolution = (int)nudScreenResolution.Value;
            rows = PlayingFieldPicBox.Height / screenResolution;
            cols = PlayingFieldPicBox.Width / screenResolution;

            sphere = new bool[cols, rows];

            Random rand = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    sphere[x, y] = rand.Next((int)nudCellDensity.Value) == 0;
                }
            }

            PlayingFieldPicBox.Image = new Bitmap(PlayingFieldPicBox.Width, PlayingFieldPicBox.Height);
            graphics = Graphics.FromImage(PlayingFieldPicBox.Image);
            Timer1.Start();
        }
        private void StopGame()
        {
            if (!Timer1.Enabled)
                return;

            Timer1.Stop();

            nudCellDensity.Enabled = true;
            nudScreenResolution.Enabled = true;
            BackgroundColorButton.Enabled = true;
            CellColorButton.Enabled = true;
        }
        private void LifeGeneration()
        {
            graphics.Clear(splitContainer1.Panel2.BackColor);
            SolidBrush brush = new SolidBrush(CellColorButton.ForeColor);

            var newSphere = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboringCells = CellNeighborCheck(x, y);
                    var cellCheck = sphere[x, y];

                    if (!cellCheck && neighboringCells == 3)
                    {
                        newSphere[x, y] = true;
                    }
                    else if (cellCheck && (neighboringCells < 2 || neighboringCells > 3))
                    {
                        newSphere[x, y] = false;
                    }
                    else
                    {
                        newSphere[x, y] = sphere[x, y];
                    }

                    if (cellCheck)
                    {
                        graphics.FillRectangle(brush, x * screenResolution, y * screenResolution, screenResolution - 2, screenResolution - 2);
                    }
                }
            }
            sphere = newSphere;
            PlayingFieldPicBox.Refresh();
        }
        private int CellNeighborCheck(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;

                    var checkingOnesOwnPosition = col == x && row == y;
                    var cellLifeTest = sphere[col, row];

                    if (cellLifeTest && !checkingOnesOwnPosition)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
