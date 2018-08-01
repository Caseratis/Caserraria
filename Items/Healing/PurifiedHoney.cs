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
	public class PurifiedHoney : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purified Honey");
        }
        public override void SetDefaults()
		{
			item.useStyle = 2;
			item.useTime = 17;
			item.useAnimation = 17;
			item.UseSound = SoundID.Item3;
			item.value = 150;
			item.rare = 1;
			item.healLife = 115;
			item.maxStack = 30;
			item.consumable = true;
			item.potion = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledHoney, 1);
			recipe.AddTile(TileID.Campfire);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}