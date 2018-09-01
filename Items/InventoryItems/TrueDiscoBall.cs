using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.InventoryItems
{
    public class TrueDiscoBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("True Disco Ball");
            Tooltip.SetDefault("Favorite to activate" + Environment.NewLine + "Makes you moon walk!" + Environment.NewLine + "*WARNING: May break some items*");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 30;
            item.value = 1;
            item.rare = 11;
        }

        public override void UpdateInventory(Player player)
        {
            if (item.favorited)
            {
                MyPlayer p = player.GetModPlayer<MyPlayer>();
                p.MoonWalk = true;
            }


        }

    }
}
