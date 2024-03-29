namespace mission2SicilyLines
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboArriveeLiaison = new System.Windows.Forms.ComboBox();
            this.comboDepartLiaison = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dureeLiaison = new System.Windows.Forms.TextBox();
            this.liaisonAdd = new System.Windows.Forms.Button();
            this.ListLiaison = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dureeUpdate = new System.Windows.Forms.TextBox();
            this.liaisonModify = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.liaisonSupp = new System.Windows.Forms.Button();
            this.NbLiaisonText = new System.Windows.Forms.Label();
            this.nbLiaison = new System.Windows.Forms.Label();
            this.listTraversee = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboArriveeLiaison);
            this.groupBox1.Controls.Add(this.comboDepartLiaison);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dureeLiaison);
            this.groupBox1.Controls.Add(this.liaisonAdd);
            this.groupBox1.Location = new System.Drawing.Point(16, 349);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(280, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertion";
            // 
            // comboArriveeLiaison
            // 
            this.comboArriveeLiaison.FormattingEnabled = true;
            this.comboArriveeLiaison.Location = new System.Drawing.Point(82, 109);
            this.comboArriveeLiaison.Margin = new System.Windows.Forms.Padding(4);
            this.comboArriveeLiaison.Name = "comboArriveeLiaison";
            this.comboArriveeLiaison.Size = new System.Drawing.Size(132, 24);
            this.comboArriveeLiaison.TabIndex = 9;
            // 
            // comboDepartLiaison
            // 
            this.comboDepartLiaison.FormattingEnabled = true;
            this.comboDepartLiaison.Location = new System.Drawing.Point(82, 76);
            this.comboDepartLiaison.Margin = new System.Windows.Forms.Padding(4);
            this.comboDepartLiaison.Name = "comboDepartLiaison";
            this.comboDepartLiaison.Size = new System.Drawing.Size(132, 24);
            this.comboDepartLiaison.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arriver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Départ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Durée";
            // 
            // dureeLiaison
            // 
            this.dureeLiaison.Location = new System.Drawing.Point(82, 39);
            this.dureeLiaison.Margin = new System.Windows.Forms.Padding(4);
            this.dureeLiaison.Name = "dureeLiaison";
            this.dureeLiaison.Size = new System.Drawing.Size(132, 22);
            this.dureeLiaison.TabIndex = 1;
            // 
            // liaisonAdd
            // 
            this.liaisonAdd.Location = new System.Drawing.Point(98, 142);
            this.liaisonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.liaisonAdd.Name = "liaisonAdd";
            this.liaisonAdd.Size = new System.Drawing.Size(100, 28);
            this.liaisonAdd.TabIndex = 0;
            this.liaisonAdd.Text = "Ajouter";
            this.liaisonAdd.UseVisualStyleBackColor = true;
            this.liaisonAdd.Click += new System.EventHandler(this.liaisonAdd_Click);
            // 
            // ListLiaison
            // 
            this.ListLiaison.FormattingEnabled = true;
            this.ListLiaison.ItemHeight = 16;
            this.ListLiaison.Location = new System.Drawing.Point(16, 15);
            this.ListLiaison.Margin = new System.Windows.Forms.Padding(4);
            this.ListLiaison.Name = "ListLiaison";
            this.ListLiaison.Size = new System.Drawing.Size(611, 324);
            this.ListLiaison.TabIndex = 1;
            this.ListLiaison.SelectedIndexChanged += new System.EventHandler(this.ListLiaison_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dureeUpdate);
            this.groupBox2.Controls.Add(this.liaisonModify);
            this.groupBox2.Location = new System.Drawing.Point(375, 349);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 192);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Durée (en minutes)";
            // 
            // dureeUpdate
            // 
            this.dureeUpdate.Location = new System.Drawing.Point(67, 80);
            this.dureeUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.dureeUpdate.Name = "dureeUpdate";
            this.dureeUpdate.Size = new System.Drawing.Size(132, 22);
            this.dureeUpdate.TabIndex = 1;
            // 
            // liaisonModify
            // 
            this.liaisonModify.Location = new System.Drawing.Point(76, 112);
            this.liaisonModify.Margin = new System.Windows.Forms.Padding(4);
            this.liaisonModify.Name = "liaisonModify";
            this.liaisonModify.Size = new System.Drawing.Size(100, 28);
            this.liaisonModify.TabIndex = 0;
            this.liaisonModify.Text = "Modifier";
            this.liaisonModify.UseVisualStyleBackColor = true;
            this.liaisonModify.Click += new System.EventHandler(this.liaisonModify_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.liaisonSupp);
            this.groupBox3.Location = new System.Drawing.Point(727, 349);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(267, 192);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Suppresion";
            // 
            // liaisonSupp
            // 
            this.liaisonSupp.Location = new System.Drawing.Point(87, 90);
            this.liaisonSupp.Margin = new System.Windows.Forms.Padding(4);
            this.liaisonSupp.Name = "liaisonSupp";
            this.liaisonSupp.Size = new System.Drawing.Size(100, 28);
            this.liaisonSupp.TabIndex = 0;
            this.liaisonSupp.Text = "Supprimer";
            this.liaisonSupp.UseVisualStyleBackColor = true;
            this.liaisonSupp.Click += new System.EventHandler(this.liaisonSupp_Click);
            // 
            // NbLiaisonText
            // 
            this.NbLiaisonText.AutoSize = true;
            this.NbLiaisonText.Location = new System.Drawing.Point(751, 31);
            this.NbLiaisonText.Name = "NbLiaisonText";
            this.NbLiaisonText.Size = new System.Drawing.Size(127, 16);
            this.NbLiaisonText.TabIndex = 4;
            this.NbLiaisonText.Text = "Nombre de Liaison :";
            // 
            // nbLiaison
            // 
            this.nbLiaison.AutoSize = true;
            this.nbLiaison.Location = new System.Drawing.Point(897, 31);
            this.nbLiaison.Name = "nbLiaison";
            this.nbLiaison.Size = new System.Drawing.Size(44, 16);
            this.nbLiaison.TabIndex = 5;
            this.nbLiaison.Text = "label5";
            // 
            // listTraversee
            // 
            this.listTraversee.FormattingEnabled = true;
            this.listTraversee.ItemHeight = 16;
            this.listTraversee.Location = new System.Drawing.Point(689, 135);
            this.listTraversee.Name = "listTraversee";
            this.listTraversee.Size = new System.Drawing.Size(328, 180);
            this.listTraversee.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Liste des traversée : ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listTraversee);
            this.Controls.Add(this.nbLiaison);
            this.Controls.Add(this.NbLiaisonText);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ListLiaison);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListLiaison;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button liaisonAdd;
        private System.Windows.Forms.Button liaisonModify;
        private System.Windows.Forms.Button liaisonSupp;
        private System.Windows.Forms.TextBox dureeLiaison;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dureeUpdate;
        private System.Windows.Forms.ComboBox comboDepartLiaison;
        private System.Windows.Forms.ComboBox comboArriveeLiaison;
        private System.Windows.Forms.Label NbLiaisonText;
        private System.Windows.Forms.Label nbLiaison;
        private System.Windows.Forms.ListBox listTraversee;
        private System.Windows.Forms.Label label5;
    }
}