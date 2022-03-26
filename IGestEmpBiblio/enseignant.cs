using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGestEmpBiblio
{
    [Serializable]
    public class enseignant: emprunteur
    {
        private string grade;
        private string matricule;

        public enseignant()
        { 
            }


        public enseignant(string matricule, string grade, string iD, string nom, string prenom, string pseudo, string password, int empNConfirme, string typeEmp, string email) :base(iD,nom,prenom,pseudo,password,empNConfirme,typeEmp,email)
        {
            
            this.matricule = matricule;
            this.grade = grade;
        }

        public string Matricule { get {return matricule;} set { matricule = value; }}
        public string Grade { get { return grade; } set { grade = value; } }
    }
}
