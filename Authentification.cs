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
using System.Data;
namespace GestionTâche
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;


        private void Authentification_Load(object sender, EventArgs e)
        {
           
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            string mail = txtemail.Text;
            String pass = txtpasswd.Text;
            String Query = "Select * from Utilisateur where Mail='"+mail+"' and Passwd='"+pass+"';";
            SqlCommand cmd = new SqlCommand(Query, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read()) { 
                this.Hide();
                    Acceuil p = new Acceuil((int)rd[0]);
               
                    p.Show();
                }
            }
            else
            {
                if (mail.Equals(""))
                {
                    MessageBox.Show("Entrez votre E-mail pour vous connecter", "E-mail vide", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }else if (pass.Equals(""))
                {
                    MessageBox.Show("Entrez votre Mot de passe pour vous connecter", "E-mail vide", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Mot de passe ou E-mail incorrect", "Incorrect données", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }

            cnx.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inscription au= new Inscription();
            au.Show();
        }

        private void txtpasswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
