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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }
        String connectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Red;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnx = new SqlConnection(connectionString))
                {
                    string nom = txtNom.Text;
                       string prenom = txtPrenom.Text;
                        string mail = txtemail.Text;
                        String pass = txtpasswd.Text;
                        String Conf = txtConfPaswd.Text;

                    String Query = "Insert into Utilisateur (Nom,Prenom,Mail,Passwd) VALUES ('"+nom+"','"+prenom+"','"+mail+"','"+pass+"')";
                    SqlCommand cmd = new SqlCommand(Query, cnx);
                    if (cnx.State == ConnectionState.Open)
                        cnx.Close();
                       cnx.Open();
                    if (!checkInput())
                    {
                        if (pass.Equals(Conf))
                        {
                            if (checkEmail())
                            {
                                MessageBox.Show("ce e-mail existe déja, Veuillez sasie un autre", "Dupliquer un e-mail",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                            }
                            else
                            {
                                if (cmd.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show(" Votre Compte et bien créé ","Compte",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("ERROR ");
                                }

                            }
                        }
                        else {

                            MessageBox.Show("Votre confirmation de mot passe est inccorect ");

                        }
                     
                    }
                    else
                    {
                        MessageBox.Show("Saisissez d'abord vos information");
                    }
                    

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        //check Email
        public Boolean checkEmail()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            string mail = txtemail.Text;
            String pass = txtpasswd.Text;
            String Query = "Select * from Utilisateur where Mail='" + mail +"';";
            SqlCommand cmd = new SqlCommand(Query, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                // MessageBox.Show("ce email existe déja");
                return true;
            }
            else
            {
                return false;

            }
        }

      //
      public Boolean checkInput()
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string mail = txtemail.Text;
            String pass = txtpasswd.Text;

            if(nom.Trim().Equals(string.Empty)|| prenom.Trim().Equals(string.Empty) || mail.Trim().Equals(string.Empty) || pass.Trim().Equals(string.Empty))
            {
                return true;

            }
            else
            {
                return false;
            }
            
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Authentification authen = new Authentification();
            authen.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void goBack_MouseEnter(object sender, EventArgs e)
        {
            

        }

        private void goBack_MouseLeave(object sender, EventArgs e)
        {
           
        }
    }
}
