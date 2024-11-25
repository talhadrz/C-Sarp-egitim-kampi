
            #region Hello World

            // Yazı yazdırma sınıfı Console sınıfı yazı yazarken iki methoth var Write ve WriteLine 
            Console.Write("bu kod yazı yazdıktan sonra aynı satırda beklemesi için kullanılır.");
            Console.WriteLine("bu kod ise bunu yazdıktan sonra alt satıra geçer");
            // yazı yazdırma kodu ile bir çalışan bilgisi yazdıralım
            Console.WriteLine("************* Çalışan bilgileri *************");
            Console.WriteLine();
            Console.WriteLine("Ad: Talha");
            Console.WriteLine("Soyad: Durmaz");
            Console.WriteLine();
            Console.WriteLine("Ülke: Türkiye");
            Console.WriteLine("Şehir: Konya");
            Console.WriteLine();
            Console.WriteLine("Yaş: 19");
            Console.WriteLine("Tecrübe: 4");
            #endregion
            #region Değişkenler
            // Değişkenler uygulama çalışırken bazı türde bilgileri geçici olarak saklamaya yarar
            // Değişkenlerden en çok kullanılanları anlatalım

            // burda int kullanarak tam sayıları geçici olarak saklayabiliriz 
            int tam_sayi = 19;
            // double ile kesirli sayıları saklıyoruz
            double kesirli_sayi = 19.3;
            // string ile metin/cümle'leri tutabiliriz 
            string metinin = "Talha Durmaz";
            // char karakter tutar tek olan sayılar harfler ve sembollerin hepsini alır
            char karakter = 'T';
            // bool iki değer alır true ve false olarak olumlu ve olumsuz anlamına gelir.
            bool oldumu = true;

            int yas = 19;
            string ad_soyad = "Talha Durmaz";
            bool tecrube = false;

            Console.Write("Ad Soyad: ");
            Console.WriteLine(ad_soyad);
            Console.Write("Yaş: ");
            Console.WriteLine(yas);
            Console.WriteLine("Tecrübe: " + tecrube);
            #endregion

            Console.ReadLine();