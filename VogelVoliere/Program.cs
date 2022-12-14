using VogelVoliere;

namespace VogelVoliere
{
    class Program
    {
        static void Main(string[] args)
        {
            VogelVoliere VogelVoliere1 = new VogelVoliere();
            
            Vogel Vogel1 = new Vogel("Vogel 1");
            Vogel Vogel2 = new Vogel("Vogel 2");
            Vogel Vogel3 = new Vogel("Vogel 3");

            VogelVoliere1.AddVogel(Vogel1);
            VogelVoliere1.AddVogel(Vogel2);
            VogelVoliere1.AddVogel(Vogel3);

            VogelVoliere1.VogelFliegt();
        }
    }
}