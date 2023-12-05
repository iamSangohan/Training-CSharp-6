namespace AppGestionStock
{
    partial class AjouterProduit
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
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.code = new System.Windows.Forms.Label();
            this.TBCode = new System.Windows.Forms.TextBox();
            this.TBNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPrixUnitaire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBQuantite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            this.CBFournisseur = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnClientToolStripMenuItem,
            this.listeDesClientsToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // ajouterUnClientToolStripMenuItem
            // 
            this.ajouterUnClientToolStripMenuItem.Name = "ajouterUnClientToolStripMenuItem";
            this.ajouterUnClientToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ajouterUnClientToolStripMenuItem.Text = "Ajouter un client";
            // 
            // listeDesClientsToolStripMenuItem
            // 
            this.listeDesClientsToolStripMenuItem.Name = "listeDesClientsToolStripMenuItem";
            this.listeDesClientsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listeDesClientsToolStripMenuItem.Text = "Liste des clients";
            // 
            // fournisseursToolStripMenuItem
            // 
            this.fournisseursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnFournisseurToolStripMenuItem});
            this.fournisseursToolStripMenuItem.Name = "fournisseursToolStripMenuItem";
            this.fournisseursToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.fournisseursToolStripMenuItem.Text = "Fournisseurs";
            // 
            // ajouterUnFournisseurToolStripMenuItem
            // 
            this.ajouterUnFournisseurToolStripMenuItem.Name = "ajouterUnFournisseurToolStripMenuItem";
            this.ajouterUnFournisseurToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ajouterUnFournisseurToolStripMenuItem.Text = "Ajouter un fournisseur";
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.produitsToolStripMenuItem.Text = "Produits";
            // 
            // facturesToolStripMenuItem
            // 
            this.facturesToolStripMenuItem.Name = "facturesToolStripMenuItem";
            this.facturesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.facturesToolStripMenuItem.Text = "Factures";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.fournisseursToolStripMenuItem,
            this.produitsToolStripMenuItem,
            this.facturesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un produit";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(116, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 83);
            this.panel1.TabIndex = 5;
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(241, 152);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(32, 13);
            this.code.TabIndex = 6;
            this.code.Text = "Code";
            // 
            // TBCode
            // 
            this.TBCode.Location = new System.Drawing.Point(402, 149);
            this.TBCode.Name = "TBCode";
            this.TBCode.Size = new System.Drawing.Size(159, 20);
            this.TBCode.TabIndex = 7;
            // 
            // TBNom
            // 
            this.TBNom.Location = new System.Drawing.Point(402, 193);
            this.TBNom.Name = "TBNom";
            this.TBNom.Size = new System.Drawing.Size(159, 20);
            this.TBNom.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom";
            // 
            // TBPrixUnitaire
            // 
            this.TBPrixUnitaire.Location = new System.Drawing.Point(402, 239);
            this.TBPrixUnitaire.Name = "TBPrixUnitaire";
            this.TBPrixUnitaire.Size = new System.Drawing.Size(159, 20);
            this.TBPrixUnitaire.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Prix unitaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fournisseur";
            // 
            // TBQuantite
            // 
            this.TBQuantite.Location = new System.Drawing.Point(402, 331);
            this.TBQuantite.Name = "TBQuantite";
            this.TBQuantite.Size = new System.Drawing.Size(159, 20);
            this.TBQuantite.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Quantité";
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(244, 381);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(119, 38);
            this.ajouter.TabIndex = 16;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(442, 381);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(119, 38);
            this.quitter.TabIndex = 17;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            // 
            // CBFournisseur
            // 
            this.CBFournisseur.FormattingEnabled = true;
            this.CBFournisseur.Location = new System.Drawing.Point(402, 286);
            this.CBFournisseur.Name = "CBFournisseur";
            this.CBFournisseur.Size = new System.Drawing.Size(159, 21);
            this.CBFournisseur.TabIndex = 18;
            // 
            // AjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CBFournisseur);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.TBQuantite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBPrixUnitaire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBCode);
            this.Controls.Add(this.code);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AjouterProduit";
            this.Text = "AjouterProduit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.TextBox TBCode;
        private System.Windows.Forms.TextBox TBNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBPrixUnitaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBQuantite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.ComboBox CBFournisseur;
    }
}