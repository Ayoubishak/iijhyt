using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGestEmpBiblio
{
    public interface IEmprunteur
    {

        List<ouvrage> ConsulterOvrg();
        List<ouvrage> chercherOvrg(ouvrage ovrg, String Choix);
        int InscrireListAtt(int codeBarre, string IDEmpr);
        String reserver(string id, int codeBarre);
        emprunteur ConsulterCompte(String ID);
        void modifierCompte(etudiant etud);
        void modifierCompte(enseignant ens);
        String authentifierEtud(String pseudo, String password);
        String authentifierEns(String pseudo, String password);
        List<listeAttente> listeattente(String id);
        List<emprunt> listeemprunt(String id);
        int attendreConfirmation(String id);
        //void notifierParEmail(object source, string email);

    }
}
