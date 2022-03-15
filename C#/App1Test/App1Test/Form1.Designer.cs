namespace App1Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_Prenom = new System.Windows.Forms.Label();
            this.lb_Nom = new System.Windows.Forms.Label();
            this.tb_Prenom = new System.Windows.Forms.TextBox();
            this.tb_Nom = new System.Windows.Forms.TextBox();
            this.bt_validation = new System.Windows.Forms.Button();
            this.bt_rouge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Prenom
            // 
            this.lb_Prenom.AutoSize = true;
            this.lb_Prenom.Location = new System.Drawing.Point(290, 174);
            this.lb_Prenom.Name = "lb_Prenom";
            this.lb_Prenom.Size = new System.Drawing.Size(69, 16);
            this.lb_Prenom.TabIndex = 0;
            this.lb_Prenom.Text = "Prénom :,  ";
            // 
            // lb_Nom
            // 
            this.lb_Nom.AutoSize = true;
            this.lb_Nom.Location = new System.Drawing.Point(290, 325);
            this.lb_Nom.Name = "lb_Nom";
            this.lb_Nom.Size = new System.Drawing.Size(42, 16);
            this.lb_Nom.TabIndex = 1;
            this.lb_Nom.Text = "Nom :";
            // 
            // tb_Prenom
            // 
            this.tb_Prenom.Location = new System.Drawing.Point(458, 168);
            this.tb_Prenom.Name = "tb_Prenom";
            this.tb_Prenom.Size = new System.Drawing.Size(100, 22);
            this.tb_Prenom.TabIndex = 2;
            // 
            // tb_Nom
            // 
            this.tb_Nom.Location = new System.Drawing.Point(458, 325);
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(100, 22);
            this.tb_Nom.TabIndex = 3;
            // 
            // bt_validation
            // 
            this.bt_validation.Location = new System.Drawing.Point(458, 502);
            this.bt_validation.Name = "bt_validation";
            this.bt_validation.Size = new System.Drawing.Size(115, 23);
            this.bt_validation.TabIndex = 4;
            this.bt_validation.Text = "Validé";
            this.bt_validation.UseVisualStyleBackColor = true;
            this.bt_validation.Click += new System.EventHandler(this.bt_validation_Click);
            // 
            // bt_rouge
            // 
            this.bt_rouge.Location = new System.Drawing.Point(682, 502);
            this.bt_rouge.Name = "bt_rouge";
            this.bt_rouge.Size = new System.Drawing.Size(157, 23);
            this.bt_rouge.TabIndex = 5;
            this.bt_rouge.Text = "Label Rouge";
            this.bt_rouge.UseVisualStyleBackColor = true;
            this.bt_rouge.Click += new System.EventHandler(this.bt_rouge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1275, 672);
            this.Controls.Add(this.bt_rouge);
            this.Controls.Add(this.bt_validation);
            this.Controls.Add(this.tb_Nom);
            this.Controls.Add(this.tb_Prenom);
            this.Controls.Add(this.lb_Nom);
            this.Controls.Add(this.lb_Prenom);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Prenom;
        private System.Windows.Forms.Label lb_Nom;
        private System.Windows.Forms.TextBox tb_Prenom;
        private System.Windows.Forms.TextBox tb_Nom;
        private System.Windows.Forms.Button bt_validation;
        private System.Windows.Forms.Button bt_rouge;
    }
}

