// object tipini gördükten sonra ikinci önemli keyword var keyword

// var keyword, tüm değişken tiplerinin yerine geçen bir keyword'dür.

// ilk olarak object'inde öyle olduğunu düşündük ama boxing ve unboxing konusunu işledikten sonra öyle olmadığı gördük.

// 

var a = 10;
var b = "merhaba";
var c = true;
var d = 'a';


var sayi1=10;
var sayi2=20;

Console.WriteLine(sayi1+sayi2);

// objecten farklı olarak var tipi ile tanımlanan iki tane int toplanabildi.

var degisken =10;
int degiskenInt = 10;

// yukarıdaki tanımlamalar her ne kadar farklı olasada,

// aslında CIl tarafında hiç bir fark yok, var keyword'ü sadece kodu hızlı yazabilmek için çıkartılmış bir yapıdır
// var keyword'ü tipsizdir. 

// Datetime üzsrinde var tanımını görelim

var datetime = new DateTime();

Console.WriteLine("Birinci sayıyı giriniz");
var birinciSayi =int.Parse(Console.ReadLine());

Console.WriteLine("İkinci sayıyı giriniz");
var ikinciSayi =int.Parse(Console.ReadLine());
Console.WriteLine(birinciSayi+ikinciSayi);