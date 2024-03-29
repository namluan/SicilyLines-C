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
    public class TraverseeDAO
    {
        private static string provider = "localhost";
        private static string dataBase = "mlr4";
        private static string uid = "root";
        private static string mdp = "";
        private static ConnexionSql maConnexionSql;
        private static MySqlCommand Ocom;

        public static List<Traversee> getTraversees(Liaison l)
        {
            List<Traversee> lt = new List<Traversee>();
            try
            {
                int id_liaison = l.getId;
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec($"SELECT * FROM traversee WHERE id_liaison = {id_liaison}");
                int i = Ocom.ExecuteNonQuery();
                MySqlDataReader reader = Ocom.ExecuteReader();
                Traversee t;
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    DateTime date = (DateTime)reader.GetValue(1);
                    TimeSpan heures = (TimeSpan)reader.GetValue(2);
                    id_liaison = (int)reader.GetValue(3);

                    t = new Traversee(id, date, heures, id_liaison);
                    lt.Add(t);
                }
                reader.Close();
                maConnexionSql.closeConnection();
                return lt;

            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
