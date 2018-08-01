using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Caserraria.Items;

namespace Caserraria.Items.Weapons {
public class Moongazer : ModItem
{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Moongazer");
            Tooltip.SetDefault("Fires bundles of arrows" + Environment.NewLine + "Has a wide damage range");
        }

        public override void SetDefaults()
    {
        item.damage = 110;
        item.ranged = true;
        item.width = 24;
        item.height = 42;
        item.useTime = 10;
        item.useAnimation = 10;
        item.useStyle = 5;
        item.noMelee = true;
        item.knockBack = 4.5f;
        item.value = 35000000;
        item.rare = 7;
        item.UseSound = SoundID.Item88;
        item.autoReuse = true;
        item.shoot = 1;
        item.shootSpeed = 100f;
        item.useAmmo = AmmoID.Arrow;
		item.expert = true;
    }
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 1 + Main.rand.Next(10);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(2));
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
			recipe.AddIngredient(ModLoader.GetMod("CosmeticVariety").ItemType("Veridanite"), 30);
			}
			
			recipe.AddIngredient(null, "Unknownparts", 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
}}
