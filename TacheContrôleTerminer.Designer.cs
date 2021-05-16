
namespace GestionTâche
{
    partial class TacheContrôleTerminer
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
            this.txtId = new System.Windows.Forms.Label();
            this.btnNonTer = new System.Windows.Forms.Button();
            this.txtTitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(24, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(35, 13);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "label1";
            // 
            // btnNonTer
            // 
            this.btnNonTer.BackColor = System.Drawing.Color.Red;
            this.btnNonTer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNonTer.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNonTer.ForeColor = System.Drawing.Color.White;
            this.btnNonTer.Location = new System.Drawing.Point(485, 23);
            this.btnNonTer.Name = "btnNonTer";
            this.btnNonTer.Size = new System.Drawing.Size(118, 35);
            this.btnNonTer.TabIndex = 1;
            this.btnNonTer.Text = "Non Terminer";
            this.btnNonTer.UseVisualStyleBackColor = false;
            this.btnNonTer.Click += new System.EventHandler(this.btnNonTer_Click);
            // 
            // txtTitre
            // 
            this.txtTitre.AutoSize = true;
            this.txtTitre.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitre.Location = new System.Drawing.Point(65, 19);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(93, 34);
            this.txtTitre.TabIndex = 2;
            this.txtTitre.Text = "label2";
            // 
            // TacheContrôleTerminer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.btnNonTer);
            this.Controls.Add(this.txtId);
            this.Name = "TacheContrôleTerminer";
            this.Size = new System.Drawing.Size(624, 77);
            this.Load += new System.EventHandler(this.TacheContrôleTerminer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Button btnNonTer;
        private System.Windows.Forms.Label txtTitre;
    }
}
