using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPCounterStrikeLibrary.Concrete
{
    public class Cephane
    {
        public Silah[] MyWeapons { get; set; }

        public Cephane()
        {
            MyWeapons = new Silah[6];
        }

        public Image SilahDegis(int hangisi)
        {
            string url = @"../../../../01-OOPCounterStrikeLibrary\Resimler";

            switch (hangisi)
            {
                case 1:
                    return Image.FromFile($@"{url}\Knife.jpg");
                case 2:
                    return Image.FromFile($@"{url}\Pistol.jpg");
                case 3:
                    return Image.FromFile($@"{url}\ShotGun.jpg");
                case 4:
                    return Image.FromFile($@"{url}\MachineGun.gif");
                case 5:
                    return Image.FromFile($@"{url}\KF1500.jpg");
                case 6:
                    return Image.FromFile($@"{url}\RPG.jpg");
                case 7:
                    return Image.FromFile($@"{url}\RPG.jpg");
            }

            return Image.FromFile($@"{url}\Knife.jpg");
        }
    }
}
