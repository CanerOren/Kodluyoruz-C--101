using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atama ve İşlemli Atama Operatörleri");
            //Atama Ve işlemli Atama
            int x = 3;
            int y = 3;
            y = y+2;
            
            Console.WriteLine(y);
            y+=2; 
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);
            Console.WriteLine("Mantıksal Operatörler");
            //Mantıksal Operatörler
            // ||,&&,!

            bool is_succes=true;
            bool is_completed = false;

            if(is_succes && is_completed)
            {
                Console.WriteLine("Perfect!");
            }
            if(is_succes || is_completed)
            {
                Console.WriteLine("Great!");
            }
            if(is_succes && !is_completed)
            {
                Console.WriteLine("Fine!");
            }

            Console.WriteLine("İlişkisel Operatörler");
            //İLİŞKİSEL OPERATÖRLER
            //<,>,<=,>=,==,!=
            int a=3;
            int b=4;
            bool sonuc=a<b;
            
            Console.WriteLine(sonuc);
            sonuc =a>b;
            Console.WriteLine(sonuc);
            sonuc=a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc= a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("Aritmetik  Operatörler");
            // /,*,+,-
            
            int sayi1 = 10;
            int sayi2=5;
            int sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1= sayi1++;
            Console.WriteLine(sonuc1);

            //% :mod almak için kullanılır.
            int sonuc2= 20%3;
            Console.WriteLine(sonuc2);

        }
    }
}
