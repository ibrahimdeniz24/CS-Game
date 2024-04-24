using _01_OOPCounterStrikeLibrary.Abstract;
using _01_OOPCounterStrikeLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPCounterStrikeLibrary.Concrete
{
    // Bıçak bir Silah mıdır ? Tabanca,Top,Tufek
    // Derived Class
    public class Bicak : Silah, IKesici
    {
        private int _kesmeSayisi; // field inherite aldığında başkası ulaşamaması için private yaptık.

        public Bicak(string marka, string model, double agirlik) : base(marka, model, agirlik, false, Menzil.YakinMenzil)
        {
            _kesmeSayisi = 5;
        }
        //bin / debug/net.08 içersinden 4 klasör cıkıp sesler dosyasını bulacak.
        string url = @"../../../../01-OOPCounterStrikeLibrary\Sesler";
        public string Bileyle()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = $@"{url}/SharpenKnife.wav";

            sp.Play();
            return "Bıçak Jilet gibi Oldu";
        }

        public string Kes()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = $@"{url}/StabKnife.wav";

            sp.PlaySync();

            if (_kesmeSayisi > 0)
            {
                _kesmeSayisi--;
                return Yarala();
            }
            else if (_kesmeSayisi == 0)
            {
                _kesmeSayisi = 5;
                return Oldur() + "ve" + Bileyle();
            }
            return "";

        }
    }
}
