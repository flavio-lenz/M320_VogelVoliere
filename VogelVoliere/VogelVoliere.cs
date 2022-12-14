using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogelVoliere
{
    public class VogelVoliere
    {
        private System.Collections.ArrayList vogelListe = new System.Collections.ArrayList();

        public void AddVogel(Vogel neuerVogel)
        {
            vogelListe.Add(neuerVogel);
        }

        public void VogelFliegt()
        {
            foreach (Vogel vogel in vogelListe)
            {
                vogel.Fliegen();
            }
        }
    }
}
