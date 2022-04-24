using System;

namespace odev_1
{
    class soru2
    {
      public  static void soru_2(int n , int m)
        {
            int[] sayilar = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. sayi", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("**** m'e eşit veya tam bölünen sayılar****");
            foreach (var item in sayilar)
            {
                if (item == m)
                {
                    Console.WriteLine("{0}", item);
                }
                else if (item % m == 0)
                {
                    Console.WriteLine("{0}", item);
                }
            }
        }
    }
}