using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2SicilyLines.Modal
{
    public class Port
    {
        private int idport;
        private string nom;
        public Port(int unId, string unNom)
        {
            this.idport = unId;
            this.nom = unNom;
        }

        public string getNom
        {
            get { return this.nom; }
        }


        public int getIdPort
        {
            get { return this.idport; }
        }

        public override string ToString()
        {
            return (/*this.idport + " " + */this.nom);
        }
    }
}
