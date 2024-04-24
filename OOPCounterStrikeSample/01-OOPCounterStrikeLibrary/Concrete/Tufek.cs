using _01_OOPCounterStrikeLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPCounterStrikeLibrary.Concrete
{
    public class Tufek : AtesliSilah
    {
        public TufekTipi Tip { get; set; }

        string url = @"../../../../01-OOPCounterStrikeLibrary\Sesler";
        public Tufek(string marka, string model, double agirlik, bool yivliMi, double kalibre, bool durbunluMu, TufekTipi tip) : base(marka, model, agirlik, Menzil.UzakMenzil, yivliMi, kalibre, durbunluMu)
        {
            if (Tip == TufekTipi.Pompali)
            {
                this.Mermisi = MermiTipi.Sacmali;
                this.AuidoPathFire = @$"{url}\Pompali.wav";
                this.AuidoPathReload = @$"{url}\PompaliSarjor.wav";
                this.MaxMermiSayisi = 8;
            }
            else if (Tip == TufekTipi.Taramali)
            {
                this.Mermisi = MermiTipi.Cekirdekli;
                this.AuidoPathFire = @$"{url}\Taramali.wav";
                this.AuidoPathReload = @$"{url}\Taramali1.wav";
                this.MaxMermiSayisi = 30;

            }

        }

        public override string Doldur()
        {
            if (this.Tip == TufekTipi.Taramali && this.MermiAdeti < this.MaxMermiSayisi)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = this.AuidoPathReload;
                player.Play();

                this.MermiAdeti = this.MaxMermiSayisi;

                return "Taramalı Tüfek Sarjörü fullendi";
            }
            else if (this.Tip == TufekTipi.Pompali && this.MermiAdeti < this.MaxMermiSayisi)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = this.AuidoPathReload;
                player.Play();

                this.MermiAdeti++;

                return "Pompaliya bir fişek konudu";

            }
            else
            {
                return "Mermi Full";
            }
            
        }
    }
}
