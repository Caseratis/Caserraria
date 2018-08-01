using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Materials
{
	public class Unknownparts : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sacred Weapon Fragments");
            Tooltip.SetDefault("It is unknown what weapons these were");
        }
        public override void SetDefaults()
		{
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.value = 60000;
			item.rare = 8;
			item.expert = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.FragmentVortex, 25);
			recipe.AddIngredient(ItemID.FragmentSolar, 25);
			recipe.AddIngredient(ItemID.FragmentStardust, 25);
			recipe.AddIngredient(ItemID.FragmentNebula, 25);
			recipe.AddIngredient(ItemID.IllegalGunParts, 1);
			recipe.AddIngredient(ItemID.SuspiciousLookingTentacle, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}