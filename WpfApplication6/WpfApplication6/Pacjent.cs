using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication6
{
    class Pacjent : Osoba
    {
        private int wiek;
        private string choroba;
        public Pacjent(string imieNazwisko, int wiek, string choroba)
        {
            this.imieNazwisko = imieNazwisko;
            this.wiek = wiek;
            this.choroba = choroba;

        }
        public string ToString()
        {
           
        }
    }
}
