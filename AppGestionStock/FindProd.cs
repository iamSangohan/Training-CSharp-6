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
    public partial class FindProd : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset2;

        public FindProd()
        {
            InitializeComponent();

            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=DESKTOP-OQ50T8E;Initial Catalog=BDStock;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
            cnx.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Produit";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset2 = new DataSet();
            adap.Fill(dset2, "Produit");
            dataGridView1.DataSource = dset2.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rdbnom.Checked)
            {
                cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn and NomProduit like('" + textBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                adap = new SqlDataAdapter(cmd);
                dset2 = new DataSet();
                adap.Fill(dset2, "Produit");
                dataGridView1.DataSource = dset2.Tables[0];
            }
            if (rdbcode.Checked)
            {
                cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn and CodeProduit like('" + textBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                adap = new SqlDataAdapter(cmd);
                dset2 = new DataSet();
                adap.Fill(dset2, "Produit");
                dataGridView1.DataSource = dset2.Tables[0];
            }
        }
    }
}
