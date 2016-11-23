using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    abstract class Pozycja
    {
        protected string Tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;

        public Pozycja() { }
        public Pozycja(string Tytul,int id,string wydawnictwo,int rokWydania)
        {
            this.Tytul = Tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;

        }


      public abstract void WypiszInfo();



    }
}
