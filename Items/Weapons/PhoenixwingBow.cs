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
    public class PhoenixwingBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Phoenixwing Bow");
            Tooltip.SetDefault("Wooden arrows turn into phoenixes");
        }

        public override void SetDefaults()
        {
            item.damage = 42;
            item.ranged = true;
            item.width = 28;
            item.height = 58;
            item.useTime = 13;
            item.useAnimation = 13;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 3f;
            item.value = Item.sellPrice(gold: 8);
            item.rare = 8;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shoot = 1;
            item.shootSpeed = 13f;
            item.useAmmo = AmmoID.Arrow;
           
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20));
            speedX = perturbedSpeed.X;
            speedY = perturbedSpeed.Y;

            if (type == ProjectileID.WoodenArrowFriendly) // or ProjectileID.WoodenArrowFriendly
            {
                type = ProjectileID.DD2PhoenixBowShot; // or ProjectileID.FireArrow;
            }
            return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellwingBow);
            recipe.AddIngredient(ItemID.DD2PhoenixBow);
            recipe.AddIngredient(ItemID.Ectoplasm, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
