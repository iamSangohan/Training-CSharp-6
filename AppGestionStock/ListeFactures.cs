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
    public partial class ListeFactures : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset, dset2;

        public ListeFactures()
        {
            InitializeComponent();

            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=DESKTOP-OQ50T8E;Initial Catalog=BDStock;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
            cnx.Open();
            cmd = new SqlCommand();

            // Produit dans la combobox
            cmd.CommandText = "select * from Produit";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Produit");
            DataRow dr;
            dr = dset.Tables[0].NewRow();
            dr["NomProduit"] = "Toute la liste";
            dset.Tables[0].Rows.Add(dr);
            CBProduit.DataSource = dset.Tables[0];
            CBProduit.DisplayMember = "NomProduit";
            CBProduit.ValueMember = "CodeProduit";
            // Client dans la combobox
            cmd.CommandText = "select * from Client";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Client");
            dr = dset.Tables[0].NewRow();
            dr["Nom"] = "Toute la liste";
            dset.Tables[0].Rows.Add(dr);
            CBClient.DataSource = dset.Tables[0];
            CBClient.DisplayMember = "Nom";
            CBClient.ValueMember = "CodeClient";

            cmd = new SqlCommand();
            cmd.CommandText = "select CodeFacture, DateFacture, Nom as 'Client', NomProduit as 'Produit', PrixUnitaire, Quantite, PrixTotal from Facture F, Client C, Produit P where F.CodeClient = C.CodeClient and F.CodeProduit = P.CodeProduit";
            //cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset2 = new DataSet();
            adap.Fill(dset2, "Facture");
            dataGridView1.DataSource = dset2.Tables[0];
            CBProduit.SelectedIndex = CBProduit.Items.Count - 1;
        }
    }
}
