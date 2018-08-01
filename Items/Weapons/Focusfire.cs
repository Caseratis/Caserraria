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
	public class Focusfire : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Focusfire");
            Tooltip.SetDefault("Converts musket balls into Chlorophyte Bullets" + Environment.NewLine + "75% chance to not consume ammo");
        }
        public override void SetDefaults()
		{
			item.damage = 35;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 1;
			item.useAnimation = 3;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 35000000;
			item.rare = 4;
			item.UseSound = SoundID.Item41;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
			item.expert = true;
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() > .75f;
		}
		
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet)
			{
				type = ProjectileID.ChlorophyteBullet;
			}
			return true;
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
			recipe.AddIngredient(ModLoader.GetMod("CosmeticVariety").ItemType("Veridanite"), 30);
			}
			
			recipe.AddIngredient(null, "Unknownparts", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
