baslangic:
Console.WriteLine("Merhabalar, 3 tane lokasyonumuz bulunmakta.");
Console.WriteLine("1-Bodrum ");
Console.WriteLine("2-Marmaris ");
Console.WriteLine("3-Çeşme");
int bodrumFiyat = 4000;
int marmarisFiyat = 3000;
int cesmeFiyat = 5000;
Console.WriteLine("Hangi lokasyonumuzu tercih etmek istersiniz?");

string lokasyon = Console.ReadLine().ToLower();

switch (lokasyon)
{
    case "bodrum":
        Console.WriteLine("Bodrum seçimi yapıldı.");
        break;

    case "marmaris":
        Console.WriteLine("Marmaris seçimi yapıldı.");
        break;

    case "çeşme":
        Console.WriteLine("Çeşme seçimi yapıldı.");
        break;

    default:
        Console.WriteLine("geçersiz giriş yaptınız.");
        goto baslangic;


}
Console.WriteLine("Tatilde kaç kişi olacaksınız?");

int kişi = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= kişi; i++) ;
{
    Console.WriteLine($" katılacak kişi sayısı {kişi}");

}

Console.WriteLine("Tatil sırasında yapılabilecek aktiviteler:");
if (lokasyon == "bodrum")
{
    Console.WriteLine("- Deniz, kum ve güneşin tadını çıkarabilirsiniz.");
    Console.WriteLine("- Tarihi Bodrum Kalesi'ni ziyaret edebilirsiniz.");
}
else if (lokasyon == "marmaris")
{
    Console.WriteLine("- Marmaris Kalesi ve çevresindeki tarihi bölgeleri gezebilirsiniz.");
    Console.WriteLine("- Tekne turlarına katılabilirsiniz.");
}
else if (lokasyon == "çeşme")
{
    Console.WriteLine("- Çeşme plajlarında denize girebilirsiniz.");
    Console.WriteLine("- Çeşme Kalesi ve Alaçatı'yı keşfedebilirsiniz.");
}
soru:
Console.WriteLine("Tatile hangi ulaşım şekliyle ulaşmak istersiniz?");
Console.WriteLine("1-Kara yolu");
Console.WriteLine("2-Hava yolu");
int cevap = Convert.ToInt32(Console.ReadLine());

switch (cevap)
{
    case 1:
        Console.WriteLine("Kara yolu tercihini yaptınız.");
        break;
    case 2:
        Console.WriteLine(" Hava yolu tercihini yaptınız.");
        break;
    default:
        Console.WriteLine("Geçersiz giriş yaptınız.");
        goto soru;
}

int toplamfiyat = 0;

if (lokasyon == "bodrum")
{
    toplamfiyat = bodrumFiyat * kişi;
    Console.WriteLine($"Bodrum için tatil planlıyorsunuz. Paket başlangıç fiyatı kişi başı {bodrumFiyat} TL'dir.");

}

else if (lokasyon == "marmaris")
{
    toplamfiyat = marmarisFiyat * kişi;
    Console.WriteLine($"Marmaris için tatil planlıyorsunuz. Paket başlangıç fiyatı kişi başı {marmarisFiyat} TL'dir.");
}

else if (lokasyon == "çeşme")
{
    toplamfiyat = cesmeFiyat * kişi;
    Console.WriteLine($"Çeşme için tatil planlıyorsunuz. Paket başlangıç fiyatı kişi başı {cesmeFiyat} TL'dir.");
}

Console.WriteLine($"Toplam tatil fiyatı: {toplamfiyat} TL.");

Console.WriteLine("Başka bir tatil seçimi yapmak ister misiniz? (evet/hayır)");
string cevap2 = Console.ReadLine().ToLower();
bool tekrarcevap2 = false;

if (cevap2 == "evet")
{
    tekrarcevap2 = true;
    goto baslangic;

}
else
{
    tekrarcevap2 = false;
}
Console.WriteLine("İyi günler dileriz.");
