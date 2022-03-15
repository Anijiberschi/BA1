using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taquin
{
	public partial class Form1 : Form
	{
		private const int MAX_ROW = 4;
		private const int MAX_COL = 4;
		private int aRow = 0, aCol = 0;
		public Random random = new Random();
		private int[,] matrice = new int[MAX_ROW, MAX_COL];


		public Form1()
		{
			InitializeComponent();
		}

		private void createGrid()
		{
			DataTable dt = new DataTable();

			for (int row = 0; row < MAX_ROW; row++)
				dt.Rows.Add();

			for (int col = 0; col < MAX_COL; col++)
				dt.Columns.Add();

			grid.DataSource = dt;

			for (int col = 0; col < MAX_COL; col++)
				grid.Columns[col].Width = (grid.Width / MAX_COL);

			for (int row = 0; row < MAX_ROW; row++)
				grid.Rows[row].Height = grid.Height / MAX_ROW;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			createGrid();
		}

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			int row = e.RowIndex;
			int col = e.ColumnIndex;
			int tempo =0;

			if (grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Orange)
            {
				aRow = e.RowIndex;
				aCol= e.ColumnIndex;
				
				
            }
            else
            {
				if ((e.ColumnIndex + e.RowIndex) - (aCol + aRow) == 1 || (aCol + aRow) - (e.ColumnIndex + e.RowIndex) == 1)
                {
					tempo = matrice[aRow, aCol];
					matrice[aRow, aCol] = matrice[e.RowIndex, e.ColumnIndex];
					grid.Rows[aRow].Cells[aCol].Value = matrice[aRow, aCol];
					coloriage(aRow, aCol);
					matrice[e.RowIndex, e.ColumnIndex] = tempo;
					grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = matrice[e.RowIndex, e.ColumnIndex];
					coloriage(e.RowIndex, e.ColumnIndex);
					if (isWin())
                    {
						MessageBox.Show("C'est gagné");
						grid.Enabled = false;
                    }
				}
				
			}

			

		}

		public void fillMatrice()
        {
			for (int i=0; i<MAX_ROW; i++)
            {
				for (int j=0; j<MAX_COL; j++)
                {
					matrice[i, j] = j +1+ i*MAX_COL;
                }
            }
			matrice[MAX_COL-1, MAX_ROW-1] = (MAX_COL*MAX_ROW);
		}

		public void coloriage(int row, int col)
        {
			if (matrice[row,col] == MAX_COL * MAX_ROW)
            {
				grid.Rows[row].Cells[col].Style.BackColor = Color.White;
				grid.Rows[row].Cells[col].Style.ForeColor= Color.White;
			}
            else
            {
				grid.Rows[row].Cells[col].Style.BackColor = Color.Orange;
				grid.Rows[row].Cells[col].Style.ForeColor = Color.Black;
			}
        }

		public void fillGrid()
        {
			for (int i=0;i < MAX_COL * MAX_ROW; i++)
            {
				grid.Rows[i/MAX_ROW].Cells[i%MAX_COL].Value=matrice[i/MAX_ROW,i%MAX_COL];
				grid.Rows[i / MAX_ROW].Cells[i % MAX_COL].Style.BackColor = Color.Orange;
				grid.Rows[i / MAX_ROW].Cells[i % MAX_COL].Style.ForeColor= Color.Black;
				
				
				if (matrice[i / MAX_ROW, i % MAX_COL] == (MAX_COL * MAX_ROW))
				{
					grid.Rows[i / MAX_ROW].Cells[i % MAX_COL].Style.BackColor = Color.White;
					grid.Rows[i / MAX_ROW].Cells[i % MAX_COL].Style.ForeColor = Color.White;
				}
			}

		}

		public bool isWin()
        {
			bool flag = true;
			int cpt = 0;
            while (flag && cpt < MAX_ROW*MAX_COL)
            {
				flag = (matrice[cpt / MAX_ROW, cpt % MAX_COL] == cpt+1);
				cpt++;
			}
			return flag;
		}


		public void melange()
        {

			for (int i=0;i<100;i++)
            {
				int case1 = random.Next(MAX_COL * MAX_ROW);
				int case2 = random.Next(MAX_COL * MAX_ROW);
				int temp;

				temp = matrice[case1/MAX_COL,case1%MAX_ROW];
				matrice[case1 / MAX_COL, case1 % MAX_ROW] = matrice[case2 / MAX_COL, case2 % MAX_ROW];
				matrice[case2 / MAX_COL, case2 % MAX_ROW] = temp;
			}
		}

        private void bt_start_Click(object sender, EventArgs e)
        {
			grid.Enabled =true;
			fillMatrice();
			melange();
			fillGrid();
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
			Close();
        }
    }
}
