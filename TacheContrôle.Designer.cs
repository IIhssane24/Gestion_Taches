
namespace GestionTâche
{
    partial class TacheContrôle
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
            this.IdTach = new System.Windows.Forms.Label();
            this.txtTitre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAttr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCree = new System.Windows.Forms.Label();
            this.btnTerminer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdTach
            // 
            this.IdTach.AutoSize = true;
            this.IdTach.Location = new System.Drawing.Point(151, 16);
            this.IdTach.Name = "IdTach";
            this.IdTach.Size = new System.Drawing.Size(0, 13);
            this.IdTach.TabIndex = 2;
            this.IdTach.Click += new System.EventHandler(this.IdTach_Click);
            // 
            // txtTitre
            // 
            this.txtTitre.AutoSize = true;
            this.txtTitre.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.Location = new System.Drawing.Point(43, 16);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(67, 28);
            this.txtTitre.TabIndex = 3;
            this.txtTitre.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Attribué à:";
            // 
            // labelAttr
            // 
            this.labelAttr.AutoSize = true;
            this.labelAttr.Location = new System.Drawing.Point(116, 73);
            this.labelAttr.Name = "labelAttr";
            this.labelAttr.Size = new System.Drawing.Size(35, 13);
            this.labelAttr.TabIndex = 5;
            this.labelAttr.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Crée par :";
            // 
            // labelCree
            // 
            this.labelCree.AutoSize = true;
            this.labelCree.Location = new System.Drawing.Point(409, 73);
            this.labelCree.Name = "labelCree";
            this.labelCree.Size = new System.Drawing.Size(35, 13);
            this.labelCree.TabIndex = 7;
            this.labelCree.Text = "label1";
            // 
            // btnTerminer
            // 
            this.btnTerminer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(15)))));
            this.btnTerminer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerminer.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminer.ForeColor = System.Drawing.Color.White;
            this.btnTerminer.Location = new System.Drawing.Point(514, 17);
            this.btnTerminer.Name = "btnTerminer";
            this.btnTerminer.Size = new System.Drawing.Size(93, 29);
            this.btnTerminer.TabIndex = 8;
            this.btnTerminer.Text = "Terminer";
            this.btnTerminer.UseVisualStyleBackColor = false;
            this.btnTerminer.Click += new System.EventHandler(this.btnTerminer_Click);
            // 
            // TacheContrôle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnTerminer);
            this.Controls.Add(this.labelCree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAttr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.IdTach);
            this.Name = "TacheContrôle";
            this.Size = new System.Drawing.Size(622, 91);
            this.Load += new System.EventHandler(this.TacheContrôle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IdTach;
        private System.Windows.Forms.Label txtTitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAttr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCree;
        private System.Windows.Forms.Button btnTerminer;
    }
}
