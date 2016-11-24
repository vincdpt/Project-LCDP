namespace PpeGSBTeam27
{
    partial class BackOfficeGSB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabGestionGSB = new System.Windows.Forms.TabControl();
            this.tabProduits = new System.Windows.Forms.TabPage();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.tabVisiteurs = new System.Windows.Forms.TabPage();
            this.tabProduitsGestion = new System.Windows.Forms.TabControl();
            this.tabProduitsCreer = new System.Windows.Forms.TabPage();
            this.tabProduitsModifier = new System.Windows.Forms.TabPage();
            this.tabProduitsSupprimer = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labProduitsCreerNum = new System.Windows.Forms.Label();
            this.labProduitsCreerNom = new System.Windows.Forms.Label();
            this.labProduitsCreerEffets = new System.Windows.Forms.Label();
            this.labProduitsCreerContreIndic = new System.Windows.Forms.Label();
            this.labProduitsCreerInteractions = new System.Windows.Forms.Label();
            this.labProduitsCreerPresentation = new System.Windows.Forms.Label();
            this.labProduitsCreerDosage = new System.Windows.Forms.Label();
            this.labProduitsCreerFamille = new System.Windows.Forms.Label();
            this.labProduitsCreerPrixHT = new System.Windows.Forms.Label();
            this.labProduitsCreerPrixEchant = new System.Windows.Forms.Label();
            this.btnProduitsCreerValider = new System.Windows.Forms.Button();
            this.btnProduitsCreerAnnuler = new System.Windows.Forms.Button();
            this.txbProduitsCreerNum = new System.Windows.Forms.TextBox();
            this.txbProduitsCreerNom = new System.Windows.Forms.TextBox();
            this.txbProduitsCreerEffets = new System.Windows.Forms.TextBox();
            this.txbProduitsCreerContreIndication = new System.Windows.Forms.TextBox();
            this.txbProduitsCreerInteraction = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txbProduitsCreerDosage = new System.Windows.Forms.TextBox();
            this.cbxProduitsCreerFamille = new System.Windows.Forms.ComboBox();
            this.txbProduitsCreerPrixHT = new System.Windows.Forms.TextBox();
            this.txbProduitsCreerPrixEchant = new System.Windows.Forms.TextBox();
            this.tabGestionGSB.SuspendLayout();
            this.tabProduits.SuspendLayout();
            this.tabProduitsGestion.SuspendLayout();
            this.tabProduitsCreer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabGestionGSB
            // 
            this.tabGestionGSB.Controls.Add(this.tabProduits);
            this.tabGestionGSB.Controls.Add(this.tabClients);
            this.tabGestionGSB.Controls.Add(this.tabVisiteurs);
            this.tabGestionGSB.Location = new System.Drawing.Point(-3, -2);
            this.tabGestionGSB.Name = "tabGestionGSB";
            this.tabGestionGSB.SelectedIndex = 0;
            this.tabGestionGSB.Size = new System.Drawing.Size(1435, 871);
            this.tabGestionGSB.TabIndex = 0;
            // 
            // tabProduits
            // 
            this.tabProduits.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabProduits.Controls.Add(this.dataGridView1);
            this.tabProduits.Controls.Add(this.tabProduitsGestion);
            this.tabProduits.Location = new System.Drawing.Point(4, 22);
            this.tabProduits.Name = "tabProduits";
            this.tabProduits.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduits.Size = new System.Drawing.Size(1427, 845);
            this.tabProduits.TabIndex = 0;
            this.tabProduits.Text = "Produits";
            // 
            // tabClients
            // 
            this.tabClients.Location = new System.Drawing.Point(4, 22);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(1427, 845);
            this.tabClients.TabIndex = 1;
            this.tabClients.Text = "Clients";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // tabVisiteurs
            // 
            this.tabVisiteurs.Location = new System.Drawing.Point(4, 22);
            this.tabVisiteurs.Name = "tabVisiteurs";
            this.tabVisiteurs.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisiteurs.Size = new System.Drawing.Size(1427, 845);
            this.tabVisiteurs.TabIndex = 2;
            this.tabVisiteurs.Text = "Visiteurs";
            this.tabVisiteurs.UseVisualStyleBackColor = true;
            // 
            // tabProduitsGestion
            // 
            this.tabProduitsGestion.Controls.Add(this.tabProduitsCreer);
            this.tabProduitsGestion.Controls.Add(this.tabProduitsModifier);
            this.tabProduitsGestion.Controls.Add(this.tabProduitsSupprimer);
            this.tabProduitsGestion.Location = new System.Drawing.Point(3, 3);
            this.tabProduitsGestion.Name = "tabProduitsGestion";
            this.tabProduitsGestion.SelectedIndex = 0;
            this.tabProduitsGestion.Size = new System.Drawing.Size(439, 540);
            this.tabProduitsGestion.TabIndex = 0;
            // 
            // tabProduitsCreer
            // 
            this.tabProduitsCreer.Controls.Add(this.txbProduitsCreerPrixEchant);
            this.tabProduitsCreer.Controls.Add(this.txbProduitsCreerPrixHT);
            this.tabProduitsCreer.Controls.Add(this.cbxProduitsCreerFamille);
            this.tabProduitsCreer.Controls.Add(this.txbProduitsCreerDosage);
            this.tabProduitsCreer.Controls.Add(this.textBox1);
            this.tabProduitsCreer.Controls.Add(this.txbProduitsCreerInteraction);
            this.tabProduitsCreer.Controls.Add(this.txbProduitsCreerContreIndication);
            this.tabProduitsCreer.Controls.Add(this.txbProduitsCreerEffets);
            this.tabProduitsCreer.Controls.Add(this.txbProduitsCreerNom);
            this.tabProduitsCreer.Controls.Add(this.txbProduitsCreerNum);
            this.tabProduitsCreer.Controls.Add(this.btnProduitsCreerAnnuler);
            this.tabProduitsCreer.Controls.Add(this.btnProduitsCreerValider);
            this.tabProduitsCreer.Controls.Add(this.labProduitsCreerPrixEchant);
            this.tabProduitsCreer.Controls.Add(this.labProduitsCreerPrixHT);
            this.tabProduitsCreer.Controls.Add(this.labProduitsCreerFamille);
            this.tabProduitsCreer.Controls.Add(this.labProduitsCreerDosage);
            this.tabProduitsCreer.Controls.Add(this.labProduitsCreerPresentation);
            this.tabProduitsCreer.Controls.Add(this.labProduitsCreerInteractions);
            this.tabProduitsCreer.Controls.Add(this.labProduitsCreerContreIndic);
            this.tabProduitsCreer.Controls.Add(this.labProduitsCreerEffets);
            this.tabProduitsCreer.Controls.Add(this.labProduitsCreerNom);
            this.tabProduitsCreer.Controls.Add(this.labProduitsCreerNum);
            this.tabProduitsCreer.Location = new System.Drawing.Point(4, 22);
            this.tabProduitsCreer.Name = "tabProduitsCreer";
            this.tabProduitsCreer.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduitsCreer.Size = new System.Drawing.Size(431, 514);
            this.tabProduitsCreer.TabIndex = 0;
            this.tabProduitsCreer.Text = "Créer";
            this.tabProduitsCreer.UseVisualStyleBackColor = true;
            // 
            // tabProduitsModifier
            // 
            this.tabProduitsModifier.Location = new System.Drawing.Point(4, 22);
            this.tabProduitsModifier.Name = "tabProduitsModifier";
            this.tabProduitsModifier.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduitsModifier.Size = new System.Drawing.Size(209, 161);
            this.tabProduitsModifier.TabIndex = 1;
            this.tabProduitsModifier.Text = "Modifier";
            this.tabProduitsModifier.UseVisualStyleBackColor = true;
            // 
            // tabProduitsSupprimer
            // 
            this.tabProduitsSupprimer.Location = new System.Drawing.Point(4, 22);
            this.tabProduitsSupprimer.Name = "tabProduitsSupprimer";
            this.tabProduitsSupprimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduitsSupprimer.Size = new System.Drawing.Size(209, 161);
            this.tabProduitsSupprimer.TabIndex = 2;
            this.tabProduitsSupprimer.Text = "Supprimer";
            this.tabProduitsSupprimer.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(500, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(915, 656);
            this.dataGridView1.TabIndex = 1;
            // 
            // labProduitsCreerNum
            // 
            this.labProduitsCreerNum.AutoSize = true;
            this.labProduitsCreerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProduitsCreerNum.Location = new System.Drawing.Point(15, 14);
            this.labProduitsCreerNum.Name = "labProduitsCreerNum";
            this.labProduitsCreerNum.Size = new System.Drawing.Size(139, 18);
            this.labProduitsCreerNum.TabIndex = 0;
            this.labProduitsCreerNum.Text = "Numéro du produit :";
            // 
            // labProduitsCreerNom
            // 
            this.labProduitsCreerNom.AutoSize = true;
            this.labProduitsCreerNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProduitsCreerNom.Location = new System.Drawing.Point(15, 36);
            this.labProduitsCreerNom.Name = "labProduitsCreerNom";
            this.labProduitsCreerNom.Size = new System.Drawing.Size(49, 18);
            this.labProduitsCreerNom.TabIndex = 1;
            this.labProduitsCreerNom.Text = "Nom :";
            // 
            // labProduitsCreerEffets
            // 
            this.labProduitsCreerEffets.AutoSize = true;
            this.labProduitsCreerEffets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProduitsCreerEffets.Location = new System.Drawing.Point(15, 70);
            this.labProduitsCreerEffets.Name = "labProduitsCreerEffets";
            this.labProduitsCreerEffets.Size = new System.Drawing.Size(154, 18);
            this.labProduitsCreerEffets.TabIndex = 2;
            this.labProduitsCreerEffets.Text = "Effets thérapeutiques :";
            this.labProduitsCreerEffets.Click += new System.EventHandler(this.labProduitsCreerEffets_Click);
            // 
            // labProduitsCreerContreIndic
            // 
            this.labProduitsCreerContreIndic.AutoSize = true;
            this.labProduitsCreerContreIndic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProduitsCreerContreIndic.Location = new System.Drawing.Point(15, 116);
            this.labProduitsCreerContreIndic.Name = "labProduitsCreerContreIndic";
            this.labProduitsCreerContreIndic.Size = new System.Drawing.Size(136, 18);
            this.labProduitsCreerContreIndic.TabIndex = 3;
            this.labProduitsCreerContreIndic.Text = "Contre-indications :";
            // 
            // labProduitsCreerInteractions
            // 
            this.labProduitsCreerInteractions.AutoSize = true;
            this.labProduitsCreerInteractions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProduitsCreerInteractions.Location = new System.Drawing.Point(15, 156);
            this.labProduitsCreerInteractions.Name = "labProduitsCreerInteractions";
            this.labProduitsCreerInteractions.Size = new System.Drawing.Size(161, 36);
            this.labProduitsCreerInteractions.TabIndex = 4;
            this.labProduitsCreerInteractions.Text = "Interactions avec \r\nd\'autres médicaments :";
            // 
            // labProduitsCreerPresentation
            // 
            this.labProduitsCreerPresentation.AutoSize = true;
            this.labProduitsCreerPresentation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProduitsCreerPresentation.Location = new System.Drawing.Point(15, 213);
            this.labProduitsCreerPresentation.Name = "labProduitsCreerPresentation";
            this.labProduitsCreerPresentation.Size = new System.Drawing.Size(99, 18);
            this.labProduitsCreerPresentation.TabIndex = 5;
            this.labProduitsCreerPresentation.Text = "Présentation :";
            // 
            // labProduitsCreerDosage
            // 
            this.labProduitsCreerDosage.AutoSize = true;
            this.labProduitsCreerDosage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProduitsCreerDosage.Location = new System.Drawing.Point(15, 255);
            this.labProduitsCreerDosage.Name = "labProduitsCreerDosage";
            this.labProduitsCreerDosage.Size = new System.Drawing.Size(68, 18);
            this.labProduitsCreerDosage.TabIndex = 6;
            this.labProduitsCreerDosage.Text = "Dosage :";
            // 
            // labProduitsCreerFamille
            // 
            this.labProduitsCreerFamille.AutoSize = true;
            this.labProduitsCreerFamille.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProduitsCreerFamille.Location = new System.Drawing.Point(15, 279);
            this.labProduitsCreerFamille.Name = "labProduitsCreerFamille";
            this.labProduitsCreerFamille.Size = new System.Drawing.Size(63, 18);
            this.labProduitsCreerFamille.TabIndex = 7;
            this.labProduitsCreerFamille.Text = "Famille :";
            // 
            // labProduitsCreerPrixHT
            // 
            this.labProduitsCreerPrixHT.AutoSize = true;
            this.labProduitsCreerPrixHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProduitsCreerPrixHT.Location = new System.Drawing.Point(15, 307);
            this.labProduitsCreerPrixHT.Name = "labProduitsCreerPrixHT";
            this.labProduitsCreerPrixHT.Size = new System.Drawing.Size(75, 18);
            this.labProduitsCreerPrixHT.TabIndex = 8;
            this.labProduitsCreerPrixHT.Text = "Prix (HT) :";
            // 
            // labProduitsCreerPrixEchant
            // 
            this.labProduitsCreerPrixEchant.AutoSize = true;
            this.labProduitsCreerPrixEchant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labProduitsCreerPrixEchant.Location = new System.Drawing.Point(184, 306);
            this.labProduitsCreerPrixEchant.Name = "labProduitsCreerPrixEchant";
            this.labProduitsCreerPrixEchant.Size = new System.Drawing.Size(115, 18);
            this.labProduitsCreerPrixEchant.TabIndex = 9;
            this.labProduitsCreerPrixEchant.Text = "Prix échantillon :";
            // 
            // btnProduitsCreerValider
            // 
            this.btnProduitsCreerValider.Location = new System.Drawing.Point(226, 381);
            this.btnProduitsCreerValider.Name = "btnProduitsCreerValider";
            this.btnProduitsCreerValider.Size = new System.Drawing.Size(175, 99);
            this.btnProduitsCreerValider.TabIndex = 10;
            this.btnProduitsCreerValider.Text = "Valider";
            this.btnProduitsCreerValider.UseVisualStyleBackColor = true;
            // 
            // btnProduitsCreerAnnuler
            // 
            this.btnProduitsCreerAnnuler.Location = new System.Drawing.Point(70, 434);
            this.btnProduitsCreerAnnuler.Name = "btnProduitsCreerAnnuler";
            this.btnProduitsCreerAnnuler.Size = new System.Drawing.Size(135, 46);
            this.btnProduitsCreerAnnuler.TabIndex = 11;
            this.btnProduitsCreerAnnuler.Text = "Annuler";
            this.btnProduitsCreerAnnuler.UseVisualStyleBackColor = true;
            // 
            // txbProduitsCreerNum
            // 
            this.txbProduitsCreerNum.Location = new System.Drawing.Point(160, 15);
            this.txbProduitsCreerNum.Name = "txbProduitsCreerNum";
            this.txbProduitsCreerNum.Size = new System.Drawing.Size(149, 20);
            this.txbProduitsCreerNum.TabIndex = 12;
            // 
            // txbProduitsCreerNom
            // 
            this.txbProduitsCreerNom.Location = new System.Drawing.Point(70, 37);
            this.txbProduitsCreerNom.Name = "txbProduitsCreerNom";
            this.txbProduitsCreerNom.Size = new System.Drawing.Size(239, 20);
            this.txbProduitsCreerNom.TabIndex = 13;
            // 
            // txbProduitsCreerEffets
            // 
            this.txbProduitsCreerEffets.Location = new System.Drawing.Point(175, 58);
            this.txbProduitsCreerEffets.Multiline = true;
            this.txbProduitsCreerEffets.Name = "txbProduitsCreerEffets";
            this.txbProduitsCreerEffets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbProduitsCreerEffets.Size = new System.Drawing.Size(217, 41);
            this.txbProduitsCreerEffets.TabIndex = 14;
            this.txbProduitsCreerEffets.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // txbProduitsCreerContreIndication
            // 
            this.txbProduitsCreerContreIndication.Location = new System.Drawing.Point(157, 105);
            this.txbProduitsCreerContreIndication.Multiline = true;
            this.txbProduitsCreerContreIndication.Name = "txbProduitsCreerContreIndication";
            this.txbProduitsCreerContreIndication.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbProduitsCreerContreIndication.Size = new System.Drawing.Size(235, 41);
            this.txbProduitsCreerContreIndication.TabIndex = 15;
            this.txbProduitsCreerContreIndication.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // txbProduitsCreerInteraction
            // 
            this.txbProduitsCreerInteraction.Location = new System.Drawing.Point(175, 153);
            this.txbProduitsCreerInteraction.Multiline = true;
            this.txbProduitsCreerInteraction.Name = "txbProduitsCreerInteraction";
            this.txbProduitsCreerInteraction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbProduitsCreerInteraction.Size = new System.Drawing.Size(217, 41);
            this.txbProduitsCreerInteraction.TabIndex = 16;
            this.txbProduitsCreerInteraction.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 200);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(272, 41);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // txbProduitsCreerDosage
            // 
            this.txbProduitsCreerDosage.Location = new System.Drawing.Point(89, 256);
            this.txbProduitsCreerDosage.Name = "txbProduitsCreerDosage";
            this.txbProduitsCreerDosage.Size = new System.Drawing.Size(220, 20);
            this.txbProduitsCreerDosage.TabIndex = 18;
            // 
            // cbxProduitsCreerFamille
            // 
            this.cbxProduitsCreerFamille.FormattingEnabled = true;
            this.cbxProduitsCreerFamille.Location = new System.Drawing.Point(89, 282);
            this.cbxProduitsCreerFamille.Name = "cbxProduitsCreerFamille";
            this.cbxProduitsCreerFamille.Size = new System.Drawing.Size(220, 21);
            this.cbxProduitsCreerFamille.TabIndex = 19;
            // 
            // txbProduitsCreerPrixHT
            // 
            this.txbProduitsCreerPrixHT.Location = new System.Drawing.Point(96, 307);
            this.txbProduitsCreerPrixHT.Name = "txbProduitsCreerPrixHT";
            this.txbProduitsCreerPrixHT.Size = new System.Drawing.Size(73, 20);
            this.txbProduitsCreerPrixHT.TabIndex = 20;
            // 
            // txbProduitsCreerPrixEchant
            // 
            this.txbProduitsCreerPrixEchant.Location = new System.Drawing.Point(305, 307);
            this.txbProduitsCreerPrixEchant.Name = "txbProduitsCreerPrixEchant";
            this.txbProduitsCreerPrixEchant.Size = new System.Drawing.Size(87, 20);
            this.txbProduitsCreerPrixEchant.TabIndex = 21;
            // 
            // BackOfficeGSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 865);
            this.Controls.Add(this.tabGestionGSB);
            this.Name = "BackOfficeGSB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackOfficeGSB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabGestionGSB.ResumeLayout(false);
            this.tabProduits.ResumeLayout(false);
            this.tabProduitsGestion.ResumeLayout(false);
            this.tabProduitsCreer.ResumeLayout(false);
            this.tabProduitsCreer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGestionGSB;
        private System.Windows.Forms.TabPage tabProduits;
        private System.Windows.Forms.TabControl tabProduitsGestion;
        private System.Windows.Forms.TabPage tabProduitsCreer;
        private System.Windows.Forms.TabPage tabProduitsModifier;
        private System.Windows.Forms.TabPage tabProduitsSupprimer;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabVisiteurs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbProduitsCreerPrixEchant;
        private System.Windows.Forms.TextBox txbProduitsCreerPrixHT;
        private System.Windows.Forms.ComboBox cbxProduitsCreerFamille;
        private System.Windows.Forms.TextBox txbProduitsCreerDosage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbProduitsCreerInteraction;
        private System.Windows.Forms.TextBox txbProduitsCreerContreIndication;
        private System.Windows.Forms.TextBox txbProduitsCreerEffets;
        private System.Windows.Forms.TextBox txbProduitsCreerNom;
        private System.Windows.Forms.TextBox txbProduitsCreerNum;
        private System.Windows.Forms.Button btnProduitsCreerAnnuler;
        private System.Windows.Forms.Button btnProduitsCreerValider;
        private System.Windows.Forms.Label labProduitsCreerPrixEchant;
        private System.Windows.Forms.Label labProduitsCreerPrixHT;
        private System.Windows.Forms.Label labProduitsCreerFamille;
        private System.Windows.Forms.Label labProduitsCreerDosage;
        private System.Windows.Forms.Label labProduitsCreerPresentation;
        private System.Windows.Forms.Label labProduitsCreerInteractions;
        private System.Windows.Forms.Label labProduitsCreerContreIndic;
        private System.Windows.Forms.Label labProduitsCreerEffets;
        private System.Windows.Forms.Label labProduitsCreerNom;
        private System.Windows.Forms.Label labProduitsCreerNum;
    }
}