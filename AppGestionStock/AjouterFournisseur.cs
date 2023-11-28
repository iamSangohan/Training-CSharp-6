using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Runtime.CompilerServices.RuntimeHelpers;


namespace AppGestionStock
{
    public partial class AjouterFournisseur : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        DataTable tab;
        DataRow dtr;
        int indice;

        public AjouterFournisseur()
        {
            InitializeComponent();

            cnx = new SqlConnection();
            //connexion avec le serveurs de base de données
            cnx.ConnectionString = "Data Source=DESKTOP-OQ50T8E;Initial Catalog=BDStock;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

            //Ouverture de la connexion
            cnx.Open();

            //commande de selection des données
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Fournisseur";
            cmd.Connection = cnx;

            //chargement des données dans une table
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Fournisseur");
            tab = dset.Tables[0];

            //chargement des données dans l'interface
            indice = 0;
            TBCode.Text = (tab.Rows[0][0]).ToString();
            TBNomPre.Text = (tab.Rows[0][1]).ToString();
            TBAdresse.Text = (tab.Rows[0][2]).ToString();
            TBTel.Text = (tab.Rows[0][3]).ToString();
            TBFax.Text = (tab.Rows[0][4]).ToString();
            ajouter.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TBCode.Text = "";
            TBNomPre.Text = "";
            TBAdresse.Text = "";
            TBTel.Text = "";
            TBFax.Text = "";
            ajouter.Enabled = true;
        }

        private void premier_Click(object sender, EventArgs e)
        {
            indice = 0;
            TBCode.Text = (tab.Rows[0][0]).ToString();
            TBNomPre.Text = (tab.Rows[0][1]).ToString();
            TBAdresse.Text = (tab.Rows[0][2]).ToString();
            TBTel.Text = (tab.Rows[0][3]).ToString();
            TBFax.Text = (tab.Rows[0][4]).ToString();
        }

        private void precedant_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                TBCode.Text = (tab.Rows[indice][0]).ToString();
                TBNomPre.Text = (tab.Rows[indice][1]).ToString();
                TBAdresse.Text = (tab.Rows[indice][2]).ToString();
                TBTel.Text = (tab.Rows[indice][3]).ToString();
                TBFax.Text = (tab.Rows[indice][4]).ToString();
            }
        }

        private void suivant_Click(object sender, EventArgs e)
        {
            if (indice < tab.Rows.Count - 1)
            {
                indice++;
                TBCode.Text = (tab.Rows[indice][0]).ToString();
                TBNomPre.Text = (tab.Rows[indice][1]).ToString();
                TBAdresse.Text = (tab.Rows[indice][2]).ToString();
                TBTel.Text = (tab.Rows[indice][3]).ToString();
                TBFax.Text = (tab.Rows[indice][4]).ToString();
            }
        }

        private void dernier_Click(object sender, EventArgs e)
        {
            indice = tab.Rows.Count - 1;
            TBCode.Text = (tab.Rows[indice][0]).ToString();
            TBNomPre.Text = (tab.Rows[indice][1]).ToString();
            TBAdresse.Text = (tab.Rows[indice][2]).ToString();
            TBTel.Text = (tab.Rows[indice][3]).ToString();
            TBFax.Text = (tab.Rows[indice][4]).ToString();
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            dtr = tab.NewRow();
            dtr[0] = TBCode.Text;
            dtr[1] = TBNomPre.Text;
            dtr[2] = TBAdresse.Text;
            dtr[3] = TBTel.Text;
            dtr[4] = TBFax.Text;
            dset.Tables[0].Rows.Add(dtr);
            tab = dset.Tables[0];
            indice = tab.Rows.Count - 1;
            MessageBox.Show("Fournisseur ajouté");
            ajouter.Enabled = false;
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer ce fournisseur ? ", "Confirmer suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dset.Tables[0].Rows[indice].Delete();
                    dset.AcceptChanges();
                    indice--;
                    tab = dset.Tables[0];
                    if (indice < 0)
                        indice = 0;
                    if (tab.Rows.Count != 0)
                    {
                        TBCode.Text = (tab.Rows[indice][0]).ToString();
                        TBNomPre.Text = (tab.Rows[indice][1]).ToString();
                        TBAdresse.Text = (tab.Rows[indice][2]).ToString();
                        TBTel.Text = (tab.Rows[indice][3]).ToString();
                        TBFax.Text = (tab.Rows[indice][4]).ToString();
                    }
                    else
                    {
                        TBCode.Text = "";
                        TBNomPre.Text = "";
                        TBAdresse.Text = "";
                        TBTel.Text = "";
                        TBFax.Text = "";
                        MessageBox.Show("Fournisseur Supprimé");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            try
            {
                dset.Tables[0].Rows[indice][0] = TBCode.Text;
                dset.Tables[0].Rows[indice][1] = TBNomPre.Text;
                dset.Tables[0].Rows[indice][2] = TBAdresse.Text;
                dset.Tables[0].Rows[indice][3] = TBTel.Text;
                dset.Tables[0].Rows[indice][4] = TBFax.Text;
                tab = dset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                cb = new SqlCommandBuilder(adap);
                adap.Update(dset, "Fournisseur");
                dset.Clear();
                adap.Fill(dset, "Fournisseur");
                tab = dset.Tables[0];
                MessageBox.Show("Données enregistrées dans la base");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
