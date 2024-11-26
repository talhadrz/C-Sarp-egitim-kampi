using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For döngüsü ile çarpım tablosu
            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {(i*j)} ");
            //    }
            //    Console.WriteLine();

            //}
            #endregion
            #region 0 ile kullanıcıdan alınan sayının arasındaki asal sayılar
            //bool asal = false;
            //Console.Write("Bir sayı Giriniz: ");
            //int sayı = int.Parse(Console.ReadLine());
            //Console.WriteLine($"*** 0 ile {sayı} arasındaki asal sayılar ***");
            //for (int i = 2; i <= sayı; i++) 
            //{
            //    for (int k = 2; k < i; k++)
            //    {
            //         asal = true;
            //        if(i%k == 0)
            //        {
            //            asal = false;
            //            break;
            //        }
            //    }
            //    if (asal)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region while ile tahmin oyunu
            //Random rnd = new Random();
            //int sayı = rnd.Next(1, 10);
            //int kullanıcı = 0;
            //Console.WriteLine("*** 1 ile 10 Arasından Sayı tahmin Oyunu ***");
            //while (sayı != kullanıcı)
            //{
            //    Console.Write("Tahmin: ");
            //    kullanıcı = int.Parse(Console.ReadLine());
            //    if (kullanıcı != sayı)
            //        Console.WriteLine("Yanlış tahmin :(");
            //    else
            //        Console.WriteLine("Doğru tahmin");
            //}
            #endregion
            #region while Dönggüsü İle matematik soruları
            //Random rnd = new Random();
            //int no1, no2, sonuc = 0, kullanıcı = 0;
            //Console.WriteLine("*** Matematik Soruları ***");
            //Console.WriteLine();
            //Console.Write("Hangi işlem sorusu sorulsun: ");
            //char simge = char.Parse(Console.ReadLine());
            //do
            //{
            //    no1 = rnd.Next(1, 50);
            //    no2 = rnd.Next(1, 50);
            //    switch (simge)
            //    {
            //        case '+':
            //            sonuc = no1 + no2;
            //            break;
            //        case '-':
            //            sonuc = no1 - no2;

            //            break;
            //        case '*':
            //            sonuc = no1 * no2;
            //            break;
            //        case '/':
            //            sonuc = no1 / no2;
            //            break;
            //        default:
            //            Console.WriteLine("İşlem simgesi ( + , - , * , / ) simgeleriyle eşleşmiyor ");
            //            break;
            //    }
            //    Console.Write($"{no1} {simge} {no2} Kaçtır: ");
            //    kullanıcı = int.Parse(Console.ReadLine());
            //    if (kullanıcı == sonuc)
            //        Console.WriteLine("Sonuç Doğru Tebrikler :)");
            //    else Console.WriteLine("Sonuç Yanlış :(");
            //} while (kullanıcı != sonuc);
            #endregion

        }
    }
}