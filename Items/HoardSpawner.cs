
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items
{
    public class HoardSpawner : ModItem
    {
        int hoardTimer;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hoard Spawner");
            Tooltip.SetDefault("Toggles a massive hoard of monsters");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 42;
            item.value = 100;
            item.rare = 1;
            item.useAnimation = 20;
            item.useTime = 20;
            item.useStyle = 4;

        }


        public override bool UseItem(Player player)
        {
            MyPlayer p = player.GetModPlayer<MyPlayer>();
            p.hoardCalled = !p.hoardCalled;
            if (p.hoardCalled)
            {
                Main.NewText("Prepare to perish", Colors.RarityRed);
            }
            else
            {
                Main.NewText("May peace be restored", Colors.RarityGreen);
            }
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ObsidianSkull);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddIngredient(ItemID.BattlePotion, 3);
            recipe.AddIngredient(ItemID.WaterCandle);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}