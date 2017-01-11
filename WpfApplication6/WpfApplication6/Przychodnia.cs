using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication6
{
    class Przychodnia : IPrzychodnia
    {
        private Lekarz lekarz;
        private Stack<Pacjent> pacjenci;

        public void UstawLekarza(string imieN, string specjalnosc)
        {
            lekarz = new lekarz(string imieN, string specjalnosc);
        }
        public void ZapiszDoLekarza(string imieN, int wiek, string choroba)
        {
            pacjenci.push(new Pacjent(string imieNazwisko,int wiek, string choroba));
        }
        public string WykonajPorade()
        { 
            return "Wykonano porade! " + pacjent.Pop().ToString();
        }
        public string WykonajBadanie()
        {
            return "Wykonano badanie! " + pacjent.Pop().ToString();
        }
        public int CzasOczekiwania()
        {

        }
        public void GenerujRaport()
        {

        }
        public bool CzyLekarz()
        {
           
        }

    }
}
