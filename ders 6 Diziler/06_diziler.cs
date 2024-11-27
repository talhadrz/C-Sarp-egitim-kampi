using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi örnekleri
            //string[] meslekler =  { "Şöför","Ressam","Yazar","Geliştirici","Doktor","Hakim" };// Toplu veri girişi
            //int[] yaslar = new int[10];
            //yaslar[0] = 19;
            //yaslar[1] = 23; // Tek tek veri girişi

            #endregion
            #region diziye kullanıcıdan 10 değer alıp ortalama hesaplama
            //double[] sınav_not = new double[10];//10 tane değer alabileceğini ayarladım
            //double toplam = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"{i + 1}. Sınav Notu: ");
            //    sınav_not[i] = double.Parse(Console.ReadLine());
            //}// Burda kullanıcıdan 10 tane sınav notu alacak
            //for (int i = 0; i < 10; i++)
            //{
            //    toplam += sınav_not[i];
            //}//burda tüm notları toplam değişkeni üzerine topladı
            //Console.WriteLine("Sınav ortalaması: "+(toplam/10));//burda toplamı 10a bölüp sınav ortalamasını hesaplıyor
            #endregion
            #region Dizi Metotlar
            //int[] rakamlar = {1, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int toplam = rakamlar.Sum();//dizi toplama metodu
            //Console.WriteLine("Toplam Rakamlar: "+toplam);
            //int dizi_hane = rakamlar.Length;//dizinin içinde kaç veri olduğunu bulan metot
            //Console.WriteLine(dizi_hane+" Tane rakam var.");
            //rakamlar.SetValue(0, 0);//istenen merkeze veri atamak
            //double ortalama = rakamlar.Average();//rakamların ortalamasını ortalama değişkenine atama metodu
            //string rakam_ortalamasi = rakamlar.Average().ToString();//değeri string türüne çevirme metodu
            //Console.WriteLine(rakamlar.Max());//dizideki en büyük rakamı bulma
            //Console.WriteLine(rakamlar.Min());//dizideki en küçük rakamı bulma metodu

            #endregion
            #region kullanıcıdan 10 sayı alıp en küçük ve en büyük sayıları yazdırma
            //int max, min;
            //int[] sayılar = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write($"{i+1}. Sayıyı Giriniz: ");
            //    sayılar[i] = int.Parse(Console.ReadLine());
            //}
            //(max, min) = (sayılar[0], sayılar[0]);
            //for (int i = 1; i < 10; i++)
            //{
            //    if (max < sayılar[i])
            //        max = sayılar[i];
            //    if (min > sayılar[i])
            //        min = sayılar[i];
            //}
            //Console.WriteLine("Büyü sayı: " + max);
            //Console.WriteLine("küçük sayı: " + min);
            #endregion
        }
    }
}
