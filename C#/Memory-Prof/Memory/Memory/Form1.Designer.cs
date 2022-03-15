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
            this.bQuit = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.lP1 = new System.Windows.Forms.Label();
            this.lP2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ColumnHeadersVisible = false;
            this.grid.Location = new System.Drawing.Point(114, 123);
            this.grid.Margin = new System.Windows.Forms.Padding(2);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 24;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid.Size = new System.Drawing.Size(603, 542);
            this.grid.TabIndex = 0;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // bQuit
            // 
            this.bQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuit.Location = new System.Drawing.Point(375, 700);
            this.bQuit.Margin = new System.Windows.Forms.Padding(2);
            this.bQuit.Name = "bQuit";
            this.bQuit.Size = new System.Drawing.Size(80, 42);
            this.bQuit.TabIndex = 1;
            this.bQuit.Text = "Quitter";
            this.bQuit.UseVisualStyleBackColor = true;
            this.bQuit.Click += new System.EventHandler(this.bQuit_Click);
            // 
            // bStart
            // 
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.Location = new System.Drawing.Point(240, 25);
            this.bStart.Margin = new System.Windows.Forms.Padding(2);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(150, 67);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "Nouvelle partie";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // lP1
            // 
            this.lP1.AutoSize = true;
            this.lP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lP1.Location = new System.Drawing.Point(442, 25);
            this.lP1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lP1.Name = "lP1";
            this.lP1.Size = new System.Drawing.Size(149, 24);
            this.lP1.TabIndex = 4;
            this.lP1.Text = "Score joueur 1 : ";
            // 
            // lP2
            // 
            this.lP2.AutoSize = true;
            this.lP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lP2.Location = new System.Drawing.Point(442, 68);
            this.lP2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lP2.Name = "lP2";
            this.lP2.Size = new System.Drawing.Size(149, 24);
            this.lP2.TabIndex = 5;
            this.lP2.Text = "Score joueur 2 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 777);
            this.Controls.Add(this.lP2);
            this.Controls.Add(this.lP1);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bQuit);
            this.Controls.Add(this.grid);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button bQuit;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Label lP1;
        private System.Windows.Forms.Label lP2;
    }
}

