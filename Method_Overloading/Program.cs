namespace Method_Overloading;

class Program
{
    static void Main(string[] args)
    {
        //out parametreler
        string sayi = "999";
        //int outSayi;
        
        bool sonuc = int.TryParse(sayi, out int outSayi);
        if(sonuc)
        {
            Console.WriteLine("Başarili!");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Basarisiz!");
        }
        Methodlar instance = new Methodlar();
        instance.Topla(4, 5, out int toplamSonucu);
        Console.WriteLine(toplamSonucu);

        //Metot Asiri Yukleme - Overloading
        int ifade = 999;
        instance.EkranaYazdir(Convert.ToString(ifade));
        instance.EkranaYazdir(ifade);
        instance.EkranaYazdir("Hasan", "Özkale");
        
        //Method imzasi
        //MethodAdi + parametre sayisi + parametre
    }
}
class Methodlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }
}
