// Farklı çalışan türlerinden örnekler oluştur
using Pratik_Abstraction;

YazilimGelistirici yazilimGelistirici = new YazilimGelistirici("Ali", "Yılmaz", "IT");
ProjeYoneticisi projeYoneticisi = new ProjeYoneticisi("Hasan", "Çıldırmış", "Yönetim");
SatisTemsilcisi satisTemsilcisi = new SatisTemsilcisi("Ayşe", "Kaya", "Satış");

// Her çalışan için Gorev metodunu çağır
yazilimGelistirici.Gorev();
projeYoneticisi.Gorev();
satisTemsilcisi.Gorev();