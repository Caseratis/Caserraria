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
	public class ShroomiteKnife : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Toxic Sporetip");
            Tooltip.SetDefault("Throw unlimited venom tipped shroomite knives" + Environment.NewLine + "Can inflict venom");
        }
        public override void SetDefaults()
		{
			item.damage = 48;
			item.thrown = true;
			item.noUseGraphic = true;
			item.width = 2;
			item.height = 2;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 1;
			item.value = 350000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("ShroomiteKnifeProj");
			item.shootSpeed = 22f;
		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Venom, 480);
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.VialofVenom, 5);
			recipe.AddIngredient(ItemID.ShroomiteBar, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
