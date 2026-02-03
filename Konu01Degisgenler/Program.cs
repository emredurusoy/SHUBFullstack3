// See https://aka.ms/new-console-template for more information
using System.Buffers.Text;
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");
Console.WriteLine();
Console.WriteLine("Merhaba, dünya");

// Console.Read() // Enter Basılmasını bekler 1 karakter için
// Console.ReadLine() // Enter tuşuna basılmasını bekler 

// Değişkenler 
// Tam Sayı Veri Tipleri 
byte plaka_kodu; // 0 - 255 arası değer alır, 1 byte
plaka_kodu = 34;
Console.WriteLine(plaka_kodu);

// Değişkenler tiplerine göre bellekte stack ve heap denilen 2 ayrı bölümde saklanır. Değer tipli değişkenler stack alanında saklanırken referans tipli değişkenler heap bölümünde saklanır.
// GC-çöp toplayıcı sistemi

byte birSayi, birSayiDaha;
birSayi = 5;
birSayiDaha = 10;
Console.WriteLine(birSayi);
Console.WriteLine(birSayiDaha);

// Tam sayılar
sbyte sbyteDeger = -100;
byte byteDeger = 200;
short shortDeger = -30000;
ushort ushortDeger = 60000;
int intDeger = 100000;
uint uintDeger = 300000;
long longDeger = 9000000000;
ulong ulongDeger = 18000000000;

// Kesirli Sayı Değişken Tipleri
float kesirliSayi = 4.5f; // 4byte yer kaplar 6-7 basamak
double kesirlisayi = 4.5; // 8byte yer kaplar 15-16 basamak

// Decimal Veri Tipi
decimal UrunFiyati = 9999; //12byte, duyarlı basamak 28 - 29

// Char veri tipi 

char karakter = 'a'; // klacyeden girilen her bir karakter için kullanılanilir sadece 1 değer alınabilir 

// String Veri tipi

string degisken; // klavyeden girilecek karakterlerden oluşan yapı 

string degisken1, degisken2;
string metin = "string veri tipinde tüm karakterli kullanabiliyotuz";
Console.WriteLine(metin);

// Boolen Veri tipi 
bool islemSonuc = false; // true da yazılabilir doğru yablış 

byte? kilo = null; // eğer bir değişkene başlangi. değeri olarak null vermek isrersek veri tipine ? koyarız 
kilo = 66;

// bir ürünün satışra olup olmadığı bilgsi tutacak değişken 
bool? isSatistami = null;
isSatistami = true;

// var ile degisgen oluşturma

var birdegisgen = "19"; // var ile oluşturulan 
var birsayi = 16;
var birmetin = "var atıyorsak eğer bir değer girilmesi zorunludur";
var sonuc = false;

Console.WriteLine(birdegisgen.GetType()); // ctr + d çoğaltır 
Console.WriteLine(birsayi.GetType());
Console.WriteLine(birmetin.GetType());
Console.WriteLine(sonuc.GetType());

sonuc = true;
// sonuc = 1; var ile tanımlanan bir değişkenin sonradan değiştirilmez, ancak içindeki değer değişir 



Console.WriteLine("Object Veri Tipi");
Console.WriteLine();

object nesne = "bu bir nesnedir"; // bu değişken türüne ger türden atanabilir 

Console.WriteLine(nesne);
Console.WriteLine(nesne.GetType());
nesne = 10; // object tanımlanan nesne değişkendir 
Console.WriteLine(nesne);
Console.WriteLine(nesne.GetType());

object a = 10; // tam sayı
object b = 'k'; // karakter
object c = "metin"; // string
object d = 12.9f; // float

// c# sabit tanımlama 

Console.WriteLine("C# sabit tanımlama");
const int kdvorani = 18; // sabitleri const olarak tanınpalıp program içerisnde kullanabilriz sabilterim değeri tanımladnığı terde verilir 
// kdvOrani = 20;

const int iskonto = 25;
Console.WriteLine("kdv orani: ");
Console.WriteLine(kdvorani);

//Ekrandan değer alma 

Console.WriteLine("ekrandan değer alma");
var deger = Console.ReadLine();
Console.WriteLine("Girdiğiniz değeri");
Console.WriteLine(deger);






