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
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();

        }
        string connectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
        public  int id;
        

        public Acceuil(int idU)
        {
            InitializeComponent();
            this.id = idU;
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Acceuil_Load(object sender, EventArgs e)
        {
            UtilisateurConnecter();
            Menu();
        }




        public void UtilisateurConnecter()
        {
            int idP = id;
            
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            String Query = "select Nom,Prenom from Utilisateur where id_Utilisateur='" + idP + "';";
            SqlCommand cmd = new SqlCommand(Query, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    labelUti.Text = (string)rd[0]+" "+ (string)rd[1];
                }
                cnx.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        





        private void projetsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bool t = false;
            foreach (Form fr in this.MdiChildren)
            {
                if (fr.Text == "Projet")
                {
                    t = true;
                    fr.Focus();
                    break;
                }


            }

            if (t == false)
            {


                Projet p = new Projet(id);
                p.MdiParent = this;
                p.Dock = DockStyle.Fill;
                p.Show();
            }
        }

        private void déconnexionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Menu()
        {
            foreach (Form f in this.MdiChildren)
            {
                string h;
                h = f.Text;
                if (toolStripMenuItem1.Available.Equals(h))
                    break;
                toolStripMenuItem1.DropDownItems.Add(h);

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
