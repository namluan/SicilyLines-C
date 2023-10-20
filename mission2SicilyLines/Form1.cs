using mission2SicilyLines.Modele;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mission2SicilyLines
{
    public partial class Form1 : Form
    {

            List<Secteur> lsecteur = new List<Secteur>();
            Secteur secteur1 = new Secteur(1, "secteur 1");
            Secteur secteur2 = new Secteur(2, "secteur 2");
       
            



        public Form1()
        {
            InitializeComponent();
        }
           
            public void affiche()
            {
                try
                {


                    listBoxSecteur.DataSource = null;
                    listBoxSecteur.DataSource = lsecteur;
                    listBoxSecteur.DisplayMember = "Secteur";
                }


                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }


        private void Form1_Load(object sender, EventArgs e)
        {
            Secteur s1 = new Secteur(1, "secteur1");
            lsecteur.Add(s1);
            Secteur s2 = new Secteur(2, "secteur2");
            lsecteur.Add(s2);
            listBoxSecteur.DataSource = null;
            listBoxSecteur.DataSource = lsecteur;
            listBoxSecteur.DisplayMember = "solde";

        }








        private void label1_Click(object sender, EventArgs e)
        {
            affiche();
        }

        private void listBoxSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                Compte cpt = (Compte)listBox.SelectedItem;
                Client cl = cpt.Propriétaire;
                FormClient fc = new FormClient(cl);
                fc.ShowDialog();
                affiche();
            }
        }
    }
}
