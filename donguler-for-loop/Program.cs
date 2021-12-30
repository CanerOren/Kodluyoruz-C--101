using System;

    namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayılarını ekra na yazdır.
            // Console.WriteLine("Lütfen bir sayı giriniz:");
            // int sayac = int.Parse(Console.ReadLine());
            // for(int i=0;i<=sayac ; i++)
            // {
            //     //komutlar
            //     if(i%2!=0)
            //     {
            //         Console.WriteLine(i);
            //     }
            // }
            // // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamını yazdırma
            // int tekToplam = 0;
            // int ciftToplam = 0;
            // for(int i=0 ; i <= 1000 ; i++)
            // {
            //     if(i%2 ==1)
            //     {
            //         tekToplam+=i;
            //     }
            //     else
            //     {
            //         ciftToplam+=i;
            //     }
            // }
            // Console.WriteLine($"Çift Toplam: {ciftToplam}");
            // Console.WriteLine($"Tek Toplam:{tekToplam}");
            //break , continue

            for(int i = 1 ; i < 10 ; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }
        }
    }
}
