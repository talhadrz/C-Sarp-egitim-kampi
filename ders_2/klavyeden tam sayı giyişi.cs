  #region klavyeden Tam sayı girişi
  // burda string türünden farklı bir türe dönüştürürken parse methodunu kullanıyoruz 
  int sayı_1, sayı_2, sayı_3, sayı_4, ortalama;

  sayı_1 = int.Parse(Console.ReadLine());
  Console.Write("1. sınavınızı giriniz: ");
  sayı_2 = int.Parse(Console.ReadLine());
  Console.Write("2. sınavınızı giriniz: ");
  sayı_3 = int.Parse(Console.ReadLine());
  Console.Write("3. sınavınızı giriniz: ");
  sayı_4 = int.Parse(Console.ReadLine());
  Console.Write("4. sınavınızı giriniz: ");

  ortalama = (sayı_1 + sayı_2 + sayı_3 + sayı_4) / 4;
  Console.WriteLine();
  Console.WriteLine("Ortalamanız: " + ortalama);
  #endregion 