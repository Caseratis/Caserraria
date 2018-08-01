using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Weapons {
public class ChlorophyteComp : ModItem
{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chlorophyte Spreadshot");
        }

        public override void SetDefaults()
    {
        item.damage = 34;
        item.ranged = true;
        item.width = 24;
        item.height = 42;
        item.useTime = 19;
        item.useAnimation = 19;
        item.useStyle = 5;
        item.noMelee = true;
        item.knockBack = 2.75f;
        item.value = 240000;
        item.rare = 7;
        item.UseSound = SoundID.Item5;
        item.autoReuse = true;
        item.shoot = 1;
        item.shootSpeed = 11.5f;
        item.useAmmo = AmmoID.Arrow;
    }
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 2 + Main.rand.Next(3);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(8));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
        recipe.AddTile(TileID.MythrilAnvil);
        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}}
