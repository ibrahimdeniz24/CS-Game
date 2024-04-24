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
    public class Havan : AtesliSilah, IAtesli
    {
        string url = @"../../../../01-OOPCounterStrikeLibrary\Sesler";
        public Havan(string marka, string model, double agirlik ) : base(marka, model, agirlik, Menzil.CokUzakMenzil, false, 400, false)
        {
            this.AuidoPathFire = @$"{url}\TopAtis.wav";
            this.AuidoPathReload = @$"{url}\silah2.wav";

            this.Mermisi = MermiTipi.Roket;
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

                return $"Roket Atışa Hazır";
            }
            else
            {
                return "Havan Ağzına Kadar Dolu";
            }
            
        }
    }
}
