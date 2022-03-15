namespace Simon
{
    partial class Simon
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_demarrer = new System.Windows.Forms.Button();
            this.bt_red = new System.Windows.Forms.Button();
            this.bt_yellow = new System.Windows.Forms.Button();
            this.bt_blue = new System.Windows.Forms.Button();
            this.bt_green = new System.Windows.Forms.Button();
            this.gb_bouttons = new System.Windows.Forms.GroupBox();
            this.bt_quitter = new System.Windows.Forms.Button();
            this.lb_niveau = new System.Windows.Forms.Label();
            this.lb_joueur = new System.Windows.Forms.Label();
            this.gb_bouttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_demarrer
            // 
            this.lb_demarrer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lb_demarrer.Location = new System.Drawing.Point(152, 85);
            this.lb_demarrer.Name = "lb_demarrer";
            this.lb_demarrer.Size = new System.Drawing.Size(148, 72);
            this.lb_demarrer.TabIndex = 0;
            this.lb_demarrer.Text = "Démarrer";
            this.lb_demarrer.UseVisualStyleBackColor = true;
            this.lb_demarrer.Click += new System.EventHandler(this.lb_demarrer_Click);
            // 
            // bt_red
            // 
            this.bt_red.BackColor = System.Drawing.Color.DarkRed;
            this.bt_red.Location = new System.Drawing.Point(339, 0);
            this.bt_red.Name = "bt_red";
            this.bt_red.Size = new System.Drawing.Size(169, 135);
            this.bt_red.TabIndex = 1;
            this.bt_red.Text = "Red";
            this.bt_red.UseVisualStyleBackColor = false;
            this.bt_red.Click += new System.EventHandler(this.bt_red_Click);
            // 
            // bt_yellow
            // 
            this.bt_yellow.BackColor = System.Drawing.Color.Gold;
            this.bt_yellow.Location = new System.Drawing.Point(514, 132);
            this.bt_yellow.Name = "bt_yellow";
            this.bt_yellow.Size = new System.Drawing.Size(169, 135);
            this.bt_yellow.TabIndex = 2;
            this.bt_yellow.Text = "Yellow";
            this.bt_yellow.UseVisualStyleBackColor = false;
            this.bt_yellow.Click += new System.EventHandler(this.lb_yellow_Click);
            // 
            // bt_blue
            // 
            this.bt_blue.BackColor = System.Drawing.Color.DarkBlue;
            this.bt_blue.Location = new System.Drawing.Point(164, 135);
            this.bt_blue.Name = "bt_blue";
            this.bt_blue.Size = new System.Drawing.Size(169, 132);
            this.bt_blue.TabIndex = 3;
            this.bt_blue.Text = "Blue";
            this.bt_blue.UseVisualStyleBackColor = false;
            this.bt_blue.Click += new System.EventHandler(this.bt_blue_Click);
            // 
            // bt_green
            // 
            this.bt_green.BackColor = System.Drawing.Color.DarkGreen;
            this.bt_green.Location = new System.Drawing.Point(339, 260);
            this.bt_green.Name = "bt_green";
            this.bt_green.Size = new System.Drawing.Size(169, 135);
            this.bt_green.TabIndex = 4;
            this.bt_green.Text = "Green";
            this.bt_green.UseVisualStyleBackColor = false;
            this.bt_green.Click += new System.EventHandler(this.bt_green_Click);
            // 
            // gb_bouttons
            // 
            this.gb_bouttons.Controls.Add(this.bt_red);
            this.gb_bouttons.Controls.Add(this.bt_yellow);
            this.gb_bouttons.Controls.Add(this.bt_green);
            this.gb_bouttons.Controls.Add(this.bt_blue);
            this.gb_bouttons.Enabled = false;
            this.gb_bouttons.Location = new System.Drawing.Point(96, 163);
            this.gb_bouttons.Name = "gb_bouttons";
            this.gb_bouttons.Size = new System.Drawing.Size(813, 408);
            this.gb_bouttons.TabIndex = 5;
            this.gb_bouttons.TabStop = false;
            // 
            // bt_quitter
            // 
            this.bt_quitter.Location = new System.Drawing.Point(474, 577);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(75, 23);
            this.bt_quitter.TabIndex = 6;
            this.bt_quitter.Text = "Quitter";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // lb_niveau
            // 
            this.lb_niveau.AutoSize = true;
            this.lb_niveau.Location = new System.Drawing.Point(660, 85);
            this.lb_niveau.Name = "lb_niveau";
            this.lb_niveau.Size = new System.Drawing.Size(72, 16);
            this.lb_niveau.TabIndex = 7;
            this.lb_niveau.Text = "Niveau  :  0";
            // 
            // lb_joueur
            // 
            this.lb_joueur.AutoSize = true;
            this.lb_joueur.Location = new System.Drawing.Point(659, 141);
            this.lb_joueur.Name = "lb_joueur";
            this.lb_joueur.Size = new System.Drawing.Size(48, 16);
            this.lb_joueur.TabIndex = 8;
            this.lb_joueur.Text = "Joueur";
            // 
            // Simon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 629);
            this.Controls.Add(this.lb_joueur);
            this.Controls.Add(this.lb_niveau);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.gb_bouttons);
            this.Controls.Add(this.lb_demarrer);
            this.Name = "Simon";
            this.Text = "Simon";
            this.Load += new System.EventHandler(this.Simon_Load);
            this.gb_bouttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lb_demarrer;
        private System.Windows.Forms.Button bt_red;
        private System.Windows.Forms.Button bt_yellow;
        private System.Windows.Forms.Button bt_blue;
        private System.Windows.Forms.Button bt_green;
        private System.Windows.Forms.GroupBox gb_bouttons;
        private System.Windows.Forms.Button bt_quitter;
        private System.Windows.Forms.Label lb_niveau;
        private System.Windows.Forms.Label lb_joueur;
    }
}

