
using System;
using System.Windows.Forms;
using System.Drawing;

namespace G191210053_Proje
{

    public partial class Form1 : Form
    {

        OrganikAtik organikAtik = new OrganikAtik();
        Kagit kagit = new Kagit();
        Cam cam = new Cam();
        Metal metal = new Metal();

        CamSise camSise = new CamSise();
        Salatalik salatalik = new Salatalik();
        SalcaKutusu salcaKutusu = new SalcaKutusu();
        Bardak bardak = new Bardak();
        Gazete gazete = new Gazete();
        Dergi dergi = new Dergi();
        Domates domates = new Domates();
        KolaKutusu kolaKutusu = new KolaKutusu();

        Atik atik = new Atik();

        string foto;


        Random rastgele = new Random();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            //Progress Barların max değerleri
            progressBar1.Maximum = organikAtik.Kapasite;
            progressBar2.Maximum = kagit.Kapasite;
            progressBar3.Maximum = cam.Kapasite;
            progressBar4.Maximum = metal.Kapasite;

            //Oyun başlamadan butonların basılamaması
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;

            
           
        }

         

        public void resimler()
        {

            int resimNo = rastgele.Next(1, 9);

            //Rastgele resim seçme ve ekrana çıkartma (Switch case yapısıyla)
            switch (resimNo)
            {

                case 1:
                    pictureBox1.Image = salatalik.Image;
                    foto = "Salatalık";
                    break;

                case 2:
                    pictureBox1.Image = camSise.Image;
                    foto = "CamŞişe";
                    break;

                case 3:
                    pictureBox1.Image = bardak.Image;
                    foto = "Bardak";
                    break;

                case 4:
                    pictureBox1.Image = salcaKutusu.Image;
                    foto = "SalçaKutusu";
                    break;

                case 5:
                    pictureBox1.Image = domates.Image;
                    foto = "Domates";
                    break;

                case 6:
                    pictureBox1.Image = kolaKutusu.Image;
                    foto = "KolaKutusu";
                    break;

                case 7:
                    pictureBox1.Image = gazete.Image;
                    foto = "Gazete";
                    break;

                case 8:
                    pictureBox1.Image = dergi.Image;
                    foto = "Dergi";
                    break;






            }




        }


        



        int saniye = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Saniyenin geriye doğru gitmesi
            saniye--;

            //Saniyenin akması ve timer
            label3.Text = Convert.ToString(saniye);
         
            

