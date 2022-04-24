using System;

namespace odev_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Kaçıncı Soru :");

            n=int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Kaç tane sayı girilecek:");
                    int a=int.Parse(Console.ReadLine());
                    soru1.soru_1(a);
                    break;
                case 2:
                        Console.WriteLine("n:");
                        int b=int.Parse(Console.ReadLine());
                        Console.WriteLine("m:");
                        int c = int.Parse(Console.ReadLine());
                        soru2.soru_2(b,c);
                break;

                case 3:
                        Console.WriteLine("Kelime sayısı:");
                        int d=int.Parse(Console.ReadLine());
                        soru3.soru_3(d);
                        break;
                case 4:
                        Console.WriteLine("Cümle:");
                        string cümle =Console.ReadLine();
                        soru4.soru_4(cümle);
                break;

                default:

                break;
            }
        }

    }
}