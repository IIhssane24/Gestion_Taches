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
using System.Configuration;


namespace GestionTâche
{
    public partial class AjouterProjet : Form
    {
        public AjouterProjet()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Red;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            string titre = textTitreP.Text;
            string Descr = txtDescP.Text;
            String Query = "insert into Projet(Titre,Descriptionp) VALUES ('" + titre + "','" + Descr + "');";
            SqlCommand cmd = new SqlCommand(Query, cnx);
            if (cnx.State == ConnectionState.Open)
                cnx.Close();
            cnx.Open();
            if (!checkInput())
            {

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("L'ajout et bien passée ", "Compte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR ");
                }


            }

        }



        public Boolean checkInput()
        {
            string Titre = textTitreP.Text;


            if (Titre.Trim().Equals(string.Empty))
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        private void txtDescP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
