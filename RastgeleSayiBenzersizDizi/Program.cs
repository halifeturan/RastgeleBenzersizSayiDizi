using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RastgeleSayiBenzersizDizi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı üretmek istiyorsunuz?:");
            int sayiadeti = int.Parse(Console.ReadLine());
            int[] sayilar = new int[sayiadeti];
            int sayikontrol;
            Random rndm = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rndm.Next(1, 100);
                for (sayikontrol = 0; sayikontrol < i; sayikontrol++)
                {
                    if (sayilar[sayikontrol] == sayilar[i]) //sayikontrol değişkeni ile i değişkeni aynıysa i değişkeni bir azaltılıp yeni bir sayı ataması yapılıyor
                    {
                        i--;
                    }
                }



            }
            Array.Sort(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"{sayilar[i]}");
            }
            Console.ReadKey();
        }
    }
}
