namespace mission2SicilyLines
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.SecteurList = new System.Windows.Forms.ListBox();
            this.btnLiaison = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SecteurList
            // 
            this.SecteurList.FormattingEnabled = true;
            this.SecteurList.ItemHeight = 16;
            this.SecteurList.Location = new System.Drawing.Point(394, 186);
            this.SecteurList.Margin = new System.Windows.Forms.Padding(4);
            this.SecteurList.Name = "SecteurList";
            this.SecteurList.Size = new System.Drawing.Size(269, 228);
            this.SecteurList.TabIndex = 0;
            this.SecteurList.SelectedIndexChanged += new System.EventHandler(this.SecteurList_SelectedIndexChanged);
            // 
            // btnLiaison
            // 
            this.btnLiaison.Location = new System.Drawing.Point(476, 436);
            this.btnLiaison.Margin = new System.Windows.Forms.Padding(4);
            this.btnLiaison.Name = "btnLiaison";
            this.btnLiaison.Size = new System.Drawing.Size(100, 28);
            this.btnLiaison.TabIndex = 2;
            this.btnLiaison.Text = "Liaison";
            this.btnLiaison.UseVisualStyleBackColor = true;
            this.btnLiaison.Click += new System.EventHandler(this.btnLiaison_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(383, 80);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(288, 64);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "SicilyLine";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnLiaison);
            this.Controls.Add(this.SecteurList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SecteurList;
        private System.Windows.Forms.Button btnLiaison;
        private System.Windows.Forms.Label labelTitle;
    }
}

