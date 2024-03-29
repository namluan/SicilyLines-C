using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2SicilyLines.Modal
{
    public class Traversee
    {
        private int id;
        private DateTime date;
        private TimeSpan heures;
        private int id_liaison;

        public Traversee(int id, DateTime date, TimeSpan heures, int id_liaison)
        {
            this.id = id;
            this.date = date;
            this.heures = heures;
            this.id_liaison = id_liaison;
        }

        public int getId { get { return id; } }

        public DateTime getDate {  get { return date; } }

        public TimeSpan getHeures { get { return heures; } }

        public int getId_liaison { get { return id_liaison ; } }

        public string Description
        {
            get
            {
                return "id : " + id + " | L'heures : " + heures + " | La date : " + date.ToString("dd/MM/yyyy");
            }
        }
    }
}
