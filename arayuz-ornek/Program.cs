using System;

namespace arayuz_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
           Focus focus = new Focus();
           Console.WriteLine(focus.HangiMarkaninAraci().ToString());
          Console.WriteLine(focus.KacTekerlektenOlusur());
           Console.WriteLine(focus.StandartRengiNe().ToString());

            NewFocus focus1= new NewFocus();
            Console.WriteLine(focus1.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus1.KacTekerlektenOlusur());
            Console.WriteLine(focus1.StandartRengiNe().ToString());
           
        }
    }
}
