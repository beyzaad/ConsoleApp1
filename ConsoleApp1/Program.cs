//// See https://aka.ms/new-console-template for more information
//ELİMİZDE 1 DEN 10 A KADAR BİR SAYI LİSTESİ OLSUN 
//BU SAYI LİSTESİNDEN 2 TANE DAHA LİSTE ÇIKARARAK 
//TEK SAYILAR VE ÇİFT SAYILAR LİSTESİ OLUŞTURUP EKRANA BASTIRINIZ
List<int> sayilar = new List<int>();
for (int i = 1; i<=10;i++)
{
    sayilar.Add(i);
}
List<int> tek_sayilar = new List<int>();
List<int> cift_sayilar = new List<int>();
foreach (int sayı in sayilar)
{
    if ( sayı % 2== 0)
    {
        cift_sayilar.Add(sayı);
    }
    else
    {
        tek_sayilar.Add(sayı);
    }
}
Console.WriteLine("TEK SAYİLAR");
for(int i=0; i<tek_sayilar.Count;i++)
{
    Console.WriteLine(tek_sayilar[i]);
}
Console.WriteLine("ÇİFT SAYİLAR");
foreach(int sayi in cift_sayilar)
{
    Console.WriteLine(sayi);
}

//2.yöntem
Console.WriteLine("TEK SAYİLAR");
sayilar.FindAll(x => x % 2 != 1).ForEach(y => Console.WriteLine(y));
Console.WriteLine("ÇİFT SAYİLAR");
sayilar.FindAll(c => c % 2 != 0).ForEach(y => Console.WriteLine(y));
