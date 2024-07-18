using System;
using System.Buffers;

namespace ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 10)
            {
                Console.WriteLine("Girilen sayı 10'dan büyüktür");
            }
            else if (sayi < 10)
            {
                Console.WriteLine("Girilen sayı 10'dan küçüktür");
            }
            else if (sayi == 10)
            {
                Console.WriteLine("Girilen sayı 10'a eşittir");
            }
            else
            {
                Console.WriteLine("Geçersiz giriş");
            }



            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girilen sayi cifttir.");
            }

            else { Console.WriteLine("Girilen sayi tektir"); }

           
        }
    }
}


