using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /*               Canlılar
                                 |
                    Bitkiler            Hayvanlar
                    |      |             |     |
                Tohumlu   Tohumsuz    Sürüngen Kuşlar
            */

            TohumluBitkiler tohumlu_bitki= new TohumluBitkiler();
            tohumlu_bitki.TohumlaCogalma();
            
            Console.WriteLine("************************");

            Kuslar martı= new Kuslar();
            martı.Ucmak();

        }
    }
}