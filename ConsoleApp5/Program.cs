

using System;

namespace condprog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 10)
            {
                Console.WriteLine("Girilen sayı 10'dan büyüktür. ");
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Girilen sayı çifttir.");

                }
                else { Console.WriteLine("Girilen sayı tektir."); }


            }
            else if (sayi == 10)
            {
                Console.WriteLine("Girilen sayı 10'a eşittir. ");
                Console.WriteLine("Girilen sayı çifttir.");

            }
            else
            {

                Console.WriteLine("Girilen sayı 10'dan küçüktür. ");
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Girilen sayı çifttir.");

                }
                else { Console.WriteLine("Girilen sayı tektir."); }


            }
        }
    }
}







