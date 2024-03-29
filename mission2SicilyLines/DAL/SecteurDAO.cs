using mission2SicilyLines.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static mission2SicilyLines.DAL.Connexion;

namespace mission2SicilyLines.DAL
{
    internal class SecteurDAO
    {
        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "mlr4";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;
        public static List<Secteur> getSecteur()
        {
            List<Secteur> lc = new List<Secteur>();
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from secteur");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Secteur s;
                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    string libelle = (string)reader.GetValue(1);

                    //Instanciation d'un Secteur
                    s = new Secteur(id, libelle);

                    // Ajout de cet employe à la liste 
                    lc.Add(s);
                }
                reader.Close();
                maConnexionSql.closeConnection();
                return lc;
            }
            catch (Exception emp)
            {
                throw (emp);
            }

        }
    }
}
