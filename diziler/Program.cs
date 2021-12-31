using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Dizi Tanımlama
            // string[] renkler = new string[5];
            // string[] hayvanlar ={"Kedi","Köpek","Kuş","Maymun"};

            // int[] dizi;
            // dizi= new int[5];
            // // Diziler Değer Atama ve Erişim
            // renkler[0]="Mavi";
            
            
            // dizi[3] = 10;
            
            // Console.WriteLine(hayvanlar[1]);
            // Console.WriteLine(dizi[3]);
            // Console.WriteLine(renkler[0]);
            
            //Döngülerle dizi
            
            Console.WriteLine("Sayı");
            int sayi =int.Parse(Console.ReadLine());
            int[] array = new int[sayi];
            int total=0;
            for(int i=0;i<sayi ;i++)
            {
                Console.WriteLine($"{i+1}'inci sayı:");
                array[i]=int.Parse(Console.ReadLine());

            }
            foreach (var item in array)
            {
                total+=item;
            }
            Console.WriteLine("Ortalama:" + total/sayi);
        }
    }
}
