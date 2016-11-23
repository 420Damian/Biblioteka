using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Katalog
    {


        private string dzialTematyczny;
        private List<Pozycja> listaPozycji;

        public Katalog() { }
        public Katalog(string dzialTematyczny,List<Pozycja> listaPozycji) 
        {
            this.dzialTematyczny = dzialTematyczny;
            this.listaPozycji = listaPozycji;
        }

     public void DodajPozycje(string dzialTematyczny,Pozycja pozyc)
        {
            if (dzialTematyczny == "ksiazka")
            {
              
            }
            if(dzialTematyczny == "magazyn")
            {
            
            }

        }



    }
}
