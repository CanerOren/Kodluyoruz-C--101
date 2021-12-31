using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //while
            //1 den başlayarak konsoldan girilen sayıya kadar (saı dahil) ortalama hesaplayıp konsola yazdıran program
            Console.WriteLine("Sayı:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam=0;
            while(sayac <= sayi)
            {
                toplam +=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            // a'dan z'ye kadar tüm harfleri konsola yazdırma
            char character = 'a';
            while (character <= 'z')
            {
                 Console.Write(character);
                character++;
            }

            Console.WriteLine("***** Foreach ******");
            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}