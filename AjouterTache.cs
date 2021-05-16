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
    public partial class AjouterTache : Form
    {
        public AjouterTache()
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

        private void btnEnregister_Click(object sender, EventArgs e)
        {
            try {
                    SqlConnection cnx = new SqlConnection();
                    cnx.ConnectionString = connectionString;
                    string titre = textTitreT.Text;
                    string Descr = txtDescT.Text;
                    string mem = comboBoxMe.Text;
                    int idUti, idTache;
                    string Date = DateTime.Now.ToString("yyyy-MM-dd");
                    String Query = "insert into Tache (TitreT,Echéance,DescriptionT,DateCreation) VALUES ('" + titre+"','"+this.dateEch.Text+ "','"+Descr+"','"+Date+"');";
                    SqlCommand cmd = new SqlCommand(Query, cnx);
                    cnx.Open();
                    if (!checkInput())
                    {

                        if (cmd.ExecuteNonQuery()==1)
                        {
                           idUti=IdUtilisatuer(mem);
                            idTache = IdTache(titre, Date,this.dateEch.Text);
                            String Quer= "insert into Journalisation (id_Tache,id_Utilisateur_Crée,id_Utilisateur_affec) VALUES ("+idTache+","+1+","+ idUti + ");";
                            SqlCommand cmd1 = new SqlCommand(Quer, cnx);
                            cmd1.ExecuteNonQuery();
                        MessageBox.Show("Nouvelle tâche effectuer");

                        }
                        else
                        {
                            MessageBox.Show("ERROR ");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Veuillez insérer les information","Tache", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                 }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

        public Boolean checkInput()
        {
            string Titre = textTitreT.Text;
            string membre = comboBoxMe.Text;
            DateTime da = dateEch.Value;

            if (Titre.Trim().Equals(string.Empty)|| membre.Trim().Equals(string.Empty) || da.Equals(""))
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public void Utilisateur()
        {
            int i;
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            String Query = "select Mail from Utilisateur;";
            SqlCommand cmd = new SqlCommand(Query, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    comboBoxMe.Items.Add(rd[0].ToString());
                    
                }

            }
            else
            {
                
            }

        }


        private void AjouterTache_Load(object sender, EventArgs e)
        {
            Utilisateur();
        }

         public int IdTache(string titre,string dateCretion,string ech)
        {
            int i=0;
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            String Query = " select id_Tache from Tache where TitreT='"+titre+"' and Echéance='"+ ech + "' and DateCreation='"+ dateCretion + "';";
            SqlCommand cmd = new SqlCommand(Query, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    i =(int)rd[0];
                    

                }

              }
           return i;
        }
        public int IdUtilisatuer(string Mail)
        {
            int i = 0;
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            String Query = " select id_Utilisateur from Utilisateur where Mail='"+Mail+"';";
            SqlCommand cmd = new SqlCommand(Query, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    i = (int)rd[0];


                }

            }
            return i;
        }
    }
}
