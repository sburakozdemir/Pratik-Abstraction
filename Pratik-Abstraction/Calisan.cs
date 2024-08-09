using System;

namespace Pratik_Abstraction
{
    // Tüm çalışanlar için soyut temel sınıf
    internal abstract class Calisan
    {
        // Tüm çalışanlar için ortak özellikler
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }
        public string Pozisyon { get; set; }

        // Ortak özellikleri başlatmak için kurucu metot
        protected Calisan(string ad, string soyad, string departman, string pozisyon)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
            Pozisyon = pozisyon;
        }

        // Türetilmiş sınıflar tarafından uygulanacak soyut metot
        public abstract void Gorev();
    }

    // Yazılım Geliştirici için türetilmiş sınıf
    class YazilimGelistirici : Calisan
    {
        // Belirli pozisyonla temel sınıfın kurucusunu çağıran kurucu metot
        public YazilimGelistirici(string ad, string soyad, string departman)
            : base(ad, soyad, departman, "Yazılım Geliştirici") { }

        // Yazılım Geliştirici için Gorev metodunun uygulaması
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} şirketin {Pozisyon}'siyim.");
        }
    }

    // Proje Yöneticisi için türetilmiş sınıf
    class ProjeYoneticisi : Calisan
    {
        // Belirli pozisyonla temel sınıfın kurucusunu çağıran kurucu metot
        public ProjeYoneticisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman, "Proje Yöneticisi") { }

        // Proje Yöneticisi için Gorev metodunun uygulaması
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} şirketin {Pozisyon}'siyim.");
        }
    }

    // Satış Temsilcisi için türetilmiş sınıf
    class SatisTemsilcisi : Calisan
    {
        // Belirli pozisyonla temel sınıfın kurucusunu çağıran kurucu metot
        public SatisTemsilcisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman, "Satış Temsilcisi") { }

        // Satış Temsilcisi için Gorev metodunun uygulaması
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} şirketin {Pozisyon}'siyim.");
        }
    }

}