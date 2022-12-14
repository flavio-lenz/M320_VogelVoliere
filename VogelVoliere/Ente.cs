using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogelVoliere
{
    public class Ente : Vogel
    {
        public Ente(string name) : base(name)
        {
        }

        public void Schwimmen()
        {
            Console.WriteLine("Die Ente kann schwimmen");
        }
    }
}
