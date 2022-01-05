using System;

namespace inheritance
{
   public class Canlilar
   {
       protected void Beslenme()
       {
           Console.WriteLine("Canlılar Beslenir.");
       }

       protected void Solunum()
       {
           Console.WriteLine("Canlılar Solunum Yapar.");
       }

       protected void Bosaltim()
       {
            Console.WriteLine("Bütün canlılar boşaltım yapar.");
       }
   } 
}