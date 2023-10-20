using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2SicilyLines.Modele
{
    internal class Secteur
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
            return id + " " + libelle;
        }



    }
}
