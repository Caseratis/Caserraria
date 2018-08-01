using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.Accessories
{
    public class GoldenKnight : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Golden Knight");
            Tooltip.SetDefault("Provides life regeneration and greatly increased life regen when not moving" + Environment.NewLine + "Reduces the cooldown of healing potions");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 30;
            item.value = 10000;
            item.rare = 8;
            item.accessory = true;
            item.expert = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.shinyStone = true;
            player.lifeRegen += 10;
            player.pStone = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ShinyStone);
            recipe.AddIngredient(ItemID.CharmofMyths);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
