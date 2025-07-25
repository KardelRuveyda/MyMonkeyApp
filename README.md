# 🐒 MyMonkeyApp - İnteraktif Maymun Türleri Uygulaması

Bu proje, çeşitli maymun türleri hakkında bilgi edinmek için geliştirilmiş interaktif bir konsol uygulamasıdır. C# ve .NET 9.0 kullanılarak geliştirilmiş olup, **Model Context Protocol (MCP)** server entegrasyonu ile desteklenmektedir.

> 🤖 **Bu proje GitHub Copilot Agent Mode kullanılarak geliştirilmiştir.** Yapay zeka destekli geliştirme sürecinin bir örneğidir.

## 🔗 MCP Server Entegrasyonu

Bu proje **MonkeyMCP** server ile entegre çalışacak şekilde tasarlanmıştır. MCP konfigürasyonu `.vscode/mcp.json` dosyasında tanımlanmıştır:

```json
{
    "inputs": [],
    "servers": {
        "monkeymcp": {
            "command": "docker",
            "args": [
                "run",
                "-i",
                "--rm",
                "jamesmontemagno/monkeymcp"
            ],
            "env": {}
        },
        "github": {
            "type": "http",
            "url": "https://api.githubcopilot.com/mcp/"
        }
    }
}
```

### 🐳 MonkeyMCP Docker Container
- **Container**: `jamesmontemagno/monkeymcp`
- **Amaç**: Maymun verilerini MCP protokolü üzerinden sağlama
- **Entegrasyon**: GitHub Copilot ile birlikte çalışma

## 🎯 Proje Özellikleri

### 📋 Temel Özellikler
- **20 farklı maymun türü** detaylı bilgileriyle
- **4 farklı maymun ailesi** kategorisinde sınıflandırma
- **İnteraktif menü sistemi** ile kolay navigasyon
- **Türkçe arayüz** ve kullanıcı dostu deneyim
- **Rastgele ASCII art** gösterimleri
- **Arama ve filtreleme** özellikleri

### 🐵 Maymun Aileleri
1. **Great Apes (Büyük Maymunlar)** - 4 tür
   - Chimpanzee, Bonobo, Orangutan, Gorilla
2. **Lesser Apes (Küçük Maymunlar)** - 1 tür
   - Gibbon
3. **Old World Monkeys (Eski Dünya Maymunları)** - 9 tür
   - Baboon, Macaque, Proboscis Monkey ve diğerleri
4. **New World Monkeys (Yeni Dünya Maymunları)** - 6 tür
   - Capuchin, Spider Monkey, Tamarin ve diğerleri

## 🎮 Menü Seçenekleri

| Seçenek | Açıklama |
|---------|----------|
| 1️⃣ | Tüm maymunları listele |
| 2️⃣ | Belirli bir maymun ara |
| 3️⃣ | Rastgele maymun getir |
| 4️⃣ | Maymun ailelerini göster |
| 5️⃣ | Nesli tükenmekte olan türler |
| 6️⃣ | Index ile maymun getir |
| 7️⃣ | Toplam maymun sayısı ve istatistikler |
| 8️⃣ | Ekranı temizle |
| 9️⃣ | Çıkış |

## 🏗️ Proje Yapısı

```
MyMonkeyApp/
├── .vscode/
│   └── mcp.json               # MCP server konfigürasyonu
├── Models/
│   └── Monkey.cs              # Maymun veri modeli
├── Services/
│   └── MonkeyService.cs       # İş mantığı ve veri yönetimi
├── Helpers/
│   └── AsciiArtHelper.cs      # ASCII art gösterimleri
├── Program.cs                 # Ana uygulama ve menü sistemi
├── MyMonkeyApp.csproj         # Proje dosyası
└── README.md                  # Bu dosya
```

### 📊 Monkey Model Özellikleri
```csharp
public class Monkey
{
    public string Name { get; set; }           // Maymun adı
    public string Family { get; set; }         // Aile kategorisi
    public string Habitat { get; set; }        // Doğal yaşam alanı
    public string Region { get; set; }         // Coğrafi bölge
    public string Status { get; set; }         // Koruma durumu
    public int AverageLifespan { get; set; }   // Ortalama yaşam süresi
    public string Diet { get; set; }           // Beslenme türü
}
```

## 🚀 Kullanım

### Gereksinimler
- .NET 9.0 SDK
- Windows/Linux/macOS
- **Docker** (MonkeyMCP server için)
- **VS Code** (MCP entegrasyonu için önerilen)
- **GitHub Copilot** (MCP özelliklerini kullanmak için)

