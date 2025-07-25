using MyMonkeyApp.Services;
using MyMonkeyApp.Helpers;

Console.Clear();
AsciiArtHelper.DisplayWelcomeArt();

var monkeyService = new MonkeyService();

while (true)
{
    ShowMainMenu();
    
    Console.Write("🐵 Seçiminizi yapın (1-9): ");
    var input = Console.ReadLine()?.Trim();
    
    Console.WriteLine();
    
    switch (input)
    {
        case "1":
            ListAllMonkeys();
            break;
            
        case "2":
            FindSpecificMonkey();
            break;
            
        case "3":
            GetRandomMonkey();
            break;
            
        case "4":
            ShowMonkeyFamilies();
            break;
            
        case "5":
            ShowEndangeredMonkeys();
            break;
            
        case "6":
            ShowMonkeyByIndex();
            break;
            
        case "7":
            ShowMonkeyCount();
            break;
            
        case "8":
            Console.Clear();
            AsciiArtHelper.DisplayWelcomeArt();
            break;
            
        case "9":
            AsciiArtHelper.DisplayGoodbyeArt();
            Console.WriteLine("🐵 Teşekkürler! Görüşmek üzere! 🐵");
            return;
            
        default:
            Console.WriteLine("❌ Geçersiz seçim! Lütfen 1-9 arası bir sayı girin.");
            AsciiArtHelper.DisplayRandomArt();
            break;
    }
    
    Console.WriteLine("\nDevam etmek için bir tuşa basın...");
    Console.ReadKey();
    Console.Clear();
}

void ShowMainMenu()
{
    Console.WriteLine("🎯 ANA MENÜ");
    Console.WriteLine("═══════════");
    Console.WriteLine("1️⃣  Tüm maymunları listele");
    Console.WriteLine("2️⃣  Belirli bir maymun ara");
    Console.WriteLine("3️⃣  Rastgele maymun getir");
    Console.WriteLine("4️⃣  Maymun ailelerini göster");
    Console.WriteLine("5️⃣  Nesli tükenmekte olan türler");
    Console.WriteLine("6️⃣  Index ile maymun getir");
    Console.WriteLine("7️⃣  Toplam maymun sayısı");
    Console.WriteLine("8️⃣  Ekranı temizle");
    Console.WriteLine("9️⃣  Çıkış");
    Console.WriteLine();
}

void ListAllMonkeys()
{
    Console.WriteLine("📋 TÜM MAYMUN TÜRLERİ");
    Console.WriteLine("═══════════════════");
    Console.WriteLine($"Toplam tür sayısı: {monkeyService.GetTotalCount()}");
    Console.WriteLine();
    monkeyService.DisplayMonkeys(monkeyService.GetAllMonkeys());
    AsciiArtHelper.DisplayRandomArt();
}

void FindSpecificMonkey()
{
    Console.WriteLine("🔍 MAYMUN ARAMA");
    Console.WriteLine("═══════════════");
    Console.WriteLine("Mevcut maymun isimleri:");
    
    var allMonkeys = monkeyService.GetAllMonkeys();
    for (int i = 0; i < allMonkeys.Count; i++)
    {
        Console.WriteLine($"   {i + 1,2}. {allMonkeys[i].Name}");
    }
    
    Console.WriteLine();
    Console.Write("🐒 Aramak istediğiniz maymunun adını girin: ");
    var monkeyName = Console.ReadLine()?.Trim();
    
    if (string.IsNullOrEmpty(monkeyName))
    {
        Console.WriteLine("❌ Geçerli bir isim girin!");
        return;
    }
    
    var foundMonkey = monkeyService.GetMonkeyByName(monkeyName);
    if (foundMonkey != null)
    {
        Console.WriteLine($"\n✅ '{monkeyName}' bulundu:");
        Console.WriteLine("═══════════════════════");
        monkeyService.DisplayMonkeyDetails(foundMonkey);
        AsciiArtHelper.DisplayRandomArt();
    }
    else
    {
        Console.WriteLine($"❌ '{monkeyName}' bulunamadı!");
        Console.WriteLine("💡 Yukarıdaki listeden bir isim seçin.");
        AsciiArtHelper.DisplayRandomArt();
    }
}

