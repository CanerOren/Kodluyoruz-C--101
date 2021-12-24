// See https://aka.ms/new-console-template for more information
using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int deger=2;
            // deger = 2; şeklinde de verilebilir
            string degisken = null; //şeklinde de verilebilir
            string Degisken = null; //küçük büyük duyarlı
            //int 3degisken =null; sayı degeri verilemez
            //string class =""; namespaceler kullanamaz
            //string degisken+veri=null; operatörler kullanılmaz
            */

            Console.WriteLine("");
            //String degisken = " ";
            byte b = 5; //1 byte ascii gibi sanırım 0<b<256
            sbyte c = 5; //1byte -128<c<128

            short s = 5; //2byte
            ushort us = 5; //2byte

            Int16 i16 = 2; //2 byte 
            int i = 2;  //4 byte 
            Int32 i32=2; //4 byte 
            Int64 i64 = 2; //8 byte

            uint ui= 2; //4 byte
            long l = 4; //8 byte
            ulong ul = 4; //8byte

            //Reel Sayılar
            float f = 5; //4 byte   
            double d = 5; //8 byte
            decimal de = 5; //16byte 

            char ch = '2'; //2 byte
            string str = "Caner"; //sınırsız

            bool b1 = true; 
            bool b2= false;

            DateTime dt = DateTime.Now; 
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;
            
            //string ifadeler
            //string str1 ="";
            //string str1 =null;
            string str1 = string.Empty;
            str1 = "Caner Ören";
            string ad = "Caner";
            string soyad = "Ören";
            string tamIsim = ad+ " " +soyad;

            //integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3= integer1*integer2;

            //boolean
            bool bool1 = 10>2;

            // Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;
            
            string yeni_deger = str20+ int20.ToString(); //int değeri str'e çevirme
            Console.WriteLine(yeni_deger);

            int int21 =  int20 + Convert.ToInt32(str20); //str değğeri int'e çevirme    
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20); //Çıktısı 40

            //datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);    
        }
    }
}

