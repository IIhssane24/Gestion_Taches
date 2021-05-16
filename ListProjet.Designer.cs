
namespace GestionTâche
{
    partial class ListProjet
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idProjet = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtDescp = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitre
            // 
            this.txtTitre.AutoSize = true;
            this.txtTitre.BackColor = System.Drawing.Color.White;
            this.txtTitre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.ForeColor = System.Drawing.Color.Black;
            this.txtTitre.Location = new System.Drawing.Point(128, 2);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(77, 32);
            this.txtTitre.TabIndex = 0;
            this.txtTitre.Text = "Titre";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.idProjet);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(18, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 67);
            this.panel2.TabIndex = 1;
            // 
            // idProjet
            // 
            this.idProjet.AllowDrop = true;
            this.idProjet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idProjet.AutoSize = true;
            this.idProjet.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idProjet.ForeColor = System.Drawing.Color.Black;
            this.idProjet.Location = new System.Drawing.Point(16, 13);
            this.idProjet.Name = "idProjet";
            this.idProjet.Size = new System.Drawing.Size(21, 26);
            this.idProjet.TabIndex = 3;
            this.idProjet.Text = "1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestionTâche.Properties.Resources.briefing;
            this.pictureBox2.Location = new System.Drawing.Point(21, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // txtDescp
            // 
            this.txtDescp.AutoSize = true;
            this.txtDescp.Location = new System.Drawing.Point(143, 50);
            this.txtDescp.Name = "txtDescp";
            this.txtDescp.Size = new System.Drawing.Size(41, 13);
            this.txtDescp.TabIndex = 2;
            this.txtDescp.Text = "label1";
            // 
            // ListProjet
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtDescp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTitre);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "ListProjet";
            this.Size = new System.Drawing.Size(657, 93);
            this.Load += new System.EventHandler(this.ListProjet_Load);
           this.Click += new System.EventHandler(this.ListProjet_Click);
            this.DoubleClick += new System.EventHandler(this.ListProjet_Click);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label txtTitre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label idProjet;
        private System.Windows.Forms.Label txtDescp;
    }
}
