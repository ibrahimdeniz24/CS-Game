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
    public abstract class AtesliSilah : Silah, IAtesli, IYakinlastir
    {
        //Ateşli silahtan miras aldığından dolayı Silah'ın constructorena istediği parametreli vermek zorunda.
        //Ateşklissilah kısmına (kullanıcı yada devloper x'in gidriği değeri alıyor. ) eğer marka sabit olsaydı. base tarafında onu sabitliyoruz. ateşlisilah tarafında ne yazılırsa yazılsın base tarafı gönderilir. o yüzden ateşli silahi girdik. herşekilde ateşli oldugunu belirtmek için true değerini girdi,
        public AtesliSilah(string marka, string model, double agirlik, Menzil menzil, bool yivliMi, double kalibre, bool durbunluMu) : base(marka, model, agirlik, true, menzil)
        {
            this.YivliMi = yivliMi;
            this.Kalibre = kalibre;
            this.DurbnuluMu = durbunluMu;
        }


        public bool YivliMi { get; set; }
        public double Kalibre { get; set; }
        public bool DurbnuluMu { get; set; }
        public MermiTipi Mermisi { get; set; }
        public int MermiAdeti { get; set; }
        public int MaxMermiSayisi { get; set; }
        public Random Olasilik { get; set; }
        public string AuidoPathFire { get; set; }
        public string AuidoPathReload { get; set; }
        public bool DurbunluMu { get; set; }



        //IAtesli interface'inden implimente alarak buraya geldi.
        // Ateşli silahlardan inherite alan tüm silahalrad bu metot otomatik oluyor.
        public string AtesEt()
        {
            Random Olasilik = new Random();
            
            int oldurulduMu = Olasilik.Next(1, 3);

            string url = @"../../../../01-OOPCounterStrikeLibrary\Sesler";

            if (MermiAdeti > 0)
            {

                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = this.AuidoPathFire;
                sp.PlaySync();

                this.MermiAdeti--;

                return ("Ateş Edildi ve " + ((oldurulduMu == 1) ? Yarala() : Oldur()));
            }
            else
            {
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = $@"{url}\GunEmpty.wav";

                sp.PlaySync();

                return "Mermimiz Bitti";
            }
        }

        //Ateşli Silah'ı miras alan kendisi Doldur Metodunu doldursun istediğimiz için boş bıraktık. //overide yapılması için abstract taptık
        public abstract string Doldur();

        public string Uzaklastir()
        {
            return this.DurbunluMu ? "Uzaklaştırıldı" : "Silahımız Dürbünsüzdür";
        }

        public string Yakinlastir()
        {
            return this.DurbunluMu ? "Yakınlaştırıldı" : "Silahımız Dürbünsüzdür";

        }
    }
}
