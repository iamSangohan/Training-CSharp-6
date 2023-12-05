using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionStock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ajouterUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterClient f = new AjouterClient();
            f.Show();
        }

        private void listeDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeClients f = new ListeClients();
            f.Show();
        }

        private void ajouterUnFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterFournisseur f = new AjouterFournisseur();
            f.Show();
        }

        private void listeDesFournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeFournisseurs f = new ListeFournisseurs();
            f.Show();
        }

        private void ajouterProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterProduit f = new AjouterProduit();
            f.Show();
        }

        private void listeDeProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeProduits f = new ListeProduits();
            f.Show();
        }

        private void rechercheProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindProd f = new FindProd();
            f.Show();
        }

        private void ajouterUneFactureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
