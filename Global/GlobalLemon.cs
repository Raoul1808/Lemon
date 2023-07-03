using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Lemon.Global;

public class GlobalLemon : GlobalItem
{
    public override bool ConsumeItem(Item item, Player player)
    {
        switch (item.type)
        {
            case ItemID.Lemon:
                player.KillMe(PlayerDeathReason.ByCustomReason(player.name + " ate a lemon and died."), 727, 0);
                return true;
            
            default:
                return player.ConsumeItem(item.type);
        }
    }
}