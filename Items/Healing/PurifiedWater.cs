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
	public class PurifiedWater : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purified Water");
        }
        public override void SetDefaults()
		{
			item.useStyle = 2;
			item.useTime = 17;
			item.useAnimation = 17;
			item.UseSound = SoundID.Item3;
			item.value = 35;
			item.rare = 0;
			item.healLife = 40;
			item.maxStack = 30;
			item.consumable = true;
			item.potion = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddTile(TileID.Campfire);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}