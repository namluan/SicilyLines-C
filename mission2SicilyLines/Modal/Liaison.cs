using mission2SicilyLines.DAL;
using mission2SicilyLines.Modele;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2SicilyLines.Modal
{
    public class Liaison
    {
        private int id;
        private int id_secteur;
        private int depart;
        private int arrivee;
        private string duree;

        public Liaison(int id, int id_secteur, int depart, int arrivee, string duree)
        {
            this.id = id;
            this.id_secteur = id_secteur;
            this.duree = duree;
            this.depart = depart;
            this.arrivee = arrivee;
        }

        public int getId_secteur
        {
            get { return this.id_secteur;}
        }

        public int getId
        {
            get { return this.id; }
        }
        public int getDepart
        {
            get { return depart; }
        }

        public int getArrivee
        {
            get { return arrivee; }
        }

        public string getDuree
        {
            get { return duree; }
        }

        public override string ToString()
        {
            string nomDepart = String.Join(",",PortDAO.getPort(this.getDepart));
            string nomArrivee = String.Join(",", PortDAO.getPort(this.getArrivee));
            return " id : " + id + " secteur : " + id_secteur + " | port de départ : " + nomDepart + " | port d'arriver : " + nomArrivee + " | durée : " + duree + " minutes";
        }
    }
}
