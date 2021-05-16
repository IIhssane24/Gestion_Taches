
namespace GestionTâche
{
    partial class TacheProjet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitreP = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAjouterT = new System.Windows.Forms.Button();
            this.labelClose = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkTerminer = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TitreP
            // 
            this.TitreP.AutoSize = true;
            this.TitreP.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreP.Location = new System.Drawing.Point(185, 20);
            this.TitreP.Name = "TitreP";
            this.TitreP.Size = new System.Drawing.Size(246, 49);
            this.TitreP.TabIndex = 14;
            this.TitreP.Text = "Titre_Projet";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(194, 125);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(850, 462);
            this.flowLayoutPanel1.TabIndex = 15;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnAjouterT
            // 
            this.btnAjouterT.BackColor = System.Drawing.Color.Black;
            this.btnAjouterT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAjouterT.FlatAppearance.BorderSize = 23;
            this.btnAjouterT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterT.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterT.ForeColor = System.Drawing.Color.White;
            this.btnAjouterT.Location = new System.Drawing.Point(1104, 76);
            this.btnAjouterT.Name = "btnAjouterT";
            this.btnAjouterT.Size = new System.Drawing.Size(125, 35);
            this.btnAjouterT.TabIndex = 18;
            this.btnAjouterT.Text = "Ajouter";
            this.btnAjouterT.UseVisualStyleBackColor = false;
            this.btnAjouterT.Click += new System.EventHandler(this.btnAjouterT_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Wide Latin", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.Location = new System.Drawing.Point(1166, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(63, 59);
            this.labelClose.TabIndex = 19;
            this.labelClose.Text = "←";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click_1);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter_1);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 23;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1104, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkTerminer
            // 
            this.linkTerminer.AutoSize = true;
            this.linkTerminer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTerminer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkTerminer.LinkColor = System.Drawing.Color.Black;
            this.linkTerminer.Location = new System.Drawing.Point(932, 85);
            this.linkTerminer.Name = "linkTerminer";
            this.linkTerminer.Size = new System.Drawing.Size(112, 18);
            this.linkTerminer.TabIndex = 21;
            this.linkTerminer.TabStop = true;
            this.linkTerminer.Text = "Tâche Terminer";
            this.linkTerminer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTerminer_LinkClicked);
            this.linkTerminer.Click += new System.EventHandler(this.linkTerminer_Click);
            // 
            // TacheProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 635);
            this.Controls.Add(this.linkTerminer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.btnAjouterT);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TitreP);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TacheProjet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TacheProjet";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.TacheProjet_Load);
            this.MouseLeave += new System.EventHandler(this.TacheProjet_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitreP;
        private System.Windows.Forms.Button btnAjouterT;
        private System.Windows.Forms.Label labelClose;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkTerminer;
    }
}