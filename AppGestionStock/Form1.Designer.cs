namespace AppGestionStock
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listeDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listeDesFournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDeProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rechercheProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.afficherUneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnClientToolStripMenuItem,
            this.toolStripSeparator1,
            this.listeDesClientsToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // ajouterUnClientToolStripMenuItem
            // 
            this.ajouterUnClientToolStripMenuItem.Name = "ajouterUnClientToolStripMenuItem";
            this.ajouterUnClientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterUnClientToolStripMenuItem.Text = "Ajouter un client";
            this.ajouterUnClientToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnClientToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // listeDesClientsToolStripMenuItem
            // 
            this.listeDesClientsToolStripMenuItem.Name = "listeDesClientsToolStripMenuItem";
            this.listeDesClientsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeDesClientsToolStripMenuItem.Text = "Liste des clients";
            this.listeDesClientsToolStripMenuItem.Click += new System.EventHandler(this.listeDesClientsToolStripMenuItem_Click);
            // 
            // fournisseursToolStripMenuItem
            // 
            this.fournisseursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnFournisseurToolStripMenuItem,
            this.toolStripSeparator2,
            this.listeDesFournisseursToolStripMenuItem});
            this.fournisseursToolStripMenuItem.Name = "fournisseursToolStripMenuItem";
            this.fournisseursToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.fournisseursToolStripMenuItem.Text = "Fournisseurs";
            // 
            // ajouterUnFournisseurToolStripMenuItem
            // 
            this.ajouterUnFournisseurToolStripMenuItem.Name = "ajouterUnFournisseurToolStripMenuItem";
            this.ajouterUnFournisseurToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ajouterUnFournisseurToolStripMenuItem.Text = "Ajouter un fournisseur";
            this.ajouterUnFournisseurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnFournisseurToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // listeDesFournisseursToolStripMenuItem
            // 
            this.listeDesFournisseursToolStripMenuItem.Name = "listeDesFournisseursToolStripMenuItem";
            this.listeDesFournisseursToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.listeDesFournisseursToolStripMenuItem.Text = "Liste des fournisseurs";
            this.listeDesFournisseursToolStripMenuItem.Click += new System.EventHandler(this.listeDesFournisseursToolStripMenuItem_Click);
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterProduitToolStripMenuItem,
            this.listeDeProduitsToolStripMenuItem,
            this.toolStripSeparator3,
            this.rechercheProduitToolStripMenuItem});
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.produitsToolStripMenuItem.Text = "Produits";
            // 
            // ajouterProduitToolStripMenuItem
            // 
            this.ajouterProduitToolStripMenuItem.Name = "ajouterProduitToolStripMenuItem";
            this.ajouterProduitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterProduitToolStripMenuItem.Text = "Ajouter produit";
            this.ajouterProduitToolStripMenuItem.Click += new System.EventHandler(this.ajouterProduitToolStripMenuItem_Click);
            // 
            // listeDeProduitsToolStripMenuItem
            // 
            this.listeDeProduitsToolStripMenuItem.Name = "listeDeProduitsToolStripMenuItem";
            this.listeDeProduitsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeDeProduitsToolStripMenuItem.Text = "Liste de produits";
            this.listeDeProduitsToolStripMenuItem.Click += new System.EventHandler(this.listeDeProduitsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // rechercheProduitToolStripMenuItem
            // 
            this.rechercheProduitToolStripMenuItem.Name = "rechercheProduitToolStripMenuItem";
            this.rechercheProduitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rechercheProduitToolStripMenuItem.Text = "Recherche produit";
            this.rechercheProduitToolStripMenuItem.Click += new System.EventHandler(this.rechercheProduitToolStripMenuItem_Click);
            // 
            // facturesToolStripMenuItem
            // 
            this.facturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneFactureToolStripMenuItem,
            this.toolStripSeparator4,
            this.afficherUneFactureToolStripMenuItem,
            this.listeDesFacturesToolStripMenuItem});
            this.facturesToolStripMenuItem.Name = "facturesToolStripMenuItem";
            this.facturesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.facturesToolStripMenuItem.Text = "Factures";
            // 
            // ajouterUneFactureToolStripMenuItem
            // 
            this.ajouterUneFactureToolStripMenuItem.Name = "ajouterUneFactureToolStripMenuItem";
            this.ajouterUneFactureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterUneFactureToolStripMenuItem.Text = "Ajouter une facture";
            this.ajouterUneFactureToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneFactureToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(176, 6);
            // 
            // afficherUneFactureToolStripMenuItem
            // 
            this.afficherUneFactureToolStripMenuItem.Name = "afficherUneFactureToolStripMenuItem";
            this.afficherUneFactureToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.afficherUneFactureToolStripMenuItem.Text = "Afficher une facture";
            // 
            // listeDesFacturesToolStripMenuItem
            // 
            this.listeDesFacturesToolStripMenuItem.Name = "listeDesFacturesToolStripMenuItem";
            this.listeDesFacturesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.listeDesFacturesToolStripMenuItem.Text = "Liste des factures";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesFournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDeProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem listeDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem afficherUneFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesFacturesToolStripMenuItem;
    }
}

