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
	public class LunarFood : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Celestial Bites");
            Tooltip.SetDefault("The Moon Lord's favorite cereal!");
        }
        public override void SetDefaults()
		{
			item.useStyle = 2;
			item.useTime = 17;
			item.useAnimation = 17;
			item.UseSound = SoundID.Item2;
			item.value = 800;
			item.rare = 8;
			item.healLife = 225;
			item.maxStack = 30;
			item.consumable = true;
			item.potion = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bowl, 4);
			recipe.AddIngredient(ItemID.SuperHealingPotion, 1);
			recipe.AddIngredient(ItemID.LunarOre, 2);
			recipe.AddIngredient(ItemID.FragmentSolar, 2);
			recipe.AddIngredient(ItemID.FragmentVortex, 2);
			recipe.AddIngredient(ItemID.FragmentNebula, 2);
			recipe.AddIngredient(ItemID.FragmentStardust, 2);
			recipe.AddTile(TileID.CookingPots);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}