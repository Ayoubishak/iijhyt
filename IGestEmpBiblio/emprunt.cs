using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGestEmpBiblio
{
    [Serializable]
    public class emprunt
    {
        private string IDEmpr;
        private int codeBarre;
        private Boolean confirmer;
        private DateTime dateEmp, dateFinEmp;
        private int cnfirmer;

        public emprunt()
        {
        }

        public emprunt(string IDEmpr, int codeBarre, bool confirmer, DateTime dateEmp, DateTime dateFinEmp)
        {
            this.IDEmpr = IDEmpr;
            this.codeBarre = codeBarre;
            this.confirmer = confirmer;
            this.dateEmp = dateEmp;
            this.dateFinEmp = dateFinEmp;
        }

        public string IDEmpr1 { get {return IDEmpr;} set { IDEmpr = value; }}
        public int CodeBarre { get {return codeBarre;} set { codeBarre = value; }}
        public bool Confirmer { get { return confirmer;} set { confirmer = value; }}
        public DateTime DateEmp { get {return dateEmp;} set { dateEmp = value; }}
        public DateTime DateFinEmp { get {return dateFinEmp;} set { dateFinEmp = value; }}
        public int Cnfirmer { get { return cnfirmer; } set { cnfirmer = value; } }
    }
}
