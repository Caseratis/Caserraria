using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Accessories
{
    public class GraniteMedallion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Granite Medallion");
            Tooltip.SetDefault("While under 50% HP:" + Environment.NewLine + "+5 defense" + Environment.NewLine + "10% increased melee and throwing damage");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 30;
            item.value = 10000;
            item.rare = 3;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (player.statLife < player.statLifeMax / 2)
            {
                player.statDefense += 5;
                player.meleeDamage *= 1.1f;
                player.thrownDamage *= 1.1f;
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "GraniteCore", 1);
            recipe.AddIngredient(null, "AncientHeroMedallion", 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
