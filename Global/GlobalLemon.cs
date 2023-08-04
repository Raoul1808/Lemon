using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Lemon.Global;

public class GlobalLemon : GlobalItem
{
    private const int LemonDeathMessageCount = 3;
    
    public override bool ConsumeItem(Item item, Player player)
    {
        switch (item.type)
        {
            case ItemID.Lemon:
                string deathMsg = Language.GetText("Mods.Lemon.GlobalLemon.LemonDeath" + (Random.Shared.Next(LemonDeathMessageCount) + 1)).WithFormatArgs(player.name).Value;
                player.KillMe(PlayerDeathReason.ByCustomReason(deathMsg), 727, 0);
                return true;
            
            default:
                return player.ConsumeItem(item.type);
        }
    }
}