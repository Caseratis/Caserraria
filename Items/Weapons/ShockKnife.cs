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
	public class ShockKnife : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightning Knife");
            Tooltip.SetDefault("Throw unlimited knives at the speed of lightning!" + Environment.NewLine + "Stikes enemies with lightning");
        }
        public override void SetDefaults()
		{
			item.damage = 90;
			item.thrown = true;
			item.noUseGraphic = true;
			item.width = 2;
			item.height = 2;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 1;
			item.value = 500000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("ShockKnifeProj");
			item.shootSpeed = 30f;
			item.expert = true;
		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Electrified, 600);
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
			recipe.AddIngredient(ModLoader.GetMod("CosmeticVariety").ItemType("Chalchum"), 30);
			}
			
			recipe.AddIngredient(null, "Unknownparts", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
