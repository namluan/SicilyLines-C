using mission2SicilyLines.Modal;
using mission2SicilyLines.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static mission2SicilyLines.DAL.Connexion;

namespace mission2SicilyLines.DAL
{
    public class LiaisonDAO
    {
        private static string provider = "localhost";
        private static string dataBase = "mlr4";
        private static string uid = "root";
        private static string mdp = "";
        private static ConnexionSql maConnexionSql;
        private static MySqlCommand Ocom;
        //Recuperer les liaison de la table
        public static List<Liaison> getLiaison(Secteur s)
        {
            List<Liaison> lc = new List<Liaison>();
            int idSecteur = s.getId;

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec($"SELECT * FROM liaison WHERE id_secteur = {idSecteur}");
                int i = Ocom.ExecuteNonQuery();
                MySqlDataReader reader = Ocom.ExecuteReader();
                Liaison l;
                while (reader.Read())
                {

                    int id = (int)reader.GetValue(0);
                    int id_secteur = (int)reader.GetValue(1);
                    int DEPART = (int)reader.GetValue(2);
                    int ARRIVER = (int)reader.GetValue(3);
                    string duree = (string)reader.GetValue(4);

                    //Instanciation d'un Liaison
                    l = new Liaison(id, id_secteur, DEPART, ARRIVER, duree);

                    // Ajout de cet employe à la liste
                    lc.Add(l);
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
        //Ajouter une liaison
        public static void add_Liaison(int secteur, int depart, int arriver, string duree)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                //Ocom = maConnexionSql.reqExec($"INSERT INTO liaison (id_secteur,DEPART,ARRIVER, DUREE) VALUES ({l.getId_secteur}, {l.getDepart}, {l.getArrivee}, {l.getDuree})");(SELECT NOM FROM port WHERE id={depart})
                Ocom = maConnexionSql.reqExec($"INSERT INTO liaison (id_secteur,DEPART,ARRIVER, DUREE) VALUES ({secteur}, {depart}, {arriver}, {duree})");
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        //Supprimer une liaison
        public static void deleteLiaison(Liaison l)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec($"DELETE FROM liaison WHERE id = {l.getId}");
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        //Modifier
        public static void updateLiaison(int liaison, string duree)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec($"UPDATE liaison set DUREE={duree} WHERE id={liaison}");
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

    
    }
}
