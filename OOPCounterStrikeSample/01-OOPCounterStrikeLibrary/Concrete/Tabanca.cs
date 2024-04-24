using _01_OOPCounterStrikeLibrary.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPCounterStrikeLibrary.Concrete
{
    //Tabanca, Top , tüfek bunlar ateşliSilah
    public class Tabanca : AtesliSilah
    {
        public Tabanca(string marka, string model, double agirlik, bool yivliMi, double kalibre, bool durbunluMu) : base(marka, model, agirlik, Menzil.UzakMenzil, yivliMi, kalibre, durbunluMu)
        {
            this.AuidoPathFire = @"../../../../01-OOPCounterStrikeLibrary\Sesler\Tabanca.wav";
            this.AuidoPathReload = @"../../../../01-OOPCounterStrikeLibrary\Sesler\silah1.wav";

            this.Mermisi = MermiTipi.Cekirdekli;
            this.MaxMermiSayisi = 15;




        }

        public override string Doldur()
        {
            if (this.MermiAdeti<this.MaxMermiSayisi)
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = this.AuidoPathReload;
                sp.Play();

                this.MermiAdeti = this.MaxMermiSayisi;

                return $"Tabancaya {this.MermiAdeti} mermilik şarjör takıldı";
                
            }
            else
            {
                return "şarjör zaten dolu";
            }
        }
    }
}
