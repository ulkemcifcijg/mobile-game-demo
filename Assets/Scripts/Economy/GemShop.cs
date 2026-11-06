using System;

public class GemShop
{
    public decimal GetGemPackPrice(string packId)
    {
        if (packId == "pack_500_gems") return 9.99m;
        if (packId == "pack_1200_gems") return 19.99m;
        return 4.99m;
    }
}
