using System;

namespace inheritance
{
   public  class Canlilar
   {
       protected void Beslenme()
       {
           Console.WriteLine("Canlılar Beslenir.");
       }

       protected void Solunum()
       {
           Console.WriteLine("Canlılar Solunum Yapar.");
       }

       public void Bosaltim()
       {
            Console.WriteLine("Bütün canlılar boşaltım yapar.");
       }

        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
   } 
}