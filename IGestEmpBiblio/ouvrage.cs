using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGestEmpBiblio
{
    [Serializable]
   public class ouvrage
    {
        private int codeBarre;
       private string titre,typeOvrg,auteur,img,theme;

        public ouvrage()
        {
        }

        public ouvrage(int codeBarre, string titre, string typeOvrg, string auteur, string img, string theme)
        {
            this.codeBarre = codeBarre;
            this.titre = titre;
            this.typeOvrg = typeOvrg;
            this.auteur = auteur;
            this.img = img;
            this.theme = theme;
        }
        private int myVar;

	public int MyProperty
	{
		get { return myVar;}
		set { myVar = value;}
	}
	
        public int CodeBarre { get {return codeBarre;}
            set { codeBarre = value; }
        }
        public string Titre { get {return titre;}
            set { titre = value; }
        }

        public string TypeOvrg { get {return typeOvrg;}
            set { typeOvrg = value; }
        }

        public string Auteur { get{return auteur;}
            set { auteur = value; }
        }
        public string Img { get {return
            img;} set{ img = value; }
        }
        public string Theme
        {
            get { return theme; }
            set { theme = value; }
        }

    }
}
