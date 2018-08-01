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
	public class MeteorKnife : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Meteoric Shiv");
            Tooltip.SetDefault("Throw unlimited meteor shivs" + Environment.NewLine + "Can inflict On Fire");
        }
        public override void SetDefaults()
		{
			item.damage = 14;
			item.thrown = true;
			item.noUseGraphic = true;
			item.width = 2;
			item.height = 2;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 1;
			item.value = 4000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("MeteorKnifeProj");
			item.shootSpeed = 10f;
		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 60);
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteoriteBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
