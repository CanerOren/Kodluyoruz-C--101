using System;

namespace odev_1
{
   public class soru3
    {
       public static void soru_3(int n)
        {
            string[] kelimeler = new string[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("{0}. kelime", i + 1);
                kelimeler[i] = Console.ReadLine();
            }

            Console.WriteLine("**** Cümle *****");
            for(int i=(n-1);i>=0;i--)
            {
                Console.WriteLine("{0}",kelimeler[i]);
            }
        }
    }
}