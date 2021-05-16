using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTâche
{
    public partial class ListProjet : UserControl
    {
        public ListProjet()
        {
            InitializeComponent();
        }
        
        #region Properties

        private string _title;
        private string _descr;
        private int _id;
        private Color _iconBack;
        public int IDU;
        public ListProjet(int us)
        {
            InitializeComponent();
            this.IDU = us;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; txtTitre.Text = value; }

        }
        public string Desc
        {
            get { return _descr; }
            set { _descr = value; txtDescp.Text = value; }

        }
        public int ID
        {
            get { return _id; }
            set { _id = value; idProjet.Text =value.ToString(); }

        }
        public Color IconBackground
        {
            get { return _iconBack; }
            set { _iconBack = value; panel2.BackColor= value; }

        }






        #endregion

       

        private void ListProjet_Load(object sender, EventArgs e)
        {

        }

        public void ListProjet_Click(object sender, EventArgs e)
        {
            
            TacheProjet ta = new TacheProjet(int.Parse(idProjet.Text), IDU);
            ta.MdiParent = Projet.ActiveForm;
            ta.Dock = DockStyle.Fill;
            ta.Show();

            
        }

       
    }
}