void GetRandomMonkey()
{
    Console.WriteLine("🎲 RASTGELE MAYMUN");
    Console.WriteLine("══════════════════");
    var randomMonkey = monkeyService.GetRandomMonkey();
    Console.WriteLine("Bugünün şanslı maymunu:");
    Console.WriteLine();
    monkeyService.DisplayMonkeyDetails(randomMonkey);
    AsciiArtHelper.DisplayRandomArt();
}

void ShowMonkeyFamilies()
{
    Console.WriteLine("🏛️ MAYMUN AİLELERİ");
    Console.WriteLine("═══════════════════");
    var families = monkeyService.GetUniqueFamilies();
    
    foreach (var family in families)
    {
        var familyMonkeys = monkeyService.GetMonkeysByFamily(family);
        Console.WriteLine($"\n📂 {family} ({familyMonkeys.Count} tür):");
        Console.WriteLine("─".PadRight(40, '─'));
        foreach (var monkey in familyMonkeys)
        {
            Console.WriteLine($"   • {monkey.Name}");
        }
    }
    AsciiArtHelper.DisplayRandomArt();
}

void ShowEndangeredMonkeys()
{
    Console.WriteLine("⚠️ NESLİ TÜKENMEKTE OLAN TÜRLER");
    Console.WriteLine("═══════════════════════════════");
    var endangeredMonkeys = monkeyService.GetEndangeredMonkeys();
    Console.WriteLine($"Tehlike altında {endangeredMonkeys.Count} tür bulundu:");
    Console.WriteLine();
    
    foreach (var monkey in endangeredMonkeys)
    {
        monkeyService.DisplayMonkeyDetails(monkey);
    }
    AsciiArtHelper.DisplayRandomArt();
}

void ShowMonkeyByIndex()
{
    Console.WriteLine("📋 INDEX İLE MAYMUN GETIR");
    Console.WriteLine("═════════════════════════");
    Console.WriteLine($"Geçerli index aralığı: 0-{monkeyService.GetTotalCount() - 1}");
    Console.WriteLine();
    
    Console.Write("🔢 Index numarası girin: ");
    var input = Console.ReadLine()?.Trim();
    
    if (int.TryParse(input, out int index))
    {
        var monkey = monkeyService.GetMonkeyByIndex(index);
        if (monkey != null)
        {
            Console.WriteLine($"\n✅ Index {index}'deki maymun:");
            Console.WriteLine("═══════════════════════════");
            monkeyService.DisplayMonkeyDetails(monkey);
            AsciiArtHelper.DisplayRandomArt();
        }
        else
        {
            Console.WriteLine($"❌ Geçersiz index! 0-{monkeyService.GetTotalCount() - 1} arası bir sayı girin.");
            AsciiArtHelper.DisplayRandomArt();
        }
    }
    else
    {
        Console.WriteLine("❌ Geçerli bir sayı girin!");
        AsciiArtHelper.DisplayRandomArt();
    }
}

void ShowMonkeyCount()
{
    Console.WriteLine("📊 MAYMUN SAYISI İSTATİSTİKLERİ");
    Console.WriteLine("═══════════════════════════════");
    Console.WriteLine($"🐒 Toplam maymun türü: {monkeyService.GetTotalCount()}");
    
    var families = monkeyService.GetUniqueFamilies();
    Console.WriteLine($"🏛️ Toplam aile sayısı: {families.Count}");
    
    var endangered = monkeyService.GetEndangeredMonkeys();
    Console.WriteLine($"⚠️ Tehlike altındaki türler: {endangered.Count}");
    
    Console.WriteLine("\n📈 Aile bazında dağılım:");
    foreach (var family in families)
    {
        var count = monkeyService.GetMonkeysByFamily(family).Count;
        Console.WriteLine($"   • {family}: {count} tür");
    }
    
    AsciiArtHelper.DisplayRandomArt();
}
