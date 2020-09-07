
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G191210053_Proje
{

    

    public class Atik
    {

        
        public int ekle;

    }

    public interface IAtik
    {
        int Hacim { get; }
        System.Drawing.Image Image { get; }
    }


    public interface IAtikKutusu : IDolabilen
    {
        /// <summary>
        /// Atık kutusu boşaltıldığında oyun puanına kaç puan ekleneceğini döndürür.
        /// </summary>
        int BosaltmaPuani { get; }
        /// <summary>
        /// Atık kutusunda gönderilen atığı alacak kadar boş yer varsa atığı kutuya ekler.
        /// </summary>
        /// <param name="atik">Eklenecek Atık</param>
        /// <returns>Atığın kutuya eklenip eklenmediğini döndürür.</returns>
        bool Ekle(Atik atik);
        /// <summary>
        /// Atık kutusunun doluluk oranı %75'in üstündeyse atık kutusunu boşaltır.
        /// </summary>
        /// <returns>Atık kutusunun boşaltılıp boşaltılmadığını döndürür.</returns>
        bool Bosalt();
    }

    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; }
        int DolulukOrani { get; }
    }

    
    class Bardak : Atik, IAtik
    {
        
        public Bardak()
        {

            ekle = Hacim;

        }
        
           
        public int Hacim => 250;

        public Image Image => Image.FromFile("Bardak.jpg");
    }

    class CamSise : Atik, IAtik
    {

        

        public CamSise()
        {

            ekle = Hacim;

        }

        public int Hacim =>600;

        public Image Image => Image.FromFile("Cam_Sise.jpg");
    }

    class Dergi : Atik, IAtik
    {

       

        public Dergi()
        {

            ekle = Hacim;

        }

        public int Hacim => 200;

        public Image Image => Image.FromFile("Dergi.jpg");
    }

    class Domates : Atik, IAtik
    {

       

        public Domates()
        {

            ekle = Hacim;

        }

        public int Hacim => 150;

        public Image Image => Image.FromFile("Domates.jpg");
    }


    class Gazete : Atik, IAtik
    {

       

        public Gazete()
        {

            ekle = Hacim;

        }

        public int Hacim => 250;

        public Image Image => Image.FromFile("Gazete.jpg");
    }

    class KolaKutusu : Atik, IAtik
    {

       

        public KolaKutusu()
        {

            ekle = Hacim;

        }











        public int Hacim => 350;

        public Image Image => Image.FromFile("Kola_Kutusu.jpg");
    }

    class Salatalik : Atik, IAtik
    {

        

        public Salatalik()
        {

            ekle = Hacim;

        }

        public int Hacim => 120;

        public Image Image => Image.FromFile("Salatalık.jpg");
    }



    class SalcaKutusu : Atik, IAtik
    {

       

        public SalcaKutusu()
        {

            ekle = Hacim;

        }

        public int Hacim => 550;

        public Image Image => Image.FromFile("Salca_Kutusu.jpg");

        

    }

}
