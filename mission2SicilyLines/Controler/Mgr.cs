using mission2SicilyLines.DAL;
using mission2SicilyLines.Modal;
using mission2SicilyLines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2SicilyLines.Controler
{
    internal class Mgr
    {
        SecteurDAO strDAO = new SecteurDAO();
        LiaisonDAO lsnDAO = new LiaisonDAO();
        PortDAO portDAO = new PortDAO();
        List<Secteur> mgrSecteur;
        List<Liaison> mgrLiaison;
        List<Traversee> mgrTraversee;
        List<Port> mgrPorts;

        public List<Secteur> chargementSecteurBD()
        {
            mgrSecteur = SecteurDAO.getSecteur();
            return (mgrSecteur);
        }

        public List<Liaison> chargementLiaisonBD(Secteur s)
        {
            mgrLiaison = LiaisonDAO.getLiaison(s);
            return (mgrLiaison);
        }

        public List<Traversee> chargementTraverseBD(Liaison l)
        {
            mgrTraversee = TraverseeDAO.getTraversees(l);
            return (mgrTraversee);
        }

        public List<Port> chargementPortsBD()
        {
            mgrPorts = PortDAO.getAllPort();
            return (mgrPorts);
        }

        public void deleteLiaison(Liaison l)
        {
            LiaisonDAO.deleteLiaison(l);
        }

        public void addLiaison(int secteur, int depart, int arriver, string duree)
        {
            //Liaison liaison = new Liaison(secteur, depart, arriver, duree);
            LiaisonDAO.add_Liaison(secteur, depart, arriver, duree);

        }

        public void updateLiaison(int liaison, string duree)
        {
            LiaisonDAO.updateLiaison(liaison, duree);
        }
    }
}
