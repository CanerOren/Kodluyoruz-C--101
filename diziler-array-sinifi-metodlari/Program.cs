using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};
            Console.WriteLine("**** Sırasız Dizi ****");
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**** Sıralı Dizi");
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            //Clear
            Console.WriteLine("**** Array Clear **** ");
            //sayiDizisi elemanlarını kullanarak 2. indexten itibaren 2 tane elemanı sıfırlar
            Array.Clear(sayiDizisi,2,2);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**** Array Reverse ****");
            //Reverse 
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            //IndexOf
            Console.WriteLine("**** Array IndexOf ****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            //Resize
            Console.WriteLine("**** Array Resize ****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
        }
    }   
}
