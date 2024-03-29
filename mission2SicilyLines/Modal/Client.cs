using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace mission2SicilyLines.Modele
{

    public class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private string adresse;
        private int cp;
        private string ville;

        public Client(int unId, string unNom, string unPrenom, string uneAdresse, int unCp, string uneVille)
        {
            this.id = unId;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.adresse = uneAdresse;
            this.cp = unCp;
            this.ville = uneVille;
        }
    }


}
