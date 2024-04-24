using _01_OOPCounterStrikeLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPCounterStrikeLibrary.Concrete
{
    public class Top : AtesliSilah
    {
        string url = @"../../../../01-OOPCounterStrikeLibrary\Sesler";
        public Top(string marka, string model, double agirlik) : base(marka, model, agirlik, Menzil.CokUzakMenzil, false, 152, false)
        {


            this.AuidoPathFire = @$"{url}\TopAtis.wav";
            this.AuidoPathReload = @$"{url}\silah1.wav";

            this.Mermisi = MermiTipi.Top;
            this.MaxMermiSayisi = 1;
        }

        public override string Doldur()
        {
            if (this.MermiAdeti < this.MaxMermiSayisi)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = this.AuidoPathReload;
                sp.Play();

                this.MermiAdeti = this.MaxMermiSayisi;

                return $"Top Atışa Hazır";

            }
            else
            {
                return "Top Zaten Dolu";
            }
        }
    }
}
