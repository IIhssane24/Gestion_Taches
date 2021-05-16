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
    public partial class TacheProjet : Form
    {
        public TacheProjet()
        {
            
        }
        string connectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
        public int id;//id projet
        public int idUti;//id UtilisateurConn
        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Red;
        }
        public TacheProjet(int a,int idU)
        {
            InitializeComponent();
            this.id = a;
            this.idUti = idU;
        }
        private void TacheProjet_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TacheProjet_Load(object sender, EventArgs e)
        {

            Projet();
            listTache();
            
        }

        public void TacheContrôle_Click(object sender, EventArgs e)
        {
          
        }

        public void Projet()
        {
            int idP = id;
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            String Query = "SELECT * FROM Projet where id_projet='" +idP+ "';";
            SqlCommand cmd = new SqlCommand(Query, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    TitreP.Text = (string)rd[1];
                }
                cnx.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
        public void listTache()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            Boolean a;
            string mailAtt ;
            string mailCree ;
            int Ma;
            String Query = "SELECT Tache.id_Tache , Tache.TitreT From Projet INNER JOIN Statut ON Projet.id_projet = Statut.id_projet INNER JOIN Tache ON Statut.id_Tache = Tache.id_Tache INNER JOIN journalisation ON journalisation.id_Tache = Tache.id_Tache where Projet.id_projet = " + id + " and journalisation.Terminer = 0;";
           
            SqlCommand cmd = new SqlCommand(Query, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            flowLayoutPanel1.Controls.Clear();
            if (rd.HasRows)
            {

                while (rd.Read())
                {



                    TacheContrôle t = new TacheContrôle(id,idUti);
                    t.ID = (int)rd[0];
                    t.Title = (string)rd[1];
                     mailCree = MailUtiliCrr();
                      t.CreePar = mailCree;
                      Ma = IdUtiliAttri((int)rd[0]);
                     mailAtt = MailUtiliAttri(Ma);
                     t.AttribuéA = mailAtt;
                    flowLayoutPanel1.Controls.Add(t);

                }
                cnx.Close();
            }


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAjouterT_Click(object sender, EventArgs e)
        {
            AjouterTache t = new AjouterTache();
            t.Show();
        }
       
        public int IdUtiliAttri(int idUta)
        {
            int a =0;
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            String Query = "select  Journalisation.id_Utilisateur_aff From Journalisation INNER JOIN Tache ON journalisation.id_Tache = Tache.id_Tache where journalisation.id_Tache =" + idUta + "; ";
            SqlCommand cmd = new SqlCommand(Query, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    a = (int)rd[0];
                    return a;
                }
                cnx.Close();
            }
            return a;
        }
        public String MailUtiliAttri(int idU)
        {
            int a;
            string mail = " ";

            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            a = IdUtiliAttri(idU);

                String Query = "select Utilisateur.Mail from Utilisateur where id_Utilisateur=" + a + ";";
                SqlCommand cmd = new SqlCommand(Query, cnx);
                cnx.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {

                    while (rd.Read())
                    {
                        mail = (string)rd[0];
                    return mail;
                    }
                    cnx.Close();
                }
             
            return mail;
        }
        public String MailUtiliCrr()
        {

            int a;
            string mail = " ";

            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;

                String Query = "select Utilisateur.Mail from Utilisateur where id_Utilisateur=" + idUti + ";";
                SqlCommand cmd = new SqlCommand(Query, cnx);
                cnx.Open();
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {

                    while (rd.Read())
                    {
                        mail = (string)rd[0];

                    }
                    cnx.Close();
                }
            
            return mail;
        }

        private void labelClose_MouseEnter_1(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Red;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Black;
        }

        private void labelClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
  //"Delete from Projet where id_projet" + id + ";"
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            String Query = "Delete from Statut where id_projet=" + id + ";";
            SqlCommand cmd = new SqlCommand(Query, cnx);
            if (cnx.State == ConnectionState.Open)
                cnx.Close();
            cnx.Open();
            cmd.ExecuteNonQuery();
              Supprimerprojet();
            Projet ta = new Projet(id);
            ta.MdiParent = Acceuil.ActiveForm;
            ta.Dock = DockStyle.Fill;
            ta.Show();
        }

        public void Supprimerprojet()
        {

            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            String Query = "Delete from Projet where id_projet=" + id + ";";
            SqlCommand cmd = new SqlCommand(Query, cnx);
            if (cnx.State == ConnectionState.Open)
                cnx.Close();
            cnx.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Projet est supprimer ", "Projet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void linkTerminer_Click(object sender, EventArgs e)
        {
            TacheProjetTerminer ta = new TacheProjetTerminer(id,idUti);
            ta.MdiParent = Acceuil.ActiveForm;
            ta.Dock = DockStyle.Fill;
            ta.Show();

        }

        private void linkTerminer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
