using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items
{
    public class MagicClock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Clock");
            Tooltip.SetDefault("Hold to accelerate time" + Environment.NewLine + "Only usable after the Eye of Cthulhu has been defeated");
        }

        public override void SetDefaults()
        {
            item.noMelee = true;
            item.width = 58;
            item.height = 58;
            item.value = Item.sellPrice(silver: 50);
            item.rare = 1;
            item.useTime = 0;
            item.useStyle = 5;
            item.useAnimation = 2;
            item.autoReuse = true;
            item.scale = 0.8f;
            item.useTurn = true;
        }

        public override bool UseItem(Player player)
        {
            if (NPC.downedBoss1 || NPC.downedBoss2 || NPC.downedBoss3 || Main.hardMode)
            {
                Main.time += 75;
                return true;
            }
            else {
                return false;
            }
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(7, 0);

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 5);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 5);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
