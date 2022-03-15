using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    public partial class Simon : Form
    {

        //0 correspond à red
        //1 correspond à Yellow
        //2 correspond à Green
        //3 correspond à Blue


        static int NIVEAUENCOURS = 0;
        int niveau = 10;


        public void bt_Light(int indice)
        {
            Color[] couleurClair = { Color.Red, Color.Yellow, Color.Green, Color.Blue };
            Color[] couleurSombre = { Color.DarkRed, Color.Gold, Color.DarkGreen, Color.DarkBlue };
            Button[] bouttons = { bt_red,bt_yellow, bt_green, bt_blue};
            bouttons[indice].BackColor = couleurClair[indice];
            this.Refresh();
            System.Threading.Thread.Sleep(500);
            bouttons[indice].BackColor = couleurSombre[indice];
        }

        private void verification(int bt)
        {

            int[] liste_joueur = new int[niveau];

            if (NIVEAUENCOURS != 0)
            {
                bt_Light(bt);
                liste_joueur.Append(bt);

            }
            else
            {
                bt_Light(bt);
            }
        }

        public Simon()
        {
            InitializeComponent();
        }

        private void lb_yellow_Click(object sender, EventArgs e)
        {

            verification(1);
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Simon_Load(object sender, EventArgs e)
        {

        }

        private void bt_green_Click(object sender, EventArgs e)
        {
            verification(2);
        }

        private int [] miseenplace()
        {
            
            int[] TabCouleurs = { 0, 1, 2, 3 };

            int[] ListeIA = new int[niveau];
            Random r = new Random();

            for (int i = 0; i < niveau; i++)
            {
                int aleatoire = r.Next(4);
                ListeIA[i] = TabCouleurs[aleatoire];
            }
            return ListeIA;
        }

        private void MachineJoue(bool j)
        {
            if (j != true)
            {
                lb_joueur.Text = "Joueur : Vous";
            }
            else
            {
                lb_joueur.Text = "Joueur : Machine";
            }
        }

        private void lb_demarrer_Click(object sender, EventArgs e)
        {
            


            if (gb_bouttons.Enabled == false)
            {
                gb_bouttons.Enabled = true;
                miseenplace();


            }

            gb_bouttons.Enabled = false;
        }

        public void bt_red_Click(object sender, EventArgs e)
        {
            verification(0);
        }

        private void bt_blue_Click(object sender, EventArgs e)
        {
            verification(3);
        }
    }
}
