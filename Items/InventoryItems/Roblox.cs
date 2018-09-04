using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Caserraria.Items.InventoryItems
{
    public class Roblox : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("OOF.mp3");
            Tooltip.SetDefault("Favorite to activate" + Environment.NewLine + "Makes you go OOF");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 30;
            item.value = Item.sellPrice(gold: 10);
            item.rare = 11;
        }

        public override void UpdateInventory(Player player)
        {
            if (item.favorited)
            {
                MyPlayer p = player.GetModPlayer<MyPlayer>();
                p.Oof = true;
            }


        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MusicBox);
            recipe.AddIngredient(ItemID.SoulofFright, 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
