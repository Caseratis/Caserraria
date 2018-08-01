using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Accessories
{
    public class AncientHeroMedallion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Hero Medallion");
            Tooltip.SetDefault("10% increased melee and throwing damage if under 50% HP");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 30;
            item.value = 10000;
            item.rare = 1;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (player.statLife < player.statLifeMax / 2)
            {
                player.meleeDamage *= 1.1f;
                player.thrownDamage *= 1.1f;
            }
        }
    }
}
