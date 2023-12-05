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
using System.Data.SqlClient;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace AppGestionStock
{
    public partial class AjouterProduit : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;

        public AjouterProduit()
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
            CBFournisseur.DataSource = dset.Tables[0];
            CBFournisseur.DisplayMember = "NomPrenom";
            CBFournisseur.ValueMember = "CodeFourn";
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment ajouter ce produit ?", "Ajout d'un Produit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Convertir les données saisies en paramètres
                int code = int.Parse(TBCode.Text);
                int fournisseur = int.Parse(CBFournisseur.SelectedValue.ToString());
                String nom = TBNom.Text;
                String prix = TBPrixUnitaire.Text;
                int quantite = int.Parse(TBQuantite.Text);

                try
                { 
                    cmd.CommandText = "insert into Produit values (" + code + "," + fournisseur + ",'" + nom + "', '" + prix + "'," + quantite + ")";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insertion effectuée avec succes", "Insertion");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
