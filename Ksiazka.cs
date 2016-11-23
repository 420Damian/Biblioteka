using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
   class Ksiazka : Pozycja
    {
        private int LiczbaStron;
        private Autor autor;

        public Ksiazka() { }
        public Ksiazka(int LiczbaStron, Autor autor, string Tytul, int id, string wydawnictwo, int rokWydania) 
        {
            this.LiczbaStron = LiczbaStron;
            this.autor = autor;
            this.Tytul = Tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }

        public override void WypiszInfo()
        {
            Console.WriteLine("LiczbaStron to: {0}", LiczbaStron);
            Console.WriteLine("Autor: {0}", autor);

            Console.WriteLine("Tytul: {0}", Tytul);
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok Wydania: {0}", rokWydania);
        
        }

    }
}
