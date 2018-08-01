using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Ammo
{
	public class TideArrow : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tide Arrow");
            Tooltip.SetDefault("Unaffected by water");
        }
        public override void SetDefaults()
		{
			item.damage = 7;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 1;
			item.rare = 2;
			item.shoot = mod.ProjectileType("TideArrowProj");
			item.shootSpeed = 14f;
			item.ammo = AmmoID.Arrow;
		}
		
		public override void AddRecipes()
		{
			if(Caserraria.instance.thoriumLoaded)
			{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenArrow, 75);
			recipe.AddIngredient(ModLoader.GetMod("ThoriumMod").ItemType("AquaiteBar"));
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 75);
			recipe.AddRecipe();
			}
		}
	}
}