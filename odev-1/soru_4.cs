using System;

namespace odev_1
{
    class soru4
    {
        public static void soru_4(string cumle)
        {
            int counter = 0;
            string karakterler = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ" + "abcçdefgğhiıjklmnoöprsştuüvyz";
            string[] array = cumle.Split(' ');
            Console.WriteLine("Kelime sayısı:{0}",array.Length);

            for(int i=0;i<cumle.Length;i++)
            {
                if(karakterler.Contains(cumle[i]))
                {
                    counter++;
                }
            }
            Console.WriteLine("Harf sayısı:{0}", counter);
        }
    }
}