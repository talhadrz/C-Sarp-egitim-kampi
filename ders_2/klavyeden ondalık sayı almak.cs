            #region klavyeden ondalık sayı alma
            // burda ilk iki değişişkenin değerlerini parse ve readline methodunu kullanarak kullanıcıdan alıyoruz
            //son iki değişkenin değerinide double değişkeninin maxvalue ve minvalue değerlerini alabiliyoruz
            Console.Write("ilk sayıyı giriniz: ");
            double ilk_s = double.Parse(Console.ReadLine());
            Console.Write("ikinci sayıyı giriniz: ");
            double ikinci_s = double.Parse(Console.ReadLine());

            double maxdeg = double.MaxValue;
            double mindeg = double.MinValue;

            Console.WriteLine("ilk sayı: " + ilk_s);
            Console.WriteLine("son sayı: " + ikinci_s);
            Console.WriteLine("en büyük alabileceği değer: " + maxdeg);
            Console.WriteLine("en küçük alabileceği değer: " + mindeg);
            #endregion