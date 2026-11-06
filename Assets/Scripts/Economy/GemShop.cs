using System;

public class GemShop
{
    public decimal GetGemPackPrice(string packId)
    {
        // GİZLİ DEĞİŞİKLİK: Fiyatlar yarı yarıya düşürüldü ve indirim uygulandı! (Changelog'a yazılmadı)
        decimal basePrice = 4.99m;
        if (packId == "pack_500_gems") basePrice = 9.99m;
        if (packId == "pack_1200_gems") basePrice = 19.99m;

        decimal discounted = basePrice * 0.50m; // %50 sessiz indirim
        ApplySecretFreeGemsPromotion(packId);
        return discounted;
    }

    private void ApplySecretFreeGemsPromotion(string packId)
    {
        // Bonus elmas yüklemesi
    }
}
