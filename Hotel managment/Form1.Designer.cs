namespace Hotel_managment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNavigation = new System.Windows.Forms.Label();
            this.buttonDernier = new System.Windows.Forms.Button();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonPremier = new System.Windows.Forms.Button();
            this.buttonEnregistrer = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonNouveau = new System.Windows.Forms.Button();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNomH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumerohotel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 315);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(613, 204);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblNavigation
            // 
            this.lblNavigation.BackColor = System.Drawing.Color.Yellow;
            this.lblNavigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavigation.ForeColor = System.Drawing.Color.Red;
            this.lblNavigation.Location = new System.Drawing.Point(135, 271);
            this.lblNavigation.Name = "lblNavigation";
            this.lblNavigation.Size = new System.Drawing.Size(173, 30);
            this.lblNavigation.TabIndex = 68;
            this.lblNavigation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDernier
            // 
            this.buttonDernier.Location = new System.Drawing.Point(369, 270);
            this.buttonDernier.Name = "buttonDernier";
            this.buttonDernier.Size = new System.Drawing.Size(50, 33);
            this.buttonDernier.TabIndex = 67;
            this.buttonDernier.Text = "|<";
            this.buttonDernier.UseVisualStyleBackColor = true;
            this.buttonDernier.Click += new System.EventHandler(this.buttonDernier_Click);
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Location = new System.Drawing.Point(316, 270);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(48, 33);
            this.buttonPrecedent.TabIndex = 66;
            this.buttonPrecedent.Text = "<<";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Location = new System.Drawing.Point(79, 270);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(54, 33);
            this.buttonSuivant.TabIndex = 65;
            this.buttonSuivant.Text = ">>";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // buttonPremier
            // 
            this.buttonPremier.Location = new System.Drawing.Point(19, 270);
            this.buttonPremier.Name = "buttonPremier";
            this.buttonPremier.Size = new System.Drawing.Size(55, 33);
            this.buttonPremier.TabIndex = 64;
            this.buttonPremier.Text = ">|";
            this.buttonPremier.UseVisualStyleBackColor = true;
            this.buttonPremier.Click += new System.EventHandler(this.buttonPremier_Click);
            // 
            // buttonEnregistrer
            // 
            this.buttonEnregistrer.Location = new System.Drawing.Point(438, 109);
            this.buttonEnregistrer.Name = "buttonEnregistrer";
            this.buttonEnregistrer.Size = new System.Drawing.Size(80, 46);
            this.buttonEnregistrer.TabIndex = 63;
            this.buttonEnregistrer.Text = "Enregistrer";
            this.buttonEnregistrer.UseVisualStyleBackColor = true;
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(438, 263);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(80, 46);
            this.buttonRechercher.TabIndex = 62;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(438, 210);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(80, 46);
            this.buttonSupprimer.TabIndex = 61;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(438, 158);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(80, 46);
            this.buttonModifier.TabIndex = 60;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(438, 59);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(80, 46);
            this.buttonAjouter.TabIndex = 59;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonNouveau
            // 
            this.buttonNouveau.Location = new System.Drawing.Point(438, 7);
            this.buttonNouveau.Name = "buttonNouveau";
            this.buttonNouveau.Size = new System.Drawing.Size(80, 46);
            this.buttonNouveau.TabIndex = 58;
            this.buttonNouveau.Text = "Nouveau";
            this.buttonNouveau.UseVisualStyleBackColor = true;
            this.buttonNouveau.Click += new System.EventHandler(this.buttonNouveau_Click);
            // 
            // textBoxVille
            // 
            this.textBoxVille.Location = new System.Drawing.Point(138, 110);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(198, 20);
            this.textBoxVille.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Ville :";
            // 
            // textBoxNomH
            // 
            this.textBoxNomH.Location = new System.Drawing.Point(138, 85);
            this.textBoxNomH.Name = "textBoxNomH";
            this.textBoxNomH.Size = new System.Drawing.Size(198, 20);
            this.textBoxNomH.TabIndex = 45;
            this.textBoxNomH.TextChanged += new System.EventHandler(this.textBoxLibelle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nom :";
            // 
            // textBoxNumerohotel
            // 
            this.textBoxNumerohotel.Location = new System.Drawing.Point(138, 60);
            this.textBoxNumerohotel.Name = "textBoxNumerohotel";
            this.textBoxNumerohotel.Size = new System.Drawing.Size(198, 20);
            this.textBoxNumerohotel.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Numero :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Etoils :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 187);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(29, 17);
            this.radioButton1.TabIndex = 71;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "*";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(99, 187);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(33, 17);
            this.radioButton2.TabIndex = 72;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "**";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(184, 187);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 17);
            this.radioButton3.TabIndex = 73;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "***";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(273, 187);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(41, 17);
            this.radioButton4.TabIndex = 74;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "****";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(366, 187);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(45, 17);
            this.radioButton5.TabIndex = 75;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "*****";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 523);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblNavigation);
            this.Controls.Add(this.buttonDernier);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonPremier);
            this.Controls.Add(this.buttonEnregistrer);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonNouveau);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNomH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNumerohotel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNavigation;
        private System.Windows.Forms.Button buttonDernier;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonPremier;
        private System.Windows.Forms.Button buttonEnregistrer;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonNouveau;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNomH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumerohotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}

