using System;

namespace Konsol_Programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi girin:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi Girin:");
            string surname = Console.ReadLine();            

            Console.WriteLine("Merhaba " + name + " " + surname);
        }
    }
}
