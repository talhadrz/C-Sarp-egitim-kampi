
            #region if else ile ortalama alma
            double sayı1, sayı2, sayı3, sayı4, ortalama;

            Console.WriteLine("****** Ortalama Hesaplama Uygulaması ******");
            Console.WriteLine();

            Console.Write("1. sınavınızı giriniz: ");
            sayı1 = double.Parse(Console.ReadLine());

            Console.Write("2. sınavınızı giriniz: ");
            sayı2 = double.Parse(Console.ReadLine());

            Console.Write("3. sınavınızı giriniz: ");
            sayı3 = double.Parse(Console.ReadLine());

            Console.Write("4. sınavınızı giriniz: ");
            sayı4 = double.Parse(Console.ReadLine());

            Console.WriteLine("********** Sonuçlar **********");
            Console.WriteLine();


            ortalama = (sayı1 + sayı2 + sayı3 + sayı4) / 4;
            Console.WriteLine("Ortalama: " + ortalama);
            if (ortalama < 50)
            {
                Console.WriteLine("sonuç: kaldı ");
            }
            else
            {
                Console.WriteLine("sonuç: geçti ");
            }

            #endregion
            #region if else ile tek çift sayı ayırma mod işlemi
            int sayı;

            Console.WriteLine("**** Tek Çift ayırma ****");
            Console.WriteLine();

            Console.Write("Sayı giriniz: ");
            sayı = int.Parse(Console.ReadLine());

            if (sayı % 2 == 0)
            {
                Console.WriteLine("girdiğiniz sayı çift.");
            }
            else
            {
                Console.WriteLine("girdiğiniz sayı tek.");
            }

            #endregion
            #region char ile if else
            char ad, soyad;

            Console.Write("isminizin ilk harfini giriniz: ");
            ad = char.Parse(Console.ReadLine());

            Console.Write("soy isminizin ilk harfini giriniz: ");
            soyad = char.Parse(Console.ReadLine());

            if (ad == 'T' & soyad == 'D')
            {
                Console.WriteLine("Doğru ad soyad girişi yaptınız tebrikler.");
            }
            else if (ad == 'T' ^ soyad == 'D')
            {
                Console.WriteLine("ad yada soyadınızda bir hata var!");
            }
            else
            {
                Console.WriteLine("iki isimde yanlış!!!");
            }

            #endregion
            #region örnek proje
            int ay;
            Console.WriteLine("**** Ay hesaplama ****");
            Console.WriteLine();

            Console.Write("kaçıncı aydasınız: ");
            ay = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (ay == 1)
                Console.WriteLine("  Ocak Ayı  ");
            else if (ay == 2)
                Console.WriteLine("  Şubat Ayı  ");
            else if (ay == 3)
                Console.WriteLine("  Mart Ayı  ");
            else if (ay == 4)
                Console.WriteLine("  Nisan Ayı  ");
            else if (ay == 5)
                Console.WriteLine("  Mayıs Ayı  ");
            else if (ay == 6)
                Console.WriteLine("  Haziran Ayı  ");
            else if (ay == 7)
                Console.WriteLine("  Temmuz Ayı  ");
            else if (ay == 8)
                Console.WriteLine("  Ağustos Ayı  ");
            else if (ay == 9)
                Console.WriteLine("  Eylül Ayı  ");
            else if (ay == 10)
                Console.WriteLine("  Ekim Ayı  ");
            else if (ay == 11)
                Console.WriteLine("  Kasım Ayı  ");
            else if (ay == 12)
                Console.WriteLine("  Kasım Ayı  ");

            #endregion
            #region switch case ile öğrenci sorgu
            int no;
            Console.Write("Öğrenci No: ");
            no = int.Parse(Console.ReadLine());

            switch (no)
            {
                case 1:
                    Console.WriteLine("Hoşgeldin ali");
                    break;
                case 2:
                    Console.WriteLine("Hoşgeldin kasım");
                    break;
                case 3:
                    Console.WriteLine("Hoşgeldin turhan");
                    break;
                case 4:
                    Console.WriteLine("Hoşgeldin fidan");
                    break;
                case 5:
                    Console.WriteLine("Hoşgeldin fatih");
                    break;
                default:
                    Console.WriteLine("bu numaralı bir öğrencimiz yoktur!");
                    break;
            }
            #endregion
            #region switch case örnek proje
            int rakam;
            Console.WriteLine("*** Hafta Hesaplamak ***");
            Console.WriteLine();
            Console.Write("Haftanın Kaçıncı Günündesiniz: ");
            rakam = int.Parse(Console.ReadLine());

            switch (rakam)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("yanlış rakam tuşlanmış!!");
                    break;
            }
            #endregion
            Console.ReadLine();
        