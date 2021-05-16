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
    public partial class TacheContrôle : UserControl
    {
        public TacheContrôle()
        {
            InitializeComponent();
        }
        string connectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
        private string _titre;
        private int idProjet;
        private int _id;//id tache
        public int IDUliCon;//id d'utilisateur connecter
        private string _utilisAttribu;
        private string _utilisateurCree;
        
        
        public TacheContrôle(int a, int p)
        {
            InitializeComponent();
            this.IDUliCon = a;
            this.idProjet = p;
        }

        public string Title
        {
            get { return _titre; }
            set { _titre = value; txtTitre.Text = value; }

        }
        public string AttribuéA
        {
            get { return _utilisAttribu; }
            set { _utilisAttribu = value; labelAttr.Text = value; }

        }
       
        public string CreePar
        {
            get { return _utilisateurCree; }
            set { _utilisateurCree = value; labelCree.Text = value; }

        }
        public int ID
        {
            get { return _id; }
            set { _id = value; IdTach.Text = value.ToString(); }

        }
     


        private void TacheContrôle_Load(object sender, EventArgs e)
        {
            IdTach.Hide();
        }

        private void panelGreen_MouseEnter(object sender, EventArgs e)
        {
           // panelGreen.BackColor=Color.FromArgb(0, 158, 15);
        }

        

     

        private void IdTach_Click(object sender, EventArgs e)
        {

        }

        public void btnTerminer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnx = new SqlConnection();
                cnx.ConnectionString = connectionString;

                String Query = "update journalisation set Terminer=1 where id_Tache=" + _id + ";";
                SqlCommand cmd = new SqlCommand(Query, cnx);
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
                cnx.Open();


                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Tâche terminer ", "Tâche", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                   
                    return;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
    }
}
