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
	public class StalwartPotion : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stalwart Healing Potion");
        }
        public override void SetDefaults()
		{
			item.useStyle = 2;
			item.useTime = 17;
			item.useAnimation = 17;
			item.UseSound = SoundID.Item3;
			item.value = 100000;
			item.rare = 9;
			item.healLife = 300;
			item.maxStack = 30;
			item.consumable = true;
			item.potion = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SuperHealingPotion, 6);
			recipe.AddIngredient(ItemID.LifeFruit, 1);
			recipe.AddIngredient(ItemID.LunarOre, 5);
			
			if(Caserraria.instance.thoriumLoaded)
			{
			recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("BioMatter"), 4);
			}
			
			if(Caserraria.instance.calamityLoaded)
			{
			recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("LivingShard"), 2);
			}
			
			if(Caserraria.instance.cosmeticvarietyLoaded)
			{
			recipe.AddIngredient(ModLoader.GetMod("CosmeticVariety").ItemType("StarlightOre"), 2);
			recipe.AddIngredient(ModLoader.GetMod("CosmeticVariety").ItemType("Veridanite"), 2);
			recipe.AddIngredient(ModLoader.GetMod("CosmeticVariety").ItemType("Chalchum"), 2);
			}
			
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
	}
}