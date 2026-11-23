
# Kişisel Portfolyo Uygulaması ve Yönetim Paneli

**C#**, **ASP.NET Core MVC**, **Entity Framework Core**, **Microsoft SQL Server** ve **Bootstrap 5** kullanılarak geliştirilmiş, içeriklerin panel üzerinden yönetilebildiği dinamik web uygulaması. Ziyaretçiye açık vitrin sayfası ile yönetici ekranları aynı veri modeli üzerinde çalışır.

## İçindekiler
- [Kullanılan Teknolojiler](#kullanılan-teknolojiler)
- [Kurulum Adımları](#kurulum-adımları)
- [Uygulama Özellikleri](#uygulama-özellikleri)
- [Klasör Yapısı](#klasör-yapısı)
- [Geliştirici Notları](#geliştirici-notları)

## Kullanılan Teknolojiler

| Katman | Araç ve Teknolojiler |
| --- | --- |
| Uygulama Çatısı | ASP.NET Core MVC, C# |
| Veri Erişimi | Entity Framework Core (Code First, Migrations), LINQ |
| Veritabanı | Microsoft SQL Server |
| Ön Yüz | Razor, ViewComponents, Bootstrap 5, Bootstrap Icons, JavaScript |
| Doğrulama ve Etkileşim | Data Annotations, ModelState doğrulama, Modal / bildirim bileşenleri |

## Kurulum Adımları

### Ön Koşullar
- .NET SDK ve ASP.NET Core çalışma ortamı
- Visual Studio veya uyumlu bir kod editörü
- Microsoft SQL Server örneği ve yönetim aracı

### Çalıştırma
1. Depoyu yerel makinenize klonlayın:
   ```bash
   git clone [https://github.com/hamiyetipek/MYAcademy_Portfolio.git](https://github.com/hamiyetipek/MYAcademy_Portfolio.git)

```

2. Veritabanı bağlantı bilgisini yapılandırma dosyasından veya `DbContext` ayarlarından kendi SQL Server örneğinize göre güncelleyin.
3. Paketleri geri yükleyin ve migration'ları uygulayarak veritabanını oluşturun:
```bash
dotnet restore
dotnet ef database update

```


4. Uygulamayı başlatın:
```bash
dotnet run

```



> Bağlantı dizesi ve hassas yapılandırma değerlerini kaynak kod içinde açık bırakmamaya dikkat edin.

## Uygulama Özellikleri

### Ziyaretçi Tarafı

* **Giriş ve Tanıtım:** Dinamik başlık, unvan geçişleri, kişisel bilgiler ve sosyal bağlantılar.
* **Akademik ve İş Geçmişi:** Eğitim ve deneyim kayıtlarının sıralı listelenmesi ve aktif kayıtların gösterimi.
* **Yetenek ve Proje Vitrinleri:** Yeteneklerin sunulması, kategori bazlı proje filtreleme ve uyumlu (`responsive`) yerleşim.
* **İletişim ve Özgeçmiş:** Doğrulamalı iletişim formu ile mesaj kaydı ve CV indirme erişimi.

### Yönetim Paneli

* **Genel Özet (Dashboard):** Proje, yetenek, eğitim, deneyim ve mesaj sayıları ile kategori dağılımı ve son kayıtlar.
* **CRUD Modülleri:** Hakkımda, eğitim, deneyim, yetenek, kategori ve proje kayıtları üzerinde ekleme, güncelleme, listeleme ve silme işlemleri.
* **Mesaj ve Dosya Yönetimi:** Gelen mesajların incelenmesi, okundu/okunmadı takibi, görsel yükleme ve CV güncelleme işlemleri.
### Ekran Görüntüleri
<img width="1886" height="895" alt="Ekran görüntüsü 2026-11-23 185933" src="https://github.com/user-attachments/assets/a671836e-0810-4ef9-b7c5-5a880fe54478" />
<img width="1917" height="906" alt="Ekran görüntüsü 2026-11-23 185841" src="https://github.com/user-attachments/assets/fbcf7bb4-58ae-4b85-a0a8-90c87cc52194" />
<img width="1895" height="906" alt="Ekran görüntüsü 2026-11-23 190041" src="https://github.com/user-attachments/assets/1b52e6ad-0778-4f32-89d3-cf36861ecbd3" />
<img width="1902" height="892" alt="Ekran görüntüsü 2026-11-23 190236" src="https://github.com/user-attachments/assets/d6353e16-481d-4f42-a97c-e7cddf0df37d" />
<img width="1916" height="917" alt="Ekran görüntüsü 2026-11-23 185852" src="https://github.com/user-attachments/assets/9320091f-efc3-4e6d-82b8-6b68cd45cbc7" />






## Klasör Yapısı

```text
MYAcademy_Portfolio/
├── Areas/Admin/
├── Controllers/
├── Context/
├── Entities/
├── Models/
├── ViewComponents/
├── Views/
├── wwwroot/
├── Migrations/
└── Program.cs

