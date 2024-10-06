//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
int sayac = 0;
while (sayac < 11)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    sayac++;
}

//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
int sayi = 1;
while(sayi < 21)
{
    Console.WriteLine(sayi);
    sayi++;
}

// 3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
int cift = 1;
while (cift <21)
{
    if (cift %2 ==0)
        Console.WriteLine(cift);
    cift++;
}

//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int a = 1;
int toplam = 0;
while (a < 151)
{
    toplam += a;
    a++;

}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);

//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
int sayi2 = 1;
int cifttoplam = 0;
int tektoplam = 0;

while (sayi2 < 121)
{
    if (sayi2 % 2 == 0) //Çift sayıların toplanması için.
    {
        cifttoplam += sayi2;
        sayi2++;
    }
    else //Tek sayıların toplanması için.
    {      
        tektoplam += sayi2;
        sayi2++;      
    }
}
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamları: " + cifttoplam);
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamları: " + tektoplam);




