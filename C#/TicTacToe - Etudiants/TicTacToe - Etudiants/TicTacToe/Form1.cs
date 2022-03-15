using System;
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
	public partial class Form1 : Form
	{
		private const int GRID_SIZE = 3;
		private const int totalPlayer = 2;
		private int currentPlayer = -1;
		private  Color startColor = Color.Aqua;
		private int nbClick = 0;

		private Color[] colorPlayer = new Color[totalPlayer] {Color.Red,Color.Yellow };
		


		public Form1()
		{
			InitializeComponent();
		}

		private void createGrid()
		{
			DataTable dt = new DataTable();

			for (int row = 0; row < GRID_SIZE; row++)
				dt.Rows.Add();

			for (int col = 0; col < GRID_SIZE; col++)
				dt.Columns.Add();

			grid.DataSource = dt;

			for (int col = 0; col < GRID_SIZE; col++)
				grid.Columns[col].Width = (grid.Width / GRID_SIZE);

			for (int row = 0; row < GRID_SIZE; row++)
				grid.Rows[row].Height = grid.Height / GRID_SIZE;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			createGrid();
		}

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			if (currentPlayer > -1) 
			{
				int row = e.RowIndex;
				int col = e.ColumnIndex;


				changePlayer();
				changeColor(row, col);
				HasWin(row, col);
			}


		}

		private void changePlayer()
        {
			currentPlayer = ++currentPlayer % totalPlayer;
			lb_currentPlayer.Text = "Joueur : "+currentPlayer;
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
			Close();
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
			currentPlayer = 0;
			fillCells();

        }
		
		private void fillCells()
        {
			for (int i=0;i < GRID_SIZE * GRID_SIZE; i++)
            {
				grid.Rows[i / GRID_SIZE].Cells[i % GRID_SIZE].Style.BackColor=startColor;
			}
        }
		private void changeColor(int row, int cell)
        {
			if (grid.Rows[row].Cells[cell].Style.BackColor == startColor) 
			{
				grid.Rows[row].Cells[cell].Style.BackColor = colorPlayer[currentPlayer];
				nbClick++;
			}
        }
		
		private bool checkHoriontal(int row, int cell)
        {

			Color colorCase = grid.Rows[row].Cells[cell].Style.BackColor;

			if (grid.Rows[row].Cells[0].Style.BackColor ==  colorCase && grid.Rows[row].Cells[1].Style.BackColor == colorCase && grid.Rows[row].Cells[2].Style.BackColor == colorCase)
            {
				return true;
            }
            else
            {
				return false;
            }
		}

		private bool checkVertical(int row,int cell)
		{

			Color colorCase = grid.Rows[row].Cells[cell].Style.BackColor;

			if (grid.Rows[0].Cells[cell].Style.BackColor == colorCase && grid.Rows[1].Cells[cell].Style.BackColor == colorCase && grid.Rows[2].Cells[cell].Style.BackColor == colorCase)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool checkDiago(int row, int cell)
		{

			Color colorCase = grid.Rows[row].Cells[cell].Style.BackColor;
			bool flag = false; 

			if ((row == 0 && cell!=1) ||(row == 1 && cell == 1)) 
			{
				if ((grid.Rows[row].Cells[0].Style.BackColor == colorCase && grid.Rows[row+1].Cells[1].Style.BackColor == colorCase && grid.Rows[row+2].Cells[2].Style.BackColor == colorCase))

				{
					flag =true;
                }
            }
			else if (row == 2 && cell != 1)
			{
				if ((grid.Rows[row].Cells[2].Style.BackColor == colorCase && grid.Rows[row - 1].Cells[1].Style.BackColor == colorCase && grid.Rows[row - 2].Cells[0].Style.BackColor == colorCase))

				{
					flag = true;
				}
			}
            else
            {
				flag = false;
            }
			return flag;
		}

		private void HasWin(int row, int cell)
        {
			if (checkDiago(row, cell) == true || checkVertical(row, cell)== true || checkHoriontal(row, cell) == true)
            {
				MessageBox.Show("Le joueur "+currentPlayer+ " a gagné");
				currentPlayer = -1;
			}else if (nbClick == GRID_SIZE*GRID_SIZE)
			{
				MessageBox.Show("Egalité");
				currentPlayer = -1;
			}

        }
	}
}
