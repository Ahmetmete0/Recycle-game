
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G191210053_Proje
{

   

    class OrganikAtik :  IAtikKutusu
    {
        public int _organikAtikKapasite = 700;
        public int _doluHacim = 0;

        public int Kapasite
        {
            get { return _organikAtikKapasite; }
            set { _organikAtikKapasite = value; }


        }

        public int DoluHacim => _doluHacim;

        public int DolulukOrani => 100* _doluHacim / _organikAtikKapasite;

        public int BosaltmaPuani => 0 ;

      


        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }
            else
            {

                return false;

            }
        }


        public bool Ekle(Atik atik)
        {
            if(_organikAtikKapasite - _doluHacim >= atik.ekle)
            {
                return true;

            }

            return false;


        }

    }


    class Kagit :  IAtikKutusu
    {

        public int _kagitKapasite=1200;
        public int _doluHacim = 0;
        public int Kapasite
        {
            get { return _kagitKapasite; }
            set { _kagitKapasite = value; }


        }

        public int DoluHacim
        {

            get
            {
               return _doluHacim;

            }

        }

        public int DolulukOrani
        {

            get
            {

                return 100 * _doluHacim / _kagitKapasite;


            }

        }

        public int BosaltmaPuani => 1000;

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }
            else
            {

                return false;

            }
        }

        public bool Ekle(Atik atik)
        {
            if (_kagitKapasite - _doluHacim >= atik.ekle)
            {
                return true;

            }

            return false;
        }
    }


    class Cam : IAtikKutusu
    {

      

        public int _camKapasite=2200;
        public int _doluHacim = 0;

        public int Kapasite
        {
            get { return _camKapasite; }
            set { _camKapasite = value; }
        }

        public int DoluHacim => _doluHacim;

        public int DolulukOrani => 100 * _doluHacim / _camKapasite;

        public int BosaltmaPuani => 600;

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }
            else
            {

                return false;

            }
        }

        public bool Ekle(Atik atik)
        {
            if (_camKapasite - _doluHacim >= atik.ekle  )
            {
                return true;

            }

            return false;
        }
    }


    class Metal : IAtikKutusu
    {

        public int _metalKapasite=2300;
        public int _doluHacim = 0;

        public int Kapasite
        {
            get { return _metalKapasite; }
            set { _metalKapasite = value; }


        }

        public int DoluHacim => _doluHacim;

        public int DolulukOrani => 100 * _doluHacim / _metalKapasite;

        public int BosaltmaPuani => 800 ;

        public bool Bosalt()
        {
            if (DolulukOrani >= 75)
            {
                return true;
            }
            else
            {

                return false;

            }
           
        }

        public bool Ekle(Atik atik)
        {
            if (_metalKapasite - _doluHacim >= atik.ekle)
            {
                return true;

            }

            return false;
        }
    }


   



   
}
