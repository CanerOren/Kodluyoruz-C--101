using System;

namespace inheritance
{
   public class Hayvanlar:Canlilar
   {
       protected void Adaptasyon()
       {
           Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
       }
   } 

   public class Surungenler:Hayvanlar
   {
       public Surungenler()
       {
           base.Adaptasyon();
           base.Beslenme();
           base.Bosaltim();
            base.Solunum();
       }
       public void SurunerekHareketEtmek()
       {
           Console.WriteLine("Sürüngenler Sürünerek Hareket Eder.");
       }
   }

   public class Kuslar:Hayvanlar
  {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
       public void Ucmak()
       {
           Console.WriteLine("Kuşlar uçar");
       }
   }

}