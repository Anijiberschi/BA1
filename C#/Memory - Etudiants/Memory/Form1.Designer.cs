namespace Memory
{
    partial class Form1
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.lb_p1 = new System.Windows.Forms.Label();
            this.lb_p2 = new System.Windows.Forms.Label();
            this.bt_demarrer = new System.Windows.Forms.Button();
            this.bt_quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ColumnHeadersVisible = false;
            this.grid.Location = new System.Drawing.Point(152, 151);
            this.grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid.Size = new System.Drawing.Size(804, 667);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // lb_p1
            // 
            this.lb_p1.AutoSize = true;
            this.lb_p1.Location = new System.Drawing.Point(764, 49);
            this.lb_p1.Name = "lb_p1";
            this.lb_p1.Size = new System.Drawing.Size(32, 16);
            this.lb_p1.TabIndex = 1;
            this.lb_p1.Text = "P1 : ";
            // 
            // lb_p2
            // 
            this.lb_p2.AutoSize = true;
            this.lb_p2.Location = new System.Drawing.Point(774, 103);
            this.lb_p2.Name = "lb_p2";
            this.lb_p2.Size = new System.Drawing.Size(44, 16);
            this.lb_p2.TabIndex = 2;
            this.lb_p2.Text = "label1";
            // 
            // bt_demarrer
            // 
            this.bt_demarrer.Location = new System.Drawing.Point(300, 75);
            this.bt_demarrer.Name = "bt_demarrer";
            this.bt_demarrer.Size = new System.Drawing.Size(75, 23);
            this.bt_demarrer.TabIndex = 3;
            this.bt_demarrer.Text = "button1";
            this.bt_demarrer.UseVisualStyleBackColor = true;
            this.bt_demarrer.Click += new System.EventHandler(this.bt_demarrer_Click);
            // 
            // bt_quitter
            // 
            this.bt_quitter.Location = new System.Drawing.Point(450, 834);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(188, 54);
            this.bt_quitter.TabIndex = 4;
            this.bt_quitter.Text = "button1";
            this.bt_quitter.UseVisualStyleBackColor = true;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 956);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.bt_demarrer);
            this.Controls.Add(this.lb_p2);
            this.Controls.Add(this.lb_p1);
            this.Controls.Add(this.grid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label lb_p1;
        private System.Windows.Forms.Label lb_p2;
        private System.Windows.Forms.Button bt_demarrer;
        private System.Windows.Forms.Button bt_quitter;
    }
}

