using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Weapons
{
	public class Infernohand : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hand of Eruptions");
            Tooltip.SetDefault("Shoots chains of fireballs from your fingertips");
        }

        public override void SetDefaults()
		{
			item.damage = 165;
			item.magic = true;
			item.noUseGraphic = true;
			item.mana = 17;
			item.width = 40;
			item.height = 20;
			item.useTime = 8;
			item.useAnimation = 53;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 7;
			item.value = 35000000;
			item.rare = 4;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = 15;
			item.shootSpeed = 30f;
			item.expert = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 30);
			
			if(Caserraria.instance.thoriumLoaded)
			{
			recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("TerrariumCore"), 10);
			}
			
			if(Caserraria.instance.calamityLoaded)
			{
			recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("MeldiateBar"), 10);
			}
			
			if(Caserraria.instance.cosmeticvarietyLoaded)
			{
			recipe.AddIngredient(ModLoader.GetMod("CosmeticVariety").ItemType("Mantilum"), 30);
			}
			
			recipe.AddIngredient(null, "Unknownparts", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
