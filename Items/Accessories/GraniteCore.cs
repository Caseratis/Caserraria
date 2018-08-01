using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Accessories
{
	public class GraniteCore : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Core");
            Tooltip.SetDefault("+5 defense if under 50% HP");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.value = 10000;
            item.rare = 1;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (player.statLife < player.statLifeMax/2)
            {
                player.statDefense += 5;
            }
        }
    }
}
