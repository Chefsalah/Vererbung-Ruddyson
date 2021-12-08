using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
     abstract class Tiere
    {
        protected int lebenserwartung;
        protected string bezeichnung;
       protected Tiere(int lebenserwartung,string bezeichnung)
        {
            this.lebenserwartung = lebenserwartung;
            this.bezeichnung = bezeichnung;
        }
    
        protected virtual  string LebenserwartungUndBezeichnung()
        {
            return lebenserwartung + bezeichnung;
        }
        protected abstract string Lebenserwartung();    
    
    }
}
