using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Czasopismo : Pozycja
    {
        private int numer;

        public Czasopismo(){}
        public Czasopismo(int numer, string Tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.numer = numer;
            this.Tytul = Tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("numer to: {0}", numer);
            Console.WriteLine("Tytul: {0}", Tytul);
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok Wydania: {0}", rokWydania);
        
        }

    }
}
