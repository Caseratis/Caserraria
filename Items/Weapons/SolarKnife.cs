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
	public class SolarKnife : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dawnbringer");
            Tooltip.SetDefault("Throw unlimited solar knives" + Environment.NewLine + "'Strike down your foes with the knife of the sun'");
        }
        public override void SetDefaults()
		{
			item.damage = 65;
			item.thrown = true;
			item.noUseGraphic = true;
			item.width = 2;
			item.height = 2;
			item.useTime = 6;
			item.useAnimation = 6;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 1;
			item.value = 350000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("SolarKnifeProj");
			item.shootSpeed = 26f;
		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Daybreak, 300);
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 18);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
