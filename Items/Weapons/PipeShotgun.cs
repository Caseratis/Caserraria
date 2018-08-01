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
	public class PipeShotgun : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pipe Shotgun");
            Tooltip.SetDefault("Fires a spread of bullets" + Environment.NewLine + "How it shoots is nothing short of a miracle");
        }
        public override void SetDefaults()
		{
			item.damage = 4;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 105;
			item.useAnimation = 105;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 8;
			item.value = 1000;
			item.rare = 0;
			item.UseSound = SoundID.Item38;
			item.autoReuse = false;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 3 + Main.rand.Next(1);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 21);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 21);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
