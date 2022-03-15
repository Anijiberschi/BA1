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
	}
}
