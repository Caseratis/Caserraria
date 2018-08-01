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
	public class MakeshiftFlintlock : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Makeshift Flintlock");
            Tooltip.SetDefault("A makeshift handgun, designed mainly for highwaymen." + Environment.NewLine + "Elusive, evasive, persistent. Righteous traits for a rogue.");
        }
        public override void SetDefaults()
		{
			item.damage = 7;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 44;
			item.useAnimation = 44;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 0;
			item.value = 500;
			item.rare = 0;
			item.UseSound = SoundID.Item11;
			item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
