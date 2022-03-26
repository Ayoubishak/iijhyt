using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGestEmpBiblio
{
    [Serializable]
    public class emprunteur
    {
        private string ID,nom,prenom,pseudo,password,typeEmp,email;
        private int empNConfirme;
        public emprunteur()
        {

        }

        public emprunteur(string iD, string nom, string prenom, string pseudo, string password, int empNConfirme,string typeEmp,string email)
        {
            ID = iD;
            this.nom = nom;
            this.prenom = prenom;
            this.pseudo = pseudo;
            this.password = password;
            this.empNConfirme = empNConfirme;
            this.typeEmp = typeEmp;
            this.email = email;
        }

        public string ID1 { get{return ID;}
            set { ID = value; }
        }
        public string Nom { get {return nom;}
            set{ nom = value; }
        }
        public string Prenom { get {return prenom;} set { prenom = value; }}
        public string Pseudo { get {return pseudo;} set { pseudo = value; }}
        public string Password { get {return password;} set { password = value; }}
        public int EmpNConfirme { get {return empNConfirme;} set { empNConfirme = value; }}
        public string TypeEmp { get { return typeEmp;} set{ typeEmp=value; }}
        public string Email { get { return email; } set { email = value; } }
    }
}
