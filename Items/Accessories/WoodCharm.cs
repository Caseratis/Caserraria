using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Accessories
{
    public class WoodCharm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forest Charm");
            Tooltip.SetDefault("Increased stats while on the surface");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 30;
            item.value = 10000;
            item.rare = 1;
            item.accessory = true;
            item.expert = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (player.ZoneOverworldHeight)
            {
                player.statDefense += 3;
                player.meleeDamage *= 1.05f;
                player.rangedDamage *= 1.05f;
                player.magicDamage *= 1.05f;
                player.minionDamage *= 1.05f;
                player.thrownDamage *= 1.05f;
                player.lifeRegen += 2;
                player.moveSpeed *= 1.2f;
            }
        }
    }
}
