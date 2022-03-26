using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGestEmpBiblio
{
    [Serializable]
    public class listePrive
    {
        private string IDEmpr;
        private DateTime dateD, dateF;

        public listePrive(string iDEmpr, DateTime dateD, DateTime dateF)
        {
            IDEmpr = iDEmpr;
            this.dateD = dateD;
            this.dateF = dateF;
        }

        public DateTime DateD { get {return dateD;} set { dateD = value; }}
        public DateTime DateF { get {return dateF;} set { dateF = value; }}
        public string IDEmpr1 { get { return IDEmpr; } set { IDEmpr = value; } }
    }
}
