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
	public class Decimation : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Decimation");
            Tooltip.SetDefault("Unleashes a burst of raging infernos");
            Item.staff[item.type] = true;
        }
        public override void SetDefaults()
		{
			item.damage = 85;
			item.magic = true;
			item.mana = 22;
			item.width = 40;
			item.height = 20;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 35000000;
			item.rare = 4;
			item.UseSound = SoundID.Item73;
			item.autoReuse = true;
			item.shoot = 295;
			item.shootSpeed = 25f;
			item.expert = true;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 8 + Main.rand.Next(8);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(25));
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
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
			recipe.AddIngredient(ModLoader.GetMod("CosmeticVariety").ItemType("Mantilum"), 30);
			}
			
			recipe.AddIngredient(null, "Unknownparts", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
