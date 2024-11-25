 #region klavyeden string veri giri girişi
 // kullanıcıdan değer almak için ReadLine methodunu kullamıyoruz
 // ve bu şekilde değer aldığımızda değer string olur
 // bir çeviri methodu kullanılmasına gerek duyulmaz
 Console.Write("Adınızı Girin: ");
 string ad = Console.ReadLine();
 Console.Write("Soy Adınızı Giriniz: ");
 string soyad = Console.ReadLine();
 Console.Write("Ülkenizi Girin: ");
 string ulke = Console.ReadLine();
 Console.Write("Şehrinizi Girin: ");
 string sehir = Console.ReadLine();
 Console.WriteLine("****** Kişi Bilgileri ******");
 Console.WriteLine();
 Console.WriteLine($"Ad Soyad: {ad} {soyad}");
 Console.WriteLine($"Ülke/Şehir: {ulke}/{sehir}");

 #endregion