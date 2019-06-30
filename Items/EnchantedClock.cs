using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items
{
    public class EnchantedClock : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted Clock");
            Tooltip.SetDefault("Toggles the time between day and night");
        }

        public override void SetDefaults()
        {
            item.noMelee = true;
            item.width = 58;
            item.height = 58;
            item.value = Item.sellPrice(gold: 3);
            item.rare = 1;
            item.useTime = 20;
            item.useStyle = 5;
            item.useAnimation = 20;
            item.autoReuse = false;
            item.scale = 0.8f;
            item.useTurn = true;
        }

        public override bool UseItem(Player player)
        {
            Main.dayTime = (Main.dayTime) ? false : true;
            Main.time = 0;
            return true;
        }
    

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(7, 0);

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("MagicClock"), 1);
            recipe.AddIngredient(ItemID.SoulofLight, 5);
            recipe.AddIngredient(ItemID.SoulofNight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
