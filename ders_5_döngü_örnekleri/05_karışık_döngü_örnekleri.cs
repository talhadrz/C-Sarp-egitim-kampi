using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Dögüler_İle_Şekil_oluşturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüleri ile ardışık sayılar
            //int s1 = 9;
            //int s2 = 1;
            //int sayı;
            //bool sorgu = false;
            //for (int i = 1; i <= 5; i++)
            //{
            //    sayı = i;
            //    for (int k = 1; k <= 5; k++)
            //    {

            //        if (k == 1)
            //        {
            //            Console.Write(sayı);
            //        }
            //        else if (sorgu == false)
            //        {
            //            sayı += s1;
            //            Console.Write(sayı);
            //            sorgu = true;
            //        }
            //        else
            //        {
            //            sayı += s2;
            //            Console.Write(sayı);
            //            sorgu = false;
            //        }
            //        Console.Write(' ');
            //    }
            //    s1 -= 2;
            //    s2 += 2;
            //    Console.WriteLine();
            //}
            #endregion
            #region for döngüsü ile ikişer ardışık sayılar
            //int sayı = 0;
            //for (int i = 1; i < 6; i++)
            //{
            //    for (int k = 1; k < 6; k++)
            //    {
            //        sayı += 2;
            //        Console.Write(sayı + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region for döngüsü ile ardışık alfabe
            //int hrf = 65;
            //int artıs = 5;
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(Convert.ToChar(hrf) + " ");
            //        hrf += artıs;
            //    }
            //    hrf -= (artıs * 5);
            //    hrf++;
            //    Console.WriteLine();
            //}
            #endregion
            #region for döngüsü ile sayılı yatay üçken
            //int sayı = 0;
            //int sayı2 = 0;
            //for (int i = 1; i <= 4; i++)
            //{
            //    sayı += i;
            //    sayı2 = sayı;
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write(sayı + " ");
            //        sayı -= 1;
            //    }
            //    sayı = sayı2;
            //    Console.WriteLine();
            //}
            #endregion
            #region yıldız simgesi ile üçgen
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int k = 5; k > i; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k < i * 2; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region for döngüsü ile ters üçken
            //for (int i = 0; i < 8; i++) 
            //{
            //    for (int k = 0; k <= i; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 9; k > i*2; k--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}