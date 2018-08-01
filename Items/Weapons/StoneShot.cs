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
	public class StoneShot : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stone Shot");
            Tooltip.SetDefault("Used by the most desperate gun users");
        }
        public override void SetDefaults()
		{
			item.damage = 0;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 1;
			item.rare = 0;
			item.shoot = 14;
			item.shootSpeed = 11f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
		}
	}
}