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
	public class GrilledMushroom : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Grilled Mushroom");
        }
        public override void SetDefaults()
		{
			item.useStyle = 2;
			item.useTime = 17;
			item.useAnimation = 17;
			item.UseSound = SoundID.Item2;
			item.value = 5;
			item.rare = 0;
			item.healLife = 30;
			item.maxStack = 30;
			item.consumable = true;
			item.potion = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Mushroom, 1);
			recipe.AddTile(TileID.Campfire);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}