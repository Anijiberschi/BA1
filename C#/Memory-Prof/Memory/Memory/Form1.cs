using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {
        private const int MAX_LINE = 4;
        private const int MAX_COL = 4;
        private const int totImage = (MAX_LINE * MAX_COL)/2;

        private int count = 0;

        private int prevCol = -1;
        private int prevRow = -1;

        private  String[] tabImage = null;

        private int currentPlayer = 0;
        private int[] tabScore = { 0, 0 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createGrid();
        }

        private void updateColorLabel()
        {
            lP1.BackColor = SystemColors.Control;
            lP2.BackColor = SystemColors.Control;

            if (currentPlayer == 0)
                lP1.BackColor = Color.Red;
            else
                lP2.BackColor = Color.Red;
        }

        private void changePlayer()
        {
            currentPlayer = (currentPlayer + 1) % 2;

            updateColorLabel();
        }

        private void createGame()
        {
            emptyGrid();
            createTabImage();

            mixTabImage();

            fillGrid();

            grid.ClearSelection();
            grid.Enabled = true;
        }

        private void fillGrid()
        {
            int i = 0;
            for (int col = 0; col < MAX_COL; col++ )
            {
                for(int row = 0 ; row < MAX_LINE ; row++)
                {
                    grid.Rows[row].Cells[col].Style.ForeColor = Color.White;
                    grid.Rows[row].Cells[col].Value = tabImage[i];

                    i++;
                }
            }
        }

        private  void createTabImage()
        {
            int numImage = 0;

            tabImage = new String[MAX_LINE * MAX_COL];

            for (int i = 0; i < (totImage * 2) ; i++)
            {
                numImage = i % totImage + 1;

                tabImage[i] = ""+numImage;
            }
        }

        private  void mixTabImage()
        {
            Random random = new Random();

            int index1 = 0;
            int index2 = 0;

            for (int i = 0; i < 200; i++)
            {
                index1 = random.Next(0, totImage * 2);
                index2 = random.Next(0, totImage * 2);

                swap(index1, index2);
            }
        }

        private void swap(int i, int j)
        {
            String temp = "";

            temp = tabImage[i];
            tabImage[i] = tabImage[j];
            tabImage[j] = temp;
        }    

        private void createGrid()
        {
            DataTable dt = new DataTable();

            for (int row = 0; row < MAX_LINE; row++)
                dt.Rows.Add();

            for (int col = 0; col < MAX_COL; col++)
                dt.Columns.Add();

            grid.DataSource = dt;

            for (int col = 0; col < MAX_COL; col++)
                grid.Columns[col].Width = (grid.Width / MAX_COL);

            for (int row = 0; row < MAX_LINE; row++)
                grid.Rows[row].Height = grid.Height / MAX_LINE;

            for (int row = 0; row < MAX_LINE; row++)
            {
                for (int col = 0; col < MAX_COL; col++)
                {
                    grid.Rows[row].Cells[col].Value = "";
                    grid.Rows[row].Cells[col].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    grid.Rows[row].Cells[col].Style.Font = new Font(bStart.Font.Name, 14);
                }
            }
        }

        private void emptyGrid()
        {
            for (int row = 0; row < MAX_LINE; row++)
            {
                for (int col = 0; col < MAX_COL; col++)
                {
                    grid.Rows[row].Cells[col].Value = "";
                }
            }
        }

        private void bQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            tabScore[0] = 0;
            tabScore[1] = 0;

            createGame();
            updateColorLabel();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;


            if(row != prevRow || col != prevCol)
            { 
                count++;

                grid.Rows[row].Cells[col].Style.ForeColor = Color.Black;

                if (count == 1)
                {
                    prevRow = row;
                    prevCol = col;
                }
                else 
                { 
                    if(grid.Rows[row].Cells[col].Value.ToString().CompareTo( grid.Rows[prevRow].Cells[prevCol].Value.ToString()) == 0)
                    {
                        tabScore[currentPlayer] = tabScore[currentPlayer]+1;
                    }
                    else
                    {
                        grid.Rows[row].Cells[col].Style.ForeColor = Color.White;
                        grid.Rows[prevRow].Cells[prevCol].Style.ForeColor = Color.White;

                        changePlayer();
                    }

                    updateScore();

                    prevRow = -1;
                    prevCol = -1;

                    count = 0;

                    System.Threading.Thread.Sleep(1000);
                }
            }

            grid.ClearSelection();
        }

        private void updateScore()
        {
            lP1.Text = "P1 : " + tabScore[0];
            lP2.Text = "P2 : " + tabScore[1];
        }
    }
}
