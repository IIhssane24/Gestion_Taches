
namespace GestionTâche
{
    partial class Acceuil
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
            this.labelUti = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesTâcheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nonTerminerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.membresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUti
            // 
            this.labelUti.AutoSize = true;
            this.labelUti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelUti.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUti.Location = new System.Drawing.Point(875, 9);
            this.labelUti.Name = "labelUti";
            this.labelUti.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelUti.Size = new System.Drawing.Size(51, 20);
            this.labelUti.TabIndex = 3;
            this.labelUti.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::GestionTâche.Properties.Resources.membre;
            this.pictureBox1.Location = new System.Drawing.Point(849, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projetsToolStripMenuItem,
            this.mesTâcheToolStripMenuItem,
            this.membresToolStripMenuItem,
            this.statistiqueToolStripMenuItem,
            this.toolStripMenuItem1,
            this.déconnexionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 40);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projetsToolStripMenuItem
            // 
            this.projetsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projetsToolStripMenuItem.Image = global::GestionTâche.Properties.Resources.briefing__1_;
            this.projetsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.projetsToolStripMenuItem.Name = "projetsToolStripMenuItem";
            this.projetsToolStripMenuItem.Size = new System.Drawing.Size(94, 36);
            this.projetsToolStripMenuItem.Text = "Projets";
            this.projetsToolStripMenuItem.Click += new System.EventHandler(this.projetsToolStripMenuItem_Click_1);
            // 
            // mesTâcheToolStripMenuItem
            // 
            this.mesTâcheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminerToolStripMenuItem,
            this.nonTerminerToolStripMenuItem});
            this.mesTâcheToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mesTâcheToolStripMenuItem.Image = global::GestionTâche.Properties.Resources.check;
            this.mesTâcheToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mesTâcheToolStripMenuItem.Name = "mesTâcheToolStripMenuItem";
            this.mesTâcheToolStripMenuItem.Size = new System.Drawing.Size(116, 36);
            this.mesTâcheToolStripMenuItem.Text = "Mes tâche";
            // 
            // terminerToolStripMenuItem
            // 
            this.terminerToolStripMenuItem.Name = "terminerToolStripMenuItem";
            this.terminerToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.terminerToolStripMenuItem.Text = "Terminer";
            // 
            // nonTerminerToolStripMenuItem
            // 
            this.nonTerminerToolStripMenuItem.Name = "nonTerminerToolStripMenuItem";
            this.nonTerminerToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.nonTerminerToolStripMenuItem.Text = "Non Terminer";
            // 
            // membresToolStripMenuItem
            // 
            this.membresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membresToolStripMenuItem.Image = global::GestionTâche.Properties.Resources.friends;
            this.membresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.membresToolStripMenuItem.Name = "membresToolStripMenuItem";
            this.membresToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.membresToolStripMenuItem.Text = "Membres";
            // 
            // statistiqueToolStripMenuItem
            // 
            this.statistiqueToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistiqueToolStripMenuItem.Image = global::GestionTâche.Properties.Resources.bar_chart__1_;
            this.statistiqueToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.statistiqueToolStripMenuItem.Name = "statistiqueToolStripMenuItem";
            this.statistiqueToolStripMenuItem.Size = new System.Drawing.Size(126, 36);
            this.statistiqueToolStripMenuItem.Text = "Statistique";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 36);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // déconnexionsToolStripMenuItem
            // 
            this.déconnexionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.déconnexionsToolStripMenuItem.Image = global::GestionTâche.Properties.Resources.logout1;
            this.déconnexionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.déconnexionsToolStripMenuItem.Name = "déconnexionsToolStripMenuItem";
            this.déconnexionsToolStripMenuItem.Size = new System.Drawing.Size(144, 36);
            this.déconnexionsToolStripMenuItem.Text = "Déconnexion";
            this.déconnexionsToolStripMenuItem.Click += new System.EventHandler(this.déconnexionsToolStripMenuItem_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 585);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelUti);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Acceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceuil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Acceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelUti;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesTâcheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nonTerminerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem membresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem déconnexionsToolStripMenuItem;
    }
}