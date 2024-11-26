using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Değişkenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Klavyeden kaarkter girişleri
            //// burdada char değişkenini kullanarak kullanıcıdan ülkesinin isminin ilk harfini alıyoruz
            //Console.WriteLine("***** Ülkeler *****");
            //Console.WriteLine();
            //Console.WriteLine("Rusya Türkiye Çin Azerbeycan Filistin Hindistan");
            //Console.WriteLine();
            //Console.Write("Ülkenizin ilk harfini giriniz: ");
            //char ulke_h = char.Parse(Console.ReadLine());
            //// burda ise char değişkenini kullanarak kullanıcıdan meyve veya sebzenin isminin ilk harfini alıyoruz
            //Console.WriteLine("***** Meyveler ve Sebzeler *****");
            //Console.WriteLine();
            //Console.WriteLine("elma armut muz çilek pırasa nane biber");
            //Console.WriteLine();
            //Console.Write("almak istediğiniz meyve ve ya sebzenin ilk harfini giriniz: ");
            //char mey_seb = char.Parse(Console.ReadLine());
            #endregion
            #region klavyeden ondalık sayı alma
            //// burda ilk iki değişişkenin değerlerini parse ve readline methodunu kullanarak kullanıcıdan alıyoruz
            ////son iki değişkenin değerinide double değişkeninin maxvalue ve minvalue değerlerini alabiliyoruz
            //Console.Write("ilk sayıyı giriniz: ");
            //double ilk_s = double.Parse(Console.ReadLine());
            //Console.Write("ikinci sayıyı giriniz: ");
            //double ikinci_s = double.Parse(Console.ReadLine());

            //double maxdeg = double.MaxValue;
            //double mindeg = double.MinValue;

            //Console.WriteLine("ilk sayı: " + ilk_s);
            //Console.WriteLine("son sayı: " + ikinci_s);
            //Console.WriteLine("en büyük alabileceği değer: " + maxdeg);
            //Console.WriteLine("en küçük alabileceği değer: " + mindeg);
            #endregion
            #region klavyeden string veri giri girişi
            //// kullanıcıdan değer almak için ReadLine methodunu kullamıyoruz
            //// ve bu şekilde değer aldığımızda değer string olur
            //// bir çeviri methodu kullanılmasına gerek duyulmaz
            //Console.Write("Adınızı Girin: ");
            //string ad = Console.ReadLine();
            //Console.Write("Soy Adınızı Giriniz: ");
            //string soyad = Console.ReadLine();
            //Console.Write("Ülkenizi Girin: ");
            //string ulke = Console.ReadLine();
            //Console.Write("Şehrinizi Girin: ");
            //string sehir = Console.ReadLine();
            //Console.WriteLine("****** Kişi Bilgileri ******");
            //Console.WriteLine();
            //Console.WriteLine($"Ad Soyad: {ad} {soyad}");
            //Console.WriteLine($"Ülke/Şehir: {ulke}/{sehir}");

            #endregion
            #region klavyeden Tam sayı girişi
            //// burda string türünden farklı bir türe dönüştürürken parse methodunu kullanıyoruz 
            //int sayı_1, sayı_2, sayı_3, sayı_4, ortalama;

            //sayı_1 = int.Parse(Console.ReadLine());
            //Console.Write("1. sınavınızı giriniz: ");
            //sayı_2 = int.Parse(Console.ReadLine());
            //Console.Write("2. sınavınızı giriniz: ");
            //sayı_3 = int.Parse(Console.ReadLine());
            //Console.Write("3. sınavınızı giriniz: ");
            //sayı_4 = int.Parse(Console.ReadLine());
            //Console.Write("4. sınavınızı giriniz: ");

            //ortalama = (sayı_1 + sayı_2 + sayı_3 + sayı_4) / 4;
            //Console.WriteLine();
            //Console.WriteLine("Ortalamanız: " + ortalama);
            #endregion
            Console.ReadLine();
        }
    }
}
