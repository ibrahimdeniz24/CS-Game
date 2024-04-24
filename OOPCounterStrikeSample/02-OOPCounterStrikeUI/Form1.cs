using _01_OOPCounterStrikeLibrary.Abstract;
using _01_OOPCounterStrikeLibrary.Concrete;
using _01_OOPCounterStrikeLibrary.Enum;

namespace _02_OOPCounterStrikeUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cephane cephanem = new Cephane();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Bizim Form";
            cephanem = new Cephane();
            cephanem.MyWeapons[0] = new Bicak("xs500", "Rambo", 0.5);
            cephanem.MyWeapons[1] = new Tabanca("Magnum", "6Patlar", 1.5, false, 33, false);
            cephanem.MyWeapons[2] = new Tufek("SuperPoze", "Bimdirmeli", 4, false, 90, false, TufekTipi.Pompali);
            cephanem.MyWeapons[3] = new Tufek("Magnum", "6Patlar", 1.5, false, 33, false, TufekTipi.Taramali);
            cephanem.MyWeapons[4] = new Top("Magnum", "6Patlar", 100);
            cephanem.MyWeapons[5] = new Top("RPG", "ROKETATAR", 500);

            pictureBox1.Image = cephanem.SilahDegis(0); //B��ak geliyor.

            Form1_KeyPress(this, new KeyPressEventArgs('1')); // Form load olurken 1'e bas�lm�� gibi davran�ls�n.



            this.Focus();




        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            //B�cag�n Kes Metodunu �al��t�r�aca��m.
            //B��ak nesnesine ula�p�p kes metodunu �a��rmak istiyorum.

            //int index = Convert.ToInt32(pictureBox1.Tag);

            //Bicak bicak = (cephanem.MyWeapons[index] as Bicak);


            // b�cak harici groupmetotlar� kapat�ld��� i�in �al��mayacak visible kapal� olacak.

            Bicak bicak1 = cephanem.MyWeapons[(Convert.ToInt32(pictureBox1.Tag))] as Bicak;


            // bu �ekildede yapabiliriz. Bileyle metodu Ikesiciden geldi�i i�in ub �ekildede yapabilmekteyiz.
            //IKesici bicak1 = cephanem.MyWeapons[(Convert.ToInt32(pictureBox1.Tag))] as IKesici;


            MessageBox.Show(bicak1.Kes());





        }

        private void btnAtesEt_Click(object sender, EventArgs e)
        {
            IAtesli atesli = (cephanem.MyWeapons[(Convert.ToInt32(pictureBox1.Tag))] as IAtesli);

            MessageBox.Show(atesli.AtesEt());
            RefreshProgresBar();
        }

        private void btnYakinlastir_Click(object sender, EventArgs e)
        {
            IYakinlastir yakinlastir = (cephanem.MyWeapons[(Convert.ToInt32(pictureBox1.Tag))] as IYakinlastir);

            MessageBox.Show(yakinlastir.Yakinlastir());

        }

        private void btnBileyle_Click(object sender, EventArgs e)
        {
            IKesici kesici = cephanem.MyWeapons[(Convert.ToInt32(pictureBox1.Tag))] as IKesici;

            MessageBox.Show(kesici.Bileyle());

            //MessageBox.Show((cephanem.MyWeapons[(Convert.ToInt32(pictureBox1.Tag))] as IKesici).Bileyle()); 

            //Bileyle metodu Ikesiciden gelmekte.

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            IAtesli ateslisilah = (cephanem.MyWeapons[(Convert.ToInt32(pictureBox1.Tag))] as IAtesli);

            MessageBox.Show(ateslisilah.Doldur());
            RefreshProgresBar();


        }

        private void btnUzaklastir_Click(object sender, EventArgs e)
        {
            IYakinlastir uzaklastir = (cephanem.MyWeapons[(Convert.ToInt32(pictureBox1.Tag))] as IYakinlastir);

            MessageBox.Show(uzaklastir.Uzaklastir());


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {


                int gelenDeger = Convert.ToInt32(e.KeyChar.ToString());

                if (gelenDeger < 8 && gelenDeger > 0) //1-6 aras� de�erlenrinden birisi ise cal��t�r.
                {
                    pictureBox1.Image = cephanem.SilahDegis(gelenDeger);
                    pictureBox1.Tag = gelenDeger - 1; // dizinin i�indeki hangi indis oldugunu buluruz.

                    if (gelenDeger == 1) //Yani b��aksa group1'i ac�k b�rak.
                    {
                        grpKesici.Visible = true;
                        grpAtesli.Visible = false;
                        grpSarjor.Visible = false;
                    }
                    else//2,3,4,5,6 ya bas�ld�g�nda buras� cal��acak. Yani progresbar burada 
                    {
                        grpKesici.Visible = false;
                        grpAtesli.Visible = true;
                        grpSarjor.Visible = true;

                        RefreshProgresBar(); // ProgressBar doldurulacak.

                        //if ((cephanem.MyWeapons[(Convert.ToInt32(pictureBox1.Tag))] as IYakinlastir).DurbunluMu)
                        //{
                        //    btnYakinlastir.Visible =btnUzaklastir.Visible= true;
                        //}
                        //else
                        //{
                        //    btnYakinlastir.Visible=btnUzaklastir.Visible = false;
                        //}

                        //btnYakinlastir.Visible = btnUzaklastir.Visible = (cephanem.MyWeapons[(Convert.ToInt32(pictureBox1.Tag))] as IYakinlastir).DurbunluMu;

                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

        }


        private void RefreshProgresBar()
        {
            //Max Mermi Say�s�na g�re getirece�im.
            //1-4 aras� index de�erleri buraya gelecek.
            //B�cakl� se�ili ise 0. indis gelecek.
            int index = Convert.ToInt32(pictureBox1.Tag); // Hangi resim se�ildi�ini int de�ere at�yoruz.

            //Bana max. meri say�s� laz�m. neden ? progresbarr'�n maximum de�erini atayabilmek i�in. AtesliSilah s�n�f�n�n i�ersiiden bula�abiliriz.

            Silah silah = cephanem.MyWeapons[index]; // ekrana gelen resmin indix'ini bulduk.
            AtesliSilah atesliSilah = silah as AtesliSilah; // Ben biliyorum sliah bir ate�lisilah demektir.
            int maxMermiSayisi = atesliSilah.MaxMermiSayisi; // ekrandaki ate�lisilah�n maxmermi say�s�na ula�t�k.
            
            progressBar1.Maximum = maxMermiSayisi; // gelenate�ili silah�n maximum de�erinin progresbar�n maximumua atad�k.

            progressBar1.Value = atesliSilah.MermiAdeti;
            progressBar1.Refresh();



            //progressBar1.Maximum = (cephanem.MyWeapons[index] as AtesliSilah).MaxMermiSayisi;




        }
    }
}

