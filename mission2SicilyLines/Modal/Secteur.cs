using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2SicilyLines.Modele
{
    public class Secteur
    {
        private int id;
        private string libelle;

        public Secteur(int unId, string unLibelle)
        {
            this.id = unId;
            this.libelle = unLibelle;
        }

        public override string ToString()
        {
            return "Secteur numero " + id + " " + libelle;
        }

        public int getId
        {
            get { return this.id; }
        }



    }
}
