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
	public class FlowerTea : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lavender Tea");
            Tooltip.SetDefault("The petals are less gray in liquid form!" + Environment.NewLine + "A great beverage for builders of cosmetic variety!");
        }
        public override void SetDefaults()
		{
			item.useStyle = 2;
			item.useTime = 17;
			item.useAnimation = 17;
			item.UseSound = SoundID.Item3;
			item.value = 100;
			item.rare = 1;
			item.healLife = 60;
			item.maxStack = 30;
			item.consumable = true;
			item.potion = true;
		}

		public override void AddRecipes()
		{
			if(Caserraria.instance.cosmeticvarietyLoaded)
			{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(ModLoader.GetMod("CosmeticVariety").ItemType("WeirdlyColoredPetal"), 2);
			recipe.AddTile(TileID.Campfire);
			recipe.SetResult(this);
			recipe.AddRecipe();
			}
		}
	}
}