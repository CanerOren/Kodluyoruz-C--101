using System;

namespace metotlar_overloading
{
    class Program{
        static void Main(string[] args)
        {
            //out paramtereler
            string sayi="999";
            
           bool sonuc= int.TryParse(sayi,out int outSayi);
           if(sonuc)
           {
               Console.WriteLine("Başarılı");
               Console.WriteLine(outSayi);
           }
           else
           {
               Console.WriteLine("Başarısız");
               Console.WriteLine(outSayi);
           }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int toplam);
            Console.WriteLine(toplam);

            //Metot Overloading
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);

            //Metot İmzası
            //metotAdı + parametre sayisi + parametre
            instance.EkranaYazdir("Caner","Ören");

        }

    }
    class Metotlar
    {
        public void Topla(int a, int b , out int toplam)
        {
            toplam = a+b;
            
        }

        public void EkranaYazdir(string veri )
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri )
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri , string veri2)
        {
            Console.WriteLine(veri+veri2);
        }
    }  

    
}
