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
	public class SubmarinersHarpoon : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Submariner's Harpoon");
            Tooltip.SetDefault("Unaffected by water");
        }
        public override void SetDefaults()
		{
			item.damage = 27;
			item.thrown = true;
			item.noUseGraphic = true;
			item.consumable = true;
			item.width = 2;
			item.height = 2;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 50;
			item.rare = 3;
			item.maxStack = 999;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType("SubmarinersHarpoonProj");
			item.shootSpeed = 9f;
		}
		
		public override void AddRecipes()
		{
			if(Caserraria.instance.thoriumLoaded)
			{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("AquaiteBar"));
			recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("DepthScale"));
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Javelin, 250);
			recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("AquaiteBar"));
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 250);
			recipe.AddRecipe();
			}
		}
	}
}
