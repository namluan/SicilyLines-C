using mission2SicilyLines.Modal;
using mission2SicilyLines.Modele;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static mission2SicilyLines.DAL.Connexion;

namespace mission2SicilyLines.DAL
{
    public class PortDAO
    {
        private static string provider = "localhost";
        private static string dataBase = "mlr4";
        private static string uid = "root";
        private static string mdp = "";
        private static ConnexionSql maConnexionSql;
        private static MySqlCommand Ocom;


        public static List<Port> getPort(int idport)
        {
            List<Port> lc = new List<Port>();
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec($"SELECT * from port WHERE id = {idport}");
                MySqlDataReader reader = Ocom.ExecuteReader();
                Port p;
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);

                    //Instanciation d'un port
                    p = new Port(id, nom);

                    // Ajout de cet employe à la liste 
                    lc.Add(p);
                }
                reader.Close();
                maConnexionSql.closeConnection();
                return lc;
            }
            catch(Exception emp)
            {
                throw (emp);
            }
            
        }

        public static List<Port> getAllPort()
        {
            List<Port> lc = new List<Port>();
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec($"SELECT * from port");
                MySqlDataReader reader = Ocom.ExecuteReader();
                Port p;
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);

                    //Instanciation d'un port
                    p = new Port(id, nom);

                    // Ajout de cet employe à la liste 
                    lc.Add(p);
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


        /*public static string getPort_2(int idport)
        {

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec($"SELECT * from port WHERE id = {idport}");
                MySqlDataReader reader = Ocom.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);

                }
                reader.Close();
                maConnexionSql.closeConnection();
                return nom;
            }
            catch (Exception emp)
            {
                throw (emp);
            }

        }*/
    }
}
