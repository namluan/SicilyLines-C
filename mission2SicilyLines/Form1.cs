using mission2SicilyLines.Controler;
using mission2SicilyLines.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mission2SicilyLines
{
    public partial class Form1 : Form
    {
        Mgr monManager;
        List<Secteur> lsecteur = new List<Secteur>();
        public Form1()
        {
            InitializeComponent();
            monManager = new Mgr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsecteur = monManager.chargementSecteurBD();
            affiche();
        }
        public void affiche()

        {
            try
            {
                SecteurList.DataSource = null;
                SecteurList.DataSource = lsecteur;
                SecteurList.DisplayMember = "Secteur";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SecteurList_SelectedIndexChanged(object sender, EventArgs e)
        {
            affiche();
        }

        private void btnLiaison_Click(object sender, EventArgs e)
        {
            Secteur s = (Secteur)SecteurList.SelectedItem;
            Form2 liaison = new Form2(s);
            liaison.ShowDialog();
            affiche();
        }

    }
}
