using mission2SicilyLines.Controler;
using mission2SicilyLines.DAL;
using mission2SicilyLines.Modal;
using mission2SicilyLines.Modele;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static mission2SicilyLines.DAL.Connexion;

namespace mission2SicilyLines
{
    public partial class Form2 : Form
    {
        Mgr monManager;
        Secteur unSecteur;
        Liaison li;
        List<Liaison> liaisons = new List<Liaison>();
        List<Traversee> traversees = new List<Traversee>();
        List<Port> ports = new List<Port>();
        List<Port> ports2 = new List<Port>();
        public Form2(Secteur s)
        {
            InitializeComponent();
            this.unSecteur = s;
            monManager = new Mgr();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            liaisons = monManager.chargementLiaisonBD(unSecteur);
            ports = monManager.chargementPortsBD();
            ports2 = monManager.chargementPortsBD();
            affiche();
        }
        public void affiche()

        {
            try
            {
                ListLiaison.DataSource = null;
                ListLiaison.DataSource = liaisons;
                ListLiaison.DisplayMember = "Liaison";

                comboDepartLiaison.DataSource = null;
                comboDepartLiaison.DataSource = ports;
                comboDepartLiaison.DisplayMember = "Ports";

                comboArriveeLiaison.DataSource = null;
                comboArriveeLiaison.DataSource = ports2;
                comboArriveeLiaison.DisplayMember = "Ports2";

                nbLiaison.Text = Convert.ToString(liaisons.Count);

                listTraversee.DataSource = null;
                listTraversee.DataSource = traversees;
                listTraversee.DisplayMember = "Description";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //Modifier Liaison button
        private void liaisonModify_Click(object sender, EventArgs e)
        {
            try
            {
                Liaison lia = (Liaison)ListLiaison.SelectedItem;
                monManager.updateLiaison(lia.getId, dureeUpdate.Text);
                liaisons = monManager.chargementLiaisonBD(unSecteur);
                affiche();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Supprimer liaison button
        private void liaisonSupp_Click(object sender, EventArgs e)
        {
            try
            {
                Liaison lia = (Liaison)ListLiaison.SelectedItem;
                monManager.deleteLiaison(lia);
                liaisons = monManager.chargementLiaisonBD(unSecteur);
                affiche();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Ajouter Liaison button
        private void liaisonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Port portA = (Port)comboArriveeLiaison.SelectedItem;
                Port portD = (Port)comboDepartLiaison.SelectedItem;
                monManager.addLiaison(unSecteur.getId, portD.getIdPort, portA.getIdPort , dureeLiaison.Text);;
                liaisons = monManager.chargementLiaisonBD(unSecteur);
                affiche();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {
            li = (Liaison)ListLiaison.SelectedItem;
            if (li != null) 
            {
                traversees = monManager.chargementTraverseBD(li);
            affiche();
            }
        }
    }
}
