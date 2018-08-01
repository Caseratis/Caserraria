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
	public class MeldCereal : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ayy Lma-Os");
            Tooltip.SetDefault("Now with 50% more meld!" + Environment.NewLine + "Lunatic Cultists love it!");
        }
        public override void SetDefaults()
		{
			item.useStyle = 2;
			item.useTime = 17;
			item.useAnimation = 17;
			item.UseSound = SoundID.Item2;
			item.value = 800;
			item.rare = 8;
			item.healLife = 240;
			item.maxStack = 30;
			item.consumable = true;
			item.potion = true;
		}

		public override void AddRecipes()
		{
			if(Caserraria.instance.calamityLoaded)
			{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "LunarFood", 2);
			recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("MeldBlob"), 6);
			recipe.AddTile(TileID.CookingPots);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
			}
		}
	}
}