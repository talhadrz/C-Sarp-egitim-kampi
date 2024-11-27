using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metot_türleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metot
            //void alfabe()
            //{
            //    for (char harf = 'a'; harf <= 'z'; harf++)
            //    {
            //        Console.WriteLine(harf);
            //    }
            //}

            //void ALFABE()
            //{
            //    for (char harf = 'A'; harf <= 'Z'; harf++)
            //    {
            //        Console.WriteLine(harf);
            //    }
            //}

            //alfabe();
            //alfabe();
            //ALFABE();
            //// tek satırdan fazla olan kodları tekrar yazmamak için kullanılır
            #endregion
            #region geriye değer döndürmeyen string parametreli methot

            //void selamla(string ad = "talha", string soyad = "Durmaz")
            //{
            //    Console.WriteLine($"Selam {ad} {soyad} Nasılsınız ?");
            //}
            //selamla("Talha", "Durmaz");

            //void is_basvur(string ad, string soyad, string sirket_ad, string bolum)
            //{
            //    Console.WriteLine($"Sayın {sirket_ad} çalışanı ben {ad} {soyad} sizin iş düzeninizi çok iyi buluyorum sizin {bolum} bölümünüze kendimi uygun görüyorum saygılarımla arz ediyorum");
            //}
            //is_basvur("Talha", "Durmaz", "x", "y");
            #endregion
            #region geriye değer döndürmeyen int parametreli methot
            //void yas_hespla(int dogum_yıl = 2000,int simdiki_yıl=2024)
            //{
            //    int yas = simdiki_yıl - dogum_yıl;
            //    Console.WriteLine(yas+" Yaşındasınız.");
            //}
            //yas_hespla(1996);
            //void yuzde_hesap(int sayı,int yuze)
            //{
            //    sayı = sayı / 100;
            //    sayı = yuze * sayı;
            //    Console.WriteLine($"Sonuç; {sayı}");
            //}
            //yuzde_hesap(100,10);
            #endregion
            #region int geriye değer döndüren int parametreli methot
            //int ortalama(int s1, int s2, int s3, int s4)
            //{
            //    return (s1 + s2 + s3 + s4)/4;
            //}
            //Console.WriteLine(ortalama(85,45,95,55));
            //int buyuk_sayı(int[] sayılar)
            //{
            //    int buyuk_s = sayılar[0];
            //    for (int i = 1; i < sayılar.Length; i++)
            //    {
            //        if (buyuk_s < sayılar[i]) 
            //            buyuk_s = sayılar [i];
            //    }
            //    return buyuk_s;
            //}
            //Console.WriteLine(buyuk_sayı(new[] { 45, 45, 78, 53 }));
            #endregion
            #region string geriye değer döndüren string parametreli methot
            //string bas_harfi_buyut(string isim)
            //{
            //    string ısım = isim[0].ToString().ToUpper() + isim.Substring(1);
            //    return ısım;
            //}
            ////Console.WriteLine(bas_harfi_buyut("talha"));
            //string metin_sifrele(string metin)
            //{
            //    string sıfreli = "";
            //    for (int i = 0; i < metin.Length; i++)
            //    {
            //       sıfreli += Convert.ToChar(Convert.ToInt32(metin[i])*5);
            //    }

            //    return sıfreli;
            //}
            //string metin_sifre_coz(string metin)
            //{
            //    string sıfreli = "";
            //    for (int i = 0; i < metin.Length; i++)
            //    {
            //        sıfreli += Convert.ToChar(Convert.ToInt32(metin[i]) / 5);
            //    }

            //    return sıfreli;
            //}
            //Console.WriteLine(metin_sifre_coz(metin_sifrele("Talha Durmaz")));
            #endregion
            #region örnek uygulama
            //Console.Write("büyüklüğünü girin: ");
            //int buyukluk = int.Parse(Console.ReadLine());
            //void ucgen(int sayı)
            //{
            //    for (int i = 0; i < sayı; i++)
            //    {
            //        for (int k = sayı; k > i; k--)
            //        {
            //            Console.Write(" ");
            //        }
            //        for (int k = 1; k < i * 2; k++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //ucgen(buyukluk);
            //ucgen(15);
            //ucgen(10);

            #endregion

        }
    }
}