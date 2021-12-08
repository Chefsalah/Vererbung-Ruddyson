using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    internal class Sauegetiere : Tiere
    {
        protected double koerpertemperatur;

        //Base Konstrucktor
        protected Sauegetiere(int lebenserwartung, string bezeichnung, double koerpertemperatur) : base(lebenserwartung, bezeichnung)
        {
            this.koerpertemperatur = koerpertemperatur;
        }
        //Override abstrackt
        protected override string Lebenserwartung()
        {
            return "" + base.lebenserwartung;
        }
        //Base
        public string tierInfos()
        {
            return base.LebenserwartungUndBezeichnung();
        }
        //Override Virtual
        protected override string LebenserwartungUndBezeichnung()
        {
            return base.LebenserwartungUndBezeichnung();
        } 

         
    }
}
