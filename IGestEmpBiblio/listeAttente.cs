using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGestEmpBiblio
{
    [Serializable]
    public class listeAttente
    {
        private int codeBarre, priorite;
        private string IDEmpr;

        public listeAttente()
        {
        }

        public listeAttente(int codeBarre, int priorite, string iDEmpr)
        {
            this.codeBarre = codeBarre;
            this.priorite = priorite;
            IDEmpr = iDEmpr;
        }

        public int CodeBarre { get {return codeBarre;} set { codeBarre = value; }}
        public int Priorite { get {return priorite;} set { priorite = value; }}
        public string IDEmpr1 { get {return IDEmpr; } set { IDEmpr = value; } }
    }
}
