using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication6
{
    interface IPrzychodnia
    {
        public void UstawLekarza(string imieN, string specjalnosc)
        { 
        
        }
        public void ZapiszDoLekarza(string imieN, int wiek, string choroba)
        { 
        
        }
        public string WykonajPorade()
        { 
        
        }
        public string WykonajBadanie()
        {

        }
        public int CzasOczekiwania()
        {

        }
        public void GenerujRaport()
        {

        }
    }
}
