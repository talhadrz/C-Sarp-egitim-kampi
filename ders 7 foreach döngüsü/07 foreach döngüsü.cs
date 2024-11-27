using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach_Döngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //char[] karakterler = { 'A', 'B', 'C', 'D', 'E' };
            //foreach (char karakter in karakterler)
            //{
            //    Console.Write(karakter + " ");
            //}
            ////karakterleri tek tek karakter değişkenine atayıp işlem yapmaya yarar
            #endregion
            #region Örnek İsimdeki Karakter Sayısını Sayma ve harflerine parçalama
            //Console.Write("isminizi giriniz: ");
            //string isim = Console.ReadLine();
            //int karakter_sayısı = 0;
            //foreach (char harf in isim)
            //{
            //    Console.WriteLine(harf);
            //    karakter_sayısı++;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Toplam karakter Sayısı: "+karakter_sayısı);
            #endregion
            #region Örnek Sınav Sistemi
            //Console.WriteLine("****** Sınıf Ortalama Hesaplama ******");
            //Console.WriteLine("----------------------");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("Öğrenci sayısı: ");
            //int orenci_sayısı = int.Parse(Console.ReadLine());
            //Console.Write("Sınav sayısı: ");
            //int sınav_sayısı = int.Parse(Console.ReadLine());
            //Console.WriteLine("----------------------");
            //Console.WriteLine();
            //Console.WriteLine();
            //int[] ortalamalar = new int[orenci_sayısı];
            //int[,] sınav_notları = new int[orenci_sayısı , sınav_sayısı];
            //string[] isimler = new string[orenci_sayısı];
            //for (int i = 0; i < orenci_sayısı; i++)
            //{
            //    Console.Write((i + 1) + ".kişinin ismi: ");
            //    string isim = Console.ReadLine();
            //    isim = isim[0].ToString().ToUpper() + isim.Substring(1);
            //    isimler[i] = isim;
            //    Console.WriteLine();

            //    for (int k = 0; k < sınav_sayısı; k++)
            //    {
            //        Console.Write($"{isimler[i]} {k + 1}.Sınavı: ");
            //         sınav_notları[i,k] = int.Parse(Console.ReadLine());
            //        ortalamalar[i] += sınav_notları[i,k];
            //    }
            //    ortalamalar[i] /= sınav_sayısı;
            //    Console.WriteLine("----------------------");

            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //for (int k = 0; k < orenci_sayısı; k++)
            //{
            //    Console.Write(isimler[k] + " - ");
            //    for (int l = 0; l < sınav_sayısı; l++)
            //    {
            //        Console.Write(sınav_notları[k,l] + " - ");
            //    }
            //    Console.WriteLine("Ortalaması: " + ortalamalar[k]);
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}