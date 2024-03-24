using Business.Concrete;
using Entities.Concrete;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Vatandas vatandas1 = new Vatandas();

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Engin";
        ogrenciler[1] = "Mehmet";
        ogrenciler[2] = "Asude";

        ogrenciler = new string[4];
        ogrenciler[3] = "Adem";


        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = { "ankara", "adıyaman", "Karaman" };
        string[] sehirler2 = { "Bursa", "Antalya", "diyarbakır" };
        //string[] sehirler3 = { "çankırı", "osmaniye", "antep" };
        sehirler2 = sehirler1;
        //sehirler1 = sehirler3;
        sehirler1[0] = "canakkale";
        //Console.WriteLine(sehirler1[0]);
        Console.WriteLine(sehirler2[0]);

        Console.WriteLine();
        foreach (string s in sehirler2)
        {
            Console.WriteLine(s);
        }

        List<string> yeniSehirler = new List<string> { "Ankara 1","İstanbul 1","izmir 1"};
        yeniSehirler.Add("Adana 1");

        foreach (string yenisehir in yeniSehirler)
        {
            Console.WriteLine(yenisehir);
        }
        int sonuc = Topla(5, 10);
        Console.WriteLine(sonuc);
        SelamVer("abuzer");
        SelamVer();
        Degiskenler();
        Person person1 = new Person ();
        person1.FirstName = "mehmet";
        person1.LastName = "meral";
        person1.NationalIdentity = 123;
        person1.DateOfBirthYear = 1998;
        PttManager pttmanager = new PttManager(new PersonManager());
        pttmanager.GİveMask(person1);
        Console.ReadLine();


    }
    static void SelamVer(string isim = "Memo")
    {
        Console.WriteLine("Merhaba " + isim);
    }
    static int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    private static void Degiskenler()
    {
        string mesaj = "Merhaba";
        double tutar = 100000; // dbden gelir
        int sayi = 110;
        bool girisYapmisMi = false;

        string ad = "Mehmet";
        string soyad = "Meral";
        int dogumYili = 1998;
        long tcNo = 12345678910;
    }

    public class Vatandas
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public int dogumYili { get; set; }
        public long tcNo { get; set; }
    }
}