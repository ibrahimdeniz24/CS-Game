
using _01_OOPCounterStrikeLibrary.Enum;
using System.Media;

namespace _01_OOPCounterStrikeLibrary.Concrete
{
    public class Silah //Base Class
    {
        public double Agirlik { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public bool AtesliMi { get; set; }
        public Menzil Menzil { get; set; }


        //Bunu yazarak default construkcetı çiğnemiş oluyoruz.
        // Silahtan miras alan default constructer olmadığından buradan miras alacak.
        public Silah(string marka,string model,double agirlik,bool atesliMi,Menzil menzil)
        {
            Menzil = menzil;
            Model = model;
            Marka = marka;
            Model = model;
            AtesliMi = atesliMi;
        }

        //bin / debug/net.08 içersinden 4 klasör cıkıp sesler dosyasını bulacak.
        string url = @"../../../../01-OOPCounterStrikeLibrary\Sesler";  

        internal string Oldur()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = $@"{url}/death.wav";

            sp.Play();
            return "Öldürüldü";
        }

        internal string Yarala()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = $@"{url}/scream.wav";

            sp.Play();
            return "Yaralandı";

        }


    }
}
