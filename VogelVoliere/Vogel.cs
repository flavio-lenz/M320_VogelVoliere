using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogelVoliere
{
    public class Vogel
    {
        public Vogel(string name)
        {
            this.Name = name;
        }
        
        public string Name { get; set; }
        private string _farbe;

        public string Farbe
        {
            get { return _farbe; }
            set { _farbe = value; }
        }

        public virtual void Fliegen()
        {
            Console.WriteLine("Der Vogel " + Name + " fliegt");
        }

        public void EiLegen()
        {
            Console.WriteLine("Der Vogel " + Name + " legt ein Ei");
        }
    }
}
