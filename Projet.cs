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
    public partial class Projet : Form
    {
        private Random rnd = new Random();
        
        public Projet()
        {
            InitializeComponent();
        }
       
        string connectionString = ConfigurationManager.ConnectionStrings["cnxSqlServer"].ConnectionString;
        public int user;
        ListProjet listP = new ListProjet();
        private void Projet_Load(object sender, EventArgs e)
        {
            listProject();
           


        }
          public Projet(int id )
           {
              InitializeComponent();

               this.user = id;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureSearch_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void pictureSearch_MouseLeave(object sender, EventArgs e)
        {
            

        }

        private void panelSearch_MouseEnter(object sender, EventArgs e)
        {
             
        }

        private void panelSearch_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panelSearch_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterP_Click(object sender, EventArgs e)
        {
            AjouterProjet au = new AjouterProjet();
            au.Show();
        }

        private void listProject()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            String Query = "SELECT * FROM Projet;";
            SqlCommand cmd = new SqlCommand(Query, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            
            if (rd.HasRows)
            {
                
                while (rd.Read())
                {
                    Color randomColor = Color.FromArgb(192, 192, 255);

                    ListProjet a = new ListProjet(user);
                    a.ID = (int)rd[0];
                    a.Title = (string)rd[1];
                    a.Desc = (string)rd[2];
                    a.IconBackground = randomColor;
                  
                    
                    

                    flowLayoutPanel1.Controls.Add(a);
                }
               
            }else
            {
                MessageBox.Show("Table est vide");
            }
            cnx.Close();
        }

      

        private void pictureSearch_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            string search = txtSearch.Text;
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = connectionString;
            String Query = "SELECT * FROM Projet WHERE CONCAT(id_projet, Titre,DescriptionP) LIKE '%"+search+"%';";
            SqlCommand cmd = new SqlCommand(Query, cnx);
            cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            List<ListProjet> pr = new List<ListProjet>();
            if (rd.HasRows)
            {

                while (rd.Read())
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                    
                    listP.ID = (int)rd[0];
                    listP.Title = (string)rd[1];
                    listP.Desc = (string)rd[2];
                    listP.IconBackground = randomColor;
                   


                    flowLayoutPanel1.Controls.Add(listP);
                }
                cnx.Close();
            }
            else
            {
                MessageBox.Show("Aucune Projet avec cette information");
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void listProjet1_Click(object sender, EventArgs e)
        {

        }

        private void listProjet1_Load(object sender, EventArgs e)
        {

        }
    }
}

        
  
          

            
            
        
        