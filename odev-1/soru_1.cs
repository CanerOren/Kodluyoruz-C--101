using System;

namespace odev_1
{
    class soru1
    {
       public static void  soru_1(int n)
        {
            int[] sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayı", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("****Çift Sayılar****");
            foreach (var item in sayilar)
            {
                if (item % 2 == 0)
                {

                    Console.WriteLine(item);
                }
            }
        }
    }

}