# Banka Simülasyonu

C# ve Windows Forms ile geliştirilmiş, nesne yönelimli programlama (OOP) ilkelerini uygulayan bir masaüstü banka simülasyonu. Vadesiz, vadeli ve kredi hesapları açılabilir; bu hesaplar üzerinde para yatırma, çekme, faiz uygulama ve raporlama işlemleri yapılabilir.

## Özellikler

- Vadesiz, vadeli ve kredi hesabı açma
- Hesapları tablo üzerinde listeleme ve silme
- Para yatırma ve çekme
- Vadeli ve kredi hesaplarında faiz hesaplama ve uygulama
- Hesap bazında işlem geçmişi ve rapor görüntüleme
- Hatalı girişler ve yetersiz bakiye için doğrulama ve hata mesajları

Veriler bellekte tutulur, uygulama kapatıldığında kaydedilmez. Uygulama üç örnek hesapla açılır.

## Uygulanan OOP kavramları

| Kavram | Projedeki karşılığı |
| --- | --- |
| Soyutlama | `BankaHesabi` soyut sınıfı ve soyut üyeleri (`HesapTuru`, `CekimOnayı` vb.) |
| Kalıtım | `VadesizHesap`, `VadeliHesap` ve `KrediHesabi` sınıfları `BankaHesabi` sınıfından türer |
| Çok biçimlilik | Alt sınıflarda ezilen `RaporOlustur` ve çekim kuralları; hesapların tek bir `List<BankaHesabi>` içinde yönetilmesi |
| Kapsülleme | Özel alanlar ve doğrulama yapan özellikler (`Bakiye`, `HesapSahibi`, `FaizOranı`) |
| Arayüzler | `IRaporla` tüm hesaplarda, `IFaizHesapla` yalnızca faizli hesaplarda uygulanır |
| Şablon metot | `ParaYatir` ve `ParaCek` ortak akışı tanımlar, alt sınıflar kendi adımlarını doldurur |

## Proje yapısı

```
BankaSimulasyonu/
├── Interfaces/          IFaizHesapla, IRaporla
├── Models/              BankaHesabi, VadesizHesap, VadeliHesap, KrediHesabi
├── MainForm.cs          Hesap listesi ve ana işlemler
├── HesapAcForm.cs       Yeni hesap açma formu
├── IslemForm.cs         Para yatırma/çekme, faiz ve işlem geçmişi
└── Program.cs           Uygulamanın giriş noktası
```

## Çalıştırma

Gereksinimler: Windows, .NET Framework 4.7.2 ve "Masaüstü geliştirme (.NET)" iş yüküyle Visual Studio.

1. Depoyu klonlayın.
2. `BankaSimulasyonu.slnx` dosyasını Visual Studio ile açın.
3. `F5` ile derleyip çalıştırın.

## Teknolojiler

C#, .NET Framework 4.7.2, Windows Forms
