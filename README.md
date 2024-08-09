# Pratik-Abstraction

Bu proje, C# programlama dilinde soyutlama (abstraction) kavramını göstermek için tasarlanmış basit bir çalışan yönetim sistemi örneğidir. Farklı çalışan türlerini temsil eden sınıflar, ortak bir soyut sınıftan türetilmiştir.

## Proje Hakkında

Bu projede, bir şirketin farklı pozisyonlardaki çalışanlarını temsil eden bir sistem oluşturulmuştur. Sistem şu özellikleri içerir:

- Tüm çalışanlar için ortak özellikleri (ad, soyad, departman, pozisyon) içeren bir soyut `Calisan` sınıfı
- `Calisan` sınıfından türetilen `YazilimGelistirici`, `ProjeYoneticisi` ve `SatisTemsilcisi` sınıfları
- Her çalışan türü için özelleştirilmiş bir `Gorev()` metodu

## Nasıl Çalışır?

Proje, her çalışan türü için ayrı bir sınıf oluşturur ve bu sınıflar `Calisan` soyut sınıfından türetilir. Her sınıf, kendi pozisyonuna özgü bir `Gorev()` metodu uygular.

Ana program (`Main` metodu), farklı türde çalışanlar oluşturur ve her birinin `Gorev()` metodunu çağırarak çalışanın görevini ekrana yazdırır.

## Kullanım

1. Projeyi klonlayın veya indirin.
2. Visual Studio veya tercih ettiğiniz bir C# IDE'sinde projeyi açın.
3. Projeyi derleyin ve çalıştırın.

Çıktı, her çalışanın adını, soyadını, pozisyonunu ve görevini gösterecektir.

## Örnek Çıktı

```
Ali Yılmaz şirketin Yazılım Geliştirici'si. Yazılım Geliştirici olarak çalışıyorum.
Hasan Çıldırmış şirketin Proje Yöneticisi'si. Proje Yöneticisi olarak çalışıyorum.
Ayşe Kaya şirketin Satış Temsilcisi'si. Satış Temsilcisi olarak çalışıyorum.
```
