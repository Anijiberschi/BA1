namespace Tawai
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
            this.lb_question = new System.Windows.Forms.Label();
            this.lb_oui = new System.Windows.Forms.Button();
            this.lb_non = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_question
            // 
            this.lb_question.AutoSize = true;
            this.lb_question.BackColor = System.Drawing.Color.Transparent;
            this.lb_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_question.ForeColor = System.Drawing.Color.Red;
            this.lb_question.Location = new System.Drawing.Point(154, 127);
            this.lb_question.Name = "lb_question";
            this.lb_question.Size = new System.Drawing.Size(484, 36);
            this.lb_question.TabIndex = 0;
            this.lb_question.Text = "Tawai appartient-elle à la chine ?";
            this.lb_question.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_oui
            // 
            this.lb_oui.Location = new System.Drawing.Point(160, 316);
            this.lb_oui.Name = "lb_oui";
            this.lb_oui.Size = new System.Drawing.Size(75, 23);
            this.lb_oui.TabIndex = 1;
            this.lb_oui.Text = "OUI ?";
            this.lb_oui.UseVisualStyleBackColor = true;
            // 
            // lb_non
            // 
            this.lb_non.Location = new System.Drawing.Point(563, 316);
            this.lb_non.Name = "lb_non";
            this.lb_non.Size = new System.Drawing.Size(75, 23);
            this.lb_non.TabIndex = 2;
            this.lb_non.Text = "NON ?";
            this.lb_non.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_non);
            this.Controls.Add(this.lb_oui);
            this.Controls.Add(this.lb_question);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_question;
        private System.Windows.Forms.Button lb_oui;
        private System.Windows.Forms.Button lb_non;
    }
}

