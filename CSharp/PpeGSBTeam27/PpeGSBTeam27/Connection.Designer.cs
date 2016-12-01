namespace PpeGSBTeam27
{
    partial class FormConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnection));
            this.btnSeConnecterValider = new System.Windows.Forms.Button();
            this.txbSeConnecterLogin = new System.Windows.Forms.TextBox();
            this.txbSeConnecterMdp = new System.Windows.Forms.TextBox();
            this.labSeConnecterPseudo = new System.Windows.Forms.Label();
            this.labSeConnecterMdp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSeConnecterValider
            // 
            this.btnSeConnecterValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSeConnecterValider.Location = new System.Drawing.Point(1076, 626);
            this.btnSeConnecterValider.Name = "btnSeConnecterValider";
            this.btnSeConnecterValider.Size = new System.Drawing.Size(158, 30);
            this.btnSeConnecterValider.TabIndex = 9;
            this.btnSeConnecterValider.Text = "Valider";
            this.btnSeConnecterValider.UseVisualStyleBackColor = true;
            this.btnSeConnecterValider.Click += new System.EventHandler(this.btnSeConnecterValider_Click);
            // 
            // txbSeConnecterLogin
            // 
            this.txbSeConnecterLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbSeConnecterLogin.Location = new System.Drawing.Point(1076, 526);
            this.txbSeConnecterLogin.Name = "txbSeConnecterLogin";
            this.txbSeConnecterLogin.Size = new System.Drawing.Size(158, 20);
            this.txbSeConnecterLogin.TabIndex = 6;
            // 
            // txbSeConnecterMdp
            // 
            this.txbSeConnecterMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbSeConnecterMdp.Location = new System.Drawing.Point(1076, 580);
            this.txbSeConnecterMdp.Name = "txbSeConnecterMdp";
            this.txbSeConnecterMdp.Size = new System.Drawing.Size(158, 20);
            this.txbSeConnecterMdp.TabIndex = 8;
            // 
            // labSeConnecterPseudo
            // 
            this.labSeConnecterPseudo.AutoSize = true;
            this.labSeConnecterPseudo.BackColor = System.Drawing.Color.Transparent;
            this.labSeConnecterPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSeConnecterPseudo.ForeColor = System.Drawing.Color.Snow;
            this.labSeConnecterPseudo.Location = new System.Drawing.Point(1073, 506);
            this.labSeConnecterPseudo.Name = "labSeConnecterPseudo";
            this.labSeConnecterPseudo.Size = new System.Drawing.Size(56, 20);
            this.labSeConnecterPseudo.TabIndex = 5;
            this.labSeConnecterPseudo.Text = "Login :";
            // 
            // labSeConnecterMdp
            // 
            this.labSeConnecterMdp.AutoSize = true;
            this.labSeConnecterMdp.BackColor = System.Drawing.Color.Transparent;
            this.labSeConnecterMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSeConnecterMdp.ForeColor = System.Drawing.Color.Snow;
            this.labSeConnecterMdp.Location = new System.Drawing.Point(1073, 560);
            this.labSeConnecterMdp.Name = "labSeConnecterMdp";
            this.labSeConnecterMdp.Size = new System.Drawing.Size(113, 20);
            this.labSeConnecterMdp.TabIndex = 7;
            this.labSeConnecterMdp.Text = "Mot de passe :";
            // 
            // FormConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1428, 865);
            this.Controls.Add(this.btnSeConnecterValider);
            this.Controls.Add(this.txbSeConnecterLogin);
            this.Controls.Add(this.labSeConnecterMdp);
            this.Controls.Add(this.labSeConnecterPseudo);
            this.Controls.Add(this.txbSeConnecterMdp);
            this.MinimizeBox = false;
            this.Name = "FormConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSeConnecterValider;
        private System.Windows.Forms.TextBox txbSeConnecterLogin;
        private System.Windows.Forms.TextBox txbSeConnecterMdp;
        private System.Windows.Forms.Label labSeConnecterPseudo;
        private System.Windows.Forms.Label labSeConnecterMdp;
    }
}

