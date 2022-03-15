using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_validation_Click(object sender, EventArgs e)
        {
            String mess = "Bonjour " + tb_Nom.Text +" "+ tb_Prenom.Text;
            MessageBox.Show(mess);
        }

        private void bt_rouge_Click(object sender, EventArgs e)
        {   if (lb_Prenom.ForeColor != Color.Red | lb_Nom.ForeColor != Color.Red)
            {
                lb_Prenom.ForeColor = Color.Red;
                lb_Nom.ForeColor = Color.Red;
            }
            else
            {
                lb_Prenom.ForeColor = Color.Black;
                lb_Nom.ForeColor = Color.Black;
            }
        }
    }
}
 