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
        private const int LineFoisCol = MAX_COL*MAX_LINE;   
        private int[] listeInitial = {  1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 };
        private int nbClique=0;
        int row1=-1, col1=-1
        private int currentPlayer = 0;

        public Form1()
        {
            InitializeComponent();
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createGrid();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           int row = e.RowIndex;
           int col = e.ColumnIndex;
           
            nbClique++;

           if (nbClique== 1)
            {
                row1 = row;
                col1 = col;
                grid.Rows[row].Cells[col].Style.BackColor = Color.Yellow;
            }
           else
            {
                if (nbClique == 2)
                {
                   
                    if (row != row1 || col != col1)
                    {
                        if (grid.Rows[row].Cells[col].Value.ToString().CompareTo(grid.Rows[row1].Cells[col1].Value.ToString())==0)
                        {

                              grid.Rows[row].Cells[col].Style.BackColor = Color.Black;
                            grid.Rows[row1].Cells[col1].Style.BackColor = Color.Black;
                        }
                        else
                        {
                            if (currentPlayer == 0)
                            {
                                currentPlayer++;
                            }
                            else
                            {
                                currentPlayer--;
                            }
                        }
                    }
                    nbClique = 0;
                }
            }


        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_demarrer_Click(object sender, EventArgs e)
        {
            generationBase();
        }

        private void generationBase()
        {
            melange();
            for (int i = 0; i < LineFoisCol; i++)
            {
                grid.Rows[i / MAX_COL].Cells[i % MAX_LINE].Value = listeInitial[i];
            }
            
        }

        private void melange()
        {
            int tampon;
            Random random = new Random();
            int r1 = random.Next(LineFoisCol);
            int r2 = random.Next(LineFoisCol);
            for (int i = 0;i < 300; i++)
            {
                tampon = listeInitial[r1];
                listeInitial[r1] = listeInitial[r2];
                listeInitial[r2] = tampon;
                r1 = random.Next(LineFoisCol);
                r2 = random.Next(LineFoisCol);
            }

        }
        private void quiJoue()
        {
           if (currentPlayer == 0)
            {

            }
        }

    }
}
