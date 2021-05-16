
namespace GestionTâche
{
    partial class TacheProjetTerminer
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
            this.linkTerminer = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TitreP
            // 
            this.TitreP.AutoSize = true;
            this.TitreP.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitreP.Location = new System.Drawing.Point(72, 37);
            this.TitreP.Name = "TitreP";
            this.TitreP.Size = new System.Drawing.Size(246, 49);
            this.TitreP.TabIndex = 15;
            this.TitreP.Text = "Titre_Projet";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(209, 122);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(816, 462);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // linkTerminer
            // 
            this.linkTerminer.AutoSize = true;
            this.linkTerminer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTerminer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkTerminer.LinkColor = System.Drawing.Color.Black;
            this.linkTerminer.Location = new System.Drawing.Point(1046, 83);
            this.linkTerminer.Name = "linkTerminer";
            this.linkTerminer.Size = new System.Drawing.Size(148, 18);
            this.linkTerminer.TabIndex = 22;
            this.linkTerminer.TabStop = true;
            this.linkTerminer.Text = "Tâche Non  Terminer";
            this.linkTerminer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTerminer_LinkClicked);
            this.linkTerminer.Click += new System.EventHandler(this.linkTerminer_Click);
            // 
            // TacheProjetTerminer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1222, 596);
            this.Controls.Add(this.linkTerminer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.TitreP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TacheProjetTerminer";
            this.Text = "TacheProjetTerminer";
            this.Load += new System.EventHandler(this.TacheProjetTerminer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitreP;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkTerminer;
    }
}