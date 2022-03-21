using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Puissance4
{
    public partial class Form1 : Form
    {
        private const int MAX_ROW = 6;
        private const int MAX_COL = 7;
        private Bitmap[] tabImage = new Bitmap[3];
        private int[,] matrice = new int[6, 7];
        private int[] JetonsCol = new int[MAX_COL];
        private int jouer_actif = 0;
        private int NbJoueur = 2;
        


        public Form1()
        {
            InitializeComponent();
        }



        private void initTabImage()
        {
            tabImage[0] = new Bitmap("red circle.ico");
            tabImage[1] = new Bitmap("black circle.ico");
            tabImage[2] = new Bitmap(1, 1);
        }

        private void createGame()
        {
            initTabImage();

            emptyGrid();


            grid.ClearSelection();
            grid.Enabled = true;
        }

        private void createGrid()
        {
            DataTable dt = new DataTable();
            DataGridViewImageColumn imageCol = null;

            for (int row = 0; row < MAX_ROW; row++)
                dt.Rows.Add();

            for (int col = 0; col < MAX_COL; col++)
            {
                dt.Columns.Add();
                imageCol = new DataGridViewImageColumn();
                grid.Columns.Add(imageCol);
            }

            grid.DataSource = dt;

            for (int col = 0; col < MAX_COL; col++)
                grid.Columns[col].Width = (grid.Width / MAX_COL);

            for (int row = 0; row < MAX_ROW; row++)
                grid.Rows[row].Height = grid.Height / MAX_ROW;
        }

        private void emptyGrid()
        {
            for (int row = 0; row < MAX_ROW; row++)
            {
                for (int col = 0; col < MAX_COL; col++)
                {
                    grid.Rows[row].Cells[col].Style.BackColor = Color.Wheat;
                    grid.Rows[row].Cells[col].Value = tabImage[2];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createGrid();
            createGame();
            grid.Enabled = false;
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;

            PosInMat(col);

        }

        private void PosInMat(int col)
        {

            int row = (MAX_ROW-1) - JetonsCol[col];

           if (row > -1)
            {
                matrice[row, col] = jouer_actif;
                JetonsCol[col]++;
                ChangeJoueur();
                TabToGrid(row, col);
                
            }
            
        }


        private void checkHorizontal(int row, int col)
        {
            if (col == 0)
            {
                
            }

        private void ChangeJoueur()
        {
            jouer_actif = (jouer_actif + 1) % NbJoueur;
        }

        private void TabToGrid(int row, int col)
        {
            grid.Rows[row].Cells[col].Value = tabImage[jouer_actif];
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            grid.Enabled = true;
            
        }

        private void bQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
