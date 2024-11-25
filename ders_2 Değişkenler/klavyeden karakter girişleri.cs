            #region Klavyeden kaarkter girişleri
            // burdada char değişkenini kullanarak kullanıcıdan ülkesinin isminin ilk harfini alıyoruz
            Console.WriteLine("***** Ülkeler *****");
            Console.WriteLine();
            Console.WriteLine("Rusya Türkiye Çin Azerbeycan Filistin Hindistan");
            Console.WriteLine();
            Console.Write("Ülkenizin ilk harfini giriniz: ");
            char ulke_h = char.Parse(Console.ReadLine());
            // burda ise char değişkenini kullanarak kullanıcıdan meyve veya sebzenin isminin ilk harfini alıyoruz
            Console.WriteLine("***** Meyveler ve Sebzeler *****");
            Console.WriteLine();
            Console.WriteLine("elma armut muz çilek pırasa nane biber");
            Console.WriteLine();
            Console.Write("almak istediğiniz meyve ve ya sebzenin ilk harfini giriniz: ");
            char mey_seb = char.Parse(Console.ReadLine());
            #endregion