            if (label3.Text == "0") //Süre bittiğinde butonların devre dışı kalması ve timerın durması
            {

                //Renk değişimi
                label3.ForeColor = Color.Turquoise;
                label5.ForeColor = Color.Turquoise;

                panel8.BackColor = Color.Azure;
                panel10.BackColor = Color.Azure;

                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;

                timer1.Stop();

                button1.Enabled = true;



            }



        }




        private void button1_Click(object sender, EventArgs e)
        {
            //Timerın başlaması
            timer1.Start();

            //Renk değişimi
            label3.ForeColor = Color.Azure;
            label5.ForeColor = Color.Azure;

            panel8.BackColor = Color.Turquoise;
            panel10.BackColor = Color.Turquoise;




            

            //Değerlerin sıfırlanması
            label3.Text = "60";
            saniye = 60;
            label5.Text = "0";


            //Listboxların temizlenmesi
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();


            //Butonların aktif hale gelmesi
            button1.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;


            //Progress Barların sıfırlanması
            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;

            //Yeni oyunda kapasiteleri sıfırlamak 
            organikAtik._doluHacim = 0;
            kagit._doluHacim = 0;
            cam._doluHacim = 0;
            metal._doluHacim = 0;

            //Yeni resim
            resimler();

        }

       



        private void button3_Click(object sender, EventArgs e)
        {
           
            if(organikAtik.Bosalt())//Eğer %75 in üstündeyse boşaltma işlemi
            {

                label5.Text = Convert.ToString(organikAtik.BosaltmaPuani + Convert.ToInt32(label5.Text));//Boşaltma puanı ekleme
                saniye += 3; //Saniye arttırma
                listBox1.Items.Clear();//Listboxu temizleme
                progressBar1.Value = 0;//Progress barı sıfırlama
                organikAtik._doluHacim = 0;//Dolu hacimi sıfırlama
            }

        }
                        
           

        private void button4_Click(object sender, EventArgs e)
        {           
            if(kagit.Bosalt()) //Eğer %75 in üstündeyse boşaltma işlemi
            {
                label5.Text = Convert.ToString(kagit.BosaltmaPuani + Convert.ToInt32(label5.Text)); //Boşaltma puanı ekleme
                saniye += 3; //Saniye arttırma
                listBox2.Items.Clear(); //Listboxu temizleme
                progressBar2.Value = 0; //Progress barı sıfırlama
                
                kagit._doluHacim = 0; //Dolu hacimi sıfırlama
                

            }
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cam.Bosalt())//Eğer %75 in üstündeyse boşaltma işlemi
            {

                
                label5.Text = Convert.ToString(cam.BosaltmaPuani + Convert.ToInt32(label5.Text)); //Boşaltma puanı ekleme
                saniye += 3; //Saniye arttırma
                listBox3.Items.Clear();//Listboxu temizleme
                progressBar3.Value = 0;//Progress barı sıfırlama
                cam._doluHacim = 0;//Dolu hacimi sıfırlama

            }
           

        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (metal.Bosalt())//Eğer %75 in üstündeyse boşaltma işlemi
            {

                label5.Text = Convert.ToString(metal.BosaltmaPuani + Convert.ToInt32(label5.Text)); //Boşaltma puanı ekleme
                saniye += 3; //Saniye arttırma
                listBox4.Items.Clear();//Listboxu temizleme
                progressBar4.Value = 0;   //Progress barı sıfırlama          
                metal._doluHacim = 0;//Dolu hacimi sıfırlama
            }

          
        }










        private void button7_Click(object sender, EventArgs e)
        {
           

            if (foto == "Domates") //Fotoğraf ile ürün aynı ise ekleme işlemleri
            {
                if (organikAtik.Ekle(domates)) //Boş yer varsa ürünü ekleme
                {

                    
                    listBox1.Items.Add("Domates (150)"); //Ürünü listbox'a ekleme
                    label5.Text = Convert.ToString(Convert.ToInt32(label5.Text) + 150); //Eklenen ürünün puanını, puanlara ekleme
                    progressBar1.Value = (progressBar1.Value + domates.Hacim); //Eklenen ürün kadar progress barın dolması
                    organikAtik._doluHacim += 150;//Kutunun doluluğunun artması


                    resimler();//Yeni resim getirme
                }
                else { }
                
                
                
            }

            if (foto == "Salatalık") //Fotoğraf ile ürün aynı ise ekleme işlemleri
            {
                if (organikAtik.Ekle(salatalik))//Boş yer varsa ürünü ekleme
                {                   
                    listBox1.Items.Add("Salatalık (120)");//Ürünü listbox'a ekleme
                    label5.Text = Convert.ToString(Convert.ToInt32(label5.Text) + 120);//Eklenen ürünün puanını, puanlara ekleme
                    resimler();//Yeni resim getirme
                    progressBar1.Value = (progressBar1.Value + salatalik.Hacim);//Eklenen ürün kadar progress barın dolması
                    organikAtik._doluHacim += 120;//Kutunun doluluğunun artması
                }
                else { }
                
            }

            else { }          
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (foto == "Dergi") //Fotoğraf ile ürün aynı ise ekleme işlemleri
            {

                if (kagit.Ekle(dergi)) //Boş yer varsa ürünü ekleme
                {                   
                    listBox2.Items.Add("Dergi (200)");//Ürünü listbox'a ekleme
                    label5.Text = Convert.ToString(Convert.ToInt32(label5.Text) + 200);//Eklenen ürünün puanını, puanlara ekleme
                    resimler();//Yeni resim getirme
                    progressBar2.Value = (progressBar2.Value + dergi.Hacim);//Eklenen ürün kadar progress barın dolması
                    kagit._doluHacim += 200;//Kutunun doluluğunun artması
                }
                else { }
                          
            }

            if (foto == "Gazete") //Fotoğraf ile ürün aynı ise ekleme işlemleri
            {
                if (kagit.Ekle(gazete))//Boş yer varsa ürünü ekleme
                {                  
                    listBox2.Items.Add("Gazete (250)");//Ürünü listbox'a ekleme
                    label5.Text = Convert.ToString(Convert.ToInt32(label5.Text) + 250);//Eklenen ürünün puanını, puanlara ekleme
                    resimler();//Yeni resim getirme
                    progressBar2.Value = (progressBar2.Value + gazete.Hacim);//Eklenen ürün kadar progress barın dolması
                    kagit._doluHacim += 250;//Kutunun doluluğunun artması
                }
                else { }

            }

            else { }

        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (foto == "CamŞişe") //Fotoğraf ile ürün aynı ise ekleme işlemleri
            { 
                if (cam.Ekle(camSise))//Boş yer varsa ürünü ekleme
                {                    
                    listBox3.Items.Add("Cam Şişe (600)");//Ürünü listbox'a ekleme
                    label5.Text = Convert.ToString(Convert.ToInt32(label5.Text) + 600);//Eklenen ürünün puanını, puanlara ekleme
                    resimler();//Yeni resim getirme
                    progressBar3.Value = (progressBar3.Value + camSise.Hacim);//Eklenen ürün kadar progress barın dolması
                    cam._doluHacim += 600;//Kutunun doluluğunun artması
                }
                else { }

            }

            if (foto == "Bardak") //Fotoğraf ile ürün aynı ise ekleme işlemleri
            {
                if (cam.Ekle(bardak))//Boş yer varsa ürünü ekleme
                {                    
                    listBox3.Items.Add("Bardak (250)");//Ürünü listbox'a ekleme
                    label5.Text = Convert.ToString(Convert.ToInt32(label5.Text) + 250);//Eklenen ürünün puanını, puanlara ekleme
                    resimler();//Yeni resim getirme
                    progressBar3.Value = progressBar3.Value + bardak.Hacim;//Eklenen ürün kadar progress barın dolması
                    cam._doluHacim += 250;//Kutunun doluluğunun artması
                }
                else { }

            }

            else { }

        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (foto == "KolaKutusu")//Fotoğraf ile ürün aynı ise ekleme işlemleri
            {
                if (metal.Ekle(kolaKutusu))//Boş yer varsa ürünü ekleme
                {                   
                    listBox4.Items.Add("Kola Kutusu (350)");//Ürünü listbox'a ekleme
                    label5.Text = Convert.ToString(Convert.ToInt32(label5.Text) + 350);//Eklenen ürünün puanını, puanlara ekleme
                    resimler();//Yeni resim getirme
                    progressBar4.Value = (progressBar4.Value + kolaKutusu.Hacim);//Eklenen ürün kadar progress barın dolması
                    metal._doluHacim += 350;//Kutunun doluluğunun artması
                }
                else { }

            }

            if (foto == "SalçaKutusu") //Fotoğraf ile ürün aynı ise ekleme işlemleri
            {

                if (metal.Ekle(salcaKutusu))//Boş yer varsa ürünü ekleme
                {                    
                    listBox4.Items.Add("Salça Kutusu (550)");//Ürünü listbox'a ekleme
                    label5.Text = Convert.ToString(Convert.ToInt32(label5.Text) + 550); //Eklenen ürünün puanını, puanlara ekleme
                    resimler(); //Yeni resim getirme
                    progressBar4.Value = (progressBar4.Value + salcaKutusu.Hacim);//Eklenen ürün kadar progress barın dolması
                    metal._doluHacim += 550; //Kutunun doluluğunun artması
                }
                else { }

            }
            else { }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }



}
