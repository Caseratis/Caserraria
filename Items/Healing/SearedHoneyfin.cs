using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Healing
{
	public class SearedHoneyfin : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Honeyfin Steak");
            Tooltip.SetDefault("With extra pixie dust seasoning!");
        }
        public override void SetDefaults()
		{
			item.useStyle = 2;
			item.useTime = 17;
			item.useAnimation = 17;
			item.UseSound = SoundID.Item2;
			item.value = 800;
			item.rare = 3;
			item.healLife = 175;
			item.maxStack = 30;
			item.consumable = true;
			item.potion = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Honeyfin, 1);
			recipe.AddIngredient(ItemID.PixieDust, 5);
			recipe.AddTile(TileID.CookingPots);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}