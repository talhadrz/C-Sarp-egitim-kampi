// Değişken nedir
// Değişken geçici olarak veri tutan elemanlara denir
//değişken kullanırtken üç bölüm olur 1. değişken türü,2. bir isim yazmalıyız,3. değerini gireriz

//1. değişken türleri ve kullanma amaçları 
// int tam sayıları tutar
// string metin,cümle tutar
// char tek karakter tutar
// double kesirli sayıları tutar
// bool olumlu olumsuz değerleri tutar
//daha fazla tür var ama ilk aşamada bunlar yeter diğerlerinde zaten fazla değişiklik olmuyor.

//2. değişkene özel isim kuralları
// rakam kullanılmaz 
// boşluk konulmaz
// özel semboller kullanılmaz
// sadece harfler ve _ kullanılabilir 
// ama türkçe harflerini kullanmak bazen hata verebilir ondan dolayı türkçe harflerindende kaçınsanız daha iyi olur

// 3. değer girerkende dikkatli olmamız gereken bazı durumlar var
// metinsel bir değer verecekseniz mutlaka "(çivt tırnak) içine yazmalısınız
// karakter atamak içinde '(tek tırnak) içinde yazılır
// sayı atarken sade bir şekilde yazabilirsiniz

// Örnek
string ad = "Talha";
string soyad = "Durmaz";
int yas = 19;
bool okuyor = false;
char kan_gurubu = 'A';

Console.WriteLine("Ad Soyad: " + ad + " " + soyad + " Yaşı: " + yas + " okul durumu: " + okuyor + " Kan gurubu: " + kan_gurubu);
// çıktı
// "Ad Soyad: Talha Durmaz Yaşı 19 okul durumu: false Kan gurubu: A"
// yazacaktır


