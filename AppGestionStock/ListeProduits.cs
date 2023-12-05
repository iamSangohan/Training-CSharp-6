using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGestionStock
{
    public partial class ListeProduits : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset, dset2;

        public ListeProduits()
        {
            InitializeComponent();

            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=DESKTOP-OQ50T8E;Initial Catalog=BDStock;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
            cnx.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Fournisseur";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Fournisseur");
            DataRow dr;
            dr = dset.Tables[0].NewRow();
            dr["NomPrenom"] = "Toute la liste";
            dset.Tables[0].Rows.Add(dr);
            CBFournisseur.DataSource = dset.Tables[0];
            CBFournisseur.DisplayMember = "NomPrenom";
            CBFournisseur.ValueMember = "CodeFourn";
            cmd = new SqlCommand();
            cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset2 = new DataSet();
            adap.Fill(dset2, "Produit");
            dataGridView1.DataSource = dset2.Tables[0];
            CBFournisseur.SelectedIndex = CBFournisseur.Items.Count - 1;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer ce produit ? ", "Supprimer un Produit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cmd.CommandText = "delete from Produit where CodeProduit=" +

                    dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("suppression effectuée avec succes", "Suppression");
                    cmd = new SqlCommand();
                    cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn";
                    cmd.Connection = cnx;
                    adap = new SqlDataAdapter(cmd);
                    dset2 = new DataSet();
                    adap.Fill(dset2, "Produit");
                    dataGridView1.DataSource = dset2.Tables[0];
                    CBFournisseur.SelectedIndex = CBFournisseur.Items.Count - 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous enregistrer les modifications ? ", "Confirmer modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cb = new SqlCommandBuilder(adap);
                    adap.Update(dset, "Produit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBFournisseur_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            if (CBFournisseur.SelectedIndex == CBFournisseur.Items.Count - 1) {
                cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn";

            }
            else {
                cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn and P.CodeFourn = " + CBFournisseur.SelectedValue;
                cmd.Connection = cnx;
                adap = new SqlDataAdapter(cmd);
                dset2 = new DataSet();
                adap.Fill(dset2, "Produit");
                dataGridView1.DataSource = dset2.Tables[0];
            }
        }
    }
}