### Çalıştırma
```bash
# Projeyi klonlayın
git clone https://github.com/KardelRuveyda/MyMonkeyApp.git

# Proje dizinine gidin
cd MyMonkeyApp

# Docker'ın çalıştığından emin olun
docker --version

# MCP server'ı test edin (opsiyonel)
docker run -i --rm jamesmontemagno/monkeymcp

# Uygulamayı çalıştırın
dotnet run
```

## 🎨 Özellik Detayları

### 🔍 Arama Özellikleri
- **İsme göre arama**: Maymun adıyla doğrudan arama
- **Aile bazında filtreleme**: Belirli bir aileye ait maymunları listeleme
- **Index ile erişim**: 0-19 arası index numarası ile maymun getirme
- **Rastgele seçim**: Günün maymunu özelliği

### ⚠️ Koruma Durumu Takibi
- **Stable**: Kararlı populasyon
- **Vulnerable**: Hassas durum
- **Endangered**: Tehlike altında
- **Critically Endangered**: Kritik tehlike

### 📈 İstatistik Özellikleri
- Toplam tür sayısı
- Aile bazında dağılım
- Tehlike altındaki türlerin sayısı
- Detaylı demografik bilgiler

## 🎭 ASCII Art Galerisi

Uygulama, her etkileşimden sonra rastgele ASCII art gösterimleri sunar:
- Hoş geldin sanatı
- Rastgele maymun karakterleri
- Veda sanatı
- Eğlenceli maymun figürleri

## 💡 Teknik Detaylar

### Kullanılan Teknolojiler
- **C# 11**: Ana programlama dili
- **.NET 9.0**: Framework
- **LINQ**: Veri sorgulama
- **Console Application**: Uygulama türü
- **MCP (Model Context Protocol)**: Server entegrasyonu
- **Docker**: MonkeyMCP container desteği
- **GitHub Copilot Agent Mode**: AI destekli geliştirme

### MCP Server Özellikleri
- **MonkeyMCP Container**: Docker üzerinde çalışan maymun veri servisi
- **GitHub Copilot Entegrasyonu**: MCP protokolü ile AI destekli geliştirme
- **VS Code Konfigürasyonu**: `.vscode/mcp.json` ile otomatik bağlantı

### 🤖 AI Destekli Geliştirme
Bu proje **GitHub Copilot Agent Mode** kullanılarak geliştirilmiştir:
- **Otomatik kod üretimi**: AI destekli kod yazımı
- **MCP entegrasyonu**: Model Context Protocol ile gelişmiş AI önerileri
- **İnteraktif geliştirme**: Agent mode ile gerçek zamanlı kod iyileştirmeleri
- **Kod kalitesi**: AI destekli best practices uygulaması

### Tasarım Desenleri
- **Service Pattern**: İş mantığı yönetimi
- **Helper Pattern**: Yardımcı fonksiyonlar
- **Model Pattern**: Veri yapısı

### Kod Özellikleri
- **Nullable Reference Types**: Null güvenliği
- **String Interpolation**: Modern string formatting
- **Pattern Matching**: Switch expressions
- **Local Functions**: İç fonksiyonlar

## 🌟 Gelecek Geliştirmeler

### 🔄 MCP Entegrasyonu
- [ ] MonkeyMCP server'dan canlı veri çekme
- [ ] MCP protokolü üzerinden maymun verilerini güncelleme
- [ ] GitHub Copilot ile gelişmiş AI önerileri

### 📊 Veri Yönetimi
- [ ] JSON dosyasından veri okuma
- [ ] Maymun fotoğrafları ekleme
- [ ] Web API entegrasyonu
- [ ] Veritabanı desteği

### 🌐 Kullanıcı Deneyimi
- [ ] Çoklu dil desteği
- [ ] Export/Import özellikleri
- [ ] Web arayüzü geliştirme

## 📄 Lisans

Bu proje MIT lisansı altında lisanslanmıştır.

## 🤝 Katkıda Bulunma

1. Bu repository'yi fork edin
2. Feature branch oluşturun (`git checkout -b feature/AmazingFeature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some AmazingFeature'`)
4. Branch'inizi push edin (`git push origin feature/AmazingFeature`)
5. Pull Request açın

## 👨‍💻 Geliştirici

**Kardel Ruveyda** - [GitHub](https://github.com/KardelRuveyda)

## 🙏 Teşekkürler

Bu projeyi geliştirirken aşağıdaki kaynaklara teşekkürler:
- **GitHub Copilot Agent Mode** - AI destekli geliştirme deneyimi için
- **James Montemagno** - MonkeyMCP Docker container'ı için
- **Model Context Protocol (MCP)** topluluğu
- Maymun türleri hakkında bilgi sağlayan bilimsel kaynaklar
- Açık kaynak topluluğu ve katkıda bulunanlar

---

*🤖 "GitHub Copilot Agent Mode ile geliştirilen, maymunlar hakkında bilgi edinmenin en eğlenceli yolu!" 🐒*
