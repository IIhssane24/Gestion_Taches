
namespace GestionTâche
{
    partial class Projet
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAjouterP = new System.Windows.Forms.Button();
            this.pictureSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(169, 149);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(827, 474);
            this.flowLayoutPanel1.TabIndex = 14;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(89, 59);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(155, 24);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAjouterP
            // 
            this.btnAjouterP.BackColor = System.Drawing.Color.Black;
            this.btnAjouterP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAjouterP.FlatAppearance.BorderSize = 23;
            this.btnAjouterP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterP.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterP.ForeColor = System.Drawing.Color.White;
            this.btnAjouterP.Location = new System.Drawing.Point(984, 71);
            this.btnAjouterP.Name = "btnAjouterP";
            this.btnAjouterP.Size = new System.Drawing.Size(130, 35);
            this.btnAjouterP.TabIndex = 17;
            this.btnAjouterP.Text = "Ajouter";
            this.btnAjouterP.UseVisualStyleBackColor = false;
            this.btnAjouterP.Click += new System.EventHandler(this.btnAjouterP_Click);
            // 
            // pictureSearch
            // 
            this.pictureSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSearch.Image = global::GestionTâche.Properties.Resources.loupe;
            this.pictureSearch.Location = new System.Drawing.Point(250, 59);
            this.pictureSearch.Name = "pictureSearch";
            this.pictureSearch.Size = new System.Drawing.Size(24, 24);
            this.pictureSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSearch.TabIndex = 16;
            this.pictureSearch.TabStop = false;
            this.pictureSearch.Click += new System.EventHandler(this.pictureSearch_Click);
            this.pictureSearch.MouseEnter += new System.EventHandler(this.pictureSearch_MouseEnter);
            this.pictureSearch.MouseLeave += new System.EventHandler(this.pictureSearch_MouseLeave);
            // 
            // Projet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 635);
            this.Controls.Add(this.pictureSearch);
            this.Controls.Add(this.btnAjouterP);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Projet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Projet";
            this.Load += new System.EventHandler(this.Projet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureSearch;
        private System.Windows.Forms.Button btnAjouterP;
    }
}