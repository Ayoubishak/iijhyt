using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGestEmpBiblio
{
    [Serializable]
    public class etudiant:emprunteur
    {
        private string numCarte;
        private string specialite, niveau;

        public etudiant()
        {

        }

        public etudiant(string numCarte, string specialite, string niveau, string iD, string nom, string prenom, string pseudo, string password, int empNConfirme, string typeEmp, string email) : base(iD, nom, prenom, pseudo, password, empNConfirme, typeEmp, email)
        
            {
            this.numCarte = numCarte;
            this.specialite = specialite;
            this.niveau = niveau;
        }

       
        public string Specialite { get {return specialite;} set { specialite = value; }}
        public string Niveau { get {return niveau;} set { niveau = value; }}
        public string NumCarte { get { return numCarte; } set { numCarte = value; } }
    }
}
