using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogelVoliere
{
    public class Strauss : Vogel
    {
        public Strauss(string name) : base(name)
        {
        }

        override public void Fliegen()
        {
            Console.WriteLine("Der Strauss kann nicht fliegen");
        }
    }
}
